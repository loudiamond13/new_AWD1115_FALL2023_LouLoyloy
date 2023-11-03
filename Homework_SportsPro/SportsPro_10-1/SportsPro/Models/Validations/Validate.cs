namespace SportsPro.Models.Validations
{
    public static class Validate
    {
        public static string CheckSelectedTech(Technician technician)
        {
            return (technician?.TechnicianID == null || technician.TechnicianID == 0) ? "Please Select A Technician" : "";
        }
    }
}
