using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

using System.Windows.Threading;
using System.Timers;

namespace Timer_and_Keyboard_Movement_and_Events
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        bool goLeft, goRight, goUp, goDown, Jump;
        int playerSpeed = 8;
        int speed = 5 ;
        int box_start_Y = 309;
        int JumpStep = 5;

        DispatcherTimer gameTimer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();

            myCanvas.Focus();

            gameTimer.Tick += GameTimerEvent;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);
            gameTimer.Start();

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            int box_Y = (int)Canvas.GetTop(box);

            //Red Rectangle Movement Controller
            if (goLeft == true && Canvas.GetLeft(player) > 5)
            {
                Canvas.SetLeft(player, Canvas.GetLeft(player) - playerSpeed);
            }
            if (goRight == true && Canvas.GetLeft(player) + (player.Width + 25) < Application.Current.MainWindow.Width)
            {
                Canvas.SetLeft(player, Canvas.GetLeft(player) + playerSpeed);
            }
            if(goUp == true && Canvas.GetTop(player) > 10)
            {
                Canvas.SetTop(player, Canvas.GetTop(player) - playerSpeed);
            }
            if (goDown == true && Canvas.GetTop(player) + (player.Height * 2) < Application.Current.MainWindow.Height)
            {
                Canvas.SetTop(player, Canvas.GetTop(player) + playerSpeed);
            }

            //Purple Rectangle Movement Controller
            Canvas.SetLeft(box, Canvas.GetLeft(box) - speed);

            if (Canvas.GetLeft(box) < 5 || Canvas.GetLeft(box) + (box.Width + 25) > Application.Current.MainWindow.Width)
            {
                speed = -speed;
            }

            if (Jump == true)
            {
                Canvas.SetTop(box, Canvas.GetTop(box) - JumpStep);
            }
            if (Jump == false)
            {
                if (Canvas.GetTop(box) != box_start_Y) 
                {
                    Canvas.SetTop(box, Canvas.GetTop(box) + JumpStep);
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            //Red Rectangle Movement Controller
            if (e.Key == Key.Left)
            {
                goLeft = true;
            }
            if (e.Key == Key.Right)
            {
                goRight = true;
            }
            if (e.Key == Key.Up)
            {
                goUp = true;
            }
            if (e.Key == Key.Down)
            {
                goDown = true;
            }

            //Purple Rectangle Movement Controller
            if (e.Key == Key.Space)
            {
                Jump = true;
            }

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //Red Rectangle Movement Controller
            if (e.Key == Key.Left)
            {
                goLeft = false;
            }
            if (e.Key == Key.Right)
            {
                goRight = false;
            }
            if (e.Key == Key.Up)
            {
                goUp = false;
            }
            if (e.Key == Key.Down)
            {
                goDown = false;
            }

            //Purple Rectangle Movement Controller
            if (e.Key == Key.Space)
            {
                Jump = false;
            }
        }
    }
}
