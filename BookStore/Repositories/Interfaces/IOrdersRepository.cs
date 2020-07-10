using BookStore.Data;

namespace BookStore.Repositories.Interfaces
{
    public interface IOrdersRepository
    {
        void Create(Order order);

        Order Get(string email, string orderCode);
    }
}
