// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EncounterMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/EncounterMessage.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/EncounterMessage.proto</summary>
	public static partial class EncounterMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/EncounterMessage.proto</summary>
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
		/// Initializes static members of the <see cref="EncounterMessageReflection"/> class.
		/// </summary>
		static EncounterMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvRW5j",
						"b3VudGVyTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
						"cXVlc3RzLk1lc3NhZ2VzInMKEEVuY291bnRlck1lc3NhZ2USFAoMZW5jb3Vu",
						"dGVyX2lkGAEgASgGEhYKDnNwYXduX3BvaW50X2lkGAIgASgJEhcKD3BsYXll",
						"cl9sYXRpdHVkZRgDIAEoARIYChBwbGF5ZXJfbG9uZ2l0dWRlGAQgASgBYgZw",
						"cm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.EncounterMessage),
							global::POGOProtos.Networking.Requests.Messages.EncounterMessage.Parser,
							new[] { "EncounterId", "SpawnPointId", "PlayerLatitude", "PlayerLongitude" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The encounter message.
	/// </summary>
	public sealed partial class EncounterMessage : pb::IMessage<EncounterMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "encounter_id" field.</summary>
		public const int EncounterIdFieldNumber = 1;

		/// <summary>Field number for the "spawn_point_id" field.</summary>
		public const int SpawnPointIdFieldNumber = 2;

		/// <summary>Field number for the "player_latitude" field.</summary>
		public const int PlayerLatitudeFieldNumber = 3;

		/// <summary>Field number for the "player_longitude" field.</summary>
		public const int PlayerLongitudeFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EncounterMessage> _parser =
			new pb::MessageParser<EncounterMessage>(() => new EncounterMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The encounter id_.
		/// </summary>
		private ulong encounterId_;

		/// <summary>
		/// The player latitude_.
		/// </summary>
		private double playerLatitude_;

		/// <summary>
		/// The player longitude_.
		/// </summary>
		private double playerLongitude_;

		/// <summary>
		/// The spawn point id_.
		/// </summary>
		private string spawnPointId_ = string.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EncounterMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EncounterMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterMessage(EncounterMessage other) : this()
		{
			encounterId_ = other.encounterId_;
			spawnPointId_ = other.spawnPointId_;
			playerLatitude_ = other.playerLatitude_;
			playerLongitude_ = other.playerLongitude_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EncounterMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.EncounterMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the encounter id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong EncounterId
		{
			get
			{
				return encounterId_;
			}

			set
			{
				encounterId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the spawn point id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string SpawnPointId
		{
			get
			{
				return spawnPointId_;
			}

			set
			{
				spawnPointId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
		/// The <see cref="EncounterMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterMessage Clone()
		{
			return new EncounterMessage(this);
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
		public bool Equals(EncounterMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (EncounterId != other.EncounterId)
			{
				return false;
			}

			if (SpawnPointId != other.SpawnPointId)
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
			if (EncounterId != 0UL)
			{
				output.WriteRawTag(9);
				output.WriteFixed64(EncounterId);
			}

			if (SpawnPointId.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(SpawnPointId);
			}

			if (PlayerLatitude != 0D)
			{
				output.WriteRawTag(25);
				output.WriteDouble(PlayerLatitude);
			}

			if (PlayerLongitude != 0D)
			{
				output.WriteRawTag(33);
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
			if (EncounterId != 0UL)
			{
				size += 1 + 8;
			}

			if (SpawnPointId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointId);
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
		public void MergeFrom(EncounterMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.EncounterId != 0UL)
			{
				EncounterId = other.EncounterId;
			}

			if (other.SpawnPointId.Length != 0)
			{
				SpawnPointId = other.SpawnPointId;
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
					case 9:
					{
						EncounterId = input.ReadFixed64();
						break;
					}

					case 18:
					{
						SpawnPointId = input.ReadString();
						break;
					}

					case 25:
					{
						PlayerLatitude = input.ReadDouble();
						break;
					}

					case 33:
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
			return Equals(other as EncounterMessage);
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
			if (EncounterId != 0UL)
			{
				hash ^= EncounterId.GetHashCode();
			}

			if (SpawnPointId.Length != 0)
			{
				hash ^= SpawnPointId.GetHashCode();
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