using System;

namespace MultiBracket_Validation
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static bool MultiBracketValidation(string input)
        {
            int counter = 0;
            string[] bracketHolder = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                if(Convert.ToString(input[i]) == "[" || Convert.ToString(input[i]) == "(" || Convert.ToString(input[i]) == "{")
                {
                    bracketHolder[counter] = Convert.ToString(input[i]);
                    counter++;
                }
                if(Convert.ToString(input[i]) == "]")
                {
                    if(bracketHolder[counter - 1] == "[")
                    {
                        counter--;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (Convert.ToString(input[i]) == ")")
                {
                    if (bracketHolder[counter - 1] == "(")
                    {
                        counter--;
                    }
                    else
                    {
                        return false;
                    }
                }
                if (Convert.ToString(input[i]) == "}")
                {
                    if (bracketHolder[counter - 1] == "{")
                    {
                        counter--;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            if(counter == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
