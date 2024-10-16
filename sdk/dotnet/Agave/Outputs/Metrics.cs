// *** WARNING: this file was generated by pulumi. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace ABKLabs.Svmkit.Agave.Outputs
{

    [OutputType]
    public sealed class Metrics
    {
        public readonly string Database;
        public readonly string Password;
        public readonly string Url;
        public readonly string User;

        [OutputConstructor]
        private Metrics(
            string database,

            string password,

            string url,

            string user)
        {
            Database = database;
            Password = password;
            Url = url;
            User = user;
        }
    }
}
