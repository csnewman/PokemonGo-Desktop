// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoveSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/MoveSettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/MoveSettings.proto</summary>
	public static partial class MoveSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/MoveSettings.proto</summary>
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
		/// Initializes static members of the <see cref="MoveSettingsReflection"/> class.
		/// </summary>
		static MoveSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ci1QT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9Nb3ZlU2V0dGluZ3MucHJv",
						"dG8SGlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyGiJQT0dPUHJvdG9zL0Vu",
						"dW1zL1Bva2Vtb25UeXBlLnByb3RvGipQT0dPUHJvdG9zL0VudW1zL1Bva2Vt",
						"b25Nb3ZlbWVudFR5cGUucHJvdG8iuQMKDE1vdmVTZXR0aW5ncxI6Cgttb3Zl",
						"bWVudF9pZBgBIAEoDjIlLlBPR09Qcm90b3MuRW51bXMuUG9rZW1vbk1vdmVt",
						"ZW50VHlwZRIUCgxhbmltYXRpb25faWQYAiABKAUSMwoMcG9rZW1vbl90eXBl",
						"GAMgASgOMh0uUE9HT1Byb3Rvcy5FbnVtcy5Qb2tlbW9uVHlwZRINCgVwb3dl",
						"chgEIAEoAhIXCg9hY2N1cmFjeV9jaGFuY2UYBSABKAISFwoPY3JpdGljYWxf",
						"Y2hhbmNlGAYgASgCEhMKC2hlYWxfc2NhbGFyGAcgASgCEhsKE3N0YW1pbmFf",
						"bG9zc19zY2FsYXIYCCABKAISGQoRdHJhaW5lcl9sZXZlbF9taW4YCSABKAUS",
						"GQoRdHJhaW5lcl9sZXZlbF9tYXgYCiABKAUSEAoIdmZ4X25hbWUYCyABKAkS",
						"EwoLZHVyYXRpb25fbXMYDCABKAUSHgoWZGFtYWdlX3dpbmRvd19zdGFydF9t",
						"cxgNIAEoBRIcChRkYW1hZ2Vfd2luZG93X2VuZF9tcxgOIAEoBRIUCgxlbmVy",
						"Z3lfZGVsdGEYDyABKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Enums.PokemonTypeReflection.Descriptor,
					global::POGOProtos.Enums.PokemonMovementTypeReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.MoveSettings),
							global::POGOProtos.Settings.Master.MoveSettings.Parser,
							new[]
							{
								"MovementId", "AnimationId", "PokemonType", "Power", "AccuracyChance", "CriticalChance", "HealScalar",
								"StaminaLossScalar", "TrainerLevelMin", "TrainerLevelMax", "VfxName", "DurationMs", "DamageWindowStartMs",
								"DamageWindowEndMs", "EnergyDelta"
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
	/// The move settings.
	/// </summary>
	public sealed partial class MoveSettings : pb::IMessage<MoveSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "movement_id" field.</summary>
		public const int MovementIdFieldNumber = 1;

		/// <summary>Field number for the "animation_id" field.</summary>
		public const int AnimationIdFieldNumber = 2;

		/// <summary>Field number for the "pokemon_type" field.</summary>
		public const int PokemonTypeFieldNumber = 3;

		/// <summary>Field number for the "power" field.</summary>
		public const int PowerFieldNumber = 4;

		/// <summary>Field number for the "accuracy_chance" field.</summary>
		public const int AccuracyChanceFieldNumber = 5;

		/// <summary>Field number for the "critical_chance" field.</summary>
		public const int CriticalChanceFieldNumber = 6;

		/// <summary>Field number for the "heal_scalar" field.</summary>
		public const int HealScalarFieldNumber = 7;

		/// <summary>Field number for the "stamina_loss_scalar" field.</summary>
		public const int StaminaLossScalarFieldNumber = 8;

		/// <summary>Field number for the "trainer_level_min" field.</summary>
		public const int TrainerLevelMinFieldNumber = 9;

		/// <summary>Field number for the "trainer_level_max" field.</summary>
		public const int TrainerLevelMaxFieldNumber = 10;

		/// <summary>Field number for the "vfx_name" field.</summary>
		public const int VfxNameFieldNumber = 11;

		/// <summary>Field number for the "duration_ms" field.</summary>
		public const int DurationMsFieldNumber = 12;

		/// <summary>Field number for the "damage_window_start_ms" field.</summary>
		public const int DamageWindowStartMsFieldNumber = 13;

		/// <summary>Field number for the "damage_window_end_ms" field.</summary>
		public const int DamageWindowEndMsFieldNumber = 14;

		/// <summary>Field number for the "energy_delta" field.</summary>
		public const int EnergyDeltaFieldNumber = 15;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<MoveSettings> _parser =
			new pb::MessageParser<MoveSettings>(() => new MoveSettings());

		#endregion

		#region  Fields

		/// <summary>
		/// The accuracy chance_.
		/// </summary>
		private float accuracyChance_;

		/// <summary>
		/// The animation id_.
		/// </summary>
		private int animationId_;

		/// <summary>
		/// The critical chance_.
		/// </summary>
		private float criticalChance_;

		/// <summary>
		/// The damage window end ms_.
		/// </summary>
		private int damageWindowEndMs_;

		/// <summary>
		/// The damage window start ms_.
		/// </summary>
		private int damageWindowStartMs_;

		/// <summary>
		/// The duration ms_.
		/// </summary>
		private int durationMs_;

		/// <summary>
		/// The energy delta_.
		/// </summary>
		private int energyDelta_;

		/// <summary>
		/// The heal scalar_.
		/// </summary>
		private float healScalar_;

		/// <summary>
		/// The movement id_.
		/// </summary>
		private PokemonMovementType movementId_ = 0;

		/// <summary>
		/// The pokemon type_.
		/// </summary>
		private PokemonType pokemonType_ = 0;

		/// <summary>
		/// The power_.
		/// </summary>
		private float power_;

		/// <summary>
		/// The stamina loss scalar_.
		/// </summary>
		private float staminaLossScalar_;

		/// <summary>
		/// The trainer level max_.
		/// </summary>
		private int trainerLevelMax_;

		/// <summary>
		/// The trainer level min_.
		/// </summary>
		private int trainerLevelMin_;

		/// <summary>
		/// The vfx name_.
		/// </summary>
		private string vfxName_ = string.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="MoveSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MoveSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MoveSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MoveSettings(MoveSettings other) : this()
		{
			movementId_ = other.movementId_;
			animationId_ = other.animationId_;
			pokemonType_ = other.pokemonType_;
			power_ = other.power_;
			accuracyChance_ = other.accuracyChance_;
			criticalChance_ = other.criticalChance_;
			healScalar_ = other.healScalar_;
			staminaLossScalar_ = other.staminaLossScalar_;
			trainerLevelMin_ = other.trainerLevelMin_;
			trainerLevelMax_ = other.trainerLevelMax_;
			vfxName_ = other.vfxName_;
			durationMs_ = other.durationMs_;
			damageWindowStartMs_ = other.damageWindowStartMs_;
			damageWindowEndMs_ = other.damageWindowEndMs_;
			energyDelta_ = other.energyDelta_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<MoveSettings> Parser
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
				return global::POGOProtos.Settings.Master.MoveSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the movement id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonMovementType MovementId
		{
			get
			{
				return movementId_;
			}

			set
			{
				movementId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the animation id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int AnimationId
		{
			get
			{
				return animationId_;
			}

			set
			{
				animationId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the pokemon type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonType PokemonType
		{
			get
			{
				return pokemonType_;
			}

			set
			{
				pokemonType_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the power.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float Power
		{
			get
			{
				return power_;
			}

			set
			{
				power_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the accuracy chance.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float AccuracyChance
		{
			get
			{
				return accuracyChance_;
			}

			set
			{
				accuracyChance_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the critical chance.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float CriticalChance
		{
			get
			{
				return criticalChance_;
			}

			set
			{
				criticalChance_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the heal scalar.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float HealScalar
		{
			get
			{
				return healScalar_;
			}

			set
			{
				healScalar_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the stamina loss scalar.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float StaminaLossScalar
		{
			get
			{
				return staminaLossScalar_;
			}

			set
			{
				staminaLossScalar_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the trainer level min.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int TrainerLevelMin
		{
			get
			{
				return trainerLevelMin_;
			}

			set
			{
				trainerLevelMin_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the trainer level max.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int TrainerLevelMax
		{
			get
			{
				return trainerLevelMax_;
			}

			set
			{
				trainerLevelMax_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the vfx name.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string VfxName
		{
			get
			{
				return vfxName_;
			}

			set
			{
				vfxName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the duration ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int DurationMs
		{
			get
			{
				return durationMs_;
			}

			set
			{
				durationMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the damage window start ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int DamageWindowStartMs
		{
			get
			{
				return damageWindowStartMs_;
			}

			set
			{
				damageWindowStartMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the damage window end ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int DamageWindowEndMs
		{
			get
			{
				return damageWindowEndMs_;
			}

			set
			{
				damageWindowEndMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the energy delta.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int EnergyDelta
		{
			get
			{
				return energyDelta_;
			}

			set
			{
				energyDelta_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="MoveSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MoveSettings Clone()
		{
			return new MoveSettings(this);
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
		public bool Equals(MoveSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (MovementId != other.MovementId)
			{
				return false;
			}

			if (AnimationId != other.AnimationId)
			{
				return false;
			}

			if (PokemonType != other.PokemonType)
			{
				return false;
			}

			if (Power != other.Power)
			{
				return false;
			}

			if (AccuracyChance != other.AccuracyChance)
			{
				return false;
			}

			if (CriticalChance != other.CriticalChance)
			{
				return false;
			}

			if (HealScalar != other.HealScalar)
			{
				return false;
			}

			if (StaminaLossScalar != other.StaminaLossScalar)
			{
				return false;
			}

			if (TrainerLevelMin != other.TrainerLevelMin)
			{
				return false;
			}

			if (TrainerLevelMax != other.TrainerLevelMax)
			{
				return false;
			}

			if (VfxName != other.VfxName)
			{
				return false;
			}

			if (DurationMs != other.DurationMs)
			{
				return false;
			}

			if (DamageWindowStartMs != other.DamageWindowStartMs)
			{
				return false;
			}

			if (DamageWindowEndMs != other.DamageWindowEndMs)
			{
				return false;
			}

			if (EnergyDelta != other.EnergyDelta)
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
			if (MovementId != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)MovementId);
			}

			if (AnimationId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(AnimationId);
			}

			if (PokemonType != 0)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)PokemonType);
			}

			if (Power != 0F)
			{
				output.WriteRawTag(37);
				output.WriteFloat(Power);
			}

			if (AccuracyChance != 0F)
			{
				output.WriteRawTag(45);
				output.WriteFloat(AccuracyChance);
			}

			if (CriticalChance != 0F)
			{
				output.WriteRawTag(53);
				output.WriteFloat(CriticalChance);
			}

			if (HealScalar != 0F)
			{
				output.WriteRawTag(61);
				output.WriteFloat(HealScalar);
			}

			if (StaminaLossScalar != 0F)
			{
				output.WriteRawTag(69);
				output.WriteFloat(StaminaLossScalar);
			}

			if (TrainerLevelMin != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(TrainerLevelMin);
			}

			if (TrainerLevelMax != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(TrainerLevelMax);
			}

			if (VfxName.Length != 0)
			{
				output.WriteRawTag(90);
				output.WriteString(VfxName);
			}

			if (DurationMs != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(DurationMs);
			}

			if (DamageWindowStartMs != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(DamageWindowStartMs);
			}

			if (DamageWindowEndMs != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(DamageWindowEndMs);
			}

			if (EnergyDelta != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(EnergyDelta);
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
			if (MovementId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)MovementId);
			}

			if (AnimationId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(AnimationId);
			}

			if (PokemonType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonType);
			}

			if (Power != 0F)
			{
				size += 1 + 4;
			}

			if (AccuracyChance != 0F)
			{
				size += 1 + 4;
			}

			if (CriticalChance != 0F)
			{
				size += 1 + 4;
			}

			if (HealScalar != 0F)
			{
				size += 1 + 4;
			}

			if (StaminaLossScalar != 0F)
			{
				size += 1 + 4;
			}

			if (TrainerLevelMin != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(TrainerLevelMin);
			}

			if (TrainerLevelMax != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(TrainerLevelMax);
			}

			if (VfxName.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(VfxName);
			}

			if (DurationMs != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(DurationMs);
			}

			if (DamageWindowStartMs != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(DamageWindowStartMs);
			}

			if (DamageWindowEndMs != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(DamageWindowEndMs);
			}

			if (EnergyDelta != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(EnergyDelta);
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
		public void MergeFrom(MoveSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.MovementId != 0)
			{
				MovementId = other.MovementId;
			}

			if (other.AnimationId != 0)
			{
				AnimationId = other.AnimationId;
			}

			if (other.PokemonType != 0)
			{
				PokemonType = other.PokemonType;
			}

			if (other.Power != 0F)
			{
				Power = other.Power;
			}

			if (other.AccuracyChance != 0F)
			{
				AccuracyChance = other.AccuracyChance;
			}

			if (other.CriticalChance != 0F)
			{
				CriticalChance = other.CriticalChance;
			}

			if (other.HealScalar != 0F)
			{
				HealScalar = other.HealScalar;
			}

			if (other.StaminaLossScalar != 0F)
			{
				StaminaLossScalar = other.StaminaLossScalar;
			}

			if (other.TrainerLevelMin != 0)
			{
				TrainerLevelMin = other.TrainerLevelMin;
			}

			if (other.TrainerLevelMax != 0)
			{
				TrainerLevelMax = other.TrainerLevelMax;
			}

			if (other.VfxName.Length != 0)
			{
				VfxName = other.VfxName;
			}

			if (other.DurationMs != 0)
			{
				DurationMs = other.DurationMs;
			}

			if (other.DamageWindowStartMs != 0)
			{
				DamageWindowStartMs = other.DamageWindowStartMs;
			}

			if (other.DamageWindowEndMs != 0)
			{
				DamageWindowEndMs = other.DamageWindowEndMs;
			}

			if (other.EnergyDelta != 0)
			{
				EnergyDelta = other.EnergyDelta;
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
						movementId_ = (global::POGOProtos.Enums.PokemonMovementType)input.ReadEnum();
						break;
					}

					case 16:
					{
						AnimationId = input.ReadInt32();
						break;
					}

					case 24:
					{
						pokemonType_ = (global::POGOProtos.Enums.PokemonType)input.ReadEnum();
						break;
					}

					case 37:
					{
						Power = input.ReadFloat();
						break;
					}

					case 45:
					{
						AccuracyChance = input.ReadFloat();
						break;
					}

					case 53:
					{
						CriticalChance = input.ReadFloat();
						break;
					}

					case 61:
					{
						HealScalar = input.ReadFloat();
						break;
					}

					case 69:
					{
						StaminaLossScalar = input.ReadFloat();
						break;
					}

					case 72:
					{
						TrainerLevelMin = input.ReadInt32();
						break;
					}

					case 80:
					{
						TrainerLevelMax = input.ReadInt32();
						break;
					}

					case 90:
					{
						VfxName = input.ReadString();
						break;
					}

					case 96:
					{
						DurationMs = input.ReadInt32();
						break;
					}

					case 104:
					{
						DamageWindowStartMs = input.ReadInt32();
						break;
					}

					case 112:
					{
						DamageWindowEndMs = input.ReadInt32();
						break;
					}

					case 120:
					{
						EnergyDelta = input.ReadInt32();
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
			return Equals(other as MoveSettings);
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
			if (MovementId != 0)
			{
				hash ^= MovementId.GetHashCode();
			}

			if (AnimationId != 0)
			{
				hash ^= AnimationId.GetHashCode();
			}

			if (PokemonType != 0)
			{
				hash ^= PokemonType.GetHashCode();
			}

			if (Power != 0F)
			{
				hash ^= Power.GetHashCode();
			}

			if (AccuracyChance != 0F)
			{
				hash ^= AccuracyChance.GetHashCode();
			}

			if (CriticalChance != 0F)
			{
				hash ^= CriticalChance.GetHashCode();
			}

			if (HealScalar != 0F)
			{
				hash ^= HealScalar.GetHashCode();
			}

			if (StaminaLossScalar != 0F)
			{
				hash ^= StaminaLossScalar.GetHashCode();
			}

			if (TrainerLevelMin != 0)
			{
				hash ^= TrainerLevelMin.GetHashCode();
			}

			if (TrainerLevelMax != 0)
			{
				hash ^= TrainerLevelMax.GetHashCode();
			}

			if (VfxName.Length != 0)
			{
				hash ^= VfxName.GetHashCode();
			}

			if (DurationMs != 0)
			{
				hash ^= DurationMs.GetHashCode();
			}

			if (DamageWindowStartMs != 0)
			{
				hash ^= DamageWindowStartMs.GetHashCode();
			}

			if (DamageWindowEndMs != 0)
			{
				hash ^= DamageWindowEndMs.GetHashCode();
			}

			if (EnergyDelta != 0)
			{
				hash ^= EnergyDelta.GetHashCode();
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