using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;
using Technico.Repositories;

namespace Technico.Services
{
    internal class RepairService
    {
        private readonly IRepairRepository repairRepository;

        public RepairService(IRepairRepository repairRepository)
        {
            this.repairRepository = repairRepository;
        }

        public void createRepair(Repair repair)
        {
            repairRepository.InsertRepair(repair);
        }
        public bool deleteRepairById(Guid id)
        {
            return repairRepository.Delete(id);
        }

        public Repair? getRepairById(Guid id)
        {
            return repairRepository.GetRepairByID(id);
        }

    }
}
