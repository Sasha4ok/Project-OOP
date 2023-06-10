using System;
using Project_OOP.Interfaces;
using Project_OOP.Models;

namespace Project_OOP.Classes
{
    public class Administrator : IUser
    {
        private int UserId { get; set; }
        private String Login { get; }
        private String Password { get; }
        
        public String Name { get; set; }
        public String Surname { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public String FullName => Name + " " + Surname;

        public Administrator(UsersModel userModel)
        {
            UserId = userModel.Id;
            Login = userModel.Login;
            Password = userModel.Password;
            Name = userModel.Name;
            Surname = userModel.Surname;
            PhoneNumber = userModel.Phone;
            Email = userModel.Email;
        }

    }
}
