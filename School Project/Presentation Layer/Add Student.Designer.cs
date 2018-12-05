namespace School_Project.Presentation_Layer
{
    partial class Add_Student
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
            this.cmboxAcademic_Year = new MetroFramework.Controls.MetroComboBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.Ok = new MetroFramework.Controls.MetroButton();
            this.txtBirthDate = new MetroFramework.Controls.MetroDateTime();
            this.Address = new MetroFramework.Controls.MetroLabel();
            this.Supervisor = new MetroFramework.Controls.MetroLabel();
            this.TxtAddress = new MetroFramework.Controls.MetroTextBox();
            this.TxtPhone_Number = new MetroFramework.Controls.MetroTextBox();
            this.PhoneNumber = new MetroFramework.Controls.MetroLabel();
            this.AcademicYear = new MetroFramework.Controls.MetroLabel();
            this.Class = new MetroFramework.Controls.MetroLabel();
            this.BirthDate = new MetroFramework.Controls.MetroLabel();
            this.txtLast_Name = new MetroFramework.Controls.MetroTextBox();
            this.LastName = new MetroFramework.Controls.MetroLabel();
            this.txtFirst_Name = new MetroFramework.Controls.MetroTextBox();
            this.FirstName = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtID = new MetroFramework.Controls.MetroTextBox();
            this.ID = new MetroFramework.Controls.MetroLabel();
            this.cmboxFees = new MetroFramework.Controls.MetroComboBox();
            this.cmboxSupervisor = new MetroFramework.Controls.MetroComboBox();
            this.cmboxClass = new MetroFramework.Controls.MetroComboBox();
            this.Fees = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboxAcademic_Year
            // 
            this.cmboxAcademic_Year.FormattingEnabled = true;
            this.cmboxAcademic_Year.ItemHeight = 23;
            this.cmboxAcademic_Year.Location = new System.Drawing.Point(172, 260);
            this.cmboxAcademic_Year.Name = "cmboxAcademic_Year";
            this.cmboxAcademic_Year.Size = new System.Drawing.Size(186, 29);
            this.cmboxAcademic_Year.TabIndex = 6;
            this.cmboxAcademic_Year.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(407, 469);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(106, 23);
            this.metroButton2.TabIndex = 12;
            this.metroButton2.Text = "Cancel";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(285, 469);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(106, 23);
            this.Ok.TabIndex = 11;
            this.Ok.Text = "Add";
            this.Ok.UseSelectable = true;
            this.Ok.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // txtBirthDate
            // 
            this.txtBirthDate.Location = new System.Drawing.Point(172, 175);
            this.txtBirthDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtBirthDate.Name = "txtBirthDate";
            this.txtBirthDate.Size = new System.Drawing.Size(186, 29);
            this.txtBirthDate.TabIndex = 4;
            // 
            // Address
            // 
            this.Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address.AutoSize = true;
            this.Address.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Address.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Address.Location = new System.Drawing.Point(31, 382);
            this.Address.Margin = new System.Windows.Forms.Padding(3);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(77, 25);
            this.Address.TabIndex = 18;
            this.Address.Text = "Address";
            // 
            // Supervisor
            // 
            this.Supervisor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Supervisor.AutoSize = true;
            this.Supervisor.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Supervisor.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Supervisor.Location = new System.Drawing.Point(31, 340);
            this.Supervisor.Margin = new System.Windows.Forms.Padding(3);
            this.Supervisor.Name = "Supervisor";
            this.Supervisor.Size = new System.Drawing.Size(96, 25);
            this.Supervisor.TabIndex = 16;
            this.Supervisor.Text = "Supervisor";
            // 
            // TxtAddress
            // 
            // 
            // 
            // 
            this.TxtAddress.CustomButton.Image = null;
            this.TxtAddress.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.TxtAddress.CustomButton.Name = "";
            this.TxtAddress.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtAddress.CustomButton.TabIndex = 1;
            this.TxtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtAddress.CustomButton.UseSelectable = true;
            this.TxtAddress.CustomButton.Visible = false;
            this.TxtAddress.Lines = new string[0];
            this.TxtAddress.Location = new System.Drawing.Point(172, 384);
            this.TxtAddress.MaxLength = 32767;
            this.TxtAddress.Name = "TxtAddress";
            this.TxtAddress.PasswordChar = '\0';
            this.TxtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtAddress.SelectedText = "";
            this.TxtAddress.SelectionLength = 0;
            this.TxtAddress.SelectionStart = 0;
            this.TxtAddress.ShortcutsEnabled = true;
            this.TxtAddress.Size = new System.Drawing.Size(186, 23);
            this.TxtAddress.TabIndex = 9;
            this.TxtAddress.UseSelectable = true;
            this.TxtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtAddress.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TxtPhone_Number
            // 
            // 
            // 
            // 
            this.TxtPhone_Number.CustomButton.Image = null;
            this.TxtPhone_Number.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.TxtPhone_Number.CustomButton.Name = "";
            this.TxtPhone_Number.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.TxtPhone_Number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtPhone_Number.CustomButton.TabIndex = 1;
            this.TxtPhone_Number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtPhone_Number.CustomButton.UseSelectable = true;
            this.TxtPhone_Number.CustomButton.Visible = false;
            this.TxtPhone_Number.Lines = new string[0];
            this.TxtPhone_Number.Location = new System.Drawing.Point(172, 305);
            this.TxtPhone_Number.MaxLength = 32767;
            this.TxtPhone_Number.Name = "TxtPhone_Number";
            this.TxtPhone_Number.PasswordChar = '\0';
            this.TxtPhone_Number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtPhone_Number.SelectedText = "";
            this.TxtPhone_Number.SelectionLength = 0;
            this.TxtPhone_Number.SelectionStart = 0;
            this.TxtPhone_Number.ShortcutsEnabled = true;
            this.TxtPhone_Number.Size = new System.Drawing.Size(186, 23);
            this.TxtPhone_Number.TabIndex = 7;
            this.TxtPhone_Number.UseSelectable = true;
            this.TxtPhone_Number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtPhone_Number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PhoneNumber.AutoSize = true;
            this.PhoneNumber.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.PhoneNumber.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.PhoneNumber.Location = new System.Drawing.Point(31, 303);
            this.PhoneNumber.Margin = new System.Windows.Forms.Padding(3);
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Size = new System.Drawing.Size(132, 25);
            this.PhoneNumber.TabIndex = 12;
            this.PhoneNumber.Text = "Phone Number";
            // 
            // AcademicYear
            // 
            this.AcademicYear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AcademicYear.AutoSize = true;
            this.AcademicYear.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.AcademicYear.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.AcademicYear.Location = new System.Drawing.Point(31, 260);
            this.AcademicYear.Margin = new System.Windows.Forms.Padding(3);
            this.AcademicYear.Name = "AcademicYear";
            this.AcademicYear.Size = new System.Drawing.Size(126, 25);
            this.AcademicYear.TabIndex = 10;
            this.AcademicYear.Text = "Academic Year";
            // 
            // Class
            // 
            this.Class.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Class.AutoSize = true;
            this.Class.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Class.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Class.Location = new System.Drawing.Point(31, 221);
            this.Class.Margin = new System.Windows.Forms.Padding(3);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(52, 25);
            this.Class.TabIndex = 8;
            this.Class.Text = "Class";
            // 
            // BirthDate
            // 
            this.BirthDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthDate.AutoSize = true;
            this.BirthDate.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.BirthDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.BirthDate.Location = new System.Drawing.Point(31, 179);
            this.BirthDate.Margin = new System.Windows.Forms.Padding(3);
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Size = new System.Drawing.Size(85, 25);
            this.BirthDate.TabIndex = 6;
            this.BirthDate.Text = "BirthDate";
            // 
            // txtLast_Name
            // 
            // 
            // 
            // 
            this.txtLast_Name.CustomButton.Image = null;
            this.txtLast_Name.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtLast_Name.CustomButton.Name = "";
            this.txtLast_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLast_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLast_Name.CustomButton.TabIndex = 1;
            this.txtLast_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLast_Name.CustomButton.UseSelectable = true;
            this.txtLast_Name.CustomButton.Visible = false;
            this.txtLast_Name.Lines = new string[0];
            this.txtLast_Name.Location = new System.Drawing.Point(172, 140);
            this.txtLast_Name.MaxLength = 32767;
            this.txtLast_Name.Name = "txtLast_Name";
            this.txtLast_Name.PasswordChar = '\0';
            this.txtLast_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLast_Name.SelectedText = "";
            this.txtLast_Name.SelectionLength = 0;
            this.txtLast_Name.SelectionStart = 0;
            this.txtLast_Name.ShortcutsEnabled = true;
            this.txtLast_Name.Size = new System.Drawing.Size(186, 23);
            this.txtLast_Name.TabIndex = 3;
            this.txtLast_Name.UseSelectable = true;
            this.txtLast_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLast_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // LastName
            // 
            this.LastName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName.AutoSize = true;
            this.LastName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.LastName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.LastName.Location = new System.Drawing.Point(31, 138);
            this.LastName.Margin = new System.Windows.Forms.Padding(3);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(95, 25);
            this.LastName.TabIndex = 4;
            this.LastName.Text = "Last Name";
            // 
            // txtFirst_Name
            // 
            // 
            // 
            // 
            this.txtFirst_Name.CustomButton.Image = null;
            this.txtFirst_Name.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtFirst_Name.CustomButton.Name = "";
            this.txtFirst_Name.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirst_Name.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirst_Name.CustomButton.TabIndex = 1;
            this.txtFirst_Name.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirst_Name.CustomButton.UseSelectable = true;
            this.txtFirst_Name.CustomButton.Visible = false;
            this.txtFirst_Name.Lines = new string[0];
            this.txtFirst_Name.Location = new System.Drawing.Point(172, 91);
            this.txtFirst_Name.MaxLength = 32767;
            this.txtFirst_Name.Name = "txtFirst_Name";
            this.txtFirst_Name.PasswordChar = '\0';
            this.txtFirst_Name.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirst_Name.SelectedText = "";
            this.txtFirst_Name.SelectionLength = 0;
            this.txtFirst_Name.SelectionStart = 0;
            this.txtFirst_Name.ShortcutsEnabled = true;
            this.txtFirst_Name.Size = new System.Drawing.Size(186, 23);
            this.txtFirst_Name.TabIndex = 2;
            this.txtFirst_Name.UseSelectable = true;
            this.txtFirst_Name.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirst_Name.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FirstName
            // 
            this.FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName.AutoSize = true;
            this.FirstName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.FirstName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.FirstName.Location = new System.Drawing.Point(31, 89);
            this.FirstName.Margin = new System.Windows.Forms.Padding(3);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(97, 25);
            this.FirstName.TabIndex = 2;
            this.FirstName.Text = "First Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.ID);
            this.groupBox1.Controls.Add(this.cmboxFees);
            this.groupBox1.Controls.Add(this.cmboxSupervisor);
            this.groupBox1.Controls.Add(this.cmboxClass);
            this.groupBox1.Controls.Add(this.Fees);
            this.groupBox1.Controls.Add(this.cmboxAcademic_Year);
            this.groupBox1.Controls.Add(this.metroButton2);
            this.groupBox1.Controls.Add(this.Ok);
            this.groupBox1.Controls.Add(this.txtBirthDate);
            this.groupBox1.Controls.Add(this.Address);
            this.groupBox1.Controls.Add(this.Supervisor);
            this.groupBox1.Controls.Add(this.TxtAddress);
            this.groupBox1.Controls.Add(this.TxtPhone_Number);
            this.groupBox1.Controls.Add(this.PhoneNumber);
            this.groupBox1.Controls.Add(this.AcademicYear);
            this.groupBox1.Controls.Add(this.Class);
            this.groupBox1.Controls.Add(this.BirthDate);
            this.groupBox1.Controls.Add(this.txtLast_Name);
            this.groupBox1.Controls.Add(this.LastName);
            this.groupBox1.Controls.Add(this.txtFirst_Name);
            this.groupBox1.Controls.Add(this.FirstName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(24, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(534, 508);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data:";
            // 
            // txtID
            // 
            // 
            // 
            // 
            this.txtID.CustomButton.Image = null;
            this.txtID.CustomButton.Location = new System.Drawing.Point(164, 1);
            this.txtID.CustomButton.Name = "";
            this.txtID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtID.CustomButton.TabIndex = 1;
            this.txtID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtID.CustomButton.UseSelectable = true;
            this.txtID.CustomButton.Visible = false;
            this.txtID.Lines = new string[0];
            this.txtID.Location = new System.Drawing.Point(172, 50);
            this.txtID.MaxLength = 32767;
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtID.SelectedText = "";
            this.txtID.SelectionLength = 0;
            this.txtID.SelectionStart = 0;
            this.txtID.ShortcutsEnabled = true;
            this.txtID.Size = new System.Drawing.Size(186, 23);
            this.txtID.TabIndex = 1;
            this.txtID.UseSelectable = true;
            this.txtID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtID.Validated += new System.EventHandler(this.txtID_Validated);
            // 
            // ID
            // 
            this.ID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ID.AutoSize = true;
            this.ID.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ID.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ID.Location = new System.Drawing.Point(31, 48);
            this.ID.Margin = new System.Windows.Forms.Padding(3);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(30, 25);
            this.ID.TabIndex = 29;
            this.ID.Text = "ID";
            // 
            // cmboxFees
            // 
            this.cmboxFees.FormattingEnabled = true;
            this.cmboxFees.ItemHeight = 23;
            this.cmboxFees.Location = new System.Drawing.Point(172, 423);
            this.cmboxFees.Name = "cmboxFees";
            this.cmboxFees.Size = new System.Drawing.Size(186, 29);
            this.cmboxFees.TabIndex = 10;
            this.cmboxFees.UseSelectable = true;
            // 
            // cmboxSupervisor
            // 
            this.cmboxSupervisor.FormattingEnabled = true;
            this.cmboxSupervisor.ItemHeight = 23;
            this.cmboxSupervisor.Location = new System.Drawing.Point(172, 340);
            this.cmboxSupervisor.Name = "cmboxSupervisor";
            this.cmboxSupervisor.Size = new System.Drawing.Size(186, 29);
            this.cmboxSupervisor.TabIndex = 8;
            this.cmboxSupervisor.UseSelectable = true;
            // 
            // cmboxClass
            // 
            this.cmboxClass.FormattingEnabled = true;
            this.cmboxClass.ItemHeight = 23;
            this.cmboxClass.Location = new System.Drawing.Point(172, 217);
            this.cmboxClass.Name = "cmboxClass";
            this.cmboxClass.Size = new System.Drawing.Size(186, 29);
            this.cmboxClass.TabIndex = 5;
            this.cmboxClass.UseSelectable = true;
            // 
            // Fees
            // 
            this.Fees.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Fees.AutoSize = true;
            this.Fees.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.Fees.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.Fees.Location = new System.Drawing.Point(31, 423);
            this.Fees.Margin = new System.Windows.Forms.Padding(3);
            this.Fees.Name = "Fees";
            this.Fees.Size = new System.Drawing.Size(47, 25);
            this.Fees.TabIndex = 24;
            this.Fees.Text = "Fees";
            // 
            // Add_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 581);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_Student";
            this.Text = "Add Student";
            this.Load += new System.EventHandler(this.Add_Student_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MetroFramework.Controls.MetroComboBox cmboxAcademic_Year;
        public MetroFramework.Controls.MetroButton metroButton2;
        public MetroFramework.Controls.MetroButton Ok;
        public MetroFramework.Controls.MetroDateTime txtBirthDate;
        public MetroFramework.Controls.MetroLabel Address;
        public MetroFramework.Controls.MetroLabel Supervisor;
        public MetroFramework.Controls.MetroTextBox TxtAddress;
        public MetroFramework.Controls.MetroTextBox TxtPhone_Number;
        public MetroFramework.Controls.MetroLabel PhoneNumber;
        public MetroFramework.Controls.MetroLabel AcademicYear;
        public MetroFramework.Controls.MetroLabel Class;
        public MetroFramework.Controls.MetroLabel BirthDate;
        public MetroFramework.Controls.MetroTextBox txtLast_Name;
        public MetroFramework.Controls.MetroLabel LastName;
        public MetroFramework.Controls.MetroTextBox txtFirst_Name;
        public MetroFramework.Controls.MetroLabel FirstName;
        public System.Windows.Forms.GroupBox groupBox1;
        public MetroFramework.Controls.MetroLabel Fees;
        public MetroFramework.Controls.MetroComboBox cmboxClass;
        public MetroFramework.Controls.MetroComboBox cmboxSupervisor;
        public MetroFramework.Controls.MetroTextBox txtID;
        public MetroFramework.Controls.MetroLabel ID;
        public MetroFramework.Controls.MetroComboBox cmboxFees;
    }
}