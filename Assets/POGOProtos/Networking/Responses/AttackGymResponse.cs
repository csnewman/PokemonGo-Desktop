// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AttackGymResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/AttackGymResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/AttackGymResponse.proto</summary>
	public static partial class AttackGymResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/AttackGymResponse.proto</summary>
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
		/// Initializes static members of the <see cref="AttackGymResponseReflection"/> class.
		/// </summary>
		static AttackGymResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjdQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0F0dGFja0d5bVJl",
						"c3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
						"GiZQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZUxvZy5wcm90bxouUE9H",
						"T1Byb3Rvcy9EYXRhL0JhdHRsZS9CYXR0bGVQb2tlbW9uSW5mby5wcm90byKM",
						"AwoRQXR0YWNrR3ltUmVzcG9uc2USSQoGcmVzdWx0GAEgASgOMjkuUE9HT1By",
						"b3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5BdHRhY2tHeW1SZXNwb25zZS5S",
						"ZXN1bHQSNQoKYmF0dGxlX2xvZxgCIAEoCzIhLlBPR09Qcm90b3MuRGF0YS5C",
						"YXR0bGUuQmF0dGxlTG9nEhEKCWJhdHRsZV9pZBgDIAEoCRJCCg9hY3RpdmVf",
						"ZGVmZW5kZXIYBCABKAsyKS5QT0dPUHJvdG9zLkRhdGEuQmF0dGxlLkJhdHRs",
						"ZVBva2Vtb25JbmZvEkIKD2FjdGl2ZV9hdHRhY2tlchgFIAEoCzIpLlBPR09Q",
						"cm90b3MuRGF0YS5CYXR0bGUuQmF0dGxlUG9rZW1vbkluZm8iWgoGUmVzdWx0",
						"EgkKBVVOU0VUEAASCwoHU1VDQ0VTUxABEiAKHEVSUk9SX0lOVkFMSURfQVRU",
						"QUNLX0FDVElPTlMQAhIWChJFUlJPUl9OT1RfSU5fUkFOR0UQA2IGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Data.Battle.BattleLogReflection.Descriptor,
					global::POGOProtos.Data.Battle.BattlePokemonInfoReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.AttackGymResponse),
							global::POGOProtos.Networking.Responses.AttackGymResponse.Parser,
							new[] { "Result", "BattleLog", "BattleId", "ActiveDefender", "ActiveAttacker" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.AttackGymResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The attack gym response.
	/// </summary>
	public sealed partial class AttackGymResponse : pb::IMessage<AttackGymResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "battle_log" field.</summary>
		public const int BattleLogFieldNumber = 2;

		/// <summary>Field number for the "battle_id" field.</summary>
		public const int BattleIdFieldNumber = 3;

		/// <summary>Field number for the "active_defender" field.</summary>
		public const int ActiveDefenderFieldNumber = 4;

		/// <summary>Field number for the "active_attacker" field.</summary>
		public const int ActiveAttackerFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<AttackGymResponse> _parser =
			new pb::MessageParser<AttackGymResponse>(() => new AttackGymResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The active attacker_.
		/// </summary>
		private BattlePokemonInfo activeAttacker_;

		/// <summary>
		/// The active defender_.
		/// </summary>
		private BattlePokemonInfo activeDefender_;

		/// <summary>
		/// The battle id_.
		/// </summary>
		private string battleId_ = string.Empty;

		/// <summary>
		/// The battle log_.
		/// </summary>
		private BattleLog battleLog_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="AttackGymResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AttackGymResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AttackGymResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AttackGymResponse(AttackGymResponse other) : this()
		{
			result_ = other.result_;
			BattleLog = other.battleLog_ != null ? other.BattleLog.Clone() : null;
			battleId_ = other.battleId_;
			ActiveDefender = other.activeDefender_ != null ? other.ActiveDefender.Clone() : null;
			ActiveAttacker = other.activeAttacker_ != null ? other.ActiveAttacker.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<AttackGymResponse> Parser
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
				return global::POGOProtos.Networking.Responses.AttackGymResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the active defender.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattlePokemonInfo ActiveDefender
		{
			get
			{
				return activeDefender_;
			}

			set
			{
				activeDefender_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the active attacker.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattlePokemonInfo ActiveAttacker
		{
			get
			{
				return activeAttacker_;
			}

			set
			{
				activeAttacker_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="AttackGymResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AttackGymResponse Clone()
		{
			return new AttackGymResponse(this);
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
		public bool Equals(AttackGymResponse other)
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

			if (!object.Equals(BattleLog, other.BattleLog))
			{
				return false;
			}

			if (BattleId != other.BattleId)
			{
				return false;
			}

			if (!object.Equals(ActiveDefender, other.ActiveDefender))
			{
				return false;
			}

			if (!object.Equals(ActiveAttacker, other.ActiveAttacker))
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

			if (battleLog_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(BattleLog);
			}

			if (BattleId.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(BattleId);
			}

			if (activeDefender_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(ActiveDefender);
			}

			if (activeAttacker_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(ActiveAttacker);
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

			if (battleLog_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(BattleLog);
			}

			if (BattleId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(BattleId);
			}

			if (activeDefender_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(ActiveDefender);
			}

			if (activeAttacker_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(ActiveAttacker);
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
		public void MergeFrom(AttackGymResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.battleLog_ != null)
			{
				if (battleLog_ == null)
				{
					battleLog_ = new global::POGOProtos.Data.Battle.BattleLog();
				}

				BattleLog.MergeFrom(other.BattleLog);
			}

			if (other.BattleId.Length != 0)
			{
				BattleId = other.BattleId;
			}

			if (other.activeDefender_ != null)
			{
				if (activeDefender_ == null)
				{
					activeDefender_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
				}

				ActiveDefender.MergeFrom(other.ActiveDefender);
			}

			if (other.activeAttacker_ != null)
			{
				if (activeAttacker_ == null)
				{
					activeAttacker_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
				}

				ActiveAttacker.MergeFrom(other.ActiveAttacker);
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
						result_ = (global::POGOProtos.Networking.Responses.AttackGymResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						if (battleLog_ == null)
						{
							battleLog_ = new global::POGOProtos.Data.Battle.BattleLog();
						}

						input.ReadMessage(battleLog_);
						break;
					}

					case 26:
					{
						BattleId = input.ReadString();
						break;
					}

					case 34:
					{
						if (activeDefender_ == null)
						{
							activeDefender_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
						}

						input.ReadMessage(activeDefender_);
						break;
					}

					case 42:
					{
						if (activeAttacker_ == null)
						{
							activeAttacker_ = new global::POGOProtos.Data.Battle.BattlePokemonInfo();
						}

						input.ReadMessage(activeAttacker_);
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
			return Equals(other as AttackGymResponse);
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

			if (battleLog_ != null)
			{
				hash ^= BattleLog.GetHashCode();
			}

			if (BattleId.Length != 0)
			{
				hash ^= BattleId.GetHashCode();
			}

			if (activeDefender_ != null)
			{
				hash ^= ActiveDefender.GetHashCode();
			}

			if (activeAttacker_ != null)
			{
				hash ^= ActiveAttacker.GetHashCode();
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

		/// <summary>Container for nested types declared in the AttackGymResponse message type.</summary>
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
				/// The error invalid attack actions.
				/// </summary>
				[pbr::OriginalName("ERROR_INVALID_ATTACK_ACTIONS")] ErrorInvalidAttackActions = 2,

				/// <summary>
				/// The error not in range.
				/// </summary>
				[pbr::OriginalName("ERROR_NOT_IN_RANGE")] ErrorNotInRange = 3,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code