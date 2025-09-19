namespace Supermarket.API.Domain.Repositories
{
    public interface ICategoryRespository
    {
        public interface ICategoryRespository
        { 
            Task<IEnumerable<Category>> ListAsync();
        }
    }
}