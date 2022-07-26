using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Functions
{
    public static class EnumFunctions
    {
        #region Comment
        /*
         * Here in our extension method class and method should be static whenever we declare a static method that we will be getting Description value from FormType enum via GetAttribute function here
         * First of value is null then it returns null value
         * memberInfo will go and get the exactly our enum if It is School then it will get school 
         * attribute is will go and get the Attribute of School and it asks Type then we give T and false it asks do you need inherited from our enum we set to false
         */
        #endregion

        private static T GetAttribute<T>(this Enum value) where T : Attribute
        {

            if (value == null) return null;
            var memberInfo = value.GetType().GetMember(value.ToString());
            var attribute = memberInfo[0].GetCustomAttributes(typeof(T),false);
            return (T)attribute[0];
        }

        #region Comment
        /*
         * Here we have create another extension method ToName it simply use GetAttribute extension method and get exactly enum description value
         * First if it is null then it returns null value 
         * attribute will use our private extension method then will get Attribute of it since our attribute name is Description so we can get it by System DescriptionAttribute class
         * then lastly if our attribute is null then it returns value for exaple if School attribute is empty then it return to us School as a string if not then it return exactly Description Attribute value
         */
        #endregion

        public static string ToName(this Enum value)
        {
            if (value == null) return null;
            var attribute = value.GetAttribute<DescriptionAttribute>();
            return attribute == null ? value.ToString() : attribute.Description;
        }

    }
}
