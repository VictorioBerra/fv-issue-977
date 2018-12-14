using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace FV_Iss_977
{
    [TypeConverter(typeof(EntityIdListTypeConverter))]
    public class EntityIdList : List<int>
    {
        public EntityIdList(IEnumerable<int> integers) : base(integers) { }
    }
}
