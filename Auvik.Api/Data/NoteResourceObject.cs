using System.Text;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The template for a resource object representing an Auvik note
	/// </summary>
	[DataContract]
	public class NoteResourceObject
	{
		/// <summary>
		/// The type of object in the API
		/// </summary>
		/// <value>The type of object in the API</value>
		[JsonConverter(typeof(StringEnumConverter))]
		public enum TypeEnum
		{

			/// <summary>
			/// Enum EntityNote for "entityNote"
			/// </summary>
			[EnumMember(Value = "entityNote")]
			EntityNote
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
		public NoteAttributes Attributes { get; set; }

		/// <summary>
		/// The unique identifier for this note
		/// </summary>
		/// <value>The unique identifier for this note</value>
		[DataMember(Name="id", EmitDefaultValue=false)]
		public string Id { get; set; }

		/// <summary>
		/// Gets or Sets Links
		/// </summary>
		[DataMember(Name="links", EmitDefaultValue=false)]
		public NoteResourceObjectLinks Links { get; set; }

		/// <summary>
		/// Gets or Sets Relationships
		/// </summary>
		[DataMember(Name="relationships", EmitDefaultValue=false)]
		public NoteRelationships Relationships { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NoteResourceObject {\n");
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
