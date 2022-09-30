namespace UserInterface
{
    public static class RunGame
    {
        public static void StartGame()
        {
            FormGame formGame = new FormGame();
            formGame.ShowDialog();
        }
    }
}