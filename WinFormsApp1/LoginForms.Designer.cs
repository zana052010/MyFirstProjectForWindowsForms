namespace WinFormsApp1
{
    partial class LoginForms
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
            components = new System.ComponentModel.Container();
            MainPanel = new Panel();
            ButttonReg1 = new Button();
            ButtonLogin = new Button();
            PassLogin = new TextBox();
            LoginField = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            TopPanel = new Panel();
            Close_Button = new Label();
            label1 = new Label();
            imageList1 = new ImageList(components);
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(107, 212, 104);
            MainPanel.Controls.Add(ButttonReg1);
            MainPanel.Controls.Add(ButtonLogin);
            MainPanel.Controls.Add(PassLogin);
            MainPanel.Controls.Add(LoginField);
            MainPanel.Controls.Add(pictureBox2);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 450);
            MainPanel.TabIndex = 0;
            MainPanel.MouseDown += MainPanel_MouseDown;
            MainPanel.MouseMove += MainPanel_MouseMove;
            // 
            // ButttonReg1
            // 
            ButttonReg1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButttonReg1.BackColor = Color.FromArgb(120, 200, 110);
            ButttonReg1.Cursor = Cursors.Hand;
            ButttonReg1.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 170, 110);
            ButttonReg1.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 190, 110);
            ButttonReg1.FlatStyle = FlatStyle.Flat;
            ButttonReg1.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButttonReg1.Location = new Point(467, 327);
            ButttonReg1.Name = "ButttonReg1";
            ButttonReg1.Size = new Size(224, 77);
            ButttonReg1.TabIndex = 6;
            ButttonReg1.Text = "РЕГЕСТРАЦИЯ";
            ButttonReg1.UseVisualStyleBackColor = false;
            ButttonReg1.Click += ButttonReg1_Click;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonLogin.BackColor = Color.FromArgb(120, 200, 110);
            ButtonLogin.Cursor = Cursors.Hand;
            ButtonLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 170, 110);
            ButtonLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 190, 110);
            ButtonLogin.FlatStyle = FlatStyle.Flat;
            ButtonLogin.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonLogin.Location = new Point(181, 327);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(224, 77);
            ButtonLogin.TabIndex = 5;
            ButtonLogin.Text = "ВОЙТИ";
            ButtonLogin.UseVisualStyleBackColor = false;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // PassLogin
            // 
            PassLogin.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PassLogin.Location = new Point(357, 252);
            PassLogin.Name = "PassLogin";
            PassLogin.PasswordChar = '*';
            PassLogin.Size = new Size(186, 29);
            PassLogin.TabIndex = 4;
            PassLogin.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginField.Location = new Point(357, 173);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(186, 29);
            LoginField.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.locked_12714906;
            pictureBox2.Location = new Point(287, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_16111568;
            pictureBox1.Location = new Point(287, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(87, 143, 161);
            TopPanel.Controls.Add(Close_Button);
            TopPanel.Controls.Add(label1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 100);
            TopPanel.TabIndex = 0;
            // 
            // Close_Button
            // 
            Close_Button.AutoSize = true;
            Close_Button.Cursor = Cursors.Hand;
            Close_Button.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Close_Button.Location = new Point(757, 0);
            Close_Button.Name = "Close_Button";
            Close_Button.Size = new Size(43, 47);
            Close_Button.TabIndex = 1;
            Close_Button.Text = "X";
            Close_Button.Click += Close_Button_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(262, 22);
            label1.Name = "label1";
            label1.Size = new Size(307, 52);
            label1.TabIndex = 0;
            label1.Text = "АВТОРИЗАЦИЯ";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // LoginForms
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForms";
            Text = "Form1";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Panel TopPanel;
        private Label label1;
        private Label Close_Button;
        private ImageList imageList1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox LoginField;
        private TextBox PassLogin;
        private Button ButtonLogin;
        private Button ButttonReg1;
    }
}