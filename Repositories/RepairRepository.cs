﻿using Technico.Models;

namespace Technico.Repositories;

public class RepairRepository : IRepairRepository
{
    private readonly AppDbContext context;
    public RepairRepository(AppDbContext context) {
        this.context = context; 
    }
    public bool Delete(Guid repairId)
    {
        var repair = context.Repairs.Single(repair => repairId == repair.Id);
        context.Repairs.Remove(repair);
        context.SaveChanges();
        return true;
    }

    public Repair? GetRepairByID(Guid repairId)
    {
        return context.Repairs.FirstOrDefault(repair => repairId == repair.Id);
    }

    public IEnumerable<Repair> GetRepairs()
    {
        return context.Repairs;
    }

    public Repair InsertRepair(Repair repair)
    {
        context.Repairs.Add(repair);
        context.SaveChanges();
        return repair;
    }

    public Repair UpdateRepair(Repair repair)
    {
        context.Repairs.Update(repair);
        context.SaveChanges();
        return repair;
    }
}
