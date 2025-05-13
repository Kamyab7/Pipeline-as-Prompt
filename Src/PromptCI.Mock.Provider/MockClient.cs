using PromptCI.Core;
using PromptCI.Core.Models;

namespace PromptCI.Mock.Provider;

public class MockClient : ISourceControlClient
{
    public Task<IEnumerable<Repository>> GetRepositoriesAsync()
    {
        return Task.FromResult<IEnumerable<Repository>>(new List<Repository>
        {
            new Repository
            {
                Id = 1,
                Name = "MockRepo1",
                Private = true
            },
            new Repository
            {
                Id = 2,
                Name = "MockRepo2",
                Private = false
            }
        });
    }
}
