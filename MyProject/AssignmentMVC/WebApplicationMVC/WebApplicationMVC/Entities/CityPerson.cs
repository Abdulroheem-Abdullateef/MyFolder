using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC.Entities
{
    public class CityPerson
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public int PersonId { get; set; }
        public City City { get; set; }
        public Person Person { get; set; }

    }
}
