using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tecnico.Enums;

namespace Tecnico.Models;

public record Item(
    
    long ID,
    string Address,
    int YearOfConstruction,
    Owner Onwer,
    TypeOfItem TypeOfItem
    );

