Console.WriteLine("Welcome to our site. If you want to register press r. If else you want login press l.");
char a = Convert.ToChar(Console.ReadLine());
bool tester = true;
string userName = "";
string password1 = "";
string password2 = "";
string userName1 = "";
char Char= 'a';
if(a=='r');
{
	do
	{
        Console.WriteLine("Welcome to Register");
        Console.Write("Please enter a Username: ");
        userName = Console.ReadLine();
        Char= char.ToUpper(userName[0]);
        userName1 = Char + userName.Substring(1);
        Console.Write("Please enter a password: ");
        password1 = Console.ReadLine();
        Console.Write("Please password again: ");
        password2 = Console.ReadLine();
        if (password1 != password2)
        {
            tester = true;
            Console.WriteLine("Password is incorrect");

            
        }
        else if (password1.Length < 8)
        {
            tester = true;
            Console.WriteLine("Password's lenght is less than 8. Please try again");
            
        }
        else
            tester = false;

    } while (tester);
    a = 'l';
}

if(a=='l')
{
    Console.Clear();
    do
    {
        Console.WriteLine("Welcome to Login");
        Console.Write("Please enter a Username: ");
        string userName2 = Console.ReadLine();
        Console.Write("Please enter a password: ");
        string password3 = Console.ReadLine();
        if (userName2 != userName1 || password3 != password1)
        {
            tester=true;
            Console.WriteLine("Password or Username is incorrect. Please try again");
            
        }
        else { tester = false; }

    } while (tester);
}