// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartGymBattleMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/StartGymBattleMessage.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Requests.Messages
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/StartGymBattleMessage.proto</summary>
	public static partial class StartGymBattleMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/StartGymBattleMessage.proto</summary>
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
		/// Initializes static members of the <see cref="StartGymBattleMessageReflection"/> class.
		/// </summary>
		static StartGymBattleMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkNQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvU3Rh",
						"cnRHeW1CYXR0bGVNZXNzYWdlLnByb3RvEidQT0dPUHJvdG9zLk5ldHdvcmtp",
						"bmcuUmVxdWVzdHMuTWVzc2FnZXMilwEKFVN0YXJ0R3ltQmF0dGxlTWVzc2Fn",
						"ZRIOCgZneW1faWQYASABKAkSHQoVYXR0YWNraW5nX3Bva2Vtb25faWRzGAIg",
						"AygGEhwKFGRlZmVuZGluZ19wb2tlbW9uX2lkGAMgASgEEhcKD3BsYXllcl9s",
						"YXRpdHVkZRgEIAEoARIYChBwbGF5ZXJfbG9uZ2l0dWRlGAUgASgBYgZwcm90",
						"bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.StartGymBattleMessage),
							global::POGOProtos.Networking.Requests.Messages.StartGymBattleMessage.Parser,
							new[] { "GymId", "AttackingPokemonIds", "DefendingPokemonId", "PlayerLatitude", "PlayerLongitude" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The start gym battle message.
	/// </summary>
	public sealed partial class StartGymBattleMessage : pb::IMessage<StartGymBattleMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "gym_id" field.</summary>
		public const int GymIdFieldNumber = 1;

		/// <summary>Field number for the "attacking_pokemon_ids" field.</summary>
		public const int AttackingPokemonIdsFieldNumber = 2;

		/// <summary>Field number for the "defending_pokemon_id" field.</summary>
		public const int DefendingPokemonIdFieldNumber = 3;

		/// <summary>Field number for the "player_latitude" field.</summary>
		public const int PlayerLatitudeFieldNumber = 4;

		/// <summary>Field number for the "player_longitude" field.</summary>
		public const int PlayerLongitudeFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<StartGymBattleMessage> _parser =
			new pb::MessageParser<StartGymBattleMessage>(() => new StartGymBattleMessage());

		/// <summary>
		/// The _repeated_attacking pokemon ids_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ulong> _repeated_attackingPokemonIds_codec = pb::FieldCodec.ForFixed64(18);

		#endregion

		#region  Fields

		/// <summary>
		/// The attacking pokemon ids_.
		/// </summary>
		private readonly pbc.RepeatedField<ulong> attackingPokemonIds_ = new pbc::RepeatedField<ulong>();

		/// <summary>
		/// The defending pokemon id_.
		/// </summary>
		private ulong defendingPokemonId_;

		/// <summary>
		/// The gym id_.
		/// </summary>
		private string gymId_ = string.Empty;

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
		/// Initializes a new instance of the <see cref="StartGymBattleMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public StartGymBattleMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="StartGymBattleMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public StartGymBattleMessage(StartGymBattleMessage other) : this()
		{
			gymId_ = other.gymId_;
			attackingPokemonIds_ = other.attackingPokemonIds_.Clone();
			defendingPokemonId_ = other.defendingPokemonId_;
			playerLatitude_ = other.playerLatitude_;
			playerLongitude_ = other.playerLongitude_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<StartGymBattleMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.StartGymBattleMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets the attacking pokemon ids.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ulong> AttackingPokemonIds
		{
			get
			{
				return attackingPokemonIds_;
			}
		}

		/// <summary>
		/// Gets or sets the defending pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong DefendingPokemonId
		{
			get
			{
				return defendingPokemonId_;
			}

			set
			{
				defendingPokemonId_ = value;
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
		/// The <see cref="StartGymBattleMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public StartGymBattleMessage Clone()
		{
			return new StartGymBattleMessage(this);
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
		public bool Equals(StartGymBattleMessage other)
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

			if (!attackingPokemonIds_.Equals(other.attackingPokemonIds_))
			{
				return false;
			}

			if (DefendingPokemonId != other.DefendingPokemonId)
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

			attackingPokemonIds_.WriteTo(output, _repeated_attackingPokemonIds_codec);
			if (DefendingPokemonId != 0UL)
			{
				output.WriteRawTag(24);
				output.WriteUInt64(DefendingPokemonId);
			}

			if (PlayerLatitude != 0D)
			{
				output.WriteRawTag(33);
				output.WriteDouble(PlayerLatitude);
			}

			if (PlayerLongitude != 0D)
			{
				output.WriteRawTag(41);
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

			size += attackingPokemonIds_.CalculateSize(_repeated_attackingPokemonIds_codec);
			if (DefendingPokemonId != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(DefendingPokemonId);
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
		public void MergeFrom(StartGymBattleMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.GymId.Length != 0)
			{
				GymId = other.GymId;
			}

			attackingPokemonIds_.Add(other.attackingPokemonIds_);
			if (other.DefendingPokemonId != 0UL)
			{
				DefendingPokemonId = other.DefendingPokemonId;
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
					case 17:
					{
						attackingPokemonIds_.AddEntriesFrom(input, _repeated_attackingPokemonIds_codec);
						break;
					}

					case 24:
					{
						DefendingPokemonId = input.ReadUInt64();
						break;
					}

					case 33:
					{
						PlayerLatitude = input.ReadDouble();
						break;
					}

					case 41:
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
			return Equals(other as StartGymBattleMessage);
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

			hash ^= attackingPokemonIds_.GetHashCode();
			if (DefendingPokemonId != 0UL)
			{
				hash ^= DefendingPokemonId.GetHashCode();
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