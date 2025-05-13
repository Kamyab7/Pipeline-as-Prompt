using PromptCI.Core;
using PromptCI.Bitbucket.Provider;
using PromptCI.Github.Provider;
using PromptCI.Gitlab.Provider;
using PromptCI.Mock.Provider;

namespace PromptCI.Web.API;

public static class ProviderFactory
{
    public static ISourceControlClient CreateClient(Provider provider)
    {
        return provider switch
        {
            Provider.Github => new GithubClient(),
            Provider.Gitlab => new GitlabClient(),
            Provider.Bitbucket => new BitbucketClient(),
            Provider.Mock => new MockClient(),
            _ => throw new NotSupportedException($"Provider '{provider}' is not supported.")
        };
    }
}
