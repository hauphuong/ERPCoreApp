using StdCoreApp.Data.Enums;

namespace StdCoreApp.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}