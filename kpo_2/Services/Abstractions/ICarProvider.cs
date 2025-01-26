using kpo_2.Models;

namespace kpo_2.Services.Abstractions;

public interface ICarProvider
{
    Car? GetCar(EngineType engineType);
}
