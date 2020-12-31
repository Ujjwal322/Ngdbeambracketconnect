using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngdbeambracketconnect.Converter
{
    public class BotLength : List<string>
    {
        public BotLength()
        {
            this.Add("None");
            this.Add("Full Length");
            this.Add("HalfLength");
        }

    }
}
