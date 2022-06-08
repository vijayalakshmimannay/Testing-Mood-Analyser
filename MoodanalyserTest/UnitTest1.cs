using MoodAnalyser;

namespace MoodanalyserTest
{
    public class Tests
    {
        private string message;
        private object obj;

        [Test]
        public void GivenMood_AnalyseMood_ReturnsadMood()
        {
            string message = "I am in Sad Mood";
            MoodAnalyser.MoodAnalyze mood = new MoodAnalyser.MoodAnalyze(message);
            string acualResult = mood.getMood();
            Assert.AreEqual("Sad", acualResult);
        }
        [Test]
        public void GivenMood_AnalyseMood_ReturnHappyMood()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser.MoodAnalyze mood = new MoodAnalyser.MoodAnalyze(message);
            string acualResult = mood.getMood();
            Assert.AreEqual("Happy", acualResult);

        }
        [Test]
        public void GivenNull_AnalyseMood_ReturnHappyMood()
        {
            string message = "null";
            MoodAnalyser.MoodAnalyze mood = new MoodAnalyser.MoodAnalyze(message);
            string acualResult = mood.getMood();
            Assert.AreEqual("Happy", acualResult);
        }
        [Test]
        public void GivenEmpty_AnalyseMood_ReturnHappyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser.MoodAnalyze mood = new MoodAnalyser.MoodAnalyze(message);
                string acualResult = mood.getMood();
            }
            catch (MoodAnalyser.AnalyzerException exc)
            {
                Assert.AreEqual("Mood can not be Empty", exc.Message);
            }
        }
        [Test]
        public void GivenMoodAnalyserClassName_ShouldReturnMoodAnalyseObjectd()
        {
            object expected = new MoodAnalyze();
            object obj = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyze", "MoodAnalyze");
            expected.Equals(obj);
        }

        [Test]
        public void GivenMoodAnalyserClassName_ShouldreturnObject()
        {
            string message = null;
            object expected = new MoodAnalyze(message);
            object actual = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyze", "MoodAnalyze");
            expected.Equals(actual);

        }
    }
}
