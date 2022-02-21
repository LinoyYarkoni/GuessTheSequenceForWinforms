using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace A22_Ex05
{
    public partial class FormGame : Form
    {
        private readonly List<Button> r_ResultButtonList;
        private readonly Button[,] r_ButtonsMatrix;
        private readonly List<Button> r_ArrowList;
        private readonly List<Button[,]> r_FeedbackMatrix;
        private readonly FormColors r_FormColors = new FormColors();
        private readonly GameBoard r_GameBoard;

        public FormGame()
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            int numberOfGuesses = formLogin.UserNumberOfGuesses;

            this.r_GameBoard = new GameBoard(4, 'A', 'H', numberOfGuesses);
            this.r_ResultButtonList = new List<Button>();
            this.r_ButtonsMatrix = new Button[this.r_GameBoard.NumberOfGuesses, r_GameBoard.MaxLengthOfComputerSequence];
            this.r_ArrowList = new List<Button>();
            this.r_FeedbackMatrix = new List<Button[,]>();
            InitializeComponent();
            this.initializeResultButtonList();
            this.ClientSize = new Size(12 + 58 * 6, 36 + (this.r_GameBoard.NumberOfGuesses + 1) * 52);

            for(int i = 0; i < this.r_GameBoard.NumberOfGuesses; i++)
            {
                bool isNotFirstRow = i != 0;

                for(int j = 0; j < r_GameBoard.MaxLengthOfComputerSequence; j++)
                {
                    Button guessButton = new Button();

                    guessButton.Location = new Point(12 + (58 * j), 80 + (52 * i));
                    guessButton.Size = new Size(52, 46);
                    guessButton.UseVisualStyleBackColor = true;
                    if(isNotFirstRow)
                    {
                        guessButton.Enabled = false;
                    }

                    this.r_ButtonsMatrix[i, j] = guessButton;
                    this.Controls.Add(guessButton);
                    guessButton.Click += new EventHandler(this.guessButton_Click);
                }

                Button arrowButton = new Button();
                arrowButton.Location = new Point(244, 89 + (52 * i));
                arrowButton.Size = new Size(52, 21);
                arrowButton.Text = "-->>";
                arrowButton.UseVisualStyleBackColor = true;
                arrowButton.Enabled = false;
                this.r_ArrowList.Add(arrowButton);
                this.Controls.Add(arrowButton);
                arrowButton.Click += new EventHandler(this.arrowButton_Click);
                Button[,] feedbackMatrix = new Button[2, 2];

                for(int j = 0; j < 2; j++)
                {
                    for(int k = 0; k < 2; k++)
                    {
                        Button button = new Button();
                        button.Location = new Point(300 + (23 * k), 80 + (52 * i + 25 * j));
                        button.Size = new Size(17, 17);
                        button.UseVisualStyleBackColor = true;
                        button.Enabled = false;
                        feedbackMatrix[j, k] = button;
                        this.Controls.Add(button);
                    }
                }

                this.r_FeedbackMatrix.Add(feedbackMatrix);
            }
        }

        private void guessButton_Click(object sender, EventArgs e)
        {
            Button guessButton = sender as Button;

            if(this.r_FormColors.ShowDialog() == DialogResult.OK)
            {
                if(guessButton.BackColor != DefaultBackColor)
                {
                    Color previousBackColor = guessButton.BackColor;

                    foreach(Button colorButton in this.r_FormColors.PossibleColorButtonList)
                    {
                        if(colorButton.BackColor == previousBackColor)
                        {
                            colorButton.Enabled = true;
                        }
                    }
                }

                guessButton.BackColor = r_FormColors.PickedColor;
                guessButton.Tag = r_FormColors.ColorLetter;
                int numberOfRow = r_GameBoard.NumberOfTurnsPlayed();
                bool isCurrentGuessLineColored = isAllLineColored(this.r_ButtonsMatrix, numberOfRow);

                if(isCurrentGuessLineColored)
                {
                    this.r_ArrowList[numberOfRow].Enabled = true;
                }
            }
        }

        private void arrowButton_Click(object sender, EventArgs e)
        {
            int numberOfRow = r_GameBoard.NumberOfTurnsPlayed();
            string currentGuessString = this.createButtonTagString(this.r_ButtonsMatrix);
            bool isNotDuplicatedGuess = this.r_GameBoard.AddGuess(currentGuessString) == eValidStatuses.Valid;

            if(isNotDuplicatedGuess)
            {
                for(int i = 0; i < r_GameBoard.MaxLengthOfComputerSequence; i++)
                {
                    this.r_ButtonsMatrix[numberOfRow, i].Enabled = false;
                }

                this.showFeedback(this.r_GameBoard.GetFeedbackArray(numberOfRow));
                this.r_ArrowList[numberOfRow].Enabled = false;
                bool isShowingResult = this.r_GameBoard.GameStatus == eGameStatuses.Win
                                       || this.r_GameBoard.GameStatus == eGameStatuses.Lose;
                if(isShowingResult)
                {
                    this.showResult();
                }
                else
                {
                    this.activateNextLine();
                }
            }
        }

        private bool isAllLineColored(Button[,] i_CurrentGuess, int i_CurrentRow)
        {
            bool isAllColored = true;

            for(int i = 0; i < r_GameBoard.MaxLengthOfComputerSequence; i++)
            {
                if(i_CurrentGuess[i_CurrentRow, i].BackColor == DefaultBackColor)
                {
                    isAllColored = false;
                    break;
                }
            }

            return isAllColored;
        }

        private string createButtonTagString(Button[,] i_CurrentButtonsRow)
        {
            string result = string.Empty;
            int numberOfRow = this.r_GameBoard.NumberOfTurnsPlayed();

            for(int i = 0; i < this.r_GameBoard.MaxLengthOfComputerSequence; i++)
            {
                result += (Char)i_CurrentButtonsRow[numberOfRow, i].Tag;
            }

            string separatedString = StringService.GenerateSeparatedLetters(result, " ");

            return separatedString;
        }

        private void activateNextLine()
        {
            int numberOfRow = r_GameBoard.NumberOfTurnsPlayed();

            if(numberOfRow < this.r_GameBoard.NumberOfGuesses)
            {
                for(int i = 0; i < r_GameBoard.MaxLengthOfComputerSequence; i++)
                {
                    this.r_ButtonsMatrix[numberOfRow, i].Enabled = true;
                }

                r_FormColors.ResetColorEnable();
            }
        }

        private void showFeedback(int[] i_Result)
        {
            int numberOfRow = r_GameBoard.NumberOfTurnsPlayed() - 1;

            for(int j = 0; j < 2; j++)
            {
                for(int k = 0; k < 2; k++)
                {
                    if(i_Result[0] > 0)
                    {
                        this.r_FeedbackMatrix[numberOfRow][j, k].BackColor = Color.Black;
                        i_Result[0]--;
                    }
                    else if(i_Result[1] > 0)
                    {
                        this.r_FeedbackMatrix[numberOfRow][j, k].BackColor = Color.Yellow;
                        i_Result[1]--;
                    }
                    else if(i_Result[2] > 0)
                    {
                        i_Result[2]--;
                    }
                }
            }
        }

        private void initializeResultButtonList()
        {
            this.r_ResultButtonList.Add(this.m_ButtonFirstResult);
            this.r_ResultButtonList.Add(this.m_ButtonSecondResult);
            this.r_ResultButtonList.Add(this.m_ButtonThirdResult);
            this.r_ResultButtonList.Add(this.m_ButtonForthResult);
        }

        private void showResult()
        {
            string resultString = this.r_GameBoard.ComputerSequence;

            for(int i = 0; i < this.r_GameBoard.MaxLengthOfComputerSequence; i++)
            {
                this.r_ResultButtonList[i].BackColor = this.r_FormColors.GetColorByTag(resultString[i]);
            }
        }
    }
}
