using Depazite.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depazite
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Btn_savePerson_Click(object sender, EventArgs e)
        {
            using(DepoziteDbEntities1 db=new DepoziteDbEntities1())
            {
                db.People.Add(new Person()
                {
                     Name=Txb_name.Text,
                     Surname=Txb_surname.Text
                });
                db.SaveChanges();
            }
            AddCredite addCredite = new AddCredite();
            addCredite.ShowDialog();
        }
    }
}
