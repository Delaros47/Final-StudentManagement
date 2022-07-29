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
    #region Comment
    /*
     * Here the reason IsUnique that we have put false that for example Mardin has Derik and Kızıltepe it will be District-00001 and District-00002 and at the same time Antalya also has Alanya and Manavgat it will be District-00001 and District-00002 with different will be their CityId because when we open Antalya Districts and it will be listed its Districts so better to start from District-00001 and District-00002 if we put IsUnique =true then it will start from 1 until different number District Private Code will get but we don't want something like that
     */
    #endregion

    public class District:BaseEntityState
    {
        [Index("IX_PrivateCode",IsUnique =false)]
        public override string PrivateCode { get; set; }
        [Required,StringLength(50)]
        public string DistrictName { get; set; }
        public long CityId { get; set; }
        [StringLength(500)]
        public string Description { get; set; }

        public City City { get; set; }

    }
}
