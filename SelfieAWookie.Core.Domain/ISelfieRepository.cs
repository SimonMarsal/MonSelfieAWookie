using System.Collections.Generic;

namespace SelfieAWookie.Core.Domain
{
    public interface ISelfieRepository
    {
        IList<Selfie> GetAll();
    }
}
