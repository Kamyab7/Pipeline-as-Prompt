Feature: a CI/CD pipeline defined via natural language prompts rather than YAML files

As a developer, I want to define my CI/CD pipeline using natural language prompts so that I can easily create and modify my pipeline without having to write YAML files.

Scenario: User provides a prompt to trigger a CI pipeline without writing YAML

  Given I am on the prompt-based CI/CD web app  
  And I have connected my GitHub account to the platform  
  And I have pushed a file named "ci-pipeline.prompt" to the root of my repository with the content:
    """
    Build my .NET project using Ubuntu and run the build command on the solution file.
    """
  When the platform detects the "ci-pipeline.prompt" file in the repository
  Then it should parse the prompt and execute the described CI pipeline
  And the pipeline should:
    | runner   | ubuntu-latest              |
    | step 1   | checkout                   |
    | step 2   | dotnet build               |
  And I should see the live logs of the CI execution in the web app
