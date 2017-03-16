using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XpDragodinde
{
    public partial class MainForm : Form
    {
        List<int> lvlXp;

        public MainForm()
        {
            InitializeComponent();

            lvlXp = BuildXp();

            numChallenge.TextChanged += Calcul;
            numCharLvl.TextChanged += Calcul;
            numDesiredLvl.TextChanged += Calcul;
            numXpSolo.TextChanged += Calcul;

            Calcul(null, null);
        }

        private void btnResetChallenge_Click(object sender, EventArgs e)
        {
            numChallenge.Value = 0;
        }

        private void Calcul(object sender, EventArgs e)
        {
            int lvlChar = (int)numCharLvl.Value;
            int desiredLvl = (int)numDesiredLvl.Value;
            int desiredXp = lvlXp[desiredLvl-1];
            double challengeRate = (int)numChallenge.Value / 100.0 + 1;
            int experience = (int)numXpSolo.Value;

            int diffLvl = lvlChar - 1;
            double lvlRate = 0;

            if (diffLvl >= 70)
                lvlRate = 0.01;
            else if (diffLvl >= 60)
                lvlRate = 0.015;
            else if (diffLvl >= 50)
                lvlRate = 0.02;
            else if (diffLvl >= 40)
                lvlRate = 0.03;
            else if (diffLvl >= 30)
                lvlRate = 0.04;
            else if (diffLvl >= 20)
                lvlRate = 0.06;
            else if (diffLvl >= 10)
                lvlRate = 0.08;
            else
                lvlRate = 0.1;
            
            int percentGiveWithChallenge = (int)Math.Ceiling(100 / (experience * lvlRate * challengeRate / desiredXp) - 20);
            int percentGive = (int)Math.Ceiling(100 / (experience * lvlRate / desiredXp) - 20);

            bool useChallenge;

            if (challengeRate > 1)
            {
                if (percentGiveWithChallenge < 0)
                    useChallenge = false;
                else
                    useChallenge = true;
            }
            else
            {
                useChallenge = false;
            }

            percentGive = useChallenge ? percentGiveWithChallenge : percentGive;

            bool useCaptureSpell;

            if (percentGive > 25)
            {
                useCaptureSpell = true;
                percentGive -= 25;
                
                if (percentGive > 90)
                    percentGive = 90;
            }
            else
            {
                useCaptureSpell = false;

                if (percentGive < 0)
                    percentGive = 0;
            }

            if (useChallenge)
                lblUseChallenge.Text = "Oui";
            else
                lblUseChallenge.Text = "Non";

            if (useCaptureSpell)
                lblUseSpell.Text = "Oui";
            else
                lblUseSpell.Text = "Non";

            lblXpPercent.Text = percentGive.ToString() + " %";

            int xpGain = (int)(experience * lvlRate * (useChallenge ? challengeRate : 1) * (percentGive + 20 + (useCaptureSpell ? 25 : 0)) / 100);
            int lvlReached = lvlXp.FindIndex(x => x > xpGain);

            lblReachedLvl.Text = lvlReached.ToString();
            lblReachedLvl.ForeColor = lvlReached != desiredLvl ? Color.IndianRed : Color.LightGreen;

            if (numXpSolo.Focused)
                numXpSolo.Select(numXpSolo.Text.Length, 0);
        }

        private List<int> BuildXp()
        {

            List<int> xp = new List<int>();
            xp.Add(0);
            xp.Add(600);
            xp.Add(1750);
            xp.Add(2750);
            xp.Add(4000);
            xp.Add(5500);
            xp.Add(7250);
            xp.Add(9250);
            xp.Add(11500);
            xp.Add(14000);
            xp.Add(16750);
            xp.Add(19750);
            xp.Add(23000);
            xp.Add(26500);
            xp.Add(30250);
            xp.Add(34250);
            xp.Add(38500);
            xp.Add(43000);
            xp.Add(47750);
            xp.Add(52750);
            xp.Add(58000);
            xp.Add(63500);
            xp.Add(69250);
            xp.Add(75250);
            xp.Add(81500);
            xp.Add(88000);
            xp.Add(94750);
            xp.Add(101750);
            xp.Add(109000);
            xp.Add(116500);
            xp.Add(124250);
            xp.Add(132250);
            xp.Add(140500);
            xp.Add(149000);
            xp.Add(157750);
            xp.Add(166750);
            xp.Add(176000);
            xp.Add(185500);
            xp.Add(195250);
            xp.Add(205250);
            xp.Add(215500);
            xp.Add(226000);
            xp.Add(236750);
            xp.Add(247750);
            xp.Add(259000);
            xp.Add(270500);
            xp.Add(282250);
            xp.Add(294250);
            xp.Add(306500);
            xp.Add(319000);
            xp.Add(331750);
            xp.Add(344750);
            xp.Add(358000);
            xp.Add(371500);
            xp.Add(385250);
            xp.Add(399250);
            xp.Add(413500);
            xp.Add(428000);
            xp.Add(442750);
            xp.Add(457750);
            xp.Add(473000);
            xp.Add(488500);
            xp.Add(504250);
            xp.Add(520250);
            xp.Add(536500);
            xp.Add(553000);
            xp.Add(569750);
            xp.Add(586750);
            xp.Add(604000);
            xp.Add(621500);
            xp.Add(639250);
            xp.Add(657250);
            xp.Add(675500);
            xp.Add(694000);
            xp.Add(712750);
            xp.Add(731750);
            xp.Add(751000);
            xp.Add(770500);
            xp.Add(790250);
            xp.Add(810250);
            xp.Add(830500);
            xp.Add(851000);
            xp.Add(871750);
            xp.Add(892750);
            xp.Add(914000);
            xp.Add(935500);
            xp.Add(957250);
            xp.Add(979250);
            xp.Add(1001500);
            xp.Add(1024000);
            xp.Add(1046750);
            xp.Add(1069750);
            xp.Add(1093000);
            xp.Add(1116500);
            xp.Add(1140250);
            xp.Add(1164250);
            xp.Add(1188500);
            xp.Add(1213000);
            xp.Add(1237750);
            xp.Add(1262750);

            return xp;
        }
    }
}
