using MonSelfieAWookie.Models.Dtos;

using SelfieAWookie.Core.Domain;

using System.Collections.Generic;
using System.Linq;

namespace MonSelfieAWookie.Tools
{
    public static class SelfieConverter
    {

        public static List<SelfieDto> Convert(this List<Selfie> selfies)
            => selfies.Select(s => new SelfieDto(s)).ToList();

    }
}
