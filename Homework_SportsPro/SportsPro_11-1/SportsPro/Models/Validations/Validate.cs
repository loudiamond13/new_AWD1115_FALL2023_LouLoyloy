using Microsoft.SqlServer.Server;
using System.Numerics;
using System.Text.RegularExpressions;

namespace SportsPro.Models.Validations
{
    public static class Validate
    {
        
        public static string CheckSelectedTech(Technician technician)
        {
            return (technician?.TechnicianID == null || technician.TechnicianID == 0) ? "Please Select A Technician" : "";
        }


       

        public static string CheckPhoneFormat(string checkFormat)
        {
            string format = @"\d{3}-\d{3}-\d{4}";
            string message = string.Empty;
            if (string.IsNullOrEmpty(checkFormat) || Regex.IsMatch(checkFormat, format))
            {
                message = "";
            }
            else 
            {
                message = "Phone Number Must Be In 000-000-0000 Format.";
            }

            return message;
        }
    }
}
