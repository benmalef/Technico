using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Repositories;


public interface IOwnerRepository
{
    IEnumerable<Owner> GetOwners();
    Owner? GetOwnerByID(Guid ownerId);
    Owner InsertOwner(Owner owner);
    bool Delete(Guid ownerId);
    Owner UpdateOwner(Owner owner);
    public Owner? GetOwnerItems(Guid ownerId);
    public List<Repair> GetOwnerRepairs(Guid ownerId);
}

