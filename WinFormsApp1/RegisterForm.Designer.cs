namespace WinFormsApp1
{
    partial class RegisterForm
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
            MainPanel = new Panel();
            ButtonRegist = new Button();
            ButtonLogin = new Button();
            PassField1 = new TextBox();
            LoginField1 = new TextBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            TopPanel = new Panel();
            Close_Button1 = new Label();
            label1 = new Label();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(107, 212, 104);
            MainPanel.Controls.Add(ButtonRegist);
            MainPanel.Controls.Add(ButtonLogin);
            MainPanel.Controls.Add(PassField1);
            MainPanel.Controls.Add(LoginField1);
            MainPanel.Controls.Add(pictureBox2);
            MainPanel.Controls.Add(pictureBox1);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(783, 413);
            MainPanel.TabIndex = 1;
            MainPanel.MouseDown += MainPanel_MouseDown_1;
            MainPanel.MouseMove += MainPanel_MouseMove_1;
            // 
            // ButtonRegist
            // 
            ButtonRegist.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ButtonRegist.BackColor = Color.FromArgb(120, 200, 110);
            ButtonRegist.Cursor = Cursors.Hand;
            ButtonRegist.FlatAppearance.MouseDownBackColor = Color.FromArgb(120, 170, 110);
            ButtonRegist.FlatAppearance.MouseOverBackColor = Color.FromArgb(120, 190, 110);
            ButtonRegist.FlatStyle = FlatStyle.Flat;
            ButtonRegist.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ButtonRegist.Location = new Point(291, 306);
            ButtonRegist.Name = "ButtonRegist";
            ButtonRegist.Size = new Size(224, 77);
            ButtonRegist.TabIndex = 6;
            ButtonRegist.Text = "СОЗДАТЬ";
            ButtonRegist.UseVisualStyleBackColor = false;
            ButtonRegist.Click += ButtonRegist_Click;
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
            ButtonLogin.Location = new Point(307, 465);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(807, 77);
            ButtonLogin.TabIndex = 5;
            ButtonLogin.Text = "ВОЙТИ";
            ButtonLogin.UseVisualStyleBackColor = false;
            // 
            // PassField1
            // 
            PassField1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PassField1.Location = new Point(332, 237);
            PassField1.Name = "PassField1";
            PassField1.PasswordChar = '*';
            PassField1.Size = new Size(186, 29);
            PassField1.TabIndex = 4;
            PassField1.UseSystemPasswordChar = true;
            // 
            // LoginField1
            // 
            LoginField1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LoginField1.Location = new Point(332, 153);
            LoginField1.Name = "LoginField1";
            LoginField1.Size = new Size(186, 29);
            LoginField1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.locked_12714906;
            pictureBox2.Location = new Point(262, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_16111568;
            pictureBox1.Location = new Point(262, 134);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(64, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.FromArgb(87, 143, 161);
            TopPanel.Controls.Add(Close_Button1);
            TopPanel.Controls.Add(label1);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(783, 100);
            TopPanel.TabIndex = 0;
            // 
            // Close_Button1
            // 
            Close_Button1.AutoSize = true;
            Close_Button1.Cursor = Cursors.Hand;
            Close_Button1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Close_Button1.Location = new Point(740, 0);
            Close_Button1.Name = "Close_Button1";
            Close_Button1.Size = new Size(43, 47);
            Close_Button1.TabIndex = 1;
            Close_Button1.Text = "X";
            Close_Button1.Click += Close_Button1_Click_1;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI Semibold", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(262, 22);
            label1.Name = "label1";
            label1.Size = new Size(299, 52);
            label1.TabIndex = 0;
            label1.Text = "РЕГИСТРАЦИЯ";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(783, 413);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
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
        private Button ButtonLogin;
        private TextBox PassField1;
        private TextBox LoginField1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel TopPanel;
        private Label Close_Button1;
        private Label label1;
        private Button ButtonRegist;
    }
}