using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depazite.Forms
{
    public partial class AddCredite : Form
    {
        public AddCredite()
        {
            InitializeComponent();
        }

        private void Btn_saveCredite_Click(object sender, EventArgs e)
        {
            using(DepoziteDbEntities1 db=new DepoziteDbEntities1())
            {
                Person f_person = db.People.ToList().LastOrDefault();
                db.Credities.Add(new Credity()
                {
                    DateOfCredit = Dt_DateCredite.Value,
                    Price = Convert.ToDecimal(Txb_price.Text),
                     Person=f_person,
                      Person_Id=f_person.Id
                });
                db.SaveChanges();
            }
        }

        private void AddCredite_Load(object sender, EventArgs e)
        {
            using (DepoziteDbEntities1 db = new DepoziteDbEntities1())
            {
                Person per = db.People.ToList().LastOrDefault();
                Lb_userName.Text = per.Name;
            }
        }

        private void Btn_allPeople_Click(object sender, EventArgs e)
        {
            AllPeople allPeople = new AllPeople();
            allPeople.ShowDialog();
        }
    }
}
