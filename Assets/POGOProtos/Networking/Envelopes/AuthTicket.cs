// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AuthTicket.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Envelopes/AuthTicket.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Envelopes
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Envelopes/AuthTicket.proto</summary>
	public static partial class AuthTicketReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Envelopes/AuthTicket.proto</summary>
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
		/// Initializes static members of the <see cref="AuthTicketReflection"/> class.
		/// </summary>
		static AuthTicketReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjBQT0dPUHJvdG9zL05ldHdvcmtpbmcvRW52ZWxvcGVzL0F1dGhUaWNrZXQu",
						"cHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5FbnZlbG9wZXMiRQoKQXV0",
						"aFRpY2tldBINCgVzdGFydBgBIAEoDBIbChNleHBpcmVfdGltZXN0YW1wX21z",
						"GAIgASgEEgsKA2VuZBgDIAEoDGIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Envelopes.AuthTicket),
							global::POGOProtos.Networking.Envelopes.AuthTicket.Parser,
							new[] { "Start", "ExpireTimestampMs", "End" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The auth ticket.
	/// </summary>
	public sealed partial class AuthTicket : pb::IMessage<AuthTicket>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "start" field.</summary>
		public const int StartFieldNumber = 1;

		/// <summary>Field number for the "expire_timestamp_ms" field.</summary>
		public const int ExpireTimestampMsFieldNumber = 2;

		/// <summary>Field number for the "end" field.</summary>
		public const int EndFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<AuthTicket> _parser =
			new pb::MessageParser<AuthTicket>(() => new AuthTicket());

		#endregion

		#region  Fields

		/// <summary>
		/// The end_.
		/// </summary>
		private pb.ByteString end_ = pb::ByteString.Empty;

		/// <summary>
		/// The expire timestamp ms_.
		/// </summary>
		private ulong expireTimestampMs_;

		/// <summary>
		/// The start_.
		/// </summary>
		private pb.ByteString start_ = pb::ByteString.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthTicket"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AuthTicket()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AuthTicket"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AuthTicket(AuthTicket other) : this()
		{
			start_ = other.start_;
			expireTimestampMs_ = other.expireTimestampMs_;
			end_ = other.end_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<AuthTicket> Parser
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
				return global::POGOProtos.Networking.Envelopes.AuthTicketReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the start.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pb.ByteString Start
		{
			get
			{
				return start_;
			}

			set
			{
				start_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the expire timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong ExpireTimestampMs
		{
			get
			{
				return expireTimestampMs_;
			}

			set
			{
				expireTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the end.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pb.ByteString End
		{
			get
			{
				return end_;
			}

			set
			{
				end_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="AuthTicket"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AuthTicket Clone()
		{
			return new AuthTicket(this);
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
		public bool Equals(AuthTicket other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Start != other.Start)
			{
				return false;
			}

			if (ExpireTimestampMs != other.ExpireTimestampMs)
			{
				return false;
			}

			if (End != other.End)
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
			if (Start.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteBytes(Start);
			}

			if (ExpireTimestampMs != 0UL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(ExpireTimestampMs);
			}

			if (End.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteBytes(End);
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
			if (Start.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeBytesSize(Start);
			}

			if (ExpireTimestampMs != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ExpireTimestampMs);
			}

			if (End.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeBytesSize(End);
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
		public void MergeFrom(AuthTicket other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Start.Length != 0)
			{
				Start = other.Start;
			}

			if (other.ExpireTimestampMs != 0UL)
			{
				ExpireTimestampMs = other.ExpireTimestampMs;
			}

			if (other.End.Length != 0)
			{
				End = other.End;
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
						Start = input.ReadBytes();
						break;
					}

					case 16:
					{
						ExpireTimestampMs = input.ReadUInt64();
						break;
					}

					case 26:
					{
						End = input.ReadBytes();
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
			return Equals(other as AuthTicket);
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
			if (Start.Length != 0)
			{
				hash ^= Start.GetHashCode();
			}

			if (ExpireTimestampMs != 0UL)
			{
				hash ^= ExpireTimestampMs.GetHashCode();
			}

			if (End.Length != 0)
			{
				hash ^= End.GetHashCode();
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