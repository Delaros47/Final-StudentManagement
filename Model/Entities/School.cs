using Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class School:BaseEntityState
    {
        public string SchoolName { get; set; }
        public int CityId { get; set; }
        public int DistrictId { get; set; }
        public string Description { get; set; }


        public City City { get; set; }
        public District District { get; set; }

    }
}
