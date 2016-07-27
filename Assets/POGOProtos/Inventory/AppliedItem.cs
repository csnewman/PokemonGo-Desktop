// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppliedItem.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/AppliedItem.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/AppliedItem.proto</summary>
	public static partial class AppliedItemReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/AppliedItem.proto</summary>
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
		/// Initializes static members of the <see cref="AppliedItemReflection"/> class.
		/// </summary>
		static AppliedItemReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiZQT0dPUHJvdG9zL0ludmVudG9yeS9BcHBsaWVkSXRlbS5wcm90bxIUUE9H",
						"T1Byb3Rvcy5JbnZlbnRvcnkaJlBPR09Qcm90b3MvSW52ZW50b3J5L0l0ZW0v",
						"SXRlbUlkLnByb3RvGihQT0dPUHJvdG9zL0ludmVudG9yeS9JdGVtL0l0ZW1U",
						"eXBlLnByb3RvIqABCgtBcHBsaWVkSXRlbRIyCgdpdGVtX2lkGAEgASgOMiEu",
						"UE9HT1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5JdGVtSWQSNgoJaXRlbV90eXBl",
						"GAIgASgOMiMuUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSXRlbS5JdGVtVHlwZRIR",
						"CglleHBpcmVfbXMYAyABKAMSEgoKYXBwbGllZF9tcxgEIAEoA2IGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor,
					global::POGOProtos.Inventory.Item.ItemTypeReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Inventory.AppliedItem),
							global::POGOProtos.Inventory.AppliedItem.Parser,
							new[] { "ItemId", "ItemType", "ExpireMs", "AppliedMs" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The applied item.
	/// </summary>
	public sealed partial class AppliedItem : pb::IMessage<AppliedItem>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "item_id" field.</summary>
		public const int ItemIdFieldNumber = 1;

		/// <summary>Field number for the "item_type" field.</summary>
		public const int ItemTypeFieldNumber = 2;

		/// <summary>Field number for the "expire_ms" field.</summary>
		public const int ExpireMsFieldNumber = 3;

		/// <summary>Field number for the "applied_ms" field.</summary>
		public const int AppliedMsFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<AppliedItem> _parser =
			new pb::MessageParser<AppliedItem>(() => new AppliedItem());

		#endregion

		#region  Fields

		/// <summary>
		/// The applied ms_.
		/// </summary>
		private long appliedMs_;

		/// <summary>
		/// The expire ms_.
		/// </summary>
		private long expireMs_;

		/// <summary>
		/// The item id_.
		/// </summary>
		private ItemId itemId_ = 0;

		/// <summary>
		/// The item type_.
		/// </summary>
		private ItemType itemType_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="AppliedItem"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AppliedItem()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AppliedItem"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AppliedItem(AppliedItem other) : this()
		{
			itemId_ = other.itemId_;
			itemType_ = other.itemType_;
			expireMs_ = other.expireMs_;
			appliedMs_ = other.appliedMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<AppliedItem> Parser
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
				return global::POGOProtos.Inventory.AppliedItemReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the item type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ItemType ItemType
		{
			get
			{
				return itemType_;
			}

			set
			{
				itemType_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the expire ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long ExpireMs
		{
			get
			{
				return expireMs_;
			}

			set
			{
				expireMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the applied ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long AppliedMs
		{
			get
			{
				return appliedMs_;
			}

			set
			{
				appliedMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="AppliedItem"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AppliedItem Clone()
		{
			return new AppliedItem(this);
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
		public bool Equals(AppliedItem other)
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

			if (ItemType != other.ItemType)
			{
				return false;
			}

			if (ExpireMs != other.ExpireMs)
			{
				return false;
			}

			if (AppliedMs != other.AppliedMs)
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

			if (ItemType != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)ItemType);
			}

			if (ExpireMs != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(ExpireMs);
			}

			if (AppliedMs != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(AppliedMs);
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

			if (ItemType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemType);
			}

			if (ExpireMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpireMs);
			}

			if (AppliedMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(AppliedMs);
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
		public void MergeFrom(AppliedItem other)
		{
			if (other == null)
			{
				return;
			}

			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}

			if (other.ItemType != 0)
			{
				ItemType = other.ItemType;
			}

			if (other.ExpireMs != 0L)
			{
				ExpireMs = other.ExpireMs;
			}

			if (other.AppliedMs != 0L)
			{
				AppliedMs = other.AppliedMs;
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
						itemType_ = (global::POGOProtos.Inventory.Item.ItemType)input.ReadEnum();
						break;
					}

					case 24:
					{
						ExpireMs = input.ReadInt64();
						break;
					}

					case 32:
					{
						AppliedMs = input.ReadInt64();
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
			return Equals(other as AppliedItem);
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

			if (ItemType != 0)
			{
				hash ^= ItemType.GetHashCode();
			}

			if (ExpireMs != 0L)
			{
				hash ^= ExpireMs.GetHashCode();
			}

			if (AppliedMs != 0L)
			{
				hash ^= AppliedMs.GetHashCode();
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