﻿namespace IntegrationTest.Configuration
{
    public class SlackConfig
    {
        public string UserAuthToken { get; set; }
        public string BotAuthToken { get; set; }
        public string TestChannel { get; set; }
        public string DirectMessageUser { get; set; }
        public string AuthCode { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
    }
}