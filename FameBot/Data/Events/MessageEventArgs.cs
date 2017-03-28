﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FameBot.Data.Events
{
    public class MessageEventArgs : EventArgs
    {
        private string message;
        private string author;
        private DateTime timestamp;

        public string Message
        {
            get { return message; }
        }
        public string Author
        {
            get { return author; }
        }
        public DateTime Timestamp
        {
            get { return timestamp; }
        }
        public string TimestampString
        {
            get { return ("[" + timestamp.ToString("HH:mm:ss") + "]"); }
        }

        public string FullMessage
        {
            get { return (TimestampString + " " + author + ": " + message); }
        }

        public MessageEventArgs(string message, string author)
        {
            this.message = message;
            this.author = author;
            timestamp = DateTime.Now;
        }
    }
}
