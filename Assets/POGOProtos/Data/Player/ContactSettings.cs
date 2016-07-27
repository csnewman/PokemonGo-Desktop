// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ContactSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Player/ContactSettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Player
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Player/ContactSettings.proto</summary>
	public static partial class ContactSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Player/ContactSettings.proto</summary>
		public static pbr.FileDescriptor Descriptor
		{
			get
			{
				return descriptor;
			}
		}

		/// <summary>
		/// The descriptor.
		/// </summary>
		private static pbr.FileDescriptor descriptor;

		/// <summary>
		/// Initializes static members of the <see cref="ContactSettingsReflection"/> class.
		/// </summary>
		static ContactSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CixQT0dPUHJvdG9zL0RhdGEvUGxheWVyL0NvbnRhY3RTZXR0aW5ncy5wcm90",
						"bxIWUE9HT1Byb3Rvcy5EYXRhLlBsYXllciJRCg9Db250YWN0U2V0dGluZ3MS",
						"HQoVc2VuZF9tYXJrZXRpbmdfZW1haWxzGAEgASgIEh8KF3NlbmRfcHVzaF9u",
						"b3RpZmljYXRpb25zGAIgASgIYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Player.ContactSettings),
							global::POGOProtos.Data.Player.ContactSettings.Parser,
							new[] { "SendMarketingEmails", "SendPushNotifications" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The contact settings.
	/// </summary>
	public sealed partial class ContactSettings : pb::IMessage<ContactSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "send_marketing_emails" field.</summary>
		public const int SendMarketingEmailsFieldNumber = 1;

		/// <summary>Field number for the "send_push_notifications" field.</summary>
		public const int SendPushNotificationsFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<ContactSettings> _parser =
			new pb::MessageParser<ContactSettings>(() => new ContactSettings());

		#endregion

		#region  Fields

		/// <summary>
		/// The send marketing emails_.
		/// </summary>
		private bool sendMarketingEmails_;

		/// <summary>
		/// The send push notifications_.
		/// </summary>
		private bool sendPushNotifications_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ContactSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ContactSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ContactSettings(ContactSettings other) : this()
		{
			sendMarketingEmails_ = other.sendMarketingEmails_;
			sendPushNotifications_ = other.sendPushNotifications_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<ContactSettings> Parser
		{
			get
			{
				return _parser;
			}
		}

		/// <summary>
		/// Gets the descriptor.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pbr.MessageDescriptor Descriptor
		{
			get
			{
				return global::POGOProtos.Data.Player.ContactSettingsReflection.Descriptor.MessageTypes[0];
			}
		}

		/// <summary>
		/// Gets the descriptor.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		pbr.MessageDescriptor pb::IMessage.Descriptor
		{
			get
			{
				return Descriptor;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether send marketing emails.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool SendMarketingEmails
		{
			get
			{
				return sendMarketingEmails_;
			}

			set
			{
				sendMarketingEmails_ = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether send push notifications.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool SendPushNotifications
		{
			get
			{
				return sendPushNotifications_;
			}

			set
			{
				sendPushNotifications_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="ContactSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ContactSettings Clone()
		{
			return new ContactSettings(this);
		}

		/// <summary>
		/// The equals.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		/// <returns>
		/// The <see cref="bool"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool Equals(ContactSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (SendMarketingEmails != other.SendMarketingEmails)
			{
				return false;
			}

			if (SendPushNotifications != other.SendPushNotifications)
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// The write to.
		/// </summary>
		/// <param name="output">
		/// The output.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void WriteTo(pb.CodedOutputStream output)
		{
			if (SendMarketingEmails != false)
			{
				output.WriteRawTag(8);
				output.WriteBool(SendMarketingEmails);
			}

			if (SendPushNotifications != false)
			{
				output.WriteRawTag(16);
				output.WriteBool(SendPushNotifications);
			}
		}

		/// <summary>
		/// The calculate size.
		/// </summary>
		/// <returns>
		/// The <see cref="int"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int CalculateSize()
		{
			int size = 0;
			if (SendMarketingEmails != false)
			{
				size += 1 + 1;
			}

			if (SendPushNotifications != false)
			{
				size += 1 + 1;
			}

			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(ContactSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.SendMarketingEmails != false)
			{
				SendMarketingEmails = other.SendMarketingEmails;
			}

			if (other.SendPushNotifications != false)
			{
				SendPushNotifications = other.SendPushNotifications;
			}
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="input">
		/// The input.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(pb.CodedInputStream input)
		{
			uint tag;
			while ((tag = input.ReadTag()) != 0)
			{
				switch (tag)
				{
					default:
						input.SkipLastField();
						break;
					case 8:
					{
						SendMarketingEmails = input.ReadBool();
						break;
					}

					case 16:
					{
						SendPushNotifications = input.ReadBool();
						break;
					}
				}
			}
		}

		#endregion

		#region  Methods - Public

		/// <summary>
		/// The equals.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		/// <returns>
		/// The <see cref="bool"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public override bool Equals(object other)
		{
			return Equals(other as ContactSettings);
		}

		/// <summary>
		/// The get hash code.
		/// </summary>
		/// <returns>
		/// The <see cref="int"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public override int GetHashCode()
		{
			int hash = 1;
			if (SendMarketingEmails != false)
			{
				hash ^= SendMarketingEmails.GetHashCode();
			}

			if (SendPushNotifications != false)
			{
				hash ^= SendPushNotifications.GetHashCode();
			}

			return hash;
		}

		/// <summary>
		/// The to string.
		/// </summary>
		/// <returns>
		/// The <see cref="string"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public override string ToString()
		{
			return pb::JsonFormatter.ToDiagnosticString(this);
		}

		#endregion

		#region  Methods - Private

		/// <summary>
		/// The on construction.
		/// </summary>
		partial void OnConstruction();

		#endregion
	}

	#endregion
}

#endregion Designer generated code