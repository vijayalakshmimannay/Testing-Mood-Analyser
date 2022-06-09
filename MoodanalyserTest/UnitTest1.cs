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
            MoodAnalyser.MoodAnalyser mood = new MoodAnalyser.MoodAnalyser(message);
            string acualResult = mood.getMood();
            Assert.AreEqual("Sad", acualResult);
        }
        [Test]
        public void GivenMood_AnalyseMood_ReturnHappyMood()
        {
            string message = "I am in Happy Mood";
            MoodAnalyser.MoodAnalyser mood = new MoodAnalyser.MoodAnalyser(message);
            string acualResult = mood.getMood();
            Assert.AreEqual("Happy", acualResult);

        }
        [Test]
        public void GivenNull_AnalyseMood_ReturnHappyMood()
        {
            string message = "null";
            MoodAnalyser.MoodAnalyser mood = new MoodAnalyser.MoodAnalyser(message);
            string acualResult = mood.getMood();
            Assert.AreEqual("Happy", acualResult);
        }
        [Test]
        public void GivenEmpty_AnalyseMood_ReturnHappyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser.MoodAnalyser mood = new MoodAnalyser.MoodAnalyser(message);
                string acualResult = mood.getMood();
            }
            catch (MoodAnalyser.AnalyzerException exc)
            {
                Assert.AreEqual("Mood can not be Empty", exc.Message);
            }
        }
        
        //[Test]
        //public void GivenMoodAnalyserClassName_ShouldreturnObject()
        //{
           // string message = null;
           // object expected = new MoodAnalyze(message);
           // object actual = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyze", "MoodAnalyze");
           // expected.Equals(actual);

       // }

        [Test]
        public void GivenMoodAnalyseClassName_ShouldreturnClassNotFound()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyser.MoodAnalyser(message);
                object actual = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyser.MoodAna", "MoodAnalyser.MoodAnalyze");
                expected.Equals(actual);
            }
            catch (MoodAnalyser.AnalyzerException ex)
            {
                Assert.AreEqual("Class not found", ex.Message);
            }
        }

        [Test]
        public void GivenMoodAnalyseClassName_ShouldreturnConstructorNotFound()
        {
            try
            {
                string message = null;
                object expected = new MoodAnalyser.MoodAnalyser(message);
                object actual = MoodAnalyseFactory.CreateMoodAnalyse("MoodAnalyser.MoodAnalyze", "MoodAnaly");
                expected.Equals(actual);
            }
            catch (MoodAnalyser.AnalyzerException exp)
            {
                Assert.AreEqual("Constructor is Not Found", exp.Message);
            }
        }

        /*[Test]
        public void GivenMoodParameter_MoodParameterConstructor_ReturnParameterConstructor()
        {
            object expected = new MoodAnalyser.MoodAnalyser("Happy");
            object value = MoodAnalyseFactory.createMoodAnalyzerParameter("MoodAnalyser.MoodAnalyze", "MoodAnalyze", "Happy");
            expected.Equals(value);
        }*/

        [Test]
        public void GivenInvalidClassNameAndValidPerameterizedConstructor_ReturnNoSuchConstructor()
        {
            try
            {
                object expected = new MoodAnalyser.MoodAnalyser("Happy");
                object actual = MoodAnalyser.MoodAnalyseFactory.createMoodAnalyzerParameter("MoodAnalyze", "MoodAna", "Happy");
                expected.Equals(actual);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Constructor is Not Found", e.Message);
            }

        }

       /* [Test]
        public void GivenHappyIsInput_ShouldReturnHappy_UsingReflection()
        {
            object expected = "Happy";
            object actual = MoodAnalyser.MoodAnalyseFactory.InvokeMoodAnalyser("Happy", "getMood");
            Assert.AreEqual(expected, actual);
        }*/
        
        [Test]
        public void GivenInvalidPerameterizedConstructor_ReturnClassNotFound()
        {
            try
            {
                object expected = new MoodAnalyser.MoodAnalyser("Happy");
                object actual = MoodAnalyser.MoodAnalyseFactory.createMoodAnalyzerParameter("MoodAnalyser", "MoodAnalyse", "Happy");
                expected.Equals(actual);
            }
            catch (Exception e)
            {
                Assert.AreEqual("Class not found", e.Message);
            }

        }
        [Test]
        public void GivenHappyMoodDynamivRefactorReturnHappy()
        {
            object result = MoodAnalyser.MoodAnalyseFactory.SetField("Happy", "mood");
            Assert.AreEqual("Happy", result);
        }
        [Test]
        public void GivenMoodAnalyseClassName_ShouldreturnClassNotFound_Refactor()
        {
            try
            {
                object result = MoodAnalyser.MoodAnalyseFactory.SetField("Happy", "mood");
                Assert.AreEqual("Happy", result);
            }
            catch (MoodAnalyser.AnalyzerException ex)
            {
                Assert.AreEqual("Field Not Found", ex.Message);
            }
        }
    }
}
