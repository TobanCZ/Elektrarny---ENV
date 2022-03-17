using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;

using System.Windows.Forms;

namespace Elektrarny
{
    public partial class Game : Form
    {
        public List<string> names;
        Label[] names_label;

        int current_player = 0;
        int[] players_skip;

        public Game(List<string> i)
        {
            InitializeComponent();
            names = i;
            names_label = new Label[] {name1_label,name2_label,name3_label,name4_label};
        }


        private void Game_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                if (names.Count() - 1 >= i)
                {
                    names_label[i].Text = names[i]; 
                }
                else
                {
                    names_label[i].Text = "";
                }
            }

            players_skip = new int[names.Count];

            names_label[0].BackColor = Color.LightBlue;
        }

        private void Update(string type)
        {
            if (type == "skip")
            {
                next_player();
            }   

                if (type == "voda")
                {
                    money(820000000);
                    power(5);
                    round_skip(0);
                    next_player();
                    int temp = Convert.ToInt32(vodni_count_label.Text.Replace("x", ""));
                    temp++;
                    vodni_count_label.Text = temp.ToString() + "x";
                }

                if (type == "jadro")
                {
                    money(55000000000);
                    power(1000);
                    round_skip(10);
                    next_player();
                    int temp = Convert.ToInt32(jadro_count_label.Text.Replace("x", ""));
                    temp++;
                    jadro_count_label.Text = temp.ToString() + "x";
                }

                if (type == "uhli")
                {
                    money(212000000000);
                    power(200);
                    round_skip(2);
                    next_player();
                    int temp = Convert.ToInt32(uhli_count_label.Text.Replace("x", ""));
                    temp++;
                    uhli_count_label.Text = temp.ToString() + "x";
                }

                if (type == "svetlo")
                {
                    money(3840000000);
                    power(30);
                    round_skip(0);
                    next_player();
                    int temp = Convert.ToInt32(svetlo_count_label.Text.Replace("x", ""));
                    temp++;
                    svetlo_count_label.Text = temp.ToString() + "x";
                }

                if (type == "vitr")
                {
                    money(105000000);
                    power(3);
                    round_skip(0);
                    next_player();
                    int temp = Convert.ToInt32(vitr_count_label.Text.Replace("x", ""));
                    temp++;
                    vitr_count_label.Text = temp.ToString() + "x";
                }   
            
        }

        private void next_player()
        {
            if(current_player != names.Count - 1)
            {
                names_label[current_player].BackColor = Color.Empty;
                current_player++;
                names_label[current_player].BackColor = Color.LightBlue;
                if(players_skip[current_player] != 0)
                {
                    round_skip(-1);
                    next_player();
                }
            }
            else 
            {
                names_label[current_player].BackColor = Color.Empty;
                current_player = 0;
                names_label[current_player].BackColor = Color.LightBlue;

                int round = Convert.ToInt32(round_label.Text);
                round++;
                round_label.Text = round.ToString();

                int year = Convert.ToInt32(year_label.Text);
                year = year + 2;
                year_label.Text = year.ToString();

                if (players_skip[current_player] != 0)
                {
                    round_skip(-1);
                    next_player();
                }
            }
        }

        private void round_skip(int rounds)
        {
            players_skip[current_player] += rounds;
            if (players_skip[current_player] == 0)
            {
                names_label[current_player].Text = names[current_player];
            }
            else 
            {
                names_label[current_player].Text = names[current_player] + ": " + players_skip[current_player];
            }
        }

        private void money(long money)
        {
            long moneycount = Convert.ToInt64(money_label.Text.Replace(" ",""));
            moneycount = moneycount - money;
            string moneystring = moneycount.ToString("0,0", CultureInfo.InvariantCulture);
            moneystring = moneystring.Replace(",", " ");
            money_label.Text = moneystring;
        }

        private void power(int power)
        {
            int mwcount = Convert.ToInt32(mw_label.Text.Replace(" ", ""));
            mwcount = mwcount + power;
            string mwstring = mwcount.ToString("0,0", CultureInfo.InvariantCulture);
            mwstring = mwstring.Replace(",", " ");
            mw_label.Text = mwstring;
        }

        #region buttons
        private void voda(object sender, EventArgs e)
        {
            Update("voda");
        }

        private void jadro(object sender, EventArgs e)
        {
            Update("jadro");
        }

        private void uhli(object sender, EventArgs e)
        {
            Update("uhli");
        }

        private void svetlo(object sender, EventArgs e)
        {
            Update("svetlo");
        }

        private void vitr(object sender, EventArgs e)
        {
            Update("vitr");
        }

        private void skip(object sender, EventArgs e)
        {
            Update("skip");
        }

        private void Exit(object sender, FormClosingEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        #endregion buttons
    }
}
