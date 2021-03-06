﻿using SelfieAWookie.Core.Domain;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Infrastructure.Wookies
{
    public class MemorySelfieRepository : ISelfieRepository
    {
        public void Create(Selfie model)
        {
            throw new System.NotImplementedException();
        }

        public Task CreateAsync(Selfie model)
        {
            throw new System.NotImplementedException();
        }

        public IList<Selfie> GetAll()
            => new List<Selfie>()
                {
                    new Selfie(){ Id=1, Url="https://c1.staticflickr.com/1/39/85740389_00e3dfb5bf_b.jpg", Titre = "Ioda"},
                    new Selfie(){ Id=2, Url="https://c1.staticflickr.com/1/779/31649499113_374ef73b32_b.jpg", Titre="Chewbacca"}
                };

        public Task<IList<Selfie>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
