using MongoDBAccess;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class FormScoreBoard : Form
    {
        private readonly TableLayoutPanel scoreBoardPanel;

        public FormScoreBoard()
        {
            InitializeComponent();
            scoreBoardPanel = new TableLayoutPanel();
            createTableHead();
            //loadScoreBoard();
        }

        private void createTableHead()
        {
            scoreBoardPanel.ColumnCount = 3;
            scoreBoardPanel.RowCount = 1;
            scoreBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            scoreBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            scoreBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            scoreBoardPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            scoreBoardPanel.Controls.Add(new Label() { Text = "Turns" }, 0, 0);
            scoreBoardPanel.Controls.Add(new Label() { Text = "Turns Played" }, 1, 0);
            scoreBoardPanel.Controls.Add(new Label() { Text = "Win or Lose" }, 2, 0);
            Controls.Add(scoreBoardPanel);
        }

        private async void loadScoreBoard()
        {
            List<GameModel> gamesList = await FormGame.DB.GelAllGames();

            foreach (GameModel gameModel in gamesList)
            {
                foreach (PropertyInfo data in gameModel.GetProperties())
                {
                    if (data.Name == "Id")
                    {
                        continue;
                    }

                    //textBoxScores.Text += data.GetValue(gameModel).ToString();
                    //listBoxScores.Items.Add(data.GetValue(gameModel).ToString() + " ");
                }
                //listBoxScores.Items.Add(Environment.NewLine);
            }

        }
    }
}
