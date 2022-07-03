namespace CarsSaloonProject;

public class Address
{
    public string City { get; set; }
    public string Street { get; set; }
    public int HomeNumber { get; set; }
    public int PostIndex { get; set; }

    public Address(string city, string street, int homeNumber, int postIndex)
    {
        City = city;
        Street = street;
        HomeNumber = homeNumber;
        PostIndex = postIndex;
    }

    public override string ToString()
    {
        return $"Город: {City}\nУлица: {Street}\nДом: {HomeNumber}\nПочтовый индекс: {PostIndex}";
    }
}