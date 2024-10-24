The Project is a sample of testing using Selenium with C# NUnit 
The following files are provided
**appSettings.json **: contains parameters that would be shared and used among the project (Here we used the browser type)
**ConfiurationProvided.cs**: It is used to set up the configuration file and handle the data , we used it to read from appSetting.json
**BaseTest.cs**: The base class that contains all shared method that would be used among all test cases , it contains methods like

   - Handling web driver 
   - Scrolling to the bottom of the page
   -  Navigate to specific url
   -  retreive the web page tilte
   -  Setting up and tear down the test cases

**Example.cs** : Contains a test case the passed sucessfully
