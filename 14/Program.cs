using System;

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance),
//bank name, IBAN, BIC code and 3 credit card numbers associated with the account. Declare the variables needed 
//to keep the information for a single bank account using the appropriate data types and descriptive names.

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Pesho";
            string middleName = "Ivanov";
            string lastName = "Petrov";
            decimal balance = 987654321.321654987m;
            string bankName = "Burkan Bank";
            string iban = "CH9300762011623852957";
            string bicCode = "TBNFFR43PAR";
            ulong firstCard = 0123456789012345;
            ulong secondCard = 5432109876543210;
            ulong thirdCard = 1111222233334444;

        }
    }
}
