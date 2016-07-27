// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AppliedItems.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/AppliedItems.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/AppliedItems.proto</summary>
	public static partial class AppliedItemsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/AppliedItems.proto</summary>
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
		/// Initializes static members of the <see cref="AppliedItemsReflection"/> class.
		/// </summary>
		static AppliedItemsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CidQT0dPUHJvdG9zL0ludmVudG9yeS9BcHBsaWVkSXRlbXMucHJvdG8SFFBP",
						"R09Qcm90b3MuSW52ZW50b3J5GiZQT0dPUHJvdG9zL0ludmVudG9yeS9BcHBs",
						"aWVkSXRlbS5wcm90byI/CgxBcHBsaWVkSXRlbXMSLwoEaXRlbRgEIAMoCzIh",
						"LlBPR09Qcm90b3MuSW52ZW50b3J5LkFwcGxpZWRJdGVtYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.AppliedItemReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Inventory.AppliedItems),
							global::POGOProtos.Inventory.AppliedItems.Parser,
							new[] { "Item" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The applied items.
	/// </summary>
	public sealed partial class AppliedItems : pb::IMessage<AppliedItems>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "item" field.</summary>
		public const int ItemFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<AppliedItems> _parser =
			new pb::MessageParser<AppliedItems>(() => new AppliedItems());

		/// <summary>
		/// The _repeated_item_codec.
		/// </summary>
		private static readonly pb.FieldCodec<AppliedItem> _repeated_item_codec = pb::FieldCodec.ForMessage(
			34,
			global::POGOProtos.Inventory.AppliedItem.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The item_.
		/// </summary>
		private readonly pbc.RepeatedField<AppliedItem> item_ = new pbc::RepeatedField<AppliedItem>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="AppliedItems"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AppliedItems()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AppliedItems"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AppliedItems(AppliedItems other) : this()
		{
			item_ = other.item_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<AppliedItems> Parser
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
				return global::POGOProtos.Inventory.AppliedItemsReflection.Descriptor.MessageTypes[0];
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
		/// Gets the item.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<AppliedItem> Item
		{
			get
			{
				return item_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="AppliedItems"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AppliedItems Clone()
		{
			return new AppliedItems(this);
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
		public bool Equals(AppliedItems other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!item_.Equals(other.item_))
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
			item_.WriteTo(output, _repeated_item_codec);
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
			size += item_.CalculateSize(_repeated_item_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(AppliedItems other)
		{
			if (other == null)
			{
				return;
			}

			item_.Add(other.item_);
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
					case 34:
					{
						item_.AddEntriesFrom(input, _repeated_item_codec);
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
			return Equals(other as AppliedItems);
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
			hash ^= item_.GetHashCode();
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