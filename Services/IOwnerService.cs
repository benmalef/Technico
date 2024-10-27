using Technico.Models;

namespace Technico.Services
{
    public interface IOwnerService
    {
        void CreateOwner(Owner owner);
        bool DeleteOwnerById(Guid id);
        List<Owner> GetAllOwners();
        Owner? GetOwnerById(Guid id);
        Owner? GetOwnerByVAT(string VAT);
        List<Item>? GetOwnerItemsById(Guid id);
        List<Item>? GetOwnerItemsByVAT(string VAT);
        List<Repair>? GetOwnerRepairsByVAT(string VAT);
        void UpdateOwner(string VAT, string? name = null, string? surname = null, string? address = null, int? phone = null, string? email = null, string? password = null, string? newVAT = null);
    }
}