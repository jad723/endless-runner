﻿using System;
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
using System.Windows.Threading;

namespace Endless_Runner
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer gameTimer = new DispatcherTimer();

        Rect playerHitBox, groundHitBox, obstacleHitBox;

        bool jumping, gameOver;

        int force = 20, speed = 5, score = 0;

        Random rnd = new Random();

        ImageBrush playerSprite = new ImageBrush();
        ImageBrush backgroundSprite = new ImageBrush();
        ImageBrush obstacleSprite = new ImageBrush();

        int[] obstaclePosition = { 320, 315, 310, 305, 300 };

        double spriteIndex = 0;

        public MainWindow()
        {
            InitializeComponent();

            MyCanvas.Focus();

            gameTimer.Tick += GameEngine;
            gameTimer.Interval = TimeSpan.FromMilliseconds(20);

            backgroundSprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/background.gif"));

            background.Fill = backgroundSprite;
            background2.Fill = backgroundSprite;

            StartGame();
        }

        private void GameEngine(object sender, EventArgs e)
        {
            
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void StartGame()
        {
            Canvas.SetLeft(background, 0);
            Canvas.SetLeft(background2, 1262);

            Canvas.SetLeft(player, 110);
            Canvas.SetTop(player, 140);

            Canvas.SetLeft(obstacle, 950);
            Canvas.SetTop(obstacle, 310);

            RunSprite(1);

            obstacleSprite.ImageSource = new BitmapImage(new Uri("pack://application:,,,/images/obstacle.gif"));
            obstacle.Fill = obstacleSprite;

            jumping = false;
            gameOver = false;
            score = 0;

            scoreText.Content = "Score: " + score;

            gameTimer.Start();
        }

        private void RunSprite(double i)
        {

        }
    }
}
