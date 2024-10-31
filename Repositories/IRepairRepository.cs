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
        Repair InsertRepair(Repair repair);
        bool Delete(Guid repairId);
        Repair UpdateRepair(Repair repair);
    }
}

