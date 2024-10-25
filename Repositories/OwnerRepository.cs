using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Tecnico.Models;


namespace Tecnico.Repositories
{
     class OwnerRepository : IOwnerRepository
    {
        private readonly AppDbContext context;
        public OwnerRepository(AppDbContext context) {
         this.context = context;   
        }

        public bool Delete(int ownerID)
        {
           //return context.Owners.Remove(ownerID);
           return true;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Owner GetOwnerByID(int ownerID)
        {
            return context.Owners.Single(owner => ownerID == owner.ID);
        }

        public IEnumerable<Owner> GetOwners()
        {
            return context.Owners;
        }

        public void InsertOwner(Owner owner)
        {
            context.Owners.Add(owner);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateOwner(Owner owner)
        {
            //var findOwner = GetOwnerByID(owner.ID);
            //if (findOwner != null && findOwner != null) {
            //    findOwner.Phone = owner.Phone;

        }
    }
}
