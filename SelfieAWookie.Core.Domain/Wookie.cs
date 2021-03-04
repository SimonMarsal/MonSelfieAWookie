using System;
using System.Collections.Generic;

namespace SelfieAWookie.Core.Domain
{
    public class Wookie
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string AvatarUrl { get; set; }
        public int NbPoils { get; set; }
        public List<Selfie> Selfies { get; set; }
        public Weapon MainWeapon { get; set; }
        public List<Weapon> SecondaryWeapons { get; set; }
    }
}
