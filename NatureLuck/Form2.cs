using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatureLuck
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        int EVleft = 510;

        int HPEV = 0;
        int AtkEV = 0;
        int DefEV = 0;
        int SpAtkEV = 0;
        int SpDefEV = 0;
        int SpdEV = 0;

        private void modifStat(ref int stat, int valeur)
        {
            if ((stat + valeur <= 255) && (EVleft - valeur >= 0) && (stat + valeur >= 0))
            {
                stat += valeur;
                EVleft -= valeur;
                updateValues();
            }
        }

        private void updateValues()
        {
            HPCount.Text = "" + HPEV;
            AtkCount.Text = "" + AtkEV;
            DefCount.Text = "" + DefEV;
            SpAtkCount.Text = "" + SpAtkEV;
            SpDefCount.Text = "" + SpDefEV;
            SpdCount.Text = "" + SpdEV;
            EVLeftCount.Text = "Effort Values left : " + EVleft;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, -1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, +1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, -2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, +2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, -3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, +3);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, -4);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, +4);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, -6);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, +6);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, -8);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, +8);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, -10);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, +10);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, -12);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            modifStat(ref HPEV, +12);
        }

        private void button57_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, -1);
        }

        private void button56_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, +1);
        }

        private void button58_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, -2);
        }

        private void button55_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, +2);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, -3);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, +3);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, -4);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, +4);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, -6);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, +6);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, -8);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, +8);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, -10);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, +10);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, -12);
        }

        private void button49_Click(object sender, EventArgs e)
        {
            modifStat(ref AtkEV, +12);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, -1);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, +1);
        }

        private void button74_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, -2);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, +2);
        }

        private void button75_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, -3);
        }

        private void button70_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, +3);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, -4);
        }

        private void button69_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, +4);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, -6);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, +6);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, -8);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, +8);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, -10);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, +10);
        }

        private void button80_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, -12);
        }

        private void button65_Click(object sender, EventArgs e)
        {
            modifStat(ref DefEV, +12);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, -1);
        }

        private void button40_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, +1);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, -2);
        }

        private void button39_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, +2);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, -3);
        }

        private void button38_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, +3);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, -4);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, +4);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, -6);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, +6);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, -8);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, +8);
        }

        private void button47_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, -10);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, +10);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, -12);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            modifStat(ref SpAtkEV, +12);
        }

        private void button89_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, -1);
        }

        private void button88_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, +1);
        }

        private void button90_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, -2);
        }

        private void button87_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, +2);
        }

        private void button91_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, -3);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, +3);
        }

        private void button92_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, -4);
        }

        private void button85_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, +4);
        }

        private void button93_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, -6);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, +6);
        }

        private void button94_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, -8);
        }

        private void button83_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, +8);
        }

        private void button95_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, -10);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, +10);
        }

        private void button96_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, -12);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            modifStat(ref SpDefEV, +12);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, -1);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, +1);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, -2);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, +2);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, -3);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, +3);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, -4);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, +4);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, -6);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, +6);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, -8);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, +8);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, -10);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, +10);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, -12);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            modifStat(ref SpdEV, +12);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var targetURL = "https://bulbapedia.bulbagarden.net/wiki/List_of_Pok%C3%A9mon_by_effort_value_yield";
            var psi = new ProcessStartInfo
            {
                FileName = targetURL,
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
