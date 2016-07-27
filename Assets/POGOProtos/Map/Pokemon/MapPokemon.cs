// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapPokemon.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/Pokemon/MapPokemon.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Map.Pokemon
{
	/// <summary>Holder for reflection information generated from POGOProtos/Map/Pokemon/MapPokemon.proto</summary>
	public static partial class MapPokemonReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/Pokemon/MapPokemon.proto</summary>
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
		/// Initializes static members of the <see cref="MapPokemonReflection"/> class.
		/// </summary>
		static MapPokemonReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CidQT0dPUHJvdG9zL01hcC9Qb2tlbW9uL01hcFBva2Vtb24ucHJvdG8SFlBP",
						"R09Qcm90b3MuTWFwLlBva2Vtb24aIFBPR09Qcm90b3MvRW51bXMvUG9rZW1v",
						"bklkLnByb3RvIrEBCgpNYXBQb2tlbW9uEhYKDnNwYXduX3BvaW50X2lkGAEg",
						"ASgJEhQKDGVuY291bnRlcl9pZBgCIAEoBhIvCgpwb2tlbW9uX2lkGAMgASgO",
						"MhsuUE9HT1Byb3Rvcy5FbnVtcy5Qb2tlbW9uSWQSHwoXZXhwaXJhdGlvbl90",
						"aW1lc3RhbXBfbXMYBCABKAMSEAoIbGF0aXR1ZGUYBSABKAESEQoJbG9uZ2l0",
						"dWRlGAYgASgBYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Map.Pokemon.MapPokemon),
							global::POGOProtos.Map.Pokemon.MapPokemon.Parser,
							new[] { "SpawnPointId", "EncounterId", "PokemonId", "ExpirationTimestampMs", "Latitude", "Longitude" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The map pokemon.
	/// </summary>
	public sealed partial class MapPokemon : pb::IMessage<MapPokemon>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "spawn_point_id" field.</summary>
		public const int SpawnPointIdFieldNumber = 1;

		/// <summary>Field number for the "encounter_id" field.</summary>
		public const int EncounterIdFieldNumber = 2;

		/// <summary>Field number for the "pokemon_id" field.</summary>
		public const int PokemonIdFieldNumber = 3;

		/// <summary>Field number for the "expiration_timestamp_ms" field.</summary>
		public const int ExpirationTimestampMsFieldNumber = 4;

		/// <summary>Field number for the "latitude" field.</summary>
		public const int LatitudeFieldNumber = 5;

		/// <summary>Field number for the "longitude" field.</summary>
		public const int LongitudeFieldNumber = 6;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<MapPokemon> _parser =
			new pb::MessageParser<MapPokemon>(() => new MapPokemon());

		#endregion

		#region  Fields

		/// <summary>
		/// The encounter id_.
		/// </summary>
		private ulong encounterId_;

		/// <summary>
		/// The expiration timestamp ms_.
		/// </summary>
		private long expirationTimestampMs_;

		/// <summary>
		/// The latitude_.
		/// </summary>
		private double latitude_;

		/// <summary>
		/// The longitude_.
		/// </summary>
		private double longitude_;

		/// <summary>
		/// The pokemon id_.
		/// </summary>
		private PokemonId pokemonId_ = 0;

		/// <summary>
		/// The spawn point id_.
		/// </summary>
		private string spawnPointId_ = string.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="MapPokemon"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapPokemon()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MapPokemon"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapPokemon(MapPokemon other) : this()
		{
			spawnPointId_ = other.spawnPointId_;
			encounterId_ = other.encounterId_;
			pokemonId_ = other.pokemonId_;
			expirationTimestampMs_ = other.expirationTimestampMs_;
			latitude_ = other.latitude_;
			longitude_ = other.longitude_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<MapPokemon> Parser
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
				return global::POGOProtos.Map.Pokemon.MapPokemonReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonId PokemonId
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
		///  After this timestamp, the pokemon will be gone.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long ExpirationTimestampMs
		{
			get
			{
				return expirationTimestampMs_;
			}

			set
			{
				expirationTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the latitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Latitude
		{
			get
			{
				return latitude_;
			}

			set
			{
				latitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Longitude
		{
			get
			{
				return longitude_;
			}

			set
			{
				longitude_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="MapPokemon"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapPokemon Clone()
		{
			return new MapPokemon(this);
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
		public bool Equals(MapPokemon other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (SpawnPointId != other.SpawnPointId)
			{
				return false;
			}

			if (EncounterId != other.EncounterId)
			{
				return false;
			}

			if (PokemonId != other.PokemonId)
			{
				return false;
			}

			if (ExpirationTimestampMs != other.ExpirationTimestampMs)
			{
				return false;
			}

			if (Latitude != other.Latitude)
			{
				return false;
			}

			if (Longitude != other.Longitude)
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
			if (SpawnPointId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(SpawnPointId);
			}

			if (EncounterId != 0UL)
			{
				output.WriteRawTag(17);
				output.WriteFixed64(EncounterId);
			}

			if (PokemonId != 0)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)PokemonId);
			}

			if (ExpirationTimestampMs != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(ExpirationTimestampMs);
			}

			if (Latitude != 0D)
			{
				output.WriteRawTag(41);
				output.WriteDouble(Latitude);
			}

			if (Longitude != 0D)
			{
				output.WriteRawTag(49);
				output.WriteDouble(Longitude);
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
			if (SpawnPointId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointId);
			}

			if (EncounterId != 0UL)
			{
				size += 1 + 8;
			}

			if (PokemonId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonId);
			}

			if (ExpirationTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(ExpirationTimestampMs);
			}

			if (Latitude != 0D)
			{
				size += 1 + 8;
			}

			if (Longitude != 0D)
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
		public void MergeFrom(MapPokemon other)
		{
			if (other == null)
			{
				return;
			}

			if (other.SpawnPointId.Length != 0)
			{
				SpawnPointId = other.SpawnPointId;
			}

			if (other.EncounterId != 0UL)
			{
				EncounterId = other.EncounterId;
			}

			if (other.PokemonId != 0)
			{
				PokemonId = other.PokemonId;
			}

			if (other.ExpirationTimestampMs != 0L)
			{
				ExpirationTimestampMs = other.ExpirationTimestampMs;
			}

			if (other.Latitude != 0D)
			{
				Latitude = other.Latitude;
			}

			if (other.Longitude != 0D)
			{
				Longitude = other.Longitude;
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
						SpawnPointId = input.ReadString();
						break;
					}

					case 17:
					{
						EncounterId = input.ReadFixed64();
						break;
					}

					case 24:
					{
						pokemonId_ = (global::POGOProtos.Enums.PokemonId)input.ReadEnum();
						break;
					}

					case 32:
					{
						ExpirationTimestampMs = input.ReadInt64();
						break;
					}

					case 41:
					{
						Latitude = input.ReadDouble();
						break;
					}

					case 49:
					{
						Longitude = input.ReadDouble();
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
			return Equals(other as MapPokemon);
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
			if (SpawnPointId.Length != 0)
			{
				hash ^= SpawnPointId.GetHashCode();
			}

			if (EncounterId != 0UL)
			{
				hash ^= EncounterId.GetHashCode();
			}

			if (PokemonId != 0)
			{
				hash ^= PokemonId.GetHashCode();
			}

			if (ExpirationTimestampMs != 0L)
			{
				hash ^= ExpirationTimestampMs.GetHashCode();
			}

			if (Latitude != 0D)
			{
				hash ^= Latitude.GetHashCode();
			}

			if (Longitude != 0D)
			{
				hash ^= Longitude.GetHashCode();
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