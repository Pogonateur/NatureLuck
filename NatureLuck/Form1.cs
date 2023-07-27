using System.Runtime.CompilerServices;

namespace NatureLuck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int assure = 0;
        private double assurePercent = 0;
        private int bizarre = 0;
        private double bizarrePercent = 0;
        private int brave = 0;
        private double bravePercent = 0;
        private int calme = 0;
        private double calmePercent = 0;
        private int discret = 0;
        private double discretPercent = 0;
        private int docile = 0;
        private double docilePercent = 0;
        private int doux = 0;
        private double douxPercent = 0;
        private int foufou = 0;
        private double foufouPercent = 0;
        private int gentil = 0;
        private double gentilPercent = 0;
        private int hardi = 0;
        private double hardiPercent = 0;
        private int jovial = 0;
        private double jovialPercent = 0;
        private int lache = 0;
        private double lachePercent = 0;
        private int malin = 0;
        private double malinPercent = 0;
        private int malpoli = 0;
        private double malpoliPercent = 0;
        private int mauvais = 0;
        private double mauvaisPercent = 0;
        private int modeste = 0;
        private double modestePercent = 0;
        private int naif = 0;
        private double naifPercent = 0;
        private int presse = 0;
        private double pressePercent = 0;
        private int prudent = 0;
        private double prudentPercent = 0;
        private int pudique = 0;
        private double pudiquePercent = 0;
        private int relax = 0;
        private double relaxPercent = 0;
        private int rigide = 0;
        private double rigidePercent = 0;
        private int serieux = 0;
        private double serieuxPercent = 0;
        private int solo = 0;
        private double soloPercent = 0;
        private int timide = 0;
        private double timidePercent = 0;
        private int total = 0;

        private void reCalculatePercents()
        {
            if (total > 0)
            {
                assurePercent = Math.Round((double)assure / total * 100, 2);
                bizarrePercent = Math.Round((double)bizarre / total * 100, 2);
                bravePercent = Math.Round((double)brave / total * 100, 2);
                calmePercent = Math.Round((double)calme / total * 100, 2);
                discretPercent = Math.Round((double)discret / total * 100, 2);
                docilePercent = Math.Round((double)docile / total * 100, 2);
                douxPercent = Math.Round((double)doux / total * 100, 2);
                foufouPercent = Math.Round((double)foufou / total * 100, 2);
                gentilPercent = Math.Round((double)gentil / total * 100, 2);
                hardiPercent = Math.Round((double)hardi / total * 100, 2);
                jovialPercent = Math.Round((double)jovial / total * 100, 2);
                lachePercent = Math.Round((double)lache / total * 100, 2);
                malinPercent = Math.Round((double)malin / total * 100, 2);
                malpoliPercent = Math.Round((double)malpoli / total * 100, 2);
                mauvaisPercent = Math.Round((double)mauvais / total * 100, 2);
                modestePercent = Math.Round((double)modeste / total * 100, 2);
                naifPercent = Math.Round((double)naif / total * 100, 2);
                pressePercent = Math.Round((double)presse / total * 100, 2);
                prudentPercent = Math.Round((double)prudent / total * 100, 2);
                pudiquePercent = Math.Round((double)pudique / total * 100, 2);
                relaxPercent = Math.Round((double)relax / total * 100, 2);
                rigidePercent = Math.Round((double)rigide / total * 100, 2);
                serieuxPercent = Math.Round((double)serieux / total * 100, 2);
                soloPercent = Math.Round((double)solo / total * 100, 2);
                timidePercent = Math.Round((double)timide / total * 100, 2);
            }
        }

        private void updatePercents()
        {
            if (total > 0)
            {
                percentAssure.Text = assurePercent.ToString()+"%";
                percentBizarre.Text = bizarrePercent.ToString()+"%";
                percentBrave.Text = bravePercent.ToString()+"%";
                percentCalme.Text = calmePercent.ToString() + "%";
                percentDiscret.Text = discretPercent.ToString() + "%";
                percentDocile.Text = docilePercent.ToString() + "%";
                percentDoux.Text = douxPercent.ToString() + "%";
                percentFoufou.Text = foufouPercent.ToString() + "%";
                percentGentil.Text = gentilPercent.ToString()+ "%";
                percentHardi.Text = hardiPercent.ToString() + "%";
                percentJovial.Text = jovialPercent.ToString() + "%";
                percentLache.Text = lachePercent.ToString() + "%";
                percentMalin.Text = malinPercent.ToString() + "%";
                percentMalpoli.Text = malpoliPercent.ToString() + "%";
                percentMauvais.Text = mauvaisPercent.ToString() + "%";
                percentModeste.Text = modestePercent.ToString() + "%";
                percentNaif.Text = naifPercent.ToString() + "%";
                percentPresse.Text = pressePercent.ToString() + "%";
                percentPrudent.Text = prudentPercent.ToString() + "%";
                percentPudique.Text = pudiquePercent.ToString() + "%";
                percentRelax.Text = relaxPercent.ToString() + "%";
                percentRigide.Text = rigidePercent.ToString() + "%";
                percentSerieux.Text = serieuxPercent.ToString() + "%";
                percentSolo.Text = soloPercent.ToString() + "%";
                percentTimide.Text = timidePercent.ToString() + "%";
            }
            else
            {
                percentAssure.Text = "-";
                percentBizarre.Text = "-";
                percentBrave.Text = "-";
                percentCalme.Text = "-";
                percentDiscret.Text = "-";
                percentDocile.Text = "-";
                percentDoux.Text = "-";
                percentFoufou.Text = "-";
                percentGentil.Text = "-";
                percentHardi.Text = "-";
                percentJovial.Text = "-";
                percentLache.Text = "-";
                percentMalin.Text = "-";
                percentMalpoli.Text = "-";
                percentMauvais.Text = "-";
                percentModeste.Text = "-";
                percentNaif.Text = "-";
                percentPresse.Text = "-";
                percentPrudent.Text = "-";
                percentPudique.Text = "-";
                percentRelax.Text = "-";
                percentRigide.Text = "-";
                percentSerieux.Text = "-";
                percentSolo.Text = "-";
                percentTimide.Text = "-";
            }
        }

        private void subAssure_Click(object sender, EventArgs e)
        {
            if (assure > 0)
            {
                assure -= 1;
                total -= 1;
                assureCount.Text = assure.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addAssure_Click(object sender, EventArgs e)
        {
            assure += 1;
            total += 1;
            assureCount.Text = assure.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subModeste_Click(object sender, EventArgs e)
        {
            if (modeste > 0)
            {
                modeste -= 1;
                total -= 1;
                modesteCount.Text = modeste.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }
        private void addModeste_Click(object sender, EventArgs e)
        {
            modeste += 1;
            total += 1;
            modesteCount.Text = modeste.ToString();
            reCalculatePercents();
            updatePercents();
        }
        private void subBizarre_Click(object sender, EventArgs e)
        {
            if (bizarre > 0)
            {
                bizarre -= 1;
                total -= 1;
                bizarreCount.Text = bizarre.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addBizarre_Click(object sender, EventArgs e)
        {
            bizarre += 1;
            total += 1;
            bizarreCount.Text = bizarre.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subBrave_Click(object sender, EventArgs e)
        {
            if (brave > 0)
            {
                brave -= 1;
                total -= 1;
                braveCount.Text = brave.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addBrave_Click(object sender, EventArgs e)
        {
            brave += 1;
            total += 1;
            braveCount.Text = brave.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subDiscret_Click(object sender, EventArgs e)
        {
            if (discret > 0)
            {
                discret -= 1;
                total -= 1;
                discretCount.Text = discret.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addDiscret_Click(object sender, EventArgs e)
        {
            discret += 1;
            total += 1;
            discretCount.Text = discret.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subDocile_Click(object sender, EventArgs e)
        {
            if (docile > 0)
            {
                docile -= 1;
                total -= 1;
                docileCount.Text = docile.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addDocile_Click(object sender, EventArgs e)
        {
            docile += 1;
            total += 1;
            docileCount.Text = docile.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subDoux_Click(object sender, EventArgs e)
        {
            if (doux > 0)
            {
                doux -= 1;
                total -= 1;
                douxCount.Text = doux.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addDoux_Click(object sender, EventArgs e)
        {
            doux += 1;
            total += 1;
            douxCount.Text = doux.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subFou_Click(object sender, EventArgs e)
        {
            if (foufou > 0)
            {
                foufou -= 1;
                total -= 1;
                foufouCount.Text = foufou.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addFou_Click(object sender, EventArgs e)
        {
            foufou += 1;
            total += 1;
            foufouCount.Text = foufou.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subGentil_Click(object sender, EventArgs e)
        {
            if (gentil > 0)
            {
                gentil -= 1;
                total -= 1;
                gentilCount.Text = gentil.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addGentil_Click(object sender, EventArgs e)
        {
            gentil += 1;
            total += 1;
            gentilCount.Text = gentil.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subHardi_Click(object sender, EventArgs e)
        {
            if (hardi > 0)
            {
                hardi -= 1;
                total -= 1;
                hardiCount.Text = hardi.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addHardi_Click(object sender, EventArgs e)
        {
            hardi += 1;
            total += 1;
            hardiCount.Text = hardi.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subJovial_Click(object sender, EventArgs e)
        {
            if (jovial > 0)
            {
                jovial -= 1;
                total -= 1;
                jovialCount.Text = jovial.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addJovial_Click(object sender, EventArgs e)
        {
            jovial += 1;
            total += 1;
            jovialCount.Text = jovial.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subLache_Click(object sender, EventArgs e)
        {
            if (lache > 0)
            {
                lache -= 1;
                total -= 1;
                lacheCount.Text = lache.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addLache_Click(object sender, EventArgs e)
        {
            lache += 1;
            total += 1;
            lacheCount.Text = lache.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subMalin_Click(object sender, EventArgs e)
        {
            if (malin > 0)
            {
                malin -= 1;
                total -= 1;
                malinCount.Text = malin.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addMalin_Click(object sender, EventArgs e)
        {
            malin += 1;
            total += 1;
            malinCount.Text = malin.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subMalpoli_Click(object sender, EventArgs e)
        {
            if (malpoli > 0)
            {
                malpoli -= 1;
                total -= 1;
                malpoliCount.Text = malpoli.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addMalpoli_Click(object sender, EventArgs e)
        {
            malpoli += 1;
            total += 1;
            malpoliCount.Text = malpoli.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subMauvais_Click(object sender, EventArgs e)
        {
            if (mauvais > 0)
            {
                mauvais -= 1;
                total -= 1;
                mauvaisCount.Text = mauvais.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addMauvais_Click(object sender, EventArgs e)
        {
            mauvais += 1;
            total += 1;
            mauvaisCount.Text = mauvais.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subNaif_Click(object sender, EventArgs e)
        {
            if (naif > 0)
            {
                naif -= 1;
                total -= 1;
                naifCount.Text = naif.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addNaif_Click(object sender, EventArgs e)
        {
            naif += 1;
            total += 1;
            naifCount.Text = naif.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subPresse_Click(object sender, EventArgs e)
        {
            if (presse > 0)
            {
                presse -= 1;
                total -= 1;
                presseCount.Text = presse.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addPresse_Click(object sender, EventArgs e)
        {
            presse += 1;
            total += 1;
            presseCount.Text = presse.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subPrudent_Click(object sender, EventArgs e)
        {
            if (prudent > 0)
            {
                prudent -= 1;
                total -= 1;
                prudentCount.Text = prudent.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addPrudent_Click(object sender, EventArgs e)
        {
            prudent += 1;
            total += 1;
            prudentCount.Text = prudent.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subPudique_Click(object sender, EventArgs e)
        {
            if (pudique > 0)
            {
                pudique -= 1;
                total -= 1;
                pudiqueCount.Text = pudique.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addPudique_Click(object sender, EventArgs e)
        {
            pudique += 1;
            total += 1;
            pudiqueCount.Text = pudique.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subRelax_Click(object sender, EventArgs e)
        {
            if (relax > 0)
            {
                relax -= 1;
                total -= 1;
                relaxCount.Text = relax.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addRelax_Click(object sender, EventArgs e)
        {
            relax += 1;
            total += 1;
            relaxCount.Text = relax.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subRigide_Click(object sender, EventArgs e)
        {
            if (rigide > 0)
            {
                rigide -= 1;
                total -= 1;
                rigideCount.Text = rigide.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addRigide_Click(object sender, EventArgs e)
        {
            rigide += 1;
            total += 1;
            rigideCount.Text = rigide.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subSerieux_Click(object sender, EventArgs e)
        {
            if (serieux > 0)
            {
                serieux -= 1;
                total -= 1;
                serieuxCount.Text = serieux.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addSerieux_Click(object sender, EventArgs e)
        {
            serieux += 1;
            total += 1;
            serieuxCount.Text = serieux.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subSolo_Click(object sender, EventArgs e)
        {
            if (solo > 0)
            {
                solo -= 1;
                total -= 1;
                soloCount.Text = solo.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addSolo_Click(object sender, EventArgs e)
        {
            solo += 1;
            total += 1;
            soloCount.Text = solo.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subTimide_Click(object sender, EventArgs e)
        {
            if (timide > 0)
            {
                timide -= 1;
                total -= 1;
                timideCount.Text = timide.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addTimide_Click(object sender, EventArgs e)
        {
            timide += 1;
            total += 1;
            timideCount.Text = timide.ToString();
            reCalculatePercents();
            updatePercents();
        }

        private void subCalme_Click(object sender, EventArgs e)
        {
            if (calme > 0)
            {
                calme -= 1;
                total -= 1;
                calmeCount.Text = calme.ToString();
                reCalculatePercents();
                updatePercents();
            }
        }

        private void addCalme_Click(object sender, EventArgs e)
        {
            calme += 1;
            total += 1;
            calmeCount.Text = calme.ToString();
            reCalculatePercents();
            updatePercents();
        }
    }
}