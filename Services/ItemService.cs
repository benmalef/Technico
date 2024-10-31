using java.net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Enums;
using Technico.Models;
using Technico.Repositories;

namespace Technico.Services;

public class ItemService : IItemService
{
    private readonly IItemRepository itemRepository;

    public ItemService(IItemRepository itemRepository)
    {

        this.itemRepository = itemRepository;
    }

    public Item CreateItem(Item item)
    {
        try
        {
            return itemRepository.InsertItem(item);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            return null;
        }
    }

    public Item GetItemByE9(int E9)
    {
        return itemRepository
                     .GetItems()
                     .Single(item => item.E9 == E9);
    }

    public bool DeleteItemByE9(int E9)
    {
        var item = GetItemByE9(E9);
        return itemRepository.DeleteById(item.Id);
    }

    public List<Repair>? GetAllRepairs(Guid id)
    {
        return itemRepository?.GetItemByID(id)?.Repairs;
    }

    public Item UpdateItemByE9(int E9, string? address = null,
                                     int? yearOfConstruction = null,
                                      TypeOfItem? typeOfItem = null,
                                      Owner? owner = null,
                                      int? newE9 = null)
    {
        var item = GetItemByE9(E9);
        if (item != null)
        {
            if (!string.IsNullOrEmpty(address))
                item.Address = address;

            if (yearOfConstruction.HasValue)
                item.YearOfConstruction = yearOfConstruction.Value;

            if (owner != null)
                item.Owner = owner;

            if (typeOfItem.HasValue)
                item.TypeOfItem = typeOfItem.Value;

            if (newE9.HasValue)
                item.E9 = newE9.Value;

            return itemRepository.UpdateItem(item);
        }
        return null;
    }
    public void displayListItems(List<Item> items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}