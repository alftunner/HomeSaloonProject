namespace CarsSaloonProject;

public class Flat : RealEstate
{
    public int RoomsQuantity { get; set; }
    public int FloorNumber { get; set; }
    public int EntranceNumber { get; set; }
    public string FlatType { get; set; }

    public Flat(string type, double pricePerSquareMeter, double square, int floorQuantity, Address address, 
        DateTime age, double maxPercentForSale, int roomsQuantity, int floorNumber, int entranceNumber, string flatType) 
        : base(type, pricePerSquareMeter, square, floorQuantity, address, age, maxPercentForSale)
    {
        RoomsQuantity = roomsQuantity;
        FloorNumber = floorNumber;
        EntranceNumber = entranceNumber;
        FlatType = flatType;
    }

    public override double? PriceForAll()
    {
        if (this.RealPercentForSale != null)
        {
            return Square * PricePerSquareMeter * (1 - RealPercentForSale / 100);
        }
        return Square * PricePerSquareMeter;
    }

    public override void SetRealPercentForSale(double percent)
    {
        if (percent <= MaxPercentForSale)
        {
            RealPercentForSale = percent;
        }
    }

    public override double? SaleInRubles()
    {
        return Square * PricePerSquareMeter - PriceForAll();
    }

    public override string ToString()
    {
        return $"Тип: {Type}\nЦена за м2: {PricePerSquareMeter}\nПлощадь: {Square}\nКоличество этажей: {FloorQuantity}\n"
               +$"Адрес:\n{AddressObject}\nГод постройки: {Age}\nМаксимально возможная скидка: {MaxPercentForSale}\n"
               +$"Количество комнат: {RoomsQuantity}\nЭтаж: {FloorNumber}\nПодъезд: {EntranceNumber}\nТип квартиры: {FlatType}\nИтоговая скидка: {SaleInRubles()}\n"
               +$"Итоговая цена: {PriceForAll()} руб.\n------------------------";
    }
}