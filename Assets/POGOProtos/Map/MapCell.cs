// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapCell.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/MapCell.proto
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

namespace POGOProtos.Map
{
	/// <summary>Holder for reflection information generated from POGOProtos/Map/MapCell.proto</summary>
	public static partial class MapCellReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/MapCell.proto</summary>
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
		/// Initializes static members of the <see cref="MapCellReflection"/> class.
		/// </summary>
		static MapCellReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"ChxQT0dPUHJvdG9zL01hcC9NYXBDZWxsLnByb3RvEg5QT0dPUHJvdG9zLk1h",
						"cBofUE9HT1Byb3Rvcy9NYXAvU3Bhd25Qb2ludC5wcm90bxoiUE9HT1Byb3Rv",
						"cy9NYXAvRm9ydC9Gb3J0RGF0YS5wcm90bxolUE9HT1Byb3Rvcy9NYXAvRm9y",
						"dC9Gb3J0U3VtbWFyeS5wcm90bxoqUE9HT1Byb3Rvcy9NYXAvUG9rZW1vbi9O",
						"ZWFyYnlQb2tlbW9uLnByb3RvGihQT0dPUHJvdG9zL01hcC9Qb2tlbW9uL1dp",
						"bGRQb2tlbW9uLnByb3RvGidQT0dPUHJvdG9zL01hcC9Qb2tlbW9uL01hcFBv",
						"a2Vtb24ucHJvdG8igQQKB01hcENlbGwSEgoKczJfY2VsbF9pZBgBIAEoBBIc",
						"ChRjdXJyZW50X3RpbWVzdGFtcF9tcxgCIAEoAxIsCgVmb3J0cxgDIAMoCzId",
						"LlBPR09Qcm90b3MuTWFwLkZvcnQuRm9ydERhdGESMAoMc3Bhd25fcG9pbnRz",
						"GAQgAygLMhouUE9HT1Byb3Rvcy5NYXAuU3Bhd25Qb2ludBIXCg9kZWxldGVk",
						"X29iamVjdHMYBiADKAkSGQoRaXNfdHJ1bmNhdGVkX2xpc3QYByABKAgSOAoO",
						"Zm9ydF9zdW1tYXJpZXMYCCADKAsyIC5QT0dPUHJvdG9zLk1hcC5Gb3J0LkZv",
						"cnRTdW1tYXJ5EjoKFmRlY2ltYXRlZF9zcGF3bl9wb2ludHMYCSADKAsyGi5Q",
						"T0dPUHJvdG9zLk1hcC5TcGF3blBvaW50EjoKDXdpbGRfcG9rZW1vbnMYBSAD",
						"KAsyIy5QT0dPUHJvdG9zLk1hcC5Qb2tlbW9uLldpbGRQb2tlbW9uEj4KEmNh",
						"dGNoYWJsZV9wb2tlbW9ucxgKIAMoCzIiLlBPR09Qcm90b3MuTWFwLlBva2Vt",
						"b24uTWFwUG9rZW1vbhI+Cg9uZWFyYnlfcG9rZW1vbnMYCyADKAsyJS5QT0dP",
						"UHJvdG9zLk1hcC5Qb2tlbW9uLk5lYXJieVBva2Vtb25iBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Map.SpawnPointReflection.Descriptor, global::POGOProtos.Map.Fort.FortDataReflection.Descriptor,
					global::POGOProtos.Map.Fort.FortSummaryReflection.Descriptor,
					global::POGOProtos.Map.Pokemon.NearbyPokemonReflection.Descriptor,
					global::POGOProtos.Map.Pokemon.WildPokemonReflection.Descriptor,
					global::POGOProtos.Map.Pokemon.MapPokemonReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Map.MapCell),
							global::POGOProtos.Map.MapCell.Parser,
							new[]
							{
								"S2CellId", "CurrentTimestampMs", "Forts", "SpawnPoints", "DeletedObjects", "IsTruncatedList", "FortSummaries",
								"DecimatedSpawnPoints", "WildPokemons", "CatchablePokemons", "NearbyPokemons"
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
	///  A cell is a geographical "zone" containing objects like pokemon, gyms, and pokestops.
	/// </summary>
	public sealed partial class MapCell : pb::IMessage<MapCell>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "s2_cell_id" field.</summary>
		public const int S2CellIdFieldNumber = 1;

		/// <summary>Field number for the "current_timestamp_ms" field.</summary>
		public const int CurrentTimestampMsFieldNumber = 2;

		/// <summary>Field number for the "forts" field.</summary>
		public const int FortsFieldNumber = 3;

		/// <summary>Field number for the "spawn_points" field.</summary>
		public const int SpawnPointsFieldNumber = 4;

		/// <summary>Field number for the "deleted_objects" field.</summary>
		public const int DeletedObjectsFieldNumber = 6;

		/// <summary>Field number for the "is_truncated_list" field.</summary>
		public const int IsTruncatedListFieldNumber = 7;

		/// <summary>Field number for the "fort_summaries" field.</summary>
		public const int FortSummariesFieldNumber = 8;

		/// <summary>Field number for the "decimated_spawn_points" field.</summary>
		public const int DecimatedSpawnPointsFieldNumber = 9;

		/// <summary>Field number for the "wild_pokemons" field.</summary>
		public const int WildPokemonsFieldNumber = 5;

		/// <summary>Field number for the "catchable_pokemons" field.</summary>
		public const int CatchablePokemonsFieldNumber = 10;

		/// <summary>Field number for the "nearby_pokemons" field.</summary>
		public const int NearbyPokemonsFieldNumber = 11;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<MapCell> _parser = new pb::MessageParser<MapCell>(() => new MapCell());

		/// <summary>
		/// The _repeated_forts_codec.
		/// </summary>
		private static readonly pb.FieldCodec<FortData> _repeated_forts_codec = pb::FieldCodec.ForMessage(
			26,
			global::POGOProtos.Map.Fort.FortData.Parser);

		/// <summary>
		/// The _repeated_spawn points_codec.
		/// </summary>
		private static readonly pb.FieldCodec<SpawnPoint> _repeated_spawnPoints_codec = pb::FieldCodec.ForMessage(
			34,
			global::POGOProtos.Map.SpawnPoint.Parser);

		/// <summary>
		/// The _repeated_deleted objects_codec.
		/// </summary>
		private static readonly pb.FieldCodec<string> _repeated_deletedObjects_codec = pb::FieldCodec.ForString(50);

		/// <summary>
		/// The _repeated_fort summaries_codec.
		/// </summary>
		private static readonly pb.FieldCodec<FortSummary> _repeated_fortSummaries_codec = pb::FieldCodec.ForMessage(
			66,
			global::POGOProtos.Map.Fort.FortSummary.Parser);

		/// <summary>
		/// The _repeated_decimated spawn points_codec.
		/// </summary>
		private static readonly pb.FieldCodec<SpawnPoint> _repeated_decimatedSpawnPoints_codec = pb::FieldCodec.ForMessage(
			74,
			global::POGOProtos.Map.SpawnPoint.Parser);

		/// <summary>
		/// The _repeated_wild pokemons_codec.
		/// </summary>
		private static readonly pb.FieldCodec<WildPokemon> _repeated_wildPokemons_codec = pb::FieldCodec.ForMessage(
			42,
			global::POGOProtos.Map.Pokemon.WildPokemon.Parser);

		/// <summary>
		/// The _repeated_catchable pokemons_codec.
		/// </summary>
		private static readonly pb.FieldCodec<MapPokemon> _repeated_catchablePokemons_codec = pb::FieldCodec.ForMessage(
			82,
			global::POGOProtos.Map.Pokemon.MapPokemon.Parser);

		/// <summary>
		/// The _repeated_nearby pokemons_codec.
		/// </summary>
		private static readonly pb.FieldCodec<NearbyPokemon> _repeated_nearbyPokemons_codec = pb::FieldCodec.ForMessage(
			90,
			global::POGOProtos.Map.Pokemon.NearbyPokemon.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The catchable pokemons_.
		/// </summary>
		private readonly pbc.RepeatedField<MapPokemon> catchablePokemons_ = new pbc::RepeatedField<MapPokemon>();

		/// <summary>
		/// The current timestamp ms_.
		/// </summary>
		private long currentTimestampMs_;

		/// <summary>
		/// The decimated spawn points_.
		/// </summary>
		private readonly pbc.RepeatedField<SpawnPoint> decimatedSpawnPoints_ = new pbc::RepeatedField<SpawnPoint>();

		/// <summary>
		/// The deleted objects_.
		/// </summary>
		private readonly pbc.RepeatedField<string> deletedObjects_ = new pbc::RepeatedField<string>();

		/// <summary>
		/// The forts_.
		/// </summary>
		private readonly pbc.RepeatedField<FortData> forts_ = new pbc::RepeatedField<FortData>();

		/// <summary>
		/// The fort summaries_.
		/// </summary>
		private readonly pbc.RepeatedField<FortSummary> fortSummaries_ = new pbc::RepeatedField<FortSummary>();

		/// <summary>
		/// The is truncated list_.
		/// </summary>
		private bool isTruncatedList_;

		/// <summary>
		/// The nearby pokemons_.
		/// </summary>
		private readonly pbc.RepeatedField<NearbyPokemon> nearbyPokemons_ = new pbc::RepeatedField<NearbyPokemon>();

		/// <summary>
		/// The s 2 cell id_.
		/// </summary>
		private ulong s2CellId_;

		/// <summary>
		/// The spawn points_.
		/// </summary>
		private readonly pbc.RepeatedField<SpawnPoint> spawnPoints_ = new pbc::RepeatedField<SpawnPoint>();

		/// <summary>
		/// The wild pokemons_.
		/// </summary>
		private readonly pbc.RepeatedField<WildPokemon> wildPokemons_ = new pbc::RepeatedField<WildPokemon>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="MapCell"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapCell()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MapCell"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapCell(MapCell other) : this()
		{
			s2CellId_ = other.s2CellId_;
			currentTimestampMs_ = other.currentTimestampMs_;
			forts_ = other.forts_.Clone();
			spawnPoints_ = other.spawnPoints_.Clone();
			deletedObjects_ = other.deletedObjects_.Clone();
			isTruncatedList_ = other.isTruncatedList_;
			fortSummaries_ = other.fortSummaries_.Clone();
			decimatedSpawnPoints_ = other.decimatedSpawnPoints_.Clone();
			wildPokemons_ = other.wildPokemons_.Clone();
			catchablePokemons_ = other.catchablePokemons_.Clone();
			nearbyPokemons_ = other.nearbyPokemons_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<MapCell> Parser
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
				return global::POGOProtos.Map.MapCellReflection.Descriptor.MessageTypes[0];
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
		///  S2 geographic area that the cell covers (http://s2map.com/) (https://code.google.com/archive/p/s2-geometry-library/)
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong S2CellId
		{
			get
			{
				return s2CellId_;
			}

			set
			{
				s2CellId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the current timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long CurrentTimestampMs
		{
			get
			{
				return currentTimestampMs_;
			}

			set
			{
				currentTimestampMs_ = value;
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
		/// Gets the spawn points.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<SpawnPoint> SpawnPoints
		{
			get
			{
				return spawnPoints_;
			}
		}

		/// <summary>
		/// Gets the deleted objects.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<string> DeletedObjects
		{
			get
			{
				return deletedObjects_;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether is truncated list.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool IsTruncatedList
		{
			get
			{
				return isTruncatedList_;
			}

			set
			{
				isTruncatedList_ = value;
			}
		}

		/// <summary>
		/// Gets the fort summaries.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<FortSummary> FortSummaries
		{
			get
			{
				return fortSummaries_;
			}
		}

		/// <summary>
		/// Gets the decimated spawn points.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<SpawnPoint> DecimatedSpawnPoints
		{
			get
			{
				return decimatedSpawnPoints_;
			}
		}

		/// <summary>
		///  Pokemon within 2 steps or less.
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
		///  Pokemon within 1 step or none.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<MapPokemon> CatchablePokemons
		{
			get
			{
				return catchablePokemons_;
			}
		}

		/// <summary>
		///  Pokemon farther away than 2 steps, but still in the area.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<NearbyPokemon> NearbyPokemons
		{
			get
			{
				return nearbyPokemons_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="MapCell"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapCell Clone()
		{
			return new MapCell(this);
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
		public bool Equals(MapCell other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (S2CellId != other.S2CellId)
			{
				return false;
			}

			if (CurrentTimestampMs != other.CurrentTimestampMs)
			{
				return false;
			}

			if (!forts_.Equals(other.forts_))
			{
				return false;
			}

			if (!spawnPoints_.Equals(other.spawnPoints_))
			{
				return false;
			}

			if (!deletedObjects_.Equals(other.deletedObjects_))
			{
				return false;
			}

			if (IsTruncatedList != other.IsTruncatedList)
			{
				return false;
			}

			if (!fortSummaries_.Equals(other.fortSummaries_))
			{
				return false;
			}

			if (!decimatedSpawnPoints_.Equals(other.decimatedSpawnPoints_))
			{
				return false;
			}

			if (!wildPokemons_.Equals(other.wildPokemons_))
			{
				return false;
			}

			if (!catchablePokemons_.Equals(other.catchablePokemons_))
			{
				return false;
			}

			if (!nearbyPokemons_.Equals(other.nearbyPokemons_))
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
			if (S2CellId != 0UL)
			{
				output.WriteRawTag(8);
				output.WriteUInt64(S2CellId);
			}

			if (CurrentTimestampMs != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(CurrentTimestampMs);
			}

			forts_.WriteTo(output, _repeated_forts_codec);
			spawnPoints_.WriteTo(output, _repeated_spawnPoints_codec);
			wildPokemons_.WriteTo(output, _repeated_wildPokemons_codec);
			deletedObjects_.WriteTo(output, _repeated_deletedObjects_codec);
			if (IsTruncatedList != false)
			{
				output.WriteRawTag(56);
				output.WriteBool(IsTruncatedList);
			}

			fortSummaries_.WriteTo(output, _repeated_fortSummaries_codec);
			decimatedSpawnPoints_.WriteTo(output, _repeated_decimatedSpawnPoints_codec);
			catchablePokemons_.WriteTo(output, _repeated_catchablePokemons_codec);
			nearbyPokemons_.WriteTo(output, _repeated_nearbyPokemons_codec);
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
			if (S2CellId != 0UL)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt64Size(S2CellId);
			}

			if (CurrentTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(CurrentTimestampMs);
			}

			size += forts_.CalculateSize(_repeated_forts_codec);
			size += spawnPoints_.CalculateSize(_repeated_spawnPoints_codec);
			size += deletedObjects_.CalculateSize(_repeated_deletedObjects_codec);
			if (IsTruncatedList != false)
			{
				size += 1 + 1;
			}

			size += fortSummaries_.CalculateSize(_repeated_fortSummaries_codec);
			size += decimatedSpawnPoints_.CalculateSize(_repeated_decimatedSpawnPoints_codec);
			size += wildPokemons_.CalculateSize(_repeated_wildPokemons_codec);
			size += catchablePokemons_.CalculateSize(_repeated_catchablePokemons_codec);
			size += nearbyPokemons_.CalculateSize(_repeated_nearbyPokemons_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(MapCell other)
		{
			if (other == null)
			{
				return;
			}

			if (other.S2CellId != 0UL)
			{
				S2CellId = other.S2CellId;
			}

			if (other.CurrentTimestampMs != 0L)
			{
				CurrentTimestampMs = other.CurrentTimestampMs;
			}

			forts_.Add(other.forts_);
			spawnPoints_.Add(other.spawnPoints_);
			deletedObjects_.Add(other.deletedObjects_);
			if (other.IsTruncatedList != false)
			{
				IsTruncatedList = other.IsTruncatedList;
			}

			fortSummaries_.Add(other.fortSummaries_);
			decimatedSpawnPoints_.Add(other.decimatedSpawnPoints_);
			wildPokemons_.Add(other.wildPokemons_);
			catchablePokemons_.Add(other.catchablePokemons_);
			nearbyPokemons_.Add(other.nearbyPokemons_);
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
						S2CellId = input.ReadUInt64();
						break;
					}

					case 16:
					{
						CurrentTimestampMs = input.ReadInt64();
						break;
					}

					case 26:
					{
						forts_.AddEntriesFrom(input, _repeated_forts_codec);
						break;
					}

					case 34:
					{
						spawnPoints_.AddEntriesFrom(input, _repeated_spawnPoints_codec);
						break;
					}

					case 42:
					{
						wildPokemons_.AddEntriesFrom(input, _repeated_wildPokemons_codec);
						break;
					}

					case 50:
					{
						deletedObjects_.AddEntriesFrom(input, _repeated_deletedObjects_codec);
						break;
					}

					case 56:
					{
						IsTruncatedList = input.ReadBool();
						break;
					}

					case 66:
					{
						fortSummaries_.AddEntriesFrom(input, _repeated_fortSummaries_codec);
						break;
					}

					case 74:
					{
						decimatedSpawnPoints_.AddEntriesFrom(input, _repeated_decimatedSpawnPoints_codec);
						break;
					}

					case 82:
					{
						catchablePokemons_.AddEntriesFrom(input, _repeated_catchablePokemons_codec);
						break;
					}

					case 90:
					{
						nearbyPokemons_.AddEntriesFrom(input, _repeated_nearbyPokemons_codec);
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
			return Equals(other as MapCell);
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
			if (S2CellId != 0UL)
			{
				hash ^= S2CellId.GetHashCode();
			}

			if (CurrentTimestampMs != 0L)
			{
				hash ^= CurrentTimestampMs.GetHashCode();
			}

			hash ^= forts_.GetHashCode();
			hash ^= spawnPoints_.GetHashCode();
			hash ^= deletedObjects_.GetHashCode();
			if (IsTruncatedList != false)
			{
				hash ^= IsTruncatedList.GetHashCode();
			}

			hash ^= fortSummaries_.GetHashCode();
			hash ^= decimatedSpawnPoints_.GetHashCode();
			hash ^= wildPokemons_.GetHashCode();
			hash ^= catchablePokemons_.GetHashCode();
			hash ^= nearbyPokemons_.GetHashCode();
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