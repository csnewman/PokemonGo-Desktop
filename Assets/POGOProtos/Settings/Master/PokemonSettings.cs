// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokemonSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/PokemonSettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using POGOProtos.Settings.Master.Pokemon;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/PokemonSettings.proto</summary>
	public static partial class PokemonSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/PokemonSettings.proto</summary>
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
		/// Initializes static members of the <see cref="PokemonSettingsReflection"/> class.
		/// </summary>
		static PokemonSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjBQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9Qb2tlbW9uU2V0dGluZ3Mu",
						"cHJvdG8SGlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyGiBQT0dPUHJvdG9z",
						"L0VudW1zL1Bva2Vtb25JZC5wcm90bxokUE9HT1Byb3Rvcy9FbnVtcy9Qb2tl",
						"bW9uUmFyaXR5LnByb3RvGiJQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25UeXBl",
						"LnByb3RvGiJQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25Nb3ZlLnByb3RvGiZQ",
						"T0dPUHJvdG9zL0VudW1zL1Bva2Vtb25GYW1pbHlJZC5wcm90bxo4UE9HT1By",
						"b3Rvcy9TZXR0aW5ncy9NYXN0ZXIvUG9rZW1vbi9TdGF0c0F0dHJpYnV0ZXMu",
						"cHJvdG8aOVBPR09Qcm90b3MvU2V0dGluZ3MvTWFzdGVyL1Bva2Vtb24vQ2Ft",
						"ZXJhQXR0cmlidXRlcy5wcm90bxo8UE9HT1Byb3Rvcy9TZXR0aW5ncy9NYXN0",
						"ZXIvUG9rZW1vbi9FbmNvdW50ZXJBdHRyaWJ1dGVzLnByb3RvIpQHCg9Qb2tl",
						"bW9uU2V0dGluZ3MSLwoKcG9rZW1vbl9pZBgBIAEoDjIbLlBPR09Qcm90b3Mu",
						"RW51bXMuUG9rZW1vbklkEhMKC21vZGVsX3NjYWxlGAMgASgCEisKBHR5cGUY",
						"BCABKA4yHS5QT0dPUHJvdG9zLkVudW1zLlBva2Vtb25UeXBlEi0KBnR5cGVf",
						"MhgFIAEoDjIdLlBPR09Qcm90b3MuRW51bXMuUG9rZW1vblR5cGUSRAoGY2Ft",
						"ZXJhGAYgASgLMjQuUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIuUG9rZW1v",
						"bi5DYW1lcmFBdHRyaWJ1dGVzEkoKCWVuY291bnRlchgHIAEoCzI3LlBPR09Q",
						"cm90b3MuU2V0dGluZ3MuTWFzdGVyLlBva2Vtb24uRW5jb3VudGVyQXR0cmli",
						"dXRlcxJCCgVzdGF0cxgIIAEoCzIzLlBPR09Qcm90b3MuU2V0dGluZ3MuTWFz",
						"dGVyLlBva2Vtb24uU3RhdHNBdHRyaWJ1dGVzEjIKC3F1aWNrX21vdmVzGAkg",
						"AygOMh0uUE9HT1Byb3Rvcy5FbnVtcy5Qb2tlbW9uTW92ZRI2Cg9jaW5lbWF0",
						"aWNfbW92ZXMYCiADKA4yHS5QT0dPUHJvdG9zLkVudW1zLlBva2Vtb25Nb3Zl",
						"EhYKDmFuaW1hdGlvbl90aW1lGAsgAygCEjIKDWV2b2x1dGlvbl9pZHMYDCAD",
						"KA4yGy5QT0dPUHJvdG9zLkVudW1zLlBva2Vtb25JZBIWCg5ldm9sdXRpb25f",
						"cGlwcxgNIAEoBRIvCgZyYXJpdHkYDiABKA4yHy5QT0dPUHJvdG9zLkVudW1z",
						"LlBva2Vtb25SYXJpdHkSGAoQcG9rZWRleF9oZWlnaHRfbRgPIAEoAhIZChFw",
						"b2tlZGV4X3dlaWdodF9rZxgQIAEoAhI2ChFwYXJlbnRfcG9rZW1vbl9pZBgR",
						"IAEoDjIbLlBPR09Qcm90b3MuRW51bXMuUG9rZW1vbklkEhYKDmhlaWdodF9z",
						"dGRfZGV2GBIgASgCEhYKDndlaWdodF9zdGRfZGV2GBMgASgCEhwKFGttX2Rp",
						"c3RhbmNlX3RvX2hhdGNoGBQgASgCEjQKCWZhbWlseV9pZBgVIAEoDjIhLlBP",
						"R09Qcm90b3MuRW51bXMuUG9rZW1vbkZhbWlseUlkEhcKD2NhbmR5X3RvX2V2",
						"b2x2ZRgWIAEoBWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Enums.PokemonIdReflection.Descriptor,
					global::POGOProtos.Enums.PokemonRarityReflection.Descriptor,
					global::POGOProtos.Enums.PokemonTypeReflection.Descriptor,
					global::POGOProtos.Enums.PokemonMoveReflection.Descriptor,
					global::POGOProtos.Enums.PokemonFamilyIdReflection.Descriptor,
					global::POGOProtos.Settings.Master.Pokemon.StatsAttributesReflection.Descriptor,
					global::POGOProtos.Settings.Master.Pokemon.CameraAttributesReflection.Descriptor,
					global::POGOProtos.Settings.Master.Pokemon.EncounterAttributesReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.PokemonSettings),
							global::POGOProtos.Settings.Master.PokemonSettings.Parser,
							new[]
							{
								"PokemonId", "ModelScale", "Type", "Type2", "Camera", "Encounter", "Stats", "QuickMoves", "CinematicMoves",
								"AnimationTime", "EvolutionIds", "EvolutionPips", "Rarity", "PokedexHeightM", "PokedexWeightKg",
								"ParentPokemonId", "HeightStdDev", "WeightStdDev", "KmDistanceToHatch", "FamilyId", "CandyToEvolve"
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
	/// The pokemon settings.
	/// </summary>
	public sealed partial class PokemonSettings : pb::IMessage<PokemonSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "pokemon_id" field.</summary>
		public const int PokemonIdFieldNumber = 1;

		/// <summary>Field number for the "model_scale" field.</summary>
		public const int ModelScaleFieldNumber = 3;

		/// <summary>Field number for the "type" field.</summary>
		public const int TypeFieldNumber = 4;

		/// <summary>Field number for the "type_2" field.</summary>
		public const int Type2FieldNumber = 5;

		/// <summary>Field number for the "camera" field.</summary>
		public const int CameraFieldNumber = 6;

		/// <summary>Field number for the "encounter" field.</summary>
		public const int EncounterFieldNumber = 7;

		/// <summary>Field number for the "stats" field.</summary>
		public const int StatsFieldNumber = 8;

		/// <summary>Field number for the "quick_moves" field.</summary>
		public const int QuickMovesFieldNumber = 9;

		/// <summary>Field number for the "cinematic_moves" field.</summary>
		public const int CinematicMovesFieldNumber = 10;

		/// <summary>Field number for the "animation_time" field.</summary>
		public const int AnimationTimeFieldNumber = 11;

		/// <summary>Field number for the "evolution_ids" field.</summary>
		public const int EvolutionIdsFieldNumber = 12;

		/// <summary>Field number for the "evolution_pips" field.</summary>
		public const int EvolutionPipsFieldNumber = 13;

		/// <summary>Field number for the "rarity" field.</summary>
		public const int RarityFieldNumber = 14;

		/// <summary>Field number for the "pokedex_height_m" field.</summary>
		public const int PokedexHeightMFieldNumber = 15;

		/// <summary>Field number for the "pokedex_weight_kg" field.</summary>
		public const int PokedexWeightKgFieldNumber = 16;

		/// <summary>Field number for the "parent_pokemon_id" field.</summary>
		public const int ParentPokemonIdFieldNumber = 17;

		/// <summary>Field number for the "height_std_dev" field.</summary>
		public const int HeightStdDevFieldNumber = 18;

		/// <summary>Field number for the "weight_std_dev" field.</summary>
		public const int WeightStdDevFieldNumber = 19;

		/// <summary>Field number for the "km_distance_to_hatch" field.</summary>
		public const int KmDistanceToHatchFieldNumber = 20;

		/// <summary>Field number for the "family_id" field.</summary>
		public const int FamilyIdFieldNumber = 21;

		/// <summary>Field number for the "candy_to_evolve" field.</summary>
		public const int CandyToEvolveFieldNumber = 22;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PokemonSettings> _parser =
			new pb::MessageParser<PokemonSettings>(() => new PokemonSettings());

		/// <summary>
		/// The _repeated_quick moves_codec.
		/// </summary>
		private static readonly pb.FieldCodec<PokemonMove> _repeated_quickMoves_codec = pb::FieldCodec.ForEnum(
			74,
			x => (int)x,
			x => (global::POGOProtos.Enums.PokemonMove)x);

		/// <summary>
		/// The _repeated_cinematic moves_codec.
		/// </summary>
		private static readonly pb.FieldCodec<PokemonMove> _repeated_cinematicMoves_codec = pb::FieldCodec.ForEnum(
			82,
			x => (int)x,
			x => (global::POGOProtos.Enums.PokemonMove)x);

		/// <summary>
		/// The _repeated_animation time_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_animationTime_codec = pb::FieldCodec.ForFloat(90);

		/// <summary>
		/// The _repeated_evolution ids_codec.
		/// </summary>
		private static readonly pb.FieldCodec<PokemonId> _repeated_evolutionIds_codec = pb::FieldCodec.ForEnum(
			98,
			x => (int)x,
			x => (global::POGOProtos.Enums.PokemonId)x);

		#endregion

		#region  Fields

		/// <summary>
		/// The animation time_.
		/// </summary>
		private readonly pbc.RepeatedField<float> animationTime_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The camera_.
		/// </summary>
		private CameraAttributes camera_;

		/// <summary>
		/// The candy to evolve_.
		/// </summary>
		private int candyToEvolve_;

		/// <summary>
		/// The cinematic moves_.
		/// </summary>
		private readonly pbc.RepeatedField<PokemonMove> cinematicMoves_ = new pbc::RepeatedField<PokemonMove>();

		/// <summary>
		/// The encounter_.
		/// </summary>
		private EncounterAttributes encounter_;

		/// <summary>
		/// The evolution ids_.
		/// </summary>
		private readonly pbc.RepeatedField<PokemonId> evolutionIds_ = new pbc::RepeatedField<PokemonId>();

		/// <summary>
		/// The evolution pips_.
		/// </summary>
		private int evolutionPips_;

		/// <summary>
		/// The family id_.
		/// </summary>
		private PokemonFamilyId familyId_ = 0;

		/// <summary>
		/// The height std dev_.
		/// </summary>
		private float heightStdDev_;

		/// <summary>
		/// The km distance to hatch_.
		/// </summary>
		private float kmDistanceToHatch_;

		/// <summary>
		/// The model scale_.
		/// </summary>
		private float modelScale_;

		/// <summary>
		/// The parent pokemon id_.
		/// </summary>
		private PokemonId parentPokemonId_ = 0;

		/// <summary>
		/// The pokedex height m_.
		/// </summary>
		private float pokedexHeightM_;

		/// <summary>
		/// The pokedex weight kg_.
		/// </summary>
		private float pokedexWeightKg_;

		/// <summary>
		/// The pokemon id_.
		/// </summary>
		private PokemonId pokemonId_ = 0;

		/// <summary>
		/// The quick moves_.
		/// </summary>
		private readonly pbc.RepeatedField<PokemonMove> quickMoves_ = new pbc::RepeatedField<PokemonMove>();

		/// <summary>
		/// The rarity_.
		/// </summary>
		private PokemonRarity rarity_ = 0;

		/// <summary>
		/// The stats_.
		/// </summary>
		private StatsAttributes stats_;

		/// <summary>
		/// The type_.
		/// </summary>
		private PokemonType type_ = 0;

		/// <summary>
		/// The type 2_.
		/// </summary>
		private PokemonType type2_ = 0;

		/// <summary>
		/// The weight std dev_.
		/// </summary>
		private float weightStdDev_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PokemonSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PokemonSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonSettings(PokemonSettings other) : this()
		{
			pokemonId_ = other.pokemonId_;
			modelScale_ = other.modelScale_;
			type_ = other.type_;
			type2_ = other.type2_;
			Camera = other.camera_ != null ? other.Camera.Clone() : null;
			Encounter = other.encounter_ != null ? other.Encounter.Clone() : null;
			Stats = other.stats_ != null ? other.Stats.Clone() : null;
			quickMoves_ = other.quickMoves_.Clone();
			cinematicMoves_ = other.cinematicMoves_.Clone();
			animationTime_ = other.animationTime_.Clone();
			evolutionIds_ = other.evolutionIds_.Clone();
			evolutionPips_ = other.evolutionPips_;
			rarity_ = other.rarity_;
			pokedexHeightM_ = other.pokedexHeightM_;
			pokedexWeightKg_ = other.pokedexWeightKg_;
			parentPokemonId_ = other.parentPokemonId_;
			heightStdDev_ = other.heightStdDev_;
			weightStdDev_ = other.weightStdDev_;
			kmDistanceToHatch_ = other.kmDistanceToHatch_;
			familyId_ = other.familyId_;
			candyToEvolve_ = other.candyToEvolve_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PokemonSettings> Parser
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
				return global::POGOProtos.Settings.Master.PokemonSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the model scale.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float ModelScale
		{
			get
			{
				return modelScale_;
			}

			set
			{
				modelScale_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonType Type
		{
			get
			{
				return type_;
			}

			set
			{
				type_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the type 2.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonType Type2
		{
			get
			{
				return type2_;
			}

			set
			{
				type2_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the camera.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CameraAttributes Camera
		{
			get
			{
				return camera_;
			}

			set
			{
				camera_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the encounter.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterAttributes Encounter
		{
			get
			{
				return encounter_;
			}

			set
			{
				encounter_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the stats.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public StatsAttributes Stats
		{
			get
			{
				return stats_;
			}

			set
			{
				stats_ = value;
			}
		}

		/// <summary>
		/// Gets the quick moves.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<PokemonMove> QuickMoves
		{
			get
			{
				return quickMoves_;
			}
		}

		/// <summary>
		/// Gets the cinematic moves.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<PokemonMove> CinematicMoves
		{
			get
			{
				return cinematicMoves_;
			}
		}

		/// <summary>
		/// Gets the animation time.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> AnimationTime
		{
			get
			{
				return animationTime_;
			}
		}

		/// <summary>
		/// Gets the evolution ids.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<PokemonId> EvolutionIds
		{
			get
			{
				return evolutionIds_;
			}
		}

		/// <summary>
		/// Gets or sets the evolution pips.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int EvolutionPips
		{
			get
			{
				return evolutionPips_;
			}

			set
			{
				evolutionPips_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the rarity.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonRarity Rarity
		{
			get
			{
				return rarity_;
			}

			set
			{
				rarity_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the pokedex height m.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float PokedexHeightM
		{
			get
			{
				return pokedexHeightM_;
			}

			set
			{
				pokedexHeightM_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the pokedex weight kg.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float PokedexWeightKg
		{
			get
			{
				return pokedexWeightKg_;
			}

			set
			{
				pokedexWeightKg_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the parent pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonId ParentPokemonId
		{
			get
			{
				return parentPokemonId_;
			}

			set
			{
				parentPokemonId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the height std dev.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float HeightStdDev
		{
			get
			{
				return heightStdDev_;
			}

			set
			{
				heightStdDev_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the weight std dev.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float WeightStdDev
		{
			get
			{
				return weightStdDev_;
			}

			set
			{
				weightStdDev_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the km distance to hatch.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float KmDistanceToHatch
		{
			get
			{
				return kmDistanceToHatch_;
			}

			set
			{
				kmDistanceToHatch_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the family id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonFamilyId FamilyId
		{
			get
			{
				return familyId_;
			}

			set
			{
				familyId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the candy to evolve.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int CandyToEvolve
		{
			get
			{
				return candyToEvolve_;
			}

			set
			{
				candyToEvolve_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PokemonSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonSettings Clone()
		{
			return new PokemonSettings(this);
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
		public bool Equals(PokemonSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (PokemonId != other.PokemonId)
			{
				return false;
			}

			if (ModelScale != other.ModelScale)
			{
				return false;
			}

			if (Type != other.Type)
			{
				return false;
			}

			if (Type2 != other.Type2)
			{
				return false;
			}

			if (!object.Equals(Camera, other.Camera))
			{
				return false;
			}

			if (!object.Equals(Encounter, other.Encounter))
			{
				return false;
			}

			if (!object.Equals(Stats, other.Stats))
			{
				return false;
			}

			if (!quickMoves_.Equals(other.quickMoves_))
			{
				return false;
			}

			if (!cinematicMoves_.Equals(other.cinematicMoves_))
			{
				return false;
			}

			if (!animationTime_.Equals(other.animationTime_))
			{
				return false;
			}

			if (!evolutionIds_.Equals(other.evolutionIds_))
			{
				return false;
			}

			if (EvolutionPips != other.EvolutionPips)
			{
				return false;
			}

			if (Rarity != other.Rarity)
			{
				return false;
			}

			if (PokedexHeightM != other.PokedexHeightM)
			{
				return false;
			}

			if (PokedexWeightKg != other.PokedexWeightKg)
			{
				return false;
			}

			if (ParentPokemonId != other.ParentPokemonId)
			{
				return false;
			}

			if (HeightStdDev != other.HeightStdDev)
			{
				return false;
			}

			if (WeightStdDev != other.WeightStdDev)
			{
				return false;
			}

			if (KmDistanceToHatch != other.KmDistanceToHatch)
			{
				return false;
			}

			if (FamilyId != other.FamilyId)
			{
				return false;
			}

			if (CandyToEvolve != other.CandyToEvolve)
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
			if (PokemonId != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)PokemonId);
			}

			if (ModelScale != 0F)
			{
				output.WriteRawTag(29);
				output.WriteFloat(ModelScale);
			}

			if (Type != 0)
			{
				output.WriteRawTag(32);
				output.WriteEnum((int)Type);
			}

			if (Type2 != 0)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)Type2);
			}

			if (camera_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(Camera);
			}

			if (encounter_ != null)
			{
				output.WriteRawTag(58);
				output.WriteMessage(Encounter);
			}

			if (stats_ != null)
			{
				output.WriteRawTag(66);
				output.WriteMessage(Stats);
			}

			quickMoves_.WriteTo(output, _repeated_quickMoves_codec);
			cinematicMoves_.WriteTo(output, _repeated_cinematicMoves_codec);
			animationTime_.WriteTo(output, _repeated_animationTime_codec);
			evolutionIds_.WriteTo(output, _repeated_evolutionIds_codec);
			if (EvolutionPips != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(EvolutionPips);
			}

			if (Rarity != 0)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)Rarity);
			}

			if (PokedexHeightM != 0F)
			{
				output.WriteRawTag(125);
				output.WriteFloat(PokedexHeightM);
			}

			if (PokedexWeightKg != 0F)
			{
				output.WriteRawTag(133, 1);
				output.WriteFloat(PokedexWeightKg);
			}

			if (ParentPokemonId != 0)
			{
				output.WriteRawTag(136, 1);
				output.WriteEnum((int)ParentPokemonId);
			}

			if (HeightStdDev != 0F)
			{
				output.WriteRawTag(149, 1);
				output.WriteFloat(HeightStdDev);
			}

			if (WeightStdDev != 0F)
			{
				output.WriteRawTag(157, 1);
				output.WriteFloat(WeightStdDev);
			}

			if (KmDistanceToHatch != 0F)
			{
				output.WriteRawTag(165, 1);
				output.WriteFloat(KmDistanceToHatch);
			}

			if (FamilyId != 0)
			{
				output.WriteRawTag(168, 1);
				output.WriteEnum((int)FamilyId);
			}

			if (CandyToEvolve != 0)
			{
				output.WriteRawTag(176, 1);
				output.WriteInt32(CandyToEvolve);
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
			if (PokemonId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)PokemonId);
			}

			if (ModelScale != 0F)
			{
				size += 1 + 4;
			}

			if (Type != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Type);
			}

			if (Type2 != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Type2);
			}

			if (camera_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Camera);
			}

			if (encounter_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Encounter);
			}

			if (stats_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stats);
			}

			size += quickMoves_.CalculateSize(_repeated_quickMoves_codec);
			size += cinematicMoves_.CalculateSize(_repeated_cinematicMoves_codec);
			size += animationTime_.CalculateSize(_repeated_animationTime_codec);
			size += evolutionIds_.CalculateSize(_repeated_evolutionIds_codec);
			if (EvolutionPips != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionPips);
			}

			if (Rarity != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Rarity);
			}

			if (PokedexHeightM != 0F)
			{
				size += 1 + 4;
			}

			if (PokedexWeightKg != 0F)
			{
				size += 2 + 4;
			}

			if (ParentPokemonId != 0)
			{
				size += 2 + pb::CodedOutputStream.ComputeEnumSize((int)ParentPokemonId);
			}

			if (HeightStdDev != 0F)
			{
				size += 2 + 4;
			}

			if (WeightStdDev != 0F)
			{
				size += 2 + 4;
			}

			if (KmDistanceToHatch != 0F)
			{
				size += 2 + 4;
			}

			if (FamilyId != 0)
			{
				size += 2 + pb::CodedOutputStream.ComputeEnumSize((int)FamilyId);
			}

			if (CandyToEvolve != 0)
			{
				size += 2 + pb::CodedOutputStream.ComputeInt32Size(CandyToEvolve);
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
		public void MergeFrom(PokemonSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.PokemonId != 0)
			{
				PokemonId = other.PokemonId;
			}

			if (other.ModelScale != 0F)
			{
				ModelScale = other.ModelScale;
			}

			if (other.Type != 0)
			{
				Type = other.Type;
			}

			if (other.Type2 != 0)
			{
				Type2 = other.Type2;
			}

			if (other.camera_ != null)
			{
				if (camera_ == null)
				{
					camera_ = new global::POGOProtos.Settings.Master.Pokemon.CameraAttributes();
				}

				Camera.MergeFrom(other.Camera);
			}

			if (other.encounter_ != null)
			{
				if (encounter_ == null)
				{
					encounter_ = new global::POGOProtos.Settings.Master.Pokemon.EncounterAttributes();
				}

				Encounter.MergeFrom(other.Encounter);
			}

			if (other.stats_ != null)
			{
				if (stats_ == null)
				{
					stats_ = new global::POGOProtos.Settings.Master.Pokemon.StatsAttributes();
				}

				Stats.MergeFrom(other.Stats);
			}

			quickMoves_.Add(other.quickMoves_);
			cinematicMoves_.Add(other.cinematicMoves_);
			animationTime_.Add(other.animationTime_);
			evolutionIds_.Add(other.evolutionIds_);
			if (other.EvolutionPips != 0)
			{
				EvolutionPips = other.EvolutionPips;
			}

			if (other.Rarity != 0)
			{
				Rarity = other.Rarity;
			}

			if (other.PokedexHeightM != 0F)
			{
				PokedexHeightM = other.PokedexHeightM;
			}

			if (other.PokedexWeightKg != 0F)
			{
				PokedexWeightKg = other.PokedexWeightKg;
			}

			if (other.ParentPokemonId != 0)
			{
				ParentPokemonId = other.ParentPokemonId;
			}

			if (other.HeightStdDev != 0F)
			{
				HeightStdDev = other.HeightStdDev;
			}

			if (other.WeightStdDev != 0F)
			{
				WeightStdDev = other.WeightStdDev;
			}

			if (other.KmDistanceToHatch != 0F)
			{
				KmDistanceToHatch = other.KmDistanceToHatch;
			}

			if (other.FamilyId != 0)
			{
				FamilyId = other.FamilyId;
			}

			if (other.CandyToEvolve != 0)
			{
				CandyToEvolve = other.CandyToEvolve;
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
						pokemonId_ = (global::POGOProtos.Enums.PokemonId)input.ReadEnum();
						break;
					}

					case 29:
					{
						ModelScale = input.ReadFloat();
						break;
					}

					case 32:
					{
						type_ = (global::POGOProtos.Enums.PokemonType)input.ReadEnum();
						break;
					}

					case 40:
					{
						type2_ = (global::POGOProtos.Enums.PokemonType)input.ReadEnum();
						break;
					}

					case 50:
					{
						if (camera_ == null)
						{
							camera_ = new global::POGOProtos.Settings.Master.Pokemon.CameraAttributes();
						}

						input.ReadMessage(camera_);
						break;
					}

					case 58:
					{
						if (encounter_ == null)
						{
							encounter_ = new global::POGOProtos.Settings.Master.Pokemon.EncounterAttributes();
						}

						input.ReadMessage(encounter_);
						break;
					}

					case 66:
					{
						if (stats_ == null)
						{
							stats_ = new global::POGOProtos.Settings.Master.Pokemon.StatsAttributes();
						}

						input.ReadMessage(stats_);
						break;
					}

					case 74:
					case 72:
					{
						quickMoves_.AddEntriesFrom(input, _repeated_quickMoves_codec);
						break;
					}

					case 82:
					case 80:
					{
						cinematicMoves_.AddEntriesFrom(input, _repeated_cinematicMoves_codec);
						break;
					}

					case 90:
					case 93:
					{
						animationTime_.AddEntriesFrom(input, _repeated_animationTime_codec);
						break;
					}

					case 98:
					case 96:
					{
						evolutionIds_.AddEntriesFrom(input, _repeated_evolutionIds_codec);
						break;
					}

					case 104:
					{
						EvolutionPips = input.ReadInt32();
						break;
					}

					case 112:
					{
						rarity_ = (global::POGOProtos.Enums.PokemonRarity)input.ReadEnum();
						break;
					}

					case 125:
					{
						PokedexHeightM = input.ReadFloat();
						break;
					}

					case 133:
					{
						PokedexWeightKg = input.ReadFloat();
						break;
					}

					case 136:
					{
						parentPokemonId_ = (global::POGOProtos.Enums.PokemonId)input.ReadEnum();
						break;
					}

					case 149:
					{
						HeightStdDev = input.ReadFloat();
						break;
					}

					case 157:
					{
						WeightStdDev = input.ReadFloat();
						break;
					}

					case 165:
					{
						KmDistanceToHatch = input.ReadFloat();
						break;
					}

					case 168:
					{
						familyId_ = (global::POGOProtos.Enums.PokemonFamilyId)input.ReadEnum();
						break;
					}

					case 176:
					{
						CandyToEvolve = input.ReadInt32();
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
			return Equals(other as PokemonSettings);
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
			if (PokemonId != 0)
			{
				hash ^= PokemonId.GetHashCode();
			}

			if (ModelScale != 0F)
			{
				hash ^= ModelScale.GetHashCode();
			}

			if (Type != 0)
			{
				hash ^= Type.GetHashCode();
			}

			if (Type2 != 0)
			{
				hash ^= Type2.GetHashCode();
			}

			if (camera_ != null)
			{
				hash ^= Camera.GetHashCode();
			}

			if (encounter_ != null)
			{
				hash ^= Encounter.GetHashCode();
			}

			if (stats_ != null)
			{
				hash ^= Stats.GetHashCode();
			}

			hash ^= quickMoves_.GetHashCode();
			hash ^= cinematicMoves_.GetHashCode();
			hash ^= animationTime_.GetHashCode();
			hash ^= evolutionIds_.GetHashCode();
			if (EvolutionPips != 0)
			{
				hash ^= EvolutionPips.GetHashCode();
			}

			if (Rarity != 0)
			{
				hash ^= Rarity.GetHashCode();
			}

			if (PokedexHeightM != 0F)
			{
				hash ^= PokedexHeightM.GetHashCode();
			}

			if (PokedexWeightKg != 0F)
			{
				hash ^= PokedexWeightKg.GetHashCode();
			}

			if (ParentPokemonId != 0)
			{
				hash ^= ParentPokemonId.GetHashCode();
			}

			if (HeightStdDev != 0F)
			{
				hash ^= HeightStdDev.GetHashCode();
			}

			if (WeightStdDev != 0F)
			{
				hash ^= WeightStdDev.GetHashCode();
			}

			if (KmDistanceToHatch != 0F)
			{
				hash ^= KmDistanceToHatch.GetHashCode();
			}

			if (FamilyId != 0)
			{
				hash ^= FamilyId.GetHashCode();
			}

			if (CandyToEvolve != 0)
			{
				hash ^= CandyToEvolve.GetHashCode();
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