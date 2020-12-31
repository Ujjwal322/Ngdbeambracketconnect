using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngdbeambracketconnect.Model
{
  public class StructureData
    {
        [StructuresField("HotRolledProfile")]
        public string HotRolledProfile;

        [StructuresField("BUTopFlgThickness")]
        public double BUTopFlgThickness;

        [StructuresField("TopLengthOption")]
        public int TopLengthOption;

        [StructuresField("InnerBoltOption")]
        public int InnerBoltOption;

        [StructuresField("BUTopFlangeWidth")]
        public double BUTopFlangeWidth;

        [StructuresField("BUWebThickness")]
        public double BUWebThickness;

        [StructuresField("BUBotFlangeThick")]
        public double BUBotFlangeThick;

        [StructuresField("BUBotFlangeWidth")]
        public double BUBotFlangeWidth;

        [StructuresField("TopFlangeStiffThick")]
        public double TopFlangeStiffThick;

        [StructuresField("BotFlangeStiffThick")]
        public double BotFlangeStiffThick;

        [StructuresField("BotFlangeStiffWidth")]
        public double BotFlangeStiffWidth;

        [StructuresField("StiffThickness")]
        public double StiffThickness;

        [StructuresField("BracketProjection")]
        public double BracketProjection;

        [StructuresField("BracketEPThickness")]
        public double BracketEPThickness;

        [StructuresField("BracketEPWidth")]
        public double BracketEPWidth;

        [StructuresField("BoltStandard")]
        public double BoltStandard;

        [StructuresField("BoltDiameter")]
        public double BoltDiameter;

        [StructuresField("BoltTolerance")]
        public double BoltTolerance;

        [StructuresField("OuterBoltOffset")]
        public double OuterBoltOffset;


        [StructuresField("OuterBoltQuantity")]
        public int OuterBoltQuantity;

        [StructuresField("InnerBoltOffset")]
        public double InnerBoltOffset;

        [StructuresField("InnerBoltQuantity")]
        public int InnerBoltQuantity;

        [StructuresField("InnerBoltSpacing")]
        public string InnerBoltSpacing;

        [StructuresField("OutsideOverhang")]
        public double OutsideOverhang;

        [StructuresField("InsideOverhang")]
        public double InsideOverhang;

    }
}
