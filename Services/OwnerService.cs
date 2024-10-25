using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;
using Technico.Models;
using Technico.Repositories;
namespace Technico.Services;

public class OwnerService
{
    private readonly IOwnerRepository _ownerRepository;

    public OwnerService(IOwnerRepository ownerRepository)
    {
        _ownerRepository = ownerRepository;
    }


    //todo: Create Method
    public void createOwner(Owner owner)
    {
        if (!isVATexists(owner.VAT))
        {
            _ownerRepository.InsertOwner(owner);

        }

    }
    public bool deleteOwnerById(Guid id)
    {
        return _ownerRepository.Delete(id);
    }

    public List<Owner> get_owners()
    {
        return _ownerRepository.GetOwners().ToList();
    }

    public Owner? findOwnerById(Guid id)
    {
        return _ownerRepository?.GetOwnerByID(id);

    }

    public bool isVATexists(int VAT)
    {
        if (_ownerRepository.GetOwnerByVAT(VAT) == null)
        {
            return true;
        };
        return false;
    }
}

