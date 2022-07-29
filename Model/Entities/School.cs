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
     * [Index("IX_PrivateCode",IsUnique =true)] Here since we always make Order By by Private Code so we will use it often if we make it as Index that it will work faster and I named it as IX_PrivateCode  and also IsUnique =true it will be unique we cannot write the same Private Code again
     */
    #endregion

    public class School : BaseEntityState
    {

        [Index("IX_PrivateCode",IsUnique =true)]
        public override string PrivateCode { get; set; }
        [Required, StringLength(75)]
        public string SchoolName { get; set; }
        public long CityId { get; set; }
        public long DistrictId { get; set; }
        [StringLength(500)]
        public string Description { get; set; }


        public City City { get; set; }
        public District District { get; set; }

    }
}
