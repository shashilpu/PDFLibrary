using PDFLibrary.Services.SqlServer;

namespace PDFLibrary.Services.Factory
{
    public interface ISQLServerServiceFactory
    {
        ISQLServerService<T> Create<T>() where T : class;
    }
}
