// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokemonMove.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/PokemonMove.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/PokemonMove.proto</summary>
	public static partial class PokemonMoveReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/PokemonMove.proto</summary>
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
		/// Initializes static members of the <see cref="PokemonMoveReflection"/> class.
		/// </summary>
		static PokemonMoveReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiJQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25Nb3ZlLnByb3RvEhBQT0dPUHJv",
						"dG9zLkVudW1zKs4XCgtQb2tlbW9uTW92ZRIOCgpNT1ZFX1VOU0VUEAASEQoN",
						"VEhVTkRFUl9TSE9DSxABEhAKDFFVSUNLX0FUVEFDSxACEgsKB1NDUkFUQ0gQ",
						"AxIJCgVFTUJFUhAEEg0KCVZJTkVfV0hJUBAFEgoKBlRBQ0tMRRAGEg4KClJB",
						"Wk9SX0xFQUYQBxINCglUQUtFX0RPV04QCBINCglXQVRFUl9HVU4QCRIICgRC",
						"SVRFEAoSCQoFUE9VTkQQCxIPCgtET1VCTEVfU0xBUBAMEggKBFdSQVAQDRIO",
						"CgpIWVBFUl9CRUFNEA4SCAoETElDSxAPEg4KCkRBUktfUFVMU0UQEBIICgRT",
						"TU9HEBESCgoGU0xVREdFEBISDgoKTUVUQUxfQ0xBVxATEg0KCVZJQ0VfR1JJ",
						"UBAUEg8KC0ZMQU1FX1dIRUVMEBUSDAoITUVHQUhPUk4QFhIPCgtXSU5HX0FU",
						"VEFDSxAXEhAKDEZMQU1FVEhST1dFUhAYEhAKDFNVQ0tFUl9QVU5DSBAZEgcK",
						"A0RJRxAaEgwKCExPV19LSUNLEBsSDgoKQ1JPU1NfQ0hPUBAcEg4KClBTWUNI",
						"T19DVVQQHRILCgdQU1lCRUFNEB4SDgoKRUFSVEhRVUFLRRAfEg4KClNUT05F",
						"X0VER0UQIBINCglJQ0VfUFVOQ0gQIRIPCgtIRUFSVF9TVEFNUBAiEg0KCURJ",
						"U0NIQVJHRRAjEhAKDEZMQVNIX0NBTk5PThAkEggKBFBFQ0sQJRIOCgpEUklM",
						"TF9QRUNLECYSDAoISUNFX0JFQU0QJxIMCghCTElaWkFSRBAoEg0KCUFJUl9T",
						"TEFTSBApEg0KCUhFQVRfV0FWRRAqEg0KCVRXSU5FRURMRRArEg4KClBPSVNP",
						"Tl9KQUIQLBIOCgpBRVJJQUxfQUNFEC0SDQoJRFJJTExfUlVOEC4SEgoOUEVU",
						"QUxfQkxJWlpBUkQQLxIOCgpNRUdBX0RSQUlOEDASDAoIQlVHX0JVWloQMRIP",
						"CgtQT0lTT05fRkFORxAyEg8KC05JR0hUX1NMQVNIEDMSCQoFU0xBU0gQNBIP",
						"CgtCVUJCTEVfQkVBTRA1Eg4KClNVQk1JU1NJT04QNhIPCgtLQVJBVEVfQ0hP",
						"UBA3Eg0KCUxPV19TV0VFUBA4EgwKCEFRVUFfSkVUEDkSDQoJQVFVQV9UQUlM",
						"EDoSDQoJU0VFRF9CT01CEDsSDAoIUFNZU0hPQ0sQPBIOCgpST0NLX1RIUk9X",
						"ED0SEQoNQU5DSUVOVF9QT1dFUhA+Eg0KCVJPQ0tfVE9NQhA/Eg4KClJPQ0tf",
						"U0xJREUQQBINCglQT1dFUl9HRU0QQRIQCgxTSEFET1dfU05FQUsQQhIQCgxT",
						"SEFET1dfUFVOQ0gQQxIPCgtTSEFET1dfQ0xBVxBEEhAKDE9NSU5PVVNfV0lO",
						"RBBFEg8KC1NIQURPV19CQUxMEEYSEAoMQlVMTEVUX1BVTkNIEEcSDwoLTUFH",
						"TkVUX0JPTUIQSBIOCgpTVEVFTF9XSU5HEEkSDQoJSVJPTl9IRUFEEEoSFAoQ",
						"UEFSQUJPTElDX0NIQVJHRRBLEgkKBVNQQVJLEEwSEQoNVEhVTkRFUl9QVU5D",
						"SBBNEgsKB1RIVU5ERVIQThIPCgtUSFVOREVSQk9MVBBPEgsKB1RXSVNURVIQ",
						"UBIRCg1EUkFHT05fQlJFQVRIEFESEAoMRFJBR09OX1BVTFNFEFISDwoLRFJB",
						"R09OX0NMQVcQUxITCg9ESVNBUk1JTkdfVk9JQ0UQVBIRCg1EUkFJTklOR19L",
						"SVNTEFUSEgoOREFaWkxJTkdfR0xFQU0QVhINCglNT09OQkxBU1QQVxIOCgpQ",
						"TEFZX1JPVUdIEFgSEAoMQ1JPU1NfUE9JU09OEFkSDwoLU0xVREdFX0JPTUIQ",
						"WhIPCgtTTFVER0VfV0FWRRBbEg0KCUdVTktfU0hPVBBcEgwKCE1VRF9TSE9U",
						"EF0SDQoJQk9ORV9DTFVCEF4SDAoIQlVMTERPWkUQXxIMCghNVURfQk9NQhBg",
						"Eg8KC0ZVUllfQ1VUVEVSEGESDAoIQlVHX0JJVEUQYhIPCgtTSUdOQUxfQkVB",
						"TRBjEg0KCVhfU0NJU1NPUhBkEhAKDEZMQU1FX0NIQVJHRRBlEg8KC0ZMQU1F",
						"X0JVUlNUEGYSDgoKRklSRV9CTEFTVBBnEgkKBUJSSU5FEGgSDwoLV0FURVJf",
						"UFVMU0UQaRIJCgVTQ0FMRBBqEg4KCkhZRFJPX1BVTVAQaxILCgdQU1lDSElD",
						"EGwSDQoJUFNZU1RSSUtFEG0SDQoJSUNFX1NIQVJEEG4SDAoISUNZX1dJTkQQ",
						"bxIQCgxGUk9TVF9CUkVBVEgQcBIKCgZBQlNPUkIQcRIOCgpHSUdBX0RSQUlO",
						"EHISDgoKRklSRV9QVU5DSBBzEg4KClNPTEFSX0JFQU0QdBIOCgpMRUFGX0JM",
						"QURFEHUSDgoKUE9XRVJfV0hJUBB2EgoKBlNQTEFTSBB3EggKBEFDSUQQeBIO",
						"CgpBSVJfQ1VUVEVSEHkSDQoJSFVSUklDQU5FEHoSDwoLQlJJQ0tfQlJFQUsQ",
						"exIHCgNDVVQQfBIJCgVTV0lGVBB9Eg8KC0hPUk5fQVRUQUNLEH4SCQoFU1RP",
						"TVAQfxINCghIRUFEQlVUVBCAARIPCgpIWVBFUl9GQU5HEIEBEgkKBFNMQU0Q",
						"ggESDgoJQk9EWV9TTEFNEIMBEgkKBFJFU1QQhAESDQoIU1RSVUdHTEUQhQES",
						"FAoPU0NBTERfQkxBU1RPSVNFEIYBEhkKFEhZRFJPX1BVTVBfQkxBU1RPSVNF",
						"EIcBEg8KCldSQVBfR1JFRU4QiAESDgoJV1JBUF9QSU5LEIkBEhUKEEZVUllf",
						"Q1VUVEVSX0ZBU1QQyAESEgoNQlVHX0JJVEVfRkFTVBDJARIOCglCSVRFX0ZB",
						"U1QQygESFgoRU1VDS0VSX1BVTkNIX0ZBU1QQywESFwoSRFJBR09OX0JSRUFU",
						"SF9GQVNUEMwBEhcKElRIVU5ERVJfU0hPQ0tfRkFTVBDNARIPCgpTUEFSS19G",
						"QVNUEM4BEhIKDUxPV19LSUNLX0ZBU1QQzwESFQoQS0FSQVRFX0NIT1BfRkFT",
						"VBDQARIPCgpFTUJFUl9GQVNUENEBEhUKEFdJTkdfQVRUQUNLX0ZBU1QQ0gES",
						"DgoJUEVDS19GQVNUENMBEg4KCUxJQ0tfRkFTVBDUARIVChBTSEFET1dfQ0xB",
						"V19GQVNUENUBEhMKDlZJTkVfV0hJUF9GQVNUENYBEhQKD1JBWk9SX0xFQUZf",
						"RkFTVBDXARISCg1NVURfU0hPVF9GQVNUENgBEhMKDklDRV9TSEFSRF9GQVNU",
						"ENkBEhYKEUZST1NUX0JSRUFUSF9GQVNUENoBEhYKEVFVSUNLX0FUVEFDS19G",
						"QVNUENsBEhEKDFNDUkFUQ0hfRkFTVBDcARIQCgtUQUNLTEVfRkFTVBDdARIP",
						"CgpQT1VORF9GQVNUEN4BEg0KCENVVF9GQVNUEN8BEhQKD1BPSVNPTl9KQUJf",
						"RkFTVBDgARIOCglBQ0lEX0ZBU1QQ4QESFAoPUFNZQ0hPX0NVVF9GQVNUEOIB",
						"EhQKD1JPQ0tfVEhST1dfRkFTVBDjARIUCg9NRVRBTF9DTEFXX0ZBU1QQ5AES",
						"FgoRQlVMTEVUX1BVTkNIX0ZBU1QQ5QESEwoOV0FURVJfR1VOX0ZBU1QQ5gES",
						"EAoLU1BMQVNIX0ZBU1QQ5wESHQoYV0FURVJfR1VOX0ZBU1RfQkxBU1RPSVNF",
						"EOgBEhIKDU1VRF9TTEFQX0ZBU1QQ6QESFgoRWkVOX0hFQURCVVRUX0ZBU1QQ",
						"6gESEwoOQ09ORlVTSU9OX0ZBU1QQ6wESFgoRUE9JU09OX1NUSU5HX0ZBU1QQ",
						"7AESEAoLQlVCQkxFX0ZBU1QQ7QESFgoRRkVJTlRfQVRUQUNLX0ZBU1QQ7gES",
						"FAoPU1RFRUxfV0lOR19GQVNUEO8BEhMKDkZJUkVfRkFOR19GQVNUEPABEhQK",
						"D1JPQ0tfU01BU0hfRkFTVBDxAWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.PokemonMove), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The pokemon move.
	/// </summary>
	public enum PokemonMove
	{
		/// <summary>
		/// The move unset.
		/// </summary>
		[pbr::OriginalName("MOVE_UNSET")] MoveUnset = 0,

		/// <summary>
		/// The thunder shock.
		/// </summary>
		[pbr::OriginalName("THUNDER_SHOCK")] ThunderShock = 1,

		/// <summary>
		/// The quick attack.
		/// </summary>
		[pbr::OriginalName("QUICK_ATTACK")] QuickAttack = 2,

		/// <summary>
		/// The scratch.
		/// </summary>
		[pbr::OriginalName("SCRATCH")] Scratch = 3,

		/// <summary>
		/// The ember.
		/// </summary>
		[pbr::OriginalName("EMBER")] Ember = 4,

		/// <summary>
		/// The vine whip.
		/// </summary>
		[pbr::OriginalName("VINE_WHIP")] VineWhip = 5,

		/// <summary>
		/// The tackle.
		/// </summary>
		[pbr::OriginalName("TACKLE")] Tackle = 6,

		/// <summary>
		/// The razor leaf.
		/// </summary>
		[pbr::OriginalName("RAZOR_LEAF")] RazorLeaf = 7,

		/// <summary>
		/// The take down.
		/// </summary>
		[pbr::OriginalName("TAKE_DOWN")] TakeDown = 8,

		/// <summary>
		/// The water gun.
		/// </summary>
		[pbr::OriginalName("WATER_GUN")] WaterGun = 9,

		/// <summary>
		/// The bite.
		/// </summary>
		[pbr::OriginalName("BITE")] Bite = 10,

		/// <summary>
		/// The pound.
		/// </summary>
		[pbr::OriginalName("POUND")] Pound = 11,

		/// <summary>
		/// The double slap.
		/// </summary>
		[pbr::OriginalName("DOUBLE_SLAP")] DoubleSlap = 12,

		/// <summary>
		/// The wrap.
		/// </summary>
		[pbr::OriginalName("WRAP")] Wrap = 13,

		/// <summary>
		/// The hyper beam.
		/// </summary>
		[pbr::OriginalName("HYPER_BEAM")] HyperBeam = 14,

		/// <summary>
		/// The lick.
		/// </summary>
		[pbr::OriginalName("LICK")] Lick = 15,

		/// <summary>
		/// The dark pulse.
		/// </summary>
		[pbr::OriginalName("DARK_PULSE")] DarkPulse = 16,

		/// <summary>
		/// The smog.
		/// </summary>
		[pbr::OriginalName("SMOG")] Smog = 17,

		/// <summary>
		/// The sludge.
		/// </summary>
		[pbr::OriginalName("SLUDGE")] Sludge = 18,

		/// <summary>
		/// The metal claw.
		/// </summary>
		[pbr::OriginalName("METAL_CLAW")] MetalClaw = 19,

		/// <summary>
		/// The vice grip.
		/// </summary>
		[pbr::OriginalName("VICE_GRIP")] ViceGrip = 20,

		/// <summary>
		/// The flame wheel.
		/// </summary>
		[pbr::OriginalName("FLAME_WHEEL")] FlameWheel = 21,

		/// <summary>
		/// The megahorn.
		/// </summary>
		[pbr::OriginalName("MEGAHORN")] Megahorn = 22,

		/// <summary>
		/// The wing attack.
		/// </summary>
		[pbr::OriginalName("WING_ATTACK")] WingAttack = 23,

		/// <summary>
		/// The flamethrower.
		/// </summary>
		[pbr::OriginalName("FLAMETHROWER")] Flamethrower = 24,

		/// <summary>
		/// The sucker punch.
		/// </summary>
		[pbr::OriginalName("SUCKER_PUNCH")] SuckerPunch = 25,

		/// <summary>
		/// The dig.
		/// </summary>
		[pbr::OriginalName("DIG")] Dig = 26,

		/// <summary>
		/// The low kick.
		/// </summary>
		[pbr::OriginalName("LOW_KICK")] LowKick = 27,

		/// <summary>
		/// The cross chop.
		/// </summary>
		[pbr::OriginalName("CROSS_CHOP")] CrossChop = 28,

		/// <summary>
		/// The psycho cut.
		/// </summary>
		[pbr::OriginalName("PSYCHO_CUT")] PsychoCut = 29,

		/// <summary>
		/// The psybeam.
		/// </summary>
		[pbr::OriginalName("PSYBEAM")] Psybeam = 30,

		/// <summary>
		/// The earthquake.
		/// </summary>
		[pbr::OriginalName("EARTHQUAKE")] Earthquake = 31,

		/// <summary>
		/// The stone edge.
		/// </summary>
		[pbr::OriginalName("STONE_EDGE")] StoneEdge = 32,

		/// <summary>
		/// The ice punch.
		/// </summary>
		[pbr::OriginalName("ICE_PUNCH")] IcePunch = 33,

		/// <summary>
		/// The heart stamp.
		/// </summary>
		[pbr::OriginalName("HEART_STAMP")] HeartStamp = 34,

		/// <summary>
		/// The discharge.
		/// </summary>
		[pbr::OriginalName("DISCHARGE")] Discharge = 35,

		/// <summary>
		/// The flash cannon.
		/// </summary>
		[pbr::OriginalName("FLASH_CANNON")] FlashCannon = 36,

		/// <summary>
		/// The peck.
		/// </summary>
		[pbr::OriginalName("PECK")] Peck = 37,

		/// <summary>
		/// The drill peck.
		/// </summary>
		[pbr::OriginalName("DRILL_PECK")] DrillPeck = 38,

		/// <summary>
		/// The ice beam.
		/// </summary>
		[pbr::OriginalName("ICE_BEAM")] IceBeam = 39,

		/// <summary>
		/// The blizzard.
		/// </summary>
		[pbr::OriginalName("BLIZZARD")] Blizzard = 40,

		/// <summary>
		/// The air slash.
		/// </summary>
		[pbr::OriginalName("AIR_SLASH")] AirSlash = 41,

		/// <summary>
		/// The heat wave.
		/// </summary>
		[pbr::OriginalName("HEAT_WAVE")] HeatWave = 42,

		/// <summary>
		/// The twineedle.
		/// </summary>
		[pbr::OriginalName("TWINEEDLE")] Twineedle = 43,

		/// <summary>
		/// The poison jab.
		/// </summary>
		[pbr::OriginalName("POISON_JAB")] PoisonJab = 44,

		/// <summary>
		/// The aerial ace.
		/// </summary>
		[pbr::OriginalName("AERIAL_ACE")] AerialAce = 45,

		/// <summary>
		/// The drill run.
		/// </summary>
		[pbr::OriginalName("DRILL_RUN")] DrillRun = 46,

		/// <summary>
		/// The petal blizzard.
		/// </summary>
		[pbr::OriginalName("PETAL_BLIZZARD")] PetalBlizzard = 47,

		/// <summary>
		/// The mega drain.
		/// </summary>
		[pbr::OriginalName("MEGA_DRAIN")] MegaDrain = 48,

		/// <summary>
		/// The bug buzz.
		/// </summary>
		[pbr::OriginalName("BUG_BUZZ")] BugBuzz = 49,

		/// <summary>
		/// The poison fang.
		/// </summary>
		[pbr::OriginalName("POISON_FANG")] PoisonFang = 50,

		/// <summary>
		/// The night slash.
		/// </summary>
		[pbr::OriginalName("NIGHT_SLASH")] NightSlash = 51,

		/// <summary>
		/// The slash.
		/// </summary>
		[pbr::OriginalName("SLASH")] Slash = 52,

		/// <summary>
		/// The bubble beam.
		/// </summary>
		[pbr::OriginalName("BUBBLE_BEAM")] BubbleBeam = 53,

		/// <summary>
		/// The submission.
		/// </summary>
		[pbr::OriginalName("SUBMISSION")] Submission = 54,

		/// <summary>
		/// The karate chop.
		/// </summary>
		[pbr::OriginalName("KARATE_CHOP")] KarateChop = 55,

		/// <summary>
		/// The low sweep.
		/// </summary>
		[pbr::OriginalName("LOW_SWEEP")] LowSweep = 56,

		/// <summary>
		/// The aqua jet.
		/// </summary>
		[pbr::OriginalName("AQUA_JET")] AquaJet = 57,

		/// <summary>
		/// The aqua tail.
		/// </summary>
		[pbr::OriginalName("AQUA_TAIL")] AquaTail = 58,

		/// <summary>
		/// The seed bomb.
		/// </summary>
		[pbr::OriginalName("SEED_BOMB")] SeedBomb = 59,

		/// <summary>
		/// The psyshock.
		/// </summary>
		[pbr::OriginalName("PSYSHOCK")] Psyshock = 60,

		/// <summary>
		/// The rock throw.
		/// </summary>
		[pbr::OriginalName("ROCK_THROW")] RockThrow = 61,

		/// <summary>
		/// The ancient power.
		/// </summary>
		[pbr::OriginalName("ANCIENT_POWER")] AncientPower = 62,

		/// <summary>
		/// The rock tomb.
		/// </summary>
		[pbr::OriginalName("ROCK_TOMB")] RockTomb = 63,

		/// <summary>
		/// The rock slide.
		/// </summary>
		[pbr::OriginalName("ROCK_SLIDE")] RockSlide = 64,

		/// <summary>
		/// The power gem.
		/// </summary>
		[pbr::OriginalName("POWER_GEM")] PowerGem = 65,

		/// <summary>
		/// The shadow sneak.
		/// </summary>
		[pbr::OriginalName("SHADOW_SNEAK")] ShadowSneak = 66,

		/// <summary>
		/// The shadow punch.
		/// </summary>
		[pbr::OriginalName("SHADOW_PUNCH")] ShadowPunch = 67,

		/// <summary>
		/// The shadow claw.
		/// </summary>
		[pbr::OriginalName("SHADOW_CLAW")] ShadowClaw = 68,

		/// <summary>
		/// The ominous wind.
		/// </summary>
		[pbr::OriginalName("OMINOUS_WIND")] OminousWind = 69,

		/// <summary>
		/// The shadow ball.
		/// </summary>
		[pbr::OriginalName("SHADOW_BALL")] ShadowBall = 70,

		/// <summary>
		/// The bullet punch.
		/// </summary>
		[pbr::OriginalName("BULLET_PUNCH")] BulletPunch = 71,

		/// <summary>
		/// The magnet bomb.
		/// </summary>
		[pbr::OriginalName("MAGNET_BOMB")] MagnetBomb = 72,

		/// <summary>
		/// The steel wing.
		/// </summary>
		[pbr::OriginalName("STEEL_WING")] SteelWing = 73,

		/// <summary>
		/// The iron head.
		/// </summary>
		[pbr::OriginalName("IRON_HEAD")] IronHead = 74,

		/// <summary>
		/// The parabolic charge.
		/// </summary>
		[pbr::OriginalName("PARABOLIC_CHARGE")] ParabolicCharge = 75,

		/// <summary>
		/// The spark.
		/// </summary>
		[pbr::OriginalName("SPARK")] Spark = 76,

		/// <summary>
		/// The thunder punch.
		/// </summary>
		[pbr::OriginalName("THUNDER_PUNCH")] ThunderPunch = 77,

		/// <summary>
		/// The thunder.
		/// </summary>
		[pbr::OriginalName("THUNDER")] Thunder = 78,

		/// <summary>
		/// The thunderbolt.
		/// </summary>
		[pbr::OriginalName("THUNDERBOLT")] Thunderbolt = 79,

		/// <summary>
		/// The twister.
		/// </summary>
		[pbr::OriginalName("TWISTER")] Twister = 80,

		/// <summary>
		/// The dragon breath.
		/// </summary>
		[pbr::OriginalName("DRAGON_BREATH")] DragonBreath = 81,

		/// <summary>
		/// The dragon pulse.
		/// </summary>
		[pbr::OriginalName("DRAGON_PULSE")] DragonPulse = 82,

		/// <summary>
		/// The dragon claw.
		/// </summary>
		[pbr::OriginalName("DRAGON_CLAW")] DragonClaw = 83,

		/// <summary>
		/// The disarming voice.
		/// </summary>
		[pbr::OriginalName("DISARMING_VOICE")] DisarmingVoice = 84,

		/// <summary>
		/// The draining kiss.
		/// </summary>
		[pbr::OriginalName("DRAINING_KISS")] DrainingKiss = 85,

		/// <summary>
		/// The dazzling gleam.
		/// </summary>
		[pbr::OriginalName("DAZZLING_GLEAM")] DazzlingGleam = 86,

		/// <summary>
		/// The moonblast.
		/// </summary>
		[pbr::OriginalName("MOONBLAST")] Moonblast = 87,

		/// <summary>
		/// The play rough.
		/// </summary>
		[pbr::OriginalName("PLAY_ROUGH")] PlayRough = 88,

		/// <summary>
		/// The cross poison.
		/// </summary>
		[pbr::OriginalName("CROSS_POISON")] CrossPoison = 89,

		/// <summary>
		/// The sludge bomb.
		/// </summary>
		[pbr::OriginalName("SLUDGE_BOMB")] SludgeBomb = 90,

		/// <summary>
		/// The sludge wave.
		/// </summary>
		[pbr::OriginalName("SLUDGE_WAVE")] SludgeWave = 91,

		/// <summary>
		/// The gunk shot.
		/// </summary>
		[pbr::OriginalName("GUNK_SHOT")] GunkShot = 92,

		/// <summary>
		/// The mud shot.
		/// </summary>
		[pbr::OriginalName("MUD_SHOT")] MudShot = 93,

		/// <summary>
		/// The bone club.
		/// </summary>
		[pbr::OriginalName("BONE_CLUB")] BoneClub = 94,

		/// <summary>
		/// The bulldoze.
		/// </summary>
		[pbr::OriginalName("BULLDOZE")] Bulldoze = 95,

		/// <summary>
		/// The mud bomb.
		/// </summary>
		[pbr::OriginalName("MUD_BOMB")] MudBomb = 96,

		/// <summary>
		/// The fury cutter.
		/// </summary>
		[pbr::OriginalName("FURY_CUTTER")] FuryCutter = 97,

		/// <summary>
		/// The bug bite.
		/// </summary>
		[pbr::OriginalName("BUG_BITE")] BugBite = 98,

		/// <summary>
		/// The signal beam.
		/// </summary>
		[pbr::OriginalName("SIGNAL_BEAM")] SignalBeam = 99,

		/// <summary>
		/// The x scissor.
		/// </summary>
		[pbr::OriginalName("X_SCISSOR")] XScissor = 100,

		/// <summary>
		/// The flame charge.
		/// </summary>
		[pbr::OriginalName("FLAME_CHARGE")] FlameCharge = 101,

		/// <summary>
		/// The flame burst.
		/// </summary>
		[pbr::OriginalName("FLAME_BURST")] FlameBurst = 102,

		/// <summary>
		/// The fire blast.
		/// </summary>
		[pbr::OriginalName("FIRE_BLAST")] FireBlast = 103,

		/// <summary>
		/// The brine.
		/// </summary>
		[pbr::OriginalName("BRINE")] Brine = 104,

		/// <summary>
		/// The water pulse.
		/// </summary>
		[pbr::OriginalName("WATER_PULSE")] WaterPulse = 105,

		/// <summary>
		/// The scald.
		/// </summary>
		[pbr::OriginalName("SCALD")] Scald = 106,

		/// <summary>
		/// The hydro pump.
		/// </summary>
		[pbr::OriginalName("HYDRO_PUMP")] HydroPump = 107,

		/// <summary>
		/// The psychic.
		/// </summary>
		[pbr::OriginalName("PSYCHIC")] Psychic = 108,

		/// <summary>
		/// The psystrike.
		/// </summary>
		[pbr::OriginalName("PSYSTRIKE")] Psystrike = 109,

		/// <summary>
		/// The ice shard.
		/// </summary>
		[pbr::OriginalName("ICE_SHARD")] IceShard = 110,

		/// <summary>
		/// The icy wind.
		/// </summary>
		[pbr::OriginalName("ICY_WIND")] IcyWind = 111,

		/// <summary>
		/// The frost breath.
		/// </summary>
		[pbr::OriginalName("FROST_BREATH")] FrostBreath = 112,

		/// <summary>
		/// The absorb.
		/// </summary>
		[pbr::OriginalName("ABSORB")] Absorb = 113,

		/// <summary>
		/// The giga drain.
		/// </summary>
		[pbr::OriginalName("GIGA_DRAIN")] GigaDrain = 114,

		/// <summary>
		/// The fire punch.
		/// </summary>
		[pbr::OriginalName("FIRE_PUNCH")] FirePunch = 115,

		/// <summary>
		/// The solar beam.
		/// </summary>
		[pbr::OriginalName("SOLAR_BEAM")] SolarBeam = 116,

		/// <summary>
		/// The leaf blade.
		/// </summary>
		[pbr::OriginalName("LEAF_BLADE")] LeafBlade = 117,

		/// <summary>
		/// The power whip.
		/// </summary>
		[pbr::OriginalName("POWER_WHIP")] PowerWhip = 118,

		/// <summary>
		/// The splash.
		/// </summary>
		[pbr::OriginalName("SPLASH")] Splash = 119,

		/// <summary>
		/// The acid.
		/// </summary>
		[pbr::OriginalName("ACID")] Acid = 120,

		/// <summary>
		/// The air cutter.
		/// </summary>
		[pbr::OriginalName("AIR_CUTTER")] AirCutter = 121,

		/// <summary>
		/// The hurricane.
		/// </summary>
		[pbr::OriginalName("HURRICANE")] Hurricane = 122,

		/// <summary>
		/// The brick break.
		/// </summary>
		[pbr::OriginalName("BRICK_BREAK")] BrickBreak = 123,

		/// <summary>
		/// The cut.
		/// </summary>
		[pbr::OriginalName("CUT")] Cut = 124,

		/// <summary>
		/// The swift.
		/// </summary>
		[pbr::OriginalName("SWIFT")] Swift = 125,

		/// <summary>
		/// The horn attack.
		/// </summary>
		[pbr::OriginalName("HORN_ATTACK")] HornAttack = 126,

		/// <summary>
		/// The stomp.
		/// </summary>
		[pbr::OriginalName("STOMP")] Stomp = 127,

		/// <summary>
		/// The headbutt.
		/// </summary>
		[pbr::OriginalName("HEADBUTT")] Headbutt = 128,

		/// <summary>
		/// The hyper fang.
		/// </summary>
		[pbr::OriginalName("HYPER_FANG")] HyperFang = 129,

		/// <summary>
		/// The slam.
		/// </summary>
		[pbr::OriginalName("SLAM")] Slam = 130,

		/// <summary>
		/// The body slam.
		/// </summary>
		[pbr::OriginalName("BODY_SLAM")] BodySlam = 131,

		/// <summary>
		/// The rest.
		/// </summary>
		[pbr::OriginalName("REST")] Rest = 132,

		/// <summary>
		/// The struggle.
		/// </summary>
		[pbr::OriginalName("STRUGGLE")] Struggle = 133,

		/// <summary>
		/// The scald blastoise.
		/// </summary>
		[pbr::OriginalName("SCALD_BLASTOISE")] ScaldBlastoise = 134,

		/// <summary>
		/// The hydro pump blastoise.
		/// </summary>
		[pbr::OriginalName("HYDRO_PUMP_BLASTOISE")] HydroPumpBlastoise = 135,

		/// <summary>
		/// The wrap green.
		/// </summary>
		[pbr::OriginalName("WRAP_GREEN")] WrapGreen = 136,

		/// <summary>
		/// The wrap pink.
		/// </summary>
		[pbr::OriginalName("WRAP_PINK")] WrapPink = 137,

		/// <summary>
		/// The fury cutter fast.
		/// </summary>
		[pbr::OriginalName("FURY_CUTTER_FAST")] FuryCutterFast = 200,

		/// <summary>
		/// The bug bite fast.
		/// </summary>
		[pbr::OriginalName("BUG_BITE_FAST")] BugBiteFast = 201,

		/// <summary>
		/// The bite fast.
		/// </summary>
		[pbr::OriginalName("BITE_FAST")] BiteFast = 202,

		/// <summary>
		/// The sucker punch fast.
		/// </summary>
		[pbr::OriginalName("SUCKER_PUNCH_FAST")] SuckerPunchFast = 203,

		/// <summary>
		/// The dragon breath fast.
		/// </summary>
		[pbr::OriginalName("DRAGON_BREATH_FAST")] DragonBreathFast = 204,

		/// <summary>
		/// The thunder shock fast.
		/// </summary>
		[pbr::OriginalName("THUNDER_SHOCK_FAST")] ThunderShockFast = 205,

		/// <summary>
		/// The spark fast.
		/// </summary>
		[pbr::OriginalName("SPARK_FAST")] SparkFast = 206,

		/// <summary>
		/// The low kick fast.
		/// </summary>
		[pbr::OriginalName("LOW_KICK_FAST")] LowKickFast = 207,

		/// <summary>
		/// The karate chop fast.
		/// </summary>
		[pbr::OriginalName("KARATE_CHOP_FAST")] KarateChopFast = 208,

		/// <summary>
		/// The ember fast.
		/// </summary>
		[pbr::OriginalName("EMBER_FAST")] EmberFast = 209,

		/// <summary>
		/// The wing attack fast.
		/// </summary>
		[pbr::OriginalName("WING_ATTACK_FAST")] WingAttackFast = 210,

		/// <summary>
		/// The peck fast.
		/// </summary>
		[pbr::OriginalName("PECK_FAST")] PeckFast = 211,

		/// <summary>
		/// The lick fast.
		/// </summary>
		[pbr::OriginalName("LICK_FAST")] LickFast = 212,

		/// <summary>
		/// The shadow claw fast.
		/// </summary>
		[pbr::OriginalName("SHADOW_CLAW_FAST")] ShadowClawFast = 213,

		/// <summary>
		/// The vine whip fast.
		/// </summary>
		[pbr::OriginalName("VINE_WHIP_FAST")] VineWhipFast = 214,

		/// <summary>
		/// The razor leaf fast.
		/// </summary>
		[pbr::OriginalName("RAZOR_LEAF_FAST")] RazorLeafFast = 215,

		/// <summary>
		/// The mud shot fast.
		/// </summary>
		[pbr::OriginalName("MUD_SHOT_FAST")] MudShotFast = 216,

		/// <summary>
		/// The ice shard fast.
		/// </summary>
		[pbr::OriginalName("ICE_SHARD_FAST")] IceShardFast = 217,

		/// <summary>
		/// The frost breath fast.
		/// </summary>
		[pbr::OriginalName("FROST_BREATH_FAST")] FrostBreathFast = 218,

		/// <summary>
		/// The quick attack fast.
		/// </summary>
		[pbr::OriginalName("QUICK_ATTACK_FAST")] QuickAttackFast = 219,

		/// <summary>
		/// The scratch fast.
		/// </summary>
		[pbr::OriginalName("SCRATCH_FAST")] ScratchFast = 220,

		/// <summary>
		/// The tackle fast.
		/// </summary>
		[pbr::OriginalName("TACKLE_FAST")] TackleFast = 221,

		/// <summary>
		/// The pound fast.
		/// </summary>
		[pbr::OriginalName("POUND_FAST")] PoundFast = 222,

		/// <summary>
		/// The cut fast.
		/// </summary>
		[pbr::OriginalName("CUT_FAST")] CutFast = 223,

		/// <summary>
		/// The poison jab fast.
		/// </summary>
		[pbr::OriginalName("POISON_JAB_FAST")] PoisonJabFast = 224,

		/// <summary>
		/// The acid fast.
		/// </summary>
		[pbr::OriginalName("ACID_FAST")] AcidFast = 225,

		/// <summary>
		/// The psycho cut fast.
		/// </summary>
		[pbr::OriginalName("PSYCHO_CUT_FAST")] PsychoCutFast = 226,

		/// <summary>
		/// The rock throw fast.
		/// </summary>
		[pbr::OriginalName("ROCK_THROW_FAST")] RockThrowFast = 227,

		/// <summary>
		/// The metal claw fast.
		/// </summary>
		[pbr::OriginalName("METAL_CLAW_FAST")] MetalClawFast = 228,

		/// <summary>
		/// The bullet punch fast.
		/// </summary>
		[pbr::OriginalName("BULLET_PUNCH_FAST")] BulletPunchFast = 229,

		/// <summary>
		/// The water gun fast.
		/// </summary>
		[pbr::OriginalName("WATER_GUN_FAST")] WaterGunFast = 230,

		/// <summary>
		/// The splash fast.
		/// </summary>
		[pbr::OriginalName("SPLASH_FAST")] SplashFast = 231,

		/// <summary>
		/// The water gun fast blastoise.
		/// </summary>
		[pbr::OriginalName("WATER_GUN_FAST_BLASTOISE")] WaterGunFastBlastoise = 232,

		/// <summary>
		/// The mud slap fast.
		/// </summary>
		[pbr::OriginalName("MUD_SLAP_FAST")] MudSlapFast = 233,

		/// <summary>
		/// The zen headbutt fast.
		/// </summary>
		[pbr::OriginalName("ZEN_HEADBUTT_FAST")] ZenHeadbuttFast = 234,

		/// <summary>
		/// The confusion fast.
		/// </summary>
		[pbr::OriginalName("CONFUSION_FAST")] ConfusionFast = 235,

		/// <summary>
		/// The poison sting fast.
		/// </summary>
		[pbr::OriginalName("POISON_STING_FAST")] PoisonStingFast = 236,

		/// <summary>
		/// The bubble fast.
		/// </summary>
		[pbr::OriginalName("BUBBLE_FAST")] BubbleFast = 237,

		/// <summary>
		/// The feint attack fast.
		/// </summary>
		[pbr::OriginalName("FEINT_ATTACK_FAST")] FeintAttackFast = 238,

		/// <summary>
		/// The steel wing fast.
		/// </summary>
		[pbr::OriginalName("STEEL_WING_FAST")] SteelWingFast = 239,

		/// <summary>
		/// The fire fang fast.
		/// </summary>
		[pbr::OriginalName("FIRE_FANG_FAST")] FireFangFast = 240,

		/// <summary>
		/// The rock smash fast.
		/// </summary>
		[pbr::OriginalName("ROCK_SMASH_FAST")] RockSmashFast = 241,
	}

	#endregion
}

#endregion Designer generated code