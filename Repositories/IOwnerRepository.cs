using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnico.Models;

namespace Tecnico.Repositories;


public interface IOwnerRepository : IDisposable
{
    IEnumerable<Owner> GetOwners();
    Owner GetOwnerByID(int ownerId);
    void InsertOwner(Owner owner);
    bool Delete(int onwerID);
    void UpdateOwner(Owner owner);
    void Save();
}

