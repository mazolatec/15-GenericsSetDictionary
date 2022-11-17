using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_HashSetFile.Entities
{
    internal class LogRecords
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }

        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }

        public LogRecords(string userName, DateTime instant)
        {
            UserName = userName;
            Instant = instant;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecords))
            {
                return false;
            }LogRecords logRecords = obj as LogRecords;
            return UserName.Equals(logRecords.UserName);
        }

    }
}
