using kpo_2.Models.Abstractions;

namespace kpo_2.Models;

public record EmptyEngineParams : EngineParamsBase
{
    public static readonly EmptyEngineParams EmptyEngine = new();
}
