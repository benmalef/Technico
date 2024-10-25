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
    void InsertOwner(Owner owner);
    bool Delete(Guid ownerId);
    void UpdateOwner(Owner owner);
    public Owner? GetOwnerByVAT(int VAT);
}

