// --------------------------------------------------------------------------------------------------------------------
// <copyright file="RecycleInventoryItemMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/RecycleInventoryItemMessage.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/RecycleInventoryItemMessage.proto</summary>
	public static partial class RecycleInventoryItemMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/RecycleInventoryItemMessage.proto</summary>
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
		/// Initializes static members of the <see cref="RecycleInventoryItemMessageReflection"/> class.
		/// </summary>
		static RecycleInventoryItemMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CklQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvUmVj",
						"eWNsZUludmVudG9yeUl0ZW1NZXNzYWdlLnByb3RvEidQT0dPUHJvdG9zLk5l",
						"dHdvcmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMaJlBPR09Qcm90b3MvSW52ZW50",
						"b3J5L0l0ZW0vSXRlbUlkLnByb3RvImAKG1JlY3ljbGVJbnZlbnRvcnlJdGVt",
						"TWVzc2FnZRIyCgdpdGVtX2lkGAEgASgOMiEuUE9HT1Byb3Rvcy5JbnZlbnRv",
						"cnkuSXRlbS5JdGVtSWQSDQoFY291bnQYAiABKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.RecycleInventoryItemMessage),
							global::POGOProtos.Networking.Requests.Messages.RecycleInventoryItemMessage.Parser,
							new[] { "ItemId", "Count" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The recycle inventory item message.
	/// </summary>
	public sealed partial class RecycleInventoryItemMessage : pb::IMessage<RecycleInventoryItemMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "item_id" field.</summary>
		public const int ItemIdFieldNumber = 1;

		/// <summary>Field number for the "count" field.</summary>
		public const int CountFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<RecycleInventoryItemMessage> _parser =
			new pb::MessageParser<RecycleInventoryItemMessage>(() => new RecycleInventoryItemMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The count_.
		/// </summary>
		private int count_;

		/// <summary>
		/// The item id_.
		/// </summary>
		private ItemId itemId_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="RecycleInventoryItemMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public RecycleInventoryItemMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="RecycleInventoryItemMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public RecycleInventoryItemMessage(RecycleInventoryItemMessage other) : this()
		{
			itemId_ = other.itemId_;
			count_ = other.count_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<RecycleInventoryItemMessage> Parser
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
					global::POGOProtos.Networking.Requests.Messages.RecycleInventoryItemMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the count.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int Count
		{
			get
			{
				return count_;
			}

			set
			{
				count_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="RecycleInventoryItemMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public RecycleInventoryItemMessage Clone()
		{
			return new RecycleInventoryItemMessage(this);
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
		public bool Equals(RecycleInventoryItemMessage other)
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

			if (Count != other.Count)
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

			if (Count != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(Count);
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

			if (Count != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(Count);
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
		public void MergeFrom(RecycleInventoryItemMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}

			if (other.Count != 0)
			{
				Count = other.Count;
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

					case 16:
					{
						Count = input.ReadInt32();
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
			return Equals(other as RecycleInventoryItemMessage);
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

			if (Count != 0)
			{
				hash ^= Count.GetHashCode();
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