# xtramilesTest

This project contains a set of automated tests for the Computer Database application using Selenium WebDriver and xUnit.

## Prerequisites

* .NET Core 3.1 or later
* Chrome browser installed on the machine
* ChromeDriver executable installed on the machine (see instructions below)

## Installation

1. Copy the MySeleniumProject in your local machine
2. Open the solution in Visual Studio and restore the dependencies packages by running following code
```bash
    dotnet restore
```

## Running the Tests

1. Open the Test Explorer in Visual Studio
2. Run the tests by executing this code in the terminal
```bash
    dotnet test
```

## ChromeDriver Installation

1. Download the ChromeDriver executable from the official ChromeDriver website: https://chromedriver.chromium.org/downloads
2. Extract the executable to a directory on your machine (e.g. `C:\ChromeDriver`)
3. Add the directory to your system's PATH environment variable

## Troubleshooting

* If the tests fail due to a ChromeDriver version mismatch, update the ChromeDriver executable to the latest version
* If the tests fail due to a network issue, check your internet connection and try running the tests again

## License

This project is licensed under the MIT License. See the LICENSE file for details.
