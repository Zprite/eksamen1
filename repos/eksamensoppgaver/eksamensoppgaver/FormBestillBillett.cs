using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eksamensoppgaver
{
    public partial class FormBestillBillett : Form
    {
        const int prisBarn = 50;
        const int prisVoksen = 100;
        ListViewItem[] listViewItems;
        ListViewItem selectedItem = null;
        int numVoksne = 0;
        int numBarn = 0;
        public FormBestillBillett()
        {
            InitializeComponent();
            listViewItems = new ListViewItem[4];
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            String[] item1 = { "1.juni", "11:00", "Trondheim kammermusikkfe stival: Fabelaktig formiddag", "Dette er festivaldagen for barn og familiar.\n" +
                    "Éin billett gjeld for alt, og du kan velje mellom ei rekkje ulike framsyningar." };
            String[] item2 = { "4.juni", "14:30", "Spel opp!", "Mastereksamen NTNY fløyte v/Matthias Lauga" };
            String [] item3 = {"6.juni", "13:00", "Onsdagskonsert", "Barokke treblåsarensamble"};
            String[] item4 = { "9.juni", "14:00", "Juiogat: Joik for folk", "Ei vandring i samisk musikkhistorie ved Lena Jansen" };
            listViewItems = new ListViewItem[] { new ListViewItem(item1), new ListViewItem(item2), new ListViewItem(item3), new ListViewItem(item4) };
            foreach(ListViewItem l in listViewItems)
            {
                listView1.Items.Add(l);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                selectedItem = listView1.SelectedItems[0];
                labelValgtArrangement.Text = selectedItem.SubItems[2].Text;
            }
            catch (System.ArgumentOutOfRangeException)
            {
                // Ingen valgt
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numBarn = (int)numericUpDownBarn.Value;
            numVoksne = (int)numericUpDownVoksne.Value;
            if(selectedItem != null && numBarn+numVoksne > 0)
            {
                lagUtskrift();
            }
        }

        private void lagUtskrift()
        {
            groupBoxUtskrift.Visible = true;
            Boolean grupperabat = false;
            const double multiplier = 0.8;
            String info = "Du har bestilt " + (numBarn + numVoksne) +
                " billett(ar) til " + selectedItem.SubItems[2].Text + '\n';
            if (numVoksne > 0)
            {
                info += numVoksne;
                if (numVoksne == 1)
                    info += " vaksen";
                else
                {
                    info += " vaksne";
                }
            }
            if (numVoksne > 0 && numBarn > 0)
                info += " og ";
            if (numBarn > 0)
                info += numBarn + " barn";
            labelInfo.Text = info;

            // Setter grupperabbat
            if(numVoksne + numBarn >= 5)
            {
                grupperabat = true;
            }
            String pris = "";
            double totalpris = prisVoksen * numVoksne + prisBarn * numBarn;
            if (grupperabat)
            {
                pris = ", inklusiv grupperabatt på 20 prosent.";
                totalpris *= multiplier;
            }
         
            pris = pris.Insert(0, "Totalprisen er kr " + totalpris);
            labelPris.Text = pris;
        }
    }
}
