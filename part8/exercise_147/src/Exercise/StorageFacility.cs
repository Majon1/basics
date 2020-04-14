using System.Collections.Generic;
using System;

namespace Exercise
{
  public class StorageFacility
  {
    private Dictionary<string, List<string>> register;
    public StorageFacility()
    {
      this.register = new Dictionary<string, List<string>>();
    }
    public void Add(string unit, string item)
    {
      if (!this.register.ContainsKey(unit))
      {
        this.register.Add(unit, new List<string>());
      }
      this.register[unit].Add(item);
    }

    public List<string> Contents(string storageUnit)
    {
       if (this.register.ContainsKey(storageUnit))
      {
        return this.register[storageUnit];
      }
      else
      {
      return new List<string>();
      }
    }

    public void Remove(string storageUnit, string item)
    {
      this.register[storageUnit].Remove(item);  
      if (this.register[storageUnit].Count == 0)
      {
        this.register.Remove(storageUnit);
      }
    }

    public List<string> StorageUnits()
    {
      List<string> storageNumber = new List<string>();
      Dictionary<string, List<string>>.KeyCollection keys = this.register.Keys;
      foreach (string units in keys)
      {
      storageNumber.Add(units);
      }
      return storageNumber;
    }
  }
}