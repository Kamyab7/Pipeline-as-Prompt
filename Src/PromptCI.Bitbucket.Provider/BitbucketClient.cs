using PromptCI.Core;
using PromptCI.Core.Models;

namespace PromptCI.Bitbucket.Provider;

public class BitbucketClient : ISourceControlClient
{
    public Task<IEnumerable<Repository>> GetRepositoriesAsync()
    {
        throw new NotImplementedException();
    }
}
