using Microsoft.AspNetCore.Mvc;

namespace MonSelfieAWookie.Models.Dtos
{
    public class SelfieAddDto
    {
        public string Titre { get; set; }
        public string Image { get; set; }
        public string[] Humeur { get; set; }
    }
}
