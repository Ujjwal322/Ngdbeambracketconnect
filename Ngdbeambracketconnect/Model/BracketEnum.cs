using Ngdbeambracketconnect.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngdbeambracketconnect.Model
{
    public class BracketEnum : INotifyPropertyChanged
    {
        public BracketEnum() { }
        [DefaultValue(ProgramDetermines)]
        [TypeConverter(typeof(EnumDescriptionTypeConverter))]
        public enum BracketOptionEnum
        {
            [Description("Program Determines")]
            ProgramDetermines,
            [Description("Built Up Beam")]
            BuiltUpBeam,
            [Description("Hot Rolled")]
            HotRolled
        }

        [DefaultValue(PerStandard)]
        [TypeConverter(typeof(EnumDescriptionTypeConverter))]
        public enum WasherOptionEnum
        {
            [Description("Per Bolt Standard")]
            PerStandard,
            [Description("One Side")]
            Yes,
            [Description("Both Side")]
            YesBothSides
        }

        [DefaultValue(ProgramDetermines)]
        [TypeConverter(typeof(EnumDescriptionTypeConverter))]
        public enum SpliceBoltOptionEnum
        {
            [Description("No")]
            No,
            [Description("Program Determines")]
            ProgramDetermines,
            [Description("Yes")]
            Yes
        }

        [DefaultValue(ShearFlushInset)]
        [TypeConverter(typeof(EnumDescriptionTypeConverter))]
        public enum OuterBoltOptionEnum
        {
            [Description("Shear Flush Inset (Types B or P)")]
            ShearFlushInset,
            [Description("Flush Inset (Type I)")]
            FlushInset,
            [Description("Flush Slight Overhang (Type F)")]
            FlushSlightOverhang,
            [Description("Single Bolt Overhang (Type E)")]
            SingleBoltOverhang
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
