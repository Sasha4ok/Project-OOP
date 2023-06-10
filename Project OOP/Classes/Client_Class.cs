namespace Project_OOP.Classes
{
    using System;
    using Interfaces;
    using Models;

    public class Client : IUser
    {
        private int UserId { get; set; }
        private String Login { get; }
        private String Password { get; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public bool Admin { get; set; }
        public String FullName => Name + " " + Surname;

        public Client(UsersModel userModel)
        {
            UserId = userModel.Id;
            Login = userModel.Login;
            Password = userModel.Password;
            Name = userModel.Name;
            Surname = userModel.Surname;
            Email = userModel.Email;
            PhoneNumber = userModel.Phone;
        }

        public void ShowInfo()
        {
            Console.WriteLine(@"ID: " + UserId);
            Console.WriteLine(@"Login: " + Login);
            Console.WriteLine(@"Password: " + Password);
            Console.WriteLine(@"Name: " + Name);
            Console.WriteLine(@"Surname: " + Surname);
            Console.WriteLine(@"Email: " + Email);
            Console.WriteLine(@"Phone number: " + PhoneNumber);

        }

    }
}
