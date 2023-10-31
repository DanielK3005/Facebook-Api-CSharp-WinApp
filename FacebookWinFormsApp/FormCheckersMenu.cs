using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormCheckersMenu : Form
    {
        private int m_SizeOfBoard = 6;

        public FormCheckersMenu(string i_namePlayer)
        {
            InitializeComponent();
            textBoxPlayer1Name.Text = i_namePlayer;
        }

        public int SizeOfBoard
        {
            get
            {
                return m_SizeOfBoard;
            }

            set
            {
               m_SizeOfBoard = value;
            }
        }

        public string TextBoxPlayer1Name
        {
            get
            {
                return this.textBoxPlayer1Name.Text;
            }
        }

        public string TextBoxPlayer2Name
        {
            get
            {
                return this.textBoxPlayer2Name.Text;
            }
        }

        public bool IsPlayingAgainstFriend
        {
            get
            {
                return this.checkBoxIsPlayingAgainstFriend.Checked;
            }
        }

        public bool ArePlayersNamesNotEmpty()
        {
            return !(string.IsNullOrWhiteSpace(textBoxPlayer1Name.Text) || string.IsNullOrWhiteSpace(textBoxPlayer2Name.Text));
        }

        private void textBoxPlayer1Name_TextChanged(object sender, EventArgs e)
        {
            TextBox Name = sender as TextBox;
            textBoxPlayer1Name.Text = Name.Text;
        }

        private void textBoxPlayer2Name_TextChanged(object sender, EventArgs e)
        {
            TextBox Name = sender as TextBox;
            textBoxPlayer2Name.Text = Name.Text;
        }

        private void checkBoxIsPlayingAgainstFriend_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                textBoxPlayer2Name.Enabled = true;
                textBoxPlayer2Name.Text = "";
            }
            else
            {
                textBoxPlayer2Name.Enabled = false;
                textBoxPlayer2Name.Text = "CPU";
            }
        }

        private void radioButtonLargeSize_CheckedChanged(object sender, EventArgs e)
        {
            this.m_SizeOfBoard = 10;
        }

        private void radioButtonMediumSize_CheckedChanged(object sender, EventArgs e)
        {
            this.m_SizeOfBoard = 8;
        }

        private void radioButtonSmallSize_CheckedChanged(object sender, EventArgs e)
        {
            this.m_SizeOfBoard = 6;
        }
    }
}
