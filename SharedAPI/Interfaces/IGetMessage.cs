using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedAPI.Interfaces
{
    public interface IGetMessage
    {
        Task<string> GetMessage();
        Uri GetUri();
    }
}
