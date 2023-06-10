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
            passwordT = new MaterialSkin.Controls.MaterialTextBox();
            loginT = new MaterialSkin.Controls.MaterialTextBox();
            tabPage2 = new TabPage();
            PhoneR = new MaterialSkin.Controls.MaterialMaskedTextBox();
            EmailR = new MaterialSkin.Controls.MaterialTextBox();
            SurnameR = new MaterialSkin.Controls.MaterialTextBox();
            PasswordR = new MaterialSkin.Controls.MaterialTextBox();
            NameR = new MaterialSkin.Controls.MaterialTextBox();
            LoginR = new MaterialSkin.Controls.MaterialTextBox();
            Registration = new MaterialSkin.Controls.MaterialButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(3, 64);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(408, 306);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Enter_Button);
            tabPage1.Controls.Add(passwordT);
            tabPage1.Controls.Add(loginT);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(400, 268);
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
            Enter_Button.UseVisualStyleBackColor = false;
            Enter_Button.Click += Enter_Button_Click;
            // 
            // passwordT
            // 
            passwordT.AnimateReadOnly = false;
            passwordT.BorderStyle = BorderStyle.None;
            passwordT.Depth = 0;
            passwordT.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            passwordT.Hint = "Пароль";
            passwordT.LeadingIcon = null;
            passwordT.Location = new Point(36, 104);
            passwordT.MaxLength = 50;
            passwordT.MouseState = MaterialSkin.MouseState.OUT;
            passwordT.Multiline = false;
            passwordT.Name = "passwordT";
            passwordT.Password = true;
            passwordT.Size = new Size(312, 50);
            passwordT.TabIndex = 1;
            passwordT.Text = "";
            passwordT.TrailingIcon = null;
            // 
            // loginT
            // 
            loginT.AnimateReadOnly = false;
            loginT.BorderStyle = BorderStyle.None;
            loginT.Depth = 0;
            loginT.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            loginT.Hint = "Логін";
            loginT.LeadingIcon = null;
            loginT.Location = new Point(36, 33);
            loginT.MaxLength = 50;
            loginT.MouseState = MaterialSkin.MouseState.OUT;
            loginT.Multiline = false;
            loginT.Name = "loginT";
            loginT.Size = new Size(312, 50);
            loginT.TabIndex = 0;
            loginT.Text = "";
            loginT.TrailingIcon = null;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(PhoneR);
            tabPage2.Controls.Add(EmailR);
            tabPage2.Controls.Add(SurnameR);
            tabPage2.Controls.Add(PasswordR);
            tabPage2.Controls.Add(NameR);
            tabPage2.Controls.Add(LoginR);
            tabPage2.Controls.Add(Registration);
            tabPage2.Location = new Point(4, 34);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(400, 268);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Реєстрація";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // PhoneR
            // 
            PhoneR.AllowPromptAsInput = true;
            PhoneR.AnimateReadOnly = false;
            PhoneR.AsciiOnly = false;
            PhoneR.BackgroundImageLayout = ImageLayout.None;
            PhoneR.BeepOnError = false;
            PhoneR.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            PhoneR.Depth = 0;
            PhoneR.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PhoneR.HidePromptOnLeave = false;
            PhoneR.HideSelection = true;
            PhoneR.Hint = "Телефоний номер";
            PhoneR.InsertKeyMode = InsertKeyMode.Default;
            PhoneR.LeadingIcon = null;
            PhoneR.Location = new Point(204, 148);
            PhoneR.Mask = "00-000-00-00";
            PhoneR.MaxLength = 32767;
            PhoneR.MouseState = MaterialSkin.MouseState.OUT;
            PhoneR.Name = "PhoneR";
            PhoneR.PasswordChar = '\0';
            PhoneR.PrefixSuffix = MaterialSkin.Controls.MaterialMaskedTextBox.PrefixSuffixTypes.Prefix;
            PhoneR.PrefixSuffixText = "+380";
            PhoneR.PromptChar = '_';
            PhoneR.ReadOnly = false;
            PhoneR.RejectInputOnFirstFailure = false;
            PhoneR.ResetOnPrompt = true;
            PhoneR.ResetOnSpace = true;
            PhoneR.RightToLeft = RightToLeft.No;
            PhoneR.SelectedText = "";
            PhoneR.SelectionLength = 0;
            PhoneR.SelectionStart = 0;
            PhoneR.ShortcutsEnabled = true;
            PhoneR.Size = new Size(167, 48);
            PhoneR.SkipLiterals = true;
            PhoneR.TabIndex = 7;
            PhoneR.TabStop = false;
            PhoneR.Text = "  -   -  -";
            PhoneR.TextAlign = HorizontalAlignment.Left;
            PhoneR.TextMaskFormat = MaskFormat.IncludeLiterals;
            PhoneR.TrailingIcon = null;
            PhoneR.UseSystemPasswordChar = false;
            PhoneR.ValidatingType = null;
            // 
            // EmailR
            // 
            EmailR.AnimateReadOnly = false;
            EmailR.BorderStyle = BorderStyle.None;
            EmailR.Depth = 0;
            EmailR.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            EmailR.Hint = "Пошта";
            EmailR.LeadingIcon = null;
            EmailR.Location = new Point(22, 148);
            EmailR.MaxLength = 50;
            EmailR.MouseState = MaterialSkin.MouseState.OUT;
            EmailR.Multiline = false;
            EmailR.Name = "EmailR";
            EmailR.Size = new Size(159, 50);
            EmailR.TabIndex = 5;
            EmailR.Text = "";
            EmailR.TrailingIcon = null;
            // 
            // SurnameR
            // 
            SurnameR.AnimateReadOnly = false;
            SurnameR.BorderStyle = BorderStyle.None;
            SurnameR.Depth = 0;
            SurnameR.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            SurnameR.Hint = "Прізвище";
            SurnameR.LeadingIcon = null;
            SurnameR.Location = new Point(204, 85);
            SurnameR.MaxLength = 50;
            SurnameR.MouseState = MaterialSkin.MouseState.OUT;
            SurnameR.Multiline = false;
            SurnameR.Name = "SurnameR";
            SurnameR.Size = new Size(167, 50);
            SurnameR.TabIndex = 4;
            SurnameR.Text = "";
            SurnameR.TrailingIcon = null;
            // 
            // PasswordR
            // 
            PasswordR.AnimateReadOnly = false;
            PasswordR.BorderStyle = BorderStyle.None;
            PasswordR.Depth = 0;
            PasswordR.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PasswordR.Hint = "Пароль";
            PasswordR.LeadingIcon = null;
            PasswordR.Location = new Point(204, 14);
            PasswordR.MaxLength = 50;
            PasswordR.MouseState = MaterialSkin.MouseState.OUT;
            PasswordR.Multiline = false;
            PasswordR.Name = "PasswordR";
            PasswordR.Password = true;
            PasswordR.Size = new Size(167, 50);
            PasswordR.TabIndex = 3;
            PasswordR.Text = "";
            PasswordR.TrailingIcon = null;
            // 
            // NameR
            // 
            NameR.AnimateReadOnly = false;
            NameR.BorderStyle = BorderStyle.None;
            NameR.Depth = 0;
            NameR.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            NameR.Hint = "Ім'я";
            NameR.LeadingIcon = null;
            NameR.Location = new Point(22, 85);
            NameR.MaxLength = 50;
            NameR.MouseState = MaterialSkin.MouseState.OUT;
            NameR.Multiline = false;
            NameR.Name = "NameR";
            NameR.Size = new Size(159, 50);
            NameR.TabIndex = 2;
            NameR.Text = "";
            NameR.TrailingIcon = null;
            // 
            // LoginR
            // 
            LoginR.AnimateReadOnly = false;
            LoginR.BorderStyle = BorderStyle.None;
            LoginR.Depth = 0;
            LoginR.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LoginR.Hint = "Логін";
            LoginR.LeadingIcon = null;
            LoginR.Location = new Point(22, 14);
            LoginR.MaxLength = 50;
            LoginR.MouseState = MaterialSkin.MouseState.OUT;
            LoginR.Multiline = false;
            LoginR.Name = "LoginR";
            LoginR.Size = new Size(159, 50);
            LoginR.TabIndex = 1;
            LoginR.Text = "";
            LoginR.TrailingIcon = null;
            // 
            // Registration
            // 
            Registration.AutoSize = false;
            Registration.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Registration.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Registration.Depth = 0;
            Registration.HighEmphasis = true;
            Registration.Icon = null;
            Registration.Location = new Point(113, 205);
            Registration.Margin = new Padding(4, 6, 4, 6);
            Registration.MouseState = MaterialSkin.MouseState.HOVER;
            Registration.Name = "Registration";
            Registration.NoAccentTextColor = Color.Empty;
            Registration.Size = new Size(162, 54);
            Registration.TabIndex = 0;
            Registration.Text = "Зареєструватись";
            Registration.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Registration.UseAccentColor = false;
            Registration.UseVisualStyleBackColor = true;
            Registration.Click += Registration_Click;
            // 
            // AuthenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(414, 373);
            Controls.Add(tabControl1);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "AuthenForm";
            Text = "Вхід у систему";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private MaterialSkin.Controls.MaterialButton Enter_Button;
        private MaterialSkin.Controls.MaterialTextBox passwordT;
        private MaterialSkin.Controls.MaterialTextBox loginT;
        private MaterialSkin.Controls.MaterialTextBox EmailR;
        private MaterialSkin.Controls.MaterialTextBox SurnameR;
        private MaterialSkin.Controls.MaterialTextBox PasswordR;
        private MaterialSkin.Controls.MaterialTextBox NameR;
        private MaterialSkin.Controls.MaterialTextBox LoginR;
        private MaterialSkin.Controls.MaterialButton Registration;
        private MaterialSkin.Controls.MaterialMaskedTextBox PhoneR;
    }
}