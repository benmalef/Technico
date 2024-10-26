using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Technico.Models;

namespace Technico.Repositories
{
    class OwnerRepository : IOwnerRepository
    {
        private readonly AppDbContext context;
        public OwnerRepository(AppDbContext context)
        {
            this.context = context;
        }

        public bool Delete(Guid ownerId)
        {
            var owner = context.Owners.Single(owner => ownerId == owner.Id);
            context.Owners.Remove(owner);
            context.SaveChanges();
            return true;
        }

        public Owner GetOwnerByID(Guid ownerId)
        {
            return context.Owners.Single(owner => ownerId == owner.Id);
        }

        public IEnumerable<Owner> GetOwners()
        {
            return context.Owners;
        }

        public void InsertOwner(Owner owner)
        {
            context.Owners.Add(owner);
            context.SaveChanges();
        }



        public void UpdateOwner(Owner owner)
        {
            context.Owners.Update(owner);
            context.SaveChanges();

        }
    }
}
