using eCommerceApp.Domain.Entities.Cart;
using eCommerceApp.Domain.Interfaces.Carts;
using eCommerceApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace eCommerceApp.Infrastructure.Repositiries.Carts
{
    public class PaymentMethodRepository(AppDbContext context) : IPaymentMethod
    {
        async Task<IEnumerable<PaymentMethod>> IPaymentMethod.GetPaymentMethods()
        {
            return await context.PaymentMethods.AsNoTracking().ToListAsync();
        }
    }
}
