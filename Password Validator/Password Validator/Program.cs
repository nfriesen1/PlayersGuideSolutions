using Password_Validator;

class Program
{
    static void Main()
    {
        
        while(true)
        {
            Console.WriteLine("Please enter a valid password.");
            Console.WriteLine("To be valid it must be between 6 and 13 characters, contain a lowercase and uppercase letter, and a number");
            Console.WriteLine("It also cannot contain an uppercase 'T' or an ampersand ('&'). ");
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            var passwordValidator = new PasswordValidator(password);
            if(passwordValidator.Validate())
            {
                Console.WriteLine("Successfully created a valid password!");
            } else
            {
                Console.WriteLine("Invalid password.  Please try again");
            }
        }
    }
}