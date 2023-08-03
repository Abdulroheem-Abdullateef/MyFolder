using BusManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces.Repositories
{
    interface ITripRepository
    {
        Trip Create(Trip bus);

        Trip Get(int id);

        List<Trip> GetAll();


        void Delete(Trip bus);

        bool ExistById(int id);

    }
}
