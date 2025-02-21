// Мельник Денис 238

namespace S4.HseCarShop.Models.Abstractions;

internal abstract class EngineBase : IEngine
{
    public EngineType Type { get; }

    protected EngineBase(EngineType type)
    {
        Type = type;
    }

    public override string ToString()
        => $"Тип: {Type}";
}
