using SBEReflection.Classes;
using SBEReflection.Loaders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace MessageGenerator
{
    public partial class MainForm : Form
    {
        #region VARIABLES
        bool _Connected = false;
        string _Server = "127.0.0.1";
        Int32 _Port = 13000;
        TcpClient _Client;
        NetworkStream _Stream;
        SBEReflection.SbeReflectionWrapper _Wrapper;
        const string _SbeFile = @"C:\Users\Akio\source\repos\POC_SBE\fixp-entrypoint-messages-1.2\bin\Debug\fixp-entrypoint-messages-1.2.dll";
        List<SbeMessage> _Message;
        #endregion

        public MainForm()
        {
            InitializeComponent();
            txtHost.Text = _Server;
            numPort.Value = _Port;
            _Message = new List<SbeMessage>();
            LoadTree();

            _Wrapper = new SBEReflection.SbeReflectionWrapper(_SbeFile);
        }

        public void UpdateConnectionState(bool connected)
        {
            if (connected)
            {
                btnConnect.Text = "Disconnect";
                lblConnectionStatus.Text = "Connected";
                lblConnectionStatus.ForeColor = Color.Green;
                btnSend.Enabled = true;
            }
            else
            {
                btnConnect.Text = "Connect";
                lblConnectionStatus.Text = "Disconnected";
                lblConnectionStatus.ForeColor = Color.Black;
                btnSend.Enabled = false;
            }
        }

        public void LoadTree()
        {
            this.tree.CanExpandGetter = delegate (object x)
            {
                if (x is SbeMessage)
                    return true;
                if (x is SbeField)
                    return (((SbeField)x).Fields != null && ((SbeField)x).Fields.Count > 0);
                return false;
            };

            this.tree.ChildrenGetter = delegate (object x)
            {
                if (x is SbeMessage)
                    return ((SbeMessage)x).Fields;
                if (x is SbeField)
                    return ((SbeField)x).Fields;
                return null;
            };

            this.colName.AspectGetter = delegate (object x)
            {
                if (x is SbeMessage) return ((SbeMessage)x).Name;
                else if (x is SbeField) return ((SbeField)x).Name;
                return null;
            };

            this.coldId.AspectGetter = delegate (object x)
            {
                if (x is SbeMessage) return ((SbeMessage)x).Id;
                else if (x is SbeField) return ((SbeField)x).Id;
                return null;
            };

            this.colType.AspectGetter = delegate (object x)
            {
                if (x is SbeMessage) return "";
                else if (x is SbeField) return ((SbeField)x).Type;
                return null;
            };

            this.colPresence.AspectGetter = delegate (object x)
            {
                if (x is SbeMessage) return "";
                else if (x is SbeField) return ((SbeField)x).Presence;
                return null;
            };

            this.colValueRef.AspectGetter = delegate (object x)
            {
                if (x is SbeMessage) return "";
                else if (x is SbeField) return ((SbeField)x).ValueRef;
                return null;
            };

            this.colPrimitiveType.AspectGetter = delegate (object x)
            {
                if (x is SbeMessage) return "";
                else if (x is SbeField) return ((SbeField)x).PrimitiveType;
                return null;
            };

            this.colValue.AspectGetter = delegate (object x)
            {
                if (x is SbeMessage) return "";
                else if (x is SbeField) return ((SbeField)x).Value;
                return null;
            };

            this.colOffset.AspectGetter = delegate (object x)
            {
                if (x is SbeMessage) return "";
                else if (x is SbeField) return ((SbeField)x).Offset;
                return null;
            };


            this.colLength.AspectGetter = delegate (object x)
            {
                if (x is SbeMessage) return "";
                else if (x is SbeField) return ((SbeField)x).Length;
                return null;
            };

            this.colEncoding.AspectGetter = delegate (object x)
            {
                if (x is SbeMessage) return "";
                else if (x is SbeField) return ((SbeField)x).CharacterEncoding;
                return null;
            };
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecione o dicionário SBE";
            ofd.InitialDirectory = Application.ExecutablePath;
            ofd.Filter = "Arquivo XML|*.xml";
            ofd.CheckFileExists = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFileName.Text = ofd.FileName;
                SbeLoader.Load(txtFileName.Text);

                if (SbeLoader._Messages.Count > 0)
                {
                    cbMessages.Enabled = true;
                    SbeLoader._Messages.ForEach(x => cbMessages.Items.Add(x));
                }
            }
        }

        private void cbMessages_SelectedIndexChanged(object sender, EventArgs e)
        {
            SbeMessage message = SbeLoader.LoadMessageByName(cbMessages.Text);
            if (message != null)
            {
                tree.BeginUpdate();
                lblDescription.Text = "Description: " + message.Description;
                lblId.Text = "ID: " + message.Id;
                _Message.Clear();
                _Message.Add(message);
                if (checkBox1.Checked)
                    CreateHeader();
                tree.Roots = _Message;
                tree.ExpandAll();
                tree.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                colValue.Width = 100;
                tree.EndUpdate();
            }
            else
            {
                lblDescription.Text = "Description:";
                lblId.Text = "ID:";
                tree.Clear();
            }
        }

        private void tree_CellEditStarting(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.RowObject is SbeField)
            {
                SbeField f = (SbeField)e.RowObject;

                if ((f.Presence.Equals("constant") && !checkBox1.Checked) || (f.Fields != null && f.Fields.Count > 0 && !f.Type.ToLower().Equals("groupsizeencoding")))
                {
                    e.Cancel = true;
                    return;
                }
                else
                {
                    if (e.Column.Text == "Value")
                    {
                        if (SbeLoader._Enums.Find(x => x.Name == f.Type) != null)
                        {
                            ComboBox cb = new ComboBox();
                            cb.Bounds = e.CellBounds;
                            cb.Items.Add("");

                            SbeEnum enu = SbeLoader._Enums.Find(x => x.Name == f.Type);
                            enu.ValidValues.ForEach(x => cb.Items.Add(x.Value + " | " + x.Name));

                            cb.Text = f.Value;
                            e.Control = cb;
                        }
                        else
                        {
                            TextBox tb = new TextBox();
                            tb.Bounds = e.CellBounds;
                            tb.Text = f.Value;
                            e.Control = tb;
                        }
                    }
                    else if (e.Column.Text == "PrimitiveType")
                    {
                        ComboBox cb = new ComboBox();
                        cb.Bounds = e.CellBounds;
                        cb.Items.Add("");

                        foreach (SbeLoader.PrimitiveType p in Enum.GetValues(typeof(SbeLoader.PrimitiveType)))
                        {
                            cb.Items.Add(p.ToString().ToLower());
                        }

                        cb.Text = f.PrimitiveType;
                        e.Control = cb;
                    }
                    else if (e.Column.Text == "Length")
                    {
                        if (e.RowObject is SbeField)
                        {
                            if (((SbeField)e.RowObject).PrimitiveType == "char")
                            {
                                TextBox tb = new TextBox();
                                tb.Bounds = e.CellBounds;
                                tb.Text = f.Length.ToString();
                                e.Control = tb;
                            }
                        }
                    }
                }
            }
            else
            {
                e.Cancel = true;
                return;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                _Server = txtHost.Text;
                _Port = (int)numPort.Value;

                try
                {
                    _Client = new TcpClient(_Server, _Port);
                    _Stream = _Client.GetStream();
                    _Connected = _Client.Connected;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    _Stream.Close();
                    _Client.Close();
                }
                catch { }
                _Connected = false;
            }

            UpdateConnectionState(_Connected);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (_Message.Count > 0)
                {
                    if (!checkBox1.Checked)
                    {
                        //SBE Engine
                        byte[] reflection = _Wrapper.EncodeSBEMessage(_Message[0]);
                        _Stream.Write(reflection, 0, reflection.Length);
                    }
                    else
                    {
                        byte[] reflection = _Wrapper.EncodeSBEMessageQATEngine(_Message);
                        _Stream.Write(reflection, 0, reflection.Length);
                    }
                }
                else
                {
                    MessageBox.Show("Select a message first!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tree_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Cancel)
                return;

            SbeField field = (SbeField)e.RowObject;
            if (e.Control is ComboBox)
            {
                if (e.Column.Text == "PrimitiveType")
                {
                    field.PrimitiveType = e.Control.Text.Trim();
                    switch (field.PrimitiveType)
                    {
                        case "uint8":
                        case "int8":
                            field.Length = 1;
                            break;
                        case "uint16":
                        case "int16":
                            field.Length = 2;
                            break;
                        case "uint32":
                        case "int32":
                            field.Length = 4;
                            break;
                        case "uint64":
                        case "int64":
                            field.Length = 8;
                            break;
                        case "char":
                            field.Length = 10;
                            break;
                    }
                }
                else if (e.Column.Text == "Value")
                {
                    if (e.Control.Text.Contains("|"))
                    {
                        field.Value = e.Control.Text.Split('|')[0].Trim();
                    }
                    else
                    {
                        field.Value = e.Control.Text.Trim();
                    }
                }
            }
            else if (e.Control is TextBox)
            {
                if (e.Column.Text == "Value")
                {
                    field.Value = e.Control.Text.Trim();
                }
                else if (e.Column.Text == "Length")
                {
                    field.Length = int.Parse(e.Control.Text.Trim());
                }
            }

            if (field.Type.ToLower().Equals("groupsizeencoding"))
            {
                try
                {
                    int repeating = int.Parse(field.Value);
                    int repeatingGroupAtual = field.Fields.FindAll(x => x.Name == field.Fields[0].Name).Count;
                    SbeMessage _Original = null;
                    if (checkBox1.Checked)
                        _Original = SbeLoader.LoadMessageByName(_Message[1].Name);
                    else
                        _Original = SbeLoader.LoadMessageByName(_Message[0].Name);

                    SbeField _OriginalField = _Original.Fields.Find(x => x.Name == field.Name).Clone();

                    if (repeating > repeatingGroupAtual)
                    {
                        while (repeating > repeatingGroupAtual)
                        {
                            SbeField _FieldOriginal = _OriginalField.Clone();
                            field.Fields.AddRange(_FieldOriginal.Fields);
                            repeatingGroupAtual = field.Fields.FindAll(x => x.Name == field.Fields[0].Name).Count;
                        }
                    }
                    else if (repeating < repeatingGroupAtual)
                    {
                        while (repeating < repeatingGroupAtual)
                        {
                            foreach (SbeField _ChildField in _OriginalField.Fields)
                            {
                                SbeField toRemove = field.Fields.FindLast(x => x.Name == _ChildField.Name);
                                field.Fields.Remove(toRemove);
                            }

                            repeatingGroupAtual = field.Fields.FindAll(x => x.Name == field.Fields[0].Name).Count;
                        }
                    }
                    tree.Roots = _Message;
                    tree.ExpandAll();
                }
                catch
                {
                }
            }

            tree.RefreshItem(e.ListViewItem);
            e.Cancel = true;
        }

        private void tree_FormatRow(object sender, BrightIdeasSoftware.FormatRowEventArgs e)
        {
            if (e.Model is SbeField)
            {
                SbeField field = (SbeField)e.Model;
                if (field.Presence.ToLower().Equals("constant"))
                {
                    e.Item.BackColor = Color.LightGray;
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            txtFileName.Text = @"C:\Users\Akio\source\repos\POC_SBE\packages\sbe-tool.1.17.0\tools\fixp-entrypoint-messages-1.2.xml";
            SbeLoader.Load(txtFileName.Text);

            if (SbeLoader._Messages.Count > 0)
            {
                cbMessages.Enabled = true;
                SbeLoader._Messages.ForEach(x => cbMessages.Items.Add(x));
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMessages.SelectedItem != null)
            {
                colLength.IsEditable = checkBox1.Checked;

                if (checkBox1.Checked)
                {
                    CreateHeader();
                }
                else
                {
                    if (_Message.Count == 2)
                        _Message.RemoveAt(0);
                }
                tree.Roots = _Message;
                tree.ExpandAll();

                colPrimitiveType.IsEditable = checkBox1.Checked;
                colLength.IsEditable = checkBox1.Checked;
            }
        }

        private void CreateHeader()
        {
            SbeMessage mh = new SbeMessage();
            mh.Name = "Message Header";

            SbeField f = new SbeField();
            f.Name = "blockLength";
            f.Length = 2;
            f.Type = "uint16";
            f.PrimitiveType = "uint16";
            f.Offset = 0;
            f.Presence = "";

            mh.Fields.Insert(0, f);

            SbeField f2 = new SbeField();
            f2.Name = "TemplateId";
            f2.Length = 2;
            f2.Type = "uint16";
            f2.PrimitiveType = "uint16";
            f2.Offset = 2;
            f2.Presence = "";
            f2.Value = _Message[0].Id;

            mh.Fields.Insert(1, f2);


            SbeField f3 = new SbeField();
            f3.Name = "SchemaId";
            f3.Length = 2;
            f3.Type = "uint16";
            f3.PrimitiveType = "uint16";
            f3.Offset = 4;
            f3.Presence = "";

            mh.Fields.Insert(2, f3);

            SbeField f4 = new SbeField();
            f4.Name = "Version";
            f4.Length = 2;
            f4.Type = "uint16";
            f4.PrimitiveType = "uint16";
            f4.Offset = 6;
            f4.Presence = "";

            mh.Fields.Insert(3, f4);
            _Message.Insert(0, mh);
        }
    }
}
