using Microsoft.AspNetCore.Mvc.Rendering;

using MonSelfieAWookie.Models.Dtos;

using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Models
{
    public class WookieViewModel
    {
        #region Properties
        public List<WookieDto> Wookies { get; set; }

        //Form elements
        public List<Weapon> MainWeapons { get; set; }
        public SelectList MainWeaponsSelectList { get; set; }
        #endregion
    }
}
