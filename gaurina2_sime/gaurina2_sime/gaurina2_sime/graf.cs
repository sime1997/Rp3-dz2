using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gaurina2_sime
{
    public partial class graf : UserControl
    {
        public Tuple<DateTime, DateTime> _raspon;
        public event EventHandler<string> dvoklik;
        public Tuple<DateTime,DateTime> raspon
        {

            get {
                return _raspon;   
                }
            set {
                _raspon = value;          
                }
        }
        public graf()
        {
            InitializeComponent();
            
        }

        private void graf_Load(object sender, EventArgs e)
        {
            
           
        }


       
        public void drawGraph()
        {
           
            graf_Paint(this, null);
        }
        private void graf_DoubleClick(object sender, EventArgs e)
        {
            if (dvoklik != null)
                dvoklik(this, "");

        }

        private void graf_Paint(object sender, PaintEventArgs e)///probaj nacrtati graf
        {
            double brojDana = (raspon.Item2 - raspon.Item1).TotalDays;// broj krugova
            var g = CreateGraphics();
            g.Clear(Color.WhiteSmoke);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;///700,500

            if (brojDana < 50000)
            {
                for (int i = 0; i < brojDana; i++)
                {

                    g.DrawEllipse(Pens.DarkOrchid, (float)(10+i*(double)700/(double)brojDana), (float)(320+ 180 * (double)Math.Sin((double)((double)i/(double)10))), 2, 2);
                    g.DrawEllipse(Pens.Black, (float)(10 + i * (double)700 / (double)brojDana), (float)(320), 1, 1);
                }
              

            }
            g.DrawLine(Pens.Black, 10, 320, 700, 320);
        }
    }
}
