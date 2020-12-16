using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace _3DModel
{
    public partial class Form1 : Form
    {
        Model model;
        public Form1()
        {
            InitializeComponent();
            Bitmap bitmap = new Bitmap(Screen.Width, Screen.Height);
            Screen.Image = bitmap;
            Screen.BackColor = Color.Black;
            model = new Model(Color.White, Screen);
            model.CreateModel(null);
        }
        #region Buttons
        private void TurnUp_Click(object sender, EventArgs e)
        {
            model.Turn("up");
        }

        private void TurnDown_Click(object sender, EventArgs e)
        {
            model.Turn("down");
        }

        private void TurnLeft_Click(object sender, EventArgs e)
        {
            model.Turn("left");
        }

        private void TurnRight_Click(object sender, EventArgs e)
        {
            model.Turn("right");
        }

        private void Enlarge_Click(object sender, EventArgs e)
        {
            model.Scaling("enlarge");
        }

        private void Decrease_Click(object sender, EventArgs e)
        {
            model.Scaling("decrease");
        }

        private void TransitionUp_Click(object sender, EventArgs e)
        {
            model.Transition("up");
        }

        private void TransitionRight_Click(object sender, EventArgs e)
        {
            model.Transition("right");
        }

        private void TransitionDown_Click(object sender, EventArgs e)
        {
            model.Transition("down");
        }

        private void TransitionLeft_Click(object sender, EventArgs e)
        {
            model.Transition("left");
        }
        #endregion
    }
}
