// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BattleParticipant.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Battle/BattleParticipant.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data.Player;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Battle
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleParticipant.proto</summary>
	public static partial class BattleParticipantReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Battle/BattleParticipant.proto</summary>
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
		/// Initializes static members of the <see cref="BattleParticipantReflection"/> class.
		/// </summary>
		static BattleParticipantReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ci5QT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZVBhcnRpY2lwYW50LnBy",
						"b3RvEhZQT0dPUHJvdG9zLkRhdGEuQmF0dGxlGi5QT0dPUHJvdG9zL0RhdGEv",
						"QmF0dGxlL0JhdHRsZVBva2Vtb25JbmZvLnByb3RvGjBQT0dPUHJvdG9zL0Rh",
						"dGEvUGxheWVyL1BsYXllclB1YmxpY1Byb2ZpbGUucHJvdG8irAIKEUJhdHRs",
						"ZVBhcnRpY2lwYW50EkEKDmFjdGl2ZV9wb2tlbW9uGAEgASgLMikuUE9HT1By",
						"b3Rvcy5EYXRhLkJhdHRsZS5CYXR0bGVQb2tlbW9uSW5mbxJLChZ0cmFpbmVy",
						"X3B1YmxpY19wcm9maWxlGAIgASgLMisuUE9HT1Byb3Rvcy5EYXRhLlBsYXll",
						"ci5QbGF5ZXJQdWJsaWNQcm9maWxlEkIKD3JldmVyc2VfcG9rZW1vbhgDIAMo",
						"CzIpLlBPR09Qcm90b3MuRGF0YS5CYXR0bGUuQmF0dGxlUG9rZW1vbkluZm8S",
						"QwoQZGVmZWF0ZWRfcG9rZW1vbhgEIAMoCzIpLlBPR09Qcm90b3MuRGF0YS5C",
						"YXR0bGUuQmF0dGxlUG9rZW1vbkluZm9iBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.Battle.BattlePokemonInfoReflection.Descriptor,
					global::POGOProtos.Data.Player.PlayerPublicProfileReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Battle.BattleParticipant),
							global::POGOProtos.Data.Battle.BattleParticipant.Parser,
							new[] { "ActivePokemon", "TrainerPublicProfile", "ReversePokemon", "DefeatedPokemon" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The battle participant.
	/// </summary>
	public sealed partial class BattleParticipant : pb::IMessage<BattleParticipant>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "active_pokemon" field.</summary>
		public const int ActivePokemonFieldNumber = 1;

		/// <summary>Field number for the "trainer_public_profile" field.</summary>
		public const int TrainerPublicProfileFieldNumber = 2;

		/// <summary>Field number for the "reverse_pokemon" field.</summary>
		public const int ReversePokemonFieldNumber = 3;

		/// <summary>Field number for the "defeated_pokemon" field.</summary>
		public const int DefeatedPokemonFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<BattleParticipant> _parser =
			new pb::MessageParser<BattleParticipant>(() => new BattleParticipant());

		/// <summary>
		/// The _repeated_reverse pokemon_codec.
		/// </summary>
		private static readonly pb.FieldCodec<BattlePokemonInfo> _repeated_reversePokemon_codec = pb::FieldCodec.ForMessage(
			26,
			global::POGOProtos.Data.Battle.BattlePokemonInfo.Parser);

		/// <summary>
		/// The _repeated_defeated pokemon_codec.
		/// </summary>
		private static readonly pb.FieldCodec<BattlePokemonInfo> _repeated_defeatedPokemon_codec =
			pb::FieldCodec.ForMessage(34, global::POGOProtos.Data.Battle.BattlePokemonInfo.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The active pokemon_.
		/// </summary>
		private BattlePokemonInfo activePokemon_;

		/// <summary>
		/// The defeated pokemon_.
		/// </summary>
		private readonly pbc.RepeatedField<BattlePokemonInfo> defeatedPokemon_ = new pbc::RepeatedField<BattlePokemonInfo>();

		/// <summary>
		/// The reverse pokemon_.
		/// </summary>
		private readonly pbc.RepeatedField<BattlePokemonInfo> reversePokemon_ = new pbc::RepeatedField<BattlePokemonInfo>();

		/// <summary>
		/// The trainer public profile_.
		/// </summary>
		private PlayerPublicProfile trainerPublicProfile_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="BattleParticipant"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleParticipant()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="BattleParticipant"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleParticipant(BattleParticipant other) : this()
		{
			ActivePokemon = other.activePokemon_ != null ? other.ActivePokemon.Clone() : null;
			TrainerPublicProfile = other.trainerPublicProfile_ != null ? other.TrainerPublicProfile.Clone() : null;
			reversePokemon_ = other.reversePokemon_.Clone();
			defeatedPokemon_ = other.defeatedPokemon_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<BattleParticipant> Parser
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
				return global::POGOProtos.Data.Battle.BattleParticipantReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the active pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattlePokemonInfo ActivePokemon
		{
			get
			{
				return activePokemon_;
			}

			set
			{
				activePokemon_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the trainer public profile.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerPublicProfile TrainerPublicProfile
		{
			get
			{
				return trainerPublicProfile_;
			}

			set
			{
				trainerPublicProfile_ = value;
			}
		}

		/// <summary>
		/// Gets the reverse pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<BattlePokemonInfo> ReversePokemon
		{
			get
			{
				return reversePokemon_;
			}
		}

		/// <summary>
		/// Gets the defeated pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<BattlePokemonInfo> DefeatedPokemon
		{
			get
			{
				return defeatedPokemon_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="BattleParticipant"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleParticipant Clone()
		{
			return new BattleParticipant(this);
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
		public bool Equals(BattleParticipant other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!object.Equals(ActivePokemon, other.ActivePokemon))
			{
				return false;
			}

			if (!object.Equals(TrainerPublicProfile, other.TrainerPublicProfile))
			{
				return false;
			}

			if (!reversePokemon_.Equals(other.reversePokemon_))
			{
				return false;
			}

			if (!defeatedPokemon_.Equals(other.defeatedPokemon_))
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
			if (activePokemon_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(ActivePokemon);
			}

			if (trainerPublicProfile_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(TrainerPublicProfile);
			}

			reversePokemon_.WriteTo(output, _repeated_reversePokemon_codec);
			defeatedPokemon_.WriteTo(output, _repeated_defeatedPokemon_codec);
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
			if (activePokemon_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(ActivePokemon);
			}

			if (trainerPublicProfile_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(TrainerPublicProfile);
			}

			size += reversePokemon_.CalculateSize(_repeated_reversePokemon_codec);
			size += defeatedPokemon_.CalculateSize(_repeated_defeatedPokemon_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(BattleParticipant other)
		{
			if (other == null)
			{
				return;
			}

			if (other.activePokemon_ != null)
			{
				if (activePokemon_ == null)
				{
					activePokemon_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
				}

				ActivePokemon.MergeFrom(other.ActivePokemon);
			}

			if (other.trainerPublicProfile_ != null)
			{
				if (trainerPublicProfile_ == null)
				{
					trainerPublicProfile_ = new global::POGOProtos.Data.Player.PlayerPublicProfile();
				}

				TrainerPublicProfile.MergeFrom(other.TrainerPublicProfile);
			}

			reversePokemon_.Add(other.reversePokemon_);
			defeatedPokemon_.Add(other.defeatedPokemon_);
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
						if (activePokemon_ == null)
						{
							activePokemon_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
						}

						input.ReadMessage(activePokemon_);
						break;
					}

					case 18:
					{
						if (trainerPublicProfile_ == null)
						{
							trainerPublicProfile_ = new global::POGOProtos.Data.Player.PlayerPublicProfile();
						}

						input.ReadMessage(trainerPublicProfile_);
						break;
					}

					case 26:
					{
						reversePokemon_.AddEntriesFrom(input, _repeated_reversePokemon_codec);
						break;
					}

					case 34:
					{
						defeatedPokemon_.AddEntriesFrom(input, _repeated_defeatedPokemon_codec);
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
			return Equals(other as BattleParticipant);
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
			if (activePokemon_ != null)
			{
				hash ^= ActivePokemon.GetHashCode();
			}

			if (trainerPublicProfile_ != null)
			{
				hash ^= TrainerPublicProfile.GetHashCode();
			}

			hash ^= reversePokemon_.GetHashCode();
			hash ^= defeatedPokemon_.GetHashCode();
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