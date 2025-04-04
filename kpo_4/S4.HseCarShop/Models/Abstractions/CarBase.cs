﻿// Мельник Денис 238

namespace S4.HseCarShop.Models.Abstractions;

internal abstract class CarBase : ICar
{
    public Guid Number { get; }

    public IEngine Engine { get; }

    public CarType Type => ConvertEngineTypeToCarType(Engine.Type);

    protected CarBase(Guid number, IEngine engine)
    {
        if (number == Guid.Empty)
            throw new ArgumentException("Invalid number", nameof(number));
        ArgumentNullException.ThrowIfNull(engine);

        Number = number;
        Engine = engine;
    }

    public override string ToString()
        => $"Номер: {Number}, Двигатель: {{ {Engine} }}";

    private CarType ConvertEngineTypeToCarType(EngineType engineType)
    {
        return engineType switch
        {
            EngineType.Pedal => CarType.Pedal,
            EngineType.Hand => CarType.Hand,
            EngineType.Hybrid => CarType.Hybrid,
            _ => throw new NotImplementedException("Unknown engine type"),
        };
    }
}
