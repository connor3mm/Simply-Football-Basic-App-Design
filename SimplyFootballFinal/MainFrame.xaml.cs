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

namespace SimplyFootballFinal
{
    /// <summary>
    /// Interaction logic for MainFrame.xaml
    /// </summary>
    public partial class MainFrame : Window
    {
        public MainFrame()
        {
            InitializeComponent();
        }


        private void btnAddFootballer_Click(object sender, RoutedEventArgs e)
        {
            PlayerMember Awindow = new PlayerMember();
            Awindow.ShowDialog();
        }

        private void btnFootProfile_Click(object sender, RoutedEventArgs e)
        {
            playerProfile Awindow = new playerProfile();
            Awindow.ShowDialog();
        }

        private void BtnListAll_Click(object sender, RoutedEventArgs e)
        {
        }

        private void btnPrint_Click(object sender, RoutedEventArgs e)
        {
        }
    }
}
