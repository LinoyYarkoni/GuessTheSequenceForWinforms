using MongoDBAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FormScoreBoard : Form
    {
        public FormScoreBoard()
        {
            InitializeComponent();
            loadScoreBoard();


            //for (int i = 0; i < r_GameBoard.NumberOfGuesses; i++)
            //{
            //    bool isNotFirstRow = i != 0;

            //    for (int j = 0; j < r_GameBoard.MaxLengthOfComputerSequence; j++)
            //    {
            //        Button guessButton = new Button();

            //        guessButton.Location = new Point(12 + (58 * j), 80 + (52 * i));
            //        guessButton.Size = new Size(52, 46);
            //        guessButton.UseVisualStyleBackColor = true;
            //        if (isNotFirstRow)
            //        {
            //            guessButton.Enabled = false;
            //        }

            //        r_ButtonsMatrix[i, j] = guessButton;
            //        Controls.Add(guessButton);
            //        guessButton.Click += new EventHandler(guessButton_Click);
            //}
        }

        private async void loadScoreBoard()
        {

            List<GameModel> gamesList = await FormGame.DB.GelAllGames();

            foreach (GameModel gameModel in gamesList)
            {
                foreach (PropertyInfo data in gameModel.GetProperties())
                {
                    textBoxScores.Text += data.GetValue(gameModel).ToString();
                    listBoxScores.Items.Add(data.GetValue(gameModel).ToString() + " ");
                }

                listBoxScores.Items.Add(Environment.NewLine);
            }
        }

    }
}
