using System;
using System.Collections.Generic;
using System.Text;

namespace SelfieAWookie.Core.Domain
{
    public interface IWookieRepository
    {
        IList<Wookie> GetAll();
    }
}
