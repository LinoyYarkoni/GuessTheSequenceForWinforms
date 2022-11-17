namespace UserInterface
{
    public static class RunGame
    {
        public static void StartGame()
        {
            FormGame formGame = new FormGame();
            FormScoreBoard fsb = new FormScoreBoard();
            fsb.ShowDialog();
            //FormGame formGame = new FormGame();
            //formGame.ShowDialog();
        }
    }
}