using Microsoft.SqlServer.Server;
using SportsPro.Repositories;
using System.Numerics;
using System.Text.RegularExpressions;

namespace SportsPro.Models.Validations
{
    public static class Validate
    {

        public static string CheckIfEmailExists(SportsProContext context, string email)
        {
            string message  = string.Empty;

            if (!string.IsNullOrEmpty(email)) 
            {
                //checks if anyone has the same email 
                var customer = context.Customers.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());

                //if var customer is not emtpy, let the user know that the email is used.
                // customers can't have the same email
                if (customer != null) 
                {
                    message = "Email Address Is Already In Use.";
                }

            }
            return message;
        }


       

        //public static string CheckPhoneFormat(string checkFormat)
        //{
        //    string format = @"\d{3}-\d{3}-\d{4}";
        //    string message = string.Empty;
        //    if (string.IsNullOrEmpty(checkFormat) || Regex.IsMatch(checkFormat, format))
        //    {
        //        message = "";
        //    }
        //    else 
        //    {
        //        message = "Phone Number Must Be In 000-000-0000 Format.";
        //    }

        //    return message;
        //}
    }
}
