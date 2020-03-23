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


    public partial class Form1 : Form
    {
        Image[] bgImages = new Image[4] { Properties.Resources.intro1, Properties.Resources.intro2, Properties.Resources.intro3, Properties.Resources.intro4 };
        Image bgImage;
        int currBgImg = 0;
        Informasjon info = new Informasjon("Informasjon", "Besøksadresse: Lade allé 60, 7041 Trondheim 73 87 02 80 post@ringve.no \n" +
            "Postadresse: Postboks 6289 Torgarden, 7489 Trondheim");
        Informasjon billetter = new Informasjon("Billetter", "Voksen: 120 kr \n + " +
            "Student / honnør: 100 kr + \n + " +
            "Barn(0 - 15 år): Gratis");
        Informasjon åpningstider = new Informasjon("Åpningstider", "Tirsdag – søndag 11.00-16.00");

        public Form1()
        {
            InitializeComponent();
            bgImage = bgImages[0];
            setBackgroundImage(bgImage);
            pictureBoxInfo.Tag = info;
            pictureBoxPriser.Tag = billetter;
            pictureBoxÅpningstider.Tag = åpningstider;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("TICK: | Current image: " + currBgImg  );
            currBgImg++;
            currBgImg %= 4;
            bgImage = bgImages[currBgImg];
            setBackgroundImage(bgImage);
        }
        private void setBackgroundImage (Image image)
        {
            this.BackgroundImage = image;
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

        private void pictureBox_MouseHover(object sender, EventArgs e)
        {
            groupBoxInfo.Visible = true;
            PictureBox pb = (PictureBox)sender;
            Informasjon info = (Informasjon)pb.Tag;
            labelInfoHeader.Text = info.Header;
            labelInfoText.Text = info.Content;
        }

        private void pictureBoxInfo_MouseLeave(object sender, EventArgs e)
        {
            groupBoxInfo.Visible = false;
        }

        private void buttonBestillBillett_Click(object sender, EventArgs e)
        {
            FormBestillBillett formBestillBillett = new FormBestillBillett();
            formBestillBillett.Show();
        }

        private void buttonKunnskapstest_Click(object sender, EventArgs e)
        {
            FormKunnskapstest formKunnskapstest = new FormKunnskapstest();
            formKunnskapstest.Show();
        }
    }
}
