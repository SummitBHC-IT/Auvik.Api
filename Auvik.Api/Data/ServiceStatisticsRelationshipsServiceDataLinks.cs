using System.Text;
using System.Runtime.Serialization;

namespace Auvik.Api.Data
{
	/// <summary>
	/// Links relating to this service
	/// </summary>
	[DataContract]
	public class ServiceStatisticsRelationshipsServiceDataLinks
	{
		/// <summary>
		/// Link to this service's dashboard in Auvik
		/// </summary>
		/// <value>Link to this service's dashboard in Auvik</value>
		[DataMember(Name="dashboard", EmitDefaultValue=false)]
		public string Dashboard { get; set; }

		/// <summary>
		/// Returns the string presentation of the object
		/// </summary>
		/// <returns>String presentation of the object</returns>
		public override string ToString()
		{
			var sb = new StringBuilder();
			sb.Append("class ServiceStatisticsRelationshipsServiceDataLinks {\n");
			sb.Append("  Dashboard: ").Append(Dashboard).Append('\n');
			sb.Append("}\n");
			return sb.ToString();
		}
	}
}
