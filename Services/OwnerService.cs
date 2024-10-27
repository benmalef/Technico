using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.ComponentModel;
using Technico.Models;
using Technico.Repositories;
using Technico.Responses;
using Technico.Enums;
using sun.security.util;
namespace Technico.Services;

public class OwnerService : IOwnerService
{
    private readonly IOwnerRepository ownerRepository;
    private readonly ItemService itemService;

    public OwnerService(IOwnerRepository ownerRepository, ItemService itemService)
    {
        this.ownerRepository = ownerRepository;
        this.itemService = itemService;
    }

    public void CreateOwner(Owner owner)
    {
        if (!string.IsNullOrEmpty(owner.VAT))
        {
            if (GetOwnerByVAT(owner.VAT) == null)
            {
                ownerRepository.InsertOwner(owner);
            }
        }
    }
    public bool DeleteOwnerById(Guid id)
    {
        return ownerRepository.Delete(id);
    }

    public void UpdateOwner(string VAT,
                            string? name = null, string? surname = null,
                            string? address = null, int? phone = null,
                            string? email = null, string? password = null,
                            string? newVAT = null)
    {

        var owner = GetOwnerByVAT(VAT);
        if (owner != null)
        {
            if (!string.IsNullOrEmpty(name))
                owner.Name = name;

            if (!string.IsNullOrEmpty(surname))
                owner.Surname = surname;

            if (!string.IsNullOrEmpty(address))
                owner.Address = address;

            if (phone.HasValue)
                owner.Phone = phone;

            if (!string.IsNullOrEmpty(email))
                owner.Email = email;

            if (!string.IsNullOrEmpty(password))
                owner.Password = password;

            if (!string.IsNullOrEmpty(newVAT))
                owner.VAT = newVAT;

            ownerRepository.UpdateOwner(owner);
        }
    }
    public List<Owner> GetAllOwners()
    {
        return ownerRepository.GetOwners().ToList();
    }

    public Owner? GetOwnerById(Guid id)
    {
        return ownerRepository?.GetOwnerByID(id);
    }


    public List<Item>? GetOwnerItemsById(Guid id)
    {
        return ownerRepository?.GetOwnerByID(id)?.Items;
    }

    //VAT
    public Owner? GetOwnerByVAT(string VAT)
    {
        try
        {
            return GetAllOwners().Single(owner => owner.VAT == VAT);
        }
        catch (Exception)
        {
            return null;
        }
    }

    public List<Item>? GetOwnerItemsByVAT(string VAT)
    {
        var owner = GetOwnerByVAT(VAT);
        if (owner != null)
        {
            return ownerRepository?.GetOwnerItems(owner.Id)?.Items;
        }
        return null;

    }

    public List<Repair>? GetOwnerRepairsByVAT(string VAT)
    {

        var owner = GetOwnerByVAT(VAT);
        if (owner != null)
        {
            return ownerRepository?.GetOwnerRepairs(owner.Id);
        }
        return null;
    }
}

