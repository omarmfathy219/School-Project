namespace School_Project.Presentation_Layer
{
    partial class Class_Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class_Manage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnBack = new MetroFramework.Controls.MetroButton();
            this.BtnForward = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtboxID = new MetroFramework.Controls.MetroTextBox();
            this.txtboxClassName = new MetroFramework.Controls.MetroTextBox();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.txtboxClassSupervisor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroGrid1);
            this.groupBox1.Controls.Add(this.txtboxClassSupervisor);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.BtnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtboxClassName);
            this.groupBox1.Controls.Add(this.txtboxID);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.BtnForward);
            this.groupBox1.Controls.Add(this.btnBack);
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Class Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(31, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(38, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(31, 98);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(102, 25);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Class Name";
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnBack.Location = new System.Drawing.Point(34, 184);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 27);
            this.btnBack.TabIndex = 4;
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBack.UseSelectable = true;
            // 
            // BtnForward
            // 
            this.BtnForward.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnForward.BackgroundImage")));
            this.BtnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnForward.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BtnForward.Location = new System.Drawing.Point(198, 184);
            this.BtnForward.Name = "BtnForward";
            this.BtnForward.Size = new System.Drawing.Size(75, 27);
            this.BtnForward.TabIndex = 5;
            this.BtnForward.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(125, 186);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 25);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "1/6";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtboxID
            // 
            // 
            // 
            // 
            this.txtboxID.CustomButton.Image = null;
            this.txtboxID.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtboxID.CustomButton.Name = "";
            this.txtboxID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxID.CustomButton.TabIndex = 1;
            this.txtboxID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxID.CustomButton.UseSelectable = true;
            this.txtboxID.CustomButton.Visible = false;
            this.txtboxID.Lines = new string[] {
        "metroTextBox1"};
            this.txtboxID.Location = new System.Drawing.Point(159, 54);
            this.txtboxID.MaxLength = 32767;
            this.txtboxID.Name = "txtboxID";
            this.txtboxID.PasswordChar = '\0';
            this.txtboxID.ReadOnly = true;
            this.txtboxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxID.SelectedText = "";
            this.txtboxID.SelectionLength = 0;
            this.txtboxID.SelectionStart = 0;
            this.txtboxID.ShortcutsEnabled = true;
            this.txtboxID.Size = new System.Drawing.Size(114, 23);
            this.txtboxID.TabIndex = 1;
            this.txtboxID.Text = "metroTextBox1";
            this.txtboxID.UseSelectable = true;
            this.txtboxID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtboxID.Click += new System.EventHandler(this.txtboxID_Click);
            // 
            // txtboxClassName
            // 
            // 
            // 
            // 
            this.txtboxClassName.CustomButton.Image = null;
            this.txtboxClassName.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtboxClassName.CustomButton.Name = "";
            this.txtboxClassName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxClassName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxClassName.CustomButton.TabIndex = 1;
            this.txtboxClassName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxClassName.CustomButton.UseSelectable = true;
            this.txtboxClassName.CustomButton.Visible = false;
            this.txtboxClassName.Lines = new string[] {
        "metroTextBox2"};
            this.txtboxClassName.Location = new System.Drawing.Point(159, 98);
            this.txtboxClassName.MaxLength = 32767;
            this.txtboxClassName.Name = "txtboxClassName";
            this.txtboxClassName.PasswordChar = '\0';
            this.txtboxClassName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxClassName.SelectedText = "";
            this.txtboxClassName.SelectionLength = 0;
            this.txtboxClassName.SelectionStart = 0;
            this.txtboxClassName.ShortcutsEnabled = true;
            this.txtboxClassName.Size = new System.Drawing.Size(114, 23);
            this.txtboxClassName.TabIndex = 2;
            this.txtboxClassName.Text = "metroTextBox2";
            this.txtboxClassName.UseSelectable = true;
            this.txtboxClassName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxClassName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtboxClassName.Click += new System.EventHandler(this.txtboxClass_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.Location = new System.Drawing.Point(12, 228);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(97, 30);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.UseSelectable = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDelete.BackgroundImage")));
            this.BtnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDelete.Location = new System.Drawing.Point(239, 228);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(97, 30);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.UseSelectable = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnUpdate.Location = new System.Drawing.Point(125, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(97, 30);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.UseSelectable = true;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(355, 228);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtboxClassSupervisor
            // 
            // 
            // 
            // 
            this.txtboxClassSupervisor.CustomButton.Image = null;
            this.txtboxClassSupervisor.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtboxClassSupervisor.CustomButton.Name = "";
            this.txtboxClassSupervisor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxClassSupervisor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxClassSupervisor.CustomButton.TabIndex = 1;
            this.txtboxClassSupervisor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxClassSupervisor.CustomButton.UseSelectable = true;
            this.txtboxClassSupervisor.CustomButton.Visible = false;
            this.txtboxClassSupervisor.Lines = new string[] {
        "metroTextBox2"};
            this.txtboxClassSupervisor.Location = new System.Drawing.Point(159, 139);
            this.txtboxClassSupervisor.MaxLength = 32767;
            this.txtboxClassSupervisor.Name = "txtboxClassSupervisor";
            this.txtboxClassSupervisor.PasswordChar = '\0';
            this.txtboxClassSupervisor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxClassSupervisor.SelectedText = "";
            this.txtboxClassSupervisor.SelectionLength = 0;
            this.txtboxClassSupervisor.SelectionStart = 0;
            this.txtboxClassSupervisor.ShortcutsEnabled = true;
            this.txtboxClassSupervisor.Size = new System.Drawing.Size(114, 23);
            this.txtboxClassSupervisor.TabIndex = 3;
            this.txtboxClassSupervisor.Text = "metroTextBox2";
            this.txtboxClassSupervisor.UseSelectable = true;
            this.txtboxClassSupervisor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxClassSupervisor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtboxClassSupervisor.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(34, 137);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 25);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Class Supervisor";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(315, 54);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(304, 150);
            this.metroGrid1.TabIndex = 11;
            // 
            // Class_Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 396);
            this.Controls.Add(this.groupBox1);
            this.Name = "Class_Manage";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Class_Manage_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton BtnForward;
        private MetroFramework.Controls.MetroButton btnBack;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtboxClassName;
        private MetroFramework.Controls.MetroTextBox txtboxID;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtboxClassSupervisor;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroGrid metroGrid1;
    }
}