using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Technico.Enums;
namespace Technico.Models;

public class Owner
{
    public required string VAT { get; set; }
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Address { get; set; }
    public int? Phone { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; }
    public Users? TypeOfUser { get; set; }

    
    public  List<Item>? Items { get; set; }



    public override string? ToString()
    {
        return $"owner name:{Name}";
    }
}