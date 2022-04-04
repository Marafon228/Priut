using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AddNewDog
{
    /// <summary>
    /// Interaction logic for AddDog.xaml
    /// </summary>
    public partial class AddDog : Page
    {
        public Dog CurrentDog { get; set; }
        public AddDog()
        {
            CurrentDog = new Dog();
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openImage = new OpenFileDialog();
            openImage.FileName = "";
            openImage.Filter = "All supported graphics|*.jpg;*.jpeg;*.png|" +
            "JPEG (*.jpg;*.jpeg)|*.jpg;*.jpeg|" +
            "Portable Network Graphic (*.png)|*.png";   // Filter files by extension

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                CurrentDog.Image = (byte[])new ImageConverter().ConvertTo(new Bitmap(openImage.FileName), typeof(byte[]));
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                ADO.Instance.Dog.Add(CurrentDog);
                ADO.Instance.SaveChanges();
                System.Windows.Forms.MessageBox.Show("OK");


            }
            catch (Exception ex )
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
