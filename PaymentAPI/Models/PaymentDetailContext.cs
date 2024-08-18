using Microsoft.EntityFrameworkCore;

namespace PaymentAPI.Models
{
    // In order to inherit the Db Context, we have to install nuget packages of EntityFrameworkCore and EntityFrameworkCore.SqlServer
    public class PaymentDetailContext: DbContext
    {
        // Passing this option to the constructor and the base one too is a syntax that we use in order to use EF.
        // In this options, we have to pass which db we will be using (mysql, sql etc) and also pass the connection string.
        // This we do in program.cs file
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options) { }
        // We need a physical table corresponding to the model that we passed to the DbSet i.e PaymentDetail
        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
