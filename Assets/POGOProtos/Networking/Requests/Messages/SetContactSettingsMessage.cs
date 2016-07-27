// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetContactSettingsMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/SetContactSettingsMessage.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data.Player;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Requests.Messages
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/SetContactSettingsMessage.proto</summary>
	public static partial class SetContactSettingsMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/SetContactSettingsMessage.proto</summary>
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
		/// Initializes static members of the <see cref="SetContactSettingsMessageReflection"/> class.
		/// </summary>
		static SetContactSettingsMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvU2V0",
						"Q29udGFjdFNldHRpbmdzTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3",
						"b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzGixQT0dPUHJvdG9zL0RhdGEvUGxh",
						"eWVyL0NvbnRhY3RTZXR0aW5ncy5wcm90byJeChlTZXRDb250YWN0U2V0dGlu",
						"Z3NNZXNzYWdlEkEKEGNvbnRhY3Rfc2V0dGluZ3MYASABKAsyJy5QT0dPUHJv",
						"dG9zLkRhdGEuUGxheWVyLkNvbnRhY3RTZXR0aW5nc2IGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.Player.ContactSettingsReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.SetContactSettingsMessage),
							global::POGOProtos.Networking.Requests.Messages.SetContactSettingsMessage.Parser,
							new[] { "ContactSettings" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The set contact settings message.
	/// </summary>
	public sealed partial class SetContactSettingsMessage : pb::IMessage<SetContactSettingsMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "contact_settings" field.</summary>
		public const int ContactSettingsFieldNumber = 1;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<SetContactSettingsMessage> _parser =
			new pb::MessageParser<SetContactSettingsMessage>(() => new SetContactSettingsMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The contact settings_.
		/// </summary>
		private ContactSettings contactSettings_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="SetContactSettingsMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetContactSettingsMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SetContactSettingsMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetContactSettingsMessage(SetContactSettingsMessage other) : this()
		{
			ContactSettings = other.contactSettings_ != null ? other.ContactSettings.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<SetContactSettingsMessage> Parser
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
				return
					global::POGOProtos.Networking.Requests.Messages.SetContactSettingsMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the contact settings.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ContactSettings ContactSettings
		{
			get
			{
				return contactSettings_;
			}

			set
			{
				contactSettings_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="SetContactSettingsMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetContactSettingsMessage Clone()
		{
			return new SetContactSettingsMessage(this);
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
		public bool Equals(SetContactSettingsMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!object.Equals(ContactSettings, other.ContactSettings))
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
			if (contactSettings_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(ContactSettings);
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
			if (contactSettings_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContactSettings);
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
		public void MergeFrom(SetContactSettingsMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.contactSettings_ != null)
			{
				if (contactSettings_ == null)
				{
					contactSettings_ = new global::POGOProtos.Data.Player.ContactSettings();
				}

				ContactSettings.MergeFrom(other.ContactSettings);
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
					case 10:
					{
						if (contactSettings_ == null)
						{
							contactSettings_ = new global::POGOProtos.Data.Player.ContactSettings();
						}

						input.ReadMessage(contactSettings_);
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
			return Equals(other as SetContactSettingsMessage);
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
			if (contactSettings_ != null)
			{
				hash ^= ContactSettings.GetHashCode();
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