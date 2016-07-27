// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IncenseAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Item/IncenseAttributes.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master.Item
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/IncenseAttributes.proto</summary>
	public static partial class IncenseAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Item/IncenseAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="IncenseAttributesReflection"/> class.
		/// </summary>
		static IncenseAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjdQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0luY2Vuc2VBdHRy",
						"aWJ1dGVzLnByb3RvEh9QT0dPUHJvdG9zLlNldHRpbmdzLk1hc3Rlci5JdGVt",
						"GiJQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25UeXBlLnByb3RvItICChFJbmNl",
						"bnNlQXR0cmlidXRlcxIgChhpbmNlbnNlX2xpZmV0aW1lX3NlY29uZHMYASAB",
						"KAUSMwoMcG9rZW1vbl90eXBlGAIgAygOMh0uUE9HT1Byb3Rvcy5FbnVtcy5Q",
						"b2tlbW9uVHlwZRIoCiBwb2tlbW9uX2luY2Vuc2VfdHlwZV9wcm9iYWJpbGl0",
						"eRgDIAEoAhIwCihzdGFuZGluZ190aW1lX2JldHdlZW5fZW5jb3VudGVyc19z",
						"ZWNvbmRzGAQgASgFEi0KJW1vdmluZ190aW1lX2JldHdlZW5fZW5jb3VudGVy",
						"X3NlY29uZHMYBSABKAUSNQotZGlzdGFuY2VfcmVxdWlyZWRfZm9yX3Nob3J0",
						"ZXJfaW50ZXJ2YWxfbWV0ZXJzGAYgASgFEiQKHHBva2Vtb25fYXR0cmFjdGVk",
						"X2xlbmd0aF9zZWMYByABKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.PokemonTypeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Item.IncenseAttributes),
							global::POGOProtos.Settings.Master.Item.IncenseAttributes.Parser,
							new[]
							{
								"IncenseLifetimeSeconds", "PokemonType", "PokemonIncenseTypeProbability",
								"StandingTimeBetweenEncountersSeconds", "MovingTimeBetweenEncounterSeconds",
								"DistanceRequiredForShorterIntervalMeters", "PokemonAttractedLengthSec"
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
	/// The incense attributes.
	/// </summary>
	public sealed partial class IncenseAttributes : pb::IMessage<IncenseAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "incense_lifetime_seconds" field.</summary>
		public const int IncenseLifetimeSecondsFieldNumber = 1;

		/// <summary>Field number for the "pokemon_type" field.</summary>
		public const int PokemonTypeFieldNumber = 2;

		/// <summary>Field number for the "pokemon_incense_type_probability" field.</summary>
		public const int PokemonIncenseTypeProbabilityFieldNumber = 3;

		/// <summary>Field number for the "standing_time_between_encounters_seconds" field.</summary>
		public const int StandingTimeBetweenEncountersSecondsFieldNumber = 4;

		/// <summary>Field number for the "moving_time_between_encounter_seconds" field.</summary>
		public const int MovingTimeBetweenEncounterSecondsFieldNumber = 5;

		/// <summary>Field number for the "distance_required_for_shorter_interval_meters" field.</summary>
		public const int DistanceRequiredForShorterIntervalMetersFieldNumber = 6;

		/// <summary>Field number for the "pokemon_attracted_length_sec" field.</summary>
		public const int PokemonAttractedLengthSecFieldNumber = 7;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<IncenseAttributes> _parser =
			new pb::MessageParser<IncenseAttributes>(() => new IncenseAttributes());

		/// <summary>
		/// The _repeated_pokemon type_codec.
		/// </summary>
		private static readonly pb.FieldCodec<PokemonType> _repeated_pokemonType_codec = pb::FieldCodec.ForEnum(
			18,
			x => (int)x,
			x => (global::POGOProtos.Enums.PokemonType)x);

		#endregion

		#region  Fields

		/// <summary>
		/// The distance required for shorter interval meters_.
		/// </summary>
		private int distanceRequiredForShorterIntervalMeters_;

		/// <summary>
		/// The incense lifetime seconds_.
		/// </summary>
		private int incenseLifetimeSeconds_;

		/// <summary>
		/// The moving time between encounter seconds_.
		/// </summary>
		private int movingTimeBetweenEncounterSeconds_;

		/// <summary>
		/// The pokemon attracted length sec_.
		/// </summary>
		private int pokemonAttractedLengthSec_;

		/// <summary>
		/// The pokemon incense type probability_.
		/// </summary>
		private float pokemonIncenseTypeProbability_;

		/// <summary>
		/// The pokemon type_.
		/// </summary>
		private readonly pbc.RepeatedField<PokemonType> pokemonType_ = new pbc::RepeatedField<PokemonType>();

		/// <summary>
		/// The standing time between encounters seconds_.
		/// </summary>
		private int standingTimeBetweenEncountersSeconds_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="IncenseAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IncenseAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="IncenseAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IncenseAttributes(IncenseAttributes other) : this()
		{
			incenseLifetimeSeconds_ = other.incenseLifetimeSeconds_;
			pokemonType_ = other.pokemonType_.Clone();
			pokemonIncenseTypeProbability_ = other.pokemonIncenseTypeProbability_;
			standingTimeBetweenEncountersSeconds_ = other.standingTimeBetweenEncountersSeconds_;
			movingTimeBetweenEncounterSeconds_ = other.movingTimeBetweenEncounterSeconds_;
			distanceRequiredForShorterIntervalMeters_ = other.distanceRequiredForShorterIntervalMeters_;
			pokemonAttractedLengthSec_ = other.pokemonAttractedLengthSec_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<IncenseAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Item.IncenseAttributesReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the incense lifetime seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int IncenseLifetimeSeconds
		{
			get
			{
				return incenseLifetimeSeconds_;
			}

			set
			{
				incenseLifetimeSeconds_ = value;
			}
		}

		/// <summary>
		/// Gets the pokemon type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<PokemonType> PokemonType
		{
			get
			{
				return pokemonType_;
			}
		}

		/// <summary>
		/// Gets or sets the pokemon incense type probability.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float PokemonIncenseTypeProbability
		{
			get
			{
				return pokemonIncenseTypeProbability_;
			}

			set
			{
				pokemonIncenseTypeProbability_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the standing time between encounters seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int StandingTimeBetweenEncountersSeconds
		{
			get
			{
				return standingTimeBetweenEncountersSeconds_;
			}

			set
			{
				standingTimeBetweenEncountersSeconds_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the moving time between encounter seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MovingTimeBetweenEncounterSeconds
		{
			get
			{
				return movingTimeBetweenEncounterSeconds_;
			}

			set
			{
				movingTimeBetweenEncounterSeconds_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the distance required for shorter interval meters.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int DistanceRequiredForShorterIntervalMeters
		{
			get
			{
				return distanceRequiredForShorterIntervalMeters_;
			}

			set
			{
				distanceRequiredForShorterIntervalMeters_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the pokemon attracted length sec.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int PokemonAttractedLengthSec
		{
			get
			{
				return pokemonAttractedLengthSec_;
			}

			set
			{
				pokemonAttractedLengthSec_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="IncenseAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IncenseAttributes Clone()
		{
			return new IncenseAttributes(this);
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
		public bool Equals(IncenseAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (IncenseLifetimeSeconds != other.IncenseLifetimeSeconds)
			{
				return false;
			}

			if (!pokemonType_.Equals(other.pokemonType_))
			{
				return false;
			}

			if (PokemonIncenseTypeProbability != other.PokemonIncenseTypeProbability)
			{
				return false;
			}

			if (StandingTimeBetweenEncountersSeconds != other.StandingTimeBetweenEncountersSeconds)
			{
				return false;
			}

			if (MovingTimeBetweenEncounterSeconds != other.MovingTimeBetweenEncounterSeconds)
			{
				return false;
			}

			if (DistanceRequiredForShorterIntervalMeters != other.DistanceRequiredForShorterIntervalMeters)
			{
				return false;
			}

			if (PokemonAttractedLengthSec != other.PokemonAttractedLengthSec)
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
			if (IncenseLifetimeSeconds != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(IncenseLifetimeSeconds);
			}

			pokemonType_.WriteTo(output, _repeated_pokemonType_codec);
			if (PokemonIncenseTypeProbability != 0F)
			{
				output.WriteRawTag(29);
				output.WriteFloat(PokemonIncenseTypeProbability);
			}

			if (StandingTimeBetweenEncountersSeconds != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(StandingTimeBetweenEncountersSeconds);
			}

			if (MovingTimeBetweenEncounterSeconds != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(MovingTimeBetweenEncounterSeconds);
			}

			if (DistanceRequiredForShorterIntervalMeters != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(DistanceRequiredForShorterIntervalMeters);
			}

			if (PokemonAttractedLengthSec != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(PokemonAttractedLengthSec);
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
			if (IncenseLifetimeSeconds != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(IncenseLifetimeSeconds);
			}

			size += pokemonType_.CalculateSize(_repeated_pokemonType_codec);
			if (PokemonIncenseTypeProbability != 0F)
			{
				size += 1 + 4;
			}

			if (StandingTimeBetweenEncountersSeconds != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(StandingTimeBetweenEncountersSeconds);
			}

			if (MovingTimeBetweenEncounterSeconds != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MovingTimeBetweenEncounterSeconds);
			}

			if (DistanceRequiredForShorterIntervalMeters != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(DistanceRequiredForShorterIntervalMeters);
			}

			if (PokemonAttractedLengthSec != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(PokemonAttractedLengthSec);
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
		public void MergeFrom(IncenseAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.IncenseLifetimeSeconds != 0)
			{
				IncenseLifetimeSeconds = other.IncenseLifetimeSeconds;
			}

			pokemonType_.Add(other.pokemonType_);
			if (other.PokemonIncenseTypeProbability != 0F)
			{
				PokemonIncenseTypeProbability = other.PokemonIncenseTypeProbability;
			}

			if (other.StandingTimeBetweenEncountersSeconds != 0)
			{
				StandingTimeBetweenEncountersSeconds = other.StandingTimeBetweenEncountersSeconds;
			}

			if (other.MovingTimeBetweenEncounterSeconds != 0)
			{
				MovingTimeBetweenEncounterSeconds = other.MovingTimeBetweenEncounterSeconds;
			}

			if (other.DistanceRequiredForShorterIntervalMeters != 0)
			{
				DistanceRequiredForShorterIntervalMeters = other.DistanceRequiredForShorterIntervalMeters;
			}

			if (other.PokemonAttractedLengthSec != 0)
			{
				PokemonAttractedLengthSec = other.PokemonAttractedLengthSec;
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
						IncenseLifetimeSeconds = input.ReadInt32();
						break;
					}

					case 18:
					case 16:
					{
						pokemonType_.AddEntriesFrom(input, _repeated_pokemonType_codec);
						break;
					}

					case 29:
					{
						PokemonIncenseTypeProbability = input.ReadFloat();
						break;
					}

					case 32:
					{
						StandingTimeBetweenEncountersSeconds = input.ReadInt32();
						break;
					}

					case 40:
					{
						MovingTimeBetweenEncounterSeconds = input.ReadInt32();
						break;
					}

					case 48:
					{
						DistanceRequiredForShorterIntervalMeters = input.ReadInt32();
						break;
					}

					case 56:
					{
						PokemonAttractedLengthSec = input.ReadInt32();
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
			return Equals(other as IncenseAttributes);
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
			if (IncenseLifetimeSeconds != 0)
			{
				hash ^= IncenseLifetimeSeconds.GetHashCode();
			}

			hash ^= pokemonType_.GetHashCode();
			if (PokemonIncenseTypeProbability != 0F)
			{
				hash ^= PokemonIncenseTypeProbability.GetHashCode();
			}

			if (StandingTimeBetweenEncountersSeconds != 0)
			{
				hash ^= StandingTimeBetweenEncountersSeconds.GetHashCode();
			}

			if (MovingTimeBetweenEncounterSeconds != 0)
			{
				hash ^= MovingTimeBetweenEncounterSeconds.GetHashCode();
			}

			if (DistanceRequiredForShorterIntervalMeters != 0)
			{
				hash ^= DistanceRequiredForShorterIntervalMeters.GetHashCode();
			}

			if (PokemonAttractedLengthSec != 0)
			{
				hash ^= PokemonAttractedLengthSec.GetHashCode();
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