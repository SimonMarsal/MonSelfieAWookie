using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Models.Dtos
{
    public class WookieDto
    {
        #region Constructors
        public WookieDto(Wookie wookie)
        {
            this.Id = wookie.Id;
            this.SurName = wookie.Prenom;
            this.NbPoils = wookie.NbPoils;
            this.MainWeaponLabel = wookie.MainWeapon?.Label;
            this.NbSecondaryWeapons = (wookie.SecondaryWeapons?.Count).GetValueOrDefault(0);
            this.SelfieNumber = (wookie.Selfies?.Count).GetValueOrDefault(0);
        }
        #endregion

        #region Propoerties
        public int Id { get; private set; }
        public string SurName { get; private set; }
        public int NbPoils { get; private set; }
        public string MainWeaponLabel { get; private set; }
        public int NbSecondaryWeapons { get; private set; }
        public int SelfieNumber { get; private set; }
        #endregion
    }
}
