using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldFramework.WrapperClasses
{
    public interface IUri
    {
        Uri GetUri(string uriString);
    }
}
