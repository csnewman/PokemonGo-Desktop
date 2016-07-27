// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GymMembership.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Gym/GymMembership.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data.Player;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Gym
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Gym/GymMembership.proto</summary>
	public static partial class GymMembershipReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Gym/GymMembership.proto</summary>
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
		/// Initializes static members of the <see cref="GymMembershipReflection"/> class.
		/// </summary>
		static GymMembershipReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CidQT0dPUHJvdG9zL0RhdGEvR3ltL0d5bU1lbWJlcnNoaXAucHJvdG8SE1BP",
						"R09Qcm90b3MuRGF0YS5HeW0aIVBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGF0",
						"YS5wcm90bxowUE9HT1Byb3Rvcy9EYXRhL1BsYXllci9QbGF5ZXJQdWJsaWNQ",
						"cm9maWxlLnByb3RvIpABCg1HeW1NZW1iZXJzaGlwEjIKDHBva2Vtb25fZGF0",
						"YRgBIAEoCzIcLlBPR09Qcm90b3MuRGF0YS5Qb2tlbW9uRGF0YRJLChZ0cmFp",
						"bmVyX3B1YmxpY19wcm9maWxlGAIgASgLMisuUE9HT1Byb3Rvcy5EYXRhLlBs",
						"YXllci5QbGF5ZXJQdWJsaWNQcm9maWxlYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.PokemonDataReflection.Descriptor,
					global::POGOProtos.Data.Player.PlayerPublicProfileReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Gym.GymMembership),
							global::POGOProtos.Data.Gym.GymMembership.Parser,
							new[] { "PokemonData", "TrainerPublicProfile" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The gym membership.
	/// </summary>
	public sealed partial class GymMembership : pb::IMessage<GymMembership>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "pokemon_data" field.</summary>
		public const int PokemonDataFieldNumber = 1;

		/// <summary>Field number for the "trainer_public_profile" field.</summary>
		public const int TrainerPublicProfileFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GymMembership> _parser =
			new pb::MessageParser<GymMembership>(() => new GymMembership());

		#endregion

		#region  Fields

		/// <summary>
		/// The pokemon data_.
		/// </summary>
		private PokemonData pokemonData_;

		/// <summary>
		/// The trainer public profile_.
		/// </summary>
		private PlayerPublicProfile trainerPublicProfile_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GymMembership"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymMembership()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GymMembership"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymMembership(GymMembership other) : this()
		{
			PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
			TrainerPublicProfile = other.trainerPublicProfile_ != null ? other.TrainerPublicProfile.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GymMembership> Parser
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
				return global::POGOProtos.Data.Gym.GymMembershipReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the pokemon data.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonData PokemonData
		{
			get
			{
				return pokemonData_;
			}

			set
			{
				pokemonData_ = value;
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

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GymMembership"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GymMembership Clone()
		{
			return new GymMembership(this);
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
		public bool Equals(GymMembership other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!object.Equals(PokemonData, other.PokemonData))
			{
				return false;
			}

			if (!object.Equals(TrainerPublicProfile, other.TrainerPublicProfile))
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
			if (pokemonData_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(PokemonData);
			}

			if (trainerPublicProfile_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(TrainerPublicProfile);
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
			if (pokemonData_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
			}

			if (trainerPublicProfile_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(TrainerPublicProfile);
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
		public void MergeFrom(GymMembership other)
		{
			if (other == null)
			{
				return;
			}

			if (other.pokemonData_ != null)
			{
				if (pokemonData_ == null)
				{
					pokemonData_ = new global::POGOProtos.Data.PokemonData();
				}

				PokemonData.MergeFrom(other.PokemonData);
			}

			if (other.trainerPublicProfile_ != null)
			{
				if (trainerPublicProfile_ == null)
				{
					trainerPublicProfile_ = new global::POGOProtos.Data.Player.PlayerPublicProfile();
				}

				TrainerPublicProfile.MergeFrom(other.TrainerPublicProfile);
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
						if (pokemonData_ == null)
						{
							pokemonData_ = new global::POGOProtos.Data.PokemonData();
						}

						input.ReadMessage(pokemonData_);
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
			return Equals(other as GymMembership);
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
			if (pokemonData_ != null)
			{
				hash ^= PokemonData.GetHashCode();
			}

			if (trainerPublicProfile_ != null)
			{
				hash ^= TrainerPublicProfile.GetHashCode();
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