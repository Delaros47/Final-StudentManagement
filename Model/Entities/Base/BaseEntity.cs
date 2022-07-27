using Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entities.Base
{
    #region Comment
    /*
     * BaseEntity will be used in our EditForms our other entities will be implemented from it cause here long Id we will create our own long id and send it to the database beside if any EditForm has ToggleSwitch then we will be implementing from BaseEntityState
     * Here [Column(Order =0)] means that whenever our database is created that it will create our columns according to orders
     * Key means we say that our Id is Key we don't want the database to decide it is Key or not
     * DatabaseGenerated(DatabaseGeneratedOption.None) Here we say that don't make Identity Specification true we make it false
     * Required means that it shouldn't be null on our database in anyway we have to fill it
     * StringLength(25) here our PrivateCode is string length is 25 characters
     * We have made our PrivateCode as virtual so we can override from other entities since every entity will be different PrivateCode value
     */
    #endregion

    public class BaseEntity:IBaseEntity
    {
        [Column(Order =0),Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }

        [Column(Order = 1),Required,StringLength(25)]
        public virtual string PrivateCode { get; set; }
    }
}
