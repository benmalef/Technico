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
    private readonly ItemService itemService;

    public OwnerService(IOwnerRepository ownerRepository, ItemService itemService)
    {
        this.ownerRepository = ownerRepository;
        this.itemService = itemService;
    }

    public void createOwner(Owner owner)
    {
        if (GetOwnerByVAT(owner.VAT) == null) { 
        ownerRepository.InsertOwner(owner);
        }
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

  
    public List<Item>? getOwnerItemsById(Guid id)
    {
        return ownerRepository?.GetOwnerByID(id)?.Items;
    }
    //VAT
    public Owner? GetOwnerByVAT(int VAT)
    {
        try
        {
            return getAllOwners().Single(owner => owner.VAT == VAT);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Item>? displayOwnerItemsByVAT(int VAT)
    {
        var owner = GetOwnerByVAT(VAT);
        if (owner != null)
        {
            return ownerRepository?.GetOwnerItems(owner.Id)?.Items;
        }
        return null;

    }

    public List<Repair>? displayOwnerRepairsByVAT(int VAT)
    {
        //FIX IT 
        var owner = GetOwnerByVAT(VAT);
        if (owner != null)
        {
            return ownerRepository?.GetOwnerRepairs(owner.Id);
        }
        return null;

    }
}

