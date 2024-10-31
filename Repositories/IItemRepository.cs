using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Repositories
{
    public interface IItemRepository
    {
        IEnumerable<Item> GetItems();
        Item? GetItemByID(Guid itemId);
        Item InsertItem(Item item);
        bool DeleteById(Guid itemId);
        Item UpdateItem(Item item);
        
    }
}
