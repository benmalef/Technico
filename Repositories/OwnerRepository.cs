﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Technico.Models;
using Microsoft.EntityFrameworkCore;

namespace Technico.Repositories
{
  public  class OwnerRepository : IOwnerRepository
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
        public Owner? GetOwnerItems(Guid ownerId)
        {
            return context.Owners
                .Include(owner => owner.Items)
                .FirstOrDefault(owner => owner.Id == ownerId);
        }

        public List<Repair>? GetOwnerRepairs(Guid ownerId)
        {
            return context.Owners
                .Where(o => o.Id == ownerId)                       // Filter by the specific owner ID
                .Include(o => o.Items)                             // Include items related to the owner
                 .ThenInclude(i => i.Repairs)                       // Then include repairs for each item
                  .SelectMany(o => o.Items.SelectMany(i => i.Repairs)).ToList();


        }
    }
}
