using System;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using Project_OOP.Classes;
using Project_OOP.Linq;
using Project_OOP.Models;

namespace Project_OOP.Forms
{
    public partial class AuthenForm : MaterialForm
    {
        private readonly DataAccessUser _controllerUsers = new DataAccessUser();
        public AuthenForm()
        {
            InitializeComponent();


            MaterialSkinManager skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
            Primary.Green800,
            Primary.Green900,
            Primary.Green500,
            Accent.LightGreen200,
            TextShade.WHITE
                    );
        }


        private void Enter_Button_Click(object sender, EventArgs e)
        {
            String login = loginT.Text, password = passwordT.Text;

            if (_controllerUsers.UserExists(login, password))
            {
                UsersModel userModelDb = _controllerUsers.SelectUser(login, password);
                Client user = new Client(userModelDb);
                user.ShowInfo();

                if (!user.Admin)
                {
                    ClientForm userForm = new ClientForm(user);
                    this.Hide();
                    userForm.ShowDialog();
                }
                else
                {
                    AdminForm adminForm = new AdminForm(new Administrator(userModelDb));
                    this.Hide();
                    adminForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show(@"Невірний логін або пароль",
                    @"Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            String
                login = LoginR.Text,
                password = PasswordR.Text,
                name = NameR.Text,
                surname = SurnameR.Text,
                email = EmailR.Text,
                phone = PhoneR.Text;

            //if (login.Length != 0 &&
            //    password.Length != 0 &&
            //    name.Length != 0 &&
            //    surname.Length != 0 &&
            //    email.Length != 0 &&
            //    phone.Length != 0
            //   )
            //    MessageBox.Show(
            //        @"Введіть коректно дані",
            //        @"Авторизація",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error);

            if (!_controllerUsers.LoginUserExists(login))
            {
                UsersModel userModel = _controllerUsers.AddUser(login, password, name, surname, email, phone);
                Client client = new Client(userModel);
                client.ShowInfo();

                MessageBox.Show(
                    @"Успішна Реєстрація",
                    @"Авторизація",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    @"Користувач з таким логіном вже існує",
                    @"Помилка авторизації",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
