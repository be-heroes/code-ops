using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BeHeroes.CodeOps.Infrastructure.AmazonWebServices.Commands.Identity.Role
{
    public sealed class UpdateRoleCommand : AwsCommand<Task>
    {
        [JsonPropertyName("roleName")]
        public string RoleName { get; init; }

        [JsonPropertyName("description")]
        public string Description { get; init; }

        public UpdateRoleCommand(string roleName, string description = default)
        {
            RoleName = roleName;
            Description = description;
        }
    }
}