using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eksamensoppgaver
{   
    public partial class FormKunnskapstest : Form
    {
        int numRiktig = 0;
        int numForsøk = 0;
        int highscore = -1;
        const int numInstrumenter = 5;
        List<Instrument> instrumentList;
        Instrument currentInstrument;
        Random rng = new Random(0);
        Instrument obo = new Instrument("Obo",Properties.Resources.obo1,"obo.mp3");
        Instrument fagott = new Instrument("Fagott", Properties.Resources.fagott, "fagott.mp3");
        Instrument klarinett = new Instrument("Fagott", Properties.Resources.klarinett1, "klarinett.mp3");
        Instrument valthorn = new Instrument("Fagott", Properties.Resources.valthorn1, "valthorn.mp3");
        Instrument fløyte = new Instrument("Fløyte", Properties.Resources.floyte, "floyte.mp3");


        private int loadHighscore()
        {
            if (!File.Exists("highscore.txt"))
            {
                var highscore = File.Create("highscore.txt");
                highscore.Close();
                File.WriteAllText("highscore.txt", "100");
                return 100;
            }
            else
            {
                using (TextReader reader = File.OpenText("highscore.txt")){
                    return int.Parse(reader.ReadLine());
                }
            }
        }
        private void saveHighscore(int highscore)
        {
            if (!File.Exists("highscore.txt"))
            {
                var highscoreFile = File.Create("highscore.txt");
                highscoreFile.Close();
            }
            File.WriteAllText("highscore.txt", highscore.ToString());
        }

        public FormKunnskapstest()
        {
            InitializeComponent();
            highscore = loadHighscore();
            labelHighscore.Text = "Highscore: " + highscore + " feil";
            //pictureBoxFagott.Tag = fagott;
            pictureBoxFløyte.Tag = fløyte;
            pictureBoxKlarinett.Tag = klarinett;
            pictureBoxValthorn.Tag = valthorn;
            pictureBoxObo.Tag = obo;
            pictureBoxFagott.Tag = fagott;
        }

        private void buttonNesteLyd_Click(object sender, EventArgs e)
        {
            if (instrumentList.Count > 0)
            {
                List<Instrument> instrumentListCopy = new List<Instrument>(instrumentList);
                instrumentListCopy.Remove(currentInstrument);
                currentInstrument = instrumentListCopy[rng.Next() % instrumentListCopy.Count];
                axWindowsMediaPlayer1.URL = currentInstrument.URL;
            }
        }

        private void pictureBox_click(object sender, EventArgs e)
        {
            numForsøk++;
            PictureBox clickedImage =  (PictureBox)sender;
            if(clickedImage.Tag == currentInstrument)
            {
                numRiktig++;
                clickedImage.Visible = false;
                instrumentList.Remove(currentInstrument);
                buttonNesteLyd_Click(null,null);
                //For å forhindre avspilling med en gang
                axWindowsMediaPlayer1.Ctlcontrols.stop();
                labelAntallRiktige.Text = "(" + numRiktig + "/5) riktige";
                if(numRiktig == numInstrumenter)
                {
                    avsluttSpill();
                }
                axWindowsMediaPlayer2.URL = "riktig.mp3";
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            else
            {
                axWindowsMediaPlayer2.URL = "feil.mp3";
                axWindowsMediaPlayer2.Ctlcontrols.play();
            }
            labelAntallForsøk.Text = "Antall forsøk: " + numForsøk;
        }
        private void avsluttSpill()
        {
            buttonNesteLyd.Enabled = false;
            groupBox1.Visible = true;
            if(numForsøk == numInstrumenter)
            {
                labelGratulerer.Visible = true;
                labelGratulerer.Text = "WOHO!! Du gjetta alt riktig på fyrste forsøk";
            }
            labelResultat.Text = "Antall feil: " + (numForsøk - numInstrumenter);
            if (numForsøk-numInstrumenter < highscore)
            {
                highscore = numForsøk - numInstrumenter;
                saveHighscore(highscore);
                labelResultat.Text += " Ny highscore!";
            }else if (numForsøk - numInstrumenter == highscore)
            {
                labelResultat.Text += " Likt resultat som highscore!";
            }
            labelHighscore.Text = "Highscore: " + highscore + " feil";
        }

        private void buttonSpill_Click(object sender, EventArgs e)
        {
            numForsøk = 0;
            numRiktig = 0;
            highscore = loadHighscore();
            groupBox1.Visible = false;
            Instrument[] instrumenter = { obo, fagott, klarinett, valthorn, fløyte };
            instrumentList = new List<Instrument>();
            foreach (Instrument i in instrumenter)
            {
                instrumentList.Add(i);
            }
            foreach (Control c in this.Controls)
            {
                if (c is PictureBox || c is Label)
                    c.Visible = true;
            }
            buttonNesteLyd.Enabled = true;
            labelAntallForsøk.Text = "Antall forsøk: " + numForsøk;
            labelAntallRiktige.Text = "(" + numRiktig + "/5) riktige";
            currentInstrument = null;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            buttonNesteLyd_Click(null, null);
        }
    }
}
