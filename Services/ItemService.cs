using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;
using Technico.Repositories;

namespace Technico.Services;

internal class ItemService
{
    private readonly IItemRepository itemRepository ;
  
    public ItemService(IItemRepository itemRepository)
    {
      
        this.itemRepository = itemRepository;
    }
    
    public void create(Item item)
    {
        itemRepository.InsertItem(item);
    }
    
    public Item getItemByE9(int E9)
    {
       return itemRepository
                    .GetItems()
                    .Single(item => item.E9 == E9);
    }

    public bool deleteItemByE9(int E9)
    {
        var item = getItemByE9(E9);
        return itemRepository.DeleteById(item.Id);
    }

    public List<Repair>? getAllRepairs(Guid id)
    {
        return itemRepository?.GetItemByID(id)?.Repairs;
    }

    //public Item createItemWithVAT()

}