using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimplyFootballFinal
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainFrame Awindow = new MainFrame();
            Awindow.ShowDialog();
            //string textBoxPass;
            //string textBoxUser;
            //textBoxPass = passwordBox.Text;
            //textBoxUser = txtBoxUser.Text;
            //validUser(textBoxUser);
            //validPass(textBoxPass);
        }

        /// <summary>
        /// Regex for password
        /// </summary>
        /// <param name="pass">password</param>
        /// <returns>Password valid or not</returns>
        public bool validPass(string pass)
        {
            var input = pass;


            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Please enter Password");
            }

            var hasNumber = new Regex(@"[0-9]+");
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasMiniMaxChars = new Regex(@".{8,15}");

            var valid = hasNumber.IsMatch(input) && hasUpperChar.IsMatch(input) && hasMiniMaxChars.IsMatch(input);

            return valid;
        }


        /// <summary>
        /// To validate the username
        /// </summary>
        /// <param name="user">username</param>
        /// <returns>username valid or not</returns>
        public bool validUser(string user)
        {
            var input = user;


            if (string.IsNullOrWhiteSpace(input))
            {
                throw new Exception("Please enter Username");
            }

            var startsWith = new Regex(@"[A-Za-z0-9]");
            var hasMiniMaxChars = new Regex(@"[A-Za-z0-9._()\[\]-]{3,15}");

            var valid = startsWith.IsMatch(input) && hasMiniMaxChars.IsMatch(input);

            return valid;
        }
    }
}
