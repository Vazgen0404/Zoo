using System;

namespace Zoo
{
    class MyException : Exception
    {
        public MessageType MessageType { get; set; }
        public MyException(string message, MessageType messageType) : base(message)
        {
            MessageType = messageType;
        }
    }
}
