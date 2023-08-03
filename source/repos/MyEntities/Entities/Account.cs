using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Account
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
        public decimal Balance  { get; set; }

        public int AccountNumber { get; set; }
        public AccountHolder AccountHolder { get; set; }
        public int AccountHolderId { get; set; }











    }
}
