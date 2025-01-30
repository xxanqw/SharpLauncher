using CmlLib.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpLauncher
{
    internal class FolderSpecification : MinecraftPath
    {
        public new string Versions { get; set; }  // Shared versions directory
        public string Instances { get; set; } // Root for all instances
        public string InstanceId { get; set; } // Current instance ID

        public FolderSpecification(string launcherPath, string instanceId)
        {
            BasePath = NormalizePath(launcherPath);
            InstanceId = instanceId;

            Instances = NormalizePath(BasePath + "/instances");
            Versions = NormalizePath(BasePath + "/versions"); // Shared versions
            Library = NormalizePath(BasePath + "/libraries");      // Shared libraries
            Resource = NormalizePath(BasePath + "/resources"); // Shared resources
            Runtime = NormalizePath(BasePath + "/runtime");      // Shared Java runtime
            Assets = NormalizePath(BasePath + "/assets");     // Shared assets

            CreateDirs();
        }

        public FolderSpecification(string launcherPath) : this(launcherPath, string.Empty)
        {
        }

        public override string GetVersionJarPath(string id)
            => NormalizePath($"{Versions}/{id}/{id}.jar");

        public override string GetVersionJsonPath(string id)
            => NormalizePath($"{Versions}/{id}/{id}.json");

        public override string GetNativePath(string id)
            => NormalizePath($"{Instances}/{InstanceId}/{id}/natives");

        // Asset paths remain unchanged as assets are shared
        public override string GetIndexFilePath(string assetId)
            => NormalizePath($"{Assets}/indexes/{assetId}.json");

        public override string GetAssetObjectPath(string assetId)
            => NormalizePath($"{Assets}/objects");

        public override string GetAssetLegacyPath(string assetId)
            => NormalizePath($"{Assets}/virtual/legacy");

        public override string GetLogConfigFilePath(string configId)
            => NormalizePath($"{Assets}/log_configs/{configId}" + (configId.EndsWith(".xml") ? "" : ".xml"));

        public string GetDirectoryName(string id)
            => NormalizePath($"{Instances}/{InstanceId}/{id}/");
    }
}