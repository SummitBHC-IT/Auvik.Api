using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Additional attributes and details relating to this network.
	/// </summary>
	[DataContract]
	public class NetworkRelationshipsNetworkDetail
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public NetworkRelationshipsNetworkDetailData Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class NetworkRelationshipsNetworkDetail {\n");
			sb.Append("  Data: ").Append(Data).Append('\n');
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
