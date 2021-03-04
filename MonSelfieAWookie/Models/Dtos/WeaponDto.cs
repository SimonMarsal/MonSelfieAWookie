using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Models.Dtos
{
    public class WeaponDto
    {
        #region Constructors
        public WeaponDto(Weapon weapon)
        {
            this.Id = weapon.Id;
            this.Label = weapon.Label;
            this.GroupName = weapon.GroupName;
        }
        #endregion

        #region Propoerties
        public int Id { get; private set; }
        public string Label { get; private set; }
        public string GroupName { get; private set; }
        #endregion
    }
}
