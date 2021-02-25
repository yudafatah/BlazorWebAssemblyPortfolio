namespace Portfolio.ViewModels
{
    public class WorksVM
    {
        public string appName { get; set; } = "";
        public string urlImg { get; set; } = "";
        public string alt { get; set; } = "";
        public int orderNo { get; set; } = 0;
        public string displayName { get; set; } = "";
        public string category { get; set; } = "";
    }

    public class WorkDetVM
    {
        public string AppName { get; set; } = "";
        public string CreatedOn { get; set; } = "";
        public string Stage { get; set; } = "";
        public string Description { get; set; } = "";
        public string Platform { get; set; } = "";
        public string Role { get; set; } = "";
        public string TechStack { get; set; } = "";
    }
}
