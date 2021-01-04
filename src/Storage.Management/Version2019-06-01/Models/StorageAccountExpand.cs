// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Profiles.Storage.Version2019_06_01.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StorageAccountExpand.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StorageAccountExpand
    {
        [EnumMember(Value = "geoReplicationStats")]
        GeoReplicationStats,
        [EnumMember(Value = "blobRestoreStatus")]
        BlobRestoreStatus
    }
    internal static class StorageAccountExpandEnumExtension
    {
        internal static string ToSerializedValue(this StorageAccountExpand? value)
        {
            return value == null ? null : ((StorageAccountExpand)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StorageAccountExpand value)
        {
            switch( value )
            {
                case StorageAccountExpand.GeoReplicationStats:
                    return "geoReplicationStats";
                case StorageAccountExpand.BlobRestoreStatus:
                    return "blobRestoreStatus";
            }
            return null;
        }

        internal static StorageAccountExpand? ParseStorageAccountExpand(this string value)
        {
            switch( value )
            {
                case "geoReplicationStats":
                    return StorageAccountExpand.GeoReplicationStats;
                case "blobRestoreStatus":
                    return StorageAccountExpand.BlobRestoreStatus;
            }
            return null;
        }
    }
}
