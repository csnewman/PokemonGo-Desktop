// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EggIncubator.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/EggIncubator.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/EggIncubator.proto</summary>
	public static partial class EggIncubatorReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/EggIncubator.proto</summary>
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
		/// Initializes static members of the <see cref="EggIncubatorReflection"/> class.
		/// </summary>
		static EggIncubatorReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CidQT0dPUHJvdG9zL0ludmVudG9yeS9FZ2dJbmN1YmF0b3IucHJvdG8SFFBP",
						"R09Qcm90b3MuSW52ZW50b3J5GiZQT0dPUHJvdG9zL0ludmVudG9yeS9JdGVt",
						"L0l0ZW1JZC5wcm90bxorUE9HT1Byb3Rvcy9JbnZlbnRvcnkvRWdnSW5jdWJh",
						"dG9yVHlwZS5wcm90byLtAQoMRWdnSW5jdWJhdG9yEgoKAmlkGAEgASgJEjIK",
						"B2l0ZW1faWQYAiABKA4yIS5QT0dPUHJvdG9zLkludmVudG9yeS5JdGVtLkl0",
						"ZW1JZBI+Cg5pbmN1YmF0b3JfdHlwZRgDIAEoDjImLlBPR09Qcm90b3MuSW52",
						"ZW50b3J5LkVnZ0luY3ViYXRvclR5cGUSFgoOdXNlc19yZW1haW5pbmcYBCAB",
						"KAUSEgoKcG9rZW1vbl9pZBgFIAEoBBIXCg9zdGFydF9rbV93YWxrZWQYBiAB",
						"KAESGAoQdGFyZ2V0X2ttX3dhbGtlZBgHIAEoAWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor,
					global::POGOProtos.Inventory.EggIncubatorTypeReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Inventory.EggIncubator),
							global::POGOProtos.Inventory.EggIncubator.Parser,
							new[] { "Id", "ItemId", "IncubatorType", "UsesRemaining", "PokemonId", "StartKmWalked", "TargetKmWalked" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The egg incubator.
	/// </summary>
	public sealed partial class EggIncubator : pb::IMessage<EggIncubator>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "id" field.</summary>
		public const int IdFieldNumber = 1;

		/// <summary>Field number for the "item_id" field.</summary>
		public const int ItemIdFieldNumber = 2;

		/// <summary>Field number for the "incubator_type" field.</summary>
		public const int IncubatorTypeFieldNumber = 3;

		/// <summary>Field number for the "uses_remaining" field.</summary>
		public const int UsesRemainingFieldNumber = 4;

		/// <summary>Field number for the "pokemon_id" field.</summary>
		public const int PokemonIdFieldNumber = 5;

		/// <summary>Field number for the "start_km_walked" field.</summary>
		public const int StartKmWalkedFieldNumber = 6;

		/// <summary>Field number for the "target_km_walked" field.</summary>
		public const int TargetKmWalkedFieldNumber = 7;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EggIncubator> _parser =
			new pb::MessageParser<EggIncubator>(() => new EggIncubator());

		#endregion

		#region  Fields

		/// <summary>
		/// The id_.
		/// </summary>
		private string id_ = string.Empty;

		/// <summary>
		/// The incubator type_.
		/// </summary>
		private EggIncubatorType incubatorType_ = 0;

		/// <summary>
		/// The item id_.
		/// </summary>
		private ItemId itemId_ = 0;

		/// <summary>
		/// The pokemon id_.
		/// </summary>
		private ulong pokemonId_;

		/// <summary>
		/// The start km walked_.
		/// </summary>
		private double startKmWalked_;

		/// <summary>
		/// The target km walked_.
		/// </summary>
		private double targetKmWalked_;

		/// <summary>
		/// The uses remaining_.
		/// </summary>
		private int usesRemaining_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EggIncubator"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubator()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EggIncubator"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubator(EggIncubator other) : this()
		{
			id_ = other.id_;
			itemId_ = other.itemId_;
			incubatorType_ = other.incubatorType_;
			usesRemaining_ = other.usesRemaining_;
			pokemonId_ = other.pokemonId_;
			startKmWalked_ = other.startKmWalked_;
			targetKmWalked_ = other.targetKmWalked_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EggIncubator> Parser
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
				return global::POGOProtos.Inventory.EggIncubatorReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Id
		{
			get
			{
				return id_;
			}

			set
			{
				id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
		/// Gets or sets the incubator type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubatorType IncubatorType
		{
			get
			{
				return incubatorType_;
			}

			set
			{
				incubatorType_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the uses remaining.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int UsesRemaining
		{
			get
			{
				return usesRemaining_;
			}

			set
			{
				usesRemaining_ = value;
			}
		}

		/// <summary>
		///  TODO: Check if is PokemonType
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong PokemonId
		{
			get
			{
				return pokemonId_;
			}

			set
			{
				pokemonId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the start km walked.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double StartKmWalked
		{
			get
			{
				return startKmWalked_;
			}

			set
			{
				startKmWalked_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the target km walked.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double TargetKmWalked
		{
			get
			{
				return targetKmWalked_;
			}

			set
			{
				targetKmWalked_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="EggIncubator"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubator Clone()
		{
			return new EggIncubator(this);
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
		public bool Equals(EggIncubator other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Id != other.Id)
			{
				return false;
			}

			if (ItemId != other.ItemId)
			{
				return false;
			}

			if (IncubatorType != other.IncubatorType)
			{
				return false;
			}

			if (UsesRemaining != other.UsesRemaining)
			{
				return false;
			}

			if (PokemonId != other.PokemonId)
			{
				return false;
			}

			if (StartKmWalked != other.StartKmWalked)
			{
				return false;
			}

			if (TargetKmWalked != other.TargetKmWalked)
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
			if (Id.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Id);
			}

			if (ItemId != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)ItemId);
			}

			if (IncubatorType != 0)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)IncubatorType);
			}

			if (UsesRemaining != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(UsesRemaining);
			}

			if (PokemonId != 0UL)
			{
				output.WriteRawTag(40);
				output.WriteUInt64(PokemonId);
			}

			if (StartKmWalked != 0D)
			{
				output.WriteRawTag(49);
				output.WriteDouble(StartKmWalked);
			}

			if (TargetKmWalked != 0D)
			{
				output.WriteRawTag(57);
				output.WriteDouble(TargetKmWalked);
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
			if (Id.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
			}

			if (ItemId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ItemId);
			}

			if (IncubatorType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)IncubatorType);
			}

			if (UsesRemaining != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(UsesRemaining);
			}

			if (PokemonId != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PokemonId);
			}

			if (StartKmWalked != 0D)
			{
				size += 1 + 8;
			}

			if (TargetKmWalked != 0D)
			{
				size += 1 + 8;
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
		public void MergeFrom(EggIncubator other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Id.Length != 0)
			{
				Id = other.Id;
			}

			if (other.ItemId != 0)
			{
				ItemId = other.ItemId;
			}

			if (other.IncubatorType != 0)
			{
				IncubatorType = other.IncubatorType;
			}

			if (other.UsesRemaining != 0)
			{
				UsesRemaining = other.UsesRemaining;
			}

			if (other.PokemonId != 0UL)
			{
				PokemonId = other.PokemonId;
			}

			if (other.StartKmWalked != 0D)
			{
				StartKmWalked = other.StartKmWalked;
			}

			if (other.TargetKmWalked != 0D)
			{
				TargetKmWalked = other.TargetKmWalked;
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
					case 10:
					{
						Id = input.ReadString();
						break;
					}

					case 16:
					{
						itemId_ = (global::POGOProtos.Inventory.Item.ItemId)input.ReadEnum();
						break;
					}

					case 24:
					{
						incubatorType_ = (global::POGOProtos.Inventory.EggIncubatorType)input.ReadEnum();
						break;
					}

					case 32:
					{
						UsesRemaining = input.ReadInt32();
						break;
					}

					case 40:
					{
						PokemonId = input.ReadUInt64();
						break;
					}

					case 49:
					{
						StartKmWalked = input.ReadDouble();
						break;
					}

					case 57:
					{
						TargetKmWalked = input.ReadDouble();
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
			return Equals(other as EggIncubator);
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
			if (Id.Length != 0)
			{
				hash ^= Id.GetHashCode();
			}

			if (ItemId != 0)
			{
				hash ^= ItemId.GetHashCode();
			}

			if (IncubatorType != 0)
			{
				hash ^= IncubatorType.GetHashCode();
			}

			if (UsesRemaining != 0)
			{
				hash ^= UsesRemaining.GetHashCode();
			}

			if (PokemonId != 0UL)
			{
				hash ^= PokemonId.GetHashCode();
			}

			if (StartKmWalked != 0D)
			{
				hash ^= StartKmWalked.GetHashCode();
			}

			if (TargetKmWalked != 0D)
			{
				hash ^= TargetKmWalked.GetHashCode();
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