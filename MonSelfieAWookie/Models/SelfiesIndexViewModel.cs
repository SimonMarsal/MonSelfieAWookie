using MonSelfieAWookie.Models.Dtos;

using SelfieAWookie.Core.Domain;

using System.Collections.Generic;

namespace MonSelfieAWookie.Models
{
    public class SelfiesIndexViewModel
    {
        #region Properties
        public List<SelfieDto> Selfies { get; set; }
        public List<Weapon> Weapons { get; set; }
        #endregion
    }
}
