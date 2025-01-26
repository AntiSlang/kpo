using kpo_2.Models;
using kpo_2.Services.Abstractions;

namespace kpo_2.Services;
public class HandCarFactory : ICarFactory<EmptyEngineParams>
{
    public Car CreateCar(EmptyEngineParams carParams)
    {
        var engine = new HandEngine();
        return new Car(engine, number: Guid.NewGuid());
    }
}
