using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace WPF_Images
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

        private void btAdicionar_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "Imagens |*.jpg;*.png | Todos os ficheiros |*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                if (openFileDialog.FileName != string.Empty && File.Exists(openFileDialog.FileName))
                {
                    BitmapImage bmp = new BitmapImage(new Uri(openFileDialog.FileName));
                    Image img = new Image();
                    img.BeginInit();
                    img.Source = bmp;
                    img.EndInit();
                    SPImagens.Children.Add(img);
                    //ImgCapa.Tag = openFileDialog.FileName;
                }
            }

        }
    }
}
