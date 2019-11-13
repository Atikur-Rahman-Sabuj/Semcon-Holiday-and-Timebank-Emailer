namespace Semcon_Holiday_and_Timebank_Emailer
{
    partial class Emailer
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Emailer));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnSelectCsv = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.colSerialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsurName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHolidayTaken = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRemainingHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChristmasHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSendEmails = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSetting = new System.Windows.Forms.Button();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxSubject = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.tbxBeforeBody = new Semcon_Holiday_and_Timebank_Emailer.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Holiday Email",
            "Timebank Email"});
            this.comboBox1.Location = new System.Drawing.Point(15, 8);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(139, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnSelectCsv
            // 
            this.btnSelectCsv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectCsv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelectCsv.Location = new System.Drawing.Point(180, 6);
            this.btnSelectCsv.Margin = new System.Windows.Forms.Padding(2);
            this.btnSelectCsv.Name = "btnSelectCsv";
            this.btnSelectCsv.Size = new System.Drawing.Size(107, 24);
            this.btnSelectCsv.TabIndex = 1;
            this.btnSelectCsv.Text = "Select CSV";
            this.btnSelectCsv.UseVisualStyleBackColor = true;
            this.btnSelectCsv.Click += new System.EventHandler(this.btnSelectCsv_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToResizeColumns = false;
            this.dgvEmployees.AllowUserToResizeRows = false;
            this.dgvEmployees.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmployees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSerialNo,
            this.colName,
            this.colFirstName,
            this.colsurName,
            this.colEmail,
            this.colHolidayTaken,
            this.colRemainingHours,
            this.ChristmasHours,
            this.Result});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmployees.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmployees.GridColor = System.Drawing.Color.White;
            this.dgvEmployees.Location = new System.Drawing.Point(7, 76);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(2);
            this.dgvEmployees.MultiSelect = false;
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersVisible = false;
            this.dgvEmployees.RowTemplate.Height = 28;
            this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployees.ShowEditingIcon = false;
            this.dgvEmployees.Size = new System.Drawing.Size(1105, 313);
            this.dgvEmployees.TabIndex = 2;
            this.dgvEmployees.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEmployees_CellClick);
            // 
            // colSerialNo
            // 
            this.colSerialNo.HeaderText = "Sl. No.";
            this.colSerialNo.Name = "colSerialNo";
            this.colSerialNo.ReadOnly = true;
            this.colSerialNo.Width = 70;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 150;
            // 
            // colFirstName
            // 
            this.colFirstName.DataPropertyName = "FirstName";
            this.colFirstName.HeaderText = "First Name";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.ReadOnly = true;
            // 
            // colsurName
            // 
            this.colsurName.DataPropertyName = "SurName";
            this.colsurName.HeaderText = "Sur Name";
            this.colsurName.Name = "colsurName";
            this.colsurName.ReadOnly = true;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email Address";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 150;
            // 
            // colHolidayTaken
            // 
            this.colHolidayTaken.DataPropertyName = "HolidayTakenYTD";
            this.colHolidayTaken.HeaderText = "Holiday Taken YTD";
            this.colHolidayTaken.Name = "colHolidayTaken";
            this.colHolidayTaken.ReadOnly = true;
            this.colHolidayTaken.Width = 140;
            // 
            // colRemainingHours
            // 
            this.colRemainingHours.DataPropertyName = "RemainingHours";
            this.colRemainingHours.HeaderText = "Remaining Hours";
            this.colRemainingHours.Name = "colRemainingHours";
            this.colRemainingHours.ReadOnly = true;
            this.colRemainingHours.Width = 140;
            // 
            // ChristmasHours
            // 
            this.ChristmasHours.DataPropertyName = "ChristmasHours";
            this.ChristmasHours.HeaderText = "Christmas Hours";
            this.ChristmasHours.Name = "ChristmasHours";
            this.ChristmasHours.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // btnSendEmails
            // 
            this.btnSendEmails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSendEmails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmails.Location = new System.Drawing.Point(987, 512);
            this.btnSendEmails.Margin = new System.Windows.Forms.Padding(2);
            this.btnSendEmails.Name = "btnSendEmails";
            this.btnSendEmails.Size = new System.Drawing.Size(124, 33);
            this.btnSendEmails.TabIndex = 4;
            this.btnSendEmails.Text = "Send Emails";
            this.btnSendEmails.UseVisualStyleBackColor = true;
            this.btnSendEmails.Click += new System.EventHandler(this.btnSendEmails_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV files|*.csv";
            this.openFileDialog1.Title = "Select csv file";
            // 
            // btnSetting
            // 
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetting.Location = new System.Drawing.Point(1001, 8);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(107, 33);
            this.btnSetting.TabIndex = 5;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(7, 393);
            this.tbxEmail.Multiline = true;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbxEmail.Size = new System.Drawing.Size(1105, 114);
            this.tbxEmail.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(829, 512);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.Leave += new System.EventHandler(this.btnSave_Leave);
            // 
            // tbxSubject
            // 
            this.tbxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSubject.Location = new System.Drawing.Point(81, 519);
            this.tbxSubject.Name = "tbxSubject";
            this.tbxSubject.Size = new System.Drawing.Size(650, 22);
            this.tbxSubject.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 522);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Subject :";
            // 
            // lblFileName
            // 
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.Location = new System.Drawing.Point(292, 11);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(414, 15);
            this.lblFileName.TabIndex = 12;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Location = new System.Drawing.Point(614, 523);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(0, 16);
            this.lblSave.TabIndex = 13;
            // 
            // tbxBeforeBody
            // 
            this.tbxBeforeBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxBeforeBody.ForeColor = System.Drawing.Color.Gray;
            this.tbxBeforeBody.Location = new System.Drawing.Point(7, 47);
            this.tbxBeforeBody.Name = "tbxBeforeBody";
            this.tbxBeforeBody.PlaceHolderText = "Add additional message to add to the email. This will appear before the main body" +
    " text.";
            this.tbxBeforeBody.Size = new System.Drawing.Size(1104, 22);
            this.tbxBeforeBody.TabIndex = 11;
            this.tbxBeforeBody.Text = "Add additional message to add to the email. This will appear before the main body" +
    " text.";
            // 
            // Emailer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1123, 581);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.tbxBeforeBody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxSubject);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.btnSetting);
            this.Controls.Add(this.btnSendEmails);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.btnSelectCsv);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Emailer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Holiday & Timebank Emailer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Emailer_FormClosing);
            this.Load += new System.EventHandler(this.Emailer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnSelectCsv;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnSendEmails;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxSubject;
        private System.Windows.Forms.Label label1;
        private PlaceholderTextBox tbxBeforeBody;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerialNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsurName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHolidayTaken;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRemainingHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChristmasHours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}

