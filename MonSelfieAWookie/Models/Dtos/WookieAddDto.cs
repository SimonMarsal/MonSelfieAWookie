using Microsoft.AspNetCore.Mvc;

namespace MonSelfieAWookie.Models.Dtos
{
    public class WookieAddDto
    {
        public string Nom { get; set; }
        public int NbPoils { get; set; }
        public int WeaponId { get; set; }
    }
}
