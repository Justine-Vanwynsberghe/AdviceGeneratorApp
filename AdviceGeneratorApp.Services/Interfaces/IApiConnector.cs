using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdviceGeneratorApp.Models;

namespace AdviceGeneratorApp.Services.Interfaces
{
    public interface IApiConnector<T>
    {
        Task<T?> GetAsync(string requestUri);
    }
}
