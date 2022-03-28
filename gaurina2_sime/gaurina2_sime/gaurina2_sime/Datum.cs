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
    public partial class Datum : UserControl
    {
        public event EventHandler<DateTime> promjena;
        public Datum()
        {
            InitializeComponent();
            SuspendLayout();

            dan.Text = DateTime.Today.Day.ToString();
            mjesec.Text = DateTime.Today.Month.ToString();
            godina.Text = DateTime.Today.Year.ToString();
            try
            {
                _vrijednost = new DateTime(int.Parse(godina.Text), int.Parse(mjesec.Text), int.Parse(dan.Text));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ResumeLayout();
        }


        public DateTime _vrijednost;

        public DateTime vrijednost
        {
            get { return _vrijednost; }
            set { _vrijednost = value; }
        }
        private void dan_TextChanged(object sender, EventArgs e)
        {
            CheckIt();
        }

        private void mjesec_TextChanged(object sender, EventArgs e)
        {
            CheckIt();
        }

        private void godina_TextChanged(object sender, EventArgs e)
        {
            CheckIt();
        }

       

        private void CheckIt()
        {
            string help = "";
            help += mjesec.Text;
            help += "/";
            help += dan.Text;
            help += "/";
            help += godina.Text;

            DateTime temp;
            if (DateTime.TryParse(help, out temp))
            {
                ColorIt(true);
            }
            else
            {
                ColorIt(false);
            }
        }

        public void ColorIt(bool tf)
        {
            if (!tf)
            {
                dan.BackColor = Color.Red;
                mjesec.BackColor = Color.Red;
                godina.BackColor = Color.Red;
            }
            else
            {
                dan.BackColor = Color.White;
                mjesec.BackColor = Color.White;
                godina.BackColor = Color.White;
               
                 _vrijednost = new DateTime(Int32.Parse(godina.Text), Int32.Parse(mjesec.Text), Int32.Parse(dan.Text));
                if (promjena != null)
                {
                    promjena(this, vrijednost);
                 }
               
            }
         }

        private void Datum_Load(object sender, EventArgs e)
        {

        }
    }
}
