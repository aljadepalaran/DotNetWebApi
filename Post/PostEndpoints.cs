namespace DotNetWebApi.Post;

public static class PostEndpoint
{
    public static void MapPostEndpoints(this WebApplication app)
    {
        var postGroup = app.MapGroup("/posts").WithTags("Posts");

        postGroup.MapGet("/", HandleGetAllPostsAsync)
            .WithName("GetAllPosts");

        postGroup.MapGet("/{id:int}", HandleGetPostAsync)
            .WithName("GetPostById");
    }

    private static async Task<List<Post>> HandleGetAllPostsAsync(IPostRepository repo)
    {
        return await repo.GetAllPostsAsync();
    }

    private static async Task<Post> HandleGetPostAsync(int id, IPostRepository repo)
    {
        return await repo.GetPostByIdAsync(id);
    }
}