using IDS.ComponentModel;
using IDS.Globalization;
using IDS.Portal;
using IDS.Web.UI.WebControls;
using System;

// TODO: Move the following line to the .ppbproj file:
// <ModuleDefinition ID="F59C118D-CAD1-4C6B-A98F-0D38FA7AF59D" FriendlyName="Sample Module" DesktopControl="SampleModule.ascx" Description="" />

namespace PortalPackage
{
    /// <summary>
    /// 
    /// </summary>
    public partial class SampleModule : PortalModuleControl
    {
        #region Component Settings



        #endregion

        /// <inheritdoc />
        public override void LoadLanguageDefaults(System.Globalization.CultureInfo culture)
        {
            base.LoadLanguageDefaults(culture);
            Localizer.CreateFor(this).ApplyResources();
        }

        public static void SampleLegacyCode()
        {
            // Bug: Division by zero
            int x = 5;
            int y = 0;
            int result = x / y; // This will throw a divide by zero exception

            // Code Smell: Using StringBuilder unnecessarily
            string message = "Hello, ";
            message += "world!"; // Using string concatenation is more efficient in this case

            // Vulnerability: SQL Injection
            string userInput = "John";
            string sqlQuery = "SELECT * FROM Users WHERE Name = '" + userInput + "'"; // Vulnerable to SQL injection

            // Security Hotspot: Storing Passwords in Plain Text
            string password = "MySecretPassword";
            Console.WriteLine("Password: " + password); // Storing and displaying passwords in plain text is insecure

            // Bug: Unhandled exception
            int[] numbers = { 1, 2, 3 };
            int index = 5;
            try
            {
                int value = numbers[index]; // Accessing an out-of-bounds index
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Code Smell: Lack of comments and unclear variable names
            int a = 10; // What does 'a' represent?
            int b = 20; // What does 'b' represent?
            int sum = a + b;

            Console.WriteLine("Sum: " + sum);
        }
       public static void SampleLegacyCode2()
        {
            // Bug: Division by zero
            int x = 5;
            int y = 0;
            int result = x / y; // This will throw a divide by zero exception

            // Code Smell: Using StringBuilder unnecessarily
            string message = "Hello, ";
            message += "world!"; // Using string concatenation is more efficient in this case

            // Vulnerability: SQL Injection
            string userInput = "John";
            string sqlQuery = "SELECT * FROM Users WHERE Name = '" + userInput + "'"; // Vulnerable to SQL injection

            // Security Hotspot: Storing Passwords in Plain Text
            string password = "MySecretPassword";
            Console.WriteLine("Password: " + password); // Storing and displaying passwords in plain text is insecure

            // Bug: Unhandled exception
            int[] numbers = { 1, 2, 3 };
            int index = 5;
            try
            {
                int value = numbers[index]; // Accessing an out-of-bounds index
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            // Code Smell: Lack of comments and unclear variable names
            int a = 10; // What does 'a' represent?
            int b = 20; // What does 'b' represent?
            int sum = a + b;

            Console.WriteLine("Sum: " + sum);
        }
    }
}
