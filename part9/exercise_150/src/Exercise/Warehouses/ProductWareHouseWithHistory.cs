namespace Exercise
{
  public class ProductWarehouseWithHistory : ProductWarehouse
  {
    public ChangeHistory listofChanges;
    public int initialBalance;
    
    public ProductWarehouseWithHistory(string productName, int capacity, int initialBalance) : base(productName, capacity)
    {
      this.initialBalance = initialBalance;
      this.listofChanges = new ChangeHistory();
      AddToWarehouse(initialBalance);
    }

    public string History()
    {
      return this.listofChanges.ToString();
    }

    new public void AddToWarehouse(int amount)
    {
      base.AddToWarehouse(amount);
      this.listofChanges.Add(this.balance);
    }

    new public int TakeFromWarehouse(int amount)
    {
      base.TakeFromWarehouse(amount);
      this.listofChanges.Add(this.balance);
      return amount;
    }
  }
}