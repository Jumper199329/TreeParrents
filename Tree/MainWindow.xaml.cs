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
using System.Windows.Forms;
using System.IO;
using System.Net;
using Tree.Classes;

namespace Tree
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            EnterToAccount win = new EnterToAccount();
            win.ShowDialog();
        }

        private void ChangeUser_Click(object sender, RoutedEventArgs e)
        {
            EnterToAccount win = new EnterToAccount();
            win.ShowDialog();
        }

        private void Registration_Click(object sender, RoutedEventArgs e)
        {
            EnterToAccount win = new EnterToAccount();
            win.ShowDialog();
        }

        private void AddParrent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeInfoAboutParr_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ChangeInfoAboutMySelf_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Spouse_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Foto_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Show show = new Tree.Show();
            show.ShowDialog();
        }

        private void DifferentFacts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
        }

        private void foto_Click(object sender, RoutedEventArgs e)
        {
            Stream mystrm = null;
            OpenFileDialog opf = new OpenFileDialog();
            opf.InitialDirectory = "c:\\";
            opf.Filter = "Image file|*.png;*.jpg";
            opf.FilterIndex = 2;
            opf.RestoreDirectory = true;
            opf.ShowDialog();
            try
            {
                if (opf.FileName != "")
                {
                    if ((mystrm = opf.OpenFile()) != null)
                    {
                        using (mystrm)
                        {
                            FtpWebRequest ftp = (FtpWebRequest)WebRequest.Create("ftp://212.164.229.37/Public/eee.jpg");
                            ftp.Method = WebRequestMethods.Ftp.UploadFile;
                            ftp.Credentials = new NetworkCredential("Programm", "1993Jumper");
                            Stream ftpstream = ftp.GetRequestStream();
                            byte[] buf = new byte[1024];
                            int bytesRead = 0;
                            do
                            {
                                bytesRead = mystrm.Read(buf, 0, 1024);
                                ftpstream.Write(buf, 0, bytesRead);
                            } while (bytesRead != 0);
                            mystrm.Close();
                            ftpstream.Close();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show("WTF?! :" + ex.Message);
            }
        }
    }
}
