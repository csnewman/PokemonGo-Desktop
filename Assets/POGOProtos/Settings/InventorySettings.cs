// --------------------------------------------------------------------------------------------------------------------
// <copyright file="InventorySettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/InventorySettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/InventorySettings.proto</summary>
	public static partial class InventorySettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/InventorySettings.proto</summary>
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
		/// Initializes static members of the <see cref="InventorySettingsReflection"/> class.
		/// </summary>
		static InventorySettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CitQT0dPUHJvdG9zL1NldHRpbmdzL0ludmVudG9yeVNldHRpbmdzLnByb3Rv",
						"EhNQT0dPUHJvdG9zLlNldHRpbmdzIoABChFJbnZlbnRvcnlTZXR0aW5ncxIT",
						"CgttYXhfcG9rZW1vbhgBIAEoBRIVCg1tYXhfYmFnX2l0ZW1zGAIgASgFEhQK",
						"DGJhc2VfcG9rZW1vbhgDIAEoBRIWCg5iYXNlX2JhZ19pdGVtcxgEIAEoBRIR",
						"CgliYXNlX2VnZ3MYBSABKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.InventorySettings),
							global::POGOProtos.Settings.InventorySettings.Parser,
							new[] { "MaxPokemon", "MaxBagItems", "BasePokemon", "BaseBagItems", "BaseEggs" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The inventory settings.
	/// </summary>
	public sealed partial class InventorySettings : pb::IMessage<InventorySettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "max_pokemon" field.</summary>
		public const int MaxPokemonFieldNumber = 1;

		/// <summary>Field number for the "max_bag_items" field.</summary>
		public const int MaxBagItemsFieldNumber = 2;

		/// <summary>Field number for the "base_pokemon" field.</summary>
		public const int BasePokemonFieldNumber = 3;

		/// <summary>Field number for the "base_bag_items" field.</summary>
		public const int BaseBagItemsFieldNumber = 4;

		/// <summary>Field number for the "base_eggs" field.</summary>
		public const int BaseEggsFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<InventorySettings> _parser =
			new pb::MessageParser<InventorySettings>(() => new InventorySettings());

		#endregion

		#region  Fields

		/// <summary>
		/// The base bag items_.
		/// </summary>
		private int baseBagItems_;

		/// <summary>
		/// The base eggs_.
		/// </summary>
		private int baseEggs_;

		/// <summary>
		/// The base pokemon_.
		/// </summary>
		private int basePokemon_;

		/// <summary>
		/// The max bag items_.
		/// </summary>
		private int maxBagItems_;

		/// <summary>
		/// The max pokemon_.
		/// </summary>
		private int maxPokemon_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="InventorySettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventorySettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="InventorySettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventorySettings(InventorySettings other) : this()
		{
			maxPokemon_ = other.maxPokemon_;
			maxBagItems_ = other.maxBagItems_;
			basePokemon_ = other.basePokemon_;
			baseBagItems_ = other.baseBagItems_;
			baseEggs_ = other.baseEggs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<InventorySettings> Parser
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
				return global::POGOProtos.Settings.InventorySettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the max pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaxPokemon
		{
			get
			{
				return maxPokemon_;
			}

			set
			{
				maxPokemon_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the max bag items.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaxBagItems
		{
			get
			{
				return maxBagItems_;
			}

			set
			{
				maxBagItems_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the base pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int BasePokemon
		{
			get
			{
				return basePokemon_;
			}

			set
			{
				basePokemon_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the base bag items.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int BaseBagItems
		{
			get
			{
				return baseBagItems_;
			}

			set
			{
				baseBagItems_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the base eggs.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int BaseEggs
		{
			get
			{
				return baseEggs_;
			}

			set
			{
				baseEggs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="InventorySettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventorySettings Clone()
		{
			return new InventorySettings(this);
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
		public bool Equals(InventorySettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (MaxPokemon != other.MaxPokemon)
			{
				return false;
			}

			if (MaxBagItems != other.MaxBagItems)
			{
				return false;
			}

			if (BasePokemon != other.BasePokemon)
			{
				return false;
			}

			if (BaseBagItems != other.BaseBagItems)
			{
				return false;
			}

			if (BaseEggs != other.BaseEggs)
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
			if (MaxPokemon != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(MaxPokemon);
			}

			if (MaxBagItems != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(MaxBagItems);
			}

			if (BasePokemon != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(BasePokemon);
			}

			if (BaseBagItems != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(BaseBagItems);
			}

			if (BaseEggs != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(BaseEggs);
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
			if (MaxPokemon != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPokemon);
			}

			if (MaxBagItems != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxBagItems);
			}

			if (BasePokemon != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(BasePokemon);
			}

			if (BaseBagItems != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseBagItems);
			}

			if (BaseEggs != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(BaseEggs);
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
		public void MergeFrom(InventorySettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.MaxPokemon != 0)
			{
				MaxPokemon = other.MaxPokemon;
			}

			if (other.MaxBagItems != 0)
			{
				MaxBagItems = other.MaxBagItems;
			}

			if (other.BasePokemon != 0)
			{
				BasePokemon = other.BasePokemon;
			}

			if (other.BaseBagItems != 0)
			{
				BaseBagItems = other.BaseBagItems;
			}

			if (other.BaseEggs != 0)
			{
				BaseEggs = other.BaseEggs;
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
						MaxPokemon = input.ReadInt32();
						break;
					}

					case 16:
					{
						MaxBagItems = input.ReadInt32();
						break;
					}

					case 24:
					{
						BasePokemon = input.ReadInt32();
						break;
					}

					case 32:
					{
						BaseBagItems = input.ReadInt32();
						break;
					}

					case 40:
					{
						BaseEggs = input.ReadInt32();
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
			return Equals(other as InventorySettings);
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
			if (MaxPokemon != 0)
			{
				hash ^= MaxPokemon.GetHashCode();
			}

			if (MaxBagItems != 0)
			{
				hash ^= MaxBagItems.GetHashCode();
			}

			if (BasePokemon != 0)
			{
				hash ^= BasePokemon.GetHashCode();
			}

			if (BaseBagItems != 0)
			{
				hash ^= BaseBagItems.GetHashCode();
			}

			if (BaseEggs != 0)
			{
				hash ^= BaseEggs.GetHashCode();
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