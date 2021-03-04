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

        public void Create(Wookie model)
        {
            _context.Woookies.Add(model);
            _context.SaveChanges();
        }

        public async Task CreateAsync(Wookie model)
        {
            _context.Woookies.Add(model);
            await _context.SaveChangesAsync();
        }

        #endregion

        public IList<Wookie> GetAll()
            => _context.Woookies.Include(i => i.MainWeapon)
            .Include(i => i.Selfies).ToList();

        public async Task<IList<Wookie>> GetAllAsync()
            => await _context.Woookies.AsNoTracking().Include(i => i.MainWeapon).ToListAsync();
    }
}
