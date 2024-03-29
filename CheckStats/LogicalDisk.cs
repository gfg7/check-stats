﻿using System.Web.Script.Serialization;

namespace CheckStats
{
    internal class LogicalDisk
    {
        private string name;

        public string Name { get => name; set => name = value.Contains(":") ? value.Substring(0, value.Length-1) : value; }
        [ScriptIgnore]
        public uint DriveType { get; set; }
        public string Type
        {
            get
            {
                switch (DriveType)
                {
                    case 0:
                        return "Unknown";

                    case 1:
                        return "No Root Directory";

                    case 2:
                        return "Removable Disk";

                    case 3:
                        return "Local Disk";

                    case 4:
                        return "Network Drive";

                    case 5:
                        return "Compact Disc";

                    case 6:
                        return "RAM Disk";
                    default: return null;

                }
            }
        }
        public string FileSystem { get; set; }
        public ulong Size { get; set; }
        public ulong FreeSpace { get; set; }
        public string HealthStatus { get; set; }
    }
}
