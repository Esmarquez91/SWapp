using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System;

namespace SWapp.Clases
{
    class DiseñoForm
    {
        public static void RedondearForm(Form frm, int CornerRadius=20)
        {

            Rectangle Bounds = new Rectangle(0, 0, frm.Width, frm.Height);
            //int CornerRadius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            frm.Region = new Region(path);
            frm.Show();
        }


        public static void BotonRedondo(Button e)
        {
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(new Rectangle(2, 2, e.Width - 5, e.Height - 5));
                e.Region = new Region(path);
            }
            
        }
        public static void RedondearBoton(Button b, int CornerRadius = 20)
        {

            Rectangle Bounds = new Rectangle(0, 0, b.Width, b.Height);
            //int CornerRadius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            b.Region = new Region(path);
            //b.Show();
        }
        public static void RedondearPanel(Panel p, int CornerRadius = 20)
        {

            Rectangle Bounds = new Rectangle(0, 0, p.Width, p.Height);
            //int CornerRadius = 20;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
            path.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
            path.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
            path.CloseAllFigures();

            p.Region = new Region(path);
            //b.Show();
        }

    }

    
}
