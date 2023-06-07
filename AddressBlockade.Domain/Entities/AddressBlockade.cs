using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBlockade.Domain.Entities
{
    internal class AddressBlockade
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public Address AddressRef { get; set; }
        public int BlockadeTypeId { get; set; }
    }
}
