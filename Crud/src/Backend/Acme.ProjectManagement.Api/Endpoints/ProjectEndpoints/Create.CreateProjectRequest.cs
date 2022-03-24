using System.ComponentModel.DataAnnotations;

namespace Acme.ProjectManagement.Api.Endpoints.ProjectEndpoints
{
  public class CreateProjectRequest
  {
    public const string Route = "/Projects";

    [Required]
    public string? Name { get; set; }
  }
}
