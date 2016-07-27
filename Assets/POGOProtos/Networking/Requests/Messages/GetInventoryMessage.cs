// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetInventoryMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GetInventoryMessage.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GetInventoryMessage.proto</summary>
	public static partial class GetInventoryMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/GetInventoryMessage.proto</summary>
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
		/// Initializes static members of the <see cref="GetInventoryMessageReflection"/> class.
		/// </summary>
		static GetInventoryMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkFQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvR2V0",
						"SW52ZW50b3J5TWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5n",
						"LlJlcXVlc3RzLk1lc3NhZ2VzIkgKE0dldEludmVudG9yeU1lc3NhZ2USGQoR",
						"bGFzdF90aW1lc3RhbXBfbXMYASABKAMSFgoOaXRlbV9iZWVuX3NlZW4YAiAB",
						"KAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.GetInventoryMessage),
							global::POGOProtos.Networking.Requests.Messages.GetInventoryMessage.Parser,
							new[] { "LastTimestampMs", "ItemBeenSeen" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The get inventory message.
	/// </summary>
	public sealed partial class GetInventoryMessage : pb::IMessage<GetInventoryMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "last_timestamp_ms" field.</summary>
		public const int LastTimestampMsFieldNumber = 1;

		/// <summary>Field number for the "item_been_seen" field.</summary>
		public const int ItemBeenSeenFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetInventoryMessage> _parser =
			new pb::MessageParser<GetInventoryMessage>(() => new GetInventoryMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The item been seen_.
		/// </summary>
		private int itemBeenSeen_;

		/// <summary>
		/// The last timestamp ms_.
		/// </summary>
		private long lastTimestampMs_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetInventoryMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetInventoryMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetInventoryMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetInventoryMessage(GetInventoryMessage other) : this()
		{
			lastTimestampMs_ = other.lastTimestampMs_;
			itemBeenSeen_ = other.itemBeenSeen_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetInventoryMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.GetInventoryMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the last timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long LastTimestampMs
		{
			get
			{
				return lastTimestampMs_;
			}

			set
			{
				lastTimestampMs_ = value;
			}
		}

		/// <summary>
		///  TODO: Find out what this is.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int ItemBeenSeen
		{
			get
			{
				return itemBeenSeen_;
			}

			set
			{
				itemBeenSeen_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GetInventoryMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetInventoryMessage Clone()
		{
			return new GetInventoryMessage(this);
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
		public bool Equals(GetInventoryMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (LastTimestampMs != other.LastTimestampMs)
			{
				return false;
			}

			if (ItemBeenSeen != other.ItemBeenSeen)
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
			if (LastTimestampMs != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(LastTimestampMs);
			}

			if (ItemBeenSeen != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(ItemBeenSeen);
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
			if (LastTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastTimestampMs);
			}

			if (ItemBeenSeen != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(ItemBeenSeen);
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
		public void MergeFrom(GetInventoryMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.LastTimestampMs != 0L)
			{
				LastTimestampMs = other.LastTimestampMs;
			}

			if (other.ItemBeenSeen != 0)
			{
				ItemBeenSeen = other.ItemBeenSeen;
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
						LastTimestampMs = input.ReadInt64();
						break;
					}

					case 16:
					{
						ItemBeenSeen = input.ReadInt32();
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
			return Equals(other as GetInventoryMessage);
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
			if (LastTimestampMs != 0L)
			{
				hash ^= LastTimestampMs.GetHashCode();
			}

			if (ItemBeenSeen != 0)
			{
				hash ^= ItemBeenSeen.GetHashCode();
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