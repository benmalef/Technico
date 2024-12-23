﻿using java.security.acl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Models;

namespace Technico.Repositories;

public class ItemRepository : IItemRepository
{
    private readonly AppDbContext context;
    public ItemRepository(AppDbContext context) {
        this.context = context;
    }
    public  bool DeleteById(Guid itemId)
    {
        var item =  context.Items.Single(item => itemId == item.Id);
        context.Items.Remove(item);
        context.SaveChanges();
        return true;
    }

    public IEnumerable<Item> GetItems()
    {
        return context.Items;
    }

    public Item? GetItemByID(Guid itemId)
    {
        return context.Items.FirstOrDefault(item => itemId == item.Id);
    }

    public Item InsertItem(Item item)
    {
        var item1 = context.Items.Add(item);
        context.SaveChanges();
        return item;
    }

    public Item UpdateItem(Item item)
    {
        context.Items.Update(item);
        context.SaveChanges();
        return item;
    }
}
