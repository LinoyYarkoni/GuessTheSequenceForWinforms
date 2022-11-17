using MongoDBAccess;
using System.Collections.Generic;
using System.Drawing;
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
            loadScoreBoard();
        }

        private void createTableHead()
        {
            scoreBoardPanel.Anchor = AnchorStyles.Left;
            scoreBoardPanel.AutoScroll = true;
            scoreBoardPanel.Size = new Size(this.Size.Width, this.Size.Width);
            scoreBoardPanel.ColumnCount = 3;
            scoreBoardPanel.RowCount = 1;
  
            //scoreBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            //scoreBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            //scoreBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));

            scoreBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            scoreBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            scoreBoardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));

            scoreBoardPanel.Controls.Add(new Label() { Text = "Turns" }, 0, 0);
            scoreBoardPanel.Controls.Add(new Label() { Text = "Turns Played" }, 1, 0);
            scoreBoardPanel.Controls.Add(new Label() { Text = "Status" }, 2, 0);
            Controls.Add(scoreBoardPanel);
        }

        private async void loadScoreBoard()
        {
            int columnIndex = 0;

            List<GameModel> gamesList = await FormGame.DB.GelAllGames();

            foreach (GameModel gameModel in gamesList)
            {
                scoreBoardPanel.RowCount += 1;

                foreach (PropertyInfo data in gameModel.GetProperties())
                {
                    if (data.Name == "Id")
                    {
                        continue;
                    }

                    scoreBoardPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    scoreBoardPanel.Controls.Add(new Label() { Text = data.GetValue(gameModel).ToString() }, columnIndex, scoreBoardPanel.RowCount);
                    columnIndex++;
                }

                columnIndex = 0;
            }

        }
    }
}
