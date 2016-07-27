// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryUpgrades.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/InventoryUpgrades.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/InventoryUpgrades.proto</summary>
	public static partial class InventoryUpgradesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/InventoryUpgrades.proto</summary>
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
		/// Initializes static members of the <see cref="InventoryUpgradesReflection"/> class.
		/// </summary>
		static InventoryUpgradesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CixQT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlVcGdyYWRlcy5wcm90",
						"bxIUUE9HT1Byb3Rvcy5JbnZlbnRvcnkaK1BPR09Qcm90b3MvSW52ZW50b3J5",
						"L0ludmVudG9yeVVwZ3JhZGUucHJvdG8iVwoRSW52ZW50b3J5VXBncmFkZXMS",
						"QgoSaW52ZW50b3J5X3VwZ3JhZGVzGAEgAygLMiYuUE9HT1Byb3Rvcy5JbnZl",
						"bnRvcnkuSW52ZW50b3J5VXBncmFkZWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.InventoryUpgradeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Inventory.InventoryUpgrades),
							global::POGOProtos.Inventory.InventoryUpgrades.Parser,
							new[] { "InventoryUpgrades_" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The inventory upgrades.
	/// </summary>
	public sealed partial class InventoryUpgrades : pb::IMessage<InventoryUpgrades>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "inventory_upgrades" field.</summary>
		public const int InventoryUpgrades_FieldNumber = 1;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<InventoryUpgrades> _parser =
			new pb::MessageParser<InventoryUpgrades>(() => new InventoryUpgrades());

		/// <summary>
		/// The _repeated_inventory upgrades_codec.
		/// </summary>
		private static readonly pb.FieldCodec<InventoryUpgrade> _repeated_inventoryUpgrades_codec =
			pb::FieldCodec.ForMessage(10, global::POGOProtos.Inventory.InventoryUpgrade.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The inventory upgrades_.
		/// </summary>
		private readonly pbc.RepeatedField<InventoryUpgrade> inventoryUpgrades_ = new pbc::RepeatedField<InventoryUpgrade>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryUpgrades"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgrades()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryUpgrades"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgrades(InventoryUpgrades other) : this()
		{
			inventoryUpgrades_ = other.inventoryUpgrades_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<InventoryUpgrades> Parser
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
				return global::POGOProtos.Inventory.InventoryUpgradesReflection.Descriptor.MessageTypes[0];
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
		/// Gets the inventory upgrades_.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<InventoryUpgrade> InventoryUpgrades_
		{
			get
			{
				return inventoryUpgrades_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="InventoryUpgrades"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgrades Clone()
		{
			return new InventoryUpgrades(this);
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
		public bool Equals(InventoryUpgrades other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!inventoryUpgrades_.Equals(other.inventoryUpgrades_))
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
			inventoryUpgrades_.WriteTo(output, _repeated_inventoryUpgrades_codec);
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
			size += inventoryUpgrades_.CalculateSize(_repeated_inventoryUpgrades_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(InventoryUpgrades other)
		{
			if (other == null)
			{
				return;
			}

			inventoryUpgrades_.Add(other.inventoryUpgrades_);
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
						inventoryUpgrades_.AddEntriesFrom(input, _repeated_inventoryUpgrades_codec);
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
			return Equals(other as InventoryUpgrades);
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
			hash ^= inventoryUpgrades_.GetHashCode();
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