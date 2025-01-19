using kpo_1;

var customers = new List<Customer>
{
    new() { Name = "Иван" },
    new() { Name = "Пётр" },
    new() { Name = "Фома" },
};

var factory = new FactoryAF(customers);

for (int i = 0; i < 5; i++)
{
    factory.AddCar();
}

Console.WriteLine("До");
Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

factory.SaleCar();

Console.WriteLine("После");
Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));
Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));