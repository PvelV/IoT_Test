using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Message
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Value { get; set; }

        public Message(DateTime dateTime, int value)
        {
            DateTime = dateTime;
            Value = value;

        }

        public Message()
        {

        }
    }
}
