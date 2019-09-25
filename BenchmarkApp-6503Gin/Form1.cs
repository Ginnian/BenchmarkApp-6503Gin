using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BenchmarkApp_6503Gin
{
    public partial class Form1 : Form
    {
        List<Creature> creatures = new List<Creature>();

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            creatures.Clear();

            FileManager fm = new FileManager();

            creatures = fm.LoadCreatures();

            if (creatures == null)
            {
                MessageBox.Show("Error Loading Creatures", "File IO Error");
            }
            else
            {
                lbxCreatures.Items.Clear();
                lbxCreatures.Items.AddRange(creatures.ToArray());
            }
        }

        private void SortAZ_Click(object sender, EventArgs e)
        {
            Filter cFilter = new Filter();

            creatures = cFilter.SortAZ(creatures);

            lbxCreatures.Items.Clear();
            lbxCreatures.Items.AddRange(creatures.ToArray());
        }

        private void SortZA_Click(object sender, EventArgs e)
        {
            Filter cFilter = new Filter();

            creatures = cFilter.SortZA(creatures);

            lbxCreatures.Items.Clear();
            lbxCreatures.Items.AddRange(creatures.ToArray());
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            List<Creature> results = new List<Creature>();

            Filter cFilter = new Filter();

            string term = tbxSearch.Text;

            results = cFilter.Search(creatures, term);

            lbxSearchResults.Items.Clear();
            lbxSearchResults.Items.AddRange(results.ToArray());
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            try
            {
                FileManager fm = new FileManager();

                Creature c = (Creature)lbxSearchResults.SelectedItem;

                string fileName = c.CreatureName + c.Age + c.Owner + ".txt";

                bool result = fm.SaveCreature(c, fileName);

                if (result == false)
                {
                    MessageBox.Show("Error Saving Creature", "File IO Error");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("View File?", "Save Success", MessageBoxButtons.YesNo);

                    if (dr.Equals(DialogResult.Yes))
                    {
                        System.Diagnostics.Process.Start(fileName);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a creature", "Error");
            }
        }

        private void LbxSearchResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Creature c = (Creature)lbxSearchResults.SelectedItem;

                tbxName.Text = c.CreatureName;
                tbxAge.Text = c.Age.ToString();
                tbxOwner.Text = c.Owner;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
