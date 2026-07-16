namespace DotNetWebApi.Post;

public static class PostEndpoint
{
    public static void MapPostEndpoints(this WebApplication app)
    {
        app.MapGet("/posts", HandleGetAllPostsAsync)
            .WithName("GetAllPosts");
    }

    private static async Task<List<Post>> HandleGetAllPostsAsync(IPostRepository repo)
    {
        return await repo.GetAllPostsAsync();
        // do nothing
    }
}