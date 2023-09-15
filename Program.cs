using System.Runtime.InteropServices;

string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

CreateEmail(corporate, externalDomain);
CreateEmail(external, externalDomain);

void CreateEmail(string[,] employees, string Domain)
{
    for (int i = 0; i < employees.GetLength(0); i++)
    {
        string firstTwoLetter = employees[i, 0].Substring(0, 2).ToLower();
        Console.WriteLine(firstTwoLetter + employees[i, 1].ToLower() + "@" + Domain);
    }
}
