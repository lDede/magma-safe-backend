﻿namespace MagmaSafe.Shared.Models
{
    public class ErrorMessage
    {
        public string Code { get; set; }
        public string Message { get; set; }

        public ErrorMessage() {}

        public ErrorMessage(string code, string message)
        {
            Code = code;
            Message = message;
        }
    }
}
