using SelfieAWookie.Core.Domain;
using SelfieAWookie.Core.Infrastructure.Data;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public void Create(Weapon model)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(Weapon model)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        public IList<Weapon> GetAll()
            => _context.Weapons.ToList();

        public Task<IList<Weapon>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
