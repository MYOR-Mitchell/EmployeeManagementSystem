using EMS.Utilities.Interfaces;

namespace EMS.Utilities
{
    public class InputPrompter : IInputPrompter
    {
        private readonly IInputValidator _inputValidation;

        public InputPrompter(IInputValidator inputValidator)
        {
            _inputValidation = inputValidator;
        }


        public int GetValidSelection(int maxRange)
        {
            Console.WriteLine("Please enter your selection.");
            while (true)
            {
                string input = Console.ReadLine();
                if (_inputValidation.ValidateSelection(input, maxRange, out int validSelection))
                {
                    return validSelection;
                }
                Console.WriteLine("Invalid input. Please, try again.");
            }
        }

        public string GetValidName(string prompt = "")
        {
            Console.WriteLine(prompt);
            while (true)
            {
                string input = Console.ReadLine();
                if (_inputValidation.ValidateName(input))
                {
                    return input;
                }
                Console.WriteLine("Invalid input. Please, try again.");
            }
        }

        public DateTime GetValidHireDate(string prompt = "")
        {
            Console.WriteLine(prompt);
            while (true)
            {
                string input = Console.ReadLine();
                if (_inputValidation.ParseDateTime(input, out DateTime validHireDate))
                {
                    return validHireDate;
                }
                Console.WriteLine("Invalid input. Please, try again.");
            }
        }

        public int GetValidId(string prompt = "")
        {
            int validId;

            while (true)
            {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();

                if (_inputValidation.ParseInt(input, out validId) && validId > 0)
                {
                    return validId;
                }

                Console.WriteLine("Invalid input. Please, try again.");
            }
        }

    }
}
