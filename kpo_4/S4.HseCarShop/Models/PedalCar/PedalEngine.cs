// Мельник Денис 238

using S4.HseCarShop.Models.Abstractions;

namespace S4.HseCarShop.Models.PedalCar;

internal sealed class PedalEngine : EngineBase
{
    public uint PedalsSize { get; }

    public PedalEngine(uint pedalsSize)
        : base(EngineType.Pedal)
    {
        PedalsSize = pedalsSize;
    }

    public override string ToString()
        => $"Тип: {Type}, Размер педалей: {PedalsSize}";
}