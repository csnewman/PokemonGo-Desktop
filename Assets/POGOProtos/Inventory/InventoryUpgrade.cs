// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryUpgrade.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/InventoryUpgrade.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Inventory.Item;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Inventory
{
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/InventoryUpgrade.proto</summary>
	public static partial class InventoryUpgradeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/InventoryUpgrade.proto</summary>
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
		/// Initializes static members of the <see cref="InventoryUpgradeReflection"/> class.
		/// </summary>
		static InventoryUpgradeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CitQT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlVcGdyYWRlLnByb3Rv",
						"EhRQT0dPUHJvdG9zLkludmVudG9yeRomUE9HT1Byb3Rvcy9JbnZlbnRvcnkv",
						"SXRlbS9JdGVtSWQucHJvdG8aL1BPR09Qcm90b3MvSW52ZW50b3J5L0ludmVu",
						"dG9yeVVwZ3JhZGVUeXBlLnByb3RvIqQBChBJbnZlbnRvcnlVcGdyYWRlEjIK",
						"B2l0ZW1faWQYASABKA4yIS5QT0dPUHJvdG9zLkludmVudG9yeS5JdGVtLkl0",
						"ZW1JZBJACgx1cGdyYWRlX3R5cGUYAiABKA4yKi5QT0dPUHJvdG9zLkludmVu",
						"dG9yeS5JbnZlbnRvcnlVcGdyYWRlVHlwZRIaChJhZGRpdGlvbmFsX3N0b3Jh",
						"Z2UYAyABKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor,
					global::POGOProtos.Inventory.InventoryUpgradeTypeReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Inventory.InventoryUpgrade),
							global::POGOProtos.Inventory.InventoryUpgrade.Parser,
							new[] { "ItemId", "UpgradeType", "AdditionalStorage" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The inventory upgrade.
	/// </summary>
	public sealed partial class InventoryUpgrade : pb::IMessage<InventoryUpgrade>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "item_id" field.</summary>
		public const int ItemIdFieldNumber = 1;

		/// <summary>Field number for the "upgrade_type" field.</summary>
		public const int UpgradeTypeFieldNumber = 2;

		/// <summary>Field number for the "additional_storage" field.</summary>
		public const int AdditionalStorageFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<InventoryUpgrade> _parser =
			new pb::MessageParser<InventoryUpgrade>(() => new InventoryUpgrade());

		#endregion

		#region  Fields

		/// <summary>
		/// The additional storage_.
		/// </summary>
		private int additionalStorage_;

		/// <summary>
		/// The item id_.
		/// </summary>
		private ItemId itemId_ = 0;

		/// <summary>
		/// The upgrade type_.
		/// </summary>
		private InventoryUpgradeType upgradeType_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryUpgrade"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgrade()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryUpgrade"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgrade(InventoryUpgrade other) : this()
		{
			itemId_ = other.itemId_;
			upgradeType_ = other.upgradeType_;
			additionalStorage_ = other.additionalStorage_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<InventoryUpgrade> Parser
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
				return global::POGOProtos.Inventory.InventoryUpgradeReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the upgrade type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgradeType UpgradeType
		{
			get
			{
				return upgradeType_;
			}

			set
			{
				upgradeType_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the additional storage.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int AdditionalStorage
		{
			get
			{
				return additionalStorage_;
			}

			set
			{
				additionalStorage_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="InventoryUpgrade"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgrade Clone()
		{
			return new InventoryUpgrade(this);
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
		public bool Equals(InventoryUpgrade other)
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

			if (UpgradeType != other.UpgradeType)
			{
				return false;
			}

			if (AdditionalStorage != other.AdditionalStorage)
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

			if (UpgradeType != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)UpgradeType);
			}

			if (AdditionalStorage != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(AdditionalStorage);
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

			if (UpgradeType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)UpgradeType);
			}

			if (AdditionalStorage != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(AdditionalStorage);
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
		public void MergeFrom(InventoryUpgrade other)
		{
			if (other == null)
			{
				return;
			}

			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}

			if (other.UpgradeType != 0)
			{
				UpgradeType = other.UpgradeType;
			}

			if (other.AdditionalStorage != 0)
			{
				AdditionalStorage = other.AdditionalStorage;
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
						upgradeType_ = (global::POGOProtos.Inventory.InventoryUpgradeType)input.ReadEnum();
						break;
					}

					case 24:
					{
						AdditionalStorage = input.ReadInt32();
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
			return Equals(other as InventoryUpgrade);
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

			if (UpgradeType != 0)
			{
				hash ^= UpgradeType.GetHashCode();
			}

			if (AdditionalStorage != 0)
			{
				hash ^= AdditionalStorage.GetHashCode();
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