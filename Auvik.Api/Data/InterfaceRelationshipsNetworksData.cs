using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// InterfaceRelationshipsNetworksData
	/// </summary>
	[DataContract]
	public class InterfaceRelationshipsNetworksData
	{
		/// <summary>
		/// The type of the object
		/// </summary>
		/// <value>The type of the object</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum Network for "network"
			/// </summary>
			[EnumMember(Value = "network")]
			Network
		}

		/// <summary>
		/// The type of the object
		/// </summary>
		/// <value>The type of the object</value>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name="attributes", EmitDefaultValue=false)]
		public DeviceRelationshipsNetworksAttributes Attributes { get; set; }

		/// <summary>
		/// The unique identifier for this network
		/// </summary>
		/// <value>The unique identifier for this network</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public InterfaceRelationshipsNetworksLinks Links { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InterfaceRelationshipsNetworksData {\n");
			sb.Append("  Attributes: ").Append(Attributes).Append('\n');
			sb.Append("  Id: ").Append(Id).Append('\n');
			sb.Append("  Links: ").Append(Links).Append('\n');
			sb.Append("  Type: ").Append(Type).Append('\n');
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
