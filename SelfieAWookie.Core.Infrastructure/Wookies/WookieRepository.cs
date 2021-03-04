using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Infrastructure.Wookies
{
    public class WookieRepository : IWookieRepository
    {
        public IList<Wookie> GetAll()
            => null;

        public Task<IList<Wookie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
