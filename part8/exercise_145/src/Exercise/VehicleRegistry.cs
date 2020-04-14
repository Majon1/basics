using System;
using System.Collections.Generic;

namespace Exercise
{
  public class VehicleRegistry
  {
    private Dictionary<LicensePlate, string> owners = new Dictionary<LicensePlate, string>();
    public VehicleRegistry()
    {
      this.owners = new Dictionary<LicensePlate, string>();
    }
    public bool Add(LicensePlate licensePlate, string owner)
    {
    if (!this.owners.ContainsKey(licensePlate))
      {
      this.owners.Add(licensePlate, owner);
      return true;
      }
     else 
     {
       return false;
     } 
    }

    public string Get(LicensePlate licensePlate)
    {
    if (this.owners.ContainsKey(licensePlate))
      {
        return this.owners[licensePlate];
      }
    else
      {
      return "No such licenseplate";
      }
    }

    public bool Remove(LicensePlate licensePlate)
    {
      if (this.owners.ContainsKey(licensePlate))
      {
        this.owners.Remove(licensePlate);
        return true;
      } 
      else
      {
      return false; 
      }
    }

    public void PrintLicensePlates()
    {
      foreach (KeyValuePair<LicensePlate, string> kvp in owners)
      {
        Console.WriteLine("{0}", kvp.Key);
      }
    }

    public void PrintOwners()
    { 
      List <string>printedOwner = new List<string>();
      foreach (KeyValuePair<LicensePlate, string> kvp in this.owners)
      {
        if (!printedOwner.Contains(kvp.Value))
        {
        Console.WriteLine(kvp.Value);
        }
        printedOwner.Add(kvp.Value);
      }
    }
  }
}