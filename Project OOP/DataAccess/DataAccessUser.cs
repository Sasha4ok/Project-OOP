namespace Project_OOP.Linq 
{
    using Project_OOP.Classes;
    using Project_OOP.Interfaces;
    using Project_OOP.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Contexts;

    public class DataAccessUser : IDBUser
    {
        private readonly ApplicationContext _db = new ApplicationContext();

        public bool UserExists(String login, String password)
        {
            return _db.UserDataBase.FirstOrDefault(u => u.Login == login && u.Password == password) != null;
        }

        public bool LoginUserExists(String login)
        {
            return _db.UserDataBase.FirstOrDefault(u => u.Login == login) != null;
        }

        public UsersModel AddUser(String login, String password, String name, String surname, String email, String phoneNumber)
        {
            UsersModel userModel = new UsersModel();

            userModel.Login = login;
            userModel.Password = password;
            userModel.Name = name;
            userModel.Surname = surname;
            userModel.Email = email;
            userModel.Phone = phoneNumber;
            userModel.Admin = false;

            _db.UserDataBase.Add(userModel);
            _db.SaveChanges();

            return userModel;
        }

        public void AddUser(Client user, String login, String password)
        {
            UsersModel userModelDb = new UsersModel();

            userModelDb.Login = login;
            userModelDb.Password = password;
            userModelDb.Name = user.Name;
            userModelDb.Surname = user.Surname;
            userModelDb.Phone = user.PhoneNumber;
            userModelDb.Email = user.Email;

            _db.UserDataBase.Add(userModelDb);
            _db.SaveChanges();
        }

        public void DeleteUser(String login, String password)
        {
            UsersModel userModel = _db.UserDataBase.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (userModel != null)
            {
                _db.UserDataBase.Remove(userModel);
                _db.SaveChanges();
            }
            else
            {
                throw new Exception("Користувача не знайдено");
            }
        }

        public void UpdateUser(int idUser, String phone, String email)
        {
            UsersModel user = _db.UserDataBase.FirstOrDefault(u => u.Id == idUser);

            if (user == null) throw new Exception("Користувача не знайдено");

            user.Phone = phone;
            user.Email = email;
            _db.SaveChanges();
        }

        public UsersModel SelectUser(int idUser)
        {
            var usr = _db.UserDataBase.FirstOrDefault(user => user.Id == idUser);
            return usr ?? null;
        }

        public UsersModel SelectUser(String login, String password)
        {
            return _db.UserDataBase.First(user => user.Login == login && user.Password == password);
        }

        public List<UsersModel> SelectUsers()
        {
            return _db.UserDataBase.ToList();
        }
    }
}
