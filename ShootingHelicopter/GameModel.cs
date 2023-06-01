using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ShootingHelicopter
{
    internal class GameModel
    {

        public bool GoUp {  get; set; }
        public bool GoDown { get; set; }
        public bool GameOver { get; set; }
        public int Score { get; set; }
        public int Speed { get; set; }
        public int UFOspeed { get; set; }
        public Random Random { get; set; }
        public List<PictureBox> Bullets { get; set; }

        public GameModel()
        {
            GoUp = false;
            GoDown = false;
            GameOver = false;
            Score = 0;
            Speed = 8;
            UFOspeed = 10;
            Random = new Random();
            Bullets = new List<PictureBox>();
        }
    }
}
