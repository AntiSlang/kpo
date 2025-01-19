namespace kpo_1;

public class FactoryAF(List<Customer> customers)
{
    public List<Car> Cars { get; private set; } = new();
    public List<Customer> Customers { get; private set; } = customers;

    internal void SaleCar()
    {
        foreach (var customer in Customers)
        {
            customer.Car ??= Cars.LastOrDefault();

            if (customer.Car == null)
                break;

            Cars.RemoveAt(Cars.Count - 1);
        }

        Customers = Customers.Where(customer => customer.Car != null).ToList();
        Cars.Clear();
    }

    internal void AddCar()
    {
        var car = new Car { Number = Cars.Count + 1 };
        Cars.Add(car);
    }
}