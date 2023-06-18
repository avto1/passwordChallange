using System.Text.RegularExpressions;

string password = Console.ReadLine();

Console.WriteLine(Result(password));

string Result(string password)
{
    bool hasUpperCase = Regex.IsMatch(password, "[A -Z]");
    bool hasLowerCase = Regex.IsMatch(password, "[a - z]");
    bool hasNumber = Regex.IsMatch(password, "[0*]");
    if(hasUpperCase && hasLowerCase && hasNumber)
    {
        return password;
    }
    else { password = Console.ReadLine(); }
    return "";
}

