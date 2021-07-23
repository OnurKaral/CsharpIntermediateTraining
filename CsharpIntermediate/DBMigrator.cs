using System;

namespace CsharpIntermediate
{
    public class DBMigratorI
    {
        private readonly ILogger _logger;

        public DBMigratorI(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migrating  started at {0}" + DateTime.Now);
            _logger.LogInfo("Migrating  finished at {0}" + DateTime.Now);
        }
    }
}