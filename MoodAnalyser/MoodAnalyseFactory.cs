using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class MoodAnalyseFactory
    {
        public static object CreateMoodAnalyse(string className, string constructorName)
        {
            string pattern = @"." + constructorName + "$";
            Match result = Regex.Match(pattern, className);

            if (result.Success)
            {
                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalysetype = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalysetype);

                }
                catch (ArgumentNullException)
                {
                    throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }

            }
            else
            {
                throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
            }


        }
        public static object createMoodAnalyzerParameter(string ClassName, string ConstructorName, string message)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(ClassName) || type.FullName.Equals(ClassName))
            {
                if (type.Name.Equals(ConstructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_CLASS, "Class not found");
                }
            }
            else
            {
                throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_METHOD, "Constructor is Not Found");
            }

        }
        public static object InvokeMoodAnalyser(string mood, string methodName)
        {
            try
            {
                Type type = Type.GetType("MoodAnalyser.MoodAnalyze");
                object moodAnalyse = MoodAnalyseFactory.createMoodAnalyzerParameter("MoodAnalyser.MoodAnalyze", "MoodAnalyze", "Happy");
                MethodInfo method = type.GetMethod(methodName);
                object chkmood = method.Invoke(moodAnalyse, null);
                return chkmood.ToString();
            }
            catch (NullReferenceException)
            {
                throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_METHOD, "Method is Not Found");
            }

        }
        public static object SetField(string moods, string fieldName)
        {
            try
            {
                MoodAnalyser moodAnalyser = new MoodAnalyser();
                Type type = typeof(MoodAnalyser);
                FieldInfo field = type.GetField(fieldName, BindingFlags.Public | BindingFlags.Instance);
                if (moods == null)
                {
                    throw new AnalyzerException(AnalyzerException.ExceptionType.NULL_MESSAGE, "Mood Should not be null");
                }
                field.SetValue(moodAnalyser, moods);
                return moodAnalyser.mood;
            }
            catch 
            {
                throw new AnalyzerException(AnalyzerException.ExceptionType.NO_SUCH_FIELD, "Field Not Found");
            }
        }

    }
}
