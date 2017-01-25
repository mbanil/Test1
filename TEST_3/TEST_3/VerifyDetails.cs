using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_3
{
    public class VerifyDetails
    {


        public bool Verify(string firstName, string lastName, string emailID)
        {
            string str = "";
            string str1 = "";
            string str2 = "";
            if (string.IsNullOrEmpty(firstName))
                str += "The First Name should not be null.";
            if (string.IsNullOrEmpty(lastName))
                str1 += "The Last Name should not be null.";
            if (!IsValidEmail(emailID))
                str2 += "The Email should be valid.";
            if (str != "" || str1 != "" || str2 != "")
                throw new InvalidProgramException(str + str1 + str2);
            return true;
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
