using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// The parent tenant container object of the tenant selected
	/// </summary>
	[DataContract]
	public class TenantDetailResourceObjectRelationshipsParent
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public TenantDetailResourceObjectRelationshipsParentData Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class TenantDetailResourceObjectRelationshipsParent {\n");
			sb.Append("  Data: ").Append(Data).Append('\n');
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
