```markdown
# Regression Tests - Playwright

A robust test automation framework based on **C#**, **Playwright**, and **SpecFlow** designed for regression testing of web applications. This framework supports behavior-driven development (BDD) using SpecFlow and enables efficient test automation for modern web applications.

## 📋 Table of Contents

- [Pre-requisites](#pre-requisites)
- [Installation](#installation)
- [Project Structure](#project-structure)
- [Running Tests](#running-tests)
- [Test Execution Demo](#test-execution-demo)
- [Contributing](#contributing)
- [Contact](#contact)

## 🛠 Pre-requisites

Before you begin, ensure you have the following installed:

- **Visual Studio 2022** (with C# development workload)
- **.NET 6 SDK**
- **Playwright** for .NET
- **NUnit** test framework
- **SpecFlow** for BDD

Ensure that the Playwright CLI is installed globally:

```bash
dotnet tool install --global Microsoft.Playwright.CLI
```

## 📦 Installation

1. **Clone the repository**:
    ```bash
    git clone https://github.com/yogeshgiteSQRepository/regression-tests-playwright.git
    cd regression-tests-playwright
    ```

2. **Install dependencies**:
    All necessary dependencies will be restored when building the project:
    ```bash
    dotnet build
    ```

## 🗂 Project Structure

The project follows a clean, modular structure that makes it easy to scale and maintain.

- **Features**: Contains `.feature` files written in Gherkin language for BDD.
- **StepDefinitions**: Contains C# classes where Gherkin steps are defined.
- **Pages**: Implements the Page Object Model (POM) pattern.
- **Hooks**: Contains setup and teardown hooks for SpecFlow.

## 🚀 Running Tests

To execute the tests, navigate to the root of the project and run the following command:

```bash
dotnet test
```

## 📊 Test Execution Demo

Watch a demo of the test execution:

[![Watch the demo](https://img.youtube.com/vi/your-video-id/hqdefault.jpg)](https://drive.google.com/file/d/1opgj3ZlRk4QeInmWCFxpwioWXeefTEoY/view?usp=sharing)


## 🤝 Contributing

Contributions are welcome! Please follow the [contribution guidelines](CONTRIBUTING.md) and ensure that all code changes include appropriate tests.

## 📞 Contact

For any inquiries, feel free to reach out:

- **Author**: [Yogesh Gite](https://github.com/yogeshgiteSQRepository)
- **Email**: yogeshgite333@gmail.com
