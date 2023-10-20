using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_LoginUI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        private string _Username;

        public string Username
        {
            get { return _Username; }
            set {
                _Username = value;
                RaisePropertyChanged("Username");
            }
        }


        private string _Passwoed;

        public string Passwoed
        {
            get { return _Passwoed; }
            set
            {
                _Passwoed = value;
                RaisePropertyChanged("Passwoed");
            }
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if (Username == "123" && Passwoed == "123")
            {
                //MessageBox.Show("OK");
                MAIN mAIN = new MAIN();
                mAIN.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("NG");
                Username = "";
                Passwoed = "";

            }

        }
    }
}
