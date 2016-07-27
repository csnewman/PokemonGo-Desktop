// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokemonFamilyId.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/PokemonFamilyId.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/PokemonFamilyId.proto</summary>
	public static partial class PokemonFamilyIdReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/PokemonFamilyId.proto</summary>
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
		/// Initializes static members of the <see cref="PokemonFamilyIdReflection"/> class.
		/// </summary>
		static PokemonFamilyIdReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiZQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25GYW1pbHlJZC5wcm90bxIQUE9H",
						"T1Byb3Rvcy5FbnVtcyr6DAoPUG9rZW1vbkZhbWlseUlkEhAKDEZBTUlMWV9V",
						"TlNFVBAAEhQKEEZBTUlMWV9CVUxCQVNBVVIQARIVChFGQU1JTFlfQ0hBUk1B",
						"TkRFUhAEEhMKD0ZBTUlMWV9TUVVJUlRMRRAHEhMKD0ZBTUlMWV9DQVRFUlBJ",
						"RRAKEhEKDUZBTUlMWV9XRUVETEUQDRIRCg1GQU1JTFlfUElER0VZEBASEgoO",
						"RkFNSUxZX1JBVFRBVEEQExISCg5GQU1JTFlfU1BFQVJPVxAVEhAKDEZBTUlM",
						"WV9FS0FOUxAXEhIKDkZBTUlMWV9QSUtBQ0hVEBkSFAoQRkFNSUxZX1NBTkRT",
						"SFJFVxAbEhkKFUZBTUlMWV9OSURPUkFOX0ZFTUFMRRAdEhcKE0ZBTUlMWV9O",
						"SURPUkFOX01BTEUQIBITCg9GQU1JTFlfQ0xFRkFJUlkQIxIRCg1GQU1JTFlf",
						"VlVMUElYECUSFQoRRkFNSUxZX0pJR0dMWVBVRkYQJxIQCgxGQU1JTFlfWlVC",
						"QVQQKRIRCg1GQU1JTFlfT0RESVNIECsSEAoMRkFNSUxZX1BBUkFTEC4SEgoO",
						"RkFNSUxZX1ZFTk9OQVQQMBISCg5GQU1JTFlfRElHTEVUVBAyEhEKDUZBTUlM",
						"WV9NRU9XVEgQNBISCg5GQU1JTFlfUFNZRFVDSxA2EhEKDUZBTUlMWV9NQU5L",
						"RVkQOBIUChBGQU1JTFlfR1JPV0xJVEhFEDoSEgoORkFNSUxZX1BPTElXQUcQ",
						"PBIPCgtGQU1JTFlfQUJSQRA/EhEKDUZBTUlMWV9NQUNIT1AQQhIVChFGQU1J",
						"TFlfQkVMTFNQUk9VVBBFEhQKEEZBTUlMWV9URU5UQUNPT0wQSBISCg5GQU1J",
						"TFlfR0VPRFVERRBKEhEKDUZBTUlMWV9QT05ZVEEQTRITCg9GQU1JTFlfU0xP",
						"V1BPS0UQTxIUChBGQU1JTFlfTUFHTkVNSVRFEFESFAoQRkFNSUxZX0ZBUkZF",
						"VENIRBBTEhAKDEZBTUlMWV9ET0RVTxBUEg8KC0ZBTUlMWV9TRUVMEFYSEQoN",
						"RkFNSUxZX0dSSU1FUhBYEhMKD0ZBTUlMWV9TSEVMTERFUhBaEhEKDUZBTUlM",
						"WV9HQVNUTFkQXBIPCgtGQU1JTFlfT05JWBBfEhIKDkZBTUlMWV9EUk9XWkVF",
						"EGASEAoMRkFNSUxZX0hZUE5PEGESEQoNRkFNSUxZX0tSQUJCWRBiEhIKDkZB",
						"TUlMWV9WT0xUT1JCEGQSFAoQRkFNSUxZX0VYRUdHQ1VURRBmEhEKDUZBTUlM",
						"WV9DVUJPTkUQaBIUChBGQU1JTFlfSElUTU9OTEVFEGoSFQoRRkFNSUxZX0hJ",
						"VE1PTkNIQU4QaxIUChBGQU1JTFlfTElDS0lUVU5HEGwSEgoORkFNSUxZX0tP",
						"RkZJTkcQbRISCg5GQU1JTFlfUkhZSE9SThBvEhIKDkZBTUlMWV9DSEFOU0VZ",
						"EHESEgoORkFNSUxZX1RBTkdFTEEQchIVChFGQU1JTFlfS0FOR0FTS0hBThBz",
						"EhEKDUZBTUlMWV9IT1JTRUEQdBISCg5GQU1JTFlfR09MREVFThB2EhEKDUZB",
						"TUlMWV9TVEFSWVUQeBISCg5GQU1JTFlfTVJfTUlNRRB6EhIKDkZBTUlMWV9T",
						"Q1lUSEVSEHsSDwoLRkFNSUxZX0pZTlgQfBIVChFGQU1JTFlfRUxFQ1RBQlVa",
						"WhB9EhEKDUZBTUlMWV9NQUdNQVIQfhIRCg1GQU1JTFlfUElOU0lSEH8SEgoN",
						"RkFNSUxZX1RBVVJPUxCAARIUCg9GQU1JTFlfTUFHSUtBUlAQgQESEgoNRkFN",
						"SUxZX0xBUFJBUxCDARIRCgxGQU1JTFlfRElUVE8QhAESEQoMRkFNSUxZX0VF",
						"VkVFEIUBEhMKDkZBTUlMWV9QT1JZR09OEIkBEhMKDkZBTUlMWV9PTUFOWVRF",
						"EIoBEhIKDUZBTUlMWV9LQUJVVE8QjAESFgoRRkFNSUxZX0FFUk9EQUNUWUwQ",
						"jgESEwoORkFNSUxZX1NOT1JMQVgQjwESFAoPRkFNSUxZX0FSVElDVU5PEJAB",
						"EhIKDUZBTUlMWV9aQVBET1MQkQESEwoORkFNSUxZX01PTFRSRVMQkgESEwoO",
						"RkFNSUxZX0RSQVRJTkkQkwESEgoNRkFNSUxZX01FV1RXTxCWARIPCgpGQU1J",
						"TFlfTUVXEJcBYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.PokemonFamilyId), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The pokemon family id.
	/// </summary>
	public enum PokemonFamilyId
	{
		/// <summary>
		/// The family unset.
		/// </summary>
		[pbr::OriginalName("FAMILY_UNSET")] FamilyUnset = 0,

		/// <summary>
		/// The family bulbasaur.
		/// </summary>
		[pbr::OriginalName("FAMILY_BULBASAUR")] FamilyBulbasaur = 1,

		/// <summary>
		/// The family charmander.
		/// </summary>
		[pbr::OriginalName("FAMILY_CHARMANDER")] FamilyCharmander = 4,

		/// <summary>
		/// The family squirtle.
		/// </summary>
		[pbr::OriginalName("FAMILY_SQUIRTLE")] FamilySquirtle = 7,

		/// <summary>
		/// The family caterpie.
		/// </summary>
		[pbr::OriginalName("FAMILY_CATERPIE")] FamilyCaterpie = 10,

		/// <summary>
		/// The family weedle.
		/// </summary>
		[pbr::OriginalName("FAMILY_WEEDLE")] FamilyWeedle = 13,

		/// <summary>
		/// The family pidgey.
		/// </summary>
		[pbr::OriginalName("FAMILY_PIDGEY")] FamilyPidgey = 16,

		/// <summary>
		/// The family rattata.
		/// </summary>
		[pbr::OriginalName("FAMILY_RATTATA")] FamilyRattata = 19,

		/// <summary>
		/// The family spearow.
		/// </summary>
		[pbr::OriginalName("FAMILY_SPEAROW")] FamilySpearow = 21,

		/// <summary>
		/// The family ekans.
		/// </summary>
		[pbr::OriginalName("FAMILY_EKANS")] FamilyEkans = 23,

		/// <summary>
		/// The family pikachu.
		/// </summary>
		[pbr::OriginalName("FAMILY_PIKACHU")] FamilyPikachu = 25,

		/// <summary>
		/// The family sandshrew.
		/// </summary>
		[pbr::OriginalName("FAMILY_SANDSHREW")] FamilySandshrew = 27,

		/// <summary>
		/// The family nidoran female.
		/// </summary>
		[pbr::OriginalName("FAMILY_NIDORAN_FEMALE")] FamilyNidoranFemale = 29,

		/// <summary>
		/// The family nidoran male.
		/// </summary>
		[pbr::OriginalName("FAMILY_NIDORAN_MALE")] FamilyNidoranMale = 32,

		/// <summary>
		/// The family clefairy.
		/// </summary>
		[pbr::OriginalName("FAMILY_CLEFAIRY")] FamilyClefairy = 35,

		/// <summary>
		/// The family vulpix.
		/// </summary>
		[pbr::OriginalName("FAMILY_VULPIX")] FamilyVulpix = 37,

		/// <summary>
		/// The family jigglypuff.
		/// </summary>
		[pbr::OriginalName("FAMILY_JIGGLYPUFF")] FamilyJigglypuff = 39,

		/// <summary>
		/// The family zubat.
		/// </summary>
		[pbr::OriginalName("FAMILY_ZUBAT")] FamilyZubat = 41,

		/// <summary>
		/// The family oddish.
		/// </summary>
		[pbr::OriginalName("FAMILY_ODDISH")] FamilyOddish = 43,

		/// <summary>
		/// The family paras.
		/// </summary>
		[pbr::OriginalName("FAMILY_PARAS")] FamilyParas = 46,

		/// <summary>
		/// The family venonat.
		/// </summary>
		[pbr::OriginalName("FAMILY_VENONAT")] FamilyVenonat = 48,

		/// <summary>
		/// The family diglett.
		/// </summary>
		[pbr::OriginalName("FAMILY_DIGLETT")] FamilyDiglett = 50,

		/// <summary>
		/// The family meowth.
		/// </summary>
		[pbr::OriginalName("FAMILY_MEOWTH")] FamilyMeowth = 52,

		/// <summary>
		/// The family psyduck.
		/// </summary>
		[pbr::OriginalName("FAMILY_PSYDUCK")] FamilyPsyduck = 54,

		/// <summary>
		/// The family mankey.
		/// </summary>
		[pbr::OriginalName("FAMILY_MANKEY")] FamilyMankey = 56,

		/// <summary>
		/// The family growlithe.
		/// </summary>
		[pbr::OriginalName("FAMILY_GROWLITHE")] FamilyGrowlithe = 58,

		/// <summary>
		/// The family poliwag.
		/// </summary>
		[pbr::OriginalName("FAMILY_POLIWAG")] FamilyPoliwag = 60,

		/// <summary>
		/// The family abra.
		/// </summary>
		[pbr::OriginalName("FAMILY_ABRA")] FamilyAbra = 63,

		/// <summary>
		/// The family machop.
		/// </summary>
		[pbr::OriginalName("FAMILY_MACHOP")] FamilyMachop = 66,

		/// <summary>
		/// The family bellsprout.
		/// </summary>
		[pbr::OriginalName("FAMILY_BELLSPROUT")] FamilyBellsprout = 69,

		/// <summary>
		/// The family tentacool.
		/// </summary>
		[pbr::OriginalName("FAMILY_TENTACOOL")] FamilyTentacool = 72,

		/// <summary>
		/// The family geodude.
		/// </summary>
		[pbr::OriginalName("FAMILY_GEODUDE")] FamilyGeodude = 74,

		/// <summary>
		/// The family ponyta.
		/// </summary>
		[pbr::OriginalName("FAMILY_PONYTA")] FamilyPonyta = 77,

		/// <summary>
		/// The family slowpoke.
		/// </summary>
		[pbr::OriginalName("FAMILY_SLOWPOKE")] FamilySlowpoke = 79,

		/// <summary>
		/// The family magnemite.
		/// </summary>
		[pbr::OriginalName("FAMILY_MAGNEMITE")] FamilyMagnemite = 81,

		/// <summary>
		/// The family farfetchd.
		/// </summary>
		[pbr::OriginalName("FAMILY_FARFETCHD")] FamilyFarfetchd = 83,

		/// <summary>
		/// The family doduo.
		/// </summary>
		[pbr::OriginalName("FAMILY_DODUO")] FamilyDoduo = 84,

		/// <summary>
		/// The family seel.
		/// </summary>
		[pbr::OriginalName("FAMILY_SEEL")] FamilySeel = 86,

		/// <summary>
		/// The family grimer.
		/// </summary>
		[pbr::OriginalName("FAMILY_GRIMER")] FamilyGrimer = 88,

		/// <summary>
		/// The family shellder.
		/// </summary>
		[pbr::OriginalName("FAMILY_SHELLDER")] FamilyShellder = 90,

		/// <summary>
		/// The family gastly.
		/// </summary>
		[pbr::OriginalName("FAMILY_GASTLY")] FamilyGastly = 92,

		/// <summary>
		/// The family onix.
		/// </summary>
		[pbr::OriginalName("FAMILY_ONIX")] FamilyOnix = 95,

		/// <summary>
		/// The family drowzee.
		/// </summary>
		[pbr::OriginalName("FAMILY_DROWZEE")] FamilyDrowzee = 96,

		/// <summary>
		/// The family hypno.
		/// </summary>
		[pbr::OriginalName("FAMILY_HYPNO")] FamilyHypno = 97,

		/// <summary>
		/// The family krabby.
		/// </summary>
		[pbr::OriginalName("FAMILY_KRABBY")] FamilyKrabby = 98,

		/// <summary>
		/// The family voltorb.
		/// </summary>
		[pbr::OriginalName("FAMILY_VOLTORB")] FamilyVoltorb = 100,

		/// <summary>
		/// The family exeggcute.
		/// </summary>
		[pbr::OriginalName("FAMILY_EXEGGCUTE")] FamilyExeggcute = 102,

		/// <summary>
		/// The family cubone.
		/// </summary>
		[pbr::OriginalName("FAMILY_CUBONE")] FamilyCubone = 104,

		/// <summary>
		/// The family hitmonlee.
		/// </summary>
		[pbr::OriginalName("FAMILY_HITMONLEE")] FamilyHitmonlee = 106,

		/// <summary>
		/// The family hitmonchan.
		/// </summary>
		[pbr::OriginalName("FAMILY_HITMONCHAN")] FamilyHitmonchan = 107,

		/// <summary>
		/// The family lickitung.
		/// </summary>
		[pbr::OriginalName("FAMILY_LICKITUNG")] FamilyLickitung = 108,

		/// <summary>
		/// The family koffing.
		/// </summary>
		[pbr::OriginalName("FAMILY_KOFFING")] FamilyKoffing = 109,

		/// <summary>
		/// The family rhyhorn.
		/// </summary>
		[pbr::OriginalName("FAMILY_RHYHORN")] FamilyRhyhorn = 111,

		/// <summary>
		/// The family chansey.
		/// </summary>
		[pbr::OriginalName("FAMILY_CHANSEY")] FamilyChansey = 113,

		/// <summary>
		/// The family tangela.
		/// </summary>
		[pbr::OriginalName("FAMILY_TANGELA")] FamilyTangela = 114,

		/// <summary>
		/// The family kangaskhan.
		/// </summary>
		[pbr::OriginalName("FAMILY_KANGASKHAN")] FamilyKangaskhan = 115,

		/// <summary>
		/// The family horsea.
		/// </summary>
		[pbr::OriginalName("FAMILY_HORSEA")] FamilyHorsea = 116,

		/// <summary>
		/// The family goldeen.
		/// </summary>
		[pbr::OriginalName("FAMILY_GOLDEEN")] FamilyGoldeen = 118,

		/// <summary>
		/// The family staryu.
		/// </summary>
		[pbr::OriginalName("FAMILY_STARYU")] FamilyStaryu = 120,

		/// <summary>
		/// The family mr mime.
		/// </summary>
		[pbr::OriginalName("FAMILY_MR_MIME")] FamilyMrMime = 122,

		/// <summary>
		/// The family scyther.
		/// </summary>
		[pbr::OriginalName("FAMILY_SCYTHER")] FamilyScyther = 123,

		/// <summary>
		/// The family jynx.
		/// </summary>
		[pbr::OriginalName("FAMILY_JYNX")] FamilyJynx = 124,

		/// <summary>
		/// The family electabuzz.
		/// </summary>
		[pbr::OriginalName("FAMILY_ELECTABUZZ")] FamilyElectabuzz = 125,

		/// <summary>
		/// The family magmar.
		/// </summary>
		[pbr::OriginalName("FAMILY_MAGMAR")] FamilyMagmar = 126,

		/// <summary>
		/// The family pinsir.
		/// </summary>
		[pbr::OriginalName("FAMILY_PINSIR")] FamilyPinsir = 127,

		/// <summary>
		/// The family tauros.
		/// </summary>
		[pbr::OriginalName("FAMILY_TAUROS")] FamilyTauros = 128,

		/// <summary>
		/// The family magikarp.
		/// </summary>
		[pbr::OriginalName("FAMILY_MAGIKARP")] FamilyMagikarp = 129,

		/// <summary>
		/// The family lapras.
		/// </summary>
		[pbr::OriginalName("FAMILY_LAPRAS")] FamilyLapras = 131,

		/// <summary>
		/// The family ditto.
		/// </summary>
		[pbr::OriginalName("FAMILY_DITTO")] FamilyDitto = 132,

		/// <summary>
		/// The family eevee.
		/// </summary>
		[pbr::OriginalName("FAMILY_EEVEE")] FamilyEevee = 133,

		/// <summary>
		/// The family porygon.
		/// </summary>
		[pbr::OriginalName("FAMILY_PORYGON")] FamilyPorygon = 137,

		/// <summary>
		/// The family omanyte.
		/// </summary>
		[pbr::OriginalName("FAMILY_OMANYTE")] FamilyOmanyte = 138,

		/// <summary>
		/// The family kabuto.
		/// </summary>
		[pbr::OriginalName("FAMILY_KABUTO")] FamilyKabuto = 140,

		/// <summary>
		/// The family aerodactyl.
		/// </summary>
		[pbr::OriginalName("FAMILY_AERODACTYL")] FamilyAerodactyl = 142,

		/// <summary>
		/// The family snorlax.
		/// </summary>
		[pbr::OriginalName("FAMILY_SNORLAX")] FamilySnorlax = 143,

		/// <summary>
		/// The family articuno.
		/// </summary>
		[pbr::OriginalName("FAMILY_ARTICUNO")] FamilyArticuno = 144,

		/// <summary>
		/// The family zapdos.
		/// </summary>
		[pbr::OriginalName("FAMILY_ZAPDOS")] FamilyZapdos = 145,

		/// <summary>
		/// The family moltres.
		/// </summary>
		[pbr::OriginalName("FAMILY_MOLTRES")] FamilyMoltres = 146,

		/// <summary>
		/// The family dratini.
		/// </summary>
		[pbr::OriginalName("FAMILY_DRATINI")] FamilyDratini = 147,

		/// <summary>
		/// The family mewtwo.
		/// </summary>
		[pbr::OriginalName("FAMILY_MEWTWO")] FamilyMewtwo = 150,

		/// <summary>
		/// The family mew.
		/// </summary>
		[pbr::OriginalName("FAMILY_MEW")] FamilyMew = 151,
	}

	#endregion
}

#endregion Designer generated code