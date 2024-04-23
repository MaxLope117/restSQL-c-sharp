﻿namespace restSQL.Models;

public class Product
{
  public int Id { get; set; }
  public required string Name { get; set; }
  public required string Description { get; set; }
  public double Precio { get; set; }
  public DateTime createdAt { get; set; }
}
