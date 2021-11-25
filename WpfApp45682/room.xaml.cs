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

namespace pap
{
    /// <summary>
    /// Логика взаимодействия для room.xaml
    /// </summary>
    public partial class room : Window
    {
            {
        enum Direction { left, right, up, down, };
        double x = 0;
        double y = 0;
        public Room()
        {
            InitializeComponent();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(MovePlayer);
            timer.Start();
        }
        private void MovePlayer(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyDown(Key.Left))
            {
                x -= .025;
                Canvas.SetLeft(Player, x);
            }
            else if (Keyboard.IsKeyDown(Key.Up))
            {
                y -= .025;
                Canvas.SetTop(Player, y);
            }
            else if (Keyboard.IsKeyDown(Key.Down))
            {
                y += .025;
                Canvas.SetTop(Player, y);
            }
            else if (Keyboard.IsKeyDown(Key.Right))
            {
                x += .025;
                Canvas.SetLeft(Player, x);
            }
    }
}
