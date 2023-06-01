using System.Drawing;
using System.Windows.Forms;

namespace ShootingHelicopter
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.ufo = new System.Windows.Forms.PictureBox();
            this.txtScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).BeginInit();
            this.SuspendLayout();
            //
            // pillar1
            //
            this.pillar1.Name = "pillar1";
            this.pillar1.TabIndex = 0;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            this.pillar1.Image = Properties.Resources.pillar;
            this.pillar1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pillar1.Size = new System.Drawing.Size(136, 400);
            this.pillar1.Location = new Point(530, -300);
            //
            // pillar2
            //
            this.pillar2.Name = "pillar2";
            this.pillar2.TabIndex = 1;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            this.pillar2.Image = Properties.Resources.pillar;
            this.pillar2.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pillar2.Size = new System.Drawing.Size(136, 400);
            this.pillar2.Location = new Point(213, 200);
            //
            // player
            //
            this.player.Name = "player";
            this.player.TabIndex = 2;
            this.player.TabStop = false;
            this.player.Image = Properties.Resources.Halicopter;
            this.player.SizeMode = PictureBoxSizeMode.StretchImage;
            this.player.Size = new System.Drawing.Size(64, 64);
            this.player.Location = new System.Drawing.Point(20, 119);
            //
            // ufo
            //
            this.ufo.Name = "ufo";
            this.ufo.TabIndex = 3;
            this.ufo.TabStop = false;
            this.ufo.Image = Properties.Resources.alien1;
            this.ufo.SizeMode = PictureBoxSizeMode.StretchImage;
            this.ufo.Size = new System.Drawing.Size(64, 64);
            var m = new GameModel();
            this.ufo.Location = new Point(1000, m.Random.Next(20, this.ClientSize.Height - ufo.Height));
            //
            // txtScore
            //
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtScore.Location = new System.Drawing.Point(12, 23);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(80, 27);
            this.txtScore.TabIndex = 4;
            this.txtScore.Text = "Очки: 0";
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(923, 470);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.player);
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Name = "Form1";
            this.Text = "ShootingHelicopter";
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ufo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        public System.Windows.Forms.PictureBox pillar1;
        public System.Windows.Forms.PictureBox pillar2;
        public System.Windows.Forms.PictureBox player;
        public System.Windows.Forms.PictureBox ufo;
        public System.Windows.Forms.Label txtScore;
    }
}

