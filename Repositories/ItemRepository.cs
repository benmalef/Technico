using java.security.acl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Repositories
{
    internal class ItemRepository : IItemRepository
    {
        private readonly AppDbContext context;
        public ItemRepository(AppDbContext context) {
            this.context = context;
        }
        public bool Delete(Guid itemId)
        {
            var item = context.Owners.Single(item => itemId == item.Id);
            context.Owners.Remove(item);
            context.SaveChanges();
            return true;
        }

        public IEnumerable<Item> GetItem()
        {
            return context.Items;
        }

        public Item? GetItemByID(Guid itemId)
        {
            return context.Items.FirstOrDefault(item => itemId == item.Id);
        }

        public void InsertItem(Item item)
        {
            context.Items.Add(item);
            context.SaveChanges();
        }

        public void UpdateItem(Item item)
        {
            throw new NotImplementedException();
        }
    }
}
