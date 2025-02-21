// Мельник Денис 238

using S4.HseCarShop.Models.Abstractions;

namespace S4.HseCarShop.Models.HybridCar;

internal sealed class HybridEngine : EngineBase
{
    public GripsType GripsType { get; }

    public uint PedalsSize { get; }

    public HybridEngine(GripsType gripsType, uint pedalsSize)
        : base(EngineType.Hybrid)
    {
        GripsType = gripsType;
        PedalsSize = pedalsSize;
    }

    public override string ToString()
        => $"Тип: {Type}, Тип ручек: {GripsType}, Размер педалей: {PedalsSize}";
}
