namespace MoodanalyserTest
{
    public class Tests
    {


        [Test]
        public void GivenMood_AnalyseMood_ReturnsadMood()
        {
            MoodAnalyser.AnalyzeMood mood = new MoodAnalyser.AnalyzeMood();
            string acualResult = mood.getMood("I am in Sad mood");
            Assert.AreEqual("Sad", acualResult);
        }
        [Test]
        public void GivenMood_AnalyseMood_ReturnHappyMood()
        {
            MoodAnalyser.AnalyzeMood mood = new MoodAnalyser.AnalyzeMood();
            string acualResult = mood.getMood("I am in Any mood");
            Assert.AreEqual("Happy", acualResult);

        }
    }
}