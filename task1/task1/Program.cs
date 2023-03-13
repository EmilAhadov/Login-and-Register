Console.WriteLine("Welcome to our site. If you want to register press 1. If else you want login press 2.");
int a = Convert.ToInt32(Console.ReadLine());
bool tester = true;
string userName = "";
string password1 = "";
string password2 = "";
string password3 = "";
string userName1 = "";
string[] userNames = {"User1", "User2","User3" };
string[] passwords = { "abcd1234", "abcd1235", "abcd1236" };

if(a==1)
{
    
	do
	{
        Console.WriteLine("Welcome to Register");
        Console.Write("Please enter a Username: ");
        userName = Console.ReadLine();
        userName = userName[0].ToString().ToUpper() + userName.Substring(1);
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

    Array.Resize(ref userNames, userNames.Length+1);
    userNames[userNames.Length-1] = userName;
    Array.Resize(ref passwords, passwords.Length + 1);
    passwords[passwords.Length-1] = password1;
    a = 2;
}
string m = "";
if(a==2)
{
    Console.Clear();
    do
    {
        Console.WriteLine("Welcome to Login");
        Console.Write("Please enter a Username: ");
        userName1 = Console.ReadLine();
        Console.Write("Please enter a password: ");
        password3 = Console.ReadLine();
        for(int i = 0; i < passwords.Length; i++)
        {
            if (userNames[i]!=userName1 || passwords[i]!=password3)
            {
                tester = true;
                
            }
            else { 
                
                tester = false;
                m = userNames[i];
                break;
            }
        }
        if(tester==true)
        {
            Console.WriteLine("User not found try again");
        }
    } while (tester);
    Console.Clear();
    Console.WriteLine("Welcome to main page "+ m);
}
