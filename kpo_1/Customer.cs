namespace kpo_1;

public class Customer
{
    public required string Name { get; set; }
    public Car? Car { get; set; }

    public override string ToString()
    {
        return $"Имя: {Name}, номер машины: {Car?.Number ?? -1}";
    }
}