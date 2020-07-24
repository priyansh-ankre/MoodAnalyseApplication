using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserUtility
    {
        string message;
        public MoodAnalyserUtility()
        {
            this.message = "";
        }
        public MoodAnalyserUtility(string message)
        {
            this.message = message;
        }
       
        public string analyseMood()
        {
            try
            {
                if (message.Length == 0)
                {
                    throw new MoodAnalyserException("The mood is empty",MoodAnalyserException.ExceptionType.INVALID_MOOD_EXCEPTION);
                }
                if (message.Contains("Sad"))
                {
                    return "SAD";
                }
                return "HAPPY";
            }

            catch (NullReferenceException)
            {

                throw new MoodAnalyserException("The mood is null",MoodAnalyserException.ExceptionType.INVALID_MOOD_EXCEPTION);
            }
        }
    }
}
