// Мельник Денис 238

using S4.HseCarShop.Models.Abstractions;

namespace S4.HseCarShop.Models;

internal sealed class Customer
{
    public string Name { get; }

    public uint HandStrength { get; }

    public uint LegStrength { get; }

    public ICar? Car { get; set; }

    public Customer(string name, uint legStrength, uint handStrength)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);

        Name = name;
        LegStrength = legStrength;
        HandStrength = handStrength;
    }

    public override string ToString()
        => $"Имя: {Name}, Сила рук: {HandStrength}, Сила ног: {LegStrength}, Автомобиль: {(Car == null ? "Нет" : $"{{ {Car} }}")}";
}
