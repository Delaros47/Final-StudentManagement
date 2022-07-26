using Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    public class SchoolS:School
    {
        public string CityName { get; set; }
        public string DistrictName { get; set; }

    }
}
