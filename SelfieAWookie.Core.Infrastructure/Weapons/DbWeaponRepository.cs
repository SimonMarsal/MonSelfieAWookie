using SelfieAWookie.Core.Domain;
using SelfieAWookie.Core.Infrastructure.Data;

using System.Collections.Generic;
using System.Linq;

namespace SelfieAWookie.Core.Infrastructure.Selfies
{
    public class DbWeaponRepository : IWeaponRepository
    {
        #region Fields
        private readonly SelfieAWookieDbContext _context = null;
        #endregion

        #region Constructor
        public DbWeaponRepository(SelfieAWookieDbContext context)
        {
            this._context = context;
        }
        #endregion

        public IList<Weapon> GetAll()
            => _context.Weapons.ToList();
    }
}
