using Microsoft.AspNetCore.Mvc.Rendering;

using MonSelfieAWookie.Models.Dtos;

using SelfieAWookie.Core.Domain;

using System.Collections.Generic;
using System.Linq;

namespace MonSelfieAWookie.Tools
{
    public static class WeaponConverter
    {
        //convertir une liste de Weapon en liste de WeaponDto
        public static List<WeaponDto> Convert(this List<Weapon> weapons)
            => weapons.Select(s => new WeaponDto(s)).ToList();

        public static List<SelectListItem> ConvertToSelectList(this List<Weapon> weapons)
            => weapons.Select(s => new SelectListItem() { Text=s.Label, Value=s.Id.ToString()}).ToList();
    }
}
