using System.Drawing;
using System.Windows.Forms;

namespace ShootingHelicopter
{
    internal class GameView
    {
        public GameModel Model {  get; set; }
        public Label Score { get; set; }
        public Form1 Form { get; set; }

        public GameView(Form1 form1, Label score, GameModel model)
        {
            Score = score;
            Form = form1;
            Model = model;
        }

        public void MakeBullet()
        {
            PictureBox bullet = new PictureBox
            {
                BackColor = Color.DarkOrange,
                Height = 5,
                Width = 10,

                Left = Form.player.Left + Form.player.Width,
                Top = Form.player.Top + Form.player.Height / 2,

                Tag = "bullet"
            };

            Form.Controls.Add(bullet);
            Model.Bullets.Add(bullet);
        }

        public void RemoveBullet(PictureBox bullet)
        {
            Form.Controls.Remove(bullet);
            bullet.Dispose();
        }

        public void ChangeUFO()
        {
            var index = 0;
            index += 1;
            if (index > 3)
            {
                index = 1;
            }

            switch (index)
            {
                case 1:
                    Form.ufo.Image = Properties.Resources.alien1;
                    break;
                case 2:
                    Form.ufo.Image = Properties.Resources.alien2;
                    break;
                case 3:
                    Form.ufo.Image = Properties.Resources.alien3;
                    break;
            }

            Form.ufo.Left = 1000;
            Form.ufo.Top = Model.Random.Next(20, Form.ClientSize.Height - Form.ufo.Height);
        }
    }
}
