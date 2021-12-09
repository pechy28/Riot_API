using System;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.MatchV5;
using MingweiSamuel.Camille.SummonerV4;
using System.Windows.Forms;
using MingweiSamuel.Camille.MatchV4;
using MingweiSamuel.Camille.LeagueV4;
using System.IO;
using Match = MingweiSamuel.Camille.MatchV5.Match;

namespace Riot_API_Winforms
{
    public partial class Summoner_Search : Form
    {
        public object _matchInfo { get; private set; }

        public Summoner_Search()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MingweiSamuel.Camille.Enums.Region region = default;

            MingweiSamuel.Camille.Enums.Region continent = default;


            switch (regionComboBox.SelectedItem)
            {
                case "BR1":
                    region = MingweiSamuel.Camille.Enums.Region.BR;
                    continent = MingweiSamuel.Camille.Enums.Region.Americas;
                    break;

                case "EUN1":
                    region = MingweiSamuel.Camille.Enums.Region.EUNE;
                    continent = MingweiSamuel.Camille.Enums.Region.Europe;
                    break;

                case "EUW1":
                    region = MingweiSamuel.Camille.Enums.Region.EUW;
                    continent = MingweiSamuel.Camille.Enums.Region.Europe;
                    break;

                case "JP1":
                    region = MingweiSamuel.Camille.Enums.Region.JP;
                    continent = MingweiSamuel.Camille.Enums.Region.Asia;
                    break;

                case "KR":
                    region = MingweiSamuel.Camille.Enums.Region.KR;
                    continent = MingweiSamuel.Camille.Enums.Region.Asia;
                    break;

                case "LA1":
                    region = MingweiSamuel.Camille.Enums.Region.LAN;
                    continent = MingweiSamuel.Camille.Enums.Region.Americas;
                    break;

                case "LA2":
                    region = MingweiSamuel.Camille.Enums.Region.LAS;
                    continent = MingweiSamuel.Camille.Enums.Region.Americas;
                    break;

                case "NA1":
                    region = MingweiSamuel.Camille.Enums.Region.NA;
                    continent = MingweiSamuel.Camille.Enums.Region.Americas;
                    break;

                case "OC1":
                    region = MingweiSamuel.Camille.Enums.Region.OCE;
                    continent = MingweiSamuel.Camille.Enums.Region.Europe;
                    break;

                case "RU":
                    region = MingweiSamuel.Camille.Enums.Region.RU;
                    continent = MingweiSamuel.Camille.Enums.Region.Europe;
                    break;

                case "TR1":
                    region = MingweiSamuel.Camille.Enums.Region.TR;
                    continent = MingweiSamuel.Camille.Enums.Region.Europe;
                    break;
            }

            var riotApi = RiotApi.NewInstance(APITextBox.Text);
            Summoner summoner = riotApi.SummonerV4.GetBySummonerName(region, summonerTextBox.Text);

            levelTextBox.Text = summoner.SummonerLevel.ToString();



            //Task<LeagueList> leagueList = riotApi.LeagueV4.GetLeagueByIdAsync(region, "7mWpUTSIHj7zL7QCTXre7V9sFpSa8uSOiQepOnEBJV-VrXc");
            //leagueList.ToString();
            //Console.WriteLine(leagueList.ToString());

            

            string[] matches = riotApi.MatchV5.GetMatchIdsByPUUID(continent, summoner.Puuid, null, 20);



            //Matchlist matches = riotApi.MatchV4.GetMatchlist(region, summoner.AccountId, cham);
            Console.WriteLine(matches);

            foreach (var m in matches)
            {
                matchesListBox.Items.Add(m);
                Console.WriteLine(m);
            }




            //Match m1 = riotApi.MatchV5.GetMatch(continent, matches[0]);
           //var dictionary = m1._AdditionalProperties;
            //var listPlayer = dictionary["participants"];
            //Console.WriteLine(listPlayer);

            puuidTextBox.Text = summoner.Puuid;
        }

        private void regionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            losersListBox.Items.Clear();
            winnersListBox.Items.Clear();
            matchesListBox.Items.Clear();
            regionComboBox.ResetText();
            puuidTextBox.Text = String.Empty;
            summonerTextBox.Text = String.Empty;
            winsTextBox.Text = String.Empty;
            losesTextBox.Text = String.Empty;
            levelTextBox.Text = String.Empty;
        }

        private void summonerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void APITextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void summonerDetailsGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void ratingTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
