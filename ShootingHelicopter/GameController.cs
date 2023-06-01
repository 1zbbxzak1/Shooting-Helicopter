using System;
using System.Windows.Forms;

namespace ShootingHelicopter
{
    internal class GameController
    {
        public Form1 Form {  get; set; }
        public GameModel Model { get; set; }
        private GameView View { get; set; }

        private readonly int playerSpeed = 7;
        public Timer _timer;

        public bool Shot { get; set; }

        public GameController()
        {
            Form = new Form1(this)
            {
                KeyPreview = true
            };

            Model = new GameModel();
            View = new GameView(Form, Form.txtScore, Model);
            Form.KeyDown += new KeyEventHandler((sender, e) => KeyIsDown(e, Model));
            Form.KeyUp += new KeyEventHandler((sender, e) => KeyIsUp(e));


            _timer = new Timer { Interval = 20 };
            _timer.Start();
            _timer.Tick += new EventHandler((x, y) => MainTimerEvent(Model, Form, View));
        }

        public void MainTimerEvent(GameModel model, Form1 form1, GameView view)
        {
            form1.txtScore.Text = "Score: " + model.Score;

            if (model.GoUp && form1.player.Top > 0)
            {
                form1.player.Top -= playerSpeed;
            }
            if (model.GoDown && form1.player.Top + form1.player.Height < form1.ClientSize.Height)
            {
                form1.player.Top += playerSpeed;
            }

            form1.ufo.Left -= model.UFOspeed;

            if (view.Form.ufo.Left + form1.ufo.Width < 0)
            {
                View.ChangeUFO();
            }

            foreach (Control x in form1.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "pillar")
                {
                    x.Left -= model.Speed;
                    if (x.Left < -200)
                    {
                        x.Left = 1000;
                    }

                    if (form1.player.Bounds.IntersectsWith(x.Bounds))
                    {
                        model.GameOver = true;
                        ShowGameOver(model.Score);
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    x.Left += 25;
                    if (x.Left > 800)
                    {
                        view.RemoveBullet((PictureBox)x);
                    }

                    if (form1.ufo.Bounds.IntersectsWith(x.Bounds))
                    {
                        view.RemoveBullet((PictureBox)x);
                        model.Score += 1;
                        View.ChangeUFO();
                    }
                }
            }

            if (form1.player.Bounds.IntersectsWith(form1.ufo.Bounds))
            {
                model.GameOver = true;
                ShowGameOver(model.Score);
            }

            if (model.Score > 10)
            {
                model.Speed = 12;
                model.UFOspeed = 18;
            }
        }

        public void KeyIsDown(KeyEventArgs e, GameModel model)
        {
            if (e.KeyCode == Keys.Up)
            {
                model.GoUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                model.GoDown = true;
            }
            if (e.KeyCode == Keys.Space && !Shot)
            {
                Shot = true;
                View.MakeBullet();
            }
        }

        public void KeyIsUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                Model.GoUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                Model.GoDown = false;
            }
            if (e.KeyCode == Keys.Enter && Model.GameOver)
            {
                RestartGame();
            }
            if (e.KeyCode == Keys.Space)
            {
                Shot = false;
            }
        }

        public void ShowGameOver(int score)
        {
            _timer.Stop();
            Form.txtScore.Text = "Score: " + score + " Игра окончена, нажмите Enter, чтобы повторить попытку!";
        }

        public void RestartGame()
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
