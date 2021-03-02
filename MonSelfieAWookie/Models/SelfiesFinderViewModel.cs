using Microsoft.AspNetCore.Mvc.Rendering;

using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Models
{
    public class SelfiesFinderViewModel
    {
        #region Properties
        public List<Wookie> Wookies { get; set; }

        //Form elements
        public List<Weapon> MainWeapons { get; set; }
        public SelectList MainWeaponsSelectList { get; set; }
        #endregion
    }
}
