using Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Functions
{
    public static class Converts
    {
        #region Comment
        /*
         * This is our Entity convert function it will convert DTO to entities first it will get their properties if they have the same name then it will assign the values on them
         */
        #endregion

        public static TTarget EntityConvert<TTarget>(this IBaseEntity source)
        {
            #region Comment
            /*
             * If the source is null then it returns null value
             * destination is our target so we create an instance from it
             * sourceProp and destinationProp we reach both of them properties via reflection so since destinationProp is generic so we have to access to its properties by typeof
             * It simply takes all values from DTO to entity and if it is empty it assign null value
             *  
             */
            #endregion

            if (source == null) return default(TTarget);
            var destination = Activator.CreateInstance<TTarget>();
            var sourceProp = source.GetType().GetProperties();
            var destinationProp = typeof(TTarget).GetProperties();

            foreach (var sp in sourceProp)
            {
                var value = sp.GetValue(source);
                var dp = destinationProp.FirstOrDefault(x=>x.Name==sp.Name);
                if (dp!=null)
                {
                    dp.SetValue(destination,ReferenceEquals(value,"")?null:value);
                }
            }
            return destination;
        }

    }
}
