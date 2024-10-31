using Technico.Enums;
using Technico.Models;

namespace Technico.Services
{
    public interface IItemService
    {
        Item CreateItem(Item item);
        bool DeleteItemByE9(int E9);
        List<Repair>? GetAllRepairs(Guid id);
        Item GetItemByE9(int E9);
        Item UpdateItemByE9(int E9, string? address = null, int? yearOfConstruction = null, TypeOfItem? typeOfItem = null, Owner? owner = null, int? newE9 = null);
    }
}