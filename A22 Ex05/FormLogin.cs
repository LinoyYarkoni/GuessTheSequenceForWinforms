using System;
using System.Windows.Forms;

namespace A22_Ex05
{
    public partial class FormLogin : Form
    {
        private int m_CurrentNumberOfGuesses = 4;
        private int m_UserNumberOfGuesses;

        public FormLogin()
        {
            InitializeComponent();
        }

        public int UserNumberOfGuesses
        {
            get
            {
                return this.m_UserNumberOfGuesses;
            }
        }

        private void buttonNumberOfChances_Click(object sender, EventArgs e)
        {
            Button numberOfChances = sender as Button;
            int maxNumberOfGuesses = 11;

            m_CurrentNumberOfGuesses = (m_CurrentNumberOfGuesses + 1) % maxNumberOfGuesses;
            if(m_CurrentNumberOfGuesses % maxNumberOfGuesses == 0)
            {
                m_CurrentNumberOfGuesses = 4;
            }

            numberOfChances.Text = string.Format("Number of chances: {0}", this.m_CurrentNumberOfGuesses);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.m_UserNumberOfGuesses = this.m_CurrentNumberOfGuesses;
            this.Dispose();
        }

    }
}
