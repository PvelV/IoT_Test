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

        public Message()
        {
            DateTime = DateTime.Now;
            Value = new Random().Next(0, 100);
        }
    }
}
