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

namespace WpfApp45682
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Game game;
        room room;
        public Start()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            byte n;
            bool success = byte.TryParse(Gamers.Text, out n);
            if (success)
            {
                if (n <= 1 | n > 10)
                {
                    Error.Content = "Введите число от 2 до 10";
                }
                else
                {
                    game = new Game(n);
                    room = new Room();
                    room.Show();
                    window.WindowState = WindowState.Minimized;
                }

            }
            else
            {
                Error.Content = "Введите число от 2 до 10";
            }
        }
    }
}
