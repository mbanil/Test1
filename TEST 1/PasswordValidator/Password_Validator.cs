using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    class Password_Validator
    {
        public bool Verify(string pswd, string type)
        {
            if(type == "ex")
            {
                ExternalPassword externalPass = new ExternalPassword();
                return externalPass.Verify1(pswd);
            }            
            else if (type == "in")
            {
                InternalPassword interPass = new InternalPassword();
                return interPass.Verify2(pswd);
            }
            return false;
        }
    }

    class ExternalPassword:Password_Validator
    {
        int condition = 0;
        int condition2 = 0;
        string str1 = "";
        string str2 = "";
        string str3 = "";
        string str4 = "";
        string str5 = "";

        public bool Verify1(string pswd)
        {
            if (!NotNull(pswd))
            {
                String.Concat(str1,"The Password cant be null");
            }
            if (!GreaterThanEight(pswd))
            {
                String.Concat(str2, "The Password cant have less than 8 chars");
            }
            if (!HasUpperCase(pswd))
            {
                String.Concat(str3, "The Password should have one UpperCase");
            }
            if (!HasLowerCase(pswd))
            {
                String.Concat(str4, "The Password should have one LowerCase");
            }
            if (!HasDigit(pswd))
            {
                String.Concat(str5, "The Password should have one Digit");
            }

            if (NotNull(pswd))
            {
                if (GreaterThanEight(pswd))
                {
                    condition++;
                }
                if (HasUpperCase(pswd))
                {
                    condition2 = 1;
                    condition++;
                }
                if (HasLowerCase(pswd))
                {
                    condition++;
                }
                if (HasDigit(pswd))
                {
                    condition++;
                }

            }

            if (condition > 1)
                return true;

            if (condition2 == 1)
                return true;

                
            if (!NotNull(pswd) || !GreaterThanEight(pswd) || !HasUpperCase(pswd) || !HasLowerCase(pswd) || !HasDigit(pswd))
                throw new InvalidProgramException(str1+"\n"+str2+"\n"+str3+"\n"+str4+"\n"+str5);

            return false;

        }

        public static bool NotNull(string pswd)
        {
            if (pswd.Length > 0)
                return true;
            return false;
        }

        public static bool GreaterThanEight(string pswd)
        {
            if (pswd.Length > 8)
                return true;
            return false;
        }

        public static bool HasUpperCase(string pswd)
        {
            for (int i = 0; i < pswd.Length; i++)
            {
                if (char.IsUpper(pswd[i]))
                    return true;
            }
            return false;
        }

        public static bool HasLowerCase(string pswd)
        {
            for (int i = 0; i < pswd.Length; i++)
            {
                if (char.IsLower(pswd[i]))
                    return true;
            }
            return false;
        }

        public static bool HasDigit(string pswd)
        {
            for (int i = 0; i < pswd.Length; i++)
            {
                if (char.IsDigit(pswd[i]))
                    return true;
            }
            return false;
        }
    }

    class InternalPassword:Password_Validator
    {
        public bool Verify2(string pswd)
        {
            if (pswd.Length >8)
                return true;
            return false;
        }
    }
}

            

              
 
