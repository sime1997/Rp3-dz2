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
    public partial class Form1 : Form
    {
        public Form1()
        {
           InitializeComponent();

            SuspendLayout();
            var vremenski_raspon = new vremenski_raspon()
            {
                raspon = Tuple.Create(DateTime.Today, DateTime.Today)
            };
            vremenski_raspon.Margin = new Padding(5, 5, 5, 5);
            this.Controls.Add(vremenski_raspon);

            var graf = new graf()
            {
                raspon = Tuple.Create(DateTime.Today, DateTime.Today)
            };
            graf.Width = 700;
            graf.Height = 550;
            this.Controls.Add(graf);
            vremenski_raspon.promjena +=(sender,e)=>
            {
                graf.raspon=vremenski_raspon.raspon;
                graf.drawGraph();

            };

            graf.dvoklik +=(sender,e)=>
            {
                graf.raspon = Tuple.Create(new DateTime(graf.raspon.Item1.Year,1,1),new DateTime(graf.raspon.Item2.Year,1,1));
                vremenski_raspon.raspon = Tuple.Create(new DateTime(graf.raspon.Item1.Year, 1, 1), new DateTime(graf.raspon.Item2.Year, 1, 1));
                graf.drawGraph();

            };
            ResumeLayout();
        }

        private void vremenski_raspon1_Load(object sender, EventArgs e)
        {

        }

        private void vremenski_raspon1_Load_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)///ovdje dodajem kontrole
        {
          
        }

        private void vremenski_raspon1_promjena(object sender, string e)
        {
            MessageBox.Show("da");
        }

        private void graf1_Load(object sender, EventArgs e)
        {

        }

        private void vremenski_raspon1_Load_2(object sender, EventArgs e)
        {

        }
    }
}
