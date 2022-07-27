using Model.Entities;
using Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DTO
{
    #region Comment
    /*
     * SchoolS and S means Single mostly when we want to get a single entity for example School entity mostly we will be using for our edit forms whenever we need update for a single entity
     * SchoolL is L stand for Listing so if we want all our DTO as listed we will be using SchoolL and it will be mostly using for our ListForms for GridViews
     * [NotMapped] Whenever it creates our database that it will be added exra more columsn in School table such as CityName,DistrictName and [NotMapped] and Discriminator and so on in order to prevent that we use [NotMapped] attribute on our table
     */
    #endregion

    [NotMapped]
    public class SchoolS:School
    {
        public string CityName { get; set; }
        public string DistrictName { get; set; }

    }

    #region Comment
    /*
     * SchoolL is for Listing our entities in GridControl but when we list that we need Id,PrivateCode which they are inside the BaseEntity inheritted from it and also we defined SchoolName,CityName,DistrictName,Description by the way we don't need State on our GridControl
     */
    #endregion

    public class SchoolL : BaseEntity
    {
        public string SchoolName { get; set; }
        public string CityName { get; set; }
        public string DistrictName { get; set; }
        public string Description { get; set; }

    }
}
