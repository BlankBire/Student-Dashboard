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
            ptbLogo.Location = new Point(27, 2);
            ptbLogo.Margin = new Padding(2, 2, 2, 2);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(113, 118);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 0;
            ptbLogo.TabStop = false;
            ptbLogo.Click += ptbLogo_Click;
            // 
            // btHome
            // 
            btHome.FlatStyle = FlatStyle.Flat;
            btHome.Location = new Point(784, 29);
            btHome.Margin = new Padding(2, 2, 2, 2);
            btHome.Name = "btHome";
            btHome.Size = new Size(137, 32);
            btHome.TabIndex = 1;
            btHome.Text = "Home";
            btHome.UseVisualStyleBackColor = true;
            btHome.Click += btHome_Click;
            // 
            // btSupport
            // 
            btSupport.FlatStyle = FlatStyle.Flat;
            btSupport.Location = new Point(957, 29);
            btSupport.Margin = new Padding(2, 2, 2, 2);
            btSupport.Name = "btSupport";
            btSupport.Size = new Size(137, 32);
            btSupport.TabIndex = 2;
            btSupport.Text = "Support";
            btSupport.UseVisualStyleBackColor = true;
            // 
            // btAccount
            // 
            btAccount.FlatStyle = FlatStyle.Flat;
            btAccount.Location = new Point(1128, 29);
            btAccount.Margin = new Padding(2, 2, 2, 2);
            btAccount.Name = "btAccount";
            btAccount.Size = new Size(137, 32);
            btAccount.TabIndex = 3;
            btAccount.Text = "My account";
            btAccount.UseVisualStyleBackColor = true;
            btAccount.Click += btAccount_Click;
            // 
            // HeaderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btAccount);
            Controls.Add(btSupport);
            Controls.Add(btHome);
            Controls.Add(ptbLogo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "HeaderControl";
            Size = new Size(1312, 122);
            Load += HeaderControl_Load;
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
