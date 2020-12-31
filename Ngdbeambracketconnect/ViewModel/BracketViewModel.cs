using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Tekla.Structures.Dialog;
using TD = Tekla.Structures.Datatype;
using static Ngdbeambracketconnect.Model.BracketEnum;

namespace Ngdbeambracketconnect.ViewModel
{
    public class BracketViewModel : INotifyPropertyChanged
    {
        private BracketOptionEnum _bracket;

        private CanopyOptionEnum _canopy;

        private SpliceBoltOptionEnum _spliceBoltOption;

        private Visibility _textBoxVisibility1;

        private Visibility _textBoxVisibility;

        private Visibility _imageVisiblity;
        private Visibility _imageVisiblity1;

        private WasherOptionEnum _washerOption;

        private OuterBoltOptionEnum _outerBoltOption;
        public Visibility TextBoxVisibility
        {
            get { return _textBoxVisibility; }
            set
            {
                _textBoxVisibility = value;
                OnPropertyChanged();
            }
        }

        public Visibility TextBoxVisibility1
        {
            get { return _textBoxVisibility1; }
            set
            {
                _textBoxVisibility1 = value;
                OnPropertyChanged();
            }
        }

        public BracketOptionEnum BracketDetail
        {
            get { return _bracket; }

            set
            {
                _bracket = value;
                OnPropertyChanged();
                TextBoxVisibility = (BracketDetail == BracketOptionEnum.HotRolled) ? Visibility.Visible : Visibility.Collapsed;
                TextBoxVisibility1 = (BracketDetail == BracketOptionEnum.BuiltUpBeam) ? Visibility.Visible : Visibility.Collapsed;

                //if (value =="Program Det.")
                //    TextBoxVisibility = Visibility.Hidden;
                //else
                //    TextBoxVisibility = Visibility.Visible;
            }
        }

        public Visibility ImageVisible
        {
            get { return _imageVisiblity; }
            set
            {
                _imageVisiblity = value;
                OnPropertyChanged();

            }
        }

        public Visibility ImageVisible1
        {
            get { return _imageVisiblity1; }
            set
            {
                _imageVisiblity1 = value;
                OnPropertyChanged();

            }
        }

        public CanopyOptionEnum CanopyDetail
        {
            get { return _canopy; }

            set
            {
                _canopy = value;
                OnPropertyChanged();
                ImageVisible = (CanopyDetail == CanopyOptionEnum.BuiltUpBeam) ? Visibility.Visible : Visibility.Hidden;
                ImageVisible1 = (CanopyDetail == CanopyOptionEnum.HotRolled) ? Visibility.Visible : Visibility.Collapsed;
                //ImageVisible1 = (CanopyDetail == CanopyOptionEnum.BuiltUpBeam) ? Visibility.Visible : Visibility.Collapsed;

            }
        }

        public SpliceBoltOptionEnum SpliceBoltOption
        {
            get { return _spliceBoltOption; }
            set
            {
                _spliceBoltOption = value;
                OnPropertyChanged();
            }
        }

        public WasherOptionEnum WasherOption
        {
            get { return _washerOption; }
            set
            {
                _washerOption = value;
                OnPropertyChanged();
            }
        }

        private Visibility _Image1;
        private Visibility _Image2;
        private Visibility _Image3;
        private Visibility _Image4;
        private Visibility _Image5;
        private Visibility _Image6;


        public Visibility Image1
        {
            get { return _Image1; }
            set
            {
                _Image1 = value;
                OnPropertyChanged();
            }
        }

        public Visibility Image2
        {
            get { return _Image2; }
            set
            {
                _Image2 = value;
                OnPropertyChanged();
            }
        }

        public Visibility Image3
        {
            get { return _Image3; }
            set
            {
                _Image3 = value;
                OnPropertyChanged();
            }
        }

        public Visibility Image4
        {
            get { return _Image4; }
            set
            {
                _Image4 = value;
                OnPropertyChanged();
            }
        }

        public Visibility Image5
        {
            get { return _Image5; }
            set
            {
                _Image5 = value;
                OnPropertyChanged();
            }
        }

        public Visibility Image6
        {
            get { return _Image6; }
            set
            {
                _Image6 = value;
                OnPropertyChanged();
            }
        }

