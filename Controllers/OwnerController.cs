﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;
using Technico.Services;

namespace Technico.Controllers;

public class OwnerController
{
    private readonly OwnerService _ownerService;
    public OwnerController(OwnerService ownerService)
    {
        _ownerService = ownerService;
    }

    //    public void create(Owner owner)
    //    {
    //        _ownerService.createOwner(owner);
    //    }

    //    public Owner findOwnerByID(Guid id)
    //    {
    //        var owner = _ownerService.findOwnerById(id);
    //        if (owner == null)
    //        {
    //            Console.WriteLine("Not Found");
    //            return null;
    //        }
    //        return owner;

    //    }
    //    public List<Owner> GetOwners()
    //    {
    //        return _ownerService.GetAllOwners();
    //    }
    //    public void display()
    //    {
    //       var repairs =  _ownerService.GetOwnerRepairsByVAT(1133);
    //        foreach (var repair in repairs)
    //        {
    //            Console.WriteLine(repair.ToString());
    //        }
    //    }

    //}
}
