using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asynchronous_programming.Interfaces
{
    public interface ILoadVerifier
    {
        Task<bool> VerifyAsync();
        bool Verify();
    }
}
