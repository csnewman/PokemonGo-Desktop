// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetPlayerTeamMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/SetPlayerTeamMessage.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/SetPlayerTeamMessage.proto</summary>
	public static partial class SetPlayerTeamMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/SetPlayerTeamMessage.proto</summary>
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
		/// Initializes static members of the <see cref="SetPlayerTeamMessageReflection"/> class.
		/// </summary>
		static SetPlayerTeamMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkJQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvU2V0",
						"UGxheWVyVGVhbU1lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29ya2lu",
						"Zy5SZXF1ZXN0cy5NZXNzYWdlcxogUE9HT1Byb3Rvcy9FbnVtcy9UZWFtQ29s",
						"b3IucHJvdG8iQQoUU2V0UGxheWVyVGVhbU1lc3NhZ2USKQoEdGVhbRgBIAEo",
						"DjIbLlBPR09Qcm90b3MuRW51bXMuVGVhbUNvbG9yYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.TeamColorReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.SetPlayerTeamMessage),
							global::POGOProtos.Networking.Requests.Messages.SetPlayerTeamMessage.Parser,
							new[] { "Team" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The set player team message.
	/// </summary>
	public sealed partial class SetPlayerTeamMessage : pb::IMessage<SetPlayerTeamMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "team" field.</summary>
		public const int TeamFieldNumber = 1;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<SetPlayerTeamMessage> _parser =
			new pb::MessageParser<SetPlayerTeamMessage>(() => new SetPlayerTeamMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The team_.
		/// </summary>
		private TeamColor team_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="SetPlayerTeamMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetPlayerTeamMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SetPlayerTeamMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetPlayerTeamMessage(SetPlayerTeamMessage other) : this()
		{
			team_ = other.team_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<SetPlayerTeamMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.SetPlayerTeamMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the team.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public TeamColor Team
		{
			get
			{
				return team_;
			}

			set
			{
				team_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="SetPlayerTeamMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetPlayerTeamMessage Clone()
		{
			return new SetPlayerTeamMessage(this);
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
		public bool Equals(SetPlayerTeamMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Team != other.Team)
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
			if (Team != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)Team);
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
			if (Team != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Team);
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
		public void MergeFrom(SetPlayerTeamMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Team != 0)
			{
				Team = other.Team;
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
						team_ = (global::POGOProtos.Enums.TeamColor)input.ReadEnum();
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
			return Equals(other as SetPlayerTeamMessage);
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
			if (Team != 0)
			{
				hash ^= Team.GetHashCode();
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