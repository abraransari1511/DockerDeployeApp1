using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DockerTestApp1.Model
{
    public sealed class MySettingsConfiguration
    {
        public bool Log { get; set; }
        public string ConnectionStringId { get; set; }
        public Parameters Parameters { get; set; }
    }

    public sealed class Parameters
    {
        public bool IsProduction { get; set; }
        public bool IsDevelopement { get; set; }
        public bool IsStaging { get; set; }
    }
}
