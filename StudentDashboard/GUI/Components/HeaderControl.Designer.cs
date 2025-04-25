namespace StudentDashboard.GUI.Components
{
    partial class HeaderControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderControl));
            ptbLogo = new PictureBox();
            btHome = new Button();
            btSupport = new Button();
            btAccount = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            SuspendLayout();
            // 
            // ptbLogo
            // 
            ptbLogo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ptbLogo.Enabled = false;
            ptbLogo.Image = (Image)resources.GetObject("ptbLogo.Image");
            ptbLogo.Location = new Point(39, 3);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(161, 144);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 0;
            ptbLogo.TabStop = false;
            // 
            // btHome
            // 
            btHome.FlatStyle = FlatStyle.Flat;
            btHome.Location = new Point(1120, 49);
            btHome.Name = "btHome";
            btHome.Size = new Size(196, 53);
            btHome.TabIndex = 1;
            btHome.Text = "Home";
            btHome.UseVisualStyleBackColor = true;
            btHome.Click += btHome_Click;
            // 
            // btSupport
            // 
            btSupport.FlatStyle = FlatStyle.Flat;
            btSupport.Location = new Point(1367, 49);
            btSupport.Name = "btSupport";
            btSupport.Size = new Size(196, 53);
            btSupport.TabIndex = 2;
            btSupport.Text = "Support";
            btSupport.UseVisualStyleBackColor = true;
            // 
            // btAccount
            // 
            btAccount.FlatStyle = FlatStyle.Flat;
            btAccount.Location = new Point(1611, 49);
            btAccount.Name = "btAccount";
            btAccount.Size = new Size(196, 53);
            btAccount.TabIndex = 3;
            btAccount.Text = "My account";
            btAccount.UseVisualStyleBackColor = true;
            btAccount.Click += btAccount_Click;
            // 
            // HeaderControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btAccount);
            Controls.Add(btSupport);
            Controls.Add(btHome);
            Controls.Add(ptbLogo);
            Name = "HeaderControl";
            Size = new Size(1875, 150);
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbLogo;
        private Button btHome;
        private Button btSupport;
        private Button btAccount;
    }
}
