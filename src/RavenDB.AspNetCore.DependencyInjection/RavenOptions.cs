﻿using Raven.Client.Documents.Conventions;

namespace RavenDB.AspNetCore.DependencyInjection
{
    public class RavenOptions
    {
        public string Url { get; set; }
        public string DefaultDatabase { get; set; }
        public DocumentConventions Conventions { get; set; }
        public string ApiKey { get; set; }
    }
}