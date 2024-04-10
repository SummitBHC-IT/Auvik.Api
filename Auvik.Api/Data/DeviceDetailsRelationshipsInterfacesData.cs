using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// DeviceDetailsRelationshipsInterfacesData
	/// </summary>
	[DataContract]
	public class DeviceDetailsRelationshipsInterfacesData
	{
		/// <summary>
		/// The type of object in the API
		/// </summary>
		/// <value>The type of object in the API</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Interface for "interface"
			/// </summary>
			[EnumMember(Value = "interface")]
			Interface
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
		public DeviceDetailsRelationshipsInterfacesAttributes Attributes { get; set; }

		/// <summary>
		/// The unique identifier for a interface
		/// </summary>
		/// <value>The unique identifier for a interface</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public DeviceDetailsRelationshipsInterfacesLinks Links { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class DeviceDetailsRelationshipsInterfacesData {\n");
			sb.Append("  Attributes: ").Append(Attributes).Append('\n');
			sb.Append("  Id: ").Append(Id).Append('\n');
			sb.Append("  Links: ").Append(Links).Append('\n');
			sb.Append("  Type: ").Append(Type).Append('\n');
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
