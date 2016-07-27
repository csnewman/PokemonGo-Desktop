// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AttackGymMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/AttackGymMessage.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data.Battle;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Requests.Messages
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/AttackGymMessage.proto</summary>
	public static partial class AttackGymMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/AttackGymMessage.proto</summary>
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
		/// Initializes static members of the <see cref="AttackGymMessageReflection"/> class.
		/// </summary>
		static AttackGymMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvQXR0",
						"YWNrR3ltTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
						"cXVlc3RzLk1lc3NhZ2VzGilQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRs",
						"ZUFjdGlvbi5wcm90byLsAQoQQXR0YWNrR3ltTWVzc2FnZRIOCgZneW1faWQY",
						"ASABKAkSEQoJYmF0dGxlX2lkGAIgASgJEjwKDmF0dGFja19hY3Rpb25zGAMg",
						"AygLMiQuUE9HT1Byb3Rvcy5EYXRhLkJhdHRsZS5CYXR0bGVBY3Rpb24SRAoW",
						"bGFzdF9yZXRyaWV2ZWRfYWN0aW9ucxgEIAEoCzIkLlBPR09Qcm90b3MuRGF0",
						"YS5CYXR0bGUuQmF0dGxlQWN0aW9uEhcKD3BsYXllcl9sYXRpdHVkZRgFIAEo",
						"ARIYChBwbGF5ZXJfbG9uZ2l0dWRlGAYgASgBYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.Battle.BattleActionReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.AttackGymMessage),
							global::POGOProtos.Networking.Requests.Messages.AttackGymMessage.Parser,
							new[] { "GymId", "BattleId", "AttackActions", "LastRetrievedActions", "PlayerLatitude", "PlayerLongitude" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The attack gym message.
	/// </summary>
	public sealed partial class AttackGymMessage : pb::IMessage<AttackGymMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "gym_id" field.</summary>
		public const int GymIdFieldNumber = 1;

		/// <summary>Field number for the "battle_id" field.</summary>
		public const int BattleIdFieldNumber = 2;

		/// <summary>Field number for the "attack_actions" field.</summary>
		public const int AttackActionsFieldNumber = 3;

		/// <summary>Field number for the "last_retrieved_actions" field.</summary>
		public const int LastRetrievedActionsFieldNumber = 4;

		/// <summary>Field number for the "player_latitude" field.</summary>
		public const int PlayerLatitudeFieldNumber = 5;

		/// <summary>Field number for the "player_longitude" field.</summary>
		public const int PlayerLongitudeFieldNumber = 6;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<AttackGymMessage> _parser =
			new pb::MessageParser<AttackGymMessage>(() => new AttackGymMessage());

		/// <summary>
		/// The _repeated_attack actions_codec.
		/// </summary>
		private static readonly pb.FieldCodec<BattleAction> _repeated_attackActions_codec = pb::FieldCodec.ForMessage(
			26,
			global::POGOProtos.Data.Battle.BattleAction.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The attack actions_.
		/// </summary>
		private readonly pbc.RepeatedField<BattleAction> attackActions_ = new pbc::RepeatedField<BattleAction>();

		/// <summary>
		/// The battle id_.
		/// </summary>
		private string battleId_ = string.Empty;

		/// <summary>
		/// The gym id_.
		/// </summary>
		private string gymId_ = string.Empty;

		/// <summary>
		/// The last retrieved actions_.
		/// </summary>
		private BattleAction lastRetrievedActions_;

		/// <summary>
		/// The player latitude_.
		/// </summary>
		private double playerLatitude_;

		/// <summary>
		/// The player longitude_.
		/// </summary>
		private double playerLongitude_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="AttackGymMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AttackGymMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="AttackGymMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AttackGymMessage(AttackGymMessage other) : this()
		{
			gymId_ = other.gymId_;
			battleId_ = other.battleId_;
			attackActions_ = other.attackActions_.Clone();
			LastRetrievedActions = other.lastRetrievedActions_ != null ? other.LastRetrievedActions.Clone() : null;
			playerLatitude_ = other.playerLatitude_;
			playerLongitude_ = other.playerLongitude_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<AttackGymMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.AttackGymMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the gym id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string GymId
		{
			get
			{
				return gymId_;
			}

			set
			{
				gymId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
		/// Gets the attack actions.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<BattleAction> AttackActions
		{
			get
			{
				return attackActions_;
			}
		}

		/// <summary>
		/// Gets or sets the last retrieved actions.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public BattleAction LastRetrievedActions
		{
			get
			{
				return lastRetrievedActions_;
			}

			set
			{
				lastRetrievedActions_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the player latitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double PlayerLatitude
		{
			get
			{
				return playerLatitude_;
			}

			set
			{
				playerLatitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the player longitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double PlayerLongitude
		{
			get
			{
				return playerLongitude_;
			}

			set
			{
				playerLongitude_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="AttackGymMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AttackGymMessage Clone()
		{
			return new AttackGymMessage(this);
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
		public bool Equals(AttackGymMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (GymId != other.GymId)
			{
				return false;
			}

			if (BattleId != other.BattleId)
			{
				return false;
			}

			if (!attackActions_.Equals(other.attackActions_))
			{
				return false;
			}

			if (!object.Equals(LastRetrievedActions, other.LastRetrievedActions))
			{
				return false;
			}

			if (PlayerLatitude != other.PlayerLatitude)
			{
				return false;
			}

			if (PlayerLongitude != other.PlayerLongitude)
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
			if (GymId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(GymId);
			}

			if (BattleId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(BattleId);
			}

			attackActions_.WriteTo(output, _repeated_attackActions_codec);
			if (lastRetrievedActions_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(LastRetrievedActions);
			}

			if (PlayerLatitude != 0D)
			{
				output.WriteRawTag(41);
				output.WriteDouble(PlayerLatitude);
			}

			if (PlayerLongitude != 0D)
			{
				output.WriteRawTag(49);
				output.WriteDouble(PlayerLongitude);
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
			if (GymId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(GymId);
			}

			if (BattleId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(BattleId);
			}

			size += attackActions_.CalculateSize(_repeated_attackActions_codec);
			if (lastRetrievedActions_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(LastRetrievedActions);
			}

			if (PlayerLatitude != 0D)
			{
				size += 1 + 8;
			}

			if (PlayerLongitude != 0D)
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
		public void MergeFrom(AttackGymMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.GymId.Length != 0)
			{
				GymId = other.GymId;
			}

			if (other.BattleId.Length != 0)
			{
				BattleId = other.BattleId;
			}

			attackActions_.Add(other.attackActions_);
			if (other.lastRetrievedActions_ != null)
			{
				if (lastRetrievedActions_ == null)
				{
					lastRetrievedActions_ = new global::POGOProtos.Data.Battle.BattleAction();
				}

				LastRetrievedActions.MergeFrom(other.LastRetrievedActions);
			}

			if (other.PlayerLatitude != 0D)
			{
				PlayerLatitude = other.PlayerLatitude;
			}

			if (other.PlayerLongitude != 0D)
			{
				PlayerLongitude = other.PlayerLongitude;
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
						GymId = input.ReadString();
						break;
					}

					case 18:
					{
						BattleId = input.ReadString();
						break;
					}

					case 26:
					{
						attackActions_.AddEntriesFrom(input, _repeated_attackActions_codec);
						break;
					}

					case 34:
					{
						if (lastRetrievedActions_ == null)
						{
							lastRetrievedActions_ = new global::POGOProtos.Data.Battle.BattleAction();
						}

						input.ReadMessage(lastRetrievedActions_);
						break;
					}

					case 41:
					{
						PlayerLatitude = input.ReadDouble();
						break;
					}

					case 49:
					{
						PlayerLongitude = input.ReadDouble();
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
			return Equals(other as AttackGymMessage);
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
			if (GymId.Length != 0)
			{
				hash ^= GymId.GetHashCode();
			}

			if (BattleId.Length != 0)
			{
				hash ^= BattleId.GetHashCode();
			}

			hash ^= attackActions_.GetHashCode();
			if (lastRetrievedActions_ != null)
			{
				hash ^= LastRetrievedActions.GetHashCode();
			}

			if (PlayerLatitude != 0D)
			{
				hash ^= PlayerLatitude.GetHashCode();
			}

			if (PlayerLongitude != 0D)
			{
				hash ^= PlayerLongitude.GetHashCode();
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