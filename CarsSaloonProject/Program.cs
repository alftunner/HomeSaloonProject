using CarsSaloonProject;

RealEstate flat = new Flat("квартира", 50000, 30, 1, new Address("Воронеж", 
    "9 января", 12, 394008), new DateTime(2006, 10, 10), 10, 
    1, 4, 2, "secondHand");
flat.SetRealPercentForSale(9);
Console.WriteLine(flat);    