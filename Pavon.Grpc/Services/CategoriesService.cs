using Google.Protobuf.WellKnownTypes;

using Grpc.Core;

namespace Pavon.Grpc.Services;
public class CategoriesService : Categories.CategoriesBase
{
    public override Task<GetCategoriesResponse> GetAllCategoriesAsync(Empty request, ServerCallContext context)
    {
        List<CategoryDto> Dtos = new List<CategoryDto>()
        {
            new CategoryDto() {Name = "aasasas"},
            new CategoryDto() {Name = "aasasas"},
            new CategoryDto() {Name = "aasasas"},
            new CategoryDto() {Name = "aasasas"}
        };
        var response = new GetCategoriesResponse();
        response.Categories.AddRange(Dtos);
        return Task.FromResult(response);
    }
}
