using Microsoft.Extensions.Configuration;

public interface Isatya
{
    void readvalues();
}

public class SatYa : Isatya
{
    private IConfiguration _config;

    public SatYa(IConfiguration dd)
    {
        _config = dd;
    }
    public void readvalues()
    {
        string? h = _config.GetConnectionString("Sqlite")!;
        Console.WriteLine(_config.GetConnectionString("Sqlite"));
    }
}