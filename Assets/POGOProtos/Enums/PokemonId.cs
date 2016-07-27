// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokemonId.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/PokemonId.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/PokemonId.proto</summary>
	public static partial class PokemonIdReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/PokemonId.proto</summary>
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
		/// Initializes static members of the <see cref="PokemonIdReflection"/> class.
		/// </summary>
		static PokemonIdReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiBQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25JZC5wcm90bxIQUE9HT1Byb3Rv",
						"cy5FbnVtcyqTEAoJUG9rZW1vbklkEg0KCU1JU1NJTkdOTxAAEg0KCUJVTEJB",
						"U0FVUhABEgsKB0lWWVNBVVIQAhIMCghWRU5VU0FVUhADEg4KCkNIQVJNQU5E",
						"RVIQBBIOCgpDSEFSTUVMRU9OEAUSDQoJQ0hBUklaQVJEEAYSDAoIU1FVSVJU",
						"TEUQBxINCglXQVJUT1JUTEUQCBINCglCTEFTVE9JU0UQCRIMCghDQVRFUlBJ",
						"RRAKEgsKB01FVEFQT0QQCxIOCgpCVVRURVJGUkVFEAwSCgoGV0VFRExFEA0S",
						"CgoGS0FLVU5BEA4SDAoIQkVFRFJJTEwQDxIKCgZQSURHRVkQEBINCglQSURH",
						"RU9UVE8QERILCgdQSURHRU9UEBISCwoHUkFUVEFUQRATEgwKCFJBVElDQVRF",
						"EBQSCwoHU1BFQVJPVxAVEgoKBkZFQVJPVxAWEgkKBUVLQU5TEBcSCQoFQVJC",
						"T0sQGBILCgdQSUtBQ0hVEBkSCgoGUkFJQ0hVEBoSDQoJU0FORFNIUkVXEBsS",
						"DQoJU0FORFNMQVNIEBwSEgoOTklET1JBTl9GRU1BTEUQHRIMCghOSURPUklO",
						"QRAeEg0KCU5JRE9RVUVFThAfEhAKDE5JRE9SQU5fTUFMRRAgEgwKCE5JRE9S",
						"SU5PECESDAoITklET0tJTkcQIhIMCghDTEVGQUlSWRAjEgwKCENMRUZBQkxF",
						"ECQSCgoGVlVMUElYECUSDQoJTklORVRBTEVTECYSDgoKSklHR0xZUFVGRhAn",
						"Eg4KCldJR0dMWVRVRkYQKBIJCgVaVUJBVBApEgoKBkdPTEJBVBAqEgoKBk9E",
						"RElTSBArEgkKBUdMT09NECwSDQoJVklMRVBMVU1FEC0SCQoFUEFSQVMQLhIM",
						"CghQQVJBU0VDVBAvEgsKB1ZFTk9OQVQQMBIMCghWRU5PTU9USBAxEgsKB0RJ",
						"R0xFVFQQMhILCgdEVUdUUklPEDMSCgoGTUVPV1RIEDQSCwoHUEVSU0lBThA1",
						"EgsKB1BTWURVQ0sQNhILCgdHT0xEVUNLEDcSCgoGTUFOS0VZEDgSDAoIUFJJ",
						"TUVBUEUQORINCglHUk9XTElUSEUQOhIMCghBUkNBTklORRA7EgsKB1BPTElX",
						"QUcQPBINCglQT0xJV0hJUkwQPRINCglQT0xJV1JBVEgQPhIICgRBQlJBED8S",
						"CwoHS0FEQUJSQRBAEgwKCEFMQUtBWkFNEEESCgoGTUFDSE9QEEISCwoHTUFD",
						"SE9LRRBDEgsKB01BQ0hBTVAQRBIOCgpCRUxMU1BST1VUEEUSDgoKV0VFUElO",
						"QkVMTBBGEg4KClZJQ1RSRUVCRUwQRxINCglURU5UQUNPT0wQSBIOCgpURU5U",
						"QUNSVUVMEEkSCwoHR0VPRFVERRBKEgwKCEdSQVZFTEVSEEsSCQoFR09MRU0Q",
						"TBIKCgZQT05ZVEEQTRIMCghSQVBJREFTSBBOEgwKCFNMT1dQT0tFEE8SCwoH",
						"U0xPV0JSTxBQEg0KCU1BR05FTUlURRBREgwKCE1BR05FVE9OEFISDQoJRkFS",
						"RkVUQ0hEEFMSCQoFRE9EVU8QVBIKCgZET0RSSU8QVRIICgRTRUVMEFYSCwoH",
						"REVXR09ORxBXEgoKBkdSSU1FUhBYEgcKA01VSxBZEgwKCFNIRUxMREVSEFoS",
						"DAoIQ0xPWVNURVIQWxIKCgZHQVNUTFkQXBILCgdIQVVOVEVSEF0SCgoGR0VO",
						"R0FSEF4SCAoET05JWBBfEgsKB0RST1daRUUQYBIJCgVIWVBOTxBhEgoKBktS",
						"QUJCWRBiEgsKB0tJTkdMRVIQYxILCgdWT0xUT1JCEGQSDQoJRUxFQ1RST0RF",
						"EGUSDQoJRVhFR0dDVVRFEGYSDQoJRVhFR0dVVE9SEGcSCgoGQ1VCT05FEGgS",
						"CwoHTUFST1dBSxBpEg0KCUhJVE1PTkxFRRBqEg4KCkhJVE1PTkNIQU4QaxIN",
						"CglMSUNLSVRVTkcQbBILCgdLT0ZGSU5HEG0SCwoHV0VFWklORxBuEgsKB1JI",
						"WUhPUk4QbxIKCgZSSFlET04QcBILCgdDSEFOU0VZEHESCwoHVEFOR0VMQRBy",
						"Eg4KCktBTkdBU0tIQU4QcxIKCgZIT1JTRUEQdBIKCgZTRUFEUkEQdRILCgdH",
						"T0xERUVOEHYSCwoHU0VBS0lORxB3EgoKBlNUQVJZVRB4EgsKB1NUQVJNSUUQ",
						"eRILCgdNUl9NSU1FEHoSCwoHU0NZVEhFUhB7EggKBEpZTlgQfBIOCgpFTEVD",
						"VEFCVVpaEH0SCgoGTUFHTUFSEH4SCgoGUElOU0lSEH8SCwoGVEFVUk9TEIAB",
						"Eg0KCE1BR0lLQVJQEIEBEg0KCEdZQVJBRE9TEIIBEgsKBkxBUFJBUxCDARIK",
						"CgVESVRUTxCEARIKCgVFRVZFRRCFARINCghWQVBPUkVPThCGARIMCgdKT0xU",
						"RU9OEIcBEgwKB0ZMQVJFT04QiAESDAoHUE9SWUdPThCJARIMCgdPTUFOWVRF",
						"EIoBEgwKB09NQVNUQVIQiwESCwoGS0FCVVRPEIwBEg0KCEtBQlVUT1BTEI0B",
						"Eg8KCkFFUk9EQUNUWUwQjgESDAoHU05PUkxBWBCPARINCghBUlRJQ1VOTxCQ",
						"ARILCgZaQVBET1MQkQESDAoHTU9MVFJFUxCSARIMCgdEUkFUSU5JEJMBEg4K",
						"CURSQUdPTkFJUhCUARIOCglEUkFHT05JVEUQlQESCwoGTUVXVFdPEJYBEggK",
						"A01FVxCXAWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.PokemonId), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The pokemon id.
	/// </summary>
	public enum PokemonId
	{
		/// <summary>
		/// The missingno.
		/// </summary>
		[pbr::OriginalName("MISSINGNO")] Missingno = 0,

		/// <summary>
		/// The bulbasaur.
		/// </summary>
		[pbr::OriginalName("BULBASAUR")] Bulbasaur = 1,

		/// <summary>
		/// The ivysaur.
		/// </summary>
		[pbr::OriginalName("IVYSAUR")] Ivysaur = 2,

		/// <summary>
		/// The venusaur.
		/// </summary>
		[pbr::OriginalName("VENUSAUR")] Venusaur = 3,

		/// <summary>
		/// The charmander.
		/// </summary>
		[pbr::OriginalName("CHARMANDER")] Charmander = 4,

		/// <summary>
		/// The charmeleon.
		/// </summary>
		[pbr::OriginalName("CHARMELEON")] Charmeleon = 5,

		/// <summary>
		/// The charizard.
		/// </summary>
		[pbr::OriginalName("CHARIZARD")] Charizard = 6,

		/// <summary>
		/// The squirtle.
		/// </summary>
		[pbr::OriginalName("SQUIRTLE")] Squirtle = 7,

		/// <summary>
		/// The wartortle.
		/// </summary>
		[pbr::OriginalName("WARTORTLE")] Wartortle = 8,

		/// <summary>
		/// The blastoise.
		/// </summary>
		[pbr::OriginalName("BLASTOISE")] Blastoise = 9,

		/// <summary>
		/// The caterpie.
		/// </summary>
		[pbr::OriginalName("CATERPIE")] Caterpie = 10,

		/// <summary>
		/// The metapod.
		/// </summary>
		[pbr::OriginalName("METAPOD")] Metapod = 11,

		/// <summary>
		/// The butterfree.
		/// </summary>
		[pbr::OriginalName("BUTTERFREE")] Butterfree = 12,

		/// <summary>
		/// The weedle.
		/// </summary>
		[pbr::OriginalName("WEEDLE")] Weedle = 13,

		/// <summary>
		/// The kakuna.
		/// </summary>
		[pbr::OriginalName("KAKUNA")] Kakuna = 14,

		/// <summary>
		/// The beedrill.
		/// </summary>
		[pbr::OriginalName("BEEDRILL")] Beedrill = 15,

		/// <summary>
		/// The pidgey.
		/// </summary>
		[pbr::OriginalName("PIDGEY")] Pidgey = 16,

		/// <summary>
		/// The pidgeotto.
		/// </summary>
		[pbr::OriginalName("PIDGEOTTO")] Pidgeotto = 17,

		/// <summary>
		/// The pidgeot.
		/// </summary>
		[pbr::OriginalName("PIDGEOT")] Pidgeot = 18,

		/// <summary>
		/// The rattata.
		/// </summary>
		[pbr::OriginalName("RATTATA")] Rattata = 19,

		/// <summary>
		/// The raticate.
		/// </summary>
		[pbr::OriginalName("RATICATE")] Raticate = 20,

		/// <summary>
		/// The spearow.
		/// </summary>
		[pbr::OriginalName("SPEAROW")] Spearow = 21,

		/// <summary>
		/// The fearow.
		/// </summary>
		[pbr::OriginalName("FEAROW")] Fearow = 22,

		/// <summary>
		/// The ekans.
		/// </summary>
		[pbr::OriginalName("EKANS")] Ekans = 23,

		/// <summary>
		/// The arbok.
		/// </summary>
		[pbr::OriginalName("ARBOK")] Arbok = 24,

		/// <summary>
		/// The pikachu.
		/// </summary>
		[pbr::OriginalName("PIKACHU")] Pikachu = 25,

		/// <summary>
		/// The raichu.
		/// </summary>
		[pbr::OriginalName("RAICHU")] Raichu = 26,

		/// <summary>
		/// The sandshrew.
		/// </summary>
		[pbr::OriginalName("SANDSHREW")] Sandshrew = 27,

		/// <summary>
		/// The sandslash.
		/// </summary>
		[pbr::OriginalName("SANDSLASH")] Sandslash = 28,

		/// <summary>
		/// The nidoran female.
		/// </summary>
		[pbr::OriginalName("NIDORAN_FEMALE")] NidoranFemale = 29,

		/// <summary>
		/// The nidorina.
		/// </summary>
		[pbr::OriginalName("NIDORINA")] Nidorina = 30,

		/// <summary>
		/// The nidoqueen.
		/// </summary>
		[pbr::OriginalName("NIDOQUEEN")] Nidoqueen = 31,

		/// <summary>
		/// The nidoran male.
		/// </summary>
		[pbr::OriginalName("NIDORAN_MALE")] NidoranMale = 32,

		/// <summary>
		/// The nidorino.
		/// </summary>
		[pbr::OriginalName("NIDORINO")] Nidorino = 33,

		/// <summary>
		/// The nidoking.
		/// </summary>
		[pbr::OriginalName("NIDOKING")] Nidoking = 34,

		/// <summary>
		/// The clefairy.
		/// </summary>
		[pbr::OriginalName("CLEFAIRY")] Clefairy = 35,

		/// <summary>
		/// The clefable.
		/// </summary>
		[pbr::OriginalName("CLEFABLE")] Clefable = 36,

		/// <summary>
		/// The vulpix.
		/// </summary>
		[pbr::OriginalName("VULPIX")] Vulpix = 37,

		/// <summary>
		/// The ninetales.
		/// </summary>
		[pbr::OriginalName("NINETALES")] Ninetales = 38,

		/// <summary>
		/// The jigglypuff.
		/// </summary>
		[pbr::OriginalName("JIGGLYPUFF")] Jigglypuff = 39,

		/// <summary>
		/// The wigglytuff.
		/// </summary>
		[pbr::OriginalName("WIGGLYTUFF")] Wigglytuff = 40,

		/// <summary>
		/// The zubat.
		/// </summary>
		[pbr::OriginalName("ZUBAT")] Zubat = 41,

		/// <summary>
		/// The golbat.
		/// </summary>
		[pbr::OriginalName("GOLBAT")] Golbat = 42,

		/// <summary>
		/// The oddish.
		/// </summary>
		[pbr::OriginalName("ODDISH")] Oddish = 43,

		/// <summary>
		/// The gloom.
		/// </summary>
		[pbr::OriginalName("GLOOM")] Gloom = 44,

		/// <summary>
		/// The vileplume.
		/// </summary>
		[pbr::OriginalName("VILEPLUME")] Vileplume = 45,

		/// <summary>
		/// The paras.
		/// </summary>
		[pbr::OriginalName("PARAS")] Paras = 46,

		/// <summary>
		/// The parasect.
		/// </summary>
		[pbr::OriginalName("PARASECT")] Parasect = 47,

		/// <summary>
		/// The venonat.
		/// </summary>
		[pbr::OriginalName("VENONAT")] Venonat = 48,

		/// <summary>
		/// The venomoth.
		/// </summary>
		[pbr::OriginalName("VENOMOTH")] Venomoth = 49,

		/// <summary>
		/// The diglett.
		/// </summary>
		[pbr::OriginalName("DIGLETT")] Diglett = 50,

		/// <summary>
		/// The dugtrio.
		/// </summary>
		[pbr::OriginalName("DUGTRIO")] Dugtrio = 51,

		/// <summary>
		/// The meowth.
		/// </summary>
		[pbr::OriginalName("MEOWTH")] Meowth = 52,

		/// <summary>
		/// The persian.
		/// </summary>
		[pbr::OriginalName("PERSIAN")] Persian = 53,

		/// <summary>
		/// The psyduck.
		/// </summary>
		[pbr::OriginalName("PSYDUCK")] Psyduck = 54,

		/// <summary>
		/// The golduck.
		/// </summary>
		[pbr::OriginalName("GOLDUCK")] Golduck = 55,

		/// <summary>
		/// The mankey.
		/// </summary>
		[pbr::OriginalName("MANKEY")] Mankey = 56,

		/// <summary>
		/// The primeape.
		/// </summary>
		[pbr::OriginalName("PRIMEAPE")] Primeape = 57,

		/// <summary>
		/// The growlithe.
		/// </summary>
		[pbr::OriginalName("GROWLITHE")] Growlithe = 58,

		/// <summary>
		/// The arcanine.
		/// </summary>
		[pbr::OriginalName("ARCANINE")] Arcanine = 59,

		/// <summary>
		/// The poliwag.
		/// </summary>
		[pbr::OriginalName("POLIWAG")] Poliwag = 60,

		/// <summary>
		/// The poliwhirl.
		/// </summary>
		[pbr::OriginalName("POLIWHIRL")] Poliwhirl = 61,

		/// <summary>
		/// The poliwrath.
		/// </summary>
		[pbr::OriginalName("POLIWRATH")] Poliwrath = 62,

		/// <summary>
		/// The abra.
		/// </summary>
		[pbr::OriginalName("ABRA")] Abra = 63,

		/// <summary>
		/// The kadabra.
		/// </summary>
		[pbr::OriginalName("KADABRA")] Kadabra = 64,

		/// <summary>
		/// The alakazam.
		/// </summary>
		[pbr::OriginalName("ALAKAZAM")] Alakazam = 65,

		/// <summary>
		/// The machop.
		/// </summary>
		[pbr::OriginalName("MACHOP")] Machop = 66,

		/// <summary>
		/// The machoke.
		/// </summary>
		[pbr::OriginalName("MACHOKE")] Machoke = 67,

		/// <summary>
		/// The machamp.
		/// </summary>
		[pbr::OriginalName("MACHAMP")] Machamp = 68,

		/// <summary>
		/// The bellsprout.
		/// </summary>
		[pbr::OriginalName("BELLSPROUT")] Bellsprout = 69,

		/// <summary>
		/// The weepinbell.
		/// </summary>
		[pbr::OriginalName("WEEPINBELL")] Weepinbell = 70,

		/// <summary>
		/// The victreebel.
		/// </summary>
		[pbr::OriginalName("VICTREEBEL")] Victreebel = 71,

		/// <summary>
		/// The tentacool.
		/// </summary>
		[pbr::OriginalName("TENTACOOL")] Tentacool = 72,

		/// <summary>
		/// The tentacruel.
		/// </summary>
		[pbr::OriginalName("TENTACRUEL")] Tentacruel = 73,

		/// <summary>
		/// The geodude.
		/// </summary>
		[pbr::OriginalName("GEODUDE")] Geodude = 74,

		/// <summary>
		/// The graveler.
		/// </summary>
		[pbr::OriginalName("GRAVELER")] Graveler = 75,

		/// <summary>
		/// The golem.
		/// </summary>
		[pbr::OriginalName("GOLEM")] Golem = 76,

		/// <summary>
		/// The ponyta.
		/// </summary>
		[pbr::OriginalName("PONYTA")] Ponyta = 77,

		/// <summary>
		/// The rapidash.
		/// </summary>
		[pbr::OriginalName("RAPIDASH")] Rapidash = 78,

		/// <summary>
		/// The slowpoke.
		/// </summary>
		[pbr::OriginalName("SLOWPOKE")] Slowpoke = 79,

		/// <summary>
		/// The slowbro.
		/// </summary>
		[pbr::OriginalName("SLOWBRO")] Slowbro = 80,

		/// <summary>
		/// The magnemite.
		/// </summary>
		[pbr::OriginalName("MAGNEMITE")] Magnemite = 81,

		/// <summary>
		/// The magneton.
		/// </summary>
		[pbr::OriginalName("MAGNETON")] Magneton = 82,

		/// <summary>
		/// The farfetchd.
		/// </summary>
		[pbr::OriginalName("FARFETCHD")] Farfetchd = 83,

		/// <summary>
		/// The doduo.
		/// </summary>
		[pbr::OriginalName("DODUO")] Doduo = 84,

		/// <summary>
		/// The dodrio.
		/// </summary>
		[pbr::OriginalName("DODRIO")] Dodrio = 85,

		/// <summary>
		/// The seel.
		/// </summary>
		[pbr::OriginalName("SEEL")] Seel = 86,

		/// <summary>
		/// The dewgong.
		/// </summary>
		[pbr::OriginalName("DEWGONG")] Dewgong = 87,

		/// <summary>
		/// The grimer.
		/// </summary>
		[pbr::OriginalName("GRIMER")] Grimer = 88,

		/// <summary>
		/// The muk.
		/// </summary>
		[pbr::OriginalName("MUK")] Muk = 89,

		/// <summary>
		/// The shellder.
		/// </summary>
		[pbr::OriginalName("SHELLDER")] Shellder = 90,

		/// <summary>
		/// The cloyster.
		/// </summary>
		[pbr::OriginalName("CLOYSTER")] Cloyster = 91,

		/// <summary>
		/// The gastly.
		/// </summary>
		[pbr::OriginalName("GASTLY")] Gastly = 92,

		/// <summary>
		/// The haunter.
		/// </summary>
		[pbr::OriginalName("HAUNTER")] Haunter = 93,

		/// <summary>
		/// The gengar.
		/// </summary>
		[pbr::OriginalName("GENGAR")] Gengar = 94,

		/// <summary>
		/// The onix.
		/// </summary>
		[pbr::OriginalName("ONIX")] Onix = 95,

		/// <summary>
		/// The drowzee.
		/// </summary>
		[pbr::OriginalName("DROWZEE")] Drowzee = 96,

		/// <summary>
		/// The hypno.
		/// </summary>
		[pbr::OriginalName("HYPNO")] Hypno = 97,

		/// <summary>
		/// The krabby.
		/// </summary>
		[pbr::OriginalName("KRABBY")] Krabby = 98,

		/// <summary>
		/// The kingler.
		/// </summary>
		[pbr::OriginalName("KINGLER")] Kingler = 99,

		/// <summary>
		/// The voltorb.
		/// </summary>
		[pbr::OriginalName("VOLTORB")] Voltorb = 100,

		/// <summary>
		/// The electrode.
		/// </summary>
		[pbr::OriginalName("ELECTRODE")] Electrode = 101,

		/// <summary>
		/// The exeggcute.
		/// </summary>
		[pbr::OriginalName("EXEGGCUTE")] Exeggcute = 102,

		/// <summary>
		/// The exeggutor.
		/// </summary>
		[pbr::OriginalName("EXEGGUTOR")] Exeggutor = 103,

		/// <summary>
		/// The cubone.
		/// </summary>
		[pbr::OriginalName("CUBONE")] Cubone = 104,

		/// <summary>
		/// The marowak.
		/// </summary>
		[pbr::OriginalName("MAROWAK")] Marowak = 105,

		/// <summary>
		/// The hitmonlee.
		/// </summary>
		[pbr::OriginalName("HITMONLEE")] Hitmonlee = 106,

		/// <summary>
		/// The hitmonchan.
		/// </summary>
		[pbr::OriginalName("HITMONCHAN")] Hitmonchan = 107,

		/// <summary>
		/// The lickitung.
		/// </summary>
		[pbr::OriginalName("LICKITUNG")] Lickitung = 108,

		/// <summary>
		/// The koffing.
		/// </summary>
		[pbr::OriginalName("KOFFING")] Koffing = 109,

		/// <summary>
		/// The weezing.
		/// </summary>
		[pbr::OriginalName("WEEZING")] Weezing = 110,

		/// <summary>
		/// The rhyhorn.
		/// </summary>
		[pbr::OriginalName("RHYHORN")] Rhyhorn = 111,

		/// <summary>
		/// The rhydon.
		/// </summary>
		[pbr::OriginalName("RHYDON")] Rhydon = 112,

		/// <summary>
		/// The chansey.
		/// </summary>
		[pbr::OriginalName("CHANSEY")] Chansey = 113,

		/// <summary>
		/// The tangela.
		/// </summary>
		[pbr::OriginalName("TANGELA")] Tangela = 114,

		/// <summary>
		/// The kangaskhan.
		/// </summary>
		[pbr::OriginalName("KANGASKHAN")] Kangaskhan = 115,

		/// <summary>
		/// The horsea.
		/// </summary>
		[pbr::OriginalName("HORSEA")] Horsea = 116,

		/// <summary>
		/// The seadra.
		/// </summary>
		[pbr::OriginalName("SEADRA")] Seadra = 117,

		/// <summary>
		/// The goldeen.
		/// </summary>
		[pbr::OriginalName("GOLDEEN")] Goldeen = 118,

		/// <summary>
		/// The seaking.
		/// </summary>
		[pbr::OriginalName("SEAKING")] Seaking = 119,

		/// <summary>
		/// The staryu.
		/// </summary>
		[pbr::OriginalName("STARYU")] Staryu = 120,

		/// <summary>
		/// The starmie.
		/// </summary>
		[pbr::OriginalName("STARMIE")] Starmie = 121,

		/// <summary>
		/// The mr mime.
		/// </summary>
		[pbr::OriginalName("MR_MIME")] MrMime = 122,

		/// <summary>
		/// The scyther.
		/// </summary>
		[pbr::OriginalName("SCYTHER")] Scyther = 123,

		/// <summary>
		/// The jynx.
		/// </summary>
		[pbr::OriginalName("JYNX")] Jynx = 124,

		/// <summary>
		/// The electabuzz.
		/// </summary>
		[pbr::OriginalName("ELECTABUZZ")] Electabuzz = 125,

		/// <summary>
		/// The magmar.
		/// </summary>
		[pbr::OriginalName("MAGMAR")] Magmar = 126,

		/// <summary>
		/// The pinsir.
		/// </summary>
		[pbr::OriginalName("PINSIR")] Pinsir = 127,

		/// <summary>
		/// The tauros.
		/// </summary>
		[pbr::OriginalName("TAUROS")] Tauros = 128,

		/// <summary>
		/// The magikarp.
		/// </summary>
		[pbr::OriginalName("MAGIKARP")] Magikarp = 129,

		/// <summary>
		/// The gyarados.
		/// </summary>
		[pbr::OriginalName("GYARADOS")] Gyarados = 130,

		/// <summary>
		/// The lapras.
		/// </summary>
		[pbr::OriginalName("LAPRAS")] Lapras = 131,

		/// <summary>
		/// The ditto.
		/// </summary>
		[pbr::OriginalName("DITTO")] Ditto = 132,

		/// <summary>
		/// The eevee.
		/// </summary>
		[pbr::OriginalName("EEVEE")] Eevee = 133,

		/// <summary>
		/// The vaporeon.
		/// </summary>
		[pbr::OriginalName("VAPOREON")] Vaporeon = 134,

		/// <summary>
		/// The jolteon.
		/// </summary>
		[pbr::OriginalName("JOLTEON")] Jolteon = 135,

		/// <summary>
		/// The flareon.
		/// </summary>
		[pbr::OriginalName("FLAREON")] Flareon = 136,

		/// <summary>
		/// The porygon.
		/// </summary>
		[pbr::OriginalName("PORYGON")] Porygon = 137,

		/// <summary>
		/// The omanyte.
		/// </summary>
		[pbr::OriginalName("OMANYTE")] Omanyte = 138,

		/// <summary>
		/// The omastar.
		/// </summary>
		[pbr::OriginalName("OMASTAR")] Omastar = 139,

		/// <summary>
		/// The kabuto.
		/// </summary>
		[pbr::OriginalName("KABUTO")] Kabuto = 140,

		/// <summary>
		/// The kabutops.
		/// </summary>
		[pbr::OriginalName("KABUTOPS")] Kabutops = 141,

		/// <summary>
		/// The aerodactyl.
		/// </summary>
		[pbr::OriginalName("AERODACTYL")] Aerodactyl = 142,

		/// <summary>
		/// The snorlax.
		/// </summary>
		[pbr::OriginalName("SNORLAX")] Snorlax = 143,

		/// <summary>
		/// The articuno.
		/// </summary>
		[pbr::OriginalName("ARTICUNO")] Articuno = 144,

		/// <summary>
		/// The zapdos.
		/// </summary>
		[pbr::OriginalName("ZAPDOS")] Zapdos = 145,

		/// <summary>
		/// The moltres.
		/// </summary>
		[pbr::OriginalName("MOLTRES")] Moltres = 146,

		/// <summary>
		/// The dratini.
		/// </summary>
		[pbr::OriginalName("DRATINI")] Dratini = 147,

		/// <summary>
		/// The dragonair.
		/// </summary>
		[pbr::OriginalName("DRAGONAIR")] Dragonair = 148,

		/// <summary>
		/// The dragonite.
		/// </summary>
		[pbr::OriginalName("DRAGONITE")] Dragonite = 149,

		/// <summary>
		/// The mewtwo.
		/// </summary>
		[pbr::OriginalName("MEWTWO")] Mewtwo = 150,

		/// <summary>
		/// The mew.
		/// </summary>
		[pbr::OriginalName("MEW")] Mew = 151,
	}

	#endregion
}

#endregion Designer generated code