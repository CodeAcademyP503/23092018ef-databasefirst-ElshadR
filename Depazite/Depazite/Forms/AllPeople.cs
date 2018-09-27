using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depazite.Forms
{
    public partial class AllPeople : Form
    {
        public AllPeople()
        {
            InitializeComponent();
        }

        private void AllPeople_Load(object sender, EventArgs e)
        {
            using(DepoziteDbEntities1 db = new DepoziteDbEntities1())
            {

                dataGridView1.DataSource = db.usp_AllPerson.ToList();
            }
        }
    }
}
