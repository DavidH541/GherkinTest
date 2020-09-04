using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GherkinTest.Feature_5
{
    class WebClientGet
    {
        public string[] WebsiteGetter()
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            byte[] raw = wc.DownloadData("https://basherweb20200903162540.azurewebsites.net/api/reservations?hotelid=42075&whitelabelid=1020");

            string webData = System.Text.Encoding.UTF8.GetString(raw);

            string[] lines = webData.Split(',');
            
            return lines;
        }
    }
}
