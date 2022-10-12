using Hangfire.MySql;
using Hangfire.SqlServer;

namespace VirtoCommerce.Platform.Hangfire
{
    public class HangfireOptions
    {
        public HangfireJobStorageType JobStorageType { get; set; } = HangfireJobStorageType.Memory;
        public int AutomaticRetryCount { get; set; } = 1;
        public int? WorkerCount { get; set; }
        public bool UseHangfireServer { get; set; } = true;

        public MySqlStorageOptions MySqlStorageOptions { get; set; } = new MySqlStorageOptions();    
    }

    public enum HangfireJobStorageType
    {
        Memory,
        SqlServer,

    }
}
