using kpo_2.Models;

namespace kpo_2.Services.Abstractions;

public interface ICustomersProvider
{
    IEnumerable<Customer> GetCustomers();
}
