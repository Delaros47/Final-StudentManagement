using Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities
{
    public class City:BaseEntityState
    {
        [Index("IX_PrivateCode", IsUnique = true)]
        public override string PrivateCode { get; set; }
        [Required,StringLength(50)]
        public string CityName { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

    }
}
