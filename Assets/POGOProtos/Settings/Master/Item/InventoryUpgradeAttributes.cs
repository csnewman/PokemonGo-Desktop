// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventoryUpgradeAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Item/InventoryUpgradeAttributes.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Inventory;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master.Item
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/InventoryUpgradeAttributes.proto</summary>
	public static partial class InventoryUpgradeAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Item/InventoryUpgradeAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="InventoryUpgradeAttributesReflection"/> class.
		/// </summary>
		static InventoryUpgradeAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkBQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0ludmVudG9yeVVw",
						"Z3JhZGVBdHRyaWJ1dGVzLnByb3RvEh9QT0dPUHJvdG9zLlNldHRpbmdzLk1h",
						"c3Rlci5JdGVtGi9QT0dPUHJvdG9zL0ludmVudG9yeS9JbnZlbnRvcnlVcGdy",
						"YWRlVHlwZS5wcm90byJ6ChpJbnZlbnRvcnlVcGdyYWRlQXR0cmlidXRlcxIa",
						"ChJhZGRpdGlvbmFsX3N0b3JhZ2UYASABKAUSQAoMdXBncmFkZV90eXBlGAIg",
						"ASgOMiouUE9HT1Byb3Rvcy5JbnZlbnRvcnkuSW52ZW50b3J5VXBncmFkZVR5",
						"cGViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.InventoryUpgradeTypeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Item.InventoryUpgradeAttributes),
							global::POGOProtos.Settings.Master.Item.InventoryUpgradeAttributes.Parser,
							new[] { "AdditionalStorage", "UpgradeType" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The inventory upgrade attributes.
	/// </summary>
	public sealed partial class InventoryUpgradeAttributes : pb::IMessage<InventoryUpgradeAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "additional_storage" field.</summary>
		public const int AdditionalStorageFieldNumber = 1;

		/// <summary>Field number for the "upgrade_type" field.</summary>
		public const int UpgradeTypeFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<InventoryUpgradeAttributes> _parser =
			new pb::MessageParser<InventoryUpgradeAttributes>(() => new InventoryUpgradeAttributes());

		#endregion

		#region  Fields

		/// <summary>
		/// The additional storage_.
		/// </summary>
		private int additionalStorage_;

		/// <summary>
		/// The upgrade type_.
		/// </summary>
		private InventoryUpgradeType upgradeType_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryUpgradeAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgradeAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InventoryUpgradeAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgradeAttributes(InventoryUpgradeAttributes other) : this()
		{
			additionalStorage_ = other.additionalStorage_;
			upgradeType_ = other.upgradeType_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<InventoryUpgradeAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Item.InventoryUpgradeAttributesReflection.Descriptor.MessageTypes[0];
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

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="InventoryUpgradeAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventoryUpgradeAttributes Clone()
		{
			return new InventoryUpgradeAttributes(this);
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
		public bool Equals(InventoryUpgradeAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (AdditionalStorage != other.AdditionalStorage)
			{
				return false;
			}

			if (UpgradeType != other.UpgradeType)
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
			if (AdditionalStorage != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(AdditionalStorage);
			}

			if (UpgradeType != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)UpgradeType);
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
			if (AdditionalStorage != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(AdditionalStorage);
			}

			if (UpgradeType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)UpgradeType);
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
		public void MergeFrom(InventoryUpgradeAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.AdditionalStorage != 0)
			{
				AdditionalStorage = other.AdditionalStorage;
			}

			if (other.UpgradeType != 0)
			{
				UpgradeType = other.UpgradeType;
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
						AdditionalStorage = input.ReadInt32();
						break;
					}

					case 16:
					{
						upgradeType_ = (global::POGOProtos.Inventory.InventoryUpgradeType)input.ReadEnum();
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
			return Equals(other as InventoryUpgradeAttributes);
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
			if (AdditionalStorage != 0)
			{
				hash ^= AdditionalStorage.GetHashCode();
			}

			if (UpgradeType != 0)
			{
				hash ^= UpgradeType.GetHashCode();
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