namespace ISTA_Exercice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbFiliere.Items.AddRange(new String[] { "TSDI ", "TSRI", "TSB" });
            cbFiliere.SelectedIndex = 0;
        }



        private void cbFiliere_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            if (tbName.Text.Trim() != "" && tbPrenom.Text.Trim() != "" && tbAge.Text.Trim() != "" && cbFiliere.Text!="")
            {
                ListViewItem L = new ListViewItem(tbName.Text);
                L.SubItems.Add(tbPrenom.Text);
                L.SubItems.Add(tbAge.Text);
                L.SubItems.Add(cbFiliere.Text);
                tbName.Focus();
                Lv.Items.Add(L);
                Clear();
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Lv.SelectedItems.Count; i++)
            {
                Lv.Items.Remove(Lv.SelectedItems[i]);
            }
        }

        int IndiceModifier = -1;
        private void btModifier_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < Lv.Items.Count; i++)
            {
                if (IndiceModifier == -1)
                {
                    if (Lv.Items[i].SubItems[0].Text.Trim().ToLower() == tbName.Text.Trim().ToLower())
                    {
                        tbPrenom.Text = Lv.Items[i].SubItems[1].Text;
                        tbAge.Text = Lv.Items[i].SubItems[2].Text;
                        cbFiliere.SelectedItem = Lv.Items[i].SubItems[3].Text;

                        btAjouter.Enabled = false;
                        btRechercher.Enabled = false;
                        btSupprimer.Enabled = false;
                        btModifier.Text = "Valider";
                        IndiceModifier = 1;
                    }





                }
                else
                {
                    if (Lv.Items[i].SubItems[0].Text == tbName.Text)
                    {

                        Lv.Items[i].SubItems[1].Text = tbPrenom.Text;
                        Lv.Items[i].SubItems[2].Text = tbAge.Text;
                        Lv.Items[i].SubItems[3].Text = cbFiliere.SelectedItem.ToString();
                        Clear();
                    }

                    btAjouter.Enabled = true;
                    btRechercher.Enabled = true;
                    btSupprimer.Enabled = true;
                    btModifier.Text = "Modifier";
                    IndiceModifier = -1;
                }


            }


        }

        private void btRechercher_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem i in Lv.Items)
            {
                i.BackColor = Color.White;
            }
            if (tbName.Text != " ")
            {
                foreach (ListViewItem i in Lv.Items)
                {
                    if (i.Text.Trim().ToLower() == tbName.Text.Trim().ToLower())
                    {
                        i.BackColor = Color.Red;
                    }
                }
            }
            
            Clear();
        }

        private void Clear()
        {
            tbName.Text = tbPrenom.Text = tbAge.Text = "";
        }
    }
}