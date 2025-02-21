// Мельник Денис 238

using S4.HseCarShop.Models.Abstractions;

namespace S4.HseCarShop.Services.Abstractions;

internal interface IEngineFactory<TEngine, TEngineParams>
    where TEngine : IEngine
    where TEngineParams : struct
{
    TEngine CreateEngine(TEngineParams engineParams);
}
