﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnico.Models;
using Tecnico.Services;

namespace Tecnico.Controllers
{
    internal class OwnerController
    {
        private readonly OwnerService _ownerService;
        public OwnerController(OwnerService ownerService)
        {
            _ownerService = ownerService;
        }

        public void create(Owner owner)
        {
            _ownerService.createOwner(owner);
        }

        public Owner findOwnerByID(int id)
        {
            var owner = _ownerService.findOwnerById(id);
            if (owner == null)
            {
                Console.WriteLine("Not Found");
                return null;
            }
            return owner;

        }
        public List<Owner> GetOwners()
        {
            return _ownerService.get_owners();
        }
        public void display()
        {
            foreach (var owner in GetOwners())
            {
                Console.WriteLine(owner);
            }
        }

    }
}