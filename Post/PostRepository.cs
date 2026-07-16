namespace DotNetWebApi.Post;

public class PostRepository : IPostRepository
{
    public async Task<List<Post>> GetAllPostsAsync()
    {
        var post = new Post
        {
            Id = 1,
            UserId = 1,
            Title = "Title",
            Body = "Body"
        };

        var output = new List<Post>();
        output.Add(post);
        return output;
    }
}