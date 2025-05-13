using PromptCI.Core;
using PromptCI.Core.Models;

namespace PromptCI.Github.Provider;

public class GithubClient : ISourceControlClient
{
    public Task<IEnumerable<Repository>> GetRepositoriesAsync()
    {
        throw new NotImplementedException();
    }
}
