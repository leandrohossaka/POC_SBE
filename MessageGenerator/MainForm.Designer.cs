namespace MessageGenerator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.tree = new BrightIdeasSoftware.TreeListView();
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.coldId = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colValue = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colLength = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPrimitiveType = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colPresence = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colValueRef = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colOffset = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cbMessages = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.numPort = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.colEncoding = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.tree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "XML:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(67, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(564, 22);
            this.txtFileName.TabIndex = 1;
            // 
            // btnLoadFile
            // 
            this.btnLoadFile.Location = new System.Drawing.Point(637, 8);
            this.btnLoadFile.Name = "btnLoadFile";
            this.btnLoadFile.Size = new System.Drawing.Size(30, 30);
            this.btnLoadFile.TabIndex = 2;
            this.btnLoadFile.Text = "...";
            this.btnLoadFile.UseVisualStyleBackColor = true;
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);
            // 
            // tree
            // 
            this.tree.AllColumns.Add(this.colName);
            this.tree.AllColumns.Add(this.coldId);
            this.tree.AllColumns.Add(this.colValue);
            this.tree.AllColumns.Add(this.colType);
            this.tree.AllColumns.Add(this.colLength);
            this.tree.AllColumns.Add(this.colPrimitiveType);
            this.tree.AllColumns.Add(this.colPresence);
            this.tree.AllColumns.Add(this.colValueRef);
            this.tree.AllColumns.Add(this.colOffset);
            this.tree.AllColumns.Add(this.colEncoding);
            this.tree.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.SingleClick;
            this.tree.CellEditUseWholeCell = false;
            this.tree.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.coldId,
            this.colValue,
            this.colType,
            this.colLength,
            this.colPrimitiveType,
            this.colPresence,
            this.colValueRef,
            this.colOffset,
            this.colEncoding});
            this.tree.Cursor = System.Windows.Forms.Cursors.Default;
            this.tree.FullRowSelect = true;
            this.tree.HideSelection = false;
            this.tree.Location = new System.Drawing.Point(12, 125);
            this.tree.Name = "tree";
            this.tree.ShowGroups = false;
            this.tree.Size = new System.Drawing.Size(1041, 631);
            this.tree.TabIndex = 3;
            this.tree.UseCompatibleStateImageBehavior = false;
            this.tree.View = System.Windows.Forms.View.Details;
            this.tree.VirtualMode = true;
            this.tree.CellEditFinishing += new BrightIdeasSoftware.CellEditEventHandler(this.tree_CellEditFinishing);
            this.tree.CellEditStarting += new BrightIdeasSoftware.CellEditEventHandler(this.tree_CellEditStarting);
            this.tree.FormatRow += new System.EventHandler<BrightIdeasSoftware.FormatRowEventArgs>(this.tree_FormatRow);
            // 
            // colName
            // 
            this.colName.Groupable = false;
            this.colName.IsEditable = false;
            this.colName.Sortable = false;
            this.colName.Text = "Name";
            // 
            // coldId
            // 
            this.coldId.IsEditable = false;
            this.coldId.Sortable = false;
            this.coldId.Text = "ID";
            // 
            // colValue
            // 
            this.colValue.Sortable = false;
            this.colValue.Text = "Value";
            this.colValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colValue.Width = 100;
            // 
            // colType
            // 
            this.colType.IsEditable = false;
            this.colType.Sortable = false;
            this.colType.Text = "Type";
            // 
            // colLength
            // 
            this.colLength.IsEditable = false;
            this.colLength.Sortable = false;
            this.colLength.Text = "Length";
            this.colLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // colPrimitiveType
            // 
            this.colPrimitiveType.IsEditable = false;
            this.colPrimitiveType.Sortable = false;
            this.colPrimitiveType.Text = "PrimitiveType";
            // 
            // colPresence
            // 
            this.colPresence.IsEditable = false;
            this.colPresence.Sortable = false;
            this.colPresence.Text = "Presence";
            // 
            // colValueRef
            // 
            this.colValueRef.IsEditable = false;
            this.colValueRef.Sortable = false;
            this.colValueRef.Text = "ValueRef";
            // 
            // colOffset
            // 
            this.colOffset.IsEditable = false;
            this.colOffset.Sortable = false;
            this.colOffset.Text = "Offset";
            // 
            // cbMessages
            // 
            this.cbMessages.Enabled = false;
            this.cbMessages.FormattingEnabled = true;
            this.cbMessages.Location = new System.Drawing.Point(117, 53);
            this.cbMessages.Name = "cbMessages";
            this.cbMessages.Size = new System.Drawing.Size(514, 24);
            this.cbMessages.TabIndex = 4;
            this.cbMessages.SelectedIndexChanged += new System.EventHandler(this.cbMessages_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Message:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.Location = new System.Drawing.Point(12, 90);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(31, 20);
            this.lblId.TabIndex = 6;
            this.lblId.Text = "ID:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(154, 90);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 20);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(729, 43);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(113, 30);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // numPort
            // 
            this.numPort.Location = new System.Drawing.Point(973, 13);
            this.numPort.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numPort.Name = "numPort";
            this.numPort.Size = new System.Drawing.Size(80, 22);
            this.numPort.TabIndex = 10;
            this.numPort.Value = new decimal(new int[] {
            13000,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(922, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Port:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(673, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Host:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(729, 12);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(187, 22);
            this.txtHost.TabIndex = 13;
            this.txtHost.Text = "127.0.0.1";
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectionStatus.Location = new System.Drawing.Point(848, 44);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(160, 29);
            this.lblConnectionStatus.TabIndex = 14;
            this.lblConnectionStatus.Text = "Disconnected";
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(867, 89);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(186, 30);
            this.btnSend.TabIndex = 15;
            this.btnSend.Text = "Send Message";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(637, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(138, 21);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "QAT SBE Engine";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // colEncoding
            // 
            this.colEncoding.Text = "Encoding";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 768);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.lblConnectionStatus);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numPort);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbMessages);
            this.Controls.Add(this.tree);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnLoadFile;
        private BrightIdeasSoftware.TreeListView tree;
        private BrightIdeasSoftware.OLVColumn colName;
        private BrightIdeasSoftware.OLVColumn coldId;
        private BrightIdeasSoftware.OLVColumn colType;
        private System.Windows.Forms.ComboBox cbMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblDescription;
        private BrightIdeasSoftware.OLVColumn colValue;
        private BrightIdeasSoftware.OLVColumn colPresence;
        private BrightIdeasSoftware.OLVColumn colValueRef;
        private BrightIdeasSoftware.OLVColumn colPrimitiveType;
        private BrightIdeasSoftware.OLVColumn colOffset;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.NumericUpDown numPort;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.Button btnSend;
        private BrightIdeasSoftware.OLVColumn colLength;
        private System.Windows.Forms.CheckBox checkBox1;
        private BrightIdeasSoftware.OLVColumn colEncoding;
    }
}