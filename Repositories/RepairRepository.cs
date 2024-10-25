using java.security.acl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Repositories
{
    internal class RepairRepository : IRepairRepository
    {
        private readonly AppDbContext context;
        public RepairRepository(AppDbContext context) {
            this.context = context; 
        }
        public bool Delete(Guid repairId)
        {
            var repair = context.Repairs.Single(repair => repairId == repair.Id);
            context.Repairs.Remove(repair);
            context.SaveChanges();
            return true;
        }

        public Repair? GetRepairByID(Guid repairId)
        {
            return context.Repairs.FirstOrDefault(repair => repairId == repair.Id);
        }

        public IEnumerable<Repair> GetRepairs()
        {
            return context.Repairs;
        }

        public void InsertRepair(Repair repair)
        {
            context.Repairs.Add(repair);
            context.SaveChanges();
        }

        public void UpdateRepair(Repair repair)
        {
            throw new NotImplementedException();
        }
    }
}
