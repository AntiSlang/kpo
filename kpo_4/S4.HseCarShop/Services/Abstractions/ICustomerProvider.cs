// Мельник Денис 238

using S4.HseCarShop.Models;

namespace S4.HseCarShop.Services.Abstractions;

internal interface ICustomerProvider
{
    IEnumerable<Customer> GetCustomers();
}
