﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Technico.Enums;

namespace Technico.Models;

public class Item
{
    public Guid Id { get; set; }
    public int E9 { get; set; }
    public string? Address { get; set; }
    public int YearOfConstruction { get; set; }
    public Owner Owner { get; set; }
    public TypeOfItem TypeOfItem { get; set; }

    public List<Repair>? Repairs { get; set; }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return $"E9:{E9}" +
            $"Owner Name:{Owner.Name}";
    }
}