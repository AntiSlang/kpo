using kpo_2.Models.Abstractions;

namespace kpo_2.Models;

public class PedalEngine : IEngine
{
    public uint Size { get; }

    public EngineType Type => EngineType.Pedal;

    public PedalEngine(uint size)
    {
        Size = size;
    }

    public override string ToString()
        => $"Тип: {Type}, Размер педалей: {Size}";
    
}