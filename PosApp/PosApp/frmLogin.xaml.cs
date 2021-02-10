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

namespace PosApp
{
    /// <summary>
    /// Interaction logic for frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {

        public static string loggedIn;
        public static string _name;
        public static string _surname;
        public static string _password;
        public static string _gender;
        public static string _dob;
        public static int _id;
        public static string _img;
        public static string _usertype;
        public bool _isActive = false;

        public bool result;
        public frmLogin()
        {
            InitializeComponent();
        }
    }
}
