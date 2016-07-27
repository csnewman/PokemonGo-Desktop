// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IncenseEncounterMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/IncenseEncounterMessage.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Requests.Messages
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/IncenseEncounterMessage.proto</summary>
	public static partial class IncenseEncounterMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/IncenseEncounterMessage.proto</summary>
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
		/// Initializes static members of the <see cref="IncenseEncounterMessageReflection"/> class.
		/// </summary>
		static IncenseEncounterMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkVQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvSW5j",
						"ZW5zZUVuY291bnRlck1lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29y",
						"a2luZy5SZXF1ZXN0cy5NZXNzYWdlcyJLChdJbmNlbnNlRW5jb3VudGVyTWVz",
						"c2FnZRIUCgxlbmNvdW50ZXJfaWQYASABKAMSGgoSZW5jb3VudGVyX2xvY2F0",
						"aW9uGAIgASgJYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.IncenseEncounterMessage),
							global::POGOProtos.Networking.Requests.Messages.IncenseEncounterMessage.Parser,
							new[] { "EncounterId", "EncounterLocation" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The incense encounter message.
	/// </summary>
	public sealed partial class IncenseEncounterMessage : pb::IMessage<IncenseEncounterMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "encounter_id" field.</summary>
		public const int EncounterIdFieldNumber = 1;

		/// <summary>Field number for the "encounter_location" field.</summary>
		public const int EncounterLocationFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<IncenseEncounterMessage> _parser =
			new pb::MessageParser<IncenseEncounterMessage>(() => new IncenseEncounterMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The encounter id_.
		/// </summary>
		private long encounterId_;

		/// <summary>
		/// The encounter location_.
		/// </summary>
		private string encounterLocation_ = string.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="IncenseEncounterMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IncenseEncounterMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="IncenseEncounterMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IncenseEncounterMessage(IncenseEncounterMessage other) : this()
		{
			encounterId_ = other.encounterId_;
			encounterLocation_ = other.encounterLocation_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<IncenseEncounterMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.IncenseEncounterMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the encounter id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long EncounterId
		{
			get
			{
				return encounterId_;
			}

			set
			{
				encounterId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the encounter location.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string EncounterLocation
		{
			get
			{
				return encounterLocation_;
			}

			set
			{
				encounterLocation_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="IncenseEncounterMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IncenseEncounterMessage Clone()
		{
			return new IncenseEncounterMessage(this);
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
		public bool Equals(IncenseEncounterMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (EncounterId != other.EncounterId)
			{
				return false;
			}

			if (EncounterLocation != other.EncounterLocation)
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
			if (EncounterId != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(EncounterId);
			}

			if (EncounterLocation.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(EncounterLocation);
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
			if (EncounterId != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(EncounterId);
			}

			if (EncounterLocation.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(EncounterLocation);
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
		public void MergeFrom(IncenseEncounterMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.EncounterId != 0L)
			{
				EncounterId = other.EncounterId;
			}

			if (other.EncounterLocation.Length != 0)
			{
				EncounterLocation = other.EncounterLocation;
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
						EncounterId = input.ReadInt64();
						break;
					}

					case 18:
					{
						EncounterLocation = input.ReadString();
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
			return Equals(other as IncenseEncounterMessage);
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
			if (EncounterId != 0L)
			{
				hash ^= EncounterId.GetHashCode();
			}

			if (EncounterLocation.Length != 0)
			{
				hash ^= EncounterLocation.GetHashCode();
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