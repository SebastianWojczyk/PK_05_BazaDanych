using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PK_05_BazaDanych
{
    public partial class Form1 : Form
    {
        DatabaseDataContext db_dc;
        public Form1()
        {
            InitializeComponent();
            db_dc = new DatabaseDataContext();
            RefreshList();
        }

        private void RefreshList()
        {
            listBoxPersons.Items.Clear();
            foreach (Person p in db_dc.Persons.OrderBy(x => x.Name))
            {
                listBoxPersons.Items.Add(p);
            }
            listBoxPersons_SelectedIndexChanged(null, null);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxPersons.SelectedItem != null)
            {
                if (listBoxPersons.SelectedItem is Person)
                {
                    Person p = listBoxPersons.SelectedItem as Person;
                    db_dc.Persons.DeleteOnSubmit(p);
                    db_dc.SubmitChanges();
                    //listBoxPersons.Items.Remove(p);
                    RefreshList();


                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormPerson fp = new FormPerson();
            if (fp.ShowDialog() == DialogResult.OK)
            {
                db_dc.Persons.InsertOnSubmit(fp.Person);
                db_dc.SubmitChanges();
                RefreshList();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listBoxPersons.SelectedItem != null)
            {
                if (listBoxPersons.SelectedItem is Person)
                {
                    Person p = listBoxPersons.SelectedItem as Person;
                    FormPerson fp = new FormPerson(p);
                    if (fp.ShowDialog() == DialogResult.OK)
                    {
                        db_dc.SubmitChanges();
                        RefreshList();
                    }
                }
            }
        }

        private void listBoxPersons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPersons.SelectedItem != null &&
                listBoxPersons.SelectedItem is Person)
            {
                buttonEdit.Enabled = true;
                buttonDelete.Enabled = true;
            }
            else
            {
                buttonEdit.Enabled = false;
                buttonDelete.Enabled = false;
            }
        }
    }

    /*
    CREATE TABLE [dbo].[Person]
    (
        [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
        [Name] NVARCHAR(50) NOT NULL, 
        [BirthDate] DATE NOT NULL, 
        [Height] INT NOT NULL
    )
    */
    /*
                List<int> l = new List<int>();
                l.Add(1);
                l.Add(2);
                l.Add(3);
                l.Add(4);
                l.Add(5);
                l.Add(6);
                List<int> l2 = l.Where(x => x % 2 == 0)
                                .OrderByDescending(x => x)
                                .ToList();
                l2 = (from i in l
                      where i % 2 == 0
                      orderby (i)
                      select i).ToList();
                int c;
                c = l2.Count;//właściwość listy
                c = l2.Count();//metoda LINQ
                */
}
