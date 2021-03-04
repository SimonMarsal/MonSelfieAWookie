using SelfieAWookie.Core.Domain;
using SelfieAWookie.Core.Infrastructure.Data;

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text.Json;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Infrastructure.Selfies
{
    public class DbSelfieRepository : ISelfieRepository
    {
        #region Fields
        private readonly SelfieAWookieDbContext _context = null;
        #endregion

        #region Constructor
        public DbSelfieRepository(SelfieAWookieDbContext context)
        {
            this._context = context;
        }
        #endregion

        public IList<Selfie> GetAll()
            => _context.Selfies.ToList();

        public Task<IList<Selfie>> GetAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
