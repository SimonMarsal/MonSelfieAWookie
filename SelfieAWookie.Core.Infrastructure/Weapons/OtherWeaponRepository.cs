using SelfieAWookie.Core.Domain;
using SelfieAWookie.Core.Infrastructure.Data;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            => new List<Weapon>()
                    {
                        new Weapon(){ Id=1, Label="Sabre bleu foncé"},
                        new Weapon(){ Id=2, Label="Sabre vert"},
                        new Weapon(){ Id=3, Label="Bow"}
                    };

        public Task<IList<Weapon>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
