using Ngdbeambracketconnect.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Tekla.Structures.Dialog;

namespace Ngdbeambracketconnect
{
    /// <summary>
    /// Interaction logic for TabExample.xaml
    /// </summary>
    public partial class TabExample : Window
    {
        //private BracketViewModel viewModel;
        public TabExample()
        {
            InitializeComponent();
            //viewModel = bracketViewModel;
            //this.DataContext = viewModel;
            //this.InitializeDataStorage(viewModel);

            //if (this.GetConnectionStatus())
            //{
            //    InitializeDistanceUnitDecimals();
            //}
        }

        //private bool GetConnectionStatus()
        //{
        //    throw new NotImplementedException();
        //}

        //private void InitializeDistanceUnitDecimals()
        //{
        //    throw new NotImplementedException();
        //}

        //private void InitializeDataStorage(BracketViewModel viewModel)
        //{
        //    throw new NotImplementedException();
        //}

        //private void Details_SelectClicked(object sender, EventArgs e)
        //{
        //    this.Details.SelectedProfile = this.viewModel.Profilename;
        //}

        //private void Details_SelectionDone(object sender, EventArgs e)
        //{
        //    this.viewModel.Profilename = this.Details.SelectedProfile;
        //}
    }
}
