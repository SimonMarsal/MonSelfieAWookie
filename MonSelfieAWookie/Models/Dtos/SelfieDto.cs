using SelfieAWookie.Core.Domain;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonSelfieAWookie.Models.Dtos
{
    public class SelfieDto
    {
        #region Constructors
        public SelfieDto(Selfie selfie)
        {
            this.Id = selfie.Id;
            this.Titre = selfie.Titre;
            this.Url = selfie.Url;
            this.Wookie = selfie.Wookie;
        }
        #endregion

        #region Propoerties
        public int Id { get; private set; }
        public string Titre { get; private set; }
        public string Url { get; private set; }
        public Wookie Wookie { get; set; }
        #endregion
    }
}
