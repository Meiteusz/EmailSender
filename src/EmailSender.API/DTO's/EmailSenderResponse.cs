﻿namespace EmailSender.API.DTO_s
{
    public class EmailSenderResponse
    {
        public bool Success { get; set; } = false;
        public string Message { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
    }
}
