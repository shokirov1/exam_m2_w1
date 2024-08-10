using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public class CorporateClient:Client
    {
        public string CompanyName { get; set; }
        public int TaxId { get; set; }
    }
}
