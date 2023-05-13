namespace Project_OOP.Forms
{
    partial class AuthenForm
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Enter_Button = new MaterialSkin.Controls.MaterialButton();
            password_E = new MaterialSkin.Controls.MaterialTextBox();
            login_E = new MaterialSkin.Controls.MaterialTextBox();
            tabPage2 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(3, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(408, 306);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Enter_Button);
            tabPage1.Controls.Add(password_E);
            tabPage1.Controls.Add(login_E);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(400, 272);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Вхід";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Enter_Button
            // 
            Enter_Button.AutoSize = false;
            Enter_Button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Enter_Button.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Enter_Button.Depth = 0;
            Enter_Button.HighEmphasis = true;
            Enter_Button.Icon = null;
            Enter_Button.Location = new Point(106, 187);
            Enter_Button.Margin = new Padding(4, 6, 4, 6);
            Enter_Button.MouseState = MaterialSkin.MouseState.HOVER;
            Enter_Button.Name = "Enter_Button";
            Enter_Button.NoAccentTextColor = Color.Empty;
            Enter_Button.Size = new Size(167, 41);
            Enter_Button.TabIndex = 2;
            Enter_Button.Text = "Увійти";
            Enter_Button.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Enter_Button.UseAccentColor = false;
            Enter_Button.UseVisualStyleBackColor = true;
            // 
            // password_E
            // 
            password_E.AnimateReadOnly = false;
            password_E.BorderStyle = BorderStyle.None;
            password_E.Depth = 0;
            password_E.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            password_E.Hint = "Пароль";
            password_E.LeadingIcon = null;
            password_E.Location = new Point(221, 89);
            password_E.MaxLength = 50;
            password_E.MouseState = MaterialSkin.MouseState.OUT;
            password_E.Multiline = false;
            password_E.Name = "password_E";
            password_E.Password = true;
            password_E.Size = new Size(138, 50);
            password_E.TabIndex = 1;
            password_E.Text = "";
            password_E.TrailingIcon = null;
            // 
            // login_E
            // 
            login_E.AnimateReadOnly = false;
            login_E.BorderStyle = BorderStyle.None;
            login_E.Depth = 0;
            login_E.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            login_E.Hint = "Логін";
            login_E.LeadingIcon = null;
            login_E.Location = new Point(31, 89);
            login_E.MaxLength = 50;
            login_E.MouseState = MaterialSkin.MouseState.OUT;
            login_E.Multiline = false;
            login_E.Name = "login_E";
            login_E.Size = new Size(141, 50);
            login_E.TabIndex = 0;
            login_E.Text = "";
            login_E.TrailingIcon = null;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(400, 278);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Реєстрація";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // AuthenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 373);
            Controls.Add(tabControl1);
            Name = "AuthenForm";
            Text = "Вхід у систему";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton Enter_Button;
        private MaterialSkin.Controls.MaterialTextBox password_E;
        private MaterialSkin.Controls.MaterialTextBox login_E;
    }
}