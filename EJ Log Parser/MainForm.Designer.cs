namespace EJ_Log_Parser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fBD = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_path = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_sall = new System.Windows.Forms.Button();
            this.btn_process = new System.Windows.Forms.Button();
            this.dg_files = new System.Windows.Forms.DataGridView();
            this.colCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_dsall = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_files)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btn_path);
            this.groupBox1.Controls.Add(this.tb_path);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a path:";
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(321, 18);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(104, 23);
            this.btn_path.TabIndex = 1;
            this.btn_path.Text = "Choose a path";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(7, 20);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(308, 20);
            this.tb_path.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btn_dsall);
            this.groupBox2.Controls.Add(this.btn_sall);
            this.groupBox2.Controls.Add(this.btn_process);
            this.groupBox2.Controls.Add(this.dg_files);
            this.groupBox2.Location = new System.Drawing.Point(13, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 196);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acquired files:";
            // 
            // btn_sall
            // 
            this.btn_sall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_sall.Location = new System.Drawing.Point(212, 164);
            this.btn_sall.Name = "btn_sall";
            this.btn_sall.Size = new System.Drawing.Size(103, 23);
            this.btn_sall.TabIndex = 2;
            this.btn_sall.Text = "Select All";
            this.btn_sall.UseVisualStyleBackColor = true;
            this.btn_sall.Click += new System.EventHandler(this.btn_sall_Click);
            // 
            // btn_process
            // 
            this.btn_process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_process.Location = new System.Drawing.Point(321, 164);
            this.btn_process.Name = "btn_process";
            this.btn_process.Size = new System.Drawing.Size(103, 23);
            this.btn_process.TabIndex = 1;
            this.btn_process.Text = "Process";
            this.btn_process.UseVisualStyleBackColor = true;
            this.btn_process.Click += new System.EventHandler(this.btn_process_Click);
            // 
            // dg_files
            // 
            this.dg_files.AllowUserToAddRows = false;
            this.dg_files.AllowUserToDeleteRows = false;
            this.dg_files.AllowUserToResizeRows = false;
            this.dg_files.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_files.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_files.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCheck,
            this.colFileName,
            this.colCreatedDate,
            this.colSize});
            this.dg_files.Location = new System.Drawing.Point(7, 20);
            this.dg_files.Name = "dg_files";
            this.dg_files.Size = new System.Drawing.Size(418, 137);
            this.dg_files.TabIndex = 0;
            // 
            // colCheck
            // 
            this.colCheck.FalseValue = "false";
            this.colCheck.HeaderText = "";
            this.colCheck.Name = "colCheck";
            this.colCheck.ReadOnly = true;
            this.colCheck.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colCheck.TrueValue = "true";
            this.colCheck.Width = 20;
            // 
            // colFileName
            // 
            this.colFileName.HeaderText = "Filename";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // colCreatedDate
            // 
            this.colCreatedDate.HeaderText = "Created";
            this.colCreatedDate.Name = "colCreatedDate";
            this.colCreatedDate.ReadOnly = true;
            // 
            // colSize
            // 
            this.colSize.HeaderText = "Size";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            // 
            // btn_dsall
            // 
            this.btn_dsall.Location = new System.Drawing.Point(212, 164);
            this.btn_dsall.Name = "btn_dsall";
            this.btn_dsall.Size = new System.Drawing.Size(103, 23);
            this.btn_dsall.TabIndex = 3;
            this.btn_dsall.Text = "Deselect All";
            this.btn_dsall.UseVisualStyleBackColor = true;
            this.btn_dsall.Click += new System.EventHandler(this.btn_dsall_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 289);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "EJ Log Parser";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_files)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fBD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_files;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.Button btn_process;
        private System.Windows.Forms.Button btn_sall;
        private System.Windows.Forms.Button btn_dsall;
    }
}

