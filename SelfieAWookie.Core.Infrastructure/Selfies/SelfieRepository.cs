﻿using SelfieAWookie.Core.Domain;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Infrastructure.Selfies
{
    public class SelfieRepository : ISelfieRepository
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
            => null;

        public Task<IList<Selfie>> GetAllAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
