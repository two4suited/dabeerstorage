using Amazon.CDK;
using System;
using System.Collections.Generic;
using System.Linq;

namespace dabeerstorage.Infrastructure
{
    sealed class Program
    {
        public static void Main(string[] args)
        {
            var app = new App();
            new InfrastructureStack(app, "dabeerstorage");
            app.Synth();
        }
    }
}
