using System.Data.SqlClient;

namespace AKKDotNetCore.RestApiWithNLayer;
internal static class ConnectionStrings
{
    public static SqlConnectionStringBuilder SqlConnectionStringBuilder = new SqlConnectionStringBuilder()
    {
        DataSource = "Aung-Khant-Kyaw\\AUNGKHANT",
        InitialCatalog = "DotNetTrainingBatch4",
        UserID = "sa",
        Password = "sasa@123",
        TrustServerCertificate = true,
    };
}

