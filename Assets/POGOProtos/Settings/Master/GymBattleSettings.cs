// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GymBattleSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/GymBattleSettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/GymBattleSettings.proto</summary>
	public static partial class GymBattleSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/GymBattleSettings.proto</summary>
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
		/// Initializes static members of the <see cref="GymBattleSettingsReflection"/> class.
		/// </summary>
		static GymBattleSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjJQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9HeW1CYXR0bGVTZXR0aW5n",
						"cy5wcm90bxIaUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIixgMKEUd5bUJh",
						"dHRsZVNldHRpbmdzEhYKDmVuZXJneV9wZXJfc2VjGAEgASgCEhkKEWRvZGdl",
						"X2VuZXJneV9jb3N0GAIgASgCEhgKEHJldGFyZ2V0X3NlY29uZHMYAyABKAIS",
						"HQoVZW5lbXlfYXR0YWNrX2ludGVydmFsGAQgASgCEh4KFmF0dGFja19zZXJ2",
						"ZXJfaW50ZXJ2YWwYBSABKAISHgoWcm91bmRfZHVyYXRpb25fc2Vjb25kcxgG",
						"IAEoAhIjChtib251c190aW1lX3Blcl9hbGx5X3NlY29uZHMYByABKAISJAoc",
						"bWF4aW11bV9hdHRhY2tlcnNfcGVyX2JhdHRsZRgIIAEoBRIpCiFzYW1lX3R5",
						"cGVfYXR0YWNrX2JvbnVzX211bHRpcGxpZXIYCSABKAISFgoObWF4aW11bV9l",
						"bmVyZ3kYCiABKAUSJAocZW5lcmd5X2RlbHRhX3Blcl9oZWFsdGhfbG9zdBgL",
						"IAEoAhIZChFkb2RnZV9kdXJhdGlvbl9tcxgMIAEoBRIcChRtaW5pbXVtX3Bs",
						"YXllcl9sZXZlbBgNIAEoBRIYChBzd2FwX2R1cmF0aW9uX21zGA4gASgFYgZw",
						"cm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.GymBattleSettings),
							global::POGOProtos.Settings.Master.GymBattleSettings.Parser,
							new[]
							{
								"EnergyPerSec", "DodgeEnergyCost", "RetargetSeconds", "EnemyAttackInterval", "AttackServerInterval",
								"RoundDurationSeconds", "BonusTimePerAllySeconds", "MaximumAttackersPerBattle", "SameTypeAttackBonusMultiplier",
								"MaximumEnergy", "EnergyDeltaPerHealthLost", "DodgeDurationMs", "MinimumPlayerLevel", "SwapDurationMs"
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
	/// The gym battle settings.
	/// </summary>
	public sealed partial class GymBattleSettings : pb::IMessage<GymBattleSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "energy_per_sec" field.</summary>
		public const int EnergyPerSecFieldNumber = 1;

		/// <summary>Field number for the "dodge_energy_cost" field.</summary>
		public const int DodgeEnergyCostFieldNumber = 2;

		/// <summary>Field number for the "retarget_seconds" field.</summary>
		public const int RetargetSecondsFieldNumber = 3;

		/// <summary>Field number for the "enemy_attack_interval" field.</summary>
		public const int EnemyAttackIntervalFieldNumber = 4;

		/// <summary>Field number for the "attack_server_interval" field.</summary>
		public const int AttackServerIntervalFieldNumber = 5;

		/// <summary>Field number for the "round_duration_seconds" field.</summary>
		public const int RoundDurationSecondsFieldNumber = 6;

		/// <summary>Field number for the "bonus_time_per_ally_seconds" field.</summary>
		public const int BonusTimePerAllySecondsFieldNumber = 7;

		/// <summary>Field number for the "maximum_attackers_per_battle" field.</summary>
		public const int MaximumAttackersPerBattleFieldNumber = 8;

		/// <summary>Field number for the "same_type_attack_bonus_multiplier" field.</summary>
		public const int SameTypeAttackBonusMultiplierFieldNumber = 9;

		/// <summary>Field number for the "maximum_energy" field.</summary>
		public const int MaximumEnergyFieldNumber = 10;

		/// <summary>Field number for the "energy_delta_per_health_lost" field.</summary>
		public const int EnergyDeltaPerHealthLostFieldNumber = 11;

		/// <summary>Field number for the "dodge_duration_ms" field.</summary>
		public const int DodgeDurationMsFieldNumber = 12;

		/// <summary>Field number for the "minimum_player_level" field.</summary>
		public const int MinimumPlayerLevelFieldNumber = 13;

		/// <summary>Field number for the "swap_duration_ms" field.</summary>
		public const int SwapDurationMsFieldNumber = 14;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GymBattleSettings> _parser =
			new pb::MessageParser<GymBattleSettings>(() => new GymBattleSettings());

		#endregion

		#region  Fields

		/// <summary>
		/// The attack server interval_.
		/// </summary>
		private float attackServerInterval_;

		/// <summary>
		/// The bonus time per ally seconds_.
		/// </summary>
		private float bonusTimePerAllySeconds_;

		/// <summary>
		/// The dodge duration ms_.
		/// </summary>
		private int dodgeDurationMs_;

		/// <summary>
		/// The dodge energy cost_.
		/// </summary>
		private float dodgeEnergyCost_;

		/// <summary>
		/// The enemy attack interval_.
		/// </summary>
		private float enemyAttackInterval_;

		/// <summary>
		/// The energy delta per health lost_.
		/// </summary>
		private float energyDeltaPerHealthLost_;

		/// <summary>
		/// The energy per sec_.
		/// </summary>
		private float energyPerSec_;

		/// <summary>
		/// The maximum attackers per battle_.
		/// </summary>
		private int maximumAttackersPerBattle_;

		/// <summary>
		/// The maximum energy_.
		/// </summary>
		private int maximumEnergy_;

		/// <summary>
		/// The minimum player level_.
		/// </summary>
		private int minimumPlayerLevel_;

		/// <summary>
		/// The retarget seconds_.
		/// </summary>
		private float retargetSeconds_;

		/// <summary>
		/// The round duration seconds_.
		/// </summary>
		private float roundDurationSeconds_;

		/// <summary>
		/// The same type attack bonus multiplier_.
		/// </summary>
		private float sameTypeAttackBonusMultiplier_;

		/// <summary>
		/// The swap duration ms_.
		/// </summary>
		private int swapDurationMs_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GymBattleSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymBattleSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GymBattleSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymBattleSettings(GymBattleSettings other) : this()
		{
			energyPerSec_ = other.energyPerSec_;
			dodgeEnergyCost_ = other.dodgeEnergyCost_;
			retargetSeconds_ = other.retargetSeconds_;
			enemyAttackInterval_ = other.enemyAttackInterval_;
			attackServerInterval_ = other.attackServerInterval_;
			roundDurationSeconds_ = other.roundDurationSeconds_;
			bonusTimePerAllySeconds_ = other.bonusTimePerAllySeconds_;
			maximumAttackersPerBattle_ = other.maximumAttackersPerBattle_;
			sameTypeAttackBonusMultiplier_ = other.sameTypeAttackBonusMultiplier_;
			maximumEnergy_ = other.maximumEnergy_;
			energyDeltaPerHealthLost_ = other.energyDeltaPerHealthLost_;
			dodgeDurationMs_ = other.dodgeDurationMs_;
			minimumPlayerLevel_ = other.minimumPlayerLevel_;
			swapDurationMs_ = other.swapDurationMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GymBattleSettings> Parser
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
				return global::POGOProtos.Settings.Master.GymBattleSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the energy per sec.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float EnergyPerSec
		{
			get
			{
				return energyPerSec_;
			}

			set
			{
				energyPerSec_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the dodge energy cost.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float DodgeEnergyCost
		{
			get
			{
				return dodgeEnergyCost_;
			}

			set
			{
				dodgeEnergyCost_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the retarget seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float RetargetSeconds
		{
			get
			{
				return retargetSeconds_;
			}

			set
			{
				retargetSeconds_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the enemy attack interval.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float EnemyAttackInterval
		{
			get
			{
				return enemyAttackInterval_;
			}

			set
			{
				enemyAttackInterval_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the attack server interval.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float AttackServerInterval
		{
			get
			{
				return attackServerInterval_;
			}

			set
			{
				attackServerInterval_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the round duration seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float RoundDurationSeconds
		{
			get
			{
				return roundDurationSeconds_;
			}

			set
			{
				roundDurationSeconds_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the bonus time per ally seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float BonusTimePerAllySeconds
		{
			get
			{
				return bonusTimePerAllySeconds_;
			}

			set
			{
				bonusTimePerAllySeconds_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the maximum attackers per battle.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaximumAttackersPerBattle
		{
			get
			{
				return maximumAttackersPerBattle_;
			}

			set
			{
				maximumAttackersPerBattle_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the same type attack bonus multiplier.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float SameTypeAttackBonusMultiplier
		{
			get
			{
				return sameTypeAttackBonusMultiplier_;
			}

			set
			{
				sameTypeAttackBonusMultiplier_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the maximum energy.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaximumEnergy
		{
			get
			{
				return maximumEnergy_;
			}

			set
			{
				maximumEnergy_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the energy delta per health lost.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float EnergyDeltaPerHealthLost
		{
			get
			{
				return energyDeltaPerHealthLost_;
			}

			set
			{
				energyDeltaPerHealthLost_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the dodge duration ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int DodgeDurationMs
		{
			get
			{
				return dodgeDurationMs_;
			}

			set
			{
				dodgeDurationMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the minimum player level.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MinimumPlayerLevel
		{
			get
			{
				return minimumPlayerLevel_;
			}

			set
			{
				minimumPlayerLevel_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the swap duration ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int SwapDurationMs
		{
			get
			{
				return swapDurationMs_;
			}

			set
			{
				swapDurationMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GymBattleSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymBattleSettings Clone()
		{
			return new GymBattleSettings(this);
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
		public bool Equals(GymBattleSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (EnergyPerSec != other.EnergyPerSec)
			{
				return false;
			}

			if (DodgeEnergyCost != other.DodgeEnergyCost)
			{
				return false;
			}

			if (RetargetSeconds != other.RetargetSeconds)
			{
				return false;
			}

			if (EnemyAttackInterval != other.EnemyAttackInterval)
			{
				return false;
			}

			if (AttackServerInterval != other.AttackServerInterval)
			{
				return false;
			}

			if (RoundDurationSeconds != other.RoundDurationSeconds)
			{
				return false;
			}

			if (BonusTimePerAllySeconds != other.BonusTimePerAllySeconds)
			{
				return false;
			}

			if (MaximumAttackersPerBattle != other.MaximumAttackersPerBattle)
			{
				return false;
			}

			if (SameTypeAttackBonusMultiplier != other.SameTypeAttackBonusMultiplier)
			{
				return false;
			}

			if (MaximumEnergy != other.MaximumEnergy)
			{
				return false;
			}

			if (EnergyDeltaPerHealthLost != other.EnergyDeltaPerHealthLost)
			{
				return false;
			}

			if (DodgeDurationMs != other.DodgeDurationMs)
			{
				return false;
			}

			if (MinimumPlayerLevel != other.MinimumPlayerLevel)
			{
				return false;
			}

			if (SwapDurationMs != other.SwapDurationMs)
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
			if (EnergyPerSec != 0F)
			{
				output.WriteRawTag(13);
				output.WriteFloat(EnergyPerSec);
			}

			if (DodgeEnergyCost != 0F)
			{
				output.WriteRawTag(21);
				output.WriteFloat(DodgeEnergyCost);
			}

			if (RetargetSeconds != 0F)
			{
				output.WriteRawTag(29);
				output.WriteFloat(RetargetSeconds);
			}

			if (EnemyAttackInterval != 0F)
			{
				output.WriteRawTag(37);
				output.WriteFloat(EnemyAttackInterval);
			}

			if (AttackServerInterval != 0F)
			{
				output.WriteRawTag(45);
				output.WriteFloat(AttackServerInterval);
			}

			if (RoundDurationSeconds != 0F)
			{
				output.WriteRawTag(53);
				output.WriteFloat(RoundDurationSeconds);
			}

			if (BonusTimePerAllySeconds != 0F)
			{
				output.WriteRawTag(61);
				output.WriteFloat(BonusTimePerAllySeconds);
			}

			if (MaximumAttackersPerBattle != 0)
			{
				output.WriteRawTag(64);
				output.WriteInt32(MaximumAttackersPerBattle);
			}

			if (SameTypeAttackBonusMultiplier != 0F)
			{
				output.WriteRawTag(77);
				output.WriteFloat(SameTypeAttackBonusMultiplier);
			}

			if (MaximumEnergy != 0)
			{
				output.WriteRawTag(80);
				output.WriteInt32(MaximumEnergy);
			}

			if (EnergyDeltaPerHealthLost != 0F)
			{
				output.WriteRawTag(93);
				output.WriteFloat(EnergyDeltaPerHealthLost);
			}

			if (DodgeDurationMs != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(DodgeDurationMs);
			}

			if (MinimumPlayerLevel != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(MinimumPlayerLevel);
			}

			if (SwapDurationMs != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(SwapDurationMs);
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
			if (EnergyPerSec != 0F)
			{
				size += 1 + 4;
			}

			if (DodgeEnergyCost != 0F)
			{
				size += 1 + 4;
			}

			if (RetargetSeconds != 0F)
			{
				size += 1 + 4;
			}

			if (EnemyAttackInterval != 0F)
			{
				size += 1 + 4;
			}

			if (AttackServerInterval != 0F)
			{
				size += 1 + 4;
			}

			if (RoundDurationSeconds != 0F)
			{
				size += 1 + 4;
			}

			if (BonusTimePerAllySeconds != 0F)
			{
				size += 1 + 4;
			}

			if (MaximumAttackersPerBattle != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaximumAttackersPerBattle);
			}

			if (SameTypeAttackBonusMultiplier != 0F)
			{
				size += 1 + 4;
			}

			if (MaximumEnergy != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaximumEnergy);
			}

			if (EnergyDeltaPerHealthLost != 0F)
			{
				size += 1 + 4;
			}

			if (DodgeDurationMs != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(DodgeDurationMs);
			}

			if (MinimumPlayerLevel != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MinimumPlayerLevel);
			}

			if (SwapDurationMs != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(SwapDurationMs);
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
		public void MergeFrom(GymBattleSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.EnergyPerSec != 0F)
			{
				EnergyPerSec = other.EnergyPerSec;
			}

			if (other.DodgeEnergyCost != 0F)
			{
				DodgeEnergyCost = other.DodgeEnergyCost;
			}

			if (other.RetargetSeconds != 0F)
			{
				RetargetSeconds = other.RetargetSeconds;
			}

			if (other.EnemyAttackInterval != 0F)
			{
				EnemyAttackInterval = other.EnemyAttackInterval;
			}

			if (other.AttackServerInterval != 0F)
			{
				AttackServerInterval = other.AttackServerInterval;
			}

			if (other.RoundDurationSeconds != 0F)
			{
				RoundDurationSeconds = other.RoundDurationSeconds;
			}

			if (other.BonusTimePerAllySeconds != 0F)
			{
				BonusTimePerAllySeconds = other.BonusTimePerAllySeconds;
			}

			if (other.MaximumAttackersPerBattle != 0)
			{
				MaximumAttackersPerBattle = other.MaximumAttackersPerBattle;
			}

			if (other.SameTypeAttackBonusMultiplier != 0F)
			{
				SameTypeAttackBonusMultiplier = other.SameTypeAttackBonusMultiplier;
			}

			if (other.MaximumEnergy != 0)
			{
				MaximumEnergy = other.MaximumEnergy;
			}

			if (other.EnergyDeltaPerHealthLost != 0F)
			{
				EnergyDeltaPerHealthLost = other.EnergyDeltaPerHealthLost;
			}

			if (other.DodgeDurationMs != 0)
			{
				DodgeDurationMs = other.DodgeDurationMs;
			}

			if (other.MinimumPlayerLevel != 0)
			{
				MinimumPlayerLevel = other.MinimumPlayerLevel;
			}

			if (other.SwapDurationMs != 0)
			{
				SwapDurationMs = other.SwapDurationMs;
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
					case 13:
					{
						EnergyPerSec = input.ReadFloat();
						break;
					}

					case 21:
					{
						DodgeEnergyCost = input.ReadFloat();
						break;
					}

					case 29:
					{
						RetargetSeconds = input.ReadFloat();
						break;
					}

					case 37:
					{
						EnemyAttackInterval = input.ReadFloat();
						break;
					}

					case 45:
					{
						AttackServerInterval = input.ReadFloat();
						break;
					}

					case 53:
					{
						RoundDurationSeconds = input.ReadFloat();
						break;
					}

					case 61:
					{
						BonusTimePerAllySeconds = input.ReadFloat();
						break;
					}

					case 64:
					{
						MaximumAttackersPerBattle = input.ReadInt32();
						break;
					}

					case 77:
					{
						SameTypeAttackBonusMultiplier = input.ReadFloat();
						break;
					}

					case 80:
					{
						MaximumEnergy = input.ReadInt32();
						break;
					}

					case 93:
					{
						EnergyDeltaPerHealthLost = input.ReadFloat();
						break;
					}

					case 96:
					{
						DodgeDurationMs = input.ReadInt32();
						break;
					}

					case 104:
					{
						MinimumPlayerLevel = input.ReadInt32();
						break;
					}

					case 112:
					{
						SwapDurationMs = input.ReadInt32();
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
			return Equals(other as GymBattleSettings);
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
			if (EnergyPerSec != 0F)
			{
				hash ^= EnergyPerSec.GetHashCode();
			}

			if (DodgeEnergyCost != 0F)
			{
				hash ^= DodgeEnergyCost.GetHashCode();
			}

			if (RetargetSeconds != 0F)
			{
				hash ^= RetargetSeconds.GetHashCode();
			}

			if (EnemyAttackInterval != 0F)
			{
				hash ^= EnemyAttackInterval.GetHashCode();
			}

			if (AttackServerInterval != 0F)
			{
				hash ^= AttackServerInterval.GetHashCode();
			}

			if (RoundDurationSeconds != 0F)
			{
				hash ^= RoundDurationSeconds.GetHashCode();
			}

			if (BonusTimePerAllySeconds != 0F)
			{
				hash ^= BonusTimePerAllySeconds.GetHashCode();
			}

			if (MaximumAttackersPerBattle != 0)
			{
				hash ^= MaximumAttackersPerBattle.GetHashCode();
			}

			if (SameTypeAttackBonusMultiplier != 0F)
			{
				hash ^= SameTypeAttackBonusMultiplier.GetHashCode();
			}

			if (MaximumEnergy != 0)
			{
				hash ^= MaximumEnergy.GetHashCode();
			}

			if (EnergyDeltaPerHealthLost != 0F)
			{
				hash ^= EnergyDeltaPerHealthLost.GetHashCode();
			}

			if (DodgeDurationMs != 0)
			{
				hash ^= DodgeDurationMs.GetHashCode();
			}

			if (MinimumPlayerLevel != 0)
			{
				hash ^= MinimumPlayerLevel.GetHashCode();
			}

			if (SwapDurationMs != 0)
			{
				hash ^= SwapDurationMs.GetHashCode();
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