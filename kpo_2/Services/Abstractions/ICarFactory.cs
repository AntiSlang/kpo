using kpo_2.Models;
using kpo_2.Models.Abstractions;

namespace kpo_2.Services.Abstractions;

public interface ICarFactory<TParams>
    where TParams : EngineParamsBase
{
    Car CreateCar(TParams carParams);
}
