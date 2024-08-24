using System;
using System.Text.Json;

public class GlobalVariables
{
    // Global variable declaration
    public static string baseUrl = "https://miacademy.co/#/";
    public static string mohsUrl = "https://miaprep.com/online-school/";
    public static object BeforeApplication = new
    {
        heading = "MOHS Initial Application",
        index = "1",
        content = "Before applying, take this quiz to find out if MOHS is the right fit for your child.",
        page = "1/4"
    };
    public static object parentInfoPage = new
    {
        heading = "MOHS Initial Application",
        index = "2",
        content = "Parent Information",
        page = "2/4"
    };
    public static string[] mandatoryFieldErrors = new string[]
    {
        "Enter a value for this field.",
        "Enter a value for this field.",
        "Enter a number for this field.",
        "Select a choice.",
        "Choose a date."
    };
    public static object studentInfoPage = new
    {
        heading = "MOHS Initial Application",
        index = "3",
        content = "Student Information",
        page = "3/4"
    };
}
