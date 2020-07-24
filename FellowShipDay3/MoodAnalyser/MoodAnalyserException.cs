using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyser
{
    public class MoodAnalyserException : Exception
    {

        public enum ExceptionType 
        {

            INVALID_MOOD_EXCEPTION
        }
        public ExceptionType type;
        public MoodAnalyserException(string message,ExceptionType type)
            : base(message) { }
    }
}
