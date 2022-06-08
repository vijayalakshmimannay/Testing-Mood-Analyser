using System.Runtime.Serialization;

namespace MoodAnalyser
{
    [Serializable]
    public class AnalyzerException : Exception
    {
        public enum ExceptionType
        {
            NULL_MESSAGE, EMPTY_MESSAGE,
            NO_SUCH_CLASS,
            NO_SUCH_METHOD
        }
        public ExceptionType Type;
        public AnalyzerException(ExceptionType type, string message) : base(message)
        {
            this.Type = type;
        }
    }
}