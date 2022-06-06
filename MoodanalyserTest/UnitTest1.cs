namespace MoodanalyserTest
{
    public class Tests
    {
        private string message;

        [Test]
        public void GivenMood_AnalyseMood_ReturnsadMood()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser.AnalyzeMood mood = new MoodAnalyser.AnalyzeMood(message);
            string acualResult = mood.getMood();
            Assert.AreEqual("Sad", acualResult);
        }
        [Test]
        public void GivenMood_AnalyseMood_ReturnHappyMood()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser.AnalyzeMood mood = new MoodAnalyser.AnalyzeMood(message);
            string acualResult = mood.getMood();
            Assert.AreEqual("Happy", acualResult);

        }
    }
}