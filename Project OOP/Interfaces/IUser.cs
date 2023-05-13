namespace Project_OOP.Interfaces
{
    using System;
    internal interface IUser
    {
        String Name { get; set; }
        String Surname { get; set; }
        String Email { get; set; }
        String PhoneNumber { get; set; }
        public String FullName { get; }
    }
}
