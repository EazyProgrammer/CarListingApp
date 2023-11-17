﻿
using SQLite;

namespace CarListingApp.MAUI.UI.Models;

[Table("Cars")]
public class Car : BaseEntity
{
    public string Make { get; set; } = string.Empty;
    
    public string Model { get; set; } = string.Empty;
    
    [MaxLength(15)]
    [Unique]
    public string Vin { get; set; } = string.Empty;
}
