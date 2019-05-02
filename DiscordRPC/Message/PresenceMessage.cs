﻿

namespace DiscordRPC.Message
{
	/// <summary>
	/// Representation of the message received by discord when the presence has been updated.
	/// </summary>
	public class PresenceMessage : MessageBase
	{
        /// <summary>
        /// The type of message received from discord
        /// </summary>
        public override MessageType Type => MessageType.PresenceUpdate;

        internal PresenceMessage() : this(null) { }
		internal PresenceMessage(RichPresenceResponse rpr)
		{
			if (rpr == null)
			{
				Presence = null;
				Name = "No Rich Presence";
				ApplicationID = "";
			}
			else
			{
				Presence = (RichPresence)rpr;
				Name = rpr.Name;
				ApplicationID = rpr.ClientID;
			}
		}

		/// <summary>
		/// The rich presence Discord has set
		/// </summary>
		public RichPresence Presence { get; internal set; }

		/// <summary>
		/// The name of the application Discord has set it for
		/// </summary>
		public string Name { get; internal set; }

		/// <summary>
		/// The ID of the application discord has set it for
		/// </summary>
		public string ApplicationID { get; internal set; }
	}
}
