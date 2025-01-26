using kpo_2.Models.Abstractions;

namespace kpo_2.Models;

public class Car
{
    public Guid Number { get; }
    public IEngine Engine { get; }

    public Car(IEngine engine, Guid number)
    {
        ArgumentNullException.ThrowIfNull(engine, nameof(engine));

        Engine = engine;
        Number = number;
    }

    public override string ToString()
        => $"Номер: {Number}, Двигатель: {{ {Engine} }}";
}
