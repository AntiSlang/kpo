// Мельник Денис 238

using S4.HseCarShop.Models;
using S4.HseCarShop.Services.Abstractions;

namespace S4.HseCarShop.Services;

internal class CustomersStorage : ICustomerStorage
{
    public List<Customer> Customers { get; }

    public CustomersStorage()
    {
        Customers = [];
    }

    public void AddCustomer(Customer customer)
    {
        ArgumentNullException.ThrowIfNull(customer);

        Customers.Add(customer);
    }

    public void AddCustomers(IEnumerable<Customer> customers)
    {
        ArgumentNullException.ThrowIfNull(customers);

        Customers.AddRange(customers);
    }

    public IEnumerable<Customer> GetCustomers()
    {
        return Customers.Where(customer => customer.Car == null);
    }
}