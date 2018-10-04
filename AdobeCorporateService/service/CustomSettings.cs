using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdobeCorporateService.service
{
    public class CustomSettings
    {
        public static String CORPORATE_ENTITY_NO_OVERRIDE = "OEM/Royalty,Reseller/Disti,Solution Partner Program,Data Privacy,Outbound Royalty";
        public static String CORPORATE_ENTITY_STOCK = "C2A Adobe Stock Contributor, C2A Adobe Template Contributor Agreement - Fixed Fee, C2A Adobe Template Contributor Agreement - Revenue Share, C2A Adobe Stock 3D Asset Contributor";
        public static Dictionary<String, String> COMPANYCODECOUNTRYCODEMAP = new Dictionary<String, String>()
        {
            { "DMIG","US" },
            { "FOCA","CA" },
            { "ADUS","US" },
            { "NLFR","FR" },
            { "NLGM","DE" },
            { "ADIR","IR" },
            { "ALJP","JP" },
            { "ADSW","SW" },
            { "NDBV","ND" },
            { "ADUS_OLD","US" },
            { "ALST","US" },
            { "ADOBEMMS-US","ST" },
            { "3PTY","US" },
            { "ALAU","AU" }
        };
    }
}
