
namespace Project_OOP.Linq
{
    using Project_OOP.Models;
    using System.Collections.Generic;
    using System.Linq;
    using Contexts;

    public class DataAccessApplication
    {
        private ApplicationContext _db = new ApplicationContext();

        public void CreateNewApplication(ApplicationModel applicationModel)
        {
            _db.ApplicationDataBase.Add(applicationModel);
        }

        public ApplicationModel SelectApplication(int idApplication)
        {
            return _db.ApplicationDataBase.FirstOrDefault(app => app.Id == idApplication);
        }

        public List<ApplicationModel> SelectApplications()
        {
            return _db.ApplicationDataBase.ToList();
        }

        public void UpdateApplication(int idApplication, string status, string notes)
        {
            return;
        }

        public void UpdateApplication(int idApplication, string statusOrNotes)
        {
            return;
        }

        public UsersModel GetUserApplications(int idApplication)
        {
            return new UsersModel();
        }

        public CarsModel GetCarApplications(int idApplication)
        {
            return new CarsModel();
        }

        public ApplicationModel GetApplicationsByStatus(string status)
        {
            return new ApplicationModel();
        }
    }
}
