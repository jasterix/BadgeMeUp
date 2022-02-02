﻿namespace BadgeMeUp
{
    public class MockCurrentUser : ICurrentUserInfo
    {
        public Guid GetPrincipalId()
        {
            return Guid.Parse("d4609816-ed54-4942-9fae-2b72c63b73ea");
        }

        public string? GetPrincipalName()
        {
            return "jason@microsoft.com";
        }
    }
}
