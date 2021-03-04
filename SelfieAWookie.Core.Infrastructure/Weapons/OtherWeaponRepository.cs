using SelfieAWookie.Core.Domain;
using SelfieAWookie.Core.Infrastructure.Data;

using System.Collections.Generic;
using System.Linq;

namespace SelfieAWookie.Core.Infrastructure.Selfies
{
    public class OtherWeaponRepository : IWeaponRepository
    {
        #region Fields

        #endregion

        #region Constructor
        public OtherWeaponRepository()
        {

        }
        #endregion

        public IList<Weapon> GetAll()
            => null;
    }
}
