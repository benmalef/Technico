using Technico.Enums;
using Technico.Models;

namespace Technico.Services
{
    public interface IRepairService
    {
        void CreateRepair(Repair repair);
        bool DeleteRepairById(Guid id);
        Repair? GetRepairById(Guid id);
        public void displayRepairsList(List<Repair> reapairs);
        void UpdateRepair(Guid id, DateTime? date = null, TypeOfRepair? typeOfRepair = null, string? description = null, string? address = null, decimal? cost = null, StatusOfRepair? status = null, Item? item = null);
    }
}