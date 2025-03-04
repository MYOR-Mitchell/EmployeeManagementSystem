﻿using EMS.Utilities.Interfaces;
using System.Text.RegularExpressions;

namespace EMS.Utilities
{
    public class InputValidator : IInputValidator
    {
        public bool ValidateSelection(string input, int maxRange, out int validSelection)
        {
            return ParseInt(input, out validSelection) && CheckIntRange(validSelection, maxRange);
        }

        public bool ValidateName(string input)
        {
            return !string.IsNullOrEmpty(input) && !Regex.IsMatch(input, @"[^\w]|[\d\s]");
        }

        public bool ParseInt(string selection, out int validSelection)
        {
            return int.TryParse(selection, out validSelection);
        }

        public bool ParseDateTime(string hireDate, out DateTime validHireDate, string format = "MM/dd/yyyy")
        {
            return DateTime.TryParseExact(hireDate, format, null, System.Globalization.DateTimeStyles.None, out validHireDate);
        }

        public bool CheckIntRange(int checkInt, int maxRange)
        {
            return checkInt > 0 && checkInt <= maxRange;
        }
    }
}
