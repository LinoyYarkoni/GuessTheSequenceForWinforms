namespace A22_Ex05
{
    public static class StringService
    {
        public static int GetNumberOfCorrectLetterAndPlace(string i_StringToCheck, string i_SourceString)
        {
            int stringLength = i_StringToCheck.Length;
            int numberOfMatches = 0;

            for(int i = 0; i < stringLength; i++)
            {
                if(i_StringToCheck[i] == i_SourceString[i])
                {
                    numberOfMatches++;
                }
            }

            return numberOfMatches;
        }

        public static int GetNumberOfMatchingCharsInWrongPlaces(string i_StringToCheck, string i_SourceString)
        {
            int stringLength = i_StringToCheck.Length;
            int numberOfMatches = 0;

            for(int i = 0; i < stringLength; i++)
            {
                for(int j = 0; j < stringLength; j++)
                {
                    if(i != j && i_StringToCheck[i] == i_SourceString[j])
                    {
                        numberOfMatches++;
                    }
                }
            }

            return numberOfMatches;
        }

        public static string GenerateSeparatedLetters(string i_StringToSeparate, string i_Separator)
        {
            char[] cArray = i_StringToSeparate.ToCharArray();
            string result = string.Join(i_Separator, cArray);

            return result;
        }
    }
}