namespace Acme.ProjectManagement.Api.Endpoints.ProjectEndpoints
{
  public class ProjectListResponse
  {
    public List<ProjectRecord> Projects { get; set; } = new();
  }
}