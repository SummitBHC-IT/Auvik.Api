using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Interface statistics resource object
	/// </summary>
	[DataContract]
	public class InterfaceStatisticsResourceObject
	{
		/// <summary>
		/// The type of this resource object
		/// </summary>
		/// <value>The type of this resource object</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum InterfaceStatistics for "interfaceStatistics"
			/// </summary>
			[EnumMember(Value = "interfaceStatistics")]
			InterfaceStatistics
		}

		/// <summary>
		/// The type of this resource object
		/// </summary>
		/// <value>The type of this resource object</value>
		[DataMember(Name="type", EmitDefaultValue=false)]
		public TypeEnum? Type { get; set; }

		/// <summary>
		/// Gets or Sets Attributes
		/// </summary>
		[DataMember(Name="attributes", EmitDefaultValue=false)]
		public StatisticsAttributes Attributes { get; set; }

		/// <summary>
		/// ID for this statistic
		/// </summary>
		/// <value>ID for this statistic</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public InterfaceStatisticsResourceObjectLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets Relationships
		/// </summary>
		[DataMember(Name="relationships", EmitDefaultValue=false)]
		public InterfaceStatisticsRelationships Relationships { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class InterfaceStatisticsResourceObject {\n");
			sb.Append("  Attributes: ").Append(Attributes).Append('\n');
			sb.Append("  Id: ").Append(Id).Append('\n');
			sb.Append("  Links: ").Append(Links).Append('\n');
			sb.Append("  Relationships: ").Append(Relationships).Append('\n');
			sb.Append("  Type: ").Append(Type).Append('\n');
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
