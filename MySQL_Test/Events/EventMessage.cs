﻿namespace MySQL_Test.Events
{
    public class EventMessage
    {
        /// <summary>
        /// Test
        /// </summary>
        public string Message { get; set; }
        public EventMessage(string message)
        {
            Message = message;
        }
    }
}
