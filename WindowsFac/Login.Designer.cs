namespace WindowsFac
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.bunifuCheckbox1 = new Bunifu.Framework.UI.BunifuCheckbox();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lblUserName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lblPassWord = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuiOSSwitch1 = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuCheckbox1
            // 
            this.bunifuCheckbox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.bunifuCheckbox1.Checked = true;
            this.bunifuCheckbox1.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.bunifuCheckbox1.ForeColor = System.Drawing.Color.White;
            this.bunifuCheckbox1.Location = new System.Drawing.Point(-15, -15);
            this.bunifuCheckbox1.Name = "bunifuCheckbox1";
            this.bunifuCheckbox1.Size = new System.Drawing.Size(20, 20);
            this.bunifuCheckbox1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(122, 374);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(109, 37);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.lblUserName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.lblUserName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lblUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserName.HintForeColor = System.Drawing.Color.Empty;
            this.lblUserName.HintText = "";
            this.lblUserName.isPassword = false;
            this.lblUserName.LineFocusedColor = System.Drawing.Color.Blue;
            this.lblUserName.LineIdleColor = System.Drawing.Color.Gray;
            this.lblUserName.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lblUserName.LineThickness = 3;
            this.lblUserName.Location = new System.Drawing.Point(62, 216);
            this.lblUserName.Margin = new System.Windows.Forms.Padding(4);
            this.lblUserName.MaxLength = 32767;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(261, 33);
            this.lblUserName.TabIndex = 4;
            this.lblUserName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.lblPassWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.lblPassWord.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.lblPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblPassWord.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lblPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassWord.HintForeColor = System.Drawing.Color.Empty;
            this.lblPassWord.HintText = "";
            this.lblPassWord.isPassword = true;
            this.lblPassWord.LineFocusedColor = System.Drawing.Color.Blue;
            this.lblPassWord.LineIdleColor = System.Drawing.Color.Gray;
            this.lblPassWord.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.lblPassWord.LineThickness = 3;
            this.lblPassWord.Location = new System.Drawing.Point(62, 270);
            this.lblPassWord.Margin = new System.Windows.Forms.Padding(4);
            this.lblPassWord.MaxLength = 32767;
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(261, 33);
            this.lblPassWord.TabIndex = 5;
            this.lblPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lblPassWord.Enter += new System.EventHandler(this.enter_Login);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(30, 220);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(25, 29);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 6;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(30, 274);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(25, 29);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 7;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // bunifuiOSSwitch1
            // 
            this.bunifuiOSSwitch1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuiOSSwitch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuiOSSwitch1.BackgroundImage")));
            this.bunifuiOSSwitch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuiOSSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuiOSSwitch1.Location = new System.Drawing.Point(87, 324);
            this.bunifuiOSSwitch1.Name = "bunifuiOSSwitch1";
            this.bunifuiOSSwitch1.OffColor = System.Drawing.Color.Gray;
            this.bunifuiOSSwitch1.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.bunifuiOSSwitch1.Size = new System.Drawing.Size(35, 20);
            this.bunifuiOSSwitch1.TabIndex = 8;
            this.bunifuiOSSwitch1.Value = true;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(139, 328);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(96, 13);
            this.bunifuCustomLabel1.TabIndex = 9;
            this.bunifuCustomLabel1.Text = "Recordar Usuario?";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.BunifuCustomLabel1_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(47, 75);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(250, 132);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 10;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.BunifuImageButton3_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 450);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.bunifuiOSSwitch1);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.bunifuCheckbox1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JRSolutions Facturacion";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCheckbox bunifuCheckbox1;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lblUserName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lblPassWord;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuiOSSwitch bunifuiOSSwitch1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
    }
}