using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Elektrarny
{
    public partial class Names : Form
    {
         public Names()
         {
            InitializeComponent();
         }

        public List<string> names = new List<string>();

        private void name_textbox_keypress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                name();
            }
        }

        void name ()
        {
            if (names.Count != 4)
            {
                if (name_textbox.Text != "")
                {
                    names_label_list.Text += name_textbox.Text + "\r\n";
                    names.Add(name_textbox.Text);
                    name_textbox.Text = "";
                }
                else
                {
                    MessageBox.Show("Prostě tam něco musíš napsat", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Max 4 playrs", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void start(object sender, EventArgs e)
        {
            if (names.Count != 0)
            {
                Names.ActiveForm.Hide();
                Game game = new Game(names);
                game.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Min 1 player", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
