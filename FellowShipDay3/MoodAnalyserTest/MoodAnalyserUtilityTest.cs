using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class MoodAnalyserUtiltyTest
    {
        [Test]
        public void givenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
            string mood = moodAnalyser.analyseMood("this is a Sad message");
            Assert.AreEqual("SAD", mood);
        }
        [Test]
        public void givenHappyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility();
            string mood = moodAnalyser.analyseMood("this is a Happy message");
            Assert.AreEqual("HAPPY", mood);
        }
    }
}