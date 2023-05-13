using System;
using Project_OOP.Interfaces;
using Project_OOP.Models;

namespace Project_OOP.Classes
{
    public class Administrator : IUser
    {
        private String Login { get; }
        private String Password { get; }
        private int UserId { get; set; }
        public String Name { get; set; }
        public String Surname { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public String FullName => Name + " " + Surname;

        public Administrator(UsersModel userModel)
        {
            Login = userModel.Login;
            Password = userModel.Password;
            UserId = userModel.Id;
            Name = userModel.Name;
            Surname = userModel.Surname;
            PhoneNumber = userModel.Phone;
            Email = userModel.Email;
        }

    }
}
