using PromptCI.Core;
using PromptCI.Core.Models;

namespace PromptCI.Gitlab.Provider;

public class GitlabClient : ISourceControlClient
{
    public Task<IEnumerable<Repository>> GetRepositoriesAsync()
    {
        throw new NotImplementedException();
    }
}
