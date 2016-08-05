namespace FormAppSchedule
{
    partial class EditMenu
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
            this.butSave = new System.Windows.Forms.Button();
            this.butCancel = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxNumberOfGuest = new System.Windows.Forms.TextBox();
            this.editCalender = new System.Windows.Forms.MonthCalendar();
            this.lb_eFirstName = new System.Windows.Forms.Label();
            this.lb_eLastName = new System.Windows.Forms.Label();
            this.lb_ePhoneNumber = new System.Windows.Forms.Label();
            this.lb_eNumberOfGuest = new System.Windows.Forms.Label();
            this.lb_eTime = new System.Windows.Forms.Label();
            this.comboBoxTimeStart = new System.Windows.Forms.ComboBox();
            this.lb_eDate = new System.Windows.Forms.Label();
            this.lb_echangeDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSave
            // 
            this.butSave.Location = new System.Drawing.Point(48, 540);
            this.butSave.Margin = new System.Windows.Forms.Padding(6);
            this.butSave.Name = "butSave";
            this.butSave.Size = new System.Drawing.Size(332, 100);
            this.butSave.TabIndex = 0;
            this.butSave.Text = "Save";
            this.butSave.UseVisualStyleBackColor = true;
            this.butSave.Click += new System.EventHandler(this.butSave_Click);
            // 
            // butCancel
            // 
            this.butCancel.Location = new System.Drawing.Point(554, 540);
            this.butCancel.Margin = new System.Windows.Forms.Padding(6);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(312, 100);
            this.butCancel.TabIndex = 1;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(526, 173);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(196, 31);
            this.textBoxFirstName.TabIndex = 2;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(782, 173);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(196, 31);
            this.textBoxLastName.TabIndex = 3;
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(526, 290);
            this.textBoxPhoneNumber.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(196, 31);
            this.textBoxPhoneNumber.TabIndex = 4;
            // 
            // textBoxNumberOfGuest
            // 
            this.textBoxNumberOfGuest.Location = new System.Drawing.Point(526, 419);
            this.textBoxNumberOfGuest.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxNumberOfGuest.Name = "textBoxNumberOfGuest";
            this.textBoxNumberOfGuest.Size = new System.Drawing.Size(196, 31);
            this.textBoxNumberOfGuest.TabIndex = 5;
            // 
            // editCalender
            // 
            this.editCalender.Location = new System.Drawing.Point(48, 35);
            this.editCalender.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.editCalender.Name = "editCalender";
            this.editCalender.TabIndex = 7;
            this.editCalender.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.editCalender_DateChanged);
            // 
            // lb_eFirstName
            // 
            this.lb_eFirstName.AutoSize = true;
            this.lb_eFirstName.BackColor = System.Drawing.Color.Transparent;
            this.lb_eFirstName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_eFirstName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_eFirstName.Location = new System.Drawing.Point(526, 113);
            this.lb_eFirstName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_eFirstName.Name = "lb_eFirstName";
            this.lb_eFirstName.Size = new System.Drawing.Size(172, 34);
            this.lb_eFirstName.TabIndex = 8;
            this.lb_eFirstName.Text = "First Name";
            // 
            // lb_eLastName
            // 
            this.lb_eLastName.AutoSize = true;
            this.lb_eLastName.BackColor = System.Drawing.Color.Transparent;
            this.lb_eLastName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_eLastName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_eLastName.Location = new System.Drawing.Point(776, 113);
            this.lb_eLastName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_eLastName.Name = "lb_eLastName";
            this.lb_eLastName.Size = new System.Drawing.Size(165, 34);
            this.lb_eLastName.TabIndex = 9;
            this.lb_eLastName.Text = "Last Name";
            // 
            // lb_ePhoneNumber
            // 
            this.lb_ePhoneNumber.AutoSize = true;
            this.lb_ePhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lb_ePhoneNumber.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ePhoneNumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_ePhoneNumber.Location = new System.Drawing.Point(520, 250);
            this.lb_ePhoneNumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_ePhoneNumber.Name = "lb_ePhoneNumber";
            this.lb_ePhoneNumber.Size = new System.Drawing.Size(223, 34);
            this.lb_ePhoneNumber.TabIndex = 10;
            this.lb_ePhoneNumber.Text = "Phone Number";
            // 
            // lb_eNumberOfGuest
            // 
            this.lb_eNumberOfGuest.AutoSize = true;
            this.lb_eNumberOfGuest.BackColor = System.Drawing.Color.Transparent;
            this.lb_eNumberOfGuest.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_eNumberOfGuest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_eNumberOfGuest.Location = new System.Drawing.Point(526, 362);
            this.lb_eNumberOfGuest.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_eNumberOfGuest.Name = "lb_eNumberOfGuest";
            this.lb_eNumberOfGuest.Size = new System.Drawing.Size(268, 34);
            this.lb_eNumberOfGuest.TabIndex = 11;
            this.lb_eNumberOfGuest.Text = "Number Of Guests";
            // 
            // lb_eTime
            // 
            this.lb_eTime.AutoSize = true;
            this.lb_eTime.BackColor = System.Drawing.Color.Transparent;
            this.lb_eTime.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_eTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_eTime.Location = new System.Drawing.Point(776, 248);
            this.lb_eTime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_eTime.Name = "lb_eTime";
            this.lb_eTime.Size = new System.Drawing.Size(86, 34);
            this.lb_eTime.TabIndex = 12;
            this.lb_eTime.Text = "Time";
            // 
            // comboBoxTimeStart
            // 
            this.comboBoxTimeStart.FormattingEnabled = true;
            this.comboBoxTimeStart.Location = new System.Drawing.Point(782, 288);
            this.comboBoxTimeStart.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxTimeStart.Name = "comboBoxTimeStart";
            this.comboBoxTimeStart.Size = new System.Drawing.Size(196, 33);
            this.comboBoxTimeStart.TabIndex = 13;
            // 
            // lb_eDate
            // 
            this.lb_eDate.AutoSize = true;
            this.lb_eDate.BackColor = System.Drawing.Color.Transparent;
            this.lb_eDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_eDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_eDate.Location = new System.Drawing.Point(258, 423);
            this.lb_eDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_eDate.Name = "lb_eDate";
            this.lb_eDate.Size = new System.Drawing.Size(145, 34);
            this.lb_eDate.TabIndex = 14;
            this.lb_eDate.Text = "lb_eDate";
            // 
            // lb_echangeDate
            // 
            this.lb_echangeDate.AutoSize = true;
            this.lb_echangeDate.BackColor = System.Drawing.Color.Transparent;
            this.lb_echangeDate.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_echangeDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_echangeDate.Location = new System.Drawing.Point(42, 423);
            this.lb_echangeDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_echangeDate.Name = "lb_echangeDate";
            this.lb_echangeDate.Size = new System.Drawing.Size(198, 34);
            this.lb_echangeDate.TabIndex = 15;
            this.lb_echangeDate.Text = "Current Date";
            // 
            // EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 748);
            this.Controls.Add(this.lb_echangeDate);
            this.Controls.Add(this.lb_eDate);
            this.Controls.Add(this.comboBoxTimeStart);
            this.Controls.Add(this.lb_eTime);
            this.Controls.Add(this.lb_eNumberOfGuest);
            this.Controls.Add(this.lb_ePhoneNumber);
            this.Controls.Add(this.lb_eLastName);
            this.Controls.Add(this.lb_eFirstName);
            this.Controls.Add(this.editCalender);
            this.Controls.Add(this.textBoxNumberOfGuest);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.butSave);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "EditMenu";
            this.Text = "EditMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSave;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxNumberOfGuest;
        private System.Windows.Forms.MonthCalendar editCalender;
        private System.Windows.Forms.Label lb_eFirstName;
        private System.Windows.Forms.Label lb_eLastName;
        private System.Windows.Forms.Label lb_ePhoneNumber;
        private System.Windows.Forms.Label lb_eNumberOfGuest;
        private System.Windows.Forms.Label lb_eTime;
        private System.Windows.Forms.ComboBox comboBoxTimeStart;
        private System.Windows.Forms.Label lb_eDate;
        private System.Windows.Forms.Label lb_echangeDate;
    }
}