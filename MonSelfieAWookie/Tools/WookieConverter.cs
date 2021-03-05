using MonSelfieAWookie.Models.Dtos;

using SelfieAWookie.Core.Domain;

using System.Collections.Generic;
using System.Linq;

namespace MonSelfieAWookie.Tools
{
    public static class WookieConverter
    {
        //convertir une liste de wookie en liste de wookieDTO
        public static List<WookieDto> Convert(this List<Wookie> wookies)
            => wookies.Select(s => new WookieDto(s)).ToList();


        //convertir wookieAddDto en wookie
        public static Wookie Convert(this WookieAddDto wookieAddDto)
            => new Wookie() { Prenom = wookieAddDto.Nom, NbPoils = wookieAddDto.NbPoils, MainWeapon =new Weapon() { Id = wookieAddDto.WeaponId}};
    }
}
