using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BeHeroes.CodeOps.Infrastructure.AmazonWebServices.Commands.Identity.Policy
{
    public sealed class DeletePolicyCommand : AwsCommand<Task>
    {
        [JsonPropertyName("policyArn")]
        public string PolicyArn { get; init; }

        public DeletePolicyCommand(string policyArn)
        {
            PolicyArn = policyArn;
        }
    }
}