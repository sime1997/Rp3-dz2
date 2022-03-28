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
    public partial class vremenski_raspon : UserControl
    {
      

        public vremenski_raspon()
        {
            InitializeComponent();
        }

        private void vremenski_raspon_Load(object sender, EventArgs e)
        {

        }
        public event EventHandler<string> promjena;
        public Tuple<DateTime, DateTime> _raspon;
        public Tuple<DateTime,DateTime> raspon
        {
            get 
            {
                _raspon=Tuple.Create(datum1.vrijednost,datum2.vrijednost);
                return _raspon;
            }
            set { _raspon = value; }
        }

        private void datum1_Load(object sender, EventArgs e)
        {
            
        }
        private void datum2_Load(object sender, EventArgs e)
        {
            
        }

        

        private void datum1_promjena(object sender, DateTime e)//prvi datum promijenjen
        {
            if (raspon.Item1 <= raspon.Item2)
            {
                if (promjena != null)
                {
                    promjena(this,"");
                }
            }

        }

        private void datum2_promjena(object sender, DateTime e)//drugi datum promijenjen
        {
           if(raspon.Item1<=raspon.Item2)
            { 
               if(promjena!=null)
                {
                    promjena(this,"");
                }
            }
        }
    }
}
