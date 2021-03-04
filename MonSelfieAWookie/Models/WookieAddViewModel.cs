
using Microsoft.AspNetCore.Mvc.Rendering;

using MonSelfieAWookie.Models.Dtos;

using System.Collections.Generic;

namespace MonSelfieAWookie.Models
{
    public class WookieAddViewModel
    {
        #region Properties
        public List<WeaponDto> MainWeapons { get; set; }

        public WookieAddDto WookieAddDto { get; set; }

        public List<SelectListItem> MainWeaponsSelectList { get; set; }
        #endregion
    }
}
