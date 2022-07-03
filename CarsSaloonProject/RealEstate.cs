namespace CarsSaloonProject;

public abstract class RealEstate
{
    public string? Type { get; set; }
    public double PricePerSquareMeter { get; set; }
    public double Square { get; set; }
    public int FloorQuantity { get; set; }
    public Address? AddressObject { get; set; }
    public DateTime Age { get; set; }
    public double MaxPercentForSale { get; set; }
    public double? RealPercentForSale { get; set; }

    public RealEstate(string type, double pricePerSquareMeter, double square, int floorQuantity, Address address, DateTime age, double maxPercentForSale = 0)
    {
        Type = type;
        PricePerSquareMeter = pricePerSquareMeter;
        Square = square;
        FloorQuantity = floorQuantity;
        AddressObject = address;
        Age = age;
        MaxPercentForSale = maxPercentForSale;
        RealPercentForSale = null;
    }

    public abstract double? PriceForAll();
    public abstract void SetRealPercentForSale(double percent);
    public abstract double? SaleInRubles();
}