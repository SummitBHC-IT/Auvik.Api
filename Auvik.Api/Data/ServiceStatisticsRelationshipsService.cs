using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// This service the statistics are reported against
	/// </summary>
	[DataContract]
	public class ServiceStatisticsRelationshipsService
	{
		/// <summary>
		/// Gets or Sets Data
		/// </summary>
		[DataMember(Name="data", EmitDefaultValue=false)]
		public ServiceStatisticsRelationshipsServiceData Data { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ServiceStatisticsRelationshipsService {\n");
			sb.Append("  Data: ").Append(Data).Append('\n');
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
