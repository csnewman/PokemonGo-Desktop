// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActivityType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/ActivityType.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Enums
{
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/ActivityType.proto</summary>
	public static partial class ActivityTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/ActivityType.proto</summary>
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
		/// Initializes static members of the <see cref="ActivityTypeReflection"/> class.
		/// </summary>
		static ActivityTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiNQT0dPUHJvdG9zL0VudW1zL0FjdGl2aXR5VHlwZS5wcm90bxIQUE9HT1By",
						"b3Rvcy5FbnVtcyrsBQoMQWN0aXZpdHlUeXBlEhQKEEFDVElWSVRZX1VOS05P",
						"V04QABIaChZBQ1RJVklUWV9DQVRDSF9QT0tFTU9OEAESIQodQUNUSVZJVFlf",
						"Q0FUQ0hfTEVHRU5EX1BPS0VNT04QAhIZChVBQ1RJVklUWV9GTEVFX1BPS0VN",
						"T04QAxIYChRBQ1RJVklUWV9ERUZFQVRfRk9SVBAEEhsKF0FDVElWSVRZX0VW",
						"T0xWRV9QT0tFTU9OEAUSFgoSQUNUSVZJVFlfSEFUQ0hfRUdHEAYSFAoQQUNU",
						"SVZJVFlfV0FMS19LTRAHEh4KGkFDVElWSVRZX1BPS0VERVhfRU5UUllfTkVX",
						"EAgSHgoaQUNUSVZJVFlfQ0FUQ0hfRklSU1RfVEhST1cQCRIdChlBQ1RJVklU",
						"WV9DQVRDSF9OSUNFX1RIUk9XEAoSHgoaQUNUSVZJVFlfQ0FUQ0hfR1JFQVRf",
						"VEhST1cQCxIiCh5BQ1RJVklUWV9DQVRDSF9FWENFTExFTlRfVEhST1cQDBIc",
						"ChhBQ1RJVklUWV9DQVRDSF9DVVJWRUJBTEwQDRIlCiFBQ1RJVklUWV9DQVRD",
						"SF9GSVJTVF9DQVRDSF9PRl9EQVkQDhIcChhBQ1RJVklUWV9DQVRDSF9NSUxF",
						"U1RPTkUQDxIaChZBQ1RJVklUWV9UUkFJTl9QT0tFTU9OEBASGAoUQUNUSVZJ",
						"VFlfU0VBUkNIX0ZPUlQQERIcChhBQ1RJVklUWV9SRUxFQVNFX1BPS0VNT04Q",
						"EhIiCh5BQ1RJVklUWV9IQVRDSF9FR0dfU01BTExfQk9OVVMQExIjCh9BQ1RJ",
						"VklUWV9IQVRDSF9FR0dfTUVESVVNX0JPTlVTEBQSIgoeQUNUSVZJVFlfSEFU",
						"Q0hfRUdHX0xBUkdFX0JPTlVTEBUSIAocQUNUSVZJVFlfREVGRUFUX0dZTV9E",
						"RUZFTkRFUhAWEh4KGkFDVElWSVRZX0RFRkVBVF9HWU1fTEVBREVSEBdiBnBy",
						"b3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.ActivityType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The activity type.
	/// </summary>
	public enum ActivityType
	{
		/// <summary>
		/// The activity unknown.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_UNKNOWN")] ActivityUnknown = 0,

		/// <summary>
		/// The activity catch pokemon.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_CATCH_POKEMON")] ActivityCatchPokemon = 1,

		/// <summary>
		/// The activity catch legend pokemon.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_CATCH_LEGEND_POKEMON")] ActivityCatchLegendPokemon = 2,

		/// <summary>
		/// The activity flee pokemon.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_FLEE_POKEMON")] ActivityFleePokemon = 3,

		/// <summary>
		/// The activity defeat fort.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_DEFEAT_FORT")] ActivityDefeatFort = 4,

		/// <summary>
		/// The activity evolve pokemon.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_EVOLVE_POKEMON")] ActivityEvolvePokemon = 5,

		/// <summary>
		/// The activity hatch egg.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_HATCH_EGG")] ActivityHatchEgg = 6,

		/// <summary>
		/// The activity walk km.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_WALK_KM")] ActivityWalkKm = 7,

		/// <summary>
		/// The activity pokedex entry new.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_POKEDEX_ENTRY_NEW")] ActivityPokedexEntryNew = 8,

		/// <summary>
		/// The activity catch first throw.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_CATCH_FIRST_THROW")] ActivityCatchFirstThrow = 9,

		/// <summary>
		/// The activity catch nice throw.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_CATCH_NICE_THROW")] ActivityCatchNiceThrow = 10,

		/// <summary>
		/// The activity catch great throw.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_CATCH_GREAT_THROW")] ActivityCatchGreatThrow = 11,

		/// <summary>
		/// The activity catch excellent throw.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_CATCH_EXCELLENT_THROW")] ActivityCatchExcellentThrow = 12,

		/// <summary>
		/// The activity catch curveball.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_CATCH_CURVEBALL")] ActivityCatchCurveball = 13,

		/// <summary>
		/// The activity catch first catch of day.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_CATCH_FIRST_CATCH_OF_DAY")] ActivityCatchFirstCatchOfDay = 14,

		/// <summary>
		/// The activity catch milestone.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_CATCH_MILESTONE")] ActivityCatchMilestone = 15,

		/// <summary>
		/// The activity train pokemon.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_TRAIN_POKEMON")] ActivityTrainPokemon = 16,

		/// <summary>
		/// The activity search fort.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_SEARCH_FORT")] ActivitySearchFort = 17,

		/// <summary>
		/// The activity release pokemon.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_RELEASE_POKEMON")] ActivityReleasePokemon = 18,

		/// <summary>
		/// The activity hatch egg small bonus.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_HATCH_EGG_SMALL_BONUS")] ActivityHatchEggSmallBonus = 19,

		/// <summary>
		/// The activity hatch egg medium bonus.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_HATCH_EGG_MEDIUM_BONUS")] ActivityHatchEggMediumBonus = 20,

		/// <summary>
		/// The activity hatch egg large bonus.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_HATCH_EGG_LARGE_BONUS")] ActivityHatchEggLargeBonus = 21,

		/// <summary>
		/// The activity defeat gym defender.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_DEFEAT_GYM_DEFENDER")] ActivityDefeatGymDefender = 22,

		/// <summary>
		/// The activity defeat gym leader.
		/// </summary>
		[pbr::OriginalName("ACTIVITY_DEFEAT_GYM_LEADER")] ActivityDefeatGymLeader = 23,
	}

	#endregion
}

#endregion Designer generated code