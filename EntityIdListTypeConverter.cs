using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FV_Iss_977
{
    public class EntityIdListTypeConverter : TypeConverter
    {
        public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
        {
            return sourceType == typeof(string) || base.CanConvertFrom(context, sourceType);
        }

        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object value)
        {
            if (value == null)
                return null;

            if (value is string s)
            {
                if (string.IsNullOrEmpty(s))
                    return null;
                return new EntityIdList(s.Split(',').Select(int.Parse).Distinct());
            }
            return base.ConvertFrom(context, culture, value);
        }

    }
}
