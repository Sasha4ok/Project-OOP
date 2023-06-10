using Project_OOP.Classes;
using Project_OOP.Models;

namespace Project_OOP.Interfaces
{
    public interface IDBUser
    {
        bool UserExists(String login, String password);
        bool LoginUserExists(String login);
        UsersModel AddUser(String login, String password,
            String name, String surname, String email, String phoneNumber);
        void AddUser(Client user, String login, String password);
        void DeleteUser(String login, String password);
        void UpdateUser(int idUser, String phone, String email);
        UsersModel SelectUser(int idUser);
        UsersModel SelectUser(String login, String password);
        List<UsersModel> SelectUsers();
    }
}
