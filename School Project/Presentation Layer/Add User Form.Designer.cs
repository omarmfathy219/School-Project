namespace School_Project.Presentation_Layer
{
    partial class Add_User_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_User_Form));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.txtboxConfirmPass = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtboxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.txtboxUsername = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtboxConfirmPass);
            this.groupBox1.Controls.Add(this.metroLabel3);
            this.groupBox1.Controls.Add(this.txtboxPassword);
            this.groupBox1.Controls.Add(this.metroLabel4);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.txtboxUsername);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 218);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New User";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::School_Project.Properties.Resources.iconfinder_floppy_2856157;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.Location = new System.Drawing.Point(314, 171);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(97, 30);
            this.btnSave.TabIndex = 4;
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtboxConfirmPass
            // 
            // 
            // 
            // 
            this.txtboxConfirmPass.CustomButton.Image = null;
            this.txtboxConfirmPass.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtboxConfirmPass.CustomButton.Name = "";
            this.txtboxConfirmPass.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxConfirmPass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxConfirmPass.CustomButton.TabIndex = 1;
            this.txtboxConfirmPass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxConfirmPass.CustomButton.UseSelectable = true;
            this.txtboxConfirmPass.CustomButton.Visible = false;
            this.txtboxConfirmPass.Lines = new string[0];
            this.txtboxConfirmPass.Location = new System.Drawing.Point(195, 126);
            this.txtboxConfirmPass.MaxLength = 25;
            this.txtboxConfirmPass.Name = "txtboxConfirmPass";
            this.txtboxConfirmPass.PasswordChar = '*';
            this.txtboxConfirmPass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxConfirmPass.SelectedText = "";
            this.txtboxConfirmPass.SelectionLength = 0;
            this.txtboxConfirmPass.SelectionStart = 0;
            this.txtboxConfirmPass.ShortcutsEnabled = true;
            this.txtboxConfirmPass.Size = new System.Drawing.Size(114, 23);
            this.txtboxConfirmPass.TabIndex = 2;
            this.txtboxConfirmPass.UseSelectable = true;
            this.txtboxConfirmPass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxConfirmPass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtboxConfirmPass.CursorChanged += new System.EventHandler(this.txtboxConfirmPass_CursorChanged);
            this.txtboxConfirmPass.Validated += new System.EventHandler(this.txtboxConfirmPass_Validated);
            // 
            // metroLabel3
            // 
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(36, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(135, 25);
            this.metroLabel3.TabIndex = 12;
            this.metroLabel3.Text = "Confirm Password";
            // 
            // txtboxPassword
            // 
            // 
            // 
            // 
            this.txtboxPassword.CustomButton.Image = null;
            this.txtboxPassword.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtboxPassword.CustomButton.Name = "";
            this.txtboxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxPassword.CustomButton.TabIndex = 1;
            this.txtboxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxPassword.CustomButton.UseSelectable = true;
            this.txtboxPassword.CustomButton.Visible = false;
            this.txtboxPassword.Lines = new string[0];
            this.txtboxPassword.Location = new System.Drawing.Point(195, 89);
            this.txtboxPassword.MaxLength = 25;
            this.txtboxPassword.Name = "txtboxPassword";
            this.txtboxPassword.PasswordChar = '*';
            this.txtboxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxPassword.SelectedText = "";
            this.txtboxPassword.SelectionLength = 0;
            this.txtboxPassword.SelectionStart = 0;
            this.txtboxPassword.ShortcutsEnabled = true;
            this.txtboxPassword.Size = new System.Drawing.Size(114, 23);
            this.txtboxPassword.TabIndex = 1;
            this.txtboxPassword.UseSelectable = true;
            this.txtboxPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtboxPassword.Click += new System.EventHandler(this.txtboxPassword_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(34, 87);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(135, 25);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Password";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClose.Location = new System.Drawing.Point(430, 171);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(97, 30);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtboxUsername
            // 
            // 
            // 
            // 
            this.txtboxUsername.CustomButton.Image = null;
            this.txtboxUsername.CustomButton.Location = new System.Drawing.Point(92, 1);
            this.txtboxUsername.CustomButton.Name = "";
            this.txtboxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtboxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtboxUsername.CustomButton.TabIndex = 1;
            this.txtboxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtboxUsername.CustomButton.UseSelectable = true;
            this.txtboxUsername.CustomButton.Visible = false;
            this.txtboxUsername.Lines = new string[0];
            this.txtboxUsername.Location = new System.Drawing.Point(195, 54);
            this.txtboxUsername.MaxLength = 32767;
            this.txtboxUsername.Name = "txtboxUsername";
            this.txtboxUsername.PasswordChar = '\0';
            this.txtboxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxUsername.SelectedText = "";
            this.txtboxUsername.SelectionLength = 0;
            this.txtboxUsername.SelectionStart = 0;
            this.txtboxUsername.ShortcutsEnabled = true;
            this.txtboxUsername.Size = new System.Drawing.Size(114, 23);
            this.txtboxUsername.TabIndex = 0;
            this.txtboxUsername.UseSelectable = true;
            this.txtboxUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtboxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(31, 54);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(76, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Username";
            // 
            // Add_User_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 253);
            this.Controls.Add(this.groupBox1);
            this.Name = "Add_User_Form";
            this.Load += new System.EventHandler(this.Add_User_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox txtboxConfirmPass;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtboxPassword;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroTextBox txtboxUsername;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnSave;
    }
}