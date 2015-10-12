namespace EJ_Log_Parser
{
    partial class LogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dg_msg = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOperID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pB1 = new System.Windows.Forms.ProgressBar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_to = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_from = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dg_err = new System.Windows.Forms.DataGridView();
            this.cPairId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEndId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSpan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_nwt = new System.Windows.Forms.Label();
            this.lb_nwt1 = new System.Windows.Forms.Label();
            this.lb_wt = new System.Windows.Forms.Label();
            this.lb_wt1 = new System.Windows.Forms.Label();
            this.lb_totalerr = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_totaloper = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_nwp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_wp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_msg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_err)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dg_msg);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 285);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acquired messages:";
            // 
            // dg_msg
            // 
            this.dg_msg.AllowUserToAddRows = false;
            this.dg_msg.AllowUserToDeleteRows = false;
            this.dg_msg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_msg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_msg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cOperID,
            this.cDate,
            this.cType,
            this.cLog});
            this.dg_msg.Location = new System.Drawing.Point(7, 20);
            this.dg_msg.Name = "dg_msg";
            this.dg_msg.ReadOnly = true;
            this.dg_msg.Size = new System.Drawing.Size(654, 259);
            this.dg_msg.TabIndex = 0;
            // 
            // cId
            // 
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            this.cId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cId.Width = 35;
            // 
            // cOperID
            // 
            this.cOperID.HeaderText = "Operation ID";
            this.cOperID.Name = "cOperID";
            this.cOperID.ReadOnly = true;
            this.cOperID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cOperID.Width = 70;
            // 
            // cDate
            // 
            this.cDate.HeaderText = "Date";
            this.cDate.Name = "cDate";
            this.cDate.ReadOnly = true;
            this.cDate.Width = 125;
            // 
            // cType
            // 
            this.cType.HeaderText = "Type";
            this.cType.Name = "cType";
            this.cType.ReadOnly = true;
            this.cType.Width = 150;
            // 
            // cLog
            // 
            this.cLog.HeaderText = "Log File";
            this.cLog.Name = "cLog";
            this.cLog.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pB1);
            this.groupBox2.Location = new System.Drawing.Point(13, 304);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(667, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Availability:";
            // 
            // pB1
            // 
            this.pB1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pB1.BackColor = System.Drawing.Color.Red;
            this.pB1.ForeColor = System.Drawing.Color.Lime;
            this.pB1.Location = new System.Drawing.Point(7, 20);
            this.pB1.Name = "pB1";
            this.pB1.Size = new System.Drawing.Size(654, 23);
            this.pB1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pB1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.lb_nwp);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lb_wp);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.lb_to);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lb_from);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.dg_err);
            this.groupBox3.Controls.Add(this.lb_nwt);
            this.groupBox3.Controls.Add(this.lb_nwt1);
            this.groupBox3.Controls.Add(this.lb_wt);
            this.groupBox3.Controls.Add(this.lb_wt1);
            this.groupBox3.Controls.Add(this.lb_totalerr);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lb_totaloper);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(13, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 283);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Availability details:";
            // 
            // lb_to
            // 
            this.lb_to.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_to.AutoSize = true;
            this.lb_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_to.Location = new System.Drawing.Point(280, 88);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(41, 13);
            this.lb_to.TabIndex = 13;
            this.lb_to.Text = "label5";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Working To:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_from
            // 
            this.lb_from.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_from.AutoSize = true;
            this.lb_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_from.Location = new System.Drawing.Point(280, 65);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(41, 13);
            this.lb_from.TabIndex = 11;
            this.lb_from.Text = "label7";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Working From:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Error Details:";
            // 
            // dg_err
            // 
            this.dg_err.AllowUserToAddRows = false;
            this.dg_err.AllowUserToDeleteRows = false;
            this.dg_err.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg_err.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_err.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cPairId,
            this.cEventType,
            this.cStartID,
            this.cStartDate,
            this.cEndId,
            this.cEndDate,
            this.cSpan});
            this.dg_err.Location = new System.Drawing.Point(7, 124);
            this.dg_err.Name = "dg_err";
            this.dg_err.ReadOnly = true;
            this.dg_err.Size = new System.Drawing.Size(654, 153);
            this.dg_err.TabIndex = 8;
            // 
            // cPairId
            // 
            this.cPairId.HeaderText = "Pair ID";
            this.cPairId.Name = "cPairId";
            this.cPairId.ReadOnly = true;
            this.cPairId.Width = 45;
            // 
            // cEventType
            // 
            this.cEventType.HeaderText = "Event Type";
            this.cEventType.Name = "cEventType";
            this.cEventType.ReadOnly = true;
            this.cEventType.Width = 130;
            // 
            // cStartID
            // 
            this.cStartID.HeaderText = "Start Event ID";
            this.cStartID.Name = "cStartID";
            this.cStartID.ReadOnly = true;
            this.cStartID.Width = 50;
            // 
            // cStartDate
            // 
            this.cStartDate.HeaderText = "Start Date";
            this.cStartDate.Name = "cStartDate";
            this.cStartDate.ReadOnly = true;
            this.cStartDate.Width = 130;
            // 
            // cEndId
            // 
            this.cEndId.HeaderText = "End Event ID";
            this.cEndId.Name = "cEndId";
            this.cEndId.ReadOnly = true;
            this.cEndId.Width = 50;
            // 
            // cEndDate
            // 
            this.cEndDate.HeaderText = "End Date";
            this.cEndDate.Name = "cEndDate";
            this.cEndDate.ReadOnly = true;
            this.cEndDate.Width = 130;
            // 
            // cSpan
            // 
            this.cSpan.HeaderText = "Time Span";
            this.cSpan.Name = "cSpan";
            this.cSpan.ReadOnly = true;
            this.cSpan.Width = 75;
            // 
            // lb_nwt
            // 
            this.lb_nwt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nwt.AutoSize = true;
            this.lb_nwt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_nwt.Location = new System.Drawing.Point(280, 43);
            this.lb_nwt.Name = "lb_nwt";
            this.lb_nwt.Size = new System.Drawing.Size(41, 13);
            this.lb_nwt.TabIndex = 7;
            this.lb_nwt.Text = "label5";
            // 
            // lb_nwt1
            // 
            this.lb_nwt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nwt1.AutoSize = true;
            this.lb_nwt1.Location = new System.Drawing.Point(178, 43);
            this.lb_nwt1.Name = "lb_nwt1";
            this.lb_nwt1.Size = new System.Drawing.Size(96, 13);
            this.lb_nwt1.TabIndex = 6;
            this.lb_nwt1.Text = "Not Working Time:";
            this.lb_nwt1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_wt
            // 
            this.lb_wt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_wt.AutoSize = true;
            this.lb_wt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_wt.Location = new System.Drawing.Point(280, 20);
            this.lb_wt.Name = "lb_wt";
            this.lb_wt.Size = new System.Drawing.Size(41, 13);
            this.lb_wt.TabIndex = 5;
            this.lb_wt.Text = "label7";
            // 
            // lb_wt1
            // 
            this.lb_wt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_wt1.AutoSize = true;
            this.lb_wt1.Location = new System.Drawing.Point(198, 20);
            this.lb_wt1.Name = "lb_wt1";
            this.lb_wt1.Size = new System.Drawing.Size(76, 13);
            this.lb_wt1.TabIndex = 4;
            this.lb_wt1.Text = "Working Time:";
            this.lb_wt1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_totalerr
            // 
            this.lb_totalerr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_totalerr.AutoSize = true;
            this.lb_totalerr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_totalerr.Location = new System.Drawing.Point(101, 43);
            this.lb_totalerr.Name = "lb_totalerr";
            this.lb_totalerr.Size = new System.Drawing.Size(41, 13);
            this.lb_totalerr.TabIndex = 3;
            this.lb_totalerr.Text = "label4";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Errors:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_totaloper
            // 
            this.lb_totaloper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_totaloper.AutoSize = true;
            this.lb_totaloper.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_totaloper.Location = new System.Drawing.Point(101, 20);
            this.lb_totaloper.Name = "lb_totaloper";
            this.lb_totaloper.Size = new System.Drawing.Size(41, 13);
            this.lb_totaloper.TabIndex = 1;
            this.lb_totaloper.Text = "label2";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Operations:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_nwp
            // 
            this.lb_nwp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_nwp.AutoSize = true;
            this.lb_nwp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_nwp.ForeColor = System.Drawing.Color.Red;
            this.lb_nwp.Location = new System.Drawing.Point(506, 43);
            this.lb_nwp.Name = "lb_nwp";
            this.lb_nwp.Size = new System.Drawing.Size(41, 13);
            this.lb_nwp.TabIndex = 17;
            this.lb_nwp.Text = "label5";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(419, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Not Working %:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_wp
            // 
            this.lb_wp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_wp.AutoSize = true;
            this.lb_wp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_wp.ForeColor = System.Drawing.Color.Lime;
            this.lb_wp.Location = new System.Drawing.Point(506, 20);
            this.lb_wp.Name = "lb_wp";
            this.lb_wp.Size = new System.Drawing.Size(41, 13);
            this.lb_wp.TabIndex = 15;
            this.lb_wp.Text = "label7";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(439, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Working %:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 662);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LogView";
            this.Text = "EJ Log Parser - Log View";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_msg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_err)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dg_msg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar pB1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dg_err;
        private System.Windows.Forms.Label lb_nwt;
        private System.Windows.Forms.Label lb_nwt1;
        private System.Windows.Forms.Label lb_wt;
        private System.Windows.Forms.Label lb_wt1;
        private System.Windows.Forms.Label lb_totalerr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_totaloper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPairId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEndId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSpan;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cOperID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn cType;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLog;
        private System.Windows.Forms.Label lb_nwp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_wp;
        private System.Windows.Forms.Label label8;
    }
}