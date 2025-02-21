// Мельник Денис 238

using S4.HseCarShop.Models.HandCar;
using S4.HseCarShop.Services.Abstractions;

namespace S4.HseCarShop.Services.HandCars;

internal sealed class HandCarFactory : ICarFactory<HandCar, HandCarParams>
{
    private readonly IEngineFactory<HandEngine, HandEngineParams> _engineFactory;

    public HandCarFactory(IEngineFactory<HandEngine, HandEngineParams> engineFactory)
    {
        ArgumentNullException.ThrowIfNull(engineFactory);

        _engineFactory = engineFactory;
    }

    public HandCar CreateCar(HandCarParams carParams)
    {
        var engineParams = new HandEngineParams { GripsType = carParams.GripsType };
        var engine = _engineFactory.CreateEngine(engineParams);

        return new HandCar(number: Guid.NewGuid(), engine);
    }
}
