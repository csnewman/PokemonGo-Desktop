// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BattleAction.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Battle/BattleAction.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Battle
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleAction.proto</summary>
	public static partial class BattleActionReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Battle/BattleAction.proto</summary>
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
		/// Initializes static members of the <see cref="BattleActionReflection"/> class.
		/// </summary>
		static BattleActionReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CilQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZUFjdGlvbi5wcm90bxIW",
						"UE9HT1Byb3Rvcy5EYXRhLkJhdHRsZRoqUE9HT1Byb3Rvcy9EYXRhL0JhdHRs",
						"ZS9CYXR0bGVSZXN1bHRzLnByb3RvGi1QT0dPUHJvdG9zL0RhdGEvQmF0dGxl",
						"L0JhdHRsZUFjdGlvblR5cGUucHJvdG8aLlBPR09Qcm90b3MvRGF0YS9CYXR0",
						"bGUvQmF0dGxlUGFydGljaXBhbnQucHJvdG8ihQQKDEJhdHRsZUFjdGlvbhI2",
						"CgRUeXBlGAEgASgOMiguUE9HT1Byb3Rvcy5EYXRhLkJhdHRsZS5CYXR0bGVB",
						"Y3Rpb25UeXBlEhcKD2FjdGlvbl9zdGFydF9tcxgCIAEoAxITCgtkdXJhdGlv",
						"bl9tcxgDIAEoBRIUCgxlbmVyZ3lfZGVsdGEYBSABKAUSFgoOYXR0YWNrZXJf",
						"aW5kZXgYBiABKAUSFAoMdGFyZ2V0X2luZGV4GAcgASgFEhkKEWFjdGl2ZV9w",
						"b2tlbW9uX2lkGAggASgEEkAKDXBsYXllcl9qb2luZWQYCSABKAsyKS5QT0dP",
						"UHJvdG9zLkRhdGEuQmF0dGxlLkJhdHRsZVBhcnRpY2lwYW50Ej0KDmJhdHRs",
						"ZV9yZXN1bHRzGAogASgLMiUuUE9HT1Byb3Rvcy5EYXRhLkJhdHRsZS5CYXR0",
						"bGVSZXN1bHRzEioKImRhbWFnZV93aW5kb3dzX3N0YXJ0X3RpbWVzdGFtcF9t",
						"c3MYCyABKAMSKAogZGFtYWdlX3dpbmRvd3NfZW5kX3RpbWVzdGFtcF9tc3MY",
						"DCABKAMSPgoLcGxheWVyX2xlZnQYDSABKAsyKS5QT0dPUHJvdG9zLkRhdGEu",
						"QmF0dGxlLkJhdHRsZVBhcnRpY2lwYW50EhkKEXRhcmdldF9wb2tlbW9uX2lk",
						"GA4gASgEYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.Battle.BattleResultsReflection.Descriptor,
					global::POGOProtos.Data.Battle.BattleActionTypeReflection.Descriptor,
					global::POGOProtos.Data.Battle.BattleParticipantReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Battle.BattleAction),
							global::POGOProtos.Data.Battle.BattleAction.Parser,
							new[]
							{
								"Type", "ActionStartMs", "DurationMs", "EnergyDelta", "AttackerIndex", "TargetIndex", "ActivePokemonId",
								"PlayerJoined", "BattleResults", "DamageWindowsStartTimestampMss", "DamageWindowsEndTimestampMss", "PlayerLeft",
								"TargetPokemonId"
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
	/// The battle action.
	/// </summary>
	public sealed partial class BattleAction : pb::IMessage<BattleAction>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "Type" field.</summary>
		public const int TypeFieldNumber = 1;

		/// <summary>Field number for the "action_start_ms" field.</summary>
		public const int ActionStartMsFieldNumber = 2;

		/// <summary>Field number for the "duration_ms" field.</summary>
		public const int DurationMsFieldNumber = 3;

		/// <summary>Field number for the "energy_delta" field.</summary>
		public const int EnergyDeltaFieldNumber = 5;

		/// <summary>Field number for the "attacker_index" field.</summary>
		public const int AttackerIndexFieldNumber = 6;

		/// <summary>Field number for the "target_index" field.</summary>
		public const int TargetIndexFieldNumber = 7;

		/// <summary>Field number for the "active_pokemon_id" field.</summary>
		public const int ActivePokemonIdFieldNumber = 8;

		/// <summary>Field number for the "player_joined" field.</summary>
		public const int PlayerJoinedFieldNumber = 9;

		/// <summary>Field number for the "battle_results" field.</summary>
		public const int BattleResultsFieldNumber = 10;

		/// <summary>Field number for the "damage_windows_start_timestamp_mss" field.</summary>
		public const int DamageWindowsStartTimestampMssFieldNumber = 11;

		/// <summary>Field number for the "damage_windows_end_timestamp_mss" field.</summary>
		public const int DamageWindowsEndTimestampMssFieldNumber = 12;

		/// <summary>Field number for the "player_left" field.</summary>
		public const int PlayerLeftFieldNumber = 13;

		/// <summary>Field number for the "target_pokemon_id" field.</summary>
		public const int TargetPokemonIdFieldNumber = 14;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<BattleAction> _parser =
			new pb::MessageParser<BattleAction>(() => new BattleAction());

		#endregion

		#region  Fields

		/// <summary>
		/// The action start ms_.
		/// </summary>
		private long actionStartMs_;

		/// <summary>
		/// The active pokemon id_.
		/// </summary>
		private ulong activePokemonId_;

		/// <summary>
		/// The attacker index_.
		/// </summary>
		private int attackerIndex_;

		/// <summary>
		/// The battle results_.
		/// </summary>
		private BattleResults battleResults_;

		/// <summary>
		/// The damage windows end timestamp mss_.
		/// </summary>
		private long damageWindowsEndTimestampMss_;

		/// <summary>
		/// The damage windows start timestamp mss_.
		/// </summary>
		private long damageWindowsStartTimestampMss_;

		/// <summary>
		/// The duration ms_.
		/// </summary>
		private int durationMs_;

		/// <summary>
		/// The energy delta_.
		/// </summary>
		private int energyDelta_;

		/// <summary>
		/// The player joined_.
		/// </summary>
		private BattleParticipant playerJoined_;

		/// <summary>
		/// The player left_.
		/// </summary>
		private BattleParticipant playerLeft_;

		/// <summary>
		/// The target index_.
		/// </summary>
		private int targetIndex_;

		/// <summary>
		/// The target pokemon id_.
		/// </summary>
		private ulong targetPokemonId_;

		/// <summary>
		/// The type_.
		/// </summary>
		private BattleActionType type_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="BattleAction"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleAction()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BattleAction"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleAction(BattleAction other) : this()
		{
			type_ = other.type_;
			actionStartMs_ = other.actionStartMs_;
			durationMs_ = other.durationMs_;
			energyDelta_ = other.energyDelta_;
			attackerIndex_ = other.attackerIndex_;
			targetIndex_ = other.targetIndex_;
			activePokemonId_ = other.activePokemonId_;
			PlayerJoined = other.playerJoined_ != null ? other.PlayerJoined.Clone() : null;
			BattleResults = other.battleResults_ != null ? other.BattleResults.Clone() : null;
			damageWindowsStartTimestampMss_ = other.damageWindowsStartTimestampMss_;
			damageWindowsEndTimestampMss_ = other.damageWindowsEndTimestampMss_;
			PlayerLeft = other.playerLeft_ != null ? other.PlayerLeft.Clone() : null;
			targetPokemonId_ = other.targetPokemonId_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<BattleAction> Parser
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
				return global::POGOProtos.Data.Battle.BattleActionReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleActionType Type
		{
			get
			{
				return type_;
			}

			set
			{
				type_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the action start ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long ActionStartMs
		{
			get
			{
				return actionStartMs_;
			}

			set
			{
				actionStartMs_ = value;
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

		/// <summary>
		/// Gets or sets the attacker index.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int AttackerIndex
		{
			get
			{
				return attackerIndex_;
			}

			set
			{
				attackerIndex_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the target index.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int TargetIndex
		{
			get
			{
				return targetIndex_;
			}

			set
			{
				targetIndex_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the active pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong ActivePokemonId
		{
			get
			{
				return activePokemonId_;
			}

			set
			{
				activePokemonId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the player joined.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleParticipant PlayerJoined
		{
			get
			{
				return playerJoined_;
			}

			set
			{
				playerJoined_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the battle results.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleResults BattleResults
		{
			get
			{
				return battleResults_;
			}

			set
			{
				battleResults_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the damage windows start timestamp mss.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long DamageWindowsStartTimestampMss
		{
			get
			{
				return damageWindowsStartTimestampMss_;
			}

			set
			{
				damageWindowsStartTimestampMss_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the damage windows end timestamp mss.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long DamageWindowsEndTimestampMss
		{
			get
			{
				return damageWindowsEndTimestampMss_;
			}

			set
			{
				damageWindowsEndTimestampMss_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the player left.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleParticipant PlayerLeft
		{
			get
			{
				return playerLeft_;
			}

			set
			{
				playerLeft_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the target pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong TargetPokemonId
		{
			get
			{
				return targetPokemonId_;
			}

			set
			{
				targetPokemonId_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="BattleAction"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleAction Clone()
		{
			return new BattleAction(this);
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
		public bool Equals(BattleAction other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Type != other.Type)
			{
				return false;
			}

			if (ActionStartMs != other.ActionStartMs)
			{
				return false;
			}

			if (DurationMs != other.DurationMs)
			{
				return false;
			}

			if (EnergyDelta != other.EnergyDelta)
			{
				return false;
			}

			if (AttackerIndex != other.AttackerIndex)
			{
				return false;
			}

			if (TargetIndex != other.TargetIndex)
			{
				return false;
			}

			if (ActivePokemonId != other.ActivePokemonId)
			{
				return false;
			}

			if (!object.Equals(PlayerJoined, other.PlayerJoined))
			{
				return false;
			}

			if (!object.Equals(BattleResults, other.BattleResults))
			{
				return false;
			}

			if (DamageWindowsStartTimestampMss != other.DamageWindowsStartTimestampMss)
			{
				return false;
			}

			if (DamageWindowsEndTimestampMss != other.DamageWindowsEndTimestampMss)
			{
				return false;
			}

			if (!object.Equals(PlayerLeft, other.PlayerLeft))
			{
				return false;
			}

			if (TargetPokemonId != other.TargetPokemonId)
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
			if (Type != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)Type);
			}

			if (ActionStartMs != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(ActionStartMs);
			}

			if (DurationMs != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(DurationMs);
			}

			if (EnergyDelta != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(EnergyDelta);
			}

			if (AttackerIndex != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(AttackerIndex);
			}

			if (TargetIndex != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(TargetIndex);
			}

			if (ActivePokemonId != 0UL)
			{
				output.WriteRawTag(64);
				output.WriteUInt64(ActivePokemonId);
			}

			if (playerJoined_ != null)
			{
				output.WriteRawTag(74);
				output.WriteMessage(PlayerJoined);
			}

			if (battleResults_ != null)
			{
				output.WriteRawTag(82);
				output.WriteMessage(BattleResults);
			}

			if (DamageWindowsStartTimestampMss != 0L)
			{
				output.WriteRawTag(88);
				output.WriteInt64(DamageWindowsStartTimestampMss);
			}

			if (DamageWindowsEndTimestampMss != 0L)
			{
				output.WriteRawTag(96);
				output.WriteInt64(DamageWindowsEndTimestampMss);
			}

			if (playerLeft_ != null)
			{
				output.WriteRawTag(106);
				output.WriteMessage(PlayerLeft);
			}

			if (TargetPokemonId != 0UL)
			{
				output.WriteRawTag(112);
				output.WriteUInt64(TargetPokemonId);
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
			if (Type != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Type);
			}

			if (ActionStartMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(ActionStartMs);
			}

			if (DurationMs != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(DurationMs);
			}

			if (EnergyDelta != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(EnergyDelta);
			}

			if (AttackerIndex != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(AttackerIndex);
			}

			if (TargetIndex != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(TargetIndex);
			}

			if (ActivePokemonId != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ActivePokemonId);
			}

			if (playerJoined_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerJoined);
			}

			if (battleResults_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleResults);
			}

			if (DamageWindowsStartTimestampMss != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(DamageWindowsStartTimestampMss);
			}

			if (DamageWindowsEndTimestampMss != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(DamageWindowsEndTimestampMss);
			}

			if (playerLeft_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlayerLeft);
			}

			if (TargetPokemonId != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TargetPokemonId);
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
		public void MergeFrom(BattleAction other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Type != 0)
			{
				Type = other.Type;
			}

			if (other.ActionStartMs != 0L)
			{
				ActionStartMs = other.ActionStartMs;
			}

			if (other.DurationMs != 0)
			{
				DurationMs = other.DurationMs;
			}

			if (other.EnergyDelta != 0)
			{
				EnergyDelta = other.EnergyDelta;
			}

			if (other.AttackerIndex != 0)
			{
				AttackerIndex = other.AttackerIndex;
			}

			if (other.TargetIndex != 0)
			{
				TargetIndex = other.TargetIndex;
			}

			if (other.ActivePokemonId != 0UL)
			{
				ActivePokemonId = other.ActivePokemonId;
			}

			if (other.playerJoined_ != null)
			{
				if (playerJoined_ == null)
				{
					playerJoined_ = new global::POGOProtos.Data.Battle.BattleParticipant();
				}

				PlayerJoined.MergeFrom(other.PlayerJoined);
			}

			if (other.battleResults_ != null)
			{
				if (battleResults_ == null)
				{
					battleResults_ = new global::POGOProtos.Data.Battle.BattleResults();
				}

				BattleResults.MergeFrom(other.BattleResults);
			}

			if (other.DamageWindowsStartTimestampMss != 0L)
			{
				DamageWindowsStartTimestampMss = other.DamageWindowsStartTimestampMss;
			}

			if (other.DamageWindowsEndTimestampMss != 0L)
			{
				DamageWindowsEndTimestampMss = other.DamageWindowsEndTimestampMss;
			}

			if (other.playerLeft_ != null)
			{
				if (playerLeft_ == null)
				{
					playerLeft_ = new global::POGOProtos.Data.Battle.BattleParticipant();
				}

				PlayerLeft.MergeFrom(other.PlayerLeft);
			}

			if (other.TargetPokemonId != 0UL)
			{
				TargetPokemonId = other.TargetPokemonId;
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
						type_ = (global::POGOProtos.Data.Battle.BattleActionType)input.ReadEnum();
						break;
					}

					case 16:
					{
						ActionStartMs = input.ReadInt64();
						break;
					}

					case 24:
					{
						DurationMs = input.ReadInt32();
						break;
					}

					case 40:
					{
						EnergyDelta = input.ReadInt32();
						break;
					}

					case 48:
					{
						AttackerIndex = input.ReadInt32();
						break;
					}

					case 56:
					{
						TargetIndex = input.ReadInt32();
						break;
					}

					case 64:
					{
						ActivePokemonId = input.ReadUInt64();
						break;
					}

					case 74:
					{
						if (playerJoined_ == null)
						{
							playerJoined_ = new global::POGOProtos.Data.Battle.BattleParticipant();
						}

						input.ReadMessage(playerJoined_);
						break;
					}

					case 82:
					{
						if (battleResults_ == null)
						{
							battleResults_ = new global::POGOProtos.Data.Battle.BattleResults();
						}

						input.ReadMessage(battleResults_);
						break;
					}

					case 88:
					{
						DamageWindowsStartTimestampMss = input.ReadInt64();
						break;
					}

					case 96:
					{
						DamageWindowsEndTimestampMss = input.ReadInt64();
						break;
					}

					case 106:
					{
						if (playerLeft_ == null)
						{
							playerLeft_ = new global::POGOProtos.Data.Battle.BattleParticipant();
						}

						input.ReadMessage(playerLeft_);
						break;
					}

					case 112:
					{
						TargetPokemonId = input.ReadUInt64();
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
			return Equals(other as BattleAction);
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
			if (Type != 0)
			{
				hash ^= Type.GetHashCode();
			}

			if (ActionStartMs != 0L)
			{
				hash ^= ActionStartMs.GetHashCode();
			}

			if (DurationMs != 0)
			{
				hash ^= DurationMs.GetHashCode();
			}

			if (EnergyDelta != 0)
			{
				hash ^= EnergyDelta.GetHashCode();
			}

			if (AttackerIndex != 0)
			{
				hash ^= AttackerIndex.GetHashCode();
			}

			if (TargetIndex != 0)
			{
				hash ^= TargetIndex.GetHashCode();
			}

			if (ActivePokemonId != 0UL)
			{
				hash ^= ActivePokemonId.GetHashCode();
			}

			if (playerJoined_ != null)
			{
				hash ^= PlayerJoined.GetHashCode();
			}

			if (battleResults_ != null)
			{
				hash ^= BattleResults.GetHashCode();
			}

			if (DamageWindowsStartTimestampMss != 0L)
			{
				hash ^= DamageWindowsStartTimestampMss.GetHashCode();
			}

			if (DamageWindowsEndTimestampMss != 0L)
			{
				hash ^= DamageWindowsEndTimestampMss.GetHashCode();
			}

			if (playerLeft_ != null)
			{
				hash ^= PlayerLeft.GetHashCode();
			}

			if (TargetPokemonId != 0UL)
			{
				hash ^= TargetPokemonId.GetHashCode();
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