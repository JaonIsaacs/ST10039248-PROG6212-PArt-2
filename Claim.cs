using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST10039248_PROG6212
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public List<string> Documents { get; set; }
    }
}
