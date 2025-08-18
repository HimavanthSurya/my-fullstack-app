using eCommerceApp.Domain.Entities.Cart;
using eCommerceApp.Domain.Interfaces.Carts;
using eCommerceApp.Infrastructure.Data;

namespace eCommerceApp.Infrastructure.Repositiries.Carts
{
    public class CartRepository(AppDbContext context) : ICart
    {
        public async Task<int> SaveCheckoutHistory(IEnumerable<Achieve> checkouts)
        {
            context.CheckoutAchieves.AddRange(checkouts);
            return await context.SaveChangesAsync();
        }
    }
}
