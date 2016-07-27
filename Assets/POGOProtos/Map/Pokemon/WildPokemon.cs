// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WildPokemon.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/Pokemon/WildPokemon.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Map.Pokemon
{
	/// <summary>Holder for reflection information generated from POGOProtos/Map/Pokemon/WildPokemon.proto</summary>
	public static partial class WildPokemonReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/Pokemon/WildPokemon.proto</summary>
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
		/// Initializes static members of the <see cref="WildPokemonReflection"/> class.
		/// </summary>
		static WildPokemonReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CihQT0dPUHJvdG9zL01hcC9Qb2tlbW9uL1dpbGRQb2tlbW9uLnByb3RvEhZQ",
						"T0dPUHJvdG9zLk1hcC5Qb2tlbW9uGiFQT0dPUHJvdG9zL0RhdGEvUG9rZW1v",
						"bkRhdGEucHJvdG8i1QEKC1dpbGRQb2tlbW9uEhQKDGVuY291bnRlcl9pZBgB",
						"IAEoBhIiChpsYXN0X21vZGlmaWVkX3RpbWVzdGFtcF9tcxgCIAEoAxIQCghs",
						"YXRpdHVkZRgDIAEoARIRCglsb25naXR1ZGUYBCABKAESFgoOc3Bhd25fcG9p",
						"bnRfaWQYBSABKAkSMgoMcG9rZW1vbl9kYXRhGAcgASgLMhwuUE9HT1Byb3Rv",
						"cy5EYXRhLlBva2Vtb25EYXRhEhsKE3RpbWVfdGlsbF9oaWRkZW5fbXMYCyAB",
						"KAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.PokemonDataReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Map.Pokemon.WildPokemon),
							global::POGOProtos.Map.Pokemon.WildPokemon.Parser,
							new[]
							{
								"EncounterId", "LastModifiedTimestampMs", "Latitude", "Longitude", "SpawnPointId", "PokemonData",
								"TimeTillHiddenMs"
							},
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The wild pokemon.
	/// </summary>
	public sealed partial class WildPokemon : pb::IMessage<WildPokemon>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "encounter_id" field.</summary>
		public const int EncounterIdFieldNumber = 1;

		/// <summary>Field number for the "last_modified_timestamp_ms" field.</summary>
		public const int LastModifiedTimestampMsFieldNumber = 2;

		/// <summary>Field number for the "latitude" field.</summary>
		public const int LatitudeFieldNumber = 3;

		/// <summary>Field number for the "longitude" field.</summary>
		public const int LongitudeFieldNumber = 4;

		/// <summary>Field number for the "spawn_point_id" field.</summary>
		public const int SpawnPointIdFieldNumber = 5;

		/// <summary>Field number for the "pokemon_data" field.</summary>
		public const int PokemonDataFieldNumber = 7;

		/// <summary>Field number for the "time_till_hidden_ms" field.</summary>
		public const int TimeTillHiddenMsFieldNumber = 11;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<WildPokemon> _parser =
			new pb::MessageParser<WildPokemon>(() => new WildPokemon());

		#endregion

		#region  Fields

		/// <summary>
		/// The encounter id_.
		/// </summary>
		private ulong encounterId_;

		/// <summary>
		/// The last modified timestamp ms_.
		/// </summary>
		private long lastModifiedTimestampMs_;

		/// <summary>
		/// The latitude_.
		/// </summary>
		private double latitude_;

		/// <summary>
		/// The longitude_.
		/// </summary>
		private double longitude_;

		/// <summary>
		/// The pokemon data_.
		/// </summary>
		private PokemonData pokemonData_;

		/// <summary>
		/// The spawn point id_.
		/// </summary>
		private string spawnPointId_ = string.Empty;

		/// <summary>
		/// The time till hidden ms_.
		/// </summary>
		private int timeTillHiddenMs_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="WildPokemon"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public WildPokemon()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="WildPokemon"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public WildPokemon(WildPokemon other) : this()
		{
			encounterId_ = other.encounterId_;
			lastModifiedTimestampMs_ = other.lastModifiedTimestampMs_;
			latitude_ = other.latitude_;
			longitude_ = other.longitude_;
			spawnPointId_ = other.spawnPointId_;
			PokemonData = other.pokemonData_ != null ? other.PokemonData.Clone() : null;
			timeTillHiddenMs_ = other.timeTillHiddenMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<WildPokemon> Parser
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
				return global::POGOProtos.Map.Pokemon.WildPokemonReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the last modified timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long LastModifiedTimestampMs
		{
			get
			{
				return lastModifiedTimestampMs_;
			}

			set
			{
				lastModifiedTimestampMs_ = value;
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
		/// Gets or sets the time till hidden ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int TimeTillHiddenMs
		{
			get
			{
				return timeTillHiddenMs_;
			}

			set
			{
				timeTillHiddenMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="WildPokemon"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public WildPokemon Clone()
		{
			return new WildPokemon(this);
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
		public bool Equals(WildPokemon other)
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

			if (LastModifiedTimestampMs != other.LastModifiedTimestampMs)
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

			if (SpawnPointId != other.SpawnPointId)
			{
				return false;
			}

			if (!object.Equals(PokemonData, other.PokemonData))
			{
				return false;
			}

			if (TimeTillHiddenMs != other.TimeTillHiddenMs)
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

			if (LastModifiedTimestampMs != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(LastModifiedTimestampMs);
			}

			if (Latitude != 0D)
			{
				output.WriteRawTag(25);
				output.WriteDouble(Latitude);
			}

			if (Longitude != 0D)
			{
				output.WriteRawTag(33);
				output.WriteDouble(Longitude);
			}

			if (SpawnPointId.Length != 0)
			{
				output.WriteRawTag(42);
				output.WriteString(SpawnPointId);
			}

			if (pokemonData_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(PokemonData);
			}

			if (TimeTillHiddenMs != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(TimeTillHiddenMs);
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

			if (LastModifiedTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastModifiedTimestampMs);
			}

			if (Latitude != 0D)
			{
				size += 1 + 8;
			}

			if (Longitude != 0D)
			{
				size += 1 + 8;
			}

			if (SpawnPointId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(SpawnPointId);
			}

			if (pokemonData_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(PokemonData);
			}

			if (TimeTillHiddenMs != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimeTillHiddenMs);
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
		public void MergeFrom(WildPokemon other)
		{
			if (other == null)
			{
				return;
			}

			if (other.EncounterId != 0UL)
			{
				EncounterId = other.EncounterId;
			}

			if (other.LastModifiedTimestampMs != 0L)
			{
				LastModifiedTimestampMs = other.LastModifiedTimestampMs;
			}

			if (other.Latitude != 0D)
			{
				Latitude = other.Latitude;
			}

			if (other.Longitude != 0D)
			{
				Longitude = other.Longitude;
			}

			if (other.SpawnPointId.Length != 0)
			{
				SpawnPointId = other.SpawnPointId;
			}

			if (other.pokemonData_ != null)
			{
				if (pokemonData_ == null)
				{
					pokemonData_ = new global::POGOProtos.Data.PokemonData();
				}

				PokemonData.MergeFrom(other.PokemonData);
			}

			if (other.TimeTillHiddenMs != 0)
			{
				TimeTillHiddenMs = other.TimeTillHiddenMs;
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

					case 16:
					{
						LastModifiedTimestampMs = input.ReadInt64();
						break;
					}

					case 25:
					{
						Latitude = input.ReadDouble();
						break;
					}

					case 33:
					{
						Longitude = input.ReadDouble();
						break;
					}

					case 42:
					{
						SpawnPointId = input.ReadString();
						break;
					}

					case 58:
					{
						if (pokemonData_ == null)
						{
							pokemonData_ = new global::POGOProtos.Data.PokemonData();
						}

						input.ReadMessage(pokemonData_);
						break;
					}

					case 88:
					{
						TimeTillHiddenMs = input.ReadInt32();
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
			return Equals(other as WildPokemon);
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

			if (LastModifiedTimestampMs != 0L)
			{
				hash ^= LastModifiedTimestampMs.GetHashCode();
			}

			if (Latitude != 0D)
			{
				hash ^= Latitude.GetHashCode();
			}

			if (Longitude != 0D)
			{
				hash ^= Longitude.GetHashCode();
			}

			if (SpawnPointId.Length != 0)
			{
				hash ^= SpawnPointId.GetHashCode();
			}

			if (pokemonData_ != null)
			{
				hash ^= PokemonData.GetHashCode();
			}

			if (TimeTillHiddenMs != 0)
			{
				hash ^= TimeTillHiddenMs.GetHashCode();
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