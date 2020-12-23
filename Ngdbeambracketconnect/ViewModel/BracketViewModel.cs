using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Ngdbeambracketconnect.Model.BracketEnum;

namespace Ngdbeambracketconnect.ViewModel
{
    public class BracketViewModel : INotifyPropertyChanged
    {
        private BracketOptionEnum _bracket;

        private SpliceBoltOptionEnum _spliceBoltOption;

        private Visibility _textBoxVisibility1;

        private Visibility _textBoxVisibility;

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


        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
