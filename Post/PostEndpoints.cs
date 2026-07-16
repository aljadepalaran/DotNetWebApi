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

    private static async Task<IResult> HandleGetAllPostsAsync(IPostRepository repo)
    {
        var allPosts = await repo.GetAllPostsAsync();
        return Results.Ok(allPosts);
    }

    private static async Task<IResult> HandleGetPostAsync(int id, IPostRepository repo)
    {
        var post = await repo.GetPostByIdAsync(id);
        return (post == null) ? Results.NotFound() : Results.Ok(post);
    }
}