// Мельник Денис 238

using S4.HseCarShop.Models.Abstractions;

namespace S4.HseCarShop.Models.HandCar;

internal sealed class HandEngine : EngineBase
{
    public GripsType GripsType { get; }

    public HandEngine(GripsType gripsType)
        : base(EngineType.Hand)
    {
        GripsType = gripsType;
    }

    public override string ToString()
        => $"Тип: {Type}, Тип ручек: {GripsType}";
}