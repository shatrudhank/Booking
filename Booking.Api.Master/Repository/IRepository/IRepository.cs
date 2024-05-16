namespace Booking.Api.Master.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        IList<T> GetAll();
        T Get(int id);
        int Update(T country);
        int Add(T country);
        int Remove(T country);

    }
}
