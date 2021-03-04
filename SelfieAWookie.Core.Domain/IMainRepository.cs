using System.Collections.Generic;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Domain
{
    public interface IMainRepository<M>
    {
        IList<M> GetAll();
        Task<IList<M>> GetAllAsync();
        void Create(M model);
        Task CreateAsync(M model);
    }
}
