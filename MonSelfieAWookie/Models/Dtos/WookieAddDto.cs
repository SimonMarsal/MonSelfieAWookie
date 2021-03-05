using Microsoft.AspNetCore.Mvc;

using System.ComponentModel.DataAnnotations;

namespace MonSelfieAWookie.Models.Dtos
{
    public class WookieAddDto
    {
        [Display(Name="Prénom")] //A ne pas faire car labels dans le domaine !
        public string Nom { get; set; }

        public int NbPoils { get; set; }

        public int WeaponId { get; set; }
    }
}
