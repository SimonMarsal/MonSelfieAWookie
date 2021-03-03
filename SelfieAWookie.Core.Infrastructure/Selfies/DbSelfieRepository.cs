using SelfieAWookie.Core.Domain;
using SelfieAWookie.Core.Infrastructure.Data;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.Json;

namespace SelfieAWookie.Core.Infrastructure.Selfies
{
    public class DbSelfieRepository : ISelfieRepository
    {
        #region Fields
        private SelfieAWookieDbContext _context = null;
        #endregion

        #region Constructor
        public DbSelfieRepository(SelfieAWookieDbContext context)
        {
            this._context = context;
        }
        #endregion

        public IList<Selfie> GetAll()
        => new List<Selfie>()
                {
                    new Selfie(){ Id=1, Url="https://c1.staticflickr.com/1/39/85740389_00e3dfb5bf_b.jpg", Titre = "Ioda"},
                    new Selfie(){ Id=2, Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg", Titre="Chewbacca"}
                };


    }
}
