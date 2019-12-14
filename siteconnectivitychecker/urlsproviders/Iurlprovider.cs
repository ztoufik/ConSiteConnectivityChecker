using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siteconnectivitychecker.urlsproviders
{
    public interface Iurlprovider
    {
         string[] geturls();
         bool addurl(string url);
         bool removeurl(string url);
    }
}
