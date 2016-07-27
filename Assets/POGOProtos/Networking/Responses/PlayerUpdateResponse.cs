// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerUpdateResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/PlayerUpdateResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Map.Fort;
using POGOProtos.Map.Pokemon;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/PlayerUpdateResponse.proto</summary>
	public static partial class PlayerUpdateResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/PlayerUpdateResponse.proto</summary>
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
		/// Initializes static members of the <see cref="PlayerUpdateResponseReflection"/> class.
		/// </summary>
		static PlayerUpdateResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjpQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1BsYXllclVwZGF0",
						"ZVJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9u",
						"c2VzGiJQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnREYXRhLnByb3RvGihQT0dP",
						"UHJvdG9zL01hcC9Qb2tlbW9uL1dpbGRQb2tlbW9uLnByb3RvIpYBChRQbGF5",
						"ZXJVcGRhdGVSZXNwb25zZRI6Cg13aWxkX3Bva2Vtb25zGAEgAygLMiMuUE9H",
						"T1Byb3Rvcy5NYXAuUG9rZW1vbi5XaWxkUG9rZW1vbhIsCgVmb3J0cxgCIAMo",
						"CzIdLlBPR09Qcm90b3MuTWFwLkZvcnQuRm9ydERhdGESFAoMZm9ydHNfbmVh",
						"cmJ5GAMgASgFYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Map.Fort.FortDataReflection.Descriptor,
					global::POGOProtos.Map.Pokemon.WildPokemonReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.PlayerUpdateResponse),
							global::POGOProtos.Networking.Responses.PlayerUpdateResponse.Parser,
							new[] { "WildPokemons", "Forts", "FortsNearby" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The player update response.
	/// </summary>
	public sealed partial class PlayerUpdateResponse : pb::IMessage<PlayerUpdateResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "wild_pokemons" field.</summary>
		public const int WildPokemonsFieldNumber = 1;

		/// <summary>Field number for the "forts" field.</summary>
		public const int FortsFieldNumber = 2;

		/// <summary>Field number for the "forts_nearby" field.</summary>
		public const int FortsNearbyFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PlayerUpdateResponse> _parser =
			new pb::MessageParser<PlayerUpdateResponse>(() => new PlayerUpdateResponse());

		/// <summary>
		/// The _repeated_wild pokemons_codec.
		/// </summary>
		private static readonly pb.FieldCodec<WildPokemon> _repeated_wildPokemons_codec = pb::FieldCodec.ForMessage(
			10,
			global::POGOProtos.Map.Pokemon.WildPokemon.Parser);

		/// <summary>
		/// The _repeated_forts_codec.
		/// </summary>
		private static readonly pb.FieldCodec<FortData> _repeated_forts_codec = pb::FieldCodec.ForMessage(
			18,
			global::POGOProtos.Map.Fort.FortData.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The forts_.
		/// </summary>
		private readonly pbc.RepeatedField<FortData> forts_ = new pbc::RepeatedField<FortData>();

		/// <summary>
		/// The forts nearby_.
		/// </summary>
		private int fortsNearby_;

		/// <summary>
		/// The wild pokemons_.
		/// </summary>
		private readonly pbc.RepeatedField<WildPokemon> wildPokemons_ = new pbc::RepeatedField<WildPokemon>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerUpdateResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerUpdateResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerUpdateResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerUpdateResponse(PlayerUpdateResponse other) : this()
		{
			wildPokemons_ = other.wildPokemons_.Clone();
			forts_ = other.forts_.Clone();
			fortsNearby_ = other.fortsNearby_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PlayerUpdateResponse> Parser
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
				return global::POGOProtos.Networking.Responses.PlayerUpdateResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets the wild pokemons.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<WildPokemon> WildPokemons
		{
			get
			{
				return wildPokemons_;
			}
		}

		/// <summary>
		/// Gets the forts.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<FortData> Forts
		{
			get
			{
				return forts_;
			}
		}

		/// <summary>
		/// Gets or sets the forts nearby.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int FortsNearby
		{
			get
			{
				return fortsNearby_;
			}

			set
			{
				fortsNearby_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PlayerUpdateResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerUpdateResponse Clone()
		{
			return new PlayerUpdateResponse(this);
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
		public bool Equals(PlayerUpdateResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!wildPokemons_.Equals(other.wildPokemons_))
			{
				return false;
			}

			if (!forts_.Equals(other.forts_))
			{
				return false;
			}

			if (FortsNearby != other.FortsNearby)
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
			wildPokemons_.WriteTo(output, _repeated_wildPokemons_codec);
			forts_.WriteTo(output, _repeated_forts_codec);
			if (FortsNearby != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(FortsNearby);
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
			size += wildPokemons_.CalculateSize(_repeated_wildPokemons_codec);
			size += forts_.CalculateSize(_repeated_forts_codec);
			if (FortsNearby != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(FortsNearby);
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
		public void MergeFrom(PlayerUpdateResponse other)
		{
			if (other == null)
			{
				return;
			}

			wildPokemons_.Add(other.wildPokemons_);
			forts_.Add(other.forts_);
			if (other.FortsNearby != 0)
			{
				FortsNearby = other.FortsNearby;
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
						wildPokemons_.AddEntriesFrom(input, _repeated_wildPokemons_codec);
						break;
					}

					case 18:
					{
						forts_.AddEntriesFrom(input, _repeated_forts_codec);
						break;
					}

					case 24:
					{
						FortsNearby = input.ReadInt32();
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
			return Equals(other as PlayerUpdateResponse);
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
			hash ^= wildPokemons_.GetHashCode();
			hash ^= forts_.GetHashCode();
			if (FortsNearby != 0)
			{
				hash ^= FortsNearby.GetHashCode();
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