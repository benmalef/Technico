using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Repositories
{
    public interface IRepairRepository
    {
        IEnumerable<Repair> GetRepairs();
        Repair? GetRepairByID(Guid repairId);
        void InsertRepair(Repair repair);
        bool Delete(Guid repairId);
        void UpdateRepair(Repair repair);
    }
}

