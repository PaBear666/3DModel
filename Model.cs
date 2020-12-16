using System;
using System.Drawing;
using System.Windows.Forms;

namespace _3DModel
{
    public class Model
    {
        public PictureBox Picture { get; private set; }
        public Color Color { get; private set; }
        public int Size { get; set; }


        Point3D[,] worldCoor = new Point3D[32, 32];
        Point3D[,] axonCoor = new Point3D[32, 32];
        Point[,] screenCoor = new Point[32, 32];
        Pen pen;
        Graphics g;

        private double a = -Math.PI / 2;
        private double b = Math.PI / 2;
        private int ky = 0;
        private int kx = 0;

        public Model(Color color, PictureBox picture, int size = 90)
        {
            Color = color;
            Picture = picture;
            Size = size;
            pen = new Pen(color, 1);
            g = Graphics.FromImage(Picture.Image);
        }

        public void CreateModel(string options)
        {
            FillWorldCoor();
            FillAxCoor();
            FillScreenCoor();
            Draw();

        }

        #region Calc
        private Point3D CalcCoor(double alpha, double beta)
        {
            double x = Size * (1 + alpha - Math.Sin(alpha)) * Math.Cos(beta);
            double y = Size * (1 - Math.Cos(beta));
            double z = Size * (-(1 + alpha - Math.Sin(alpha)) * Math.Sin(beta));
            return new Point3D(x, y, z);
        }

        private Point3D CalcAxCoor(Point3D point3D, double alpha, double beta)
        {
            double x = point3D.x * Math.Cos(alpha) + point3D.y * Math.Sin(alpha);
            double y = -point3D.x * Math.Sin(alpha) * Math.Cos(beta) + point3D.y * Math.Cos(alpha) * Math.Cos(beta) + point3D.z * Math.Sin(beta);
            double z = point3D.x * Math.Sin(alpha) * Math.Sin(beta) - point3D.y * Math.Cos(alpha) * Math.Sin(beta) + point3D.z * Math.Cos(beta);
            return new Point3D(x, y, z);
        }

        private Point CalcScreenCoor(Point3D point3D)
        {
            int x = Picture.Width / 2;
            int y = Picture.Height / 2;

            int X = (int)(x + point3D.x + kx);
            int Y = (int)(y + point3D.y + ky);
            return new Point(X, Y);
        }
        #endregion
        #region FillCoor
        private void FillWorldCoor()
        {
            int i = 0;
            for (double alpha = -Math.PI / 2; alpha < Math.PI / 2; alpha += 0.1)
            {
                int j = 0;
                for (double beta = -Math.PI; beta < Math.PI; beta += 0.2)
                {
                    worldCoor[i, j] = CalcCoor(alpha, beta);
                    j++;
                }
                i++;
            }
        }
        private void FillAxCoor()
        {
            for (int i = 0; i <= 31; i++)
            {
                for (int j = 0; j <= 31; j++)
                {
                    axonCoor[i, j] = CalcAxCoor(worldCoor[i, j], a, b);
                }
            }
        }
        private void FillScreenCoor()
        {
            for (int i = 0; i <= 31; i++)
            {

                for (int j = 0; j <= 31; j++)
                {
                    screenCoor[i, j] = CalcScreenCoor(axonCoor[i, j]);
                }
            }
        }
        #endregion
        #region Transformations
        public void Turn(string button)
        {
            switch (button)
            {
                case "up":
                    b += 0.1;
                    break;
                case "down":
                    b -= 0.1;
                    break;
                case "left":
                    a -= 0.1;
                    break;
                case "right":
                    a += 0.1;
                    break;
            }
            Picture.Refresh();
            g.Clear(Color.Black);
            FillAxCoor();
            FillScreenCoor();
            Draw();
        }
        public void Scaling(string button)
        {
            switch (button)
            {
                case "enlarge":
                    Size += 2;
                    break;
                case "decrease":
                    Size -= 2;
                    break;
            }
            Picture.Refresh();
            g.Clear(Color.Black);
            FillWorldCoor();
            FillAxCoor();
            FillScreenCoor();
            Draw();
        }
        public void Transition(string button)
        {
            switch (button)
            {
                case "up":
                    ky -= 2;
                    break;
                case "down":
                    ky += 2;
                    break;
                case "left":
                    kx -= 2;
                    break;
                case "right":
                    kx += 2;
                    break;

            }
            Picture.Refresh();
            g.Clear(Color.Black);
            FillScreenCoor();
            Draw();
        }
        #endregion
        private void Draw()
        {
            for (int i = 0; i < 31; i++)
            {
                for (int j = 0; j < 32; j++)
                {
                    if (j != 31)
                    {
                        Point p1 = new Point(screenCoor[i, j].X, screenCoor[i, j].Y);
                        Point p2 = new Point(screenCoor[i, j + 1].X, screenCoor[i, j + 1].Y);
                        g.DrawLine(pen, p1, p2);
                    }
                    else
                    {
                        Point p1 = new Point(screenCoor[i, 31].X, screenCoor[i, 31].Y);
                        Point p2 = new Point(screenCoor[i, 0].X, screenCoor[i, 0].Y);
                        g.DrawLine(pen, p1, p2);
                    }
                }
            }
        }
    }
}
