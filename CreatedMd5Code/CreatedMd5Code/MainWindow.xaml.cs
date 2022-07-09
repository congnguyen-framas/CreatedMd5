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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CreatedMd5Code
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

        //ma hoa
        private void btnEncrypt_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                txtDecryptContent.Text = EncodeMD5.EncryptString(txtEncryptContent.Text, txtEncryptPass.Text);
            }));
        }

        //giai ma
        private void btnDecrypt_Click(object sender, RoutedEventArgs e)
        {
            Dispatcher.BeginInvoke(new Action(() =>
            {
                txtEncryptContent.Text = EncodeMD5.DecryptString(txtDecryptContent.Text, txtDecryptPass.Text);
            }));
        }
    }
}
