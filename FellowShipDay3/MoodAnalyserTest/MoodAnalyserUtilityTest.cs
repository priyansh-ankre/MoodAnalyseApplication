using NUnit.Framework;

namespace MoodAnalyserTest
{
    public class MoodAnalyserUtiltyTest
    {
        [Test]
        public void givenSadMessage_WhenAnalyse_ShouldReturnSad()
        {
            MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility("this is a Sad message");
            Assert.AreEqual("SAD", moodAnalyser.analyseMood());
        }
        [Test]
        public void givenHappyMessage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility("this is a Happy message");
            Assert.AreEqual("HAPPY", moodAnalyser.analyseMood());
        }
        [Test]
        public void givenNullMessage_WhenAnalyse_ShouldReturnHappy()
        {
            MoodAnalyser.MoodAnalyserUtility moodAnalyser = new MoodAnalyser.MoodAnalyserUtility(null);
            Assert.AreEqual("HAPPY", moodAnalyser.analyseMood());
        }
    }
}