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

namespace MySqlApp
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Models.DadosModel db = new Models.DadosModel();

            db.pessoa.Add(new Models.pessoa
            {
                nome = "TIAGO",
                telefone = "123456"
            });

            db.SaveChanges();

            var l = db.pessoa.ToList();

            MessageBox.Show(l[0].nome);
        }
    }
}
