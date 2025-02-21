// Мельник Денис 238

namespace S4.HseCarShop.Models.Abstractions;

internal interface ICar
{
    public Guid Number { get; }

    public IEngine Engine { get; }

    public CarType Type { get; }
}
