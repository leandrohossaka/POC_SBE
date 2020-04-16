using SBEReflection.Classes;
using SBEReflection.Loaders;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Net.Sockets;
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
                if (f.Presence.Equals("constant") || (f.Fields != null && f.Fields.Count > 0 && !f.Type.ToLower().Equals("groupsizeencoding")))
                {
                    e.Cancel = true;
                    return;
                }
                else
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
            if (_Message.Count > 0)
            {
                byte[] reflection = _Wrapper.EncodeSBEMessage(_Message[0]);
                _Stream.Write(reflection, 0, reflection.Length);
            }
            else
            {
                MessageBox.Show("Select a message first!");
            }
        }

        private void tree_CellEditFinishing(object sender, BrightIdeasSoftware.CellEditEventArgs e)
        {
            if (e.Cancel)
                return;

            SbeField field = (SbeField)e.RowObject;
            if (e.Control is ComboBox)
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
            else if (e.Control is TextBox)
            {
                field.Value = e.Control.Text.Trim();
            }

            if (field.Type.ToLower().Equals("groupsizeencoding"))
            {
                try
                {
                    int repeating = int.Parse(field.Value);
                    int repeatingGroupAtual = field.Fields.FindAll(x => x.Name == field.Fields[0].Name).Count;
                    SbeMessage _Original = SbeLoader.LoadMessageByName(_Message[0].Name);
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
    }
}
