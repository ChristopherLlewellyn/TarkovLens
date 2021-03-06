﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TarkovLens
{
    public class RavenSettings
    {
        public DatabaseSettings Database { get; set; }
        public class DatabaseSettings
        {
            public string[] Urls { get; set; }
            public string DatabaseName { get; set; }
            public string CertPath { get;set; }
	        public string CertPass { get;set; }
            public string RawCert { get; set; }
            public string RawCertKey { get; set; }
        }
    }
}
