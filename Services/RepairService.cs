using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Enums;
using Technico.Models;
using Technico.Repositories;

namespace Technico.Services;

public class RepairService : IRepairService
{
    private readonly IRepairRepository repairRepository;

    public RepairService(IRepairRepository repairRepository)
    {
        this.repairRepository = repairRepository;
    }

    public void CreateRepair(Repair repair)
    {
        repairRepository.InsertRepair(repair);
    }
    public bool DeleteRepairById(Guid id)
    {
        return repairRepository.Delete(id);
    }

    public Repair? GetRepairById(Guid id)
    {
        return repairRepository.GetRepairByID(id);
    }

    public void UpdateRepair(Guid id, DateTime? date = null, TypeOfRepair? typeOfRepair = null,
                                       string? description = null, string? address = null,
                                       decimal? cost = null, StatusOfRepair? status = null,
                                       Item? item = null)
    {
        var repair = GetRepairById(id);
        if (repair != null)
        {
            if (date.HasValue)
                repair.Date = date.Value;

            if (typeOfRepair.HasValue)
                repair.TypeOfRepair = typeOfRepair.Value;

            if (!string.IsNullOrEmpty(description))
                repair.Description = description;

            if (!string.IsNullOrEmpty(address))
                repair.Address = address;

            if (cost.HasValue)
                repair.Cost = cost.Value;

            if (status.HasValue)
                repair.Status = status.Value;

            if (item != null)
                repair.Item = item;
            repairRepository.UpdateRepair(repair);
        }
    }
   public void displayRepairsList(List<Repair> reapairs)
    {
        foreach (var repair in reapairs)
        {
            Console.WriteLine(repair.ToString());
        }
    }
}
