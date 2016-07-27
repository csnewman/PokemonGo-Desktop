// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CatchPokemonMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/CatchPokemonMessage.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/CatchPokemonMessage.proto</summary>
	public static partial class CatchPokemonMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/CatchPokemonMessage.proto</summary>
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
		/// Initializes static members of the <see cref="CatchPokemonMessageReflection"/> class.
		/// </summary>
		static CatchPokemonMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkFQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvQ2F0",
						"Y2hQb2tlbW9uTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5n",
						"LlJlcXVlc3RzLk1lc3NhZ2VzGiZQT0dPUHJvdG9zL0ludmVudG9yeS9JdGVt",
						"L0l0ZW1JZC5wcm90byLmAQoTQ2F0Y2hQb2tlbW9uTWVzc2FnZRIUCgxlbmNv",
						"dW50ZXJfaWQYASABKAYSMwoIcG9rZWJhbGwYAiABKA4yIS5QT0dPUHJvdG9z",
						"LkludmVudG9yeS5JdGVtLkl0ZW1JZBIfChdub3JtYWxpemVkX3JldGljbGVf",
						"c2l6ZRgDIAEoARIWCg5zcGF3bl9wb2ludF9pZBgEIAEoCRITCgtoaXRfcG9r",
						"ZW1vbhgFIAEoCBIVCg1zcGluX21vZGlmaWVyGAYgASgBEh8KF25vcm1hbGl6",
						"ZWRfaGl0X3Bvc2l0aW9uGAcgASgBYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.Item.ItemIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.CatchPokemonMessage),
							global::POGOProtos.Networking.Requests.Messages.CatchPokemonMessage.Parser,
							new[]
							{
								"EncounterId", "Pokeball", "NormalizedReticleSize", "SpawnPointId", "HitPokemon", "SpinModifier",
								"NormalizedHitPosition"
							},
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The catch pokemon message.
	/// </summary>
	public sealed partial class CatchPokemonMessage : pb::IMessage<CatchPokemonMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "encounter_id" field.</summary>
		public const int EncounterIdFieldNumber = 1;

		/// <summary>Field number for the "pokeball" field.</summary>
		public const int PokeballFieldNumber = 2;

		/// <summary>Field number for the "normalized_reticle_size" field.</summary>
		public const int NormalizedReticleSizeFieldNumber = 3;

		/// <summary>Field number for the "spawn_point_id" field.</summary>
		public const int SpawnPointIdFieldNumber = 4;

		/// <summary>Field number for the "hit_pokemon" field.</summary>
		public const int HitPokemonFieldNumber = 5;

		/// <summary>Field number for the "spin_modifier" field.</summary>
		public const int SpinModifierFieldNumber = 6;

		/// <summary>Field number for the "normalized_hit_position" field.</summary>
		public const int NormalizedHitPositionFieldNumber = 7;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<CatchPokemonMessage> _parser =
			new pb::MessageParser<CatchPokemonMessage>(() => new CatchPokemonMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The encounter id_.
		/// </summary>
		private ulong encounterId_;

		/// <summary>
		/// The hit pokemon_.
		/// </summary>
		private bool hitPokemon_;

		/// <summary>
		/// The normalized hit position_.
		/// </summary>
		private double normalizedHitPosition_;

		/// <summary>
		/// The normalized reticle size_.
		/// </summary>
		private double normalizedReticleSize_;

		/// <summary>
		/// The pokeball_.
		/// </summary>
		private ItemId pokeball_ = 0;

		/// <summary>
		/// The spawn point id_.
		/// </summary>
		private string spawnPointId_ = string.Empty;

		/// <summary>
		/// The spin modifier_.
		/// </summary>
		private double spinModifier_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CatchPokemonMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CatchPokemonMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CatchPokemonMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CatchPokemonMessage(CatchPokemonMessage other) : this()
		{
			encounterId_ = other.encounterId_;
			pokeball_ = other.pokeball_;
			normalizedReticleSize_ = other.normalizedReticleSize_;
			spawnPointId_ = other.spawnPointId_;
			hitPokemon_ = other.hitPokemon_;
			spinModifier_ = other.spinModifier_;
			normalizedHitPosition_ = other.normalizedHitPosition_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<CatchPokemonMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.CatchPokemonMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the encounter id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong EncounterId
		{
			get
			{
				return encounterId_;
			}

			set
			{
				encounterId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the pokeball.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ItemId Pokeball
		{
			get
			{
				return pokeball_;
			}

			set
			{
				pokeball_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the normalized reticle size.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double NormalizedReticleSize
		{
			get
			{
				return normalizedReticleSize_;
			}

			set
			{
				normalizedReticleSize_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the spawn point id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string SpawnPointId
		{
			get
			{
				return spawnPointId_;
			}

			set
			{
				spawnPointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether hit pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool HitPokemon
		{
			get
			{
				return hitPokemon_;
			}

			set
			{
				hitPokemon_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the spin modifier.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double SpinModifier
		{
			get
			{
				return spinModifier_;
			}

			set
			{
				spinModifier_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the normalized hit position.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double NormalizedHitPosition
		{
			get
			{
				return normalizedHitPosition_;
			}

			set
			{
				normalizedHitPosition_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="CatchPokemonMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CatchPokemonMessage Clone()
		{
			return new CatchPokemonMessage(this);
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
		public bool Equals(CatchPokemonMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (EncounterId != other.EncounterId)
			{
				return false;
			}

			if (Pokeball != other.Pokeball)
			{
				return false;
			}

			if (NormalizedReticleSize != other.NormalizedReticleSize)
			{
				return false;
			}

			if (SpawnPointId != other.SpawnPointId)
			{
				return false;
			}

			if (HitPokemon != other.HitPokemon)
			{
				return false;
			}

			if (SpinModifier != other.SpinModifier)
			{
				return false;
			}

			if (NormalizedHitPosition != other.NormalizedHitPosition)
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
			if (EncounterId != 0UL)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(EncounterId);
			}

			if (Pokeball != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)Pokeball);
			}

			if (NormalizedReticleSize != 0D)
			{
				output.WriteRawTag(25);
				output.WriteDouble(NormalizedReticleSize);
			}

			if (SpawnPointId.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(SpawnPointId);
			}

			if (HitPokemon != false)
			{
				output.WriteRawTag(40);
				output.WriteBool(HitPokemon);
			}

			if (SpinModifier != 0D)
			{
				output.WriteRawTag(49);
				output.WriteDouble(SpinModifier);
			}

			if (NormalizedHitPosition != 0D)
			{
				output.WriteRawTag(57);
				output.WriteDouble(NormalizedHitPosition);
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
			if (EncounterId != 0UL)
			{
				size += 1 + 8;
			}

			if (Pokeball != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Pokeball);
			}

			if (NormalizedReticleSize != 0D)
			{
				size += 1 + 8;
			}

			if (SpawnPointId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointId);
			}

			if (HitPokemon != false)
			{
				size += 1 + 1;
			}

			if (SpinModifier != 0D)
			{
				size += 1 + 8;
			}

			if (NormalizedHitPosition != 0D)
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
		public void MergeFrom(CatchPokemonMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.EncounterId != 0UL)
			{
				EncounterId = other.EncounterId;
			}

			if (other.Pokeball != 0)
			{
				Pokeball = other.Pokeball;
			}

			if (other.NormalizedReticleSize != 0D)
			{
				NormalizedReticleSize = other.NormalizedReticleSize;
			}

			if (other.SpawnPointId.Length != 0)
			{
				SpawnPointId = other.SpawnPointId;
			}

			if (other.HitPokemon != false)
			{
				HitPokemon = other.HitPokemon;
			}

			if (other.SpinModifier != 0D)
			{
				SpinModifier = other.SpinModifier;
			}

			if (other.NormalizedHitPosition != 0D)
			{
				NormalizedHitPosition = other.NormalizedHitPosition;
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
					case 9:
					{
						EncounterId = input.ReadFixed64();
						break;
					}

					case 16:
					{
						pokeball_ = (global::POGOProtos.Inventory.Item.ItemId)input.ReadEnum();
						break;
					}

					case 25:
					{
						NormalizedReticleSize = input.ReadDouble();
						break;
					}

					case 34:
					{
						SpawnPointId = input.ReadString();
						break;
					}

					case 40:
					{
						HitPokemon = input.ReadBool();
						break;
					}

					case 49:
					{
						SpinModifier = input.ReadDouble();
						break;
					}

					case 57:
					{
						NormalizedHitPosition = input.ReadDouble();
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
			return Equals(other as CatchPokemonMessage);
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
			if (EncounterId != 0UL)
			{
				hash ^= EncounterId.GetHashCode();
			}

			if (Pokeball != 0)
			{
				hash ^= Pokeball.GetHashCode();
			}

			if (NormalizedReticleSize != 0D)
			{
				hash ^= NormalizedReticleSize.GetHashCode();
			}

			if (SpawnPointId.Length != 0)
			{
				hash ^= SpawnPointId.GetHashCode();
			}

			if (HitPokemon != false)
			{
				hash ^= HitPokemon.GetHashCode();
			}

			if (SpinModifier != 0D)
			{
				hash ^= SpinModifier.GetHashCode();
			}

			if (NormalizedHitPosition != 0D)
			{
				hash ^= NormalizedHitPosition.GetHashCode();
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