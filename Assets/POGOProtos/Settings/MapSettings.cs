// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/MapSettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/MapSettings.proto</summary>
	public static partial class MapSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/MapSettings.proto</summary>
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
		/// Initializes static members of the <see cref="MapSettingsReflection"/> class.
		/// </summary>
		static MapSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiVQT0dPUHJvdG9zL1NldHRpbmdzL01hcFNldHRpbmdzLnByb3RvEhNQT0dP",
						"UHJvdG9zLlNldHRpbmdzIo8CCgtNYXBTZXR0aW5ncxIdChVwb2tlbW9uX3Zp",
						"c2libGVfcmFuZ2UYASABKAESHQoVcG9rZV9uYXZfcmFuZ2VfbWV0ZXJzGAIg",
						"ASgBEh4KFmVuY291bnRlcl9yYW5nZV9tZXRlcnMYAyABKAESKwojZ2V0X21h",
						"cF9vYmplY3RzX21pbl9yZWZyZXNoX3NlY29uZHMYBCABKAISKwojZ2V0X21h",
						"cF9vYmplY3RzX21heF9yZWZyZXNoX3NlY29uZHMYBSABKAISKwojZ2V0X21h",
						"cF9vYmplY3RzX21pbl9kaXN0YW5jZV9tZXRlcnMYBiABKAISGwoTZ29vZ2xl",
						"X21hcHNfYXBpX2tleRgHIAEoCWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.MapSettings),
							global::POGOProtos.Settings.MapSettings.Parser,
							new[]
							{
								"PokemonVisibleRange", "PokeNavRangeMeters", "EncounterRangeMeters", "GetMapObjectsMinRefreshSeconds",
								"GetMapObjectsMaxRefreshSeconds", "GetMapObjectsMinDistanceMeters", "GoogleMapsApiKey"
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
	/// The map settings.
	/// </summary>
	public sealed partial class MapSettings : pb::IMessage<MapSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "pokemon_visible_range" field.</summary>
		public const int PokemonVisibleRangeFieldNumber = 1;

		/// <summary>Field number for the "poke_nav_range_meters" field.</summary>
		public const int PokeNavRangeMetersFieldNumber = 2;

		/// <summary>Field number for the "encounter_range_meters" field.</summary>
		public const int EncounterRangeMetersFieldNumber = 3;

		/// <summary>Field number for the "get_map_objects_min_refresh_seconds" field.</summary>
		public const int GetMapObjectsMinRefreshSecondsFieldNumber = 4;

		/// <summary>Field number for the "get_map_objects_max_refresh_seconds" field.</summary>
		public const int GetMapObjectsMaxRefreshSecondsFieldNumber = 5;

		/// <summary>Field number for the "get_map_objects_min_distance_meters" field.</summary>
		public const int GetMapObjectsMinDistanceMetersFieldNumber = 6;

		/// <summary>Field number for the "google_maps_api_key" field.</summary>
		public const int GoogleMapsApiKeyFieldNumber = 7;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<MapSettings> _parser =
			new pb::MessageParser<MapSettings>(() => new MapSettings());

		#endregion

		#region  Fields

		/// <summary>
		/// The encounter range meters_.
		/// </summary>
		private double encounterRangeMeters_;

		/// <summary>
		/// The get map objects max refresh seconds_.
		/// </summary>
		private float getMapObjectsMaxRefreshSeconds_;

		/// <summary>
		/// The get map objects min distance meters_.
		/// </summary>
		private float getMapObjectsMinDistanceMeters_;

		/// <summary>
		/// The get map objects min refresh seconds_.
		/// </summary>
		private float getMapObjectsMinRefreshSeconds_;

		/// <summary>
		/// The google maps api key_.
		/// </summary>
		private string googleMapsApiKey_ = string.Empty;

		/// <summary>
		/// The pokemon visible range_.
		/// </summary>
		private double pokemonVisibleRange_;

		/// <summary>
		/// The poke nav range meters_.
		/// </summary>
		private double pokeNavRangeMeters_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="MapSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="MapSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapSettings(MapSettings other) : this()
		{
			pokemonVisibleRange_ = other.pokemonVisibleRange_;
			pokeNavRangeMeters_ = other.pokeNavRangeMeters_;
			encounterRangeMeters_ = other.encounterRangeMeters_;
			getMapObjectsMinRefreshSeconds_ = other.getMapObjectsMinRefreshSeconds_;
			getMapObjectsMaxRefreshSeconds_ = other.getMapObjectsMaxRefreshSeconds_;
			getMapObjectsMinDistanceMeters_ = other.getMapObjectsMinDistanceMeters_;
			googleMapsApiKey_ = other.googleMapsApiKey_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<MapSettings> Parser
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
				return global::POGOProtos.Settings.MapSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the pokemon visible range.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double PokemonVisibleRange
		{
			get
			{
				return pokemonVisibleRange_;
			}

			set
			{
				pokemonVisibleRange_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the poke nav range meters.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double PokeNavRangeMeters
		{
			get
			{
				return pokeNavRangeMeters_;
			}

			set
			{
				pokeNavRangeMeters_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the encounter range meters.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double EncounterRangeMeters
		{
			get
			{
				return encounterRangeMeters_;
			}

			set
			{
				encounterRangeMeters_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the get map objects min refresh seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float GetMapObjectsMinRefreshSeconds
		{
			get
			{
				return getMapObjectsMinRefreshSeconds_;
			}

			set
			{
				getMapObjectsMinRefreshSeconds_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the get map objects max refresh seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float GetMapObjectsMaxRefreshSeconds
		{
			get
			{
				return getMapObjectsMaxRefreshSeconds_;
			}

			set
			{
				getMapObjectsMaxRefreshSeconds_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the get map objects min distance meters.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float GetMapObjectsMinDistanceMeters
		{
			get
			{
				return getMapObjectsMinDistanceMeters_;
			}

			set
			{
				getMapObjectsMinDistanceMeters_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the google maps api key.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string GoogleMapsApiKey
		{
			get
			{
				return googleMapsApiKey_;
			}

			set
			{
				googleMapsApiKey_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="MapSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapSettings Clone()
		{
			return new MapSettings(this);
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
		public bool Equals(MapSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (PokemonVisibleRange != other.PokemonVisibleRange)
			{
				return false;
			}

			if (PokeNavRangeMeters != other.PokeNavRangeMeters)
			{
				return false;
			}

			if (EncounterRangeMeters != other.EncounterRangeMeters)
			{
				return false;
			}

			if (GetMapObjectsMinRefreshSeconds != other.GetMapObjectsMinRefreshSeconds)
			{
				return false;
			}

			if (GetMapObjectsMaxRefreshSeconds != other.GetMapObjectsMaxRefreshSeconds)
			{
				return false;
			}

			if (GetMapObjectsMinDistanceMeters != other.GetMapObjectsMinDistanceMeters)
			{
				return false;
			}

			if (GoogleMapsApiKey != other.GoogleMapsApiKey)
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
			if (PokemonVisibleRange != 0D)
			{
				output.WriteRawTag(9);
				output.WriteDouble(PokemonVisibleRange);
			}

			if (PokeNavRangeMeters != 0D)
			{
				output.WriteRawTag(17);
				output.WriteDouble(PokeNavRangeMeters);
			}

			if (EncounterRangeMeters != 0D)
			{
				output.WriteRawTag(25);
				output.WriteDouble(EncounterRangeMeters);
			}

			if (GetMapObjectsMinRefreshSeconds != 0F)
			{
				output.WriteRawTag(37);
				output.WriteFloat(GetMapObjectsMinRefreshSeconds);
			}

			if (GetMapObjectsMaxRefreshSeconds != 0F)
			{
				output.WriteRawTag(45);
				output.WriteFloat(GetMapObjectsMaxRefreshSeconds);
			}

			if (GetMapObjectsMinDistanceMeters != 0F)
			{
				output.WriteRawTag(53);
				output.WriteFloat(GetMapObjectsMinDistanceMeters);
			}

			if (GoogleMapsApiKey.Length != 0)
			{
				output.WriteRawTag(58);
				output.WriteString(GoogleMapsApiKey);
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
			if (PokemonVisibleRange != 0D)
			{
				size += 1 + 8;
			}

			if (PokeNavRangeMeters != 0D)
			{
				size += 1 + 8;
			}

			if (EncounterRangeMeters != 0D)
			{
				size += 1 + 8;
			}

			if (GetMapObjectsMinRefreshSeconds != 0F)
			{
				size += 1 + 4;
			}

			if (GetMapObjectsMaxRefreshSeconds != 0F)
			{
				size += 1 + 4;
			}

			if (GetMapObjectsMinDistanceMeters != 0F)
			{
				size += 1 + 4;
			}

			if (GoogleMapsApiKey.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(GoogleMapsApiKey);
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
		public void MergeFrom(MapSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.PokemonVisibleRange != 0D)
			{
				PokemonVisibleRange = other.PokemonVisibleRange;
			}

			if (other.PokeNavRangeMeters != 0D)
			{
				PokeNavRangeMeters = other.PokeNavRangeMeters;
			}

			if (other.EncounterRangeMeters != 0D)
			{
				EncounterRangeMeters = other.EncounterRangeMeters;
			}

			if (other.GetMapObjectsMinRefreshSeconds != 0F)
			{
				GetMapObjectsMinRefreshSeconds = other.GetMapObjectsMinRefreshSeconds;
			}

			if (other.GetMapObjectsMaxRefreshSeconds != 0F)
			{
				GetMapObjectsMaxRefreshSeconds = other.GetMapObjectsMaxRefreshSeconds;
			}

			if (other.GetMapObjectsMinDistanceMeters != 0F)
			{
				GetMapObjectsMinDistanceMeters = other.GetMapObjectsMinDistanceMeters;
			}

			if (other.GoogleMapsApiKey.Length != 0)
			{
				GoogleMapsApiKey = other.GoogleMapsApiKey;
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
						PokemonVisibleRange = input.ReadDouble();
						break;
					}

					case 17:
					{
						PokeNavRangeMeters = input.ReadDouble();
						break;
					}

					case 25:
					{
						EncounterRangeMeters = input.ReadDouble();
						break;
					}

					case 37:
					{
						GetMapObjectsMinRefreshSeconds = input.ReadFloat();
						break;
					}

					case 45:
					{
						GetMapObjectsMaxRefreshSeconds = input.ReadFloat();
						break;
					}

					case 53:
					{
						GetMapObjectsMinDistanceMeters = input.ReadFloat();
						break;
					}

					case 58:
					{
						GoogleMapsApiKey = input.ReadString();
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
			return Equals(other as MapSettings);
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
			if (PokemonVisibleRange != 0D)
			{
				hash ^= PokemonVisibleRange.GetHashCode();
			}

			if (PokeNavRangeMeters != 0D)
			{
				hash ^= PokeNavRangeMeters.GetHashCode();
			}

			if (EncounterRangeMeters != 0D)
			{
				hash ^= EncounterRangeMeters.GetHashCode();
			}

			if (GetMapObjectsMinRefreshSeconds != 0F)
			{
				hash ^= GetMapObjectsMinRefreshSeconds.GetHashCode();
			}

			if (GetMapObjectsMaxRefreshSeconds != 0F)
			{
				hash ^= GetMapObjectsMaxRefreshSeconds.GetHashCode();
			}

			if (GetMapObjectsMinDistanceMeters != 0F)
			{
				hash ^= GetMapObjectsMinDistanceMeters.GetHashCode();
			}

			if (GoogleMapsApiKey.Length != 0)
			{
				hash ^= GoogleMapsApiKey.GetHashCode();
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