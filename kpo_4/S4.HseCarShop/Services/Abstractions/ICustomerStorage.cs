// Мельник Денис 238

using S4.HseCarShop.Models;

namespace S4.HseCarShop.Services.Abstractions;

internal interface ICustomerStorage : ICustomerProvider
{
    void AddCustomer(Customer customer);

    void AddCustomers(IEnumerable<Customer> customers);
}
