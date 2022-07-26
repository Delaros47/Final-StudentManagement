using Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class District:BaseEntityState
    {
        public string DistrictName { get; set; }
        public int CityId { get; set; }
        public string Description { get; set; }

        public City City { get; set; }

    }
}
