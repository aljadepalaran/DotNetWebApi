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

    public async Task<Post> GetPostByIdAsync(int id)
    {
        var post = new Post
        {
            Id = id,
            UserId = 123,
            Title = "GetPostByIdAsync",
            Body = "This is a post fetched by ID"
        };

        return post;
    }
}