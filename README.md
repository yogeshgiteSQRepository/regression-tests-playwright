# 📚 regression-tests-playwright

🎭 **Playwright | C# | Specflow**

## ⚙️ Pre-requisites

Install the following programs on top of VS2022:

- 🖥️ **C#**
- 🛠️ **.Net 6**
- 🎭 **Playwright**
- 🧪 **NUnit**
- 📄 **Specflow**

## 🚀 How to run tests

1. Clone the repository 📂
2. In the root folder, run the command: **dotnet test** 🏃

## 📁 Folder Structure

- `🗂️ Features`: Contains the feature files that describe the test cases in Gherkin language.
- `🗂️ StepDefinitions`: Houses the step definition files where the test steps are implemented.
- `🗂️ Pages`: Includes page object classes representing different pages of the application.
- `🗂️ Hooks`: Contains the setup and teardown methods that run before and after test execution.
- `🗂️ Drivers`: Holds the WebDriver configurations for Playwright.
- `🗂️ Utilities`: Includes utility classes for common functions and configurations.

## 🆕 How to add new tests

1. Create a new `.feature` file under the `Features` directory.
2. Implement the steps in the corresponding step definition file in the `StepDefinitions` directory.
3. Create or update the page objects in the `Pages` directory as needed.

## 📊 Reporting

Test results are generated in the default Playwright format. You can also integrate with third-party reporting tools for enhanced reporting.

## 🔄 CI/CD Integration

This framework can be integrated with CI/CD pipelines using tools like Jenkins, GitHub Actions, or Azure DevOps. Update the pipeline configuration to run the tests using the `dotnet test` command.

## 🎥 Test Execution Demo

[📥 Download or Watch Video](https://drive.google.com/file/d/1opgj3ZlRk4QeInmWCFxpwioWXeefTEoY/view?usp=sharing)
