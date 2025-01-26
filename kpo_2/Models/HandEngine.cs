using kpo_2.Models.Abstractions;

namespace kpo_2.Models;

public class HandEngine : IEngine
{
    public EngineType Type => EngineType.Hand;

    public override string ToString()
        => $"Тип: {Type}";
}