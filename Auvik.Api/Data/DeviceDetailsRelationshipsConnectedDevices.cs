using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Auvik.Api.Data
{
	/// <summary>
	/// List of other devices connected to this device
	/// </summary>
	[DataContract]
	public class DeviceDetailsRelationshipsConnectedDevices
	{
		/// <summary>
		/// A connected device resource object
		/// </summary>
		/// <value>A connected device resource object</value>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public List<DeviceDetailsRelationshipsConnectedDevicesData> Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsRelationshipsConnectedDevices {\n");
			sb.Append("  Data: ").Append(Data).Append('\n');
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
