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
            if (message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}
