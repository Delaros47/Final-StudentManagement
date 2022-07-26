using Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class City:BaseEntityState
    {
        public string CityName { get; set; }
        public string Description { get; set; }

    }
}
