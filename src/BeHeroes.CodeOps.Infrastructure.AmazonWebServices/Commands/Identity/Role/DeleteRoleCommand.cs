using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace BeHeroes.CodeOps.Infrastructure.AmazonWebServices.Commands.Identity.Role
{
    public sealed class DeleteRoleCommand : AwsCommand<Task>
    {
        [JsonPropertyName("roleName")]
        public string RoleName { get; init; }

        public DeleteRoleCommand(string roleName)
        {
            RoleName = roleName;
        }
    }
}