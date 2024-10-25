using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Repositories
{
    internal interface IItemRepository
    {
        IEnumerable<Item> GetItem();
        Item? GetItemByID(Guid itemId);
        void InsertItem(Item item);
        bool Delete(Guid itemId);
        void UpdateItem(Item item);
        
    }
}
