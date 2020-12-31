using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngdbeambracketconnect.Model
{

    [AttributeUsage(AttributeTargets.Field)]
    public sealed class StructuresFieldAttribute :Attribute
    {
        private string AttributeName;

        public StructuresFieldAttribute(string attributeName)
        {
            this.AttributeName = attributeName;
        }
    }
}
