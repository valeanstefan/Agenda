namespace Agenda.Domain.Models
{
    public interface IConnectionFactory
    {
        string ConnectionString { get; }
    }
}