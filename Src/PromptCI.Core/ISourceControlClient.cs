using PromptCI.Core.Models;

namespace PromptCI.Core;

public interface ISourceControlClient
{
    Task<IEnumerable<Repository>> GetRepositoriesAsync();
}
