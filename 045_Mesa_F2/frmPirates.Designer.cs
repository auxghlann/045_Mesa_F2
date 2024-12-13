namespace _045_Mesa_F2
{
    partial class frmPirates
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
            this.grdData = new System.Windows.Forms.DataGridView();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.cboSearchPirateGroup = new System.Windows.Forms.ComboBox();
            this.btnSearchPirate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAlias = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBounty = new System.Windows.Forms.TextBox();
            this.cboPirateGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNewRecord = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdData
            // 
            this.grdData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdData.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdData.Location = new System.Drawing.Point(41, 94);
            this.grdData.Name = "grdData";
            this.grdData.ReadOnly = true;
            this.grdData.RowHeadersVisible = false;
            this.grdData.RowHeadersWidth = 51;
            this.grdData.RowTemplate.Height = 24;
            this.grdData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdData.Size = new System.Drawing.Size(670, 394);
            this.grdData.TabIndex = 0;
            this.grdData.SelectionChanged += new System.EventHandler(this.grdData_SelectionChanged);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(41, 52);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(296, 22);
            this.txtKeyword.TabIndex = 1;
            // 
            // cboSearchPirateGroup
            // 
            this.cboSearchPirateGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchPirateGroup.FormattingEnabled = true;
            this.cboSearchPirateGroup.Location = new System.Drawing.Point(370, 51);
            this.cboSearchPirateGroup.Name = "cboSearchPirateGroup";
            this.cboSearchPirateGroup.Size = new System.Drawing.Size(176, 24);
            this.cboSearchPirateGroup.TabIndex = 2;
            // 
            // btnSearchPirate
            // 
            this.btnSearchPirate.Location = new System.Drawing.Point(566, 45);
            this.btnSearchPirate.Name = "btnSearchPirate";
            this.btnSearchPirate.Size = new System.Drawing.Size(113, 36);
            this.btnSearchPirate.TabIndex = 3;
            this.btnSearchPirate.Text = "Search Pirate";
            this.btnSearchPirate.UseVisualStyleBackColor = true;
            this.btnSearchPirate.Click += new System.EventHandler(this.btnSearchPirate_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(41, 507);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(113, 36);
            this.btnView.TabIndex = 4;
            this.btnView.Text = "View Details";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 507);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(154, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete Pirate Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnNewRecord);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboPirateGroup);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBounty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtAlias);
            this.groupBox1.Location = new System.Drawing.Point(743, 94);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 394);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pirate Information";
            // 
            // txtAlias
            // 
            this.txtAlias.Location = new System.Drawing.Point(114, 75);
            this.txtAlias.Name = "txtAlias";
            this.txtAlias.Size = new System.Drawing.Size(233, 22);
            this.txtAlias.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 119);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(233, 22);
            this.txtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(114, 166);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(233, 22);
            this.txtAge.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Bounty";
            // 
            // txtBounty
            // 
            this.txtBounty.Location = new System.Drawing.Point(114, 250);
            this.txtBounty.Name = "txtBounty";
            this.txtBounty.Size = new System.Drawing.Size(233, 22);
            this.txtBounty.TabIndex = 6;
            // 
            // cboPirateGroup
            // 
            this.cboPirateGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPirateGroup.FormattingEnabled = true;
            this.cboPirateGroup.Location = new System.Drawing.Point(114, 206);
            this.cboPirateGroup.Name = "cboPirateGroup";
            this.cboPirateGroup.Size = new System.Drawing.Size(233, 24);
            this.cboPirateGroup.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pirate Group";
            // 
            // btnNewRecord
            // 
            this.btnNewRecord.Location = new System.Drawing.Point(31, 323);
            this.btnNewRecord.Name = "btnNewRecord";
            this.btnNewRecord.Size = new System.Drawing.Size(113, 30);
            this.btnNewRecord.TabIndex = 7;
            this.btnNewRecord.Text = "New Record";
            this.btnNewRecord.UseVisualStyleBackColor = true;
            this.btnNewRecord.Click += new System.EventHandler(this.btnNewRecord_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(154, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(273, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 30);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name Keyword";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Pirate Group";
            // 
            // frmPirates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 564);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnSearchPirate);
            this.Controls.Add(this.cboSearchPirateGroup);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.grdData);
            this.MaximizeBox = false;
            this.Name = "frmPirates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pirate Record";
            this.Load += new System.EventHandler(this.frmPirates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.ComboBox cboSearchPirateGroup;
        private System.Windows.Forms.Button btnSearchPirate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnNewRecord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboPirateGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBounty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

