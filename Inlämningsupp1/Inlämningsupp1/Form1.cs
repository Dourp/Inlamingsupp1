using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using Inlämningsupp1.Models;

namespace Inlämningsupp1
{
    public partial class Form1 : Form
    {
        List<People> listPerson = new List<People>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadchanges();
        }
        private void lstboxPersoner_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstboxPersoner.SelectedItem != null)
            {
                txtNamn.Text = listPerson[lstboxPersoner.SelectedIndex].Namn;
                txtGatuadr.Text = listPerson[lstboxPersoner.SelectedIndex].Gatuadress;
                txtPostnr.Text = listPerson[lstboxPersoner.SelectedIndex].Postnummer;
                txtPostort.Text = listPerson[lstboxPersoner.SelectedIndex].Postort;
                txtTelenr.Text = listPerson[lstboxPersoner.SelectedIndex].Telefon;
                txtEpost.Text = listPerson[lstboxPersoner.SelectedIndex].Epost;
                dateTimePicker1.Value = listPerson[lstboxPersoner.SelectedIndex].Födelsedag;
            }
        }

        private void btNyKontakt_Click(object sender, EventArgs e)
        {
            var newPerson = new People();

            newPerson.Namn = txtNamn.Text;
            newPerson.Gatuadress = txtGatuadr.Text;
            newPerson.Postnummer = txtPostnr.Text;
            newPerson.Postort = txtPostort.Text;
            newPerson.Telefon = txtTelenr.Text;
            newPerson.Epost = txtEpost.Text;
            newPerson.Födelsedag = dateTimePicker1.Value;

            using (var dbCtx = new PeopleContext())
            {
                dbCtx.people.Add(newPerson);

                dbCtx.SaveChanges();
            }
            loadchanges();
        }
        private void btSparaAndringar_Click(object sender, EventArgs e)
        {
            if (lstboxPersoner.SelectedItem != null)
            {
                People person = listPerson[lstboxPersoner.SelectedIndex];
                person.Namn = txtNamn.Text;
                person.Gatuadress = txtGatuadr.Text;
                person.Postnummer = txtPostnr.Text;
                person.Postort = txtPostort.Text;
                person.Telefon = txtTelenr.Text;
                person.Epost = txtEpost.Text;
                person.Födelsedag = dateTimePicker1.Value;

                using (var dbCtx1 = new PeopleContext())
                {
                    dbCtx1.Entry(person).State = System.Data.Entity.EntityState.Modified;

                    dbCtx1.SaveChanges();
                }
                loadchanges();
            }
        }
        private void btTaBortKontakt_Click(object sender, EventArgs e)
        {
            People personToDelete = listPerson[lstboxPersoner.SelectedIndex];

            using (var newContext = new PeopleContext())
            {

                newContext.Entry(personToDelete).State = System.Data.Entity.EntityState.Deleted;

                newContext.SaveChanges();
            }
            loadchanges();
        }
        private void txtAvbryt_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtSök_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSök.Text))
            {
                using (var ctx = new PeopleContext())
                {
                    listPerson = ctx.people.Where(c => c.Namn.ToLower().Contains(txtSök.Text.ToLower())).ToList();

                    lstboxPersoner.Items.Clear();
                    foreach (var item in listPerson)
                    {
                        lstboxPersoner.Items.Add(item.Namn);
                    }
                }
            }
            else
            {
                loadchanges();
            }
        }
        void loadchanges()
        {
            listPerson.Clear();
            lstboxPersoner.Items.Clear();
            txtNamn.Clear();
            txtGatuadr.Clear();
            txtPostnr.Clear();
            txtPostort.Clear();
            txtTelenr.Clear();
            txtEpost.Clear();
            txtSök.Clear();
            dateTimePicker1.Value = DateTime.Today;

            using (var context = new PeopleContext())
            {
                var Person = context.people.Select(s => s);

                foreach (var item in Person)
                {
                    listPerson.Add(item);
                    lstboxPersoner.Items.Add(item.Namn);
                }
            }
        }
    }
}
