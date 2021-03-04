using Microsoft.EntityFrameworkCore;

using SelfieAWookie.Core.Domain;
using SelfieAWookie.Core.Infrastructure.Data;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Infrastructure.Wookies
{
    public class DbWookieRepository : IWookieRepository
    {
        #region Fields
        private readonly SelfieAWookieDbContext _context = null;
        #endregion

        #region Constructor
        public DbWookieRepository(SelfieAWookieDbContext context)
        {
            this._context = context;
        }
        #endregion

        public IList<Wookie> GetAll()
            => _context.Woookies.Include(i => i.MainWeapon)
            .Include(i => i.Selfies).ToList();

        public async Task<IList<Wookie>> GetAllAsync()
            => await _context.Woookies.AsNoTracking().Include(i => i.MainWeapon).ToListAsync();
    }
}
