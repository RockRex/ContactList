using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ContactList
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mItemCreateNewContactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewContactForm addNewContact = new AddNewContactForm();
            addNewContact.Show();
        }

        private void mItemViewAllContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllContacts viewContact = new AllContacts();
            viewContact.Show();
        }

        private void mItemSearchItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FindingContacts findContact = new FindingContacts();
            findContact.Show();
        }

        private void mItemHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
        }

        private void mItemExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
