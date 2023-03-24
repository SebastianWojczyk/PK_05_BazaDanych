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
    public partial class FormPerson : Form
    {
        private Person person;
        public Person Person
        {
            get => person;
        }
        public FormPerson()
        {
            InitializeComponent();
            Text = "Dodawanie osoby";
            person = new Person();
            ValidatePerson();
        }
        public FormPerson(Person person)
        {
            InitializeComponent();
            Text = "Edycja osoby";
            this.person = person;
            textBoxPersonName.Text = person.Name;
            dateTimePickerPersonBirthDate.Value = person.BirthDate;
            numericUpDownPersonHeight.Value = person.Height;
            ValidatePerson();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            person.Name = textBoxPersonName.Text;
            person.BirthDate = dateTimePickerPersonBirthDate.Value;
            person.Height = (int)numericUpDownPersonHeight.Value;

            DialogResult = DialogResult.OK;
        }

        private void textBoxPersonName_TextChanged(object sender, EventArgs e)
        {
            ValidatePerson();
        }

        private void dateTimePickerPersonBirthDate_ValueChanged(object sender, EventArgs e)
        {
            ValidatePerson();
        }

        private void numericUpDownPersonHeight_ValueChanged(object sender, EventArgs e)
        {
            ValidatePerson();
        }

        private void ValidatePerson()
        {
            if (textBoxPersonName.TextLength > 3 &&
               dateTimePickerPersonBirthDate.Value <= DateTime.Today)
            {
                buttonSave.Enabled = true;
            }
            else
            {
                buttonSave.Enabled = false;
            }
        }
    }
}
