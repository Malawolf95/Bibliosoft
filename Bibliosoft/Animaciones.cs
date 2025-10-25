using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibliosoft
{
    public static class Animaciones
    {
        // 🔹 Efecto SlideIn (entra desde un borde hacia su posición final)
        public static void SlideIn(Form form, string direction = "left", int speed = 25)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int finalX = form.Location.X;
            int finalY = form.Location.Y;

            switch (direction.ToLower())
            {
                case "left":
                    form.Left = -form.Width;
                    break;
                case "right":
                    form.Left = screen.Width;
                    break;
                case "top":
                    form.Top = -form.Height;
                    break;
                case "bottom":
                    form.Top = screen.Height;
                    break;
            }

            form.Show();
            form.Refresh();

            while (form.Left != finalX || form.Top != finalY)
            {
                switch (direction.ToLower())
                {
                    case "left":
                        form.Left = Math.Min(form.Left + speed, finalX);
                        break;
                    case "right":
                        form.Left = Math.Max(form.Left - speed, finalX);
                        break;
                    case "top":
                        form.Top = Math.Min(form.Top + speed, finalY);
                        break;
                    case "bottom":
                        form.Top = Math.Max(form.Top - speed, finalY);
                        break;
                }

                Thread.Sleep(5);
                Application.DoEvents();
            }
        }

        // 🔹 Efecto SlideOut (sale hacia un borde de la pantalla)
        public static void SlideOut(Form form, string direction = "right", int speed = 25)
        {
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;

            while (form.Left < screen.Width && form.Left > -form.Width &&
                   form.Top < screen.Height && form.Top > -form.Height)
            {
                switch (direction.ToLower())
                {
                    case "left":
                        form.Left -= speed;
                        break;
                    case "right":
                        form.Left += speed;
                        break;
                    case "top":
                        form.Top -= speed;
                        break;
                    case "bottom":
                        form.Top += speed;
                        break;
                }

                Thread.Sleep(5);
                Application.DoEvents();
            }

            form.Hide();
        }
    }
}
