using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monegement
{
    class TransactionItem
    {
        public string type { get; set; }
        public string category { get; set; }
        public string nominal { get; set; }
        public string notes { get; set; }
        public string transaction_date { get; set; }
        public string id_user { get; set; }
    }
}
