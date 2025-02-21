// Мельник Денис 238

using S4.HseCarShop.Models.HybridCar;
using S4.HseCarShop.Services.Abstractions;

namespace S4.HseCarShop.Services.HybridCars;

internal sealed class HybridCarFactory : ICarFactory<HybridCar, HybridCarParams>
{
    private readonly IEngineFactory<HybridEngine, HybridEngineParams> _engineFactory;

    public HybridCarFactory(IEngineFactory<HybridEngine, HybridEngineParams> engineFactory)
    {
        ArgumentNullException.ThrowIfNull(engineFactory);

        _engineFactory = engineFactory;
    }

    public HybridCar CreateCar(HybridCarParams carParams)
    {
        var engineParams = new HybridEngineParams
        {
            GripsType = carParams.GripsType,
            PedalSize = carParams.PedalSize,
        };

        var engine = _engineFactory.CreateEngine(engineParams);
        return new HybridCar(number: Guid.NewGuid(), engine);
    }
}