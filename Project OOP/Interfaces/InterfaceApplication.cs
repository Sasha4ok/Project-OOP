namespace Project_OOP.Interfaces
{

    using System;
    using System.Collections.Generic;
    using Models;

    public interface InterfaceApplication
    {
        void CreateNewApplication(ApplicationModel applicationModel);
        ApplicationModel SelectApplication(int idApplication);
        List<ApplicationModel> SelectApplications();
        void UpdateApplication(int idApplication, String status, String notes);
        void UpdateApplication(int idApplication, String statusOrNotes);
        ApplicationModel GetApplicationsByStatus(String status);
        CarsModel GetCarApplications(int idApplication);
        UsersModel GetUsers(int idApplication);
    }
}