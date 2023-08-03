using BusManagementSystem.DTOS;
using BusManagementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagementSystem.Interfaces.Repositories
{
    interface IBusRepository
    {
        Bus Create(Bus bus);

        Bus Get(int id);

        List<BusDto> GetAll();

        Bus GetByRegistrationNumber(string registrationNumber);

        List<BusDto> GetAvailableBuses();

        Bus Update(Bus bus);

        void Delete(Bus bus);

        bool ExistById(int id);

        bool ExistByRegNumber(string regNum);
    }
}
