using System.Windows.Forms;

namespace ShootingHelicopter
{
    internal partial class Form1 : Form
    {
        private readonly GameController _controller;

        public Form1(GameController controller)
        {
            InitializeComponent();
            
            _controller = controller;
            _controller.Form = this;
        }
    }
}
