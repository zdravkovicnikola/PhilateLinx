using System;
using System.Runtime.Serialization;

namespace KorisnickiDeo
{
    [Serializable]
    internal class ServerCommunicationException : Exception
    {
        public ServerCommunicationException()
        {
        }

        public ServerCommunicationException(string message) : base(message)
        {
        }

        public ServerCommunicationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ServerCommunicationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}