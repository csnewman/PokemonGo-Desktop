// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BattleResults.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Battle/BattleResults.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data.Gym;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Battle
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleResults.proto</summary>
	public static partial class BattleResultsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Battle/BattleResults.proto</summary>
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
		/// Initializes static members of the <see cref="BattleResultsReflection"/> class.
		/// </summary>
		static BattleResultsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CipQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZVJlc3VsdHMucHJvdG8S",
						"FlBPR09Qcm90b3MuRGF0YS5CYXR0bGUaIlBPR09Qcm90b3MvRGF0YS9HeW0v",
						"R3ltU3RhdGUucHJvdG8aLlBPR09Qcm90b3MvRGF0YS9CYXR0bGUvQmF0dGxl",
						"UGFydGljaXBhbnQucHJvdG8i3gEKDUJhdHRsZVJlc3VsdHMSMAoJZ3ltX3N0",
						"YXRlGAEgASgLMh0uUE9HT1Byb3Rvcy5EYXRhLkd5bS5HeW1TdGF0ZRI8Cglh",
						"dHRhY2tlcnMYAiADKAsyKS5QT0dPUHJvdG9zLkRhdGEuQmF0dGxlLkJhdHRs",
						"ZVBhcnRpY2lwYW50EiEKGXBsYXllcl9leHBlcmllbmNlX2F3YXJkZWQYAyAD",
						"KAUSIAoYbmV4dF9kZWZlbmRlcl9wb2tlbW9uX2lkGAQgASgDEhgKEGd5bV9w",
						"b2ludHNfZGVsdGEYBSABKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.Gym.GymStateReflection.Descriptor,
					global::POGOProtos.Data.Battle.BattleParticipantReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Battle.BattleResults),
							global::POGOProtos.Data.Battle.BattleResults.Parser,
							new[] { "GymState", "Attackers", "PlayerExperienceAwarded", "NextDefenderPokemonId", "GymPointsDelta" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The battle results.
	/// </summary>
	public sealed partial class BattleResults : pb::IMessage<BattleResults>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "gym_state" field.</summary>
		public const int GymStateFieldNumber = 1;

		/// <summary>Field number for the "attackers" field.</summary>
		public const int AttackersFieldNumber = 2;

		/// <summary>Field number for the "player_experience_awarded" field.</summary>
		public const int PlayerExperienceAwardedFieldNumber = 3;

		/// <summary>Field number for the "next_defender_pokemon_id" field.</summary>
		public const int NextDefenderPokemonIdFieldNumber = 4;

		/// <summary>Field number for the "gym_points_delta" field.</summary>
		public const int GymPointsDeltaFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<BattleResults> _parser =
			new pb::MessageParser<BattleResults>(() => new BattleResults());

		/// <summary>
		/// The _repeated_attackers_codec.
		/// </summary>
		private static readonly pb.FieldCodec<BattleParticipant> _repeated_attackers_codec = pb::FieldCodec.ForMessage(
			18,
			global::POGOProtos.Data.Battle.BattleParticipant.Parser);

		/// <summary>
		/// The _repeated_player experience awarded_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_playerExperienceAwarded_codec = pb::FieldCodec.ForInt32(26);

		#endregion

		#region  Fields

		/// <summary>
		/// The attackers_.
		/// </summary>
		private readonly pbc.RepeatedField<BattleParticipant> attackers_ = new pbc::RepeatedField<BattleParticipant>();

		/// <summary>
		/// The gym points delta_.
		/// </summary>
		private int gymPointsDelta_;

		/// <summary>
		/// The gym state_.
		/// </summary>
		private GymState gymState_;

		/// <summary>
		/// The next defender pokemon id_.
		/// </summary>
		private long nextDefenderPokemonId_;

		/// <summary>
		/// The player experience awarded_.
		/// </summary>
		private readonly pbc.RepeatedField<int> playerExperienceAwarded_ = new pbc::RepeatedField<int>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="BattleResults"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleResults()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BattleResults"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleResults(BattleResults other) : this()
		{
			GymState = other.gymState_ != null ? other.GymState.Clone() : null;
			attackers_ = other.attackers_.Clone();
			playerExperienceAwarded_ = other.playerExperienceAwarded_.Clone();
			nextDefenderPokemonId_ = other.nextDefenderPokemonId_;
			gymPointsDelta_ = other.gymPointsDelta_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<BattleResults> Parser
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
				return global::POGOProtos.Data.Battle.BattleResultsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the gym state.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymState GymState
		{
			get
			{
				return gymState_;
			}

			set
			{
				gymState_ = value;
			}
		}

		/// <summary>
		/// Gets the attackers.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<BattleParticipant> Attackers
		{
			get
			{
				return attackers_;
			}
		}

		/// <summary>
		/// Gets the player experience awarded.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> PlayerExperienceAwarded
		{
			get
			{
				return playerExperienceAwarded_;
			}
		}

		/// <summary>
		/// Gets or sets the next defender pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long NextDefenderPokemonId
		{
			get
			{
				return nextDefenderPokemonId_;
			}

			set
			{
				nextDefenderPokemonId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the gym points delta.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int GymPointsDelta
		{
			get
			{
				return gymPointsDelta_;
			}

			set
			{
				gymPointsDelta_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="BattleResults"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleResults Clone()
		{
			return new BattleResults(this);
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
		public bool Equals(BattleResults other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!object.Equals(GymState, other.GymState))
			{
				return false;
			}

			if (!attackers_.Equals(other.attackers_))
			{
				return false;
			}

			if (!playerExperienceAwarded_.Equals(other.playerExperienceAwarded_))
			{
				return false;
			}

			if (NextDefenderPokemonId != other.NextDefenderPokemonId)
			{
				return false;
			}

			if (GymPointsDelta != other.GymPointsDelta)
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
			if (gymState_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(GymState);
			}

			attackers_.WriteTo(output, _repeated_attackers_codec);
			playerExperienceAwarded_.WriteTo(output, _repeated_playerExperienceAwarded_codec);
			if (NextDefenderPokemonId != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(NextDefenderPokemonId);
			}

			if (GymPointsDelta != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(GymPointsDelta);
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
			if (gymState_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(GymState);
			}

			size += attackers_.CalculateSize(_repeated_attackers_codec);
			size += playerExperienceAwarded_.CalculateSize(_repeated_playerExperienceAwarded_codec);
			if (NextDefenderPokemonId != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(NextDefenderPokemonId);
			}

			if (GymPointsDelta != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(GymPointsDelta);
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
		public void MergeFrom(BattleResults other)
		{
			if (other == null)
			{
				return;
			}

			if (other.gymState_ != null)
			{
				if (gymState_ == null)
				{
					gymState_ = new global::POGOProtos.Data.Gym.GymState();
				}

				GymState.MergeFrom(other.GymState);
			}

			attackers_.Add(other.attackers_);
			playerExperienceAwarded_.Add(other.playerExperienceAwarded_);
			if (other.NextDefenderPokemonId != 0L)
			{
				NextDefenderPokemonId = other.NextDefenderPokemonId;
			}

			if (other.GymPointsDelta != 0)
			{
				GymPointsDelta = other.GymPointsDelta;
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
						if (gymState_ == null)
						{
							gymState_ = new global::POGOProtos.Data.Gym.GymState();
						}

						input.ReadMessage(gymState_);
						break;
					}

					case 18:
					{
						attackers_.AddEntriesFrom(input, _repeated_attackers_codec);
						break;
					}

					case 26:
					case 24:
					{
						playerExperienceAwarded_.AddEntriesFrom(input, _repeated_playerExperienceAwarded_codec);
						break;
					}

					case 32:
					{
						NextDefenderPokemonId = input.ReadInt64();
						break;
					}

					case 40:
					{
						GymPointsDelta = input.ReadInt32();
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
			return Equals(other as BattleResults);
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
			if (gymState_ != null)
			{
				hash ^= GymState.GetHashCode();
			}

			hash ^= attackers_.GetHashCode();
			hash ^= playerExperienceAwarded_.GetHashCode();
			if (NextDefenderPokemonId != 0L)
			{
				hash ^= NextDefenderPokemonId.GetHashCode();
			}

			if (GymPointsDelta != 0)
			{
				hash ^= GymPointsDelta.GetHashCode();
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