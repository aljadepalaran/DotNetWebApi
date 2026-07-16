namespace DotNetWebApi.Post;

public interface IPostRepository
{
    Task<List<Post>> GetAllPostsAsync();
    Task<Post> GetPostByIdAsync(int id);
}