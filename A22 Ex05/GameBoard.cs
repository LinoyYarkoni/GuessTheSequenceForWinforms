using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class GameBoard
    {
        private readonly List<Tuple<string, int[]>> r_UserGuessAndResult = new List<Tuple<string, int[]>>();
        private readonly int r_MaxLengthOfComputerSequence;
        private readonly char r_StartOfGuessSeqRange;
        private readonly char r_EndOfGuessSeqRange;
        private readonly Random r_Random = new Random();
        private int m_NumberOfGuesses;
        private string m_ComputerSequence;
        private eGameStatuses m_Status;

        public GameBoard(
            int i_MaxLengthOfComputerSequence,
            char i_StartOfGuessSeqRange,
            char i_EndOfGuessSeqRange,
            int i_NumberOfGuesses)
        {
            this.r_MaxLengthOfComputerSequence = i_MaxLengthOfComputerSequence;
            this.r_StartOfGuessSeqRange = i_StartOfGuessSeqRange;
            this.r_EndOfGuessSeqRange = i_EndOfGuessSeqRange;
            this.m_NumberOfGuesses = i_NumberOfGuesses;
            this.m_Status = eGameStatuses.Playing;
            this.generateRandomCharSequence();
        }

        public int NumberOfGuesses
        {
            get
            {
                return this.m_NumberOfGuesses;
            }

            set
            {
                this.m_NumberOfGuesses = value;
            }
        }

        public int MaxLengthOfComputerSequence
        {
            get
            {
                return this.r_MaxLengthOfComputerSequence;
            }
        }

        public string ComputerSequence
        {
            get
            {
                return this.m_ComputerSequence;
            }
        }

        public int NumberOfTurnsPlayed()
        {
            return this.r_UserGuessAndResult.Count();
        }

        public int[] GetFeedbackArray(int i_GamePhase)
        {
            return this.r_UserGuessAndResult[i_GamePhase].Item2;
        }

        public eGameStatuses GameStatus
        {
            get
            {
                return this.m_Status;
            }
        }

        public eValidStatuses AddGuess(string i_UserGuessInput)
        {
            eValidStatuses isValidFormat = this.isCurrentGuessValidFormat(i_UserGuessInput);

            if(isValidFormat == eValidStatuses.Valid)
            {
                string formattedGuess = i_UserGuessInput.Replace(" ", string.Empty);
                int[] resultsOfCurrentGuess = this.calculateGuessResult(formattedGuess);
                this.addToUserGuessList(i_UserGuessInput, resultsOfCurrentGuess);
                this.updateGameStatus();
            }

            return isValidFormat;
        }

        private void updateGameStatus()
        {
            if(this.r_UserGuessAndResult.Last().Item2[0] == MaxLengthOfComputerSequence)
            {
                this.m_Status = eGameStatuses.Win;
            }
            else if(this.r_UserGuessAndResult.Count() >= this.NumberOfGuesses)
            {
                this.m_Status = eGameStatuses.Lose;
            }
        }

        private eValidStatuses isCurrentGuessValidFormat(string i_UserGuessInput)
        {
            eValidStatuses isValidGuess = eValidStatuses.Valid;
            bool isDuplicatedInput = checkDuplicatedInput(i_UserGuessInput);

            if(isDuplicatedInput)
            {
                isValidGuess = eValidStatuses.AlreadyTried;
            }

            return isValidGuess;
        }

        private bool checkDuplicatedInput(string i_StringToCheck)
        {
            bool isDuplicated = false;

            if(this.r_UserGuessAndResult != null)
            {
                for(int i = 0; i < this.r_UserGuessAndResult.Count; i++)
                {
                    if(i_StringToCheck == this.r_UserGuessAndResult[i].Item1)
                    {
                        isDuplicated = true;
                    }
                }
            }

            return isDuplicated;
        }

        private int[] calculateGuessResult(string i_GuessInputToCheck)
        {
            int numberOfMatchingPlaces = StringService.GetNumberOfCorrectLetterAndPlace(i_GuessInputToCheck, this.m_ComputerSequence);
            int numberOfMatchingCharsInWrongPlaces =
                StringService.GetNumberOfMatchingCharsInWrongPlaces(i_GuessInputToCheck, this.m_ComputerSequence);
            int numberOfIncorrectChars = this.MaxLengthOfComputerSequence - numberOfMatchingPlaces
                                                                          - numberOfMatchingCharsInWrongPlaces;
            int[] result = new int[3] {numberOfMatchingPlaces, numberOfMatchingCharsInWrongPlaces, numberOfIncorrectChars};

            return result;
        }

        private void generateRandomCharSequence()
        {
            this.m_ComputerSequence = string.Empty;
            while(this.m_ComputerSequence.Length < this.r_MaxLengthOfComputerSequence)
            {
                char randomChar = (char)r_Random.Next(this.r_StartOfGuessSeqRange, this.r_EndOfGuessSeqRange);

                if(checkComputerGuess(this.m_ComputerSequence, randomChar))
                {
                    this.m_ComputerSequence += randomChar;
                }
            }
        }

        private bool checkComputerGuess(string i_ComputerSequence, char i_CurrentRandomChar)
        {
            bool checkGuessResult = true;
            int currentSequenceLength = i_ComputerSequence.Length;

            for(int i = 0; i < currentSequenceLength; i++)
            {
                if(i_CurrentRandomChar == i_ComputerSequence[i])
                {
                    checkGuessResult = false;
                }
            }

            return checkGuessResult;
        }

        private void addToUserGuessList(string i_Guess, int[] i_Result)
        {
            Tuple<string, int[]> itemToAdd = new Tuple<string, int[]>(i_Guess, i_Result);

            this.r_UserGuessAndResult.Add(itemToAdd);
        }
    }
}