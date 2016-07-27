// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IapItemDisplay.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/IapItemDisplay.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using POGOProtos.Inventory.Item;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/IapItemDisplay.proto</summary>
	public static partial class IapItemDisplayReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/IapItemDisplay.proto</summary>
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
		/// Initializes static members of the <see cref="IapItemDisplayReflection"/> class.
		/// </summary>
		static IapItemDisplayReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ci9QT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JYXBJdGVtRGlzcGxheS5w",
						"cm90bxIaUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIaJlBPR09Qcm90b3Mv",
						"RW51bXMvSWFwSXRlbUNhdGVnb3J5LnByb3RvGiZQT0dPUHJvdG9zL0ludmVu",
						"dG9yeS9JdGVtL0l0ZW1JZC5wcm90byKvAQoOSWFwSXRlbURpc3BsYXkSCwoD",
						"c2t1GAEgASgJEjcKCGNhdGVnb3J5GAIgASgOMiUuUE9HT1Byb3Rvcy5FbnVt",
						"cy5Ib2xvSWFwSXRlbUNhdGVnb3J5EhIKCnNvcnRfb3JkZXIYAyABKAUSMwoI",
						"aXRlbV9pZHMYBCADKA4yIS5QT0dPUHJvdG9zLkludmVudG9yeS5JdGVtLkl0",
						"ZW1JZBIOCgZjb3VudHMYBSADKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Enums.IapItemCategoryReflection.Descriptor,
					global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.IapItemDisplay),
							global::POGOProtos.Settings.Master.IapItemDisplay.Parser,
							new[] { "Sku", "Category", "SortOrder", "ItemIds", "Counts" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The iap item display.
	/// </summary>
	public sealed partial class IapItemDisplay : pb::IMessage<IapItemDisplay>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "sku" field.</summary>
		public const int SkuFieldNumber = 1;

		/// <summary>Field number for the "category" field.</summary>
		public const int CategoryFieldNumber = 2;

		/// <summary>Field number for the "sort_order" field.</summary>
		public const int SortOrderFieldNumber = 3;

		/// <summary>Field number for the "item_ids" field.</summary>
		public const int ItemIdsFieldNumber = 4;

		/// <summary>Field number for the "counts" field.</summary>
		public const int CountsFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<IapItemDisplay> _parser =
			new pb::MessageParser<IapItemDisplay>(() => new IapItemDisplay());

		/// <summary>
		/// The _repeated_item ids_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ItemId> _repeated_itemIds_codec = pb::FieldCodec.ForEnum(
			34,
			x => (int)x,
			x => (global::POGOProtos.Inventory.Item.ItemId)x);

		/// <summary>
		/// The _repeated_counts_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_counts_codec = pb::FieldCodec.ForInt32(42);

		#endregion

		#region  Fields

		/// <summary>
		/// The category_.
		/// </summary>
		private HoloIapItemCategory category_ = 0;

		/// <summary>
		/// The counts_.
		/// </summary>
		private readonly pbc.RepeatedField<int> counts_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The item ids_.
		/// </summary>
		private readonly pbc.RepeatedField<ItemId> itemIds_ = new pbc::RepeatedField<ItemId>();

		/// <summary>
		/// The sku_.
		/// </summary>
		private string sku_ = string.Empty;

		/// <summary>
		/// The sort order_.
		/// </summary>
		private int sortOrder_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="IapItemDisplay"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IapItemDisplay()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="IapItemDisplay"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IapItemDisplay(IapItemDisplay other) : this()
		{
			sku_ = other.sku_;
			category_ = other.category_;
			sortOrder_ = other.sortOrder_;
			itemIds_ = other.itemIds_.Clone();
			counts_ = other.counts_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<IapItemDisplay> Parser
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
				return global::POGOProtos.Settings.Master.IapItemDisplayReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the sku.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Sku
		{
			get
			{
				return sku_;
			}

			set
			{
				sku_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the category.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public HoloIapItemCategory Category
		{
			get
			{
				return category_;
			}

			set
			{
				category_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the sort order.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int SortOrder
		{
			get
			{
				return sortOrder_;
			}

			set
			{
				sortOrder_ = value;
			}
		}

		/// <summary>
		/// Gets the item ids.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ItemId> ItemIds
		{
			get
			{
				return itemIds_;
			}
		}

		/// <summary>
		/// Gets the counts.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> Counts
		{
			get
			{
				return counts_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="IapItemDisplay"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IapItemDisplay Clone()
		{
			return new IapItemDisplay(this);
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
		public bool Equals(IapItemDisplay other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Sku != other.Sku)
			{
				return false;
			}

			if (Category != other.Category)
			{
				return false;
			}

			if (SortOrder != other.SortOrder)
			{
				return false;
			}

			if (!itemIds_.Equals(other.itemIds_))
			{
				return false;
			}

			if (!counts_.Equals(other.counts_))
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
			if (Sku.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Sku);
			}

			if (Category != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)Category);
			}

			if (SortOrder != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(SortOrder);
			}

			itemIds_.WriteTo(output, _repeated_itemIds_codec);
			counts_.WriteTo(output, _repeated_counts_codec);
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
			if (Sku.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Sku);
			}

			if (Category != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Category);
			}

			if (SortOrder != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(SortOrder);
			}

			size += itemIds_.CalculateSize(_repeated_itemIds_codec);
			size += counts_.CalculateSize(_repeated_counts_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(IapItemDisplay other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Sku.Length != 0)
			{
				Sku = other.Sku;
			}

			if (other.Category != 0)
			{
				Category = other.Category;
			}

			if (other.SortOrder != 0)
			{
				SortOrder = other.SortOrder;
			}

			itemIds_.Add(other.itemIds_);
			counts_.Add(other.counts_);
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
						Sku = input.ReadString();
						break;
					}

					case 16:
					{
						category_ = (global::POGOProtos.Enums.HoloIapItemCategory)input.ReadEnum();
						break;
					}

					case 24:
					{
						SortOrder = input.ReadInt32();
						break;
					}

					case 34:
					case 32:
					{
						itemIds_.AddEntriesFrom(input, _repeated_itemIds_codec);
						break;
					}

					case 42:
					case 40:
					{
						counts_.AddEntriesFrom(input, _repeated_counts_codec);
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
			return Equals(other as IapItemDisplay);
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
			if (Sku.Length != 0)
			{
				hash ^= Sku.GetHashCode();
			}

			if (Category != 0)
			{
				hash ^= Category.GetHashCode();
			}

			if (SortOrder != 0)
			{
				hash ^= SortOrder.GetHashCode();
			}

			hash ^= itemIds_.GetHashCode();
			hash ^= counts_.GetHashCode();
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