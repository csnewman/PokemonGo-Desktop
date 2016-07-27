// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BadgeType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/BadgeType.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/BadgeType.proto</summary>
	public static partial class BadgeTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/BadgeType.proto</summary>
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
		/// Initializes static members of the <see cref="BadgeTypeReflection"/> class.
		/// </summary>
		static BadgeTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiBQT0dPUHJvdG9zL0VudW1zL0JhZGdlVHlwZS5wcm90bxIQUE9HT1Byb3Rv",
						"cy5FbnVtcyqhBwoJQmFkZ2VUeXBlEg8KC0JBREdFX1VOU0VUEAASEwoPQkFE",
						"R0VfVFJBVkVMX0tNEAESGQoVQkFER0VfUE9LRURFWF9FTlRSSUVTEAISFwoT",
						"QkFER0VfQ0FQVFVSRV9UT1RBTBADEhcKE0JBREdFX0RFRkVBVEVEX0ZPUlQQ",
						"BBIXChNCQURHRV9FVk9MVkVEX1RPVEFMEAUSFwoTQkFER0VfSEFUQ0hFRF9U",
						"T1RBTBAGEhsKF0JBREdFX0VOQ09VTlRFUkVEX1RPVEFMEAcSGwoXQkFER0Vf",
						"UE9LRVNUT1BTX1ZJU0lURUQQCBIaChZCQURHRV9VTklRVUVfUE9LRVNUT1BT",
						"EAkSGQoVQkFER0VfUE9LRUJBTExfVEhST1dOEAoSFgoSQkFER0VfQklHX01B",
						"R0lLQVJQEAsSGAoUQkFER0VfREVQTE9ZRURfVE9UQUwQDBIbChdCQURHRV9C",
						"QVRUTEVfQVRUQUNLX1dPThANEh0KGUJBREdFX0JBVFRMRV9UUkFJTklOR19X",
						"T04QDhIbChdCQURHRV9CQVRUTEVfREVGRU5EX1dPThAPEhkKFUJBREdFX1BS",
						"RVNUSUdFX1JBSVNFRBAQEhoKFkJBREdFX1BSRVNUSUdFX0RST1BQRUQQERIV",
						"ChFCQURHRV9UWVBFX05PUk1BTBASEhcKE0JBREdFX1RZUEVfRklHSFRJTkcQ",
						"ExIVChFCQURHRV9UWVBFX0ZMWUlORxAUEhUKEUJBREdFX1RZUEVfUE9JU09O",
						"EBUSFQoRQkFER0VfVFlQRV9HUk9VTkQQFhITCg9CQURHRV9UWVBFX1JPQ0sQ",
						"FxISCg5CQURHRV9UWVBFX0JVRxAYEhQKEEJBREdFX1RZUEVfR0hPU1QQGRIU",
						"ChBCQURHRV9UWVBFX1NURUVMEBoSEwoPQkFER0VfVFlQRV9GSVJFEBsSFAoQ",
						"QkFER0VfVFlQRV9XQVRFUhAcEhQKEEJBREdFX1RZUEVfR1JBU1MQHRIXChNC",
						"QURHRV9UWVBFX0VMRUNUUklDEB4SFgoSQkFER0VfVFlQRV9QU1lDSElDEB8S",
						"EgoOQkFER0VfVFlQRV9JQ0UQIBIVChFCQURHRV9UWVBFX0RSQUdPThAhEhMK",
						"D0JBREdFX1RZUEVfREFSSxAiEhQKEEJBREdFX1RZUEVfRkFJUlkQIxIXChNC",
						"QURHRV9TTUFMTF9SQVRUQVRBECQSEQoNQkFER0VfUElLQUNIVRAlYgZwcm90",
						"bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.BadgeType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The badge type.
	/// </summary>
	public enum BadgeType
	{
		/// <summary>
		/// The badge unset.
		/// </summary>
		[pbr::OriginalName("BADGE_UNSET")] BadgeUnset = 0,

		/// <summary>
		/// The badge travel km.
		/// </summary>
		[pbr::OriginalName("BADGE_TRAVEL_KM")] BadgeTravelKm = 1,

		/// <summary>
		/// The badge pokedex entries.
		/// </summary>
		[pbr::OriginalName("BADGE_POKEDEX_ENTRIES")] BadgePokedexEntries = 2,

		/// <summary>
		/// The badge capture total.
		/// </summary>
		[pbr::OriginalName("BADGE_CAPTURE_TOTAL")] BadgeCaptureTotal = 3,

		/// <summary>
		/// The badge defeated fort.
		/// </summary>
		[pbr::OriginalName("BADGE_DEFEATED_FORT")] BadgeDefeatedFort = 4,

		/// <summary>
		/// The badge evolved total.
		/// </summary>
		[pbr::OriginalName("BADGE_EVOLVED_TOTAL")] BadgeEvolvedTotal = 5,

		/// <summary>
		/// The badge hatched total.
		/// </summary>
		[pbr::OriginalName("BADGE_HATCHED_TOTAL")] BadgeHatchedTotal = 6,

		/// <summary>
		/// The badge encountered total.
		/// </summary>
		[pbr::OriginalName("BADGE_ENCOUNTERED_TOTAL")] BadgeEncounteredTotal = 7,

		/// <summary>
		/// The badge pokestops visited.
		/// </summary>
		[pbr::OriginalName("BADGE_POKESTOPS_VISITED")] BadgePokestopsVisited = 8,

		/// <summary>
		/// The badge unique pokestops.
		/// </summary>
		[pbr::OriginalName("BADGE_UNIQUE_POKESTOPS")] BadgeUniquePokestops = 9,

		/// <summary>
		/// The badge pokeball thrown.
		/// </summary>
		[pbr::OriginalName("BADGE_POKEBALL_THROWN")] BadgePokeballThrown = 10,

		/// <summary>
		/// The badge big magikarp.
		/// </summary>
		[pbr::OriginalName("BADGE_BIG_MAGIKARP")] BadgeBigMagikarp = 11,

		/// <summary>
		/// The badge deployed total.
		/// </summary>
		[pbr::OriginalName("BADGE_DEPLOYED_TOTAL")] BadgeDeployedTotal = 12,

		/// <summary>
		/// The badge battle attack won.
		/// </summary>
		[pbr::OriginalName("BADGE_BATTLE_ATTACK_WON")] BadgeBattleAttackWon = 13,

		/// <summary>
		/// The badge battle training won.
		/// </summary>
		[pbr::OriginalName("BADGE_BATTLE_TRAINING_WON")] BadgeBattleTrainingWon = 14,

		/// <summary>
		/// The badge battle defend won.
		/// </summary>
		[pbr::OriginalName("BADGE_BATTLE_DEFEND_WON")] BadgeBattleDefendWon = 15,

		/// <summary>
		/// The badge prestige raised.
		/// </summary>
		[pbr::OriginalName("BADGE_PRESTIGE_RAISED")] BadgePrestigeRaised = 16,

		/// <summary>
		/// The badge prestige dropped.
		/// </summary>
		[pbr::OriginalName("BADGE_PRESTIGE_DROPPED")] BadgePrestigeDropped = 17,

		/// <summary>
		/// The normal.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_NORMAL")] Normal = 18,

		/// <summary>
		/// The fighting.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_FIGHTING")] Fighting = 19,

		/// <summary>
		/// The flying.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_FLYING")] Flying = 20,

		/// <summary>
		/// The poison.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_POISON")] Poison = 21,

		/// <summary>
		/// The ground.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_GROUND")] Ground = 22,

		/// <summary>
		/// The rock.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_ROCK")] Rock = 23,

		/// <summary>
		/// The bug.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_BUG")] Bug = 24,

		/// <summary>
		/// The ghost.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_GHOST")] Ghost = 25,

		/// <summary>
		/// The steel.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_STEEL")] Steel = 26,

		/// <summary>
		/// The fire.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_FIRE")] Fire = 27,

		/// <summary>
		/// The water.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_WATER")] Water = 28,

		/// <summary>
		/// The grass.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_GRASS")] Grass = 29,

		/// <summary>
		/// The electric.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_ELECTRIC")] Electric = 30,

		/// <summary>
		/// The psychic.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_PSYCHIC")] Psychic = 31,

		/// <summary>
		/// The ice.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_ICE")] Ice = 32,

		/// <summary>
		/// The dragon.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_DRAGON")] Dragon = 33,

		/// <summary>
		/// The dark.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_DARK")] Dark = 34,

		/// <summary>
		/// The fairy.
		/// </summary>
		[pbr::OriginalName("BADGE_TYPE_FAIRY")] Fairy = 35,

		/// <summary>
		/// The badge small rattata.
		/// </summary>
		[pbr::OriginalName("BADGE_SMALL_RATTATA")] BadgeSmallRattata = 36,

		/// <summary>
		/// The badge pikachu.
		/// </summary>
		[pbr::OriginalName("BADGE_PIKACHU")] BadgePikachu = 37,
	}

	#endregion
}

#endregion Designer generated code