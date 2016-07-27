// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MarkTutorialCompleteMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/MarkTutorialCompleteMessage.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Requests.Messages
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/MarkTutorialCompleteMessage.proto</summary>
	public static partial class MarkTutorialCompleteMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/MarkTutorialCompleteMessage.proto</summary>
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
		/// Initializes static members of the <see cref="MarkTutorialCompleteMessageReflection"/> class.
		/// </summary>
		static MarkTutorialCompleteMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CklQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvTWFy",
						"a1R1dG9yaWFsQ29tcGxldGVNZXNzYWdlLnByb3RvEidQT0dPUHJvdG9zLk5l",
						"dHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMaJFBPR09Qcm90b3MvRW51bXMv",
						"VHV0b3JpYWxTdGF0ZS5wcm90byKbAQobTWFya1R1dG9yaWFsQ29tcGxldGVN",
						"ZXNzYWdlEjwKE3R1dG9yaWFsc19jb21wbGV0ZWQYASADKA4yHy5QT0dPUHJv",
						"dG9zLkVudW1zLlR1dG9yaWFsU3RhdGUSHQoVc2VuZF9tYXJrZXRpbmdfZW1h",
						"aWxzGAIgASgIEh8KF3NlbmRfcHVzaF9ub3RpZmljYXRpb25zGAMgASgIYgZw",
						"cm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.TutorialStateReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.MarkTutorialCompleteMessage),
							global::POGOProtos.Networking.Requests.Messages.MarkTutorialCompleteMessage.Parser,
							new[] { "TutorialsCompleted", "SendMarketingEmails", "SendPushNotifications" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The mark tutorial complete message.
	/// </summary>
	public sealed partial class MarkTutorialCompleteMessage : pb::IMessage<MarkTutorialCompleteMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "tutorials_completed" field.</summary>
		public const int TutorialsCompletedFieldNumber = 1;

		/// <summary>Field number for the "send_marketing_emails" field.</summary>
		public const int SendMarketingEmailsFieldNumber = 2;

		/// <summary>Field number for the "send_push_notifications" field.</summary>
		public const int SendPushNotificationsFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<MarkTutorialCompleteMessage> _parser =
			new pb::MessageParser<MarkTutorialCompleteMessage>(() => new MarkTutorialCompleteMessage());

		/// <summary>
		/// The _repeated_tutorials completed_codec.
		/// </summary>
		private static readonly pb.FieldCodec<TutorialState> _repeated_tutorialsCompleted_codec = pb::FieldCodec.ForEnum(
			10,
			x => (int)x,
			x => (global::POGOProtos.Enums.TutorialState)x);

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

		/// <summary>
		/// The tutorials completed_.
		/// </summary>
		private readonly pbc.RepeatedField<TutorialState> tutorialsCompleted_ = new pbc::RepeatedField<TutorialState>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="MarkTutorialCompleteMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MarkTutorialCompleteMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MarkTutorialCompleteMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MarkTutorialCompleteMessage(MarkTutorialCompleteMessage other) : this()
		{
			tutorialsCompleted_ = other.tutorialsCompleted_.Clone();
			sendMarketingEmails_ = other.sendMarketingEmails_;
			sendPushNotifications_ = other.sendPushNotifications_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<MarkTutorialCompleteMessage> Parser
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
					global::POGOProtos.Networking.Requests.Messages.MarkTutorialCompleteMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets the tutorials completed.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<TutorialState> TutorialsCompleted
		{
			get
			{
				return tutorialsCompleted_;
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
		/// The <see cref="MarkTutorialCompleteMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MarkTutorialCompleteMessage Clone()
		{
			return new MarkTutorialCompleteMessage(this);
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
		public bool Equals(MarkTutorialCompleteMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!tutorialsCompleted_.Equals(other.tutorialsCompleted_))
			{
				return false;
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
			tutorialsCompleted_.WriteTo(output, _repeated_tutorialsCompleted_codec);
			if (SendMarketingEmails != false)
			{
				output.WriteRawTag(16);
				output.WriteBool(SendMarketingEmails);
			}

			if (SendPushNotifications != false)
			{
				output.WriteRawTag(24);
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
			size += tutorialsCompleted_.CalculateSize(_repeated_tutorialsCompleted_codec);
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
		public void MergeFrom(MarkTutorialCompleteMessage other)
		{
			if (other == null)
			{
				return;
			}

			tutorialsCompleted_.Add(other.tutorialsCompleted_);
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
					case 10:
					case 8:
					{
						tutorialsCompleted_.AddEntriesFrom(input, _repeated_tutorialsCompleted_codec);
						break;
					}

					case 16:
					{
						SendMarketingEmails = input.ReadBool();
						break;
					}

					case 24:
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
			return Equals(other as MarkTutorialCompleteMessage);
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
			hash ^= tutorialsCompleted_.GetHashCode();
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