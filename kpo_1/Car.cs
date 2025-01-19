namespace kpo_1;

public class Car
{
    private static readonly Random _random = new();
    private Engine Engine { get; }
    public int Number { get; set; }

    public Car()
    {
        Engine = new Engine { Size = _random.Next(1, 10) };
    }

    public override string ToString()
    {
        return $"Номер: {Number}, размер педалей: {Engine.Size}";
    }
}