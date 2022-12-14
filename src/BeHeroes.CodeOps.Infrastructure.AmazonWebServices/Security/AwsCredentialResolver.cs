using Amazon.Runtime.CredentialManagement;
using BeHeroes.CodeOps.Infrastructure.AmazonWebServices.Identity;
using Microsoft.Extensions.Options;
using System;

namespace BeHeroes.CodeOps.Infrastructure.AmazonWebServices.Security
{
    public sealed class AwsCredentialResolver : IAwsCredentialResolver
    {
        private readonly CredentialProfileStoreChain _credentialProfileStoreChain;

        public AwsCredentialResolver(IOptions<AwsFacadeOptions> options)
        {
            _credentialProfileStoreChain = new CredentialProfileStoreChain(options.Value.ProfilesLocation);
        }

        public AwsCredentialResolver(string profilesLocation)
        {
            _credentialProfileStoreChain = new CredentialProfileStoreChain(profilesLocation);
        }

        public AwsCredentials Resolve(IAwsProfile profile = default)
        {
            if (string.IsNullOrEmpty(profile?.Name))
            {
                return null;
            }

            if (!_credentialProfileStoreChain.TryGetAWSCredentials(profile?.Name, out var credentialsHandle))
            {
                throw new AwsFacadeException($"Failed to retrieve credentials for profile: {profile?.Name}");
            }

            return (AwsCredentials)credentialsHandle.GetCredentials();
        }
    }
}
