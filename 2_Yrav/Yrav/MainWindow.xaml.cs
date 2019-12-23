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

namespace Yrav
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

        bool A, B, C;

        private void PrC_TextChanged(object sender, TextChangedEventArgs e)
        {
            Prover();
        }

        private void PrB_TextChanged(object sender, TextChangedEventArgs e)
        {
            Prover();
        }

        private void Rec_Click(object sender, RoutedEventArgs e)
        {
            Prover();
            if (A && B && C)
            {
                Yravnenie urav = new Yravnenie(prA.Text, prB.Text, prC.Text);
                urav.Rechenie();
                Otv.Text = urav.Output();
            }
            else
            {
                Excep ex = new Excep();
                Otv.Text = ex.Excepen(A, B, C, "Ошибка в значении ");
            }
        }

        /// <summary>
        /// Контроль цвета ячеек в зависимости от значений в них
        /// </summary>
        private void Prover()
        {
            bool fa = double.TryParse(prA.Text, out double a);
            bool fb = double.TryParse(prB.Text, out double b);
            bool fc = double.TryParse(prC.Text, out double c);

            A = fa;
            B = fb;
            C = fc;

            //if (!fa)
            //    prA.BackColor = Color.Red;
            //else
            //    prA.BackColor = Color.AntiqueWhite;
            //if (!fb)
            //    prB.BackColor = Color.Red;
            //else
            //    prB.BackColor = Color.AntiqueWhite;
            //if (!fc)
            //    prC.BackColor = Color.Red;
            //else
            //    prC.BackColor = Color.AntiqueWhite;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            Prover();
        }
    }
}
