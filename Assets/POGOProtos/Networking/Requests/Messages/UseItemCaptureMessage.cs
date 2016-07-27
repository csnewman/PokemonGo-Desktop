// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UseItemCaptureMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/UseItemCaptureMessage.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Inventory.Item;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Requests.Messages
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/UseItemCaptureMessage.proto</summary>
	public static partial class UseItemCaptureMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/UseItemCaptureMessage.proto</summary>
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
		/// Initializes static members of the <see cref="UseItemCaptureMessageReflection"/> class.
		/// </summary>
		static UseItemCaptureMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkNQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvVXNl",
						"SXRlbUNhcHR1cmVNZXNzYWdlLnByb3RvEidQT0dPUHJvdG9zLk5ldHdvcmtp",
						"bmcuUmVxdWVzdHMuTWVzc2FnZXMaJlBPR09Qcm90b3MvSW52ZW50b3J5L0l0",
						"ZW0vSXRlbUlkLnByb3RvInsKFVVzZUl0ZW1DYXB0dXJlTWVzc2FnZRIyCgdp",
						"dGVtX2lkGAEgASgOMiEuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5JdGVt",
						"SWQSFAoMZW5jb3VudGVyX2lkGAIgASgGEhgKEHNwYXduX3BvaW50X2d1aWQY",
						"AyABKAliBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.UseItemCaptureMessage),
							global::POGOProtos.Networking.Requests.Messages.UseItemCaptureMessage.Parser,
							new[] { "ItemId", "EncounterId", "SpawnPointGuid" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The use item capture message.
	/// </summary>
	public sealed partial class UseItemCaptureMessage : pb::IMessage<UseItemCaptureMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "item_id" field.</summary>
		public const int ItemIdFieldNumber = 1;

		/// <summary>Field number for the "encounter_id" field.</summary>
		public const int EncounterIdFieldNumber = 2;

		/// <summary>Field number for the "spawn_point_guid" field.</summary>
		public const int SpawnPointGuidFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<UseItemCaptureMessage> _parser =
			new pb::MessageParser<UseItemCaptureMessage>(() => new UseItemCaptureMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The encounter id_.
		/// </summary>
		private ulong encounterId_;

		/// <summary>
		/// The item id_.
		/// </summary>
		private ItemId itemId_ = 0;

		/// <summary>
		/// The spawn point guid_.
		/// </summary>
		private string spawnPointGuid_ = string.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="UseItemCaptureMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemCaptureMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UseItemCaptureMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemCaptureMessage(UseItemCaptureMessage other) : this()
		{
			itemId_ = other.itemId_;
			encounterId_ = other.encounterId_;
			spawnPointGuid_ = other.spawnPointGuid_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<UseItemCaptureMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.UseItemCaptureMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the item id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ItemId ItemId
		{
			get
			{
				return itemId_;
			}

			set
			{
				itemId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the encounter id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong EncounterId
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
		/// Gets or sets the spawn point guid.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string SpawnPointGuid
		{
			get
			{
				return spawnPointGuid_;
			}

			set
			{
				spawnPointGuid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="UseItemCaptureMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemCaptureMessage Clone()
		{
			return new UseItemCaptureMessage(this);
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
		public bool Equals(UseItemCaptureMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (ItemId != other.ItemId)
			{
				return false;
			}

			if (EncounterId != other.EncounterId)
			{
				return false;
			}

			if (SpawnPointGuid != other.SpawnPointGuid)
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
			if (ItemId != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)ItemId);
			}

			if (EncounterId != 0UL)
			{
				output.WriteRawTag(17);
				output.WriteFixed64(EncounterId);
			}

			if (SpawnPointGuid.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(SpawnPointGuid);
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
			if (ItemId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemId);
			}

			if (EncounterId != 0UL)
			{
				size += 1 + 8;
			}

			if (SpawnPointGuid.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointGuid);
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
		public void MergeFrom(UseItemCaptureMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}

			if (other.EncounterId != 0UL)
			{
				EncounterId = other.EncounterId;
			}

			if (other.SpawnPointGuid.Length != 0)
			{
				SpawnPointGuid = other.SpawnPointGuid;
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
						itemId_ = (global::POGOProtos.Inventory.Item.ItemId)input.ReadEnum();
						break;
					}

					case 17:
					{
						EncounterId = input.ReadFixed64();
						break;
					}

					case 26:
					{
						SpawnPointGuid = input.ReadString();
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
			return Equals(other as UseItemCaptureMessage);
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
			if (ItemId != 0)
			{
				hash ^= ItemId.GetHashCode();
			}

			if (EncounterId != 0UL)
			{
				hash ^= EncounterId.GetHashCode();
			}

			if (SpawnPointGuid.Length != 0)
			{
				hash ^= SpawnPointGuid.GetHashCode();
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