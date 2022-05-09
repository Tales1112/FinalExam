int passwordLength = 0;
char characters;
string validChars = String.Empty;

Console.WriteLine("Enter the password length");
passwordLength = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Would you like to use special characters in your password (Y/N)");
characters = Convert.ToChar(Console.ReadLine());

if(characters == 'Y')
    validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*?_-";
else
    validChars = "ABCDEFGHJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

Random Random = new Random();

char[] chars = new char[passwordLength];

for (int i = 0; i < chars.Length; i++)
{
    chars[i] = validChars[Random.Next(0,validChars.Length)];
}

Console.WriteLine(new String(chars));