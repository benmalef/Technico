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
    private readonly IOwnerRepository ownerRepository;

    public OwnerService(IOwnerRepository ownerRepository)
    {
        this.ownerRepository = ownerRepository;
    }

    public void createOwner(Owner owner)
    {
        ownerRepository.InsertOwner(owner);
    }
    public bool deleteOwnerById(Guid id)
    {
        return ownerRepository.Delete(id);
    }

    public List<Owner> getAllOwners()
    {
        return ownerRepository.GetOwners().ToList();
    }

    public Owner? findOwnerById(Guid id)
    {
        return ownerRepository?.GetOwnerByID(id);
    }
 
    //private bool isVATexists(int VAT)
    //{
    //    if (ownerRepository.GetOwnerByVAT(VAT) == null)
    //    {
    //        return false;
    //    }
    //    return true;
    //}
    public List<Item>? getOwnerItemsById(Guid id)
    {
        return ownerRepository?.GetOwnerByID(id)?.Items;
    }
    //VAT
    public Owner GetOwnerByVAT(int VAT)
    {
        return getAllOwners().Single(owner => owner.VAT == VAT);
    }

    public List<Item>? displayOwnerItemsByVAT(int VAT)
    {
       return GetOwnerByVAT(VAT).Items;
    }

    public List<Item>? displayOwnerRepairsByVAT(int VAT)
    {
        //FIX IT 
        return GetOwnerByVAT(VAT).Items;
   
    }
}

