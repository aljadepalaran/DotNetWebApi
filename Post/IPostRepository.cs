namespace DotNetWebApi.Post;

public interface IPostRepository
{
    Task<List<Post>> GetAllPostsAsync();
}