using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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
            if (menobox.Text != "")
            {
                if (datebox.SelectedDate != null)
                {
                    int vek = DateTime.Now.Year - datebox.SelectedDate.Value.Year;

                    if (DateTime.Now < datebox.SelectedDate.Value.AddYears(vek))
                    {
                        vek = vek - 1;
                    }

                    MessageBox.Show("Ahoj " + menobox.Text + ", máš " + vek + " rokov.");
                }
                else
                {
                    MessageBox.Show("Zadaj dátum narodenia.");
                }
            }
            else
            {
                MessageBox.Show("Zadaj meno.");
            }
        }

    }
}