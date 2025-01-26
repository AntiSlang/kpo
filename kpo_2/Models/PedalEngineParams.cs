using kpo_2.Models.Abstractions;

namespace kpo_2.Models;

public record PedalEngineParams : EngineParamsBase
{
    public uint PedalSize { get; }

    public PedalEngineParams(uint pedalSize)
    {
        PedalSize = pedalSize;
    }
}