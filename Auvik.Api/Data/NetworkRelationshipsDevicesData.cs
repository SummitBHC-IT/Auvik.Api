using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// NetworkRelationshipsDevicesData
	/// </summary>
	[DataContract]
	public class NetworkRelationshipsDevicesData
	{
		/// <summary>
		/// The type of object in the API
		/// </summary>
		/// <value>The type of object in the API</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Device for "device"
			/// </summary>
			[EnumMember(Value = "device")]
			Device
		}

		/// <summary>
		/// The type of object in the API
		/// </summary>
		/// <value>The type of object in the API</value>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name="attributes", EmitDefaultValue=false)]
		public NetworkRelationshipsDevicesAttributes Attributes { get; set; }

		/// <summary>
		/// The unique identifier for a device
		/// </summary>
		/// <value>The unique identifier for a device</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public NetworkRelationshipsDevicesLinks Links { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NetworkRelationshipsDevicesData {\n");
			sb.Append("  Attributes: ").Append(Attributes).Append('\n');
			sb.Append("  Id: ").Append(Id).Append('\n');
			sb.Append("  Links: ").Append(Links).Append('\n');
			sb.Append("  Type: ").Append(Type).Append('\n');
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
