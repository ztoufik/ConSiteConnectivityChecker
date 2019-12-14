using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace siteconnectivitychecker.urlsproviders
{
    public class fileurlprovider : Iurlprovider
    {
        string filepath = null;
        
        public fileurlprovider(string filepath)
        {
            this.filepath = filepath;
        }

        string[] Iurlprovider.geturls()
        {
            return File.ReadAllLines(filepath);
        }

        bool Iurlprovider.addurl(string url)
        {
            try
            {
                using (StreamWriter stream = new StreamWriter(new FileStream(filepath, FileMode.Append)))
                {
                    stream.WriteLine(url);
                    return true;
                }
            }
            catch(IOException)
            {
                return false;

            }
        }

        bool Iurlprovider.removeurl(string url)
        {
            try
            {
                string[] urls = File.ReadAllLines(filepath);
                urls = urls.Where(site => site != url).ToArray();
                File.WriteAllLines(filepath, urls);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            
        }
    }
}
