namespace PRN221.Team5.Domain.Common
{
    public class AppConfig
    {
        public static ConnectionStrings ConnectionStrings { get; set; } = new ConnectionStrings();
    }

    public class  ConnectionStrings
    {
        public string DefaultConnection { get; set; } = "Server=localhost,1433;Database=MyStore;User Id=sa;Password=12345;Trusted_Connection=True;TrustServerCertificate=True;";
    }
}
