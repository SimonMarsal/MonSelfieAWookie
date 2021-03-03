using System.Collections.Generic;

namespace SelfieAWookie.Core.Domain
{
    public interface IMainRepository<M>
    {
        IList<M> GetAll();
    }
}