        public OuterBoltOptionEnum OuterBoltOption
        {
            get { return _outerBoltOption; }
            set
            {
                _outerBoltOption = value;
                OnPropertyChanged();
                Image1 = (OuterBoltOption == OuterBoltOptionEnum.ShearFlushInset) ? Visibility.Visible : Visibility.Hidden;
                Image2 = (OuterBoltOption == OuterBoltOptionEnum.FlushInset) ? Visibility.Visible : Visibility.Hidden;
                Image3 = (OuterBoltOption == OuterBoltOptionEnum.FlushSlightOverhang) ? Visibility.Visible : Visibility.Hidden;
                Image4 = (OuterBoltOption == OuterBoltOptionEnum.SingleBoltOverhang) ? Visibility.Visible : Visibility.Hidden;
                Image5 = (OuterBoltOption == OuterBoltOptionEnum.ShearFlushInset) ? Visibility.Collapsed : Visibility.Visible;
                Image6 = (OuterBoltOption == OuterBoltOptionEnum.ShearFlushInset) ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        private String _hotRolledProfile;

        public String HotRolledProfile
        {
            get { return _hotRolledProfile; }
            set
            {
                _hotRolledProfile = value;
                OnPropertyChanged();
            }
        }

        private double _buTopFlgThickness;

        public double BUTopFlgThickness
        {
            get { return _buTopFlgThickness; }
            set
            {
                _buTopFlgThickness = value;
                OnPropertyChanged();
            }
        }

        private double _buTopFlangeWidth;
        public double BUTopFlangeWidth
        {
            get { return _buTopFlangeWidth; }
            set
            {
                _buTopFlangeWidth = value;
                OnPropertyChanged();
            }
        }

        private double _buWebThickness;
        public double BUWebThickness
        {
            get { return _buWebThickness; }
            set
            {
                _buWebThickness = value;
                OnPropertyChanged();
            }
        }

        private double _buBotFlangeThick;
        public double BUBotFlangeThick
        {
            get { return _buBotFlangeThick; }
            set
            {
                _buBotFlangeThick = value;
                OnPropertyChanged();
            }
        }

        private double _buBotFlangeWidth;
        public double BUBotFlangeWidth
        {
            get { return _buBotFlangeWidth; }
            set
            {
                _buBotFlangeWidth = value;
                OnPropertyChanged();
            }
        }

        private double _topFlangeStiffThick;
        public double TopFlangeStiffThick
        {
            get { return _topFlangeStiffThick; }
            set
            {
                _topFlangeStiffThick = value;
                OnPropertyChanged();
            }
        }

        private double _topFlangeStiffWidth;
        public double TopFlangeStiffWidth
        {
            get { return _topFlangeStiffWidth; }
            set
            {
                _topFlangeStiffWidth = value;
                OnPropertyChanged();
            }
        }

        private double _botFlangeStiffThick;
        public double BotFlangeStiffThick
        {
            get { return _botFlangeStiffThick; }
            set
            {
                _botFlangeStiffThick = value;
                OnPropertyChanged();
            }
        }

        private double _botFlangeStiffWidth;
        public double BotFlangeStiffWidth
        {
            get { return _botFlangeStiffWidth; }
            set
            {
                _botFlangeStiffWidth = value;
                OnPropertyChanged();
            }
        }

        private double _stiffThickness;
        public double StiffThickness
        {
            get { return _stiffThickness; }
            set
            {
                _stiffThickness = value;
                OnPropertyChanged();
            }
        }

        private double _bracketProjection;
        public double BracketProjection
        {
            get
            {
                return _bracketProjection;
            }
            set
            {
                _bracketProjection = value;
                OnPropertyChanged();
            }
        }

        private double _bracketEPThickness;
        public double BracketEPThickness
        {
            get { return _bracketEPThickness; }
            set
            {
                _bracketEPThickness = value;
                OnPropertyChanged();
            }
        }

        private double _bracketEPWidth;
        public double BracketEPWidth
        {
            get { return _bracketEPWidth; }
            set
            {
                _bracketEPWidth = value;
                OnPropertyChanged();
            }
        }

        private double _beamEPThickness;
        public double BeamEPThickness
        {
            get { return _beamEPThickness; }
            set
            {
                _beamEPThickness = value;
                OnPropertyChanged();
            }
        }

        private double _beamEPWidth;
        public double BeamEPWidth
        {
            get { return _beamEPWidth; }
            set
            {
                _beamEPWidth = value;
                OnPropertyChanged();
            }
        }

        private double _boltDiameter;
        public double BoltDiameter
        {
            get { return _boltDiameter; }
            set
            {
                _boltDiameter = value;
                OnPropertyChanged();
            }
        }

        private double _boltTolerance;
        public double BoltTolerance
        {
            get { return _boltTolerance; }
            set
            {
                _boltTolerance = value;
                OnPropertyChanged();
            }
        }

        private double _boltGage;
        public double BoltGage
        {
            get { return _boltGage; }
            set
            {
                _boltGage = value;
                OnPropertyChanged();
            }
        }

        private double _outerBoltOffset;
        public double OuterBoltOffset
        {
            get { return _outerBoltOffset; }
            set
            {
                _outerBoltOffset = value;
                OnPropertyChanged();
            }
        }

        private int _outerBoltQuantity;
        public int OuterBoltQuantity
        {
            get { return _outerBoltQuantity; }
            set
            {
                _outerBoltQuantity = value;
                OnPropertyChanged();
            }
        }

        private int _innerBoltQuantity;
        public int InnerBoltQuantity
        {
            get { return _innerBoltQuantity; }
            set
            {
                _innerBoltQuantity = value;
                OnPropertyChanged();
            }
        }

        private double _innerBoltOffset;
        public double InnerBoltOffset
        {
            get { return _innerBoltOffset; }
            set
            {
                _innerBoltOffset = value;
                OnPropertyChanged();
            }
        }

     

        private double _outsideOverhang;
        public double OutsideOverhang
        {
            get { return _outsideOverhang; }
            set
            {
                _outsideOverhang = value;
                OnPropertyChanged();
            }
        }

        private double _insideOverhang;
        public double InsideOverhang
        {
            get { return _insideOverhang; }
            set
            {
                _insideOverhang = value;
                OnPropertyChanged();
            }
        }

        private LengthOptionEnum _topLengthOption;
        public LengthOptionEnum TopLengthOption
        {
            get { return _topLengthOption; }
            set
            {
                _topLengthOption = value;
                OnPropertyChanged();
            }
        }

        private LengthOptionEnum _botLengthOption;

        public LengthOptionEnum BotLengthOption
        {
            get { return _botLengthOption; }
            set
            {
                _botLengthOption = value;
                OnPropertyChanged();
            }
        }

        private InnerBoltOptionEnum _innerBoltOption;
        private string partname;
        private string profile = string.Empty;

        public InnerBoltOptionEnum InnerBoltOption
        {
            get { return _innerBoltOption; }
            set
            {
                _innerBoltOption = value;
                OnPropertyChanged();
                Image1 = (InnerBoltOption == InnerBoltOptionEnum.MatchesOuterOption) ? Visibility.Visible : Visibility.Hidden;
                Image2 = (InnerBoltOption == InnerBoltOptionEnum.FlushInset) ? Visibility.Visible : Visibility.Hidden;
                Image3 = (InnerBoltOption == InnerBoltOptionEnum.FlushSlightOverhang) ? Visibility.Visible : Visibility.Hidden;
                Image4 = (InnerBoltOption == InnerBoltOptionEnum.SingleBoltOverhang) ? Visibility.Visible : Visibility.Hidden;
                Image5 = (InnerBoltOption == InnerBoltOptionEnum.MatchesOuterOption) ? Visibility.Collapsed : Visibility.Visible;
            }
        }

        [StructuresDialog("profile", typeof(TD.String))]
        public string Profilename
        {
            get { return profile; }
            set { profile = value; OnPropertyChanged("Profilename"); }
        }

        //private void OnPropertyChanged(string property)
        //{
        //    PropertyChangedEventHandler handler = PropertyChanged;
        //    if (handler != null)
        //    {
        //        handler(this, new PropertyChangedEventArgs(property));
        //    }
        //}

        public event PropertyChangedEventHandler PropertyChanged;


        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


        }
    }
}
