using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Logic
{
    public partial class FormColors : Form
    {
        private readonly List<Button> r_PossibleColorButtonList = new List<Button>();
        private object m_ColorLetter;
        private Color m_PickedColor;

        public FormColors()
        {
            InitializeComponent();
            this.initializeColoredButtonList();
        }

        public Color PickedColor
        {
            get
            {
                return this.m_PickedColor;
            }
        }

        public object ColorLetter
        {
            get
            {
                return this.m_ColorLetter;
            }
        }

        public List<Button> PossibleColorButtonList
        {
            get
            {
                return this.r_PossibleColorButtonList;
            }
        }

        public void ResetColorEnable()
        {
            foreach(Button colorButton in this.r_PossibleColorButtonList)
            {
                colorButton.Enabled = true;
            }
        }

        public Color GetColorByTag(Char i_ColorChar)
        {
            Color result = Color.Black;

            foreach(Button coloredButton in this.r_PossibleColorButtonList)
            {
                if((Char)coloredButton.Tag == i_ColorChar)
                {
                    result = coloredButton.BackColor;
                    break;
                }
            }

            return result;
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;

            this.DialogResult = DialogResult.OK;
            this.m_PickedColor = clickedButton.BackColor;
            this.m_ColorLetter = clickedButton.Tag;
            clickedButton.Enabled = false;
        }

        private void initializeColoredButtonList()
        {
            this.r_PossibleColorButtonList.Add(m_ButtonPink);
            this.r_PossibleColorButtonList.Add(m_ButtonRed);
            this.r_PossibleColorButtonList.Add(m_ButtonGreen);
            this.r_PossibleColorButtonList.Add(m_ButtonLightBlue);
            this.r_PossibleColorButtonList.Add(m_ButtonDarkBlue);
            this.r_PossibleColorButtonList.Add(m_ButtonYellow);
            this.r_PossibleColorButtonList.Add(m_ButtonBrown);
            this.r_PossibleColorButtonList.Add(m_ButtonWhite);
        }
    }
}
