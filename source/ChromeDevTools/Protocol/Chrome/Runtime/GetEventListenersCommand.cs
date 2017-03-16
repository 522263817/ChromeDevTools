using MasterDevs.ChromeDevTools;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MasterDevs.ChromeDevTools.Protocol.Chrome.Runtime
{
	/// <summary>
	/// Returns event listeners of the given object.
	/// </summary>
	[Command(ProtocolName.Runtime.GetEventListeners)]
	[SupportedBy("Chrome")]
	public class GetEventListenersCommand
	{
		/// <summary>
		/// Gets or sets Identifier of the object to return listeners for.
		/// </summary>
		public string ObjectId { get; set; }
		/// <summary>
		/// Gets or sets Symbolic group name for handler value. Handler value is not returned without this parameter specified.
		/// </summary>
		[JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
		public string ObjectGroup { get; set; }
	}
}
