using Technico.Models;

namespace Technico.Services
{
    public interface IOwnerService
    {
        void CreateOwner(Owner owner);
        bool DeleteOwnerById(Guid id);
        List<Owner> GetAllOwners();
        Owner? GetOwnerById(Guid id);
        Owner? GetOwnerByVAT(int VAT);
        List<Item>? GetOwnerItemsById(Guid id);
        List<Item>? GetOwnerItemsByVAT(int VAT);
        List<Repair>? GetOwnerRepairsByVAT(int VAT);
        void UpdateOwner(int VAT, string? name = null, string? surname = null, string? address = null, int? phone = null, string? email = null, string? password = null, int? newVAT = null);
    }
}