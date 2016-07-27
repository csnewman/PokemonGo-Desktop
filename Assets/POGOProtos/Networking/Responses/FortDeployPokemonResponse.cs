// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortDeployPokemonResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/FortDeployPokemonResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data;
using POGOProtos.Data.Gym;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/FortDeployPokemonResponse.proto</summary>
	public static partial class FortDeployPokemonResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/FortDeployPokemonResponse.proto</summary>
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
		/// Initializes static members of the <see cref="FortDeployPokemonResponseReflection"/> class.
		/// </summary>
		static FortDeployPokemonResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj9QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0ZvcnREZXBsb3lQ",
						"b2tlbW9uUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5S",
						"ZXNwb25zZXMaIVBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGF0YS5wcm90bxoi",
						"UE9HT1Byb3Rvcy9EYXRhL0d5bS9HeW1TdGF0ZS5wcm90bxo5UE9HT1Byb3Rv",
						"cy9OZXR3b3JraW5nL1Jlc3BvbnNlcy9Gb3J0RGV0YWlsc1Jlc3BvbnNlLnBy",
						"b3RvIqgEChlGb3J0RGVwbG95UG9rZW1vblJlc3BvbnNlElEKBnJlc3VsdBgB",
						"IAEoDjJBLlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuRm9ydERl",
						"cGxveVBva2Vtb25SZXNwb25zZS5SZXN1bHQSSgoMZm9ydF9kZXRhaWxzGAIg",
						"ASgLMjQuUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5Gb3J0RGV0",
						"YWlsc1Jlc3BvbnNlEjIKDHBva2Vtb25fZGF0YRgDIAEoCzIcLlBPR09Qcm90",
						"b3MuRGF0YS5Qb2tlbW9uRGF0YRIwCglneW1fc3RhdGUYBCABKAsyHS5QT0dP",
						"UHJvdG9zLkRhdGEuR3ltLkd5bVN0YXRlIoUCCgZSZXN1bHQSEQoNTk9fUkVT",
						"VUxUX1NFVBAAEgsKB1NVQ0NFU1MQARIlCiFFUlJPUl9BTFJFQURZX0hBU19Q",
						"T0tFTU9OX09OX0ZPUlQQAhIhCh1FUlJPUl9PUFBPU0lOR19URUFNX09XTlNf",
						"Rk9SVBADEhYKEkVSUk9SX0ZPUlRfSVNfRlVMTBAEEhYKEkVSUk9SX05PVF9J",
						"Tl9SQU5HRRAFEhwKGEVSUk9SX1BMQVlFUl9IQVNfTk9fVEVBTRAGEh0KGUVS",
						"Uk9SX1BPS0VNT05fTk9UX0ZVTExfSFAQBxIkCiBFUlJPUl9QTEFZRVJfQkVM",
						"T1dfTUlOSU1VTV9MRVZFTBAIYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.PokemonDataReflection.Descriptor,
					global::POGOProtos.Data.Gym.GymStateReflection.Descriptor,
					global::POGOProtos.Networking.Responses.FortDetailsResponseReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.FortDeployPokemonResponse),
							global::POGOProtos.Networking.Responses.FortDeployPokemonResponse.Parser,
							new[] { "Result", "FortDetails", "PokemonData", "GymState" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.FortDeployPokemonResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort deploy pokemon response.
	/// </summary>
	public sealed partial class FortDeployPokemonResponse : pb::IMessage<FortDeployPokemonResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "fort_details" field.</summary>
		public const int FortDetailsFieldNumber = 2;

		/// <summary>Field number for the "pokemon_data" field.</summary>
		public const int PokemonDataFieldNumber = 3;

		/// <summary>Field number for the "gym_state" field.</summary>
		public const int GymStateFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortDeployPokemonResponse> _parser =
			new pb::MessageParser<FortDeployPokemonResponse>(() => new FortDeployPokemonResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The fort details_.
		/// </summary>
		private FortDetailsResponse fortDetails_;

		/// <summary>
		/// The gym state_.
		/// </summary>
		private GymState gymState_;

		/// <summary>
		/// The pokemon data_.
		/// </summary>
		private PokemonData pokemonData_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortDeployPokemonResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortDeployPokemonResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortDeployPokemonResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortDeployPokemonResponse(FortDeployPokemonResponse other) : this()
		{
			result_ = other.result_;
			FortDetails = other.fortDetails_ != null ? other.FortDetails.Clone() : null;
			PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
			GymState = other.gymState_ != null ? other.GymState.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortDeployPokemonResponse> Parser
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
				return global::POGOProtos.Networking.Responses.FortDeployPokemonResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the result.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Types.Result Result
		{
			get
			{
				return result_;
			}

			set
			{
				result_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the fort details.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortDetailsResponse FortDetails
		{
			get
			{
				return fortDetails_;
			}

			set
			{
				fortDetails_ = value;
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

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortDeployPokemonResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortDeployPokemonResponse Clone()
		{
			return new FortDeployPokemonResponse(this);
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
		public bool Equals(FortDeployPokemonResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Result != other.Result)
			{
				return false;
			}

			if (!object.Equals(FortDetails, other.FortDetails))
			{
				return false;
			}

			if (!object.Equals(PokemonData, other.PokemonData))
			{
				return false;
			}

			if (!object.Equals(GymState, other.GymState))
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
			if (Result != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)Result);
			}

			if (fortDetails_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(FortDetails);
			}

			if (pokemonData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(PokemonData);
			}

			if (gymState_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(GymState);
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
			if (Result != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Result);
			}

			if (fortDetails_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortDetails);
			}

			if (pokemonData_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
			}

			if (gymState_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(GymState);
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
		public void MergeFrom(FortDeployPokemonResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.fortDetails_ != null)
			{
				if (fortDetails_ == null)
				{
					fortDetails_ = new global::POGOProtos.Networking.Responses.FortDetailsResponse();
				}

				FortDetails.MergeFrom(other.FortDetails);
			}

			if (other.pokemonData_ != null)
			{
				if (pokemonData_ == null)
				{
					pokemonData_ = new global::POGOProtos.Data.PokemonData();
				}

				PokemonData.MergeFrom(other.PokemonData);
			}

			if (other.gymState_ != null)
			{
				if (gymState_ == null)
				{
					gymState_ = new global::POGOProtos.Data.Gym.GymState();
				}

				GymState.MergeFrom(other.GymState);
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
						result_ = (global::POGOProtos.Networking.Responses.FortDeployPokemonResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						if (fortDetails_ == null)
						{
							fortDetails_ = new global::POGOProtos.Networking.Responses.FortDetailsResponse();
						}

						input.ReadMessage(fortDetails_);
						break;
					}

					case 26:
					{
						if (pokemonData_ == null)
						{
							pokemonData_ = new global::POGOProtos.Data.PokemonData();
						}

						input.ReadMessage(pokemonData_);
						break;
					}

					case 34:
					{
						if (gymState_ == null)
						{
							gymState_ = new global::POGOProtos.Data.Gym.GymState();
						}

						input.ReadMessage(gymState_);
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
			return Equals(other as FortDeployPokemonResponse);
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
			if (Result != 0)
			{
				hash ^= Result.GetHashCode();
			}

			if (fortDetails_ != null)
			{
				hash ^= FortDetails.GetHashCode();
			}

			if (pokemonData_ != null)
			{
				hash ^= PokemonData.GetHashCode();
			}

			if (gymState_ != null)
			{
				hash ^= GymState.GetHashCode();
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

		#region Nested types

		/// <summary>Container for nested types declared in the FortDeployPokemonResponse message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			#region Enums

			/// <summary>
			/// The result.
			/// </summary>
			public enum Result
			{
				/// <summary>
				/// The no result set.
				/// </summary>
				[pbr::OriginalName("NO_RESULT_SET")] NoResultSet = 0,

				/// <summary>
				/// The success.
				/// </summary>
				[pbr::OriginalName("SUCCESS")] Success = 1,

				/// <summary>
				/// The error already has pokemon on fort.
				/// </summary>
				[pbr::OriginalName("ERROR_ALREADY_HAS_POKEMON_ON_FORT")] ErrorAlreadyHasPokemonOnFort = 2,

				/// <summary>
				/// The error opposing team owns fort.
				/// </summary>
				[pbr::OriginalName("ERROR_OPPOSING_TEAM_OWNS_FORT")] ErrorOpposingTeamOwnsFort = 3,

				/// <summary>
				/// The error fort is full.
				/// </summary>
				[pbr::OriginalName("ERROR_FORT_IS_FULL")] ErrorFortIsFull = 4,

				/// <summary>
				/// The error not in range.
				/// </summary>
				[pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 5,

				/// <summary>
				/// The error player has no team.
				/// </summary>
				[pbr::OriginalName("ERROR_PLAYER_HAS_NO_TEAM")] ErrorPlayerHasNoTeam = 6,

				/// <summary>
				/// The error pokemon not full hp.
				/// </summary>
				[pbr::OriginalName("ERROR_POKEMON_NOT_FULL_HP")] ErrorPokemonNotFullHp = 7,

				/// <summary>
				/// The error player below minimum level.
				/// </summary>
				[pbr::OriginalName("ERROR_PLAYER_BELOW_MINIMUM_LEVEL")] ErrorPlayerBelowMinimumLevel = 8,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code