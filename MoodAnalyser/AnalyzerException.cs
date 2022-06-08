using System.Runtime.Serialization;

namespace MoodAnalyser
{
    [Serializable]
    public class AnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE
        }
        public ExceptionType Type;
        public AnalyzerException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}