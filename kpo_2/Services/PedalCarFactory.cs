using kpo_2.Models;
using kpo_2.Services.Abstractions;

namespace kpo_2.Services;

public class PedalCarFactory : ICarFactory<PedalEngineParams>
{
    public Car CreateCar(PedalEngineParams carParams)
    {
        var engine = new PedalEngine(carParams.PedalSize);
        return new Car(engine, number: Guid.NewGuid());
    }
}
