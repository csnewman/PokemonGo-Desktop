// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryItem.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/InventoryItem.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Inventory
{
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/InventoryItem.proto</summary>
	public static partial class InventoryItemReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/InventoryItem.proto</summary>
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
		/// Initializes static members of the <see cref="InventoryItemReflection"/> class.
		/// </summary>
		static InventoryItemReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CihQT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlJdGVtLnByb3RvEhRQ",
						"T0dPUHJvdG9zLkludmVudG9yeRosUE9HT1Byb3Rvcy9JbnZlbnRvcnkvSW52",
						"ZW50b3J5SXRlbURhdGEucHJvdG8ijgEKDUludmVudG9yeUl0ZW0SHQoVbW9k",
						"aWZpZWRfdGltZXN0YW1wX21zGAEgASgDEhgKEGRlbGV0ZWRfaXRlbV9rZXkY",
						"AiABKAMSRAoTaW52ZW50b3J5X2l0ZW1fZGF0YRgDIAEoCzInLlBPR09Qcm90",
						"b3MuSW52ZW50b3J5LkludmVudG9yeUl0ZW1EYXRhYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.InventoryItemDataReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Inventory.InventoryItem),
							global::POGOProtos.Inventory.InventoryItem.Parser,
							new[] { "ModifiedTimestampMs", "DeletedItemKey", "InventoryItemData" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The inventory item.
	/// </summary>
	public sealed partial class InventoryItem : pb::IMessage<InventoryItem>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "modified_timestamp_ms" field.</summary>
		public const int ModifiedTimestampMsFieldNumber = 1;

		/// <summary>Field number for the "deleted_item_key" field.</summary>
		public const int DeletedItemKeyFieldNumber = 2;

		/// <summary>Field number for the "inventory_item_data" field.</summary>
		public const int InventoryItemDataFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<InventoryItem> _parser =
			new pb::MessageParser<InventoryItem>(() => new InventoryItem());

		#endregion

		#region  Fields

		/// <summary>
		/// The deleted item key_.
		/// </summary>
		private long deletedItemKey_;

		/// <summary>
		/// The inventory item data_.
		/// </summary>
		private InventoryItemData inventoryItemData_;

		/// <summary>
		/// The modified timestamp ms_.
		/// </summary>
		private long modifiedTimestampMs_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryItem"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryItem()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryItem"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryItem(InventoryItem other) : this()
		{
			modifiedTimestampMs_ = other.modifiedTimestampMs_;
			deletedItemKey_ = other.deletedItemKey_;
			InventoryItemData = other.inventoryItemData_ != null ? other.InventoryItemData.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<InventoryItem> Parser
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
				return global::POGOProtos.Inventory.InventoryItemReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the modified timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long ModifiedTimestampMs
		{
			get
			{
				return modifiedTimestampMs_;
			}

			set
			{
				modifiedTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the deleted item key.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long DeletedItemKey
		{
			get
			{
				return deletedItemKey_;
			}

			set
			{
				deletedItemKey_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the inventory item data.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryItemData InventoryItemData
		{
			get
			{
				return inventoryItemData_;
			}

			set
			{
				inventoryItemData_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="InventoryItem"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryItem Clone()
		{
			return new InventoryItem(this);
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
		public bool Equals(InventoryItem other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (ModifiedTimestampMs != other.ModifiedTimestampMs)
			{
				return false;
			}

			if (DeletedItemKey != other.DeletedItemKey)
			{
				return false;
			}

			if (!object.Equals(InventoryItemData, other.InventoryItemData))
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
			if (ModifiedTimestampMs != 0L)
			{
				output.WriteRawTag(8);
				output.WriteInt64(ModifiedTimestampMs);
			}

			if (DeletedItemKey != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(DeletedItemKey);
			}

			if (inventoryItemData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(InventoryItemData);
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
			if (ModifiedTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(ModifiedTimestampMs);
			}

			if (DeletedItemKey != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(DeletedItemKey);
			}

			if (inventoryItemData_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventoryItemData);
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
		public void MergeFrom(InventoryItem other)
		{
			if (other == null)
			{
				return;
			}

			if (other.ModifiedTimestampMs != 0L)
			{
				ModifiedTimestampMs = other.ModifiedTimestampMs;
			}

			if (other.DeletedItemKey != 0L)
			{
				DeletedItemKey = other.DeletedItemKey;
			}

			if (other.inventoryItemData_ != null)
			{
				if (inventoryItemData_ == null)
				{
					inventoryItemData_ = new global::POGOProtos.Inventory.InventoryItemData();
				}

				InventoryItemData.MergeFrom(other.InventoryItemData);
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
						ModifiedTimestampMs = input.ReadInt64();
						break;
					}

					case 16:
					{
						DeletedItemKey = input.ReadInt64();
						break;
					}

					case 26:
					{
						if (inventoryItemData_ == null)
						{
							inventoryItemData_ = new global::POGOProtos.Inventory.InventoryItemData();
						}

						input.ReadMessage(inventoryItemData_);
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
			return Equals(other as InventoryItem);
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
			if (ModifiedTimestampMs != 0L)
			{
				hash ^= ModifiedTimestampMs.GetHashCode();
			}

			if (DeletedItemKey != 0L)
			{
				hash ^= DeletedItemKey.GetHashCode();
			}

			if (inventoryItemData_ != null)
			{
				hash ^= InventoryItemData.GetHashCode();
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