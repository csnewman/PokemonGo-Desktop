// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortRecallPokemonMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/FortRecallPokemonMessage.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/FortRecallPokemonMessage.proto</summary>
	public static partial class FortRecallPokemonMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/FortRecallPokemonMessage.proto</summary>
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
		/// Initializes static members of the <see cref="FortRecallPokemonMessageReflection"/> class.
		/// </summary>
		static FortRecallPokemonMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkZQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvRm9y",
						"dFJlY2FsbFBva2Vtb25NZXNzYWdlLnByb3RvEidQT0dPUHJvdG9zLk5ldHdv",
						"cmtpbmcuUmVxdWVzdHMuTWVzc2FnZXMicgoYRm9ydFJlY2FsbFBva2Vtb25N",
						"ZXNzYWdlEg8KB2ZvcnRfaWQYASABKAkSEgoKcG9rZW1vbl9pZBgCIAEoBBIX",
						"Cg9wbGF5ZXJfbGF0aXR1ZGUYAyABKAESGAoQcGxheWVyX2xvbmdpdHVkZRgE",
						"IAEoAWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.FortRecallPokemonMessage),
							global::POGOProtos.Networking.Requests.Messages.FortRecallPokemonMessage.Parser,
							new[] { "FortId", "PokemonId", "PlayerLatitude", "PlayerLongitude" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort recall pokemon message.
	/// </summary>
	public sealed partial class FortRecallPokemonMessage : pb::IMessage<FortRecallPokemonMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "fort_id" field.</summary>
		public const int FortIdFieldNumber = 1;

		/// <summary>Field number for the "pokemon_id" field.</summary>
		public const int PokemonIdFieldNumber = 2;

		/// <summary>Field number for the "player_latitude" field.</summary>
		public const int PlayerLatitudeFieldNumber = 3;

		/// <summary>Field number for the "player_longitude" field.</summary>
		public const int PlayerLongitudeFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortRecallPokemonMessage> _parser =
			new pb::MessageParser<FortRecallPokemonMessage>(() => new FortRecallPokemonMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The fort id_.
		/// </summary>
		private string fortId_ = string.Empty;

		/// <summary>
		/// The player latitude_.
		/// </summary>
		private double playerLatitude_;

		/// <summary>
		/// The player longitude_.
		/// </summary>
		private double playerLongitude_;

		/// <summary>
		/// The pokemon id_.
		/// </summary>
		private ulong pokemonId_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortRecallPokemonMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortRecallPokemonMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortRecallPokemonMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortRecallPokemonMessage(FortRecallPokemonMessage other) : this()
		{
			fortId_ = other.fortId_;
			pokemonId_ = other.pokemonId_;
			playerLatitude_ = other.playerLatitude_;
			playerLongitude_ = other.playerLongitude_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortRecallPokemonMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.FortRecallPokemonMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the fort id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string FortId
		{
			get
			{
				return fortId_;
			}

			set
			{
				fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong PokemonId
		{
			get
			{
				return pokemonId_;
			}

			set
			{
				pokemonId_ = value;
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
		/// The <see cref="FortRecallPokemonMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortRecallPokemonMessage Clone()
		{
			return new FortRecallPokemonMessage(this);
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
		public bool Equals(FortRecallPokemonMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (FortId != other.FortId)
			{
				return false;
			}

			if (PokemonId != other.PokemonId)
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
			if (FortId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(FortId);
			}

			if (PokemonId != 0UL)
			{
				output.WriteRawTag(16);
				output.WriteUInt64(PokemonId);
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
			if (FortId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
			}

			if (PokemonId != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(PokemonId);
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
		public void MergeFrom(FortRecallPokemonMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.FortId.Length != 0)
			{
				FortId = other.FortId;
			}

			if (other.PokemonId != 0UL)
			{
				PokemonId = other.PokemonId;
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
						FortId = input.ReadString();
						break;
					}

					case 16:
					{
						PokemonId = input.ReadUInt64();
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
			return Equals(other as FortRecallPokemonMessage);
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
			if (FortId.Length != 0)
			{
				hash ^= FortId.GetHashCode();
			}

			if (PokemonId != 0UL)
			{
				hash ^= PokemonId.GetHashCode();
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