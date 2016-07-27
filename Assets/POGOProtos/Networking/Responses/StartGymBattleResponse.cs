// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartGymBattleResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/StartGymBattleResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data.Battle;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/StartGymBattleResponse.proto</summary>
	public static partial class StartGymBattleResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/StartGymBattleResponse.proto</summary>
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
		/// Initializes static members of the <see cref="StartGymBattleResponseReflection"/> class.
		/// </summary>
		static StartGymBattleResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1N0YXJ0R3ltQmF0",
						"dGxlUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
						"b25zZXMaJlBPR09Qcm90b3MvRGF0YS9CYXR0bGUvQmF0dGxlTG9nLnByb3Rv",
						"Gi5QT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZVBhcnRpY2lwYW50LnBy",
						"b3RvIq8FChZTdGFydEd5bUJhdHRsZVJlc3BvbnNlEk4KBnJlc3VsdBgBIAEo",
						"DjI+LlBPR09Qcm90b3MuTmV0d29ya2luZy5SZXNwb25zZXMuU3RhcnRHeW1C",
						"YXR0bGVSZXNwb25zZS5SZXN1bHQSIQoZYmF0dGxlX3N0YXJ0X3RpbWVzdGFt",
						"cF9tcxgCIAEoAxIfChdiYXR0bGVfZW5kX3RpbWVzdGFtcF9tcxgDIAEoAxIR",
						"CgliYXR0bGVfaWQYBCABKAkSOwoIZGVmZW5kZXIYBSABKAsyKS5QT0dPUHJv",
						"dG9zLkRhdGEuQmF0dGxlLkJhdHRsZVBhcnRpY2lwYW50EjUKCmJhdHRsZV9s",
						"b2cYBiABKAsyIS5QT0dPUHJvdG9zLkRhdGEuQmF0dGxlLkJhdHRsZUxvZyL5",
						"AgoGUmVzdWx0EgkKBVVOU0VUEAASCwoHU1VDQ0VTUxABEhcKE0VSUk9SX0dZ",
						"TV9OT1RfRk9VTkQQAhIVChFFUlJPUl9HWU1fTkVVVFJBTBADEhgKFEVSUk9S",
						"X0dZTV9XUk9OR19URUFNEAQSEwoPRVJST1JfR1lNX0VNUFRZEAUSGgoWRVJS",
						"T1JfSU5WQUxJRF9ERUZFTkRFUhAGEikKJUVSUk9SX1RSQUlOSU5HX0lOVkFM",
						"SURfQVRUQUNLRVJfQ09VTlQQBxIdChlFUlJPUl9BTExfUE9LRU1PTl9GQUlO",
						"VEVEEAgSGgoWRVJST1JfVE9PX01BTllfQkFUVExFUxAJEhoKFkVSUk9SX1RP",
						"T19NQU5ZX1BMQVlFUlMQChIcChhFUlJPUl9HWU1fQkFUVExFX0xPQ0tPVVQQ",
						"CxIkCiBFUlJPUl9QTEFZRVJfQkVMT1dfTUlOSU1VTV9MRVZFTBAMEhYKEkVS",
						"Uk9SX05PVF9JTl9SQU5HRRANYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.Battle.BattleLogReflection.Descriptor,
					global::POGOProtos.Data.Battle.BattleParticipantReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.StartGymBattleResponse),
							global::POGOProtos.Networking.Responses.StartGymBattleResponse.Parser,
							new[] { "Result", "BattleStartTimestampMs", "BattleEndTimestampMs", "BattleId", "Defender", "BattleLog" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.StartGymBattleResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The start gym battle response.
	/// </summary>
	public sealed partial class StartGymBattleResponse : pb::IMessage<StartGymBattleResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "battle_start_timestamp_ms" field.</summary>
		public const int BattleStartTimestampMsFieldNumber = 2;

		/// <summary>Field number for the "battle_end_timestamp_ms" field.</summary>
		public const int BattleEndTimestampMsFieldNumber = 3;

		/// <summary>Field number for the "battle_id" field.</summary>
		public const int BattleIdFieldNumber = 4;

		/// <summary>Field number for the "defender" field.</summary>
		public const int DefenderFieldNumber = 5;

		/// <summary>Field number for the "battle_log" field.</summary>
		public const int BattleLogFieldNumber = 6;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<StartGymBattleResponse> _parser =
			new pb::MessageParser<StartGymBattleResponse>(() => new StartGymBattleResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The battle end timestamp ms_.
		/// </summary>
		private long battleEndTimestampMs_;

		/// <summary>
		/// The battle id_.
		/// </summary>
		private string battleId_ = string.Empty;

		/// <summary>
		/// The battle log_.
		/// </summary>
		private BattleLog battleLog_;

		/// <summary>
		/// The battle start timestamp ms_.
		/// </summary>
		private long battleStartTimestampMs_;

		/// <summary>
		/// The defender_.
		/// </summary>
		private BattleParticipant defender_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="StartGymBattleResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public StartGymBattleResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StartGymBattleResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public StartGymBattleResponse(StartGymBattleResponse other) : this()
		{
			result_ = other.result_;
			battleStartTimestampMs_ = other.battleStartTimestampMs_;
			battleEndTimestampMs_ = other.battleEndTimestampMs_;
			battleId_ = other.battleId_;
			Defender = other.defender_ != null ? other.Defender.Clone() : null;
			BattleLog = other.battleLog_ != null ? other.BattleLog.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<StartGymBattleResponse> Parser
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
				return global::POGOProtos.Networking.Responses.StartGymBattleResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the battle start timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long BattleStartTimestampMs
		{
			get
			{
				return battleStartTimestampMs_;
			}

			set
			{
				battleStartTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the battle end timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long BattleEndTimestampMs
		{
			get
			{
				return battleEndTimestampMs_;
			}

			set
			{
				battleEndTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the battle id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string BattleId
		{
			get
			{
				return battleId_;
			}

			set
			{
				battleId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the defender.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleParticipant Defender
		{
			get
			{
				return defender_;
			}

			set
			{
				defender_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the battle log.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleLog BattleLog
		{
			get
			{
				return battleLog_;
			}

			set
			{
				battleLog_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="StartGymBattleResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public StartGymBattleResponse Clone()
		{
			return new StartGymBattleResponse(this);
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
		public bool Equals(StartGymBattleResponse other)
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

			if (BattleStartTimestampMs != other.BattleStartTimestampMs)
			{
				return false;
			}

			if (BattleEndTimestampMs != other.BattleEndTimestampMs)
			{
				return false;
			}

			if (BattleId != other.BattleId)
			{
				return false;
			}

			if (!object.Equals(Defender, other.Defender))
			{
				return false;
			}

			if (!object.Equals(BattleLog, other.BattleLog))
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

			if (BattleStartTimestampMs != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(BattleStartTimestampMs);
			}

			if (BattleEndTimestampMs != 0L)
			{
				output.WriteRawTag(24);
				output.WriteInt64(BattleEndTimestampMs);
			}

			if (BattleId.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(BattleId);
			}

			if (defender_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(Defender);
			}

			if (battleLog_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(BattleLog);
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

			if (BattleStartTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(BattleStartTimestampMs);
			}

			if (BattleEndTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(BattleEndTimestampMs);
			}

			if (BattleId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(BattleId);
			}

			if (defender_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Defender);
			}

			if (battleLog_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleLog);
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
		public void MergeFrom(StartGymBattleResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.BattleStartTimestampMs != 0L)
			{
				BattleStartTimestampMs = other.BattleStartTimestampMs;
			}

			if (other.BattleEndTimestampMs != 0L)
			{
				BattleEndTimestampMs = other.BattleEndTimestampMs;
			}

			if (other.BattleId.Length != 0)
			{
				BattleId = other.BattleId;
			}

			if (other.defender_ != null)
			{
				if (defender_ == null)
				{
					defender_ = new global::POGOProtos.Data.Battle.BattleParticipant();
				}

				Defender.MergeFrom(other.Defender);
			}

			if (other.battleLog_ != null)
			{
				if (battleLog_ == null)
				{
					battleLog_ = new global::POGOProtos.Data.Battle.BattleLog();
				}

				BattleLog.MergeFrom(other.BattleLog);
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
						result_ = (global::POGOProtos.Networking.Responses.StartGymBattleResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 16:
					{
						BattleStartTimestampMs = input.ReadInt64();
						break;
					}

					case 24:
					{
						BattleEndTimestampMs = input.ReadInt64();
						break;
					}

					case 34:
					{
						BattleId = input.ReadString();
						break;
					}

					case 42:
					{
						if (defender_ == null)
						{
							defender_ = new global::POGOProtos.Data.Battle.BattleParticipant();
						}

						input.ReadMessage(defender_);
						break;
					}

					case 50:
					{
						if (battleLog_ == null)
						{
							battleLog_ = new global::POGOProtos.Data.Battle.BattleLog();
						}

						input.ReadMessage(battleLog_);
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
			return Equals(other as StartGymBattleResponse);
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

			if (BattleStartTimestampMs != 0L)
			{
				hash ^= BattleStartTimestampMs.GetHashCode();
			}

			if (BattleEndTimestampMs != 0L)
			{
				hash ^= BattleEndTimestampMs.GetHashCode();
			}

			if (BattleId.Length != 0)
			{
				hash ^= BattleId.GetHashCode();
			}

			if (defender_ != null)
			{
				hash ^= Defender.GetHashCode();
			}

			if (battleLog_ != null)
			{
				hash ^= BattleLog.GetHashCode();
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

		/// <summary>Container for nested types declared in the StartGymBattleResponse message type.</summary>
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
				/// The unset.
				/// </summary>
				[pbr::OriginalName("UNSET")] Unset = 0,

				/// <summary>
				/// The success.
				/// </summary>
				[pbr::OriginalName("SUCCESS")] Success = 1,

				/// <summary>
				/// The error gym not found.
				/// </summary>
				[pbr::OriginalName("ERROR_GYM_NOT_FOUND")] ErrorGymNotFound = 2,

				/// <summary>
				/// The error gym neutral.
				/// </summary>
				[pbr::OriginalName("ERROR_GYM_NEUTRAL")] ErrorGymNeutral = 3,

				/// <summary>
				/// The error gym wrong team.
				/// </summary>
				[pbr::OriginalName("ERROR_GYM_WRONG_TEAM")] ErrorGymWrongTeam = 4,

				/// <summary>
				/// The error gym empty.
				/// </summary>
				[pbr::OriginalName("ERROR_GYM_EMPTY")] ErrorGymEmpty = 5,

				/// <summary>
				/// The error invalid defender.
				/// </summary>
				[pbr::OriginalName("ERROR_INVALID_DEFENDER")] ErrorInvalidDefender = 6,

				/// <summary>
				/// The error training invalid attacker count.
				/// </summary>
				[pbr::OriginalName("ERROR_TRAINING_INVALID_ATTACKER_COUNT")] ErrorTrainingInvalidAttackerCount = 7,

				/// <summary>
				/// The error all pokemon fainted.
				/// </summary>
				[pbr::OriginalName("ERROR_ALL_POKEMON_FAINTED")] ErrorAllPokemonFainted = 8,

				/// <summary>
				/// The error too many battles.
				/// </summary>
				[pbr::OriginalName("ERROR_TOO_MANY_BATTLES")] ErrorTooManyBattles = 9,

				/// <summary>
				/// The error too many players.
				/// </summary>
				[pbr::OriginalName("ERROR_TOO_MANY_PLAYERS")] ErrorTooManyPlayers = 10,

				/// <summary>
				/// The error gym battle lockout.
				/// </summary>
				[pbr::OriginalName("ERROR_GYM_BATTLE_LOCKOUT")] ErrorGymBattleLockout = 11,

				/// <summary>
				/// The error player below minimum level.
				/// </summary>
				[pbr::OriginalName("ERROR_PLAYER_BELOW_MINIMUM_LEVEL")] ErrorPlayerBelowMinimumLevel = 12,

				/// <summary>
				/// The error not in range.
				/// </summary>
				[pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 13,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code