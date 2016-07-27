// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokemonType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/PokemonType.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/PokemonType.proto</summary>
	public static partial class PokemonTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/PokemonType.proto</summary>
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
		/// Initializes static members of the <see cref="PokemonTypeReflection"/> class.
		/// </summary>
		static PokemonTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiJQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25UeXBlLnByb3RvEhBQT0dPUHJv",
						"dG9zLkVudW1zKtoDCgtQb2tlbW9uVHlwZRIVChFQT0tFTU9OX1RZUEVfTk9O",
						"RRAAEhcKE1BPS0VNT05fVFlQRV9OT1JNQUwQARIZChVQT0tFTU9OX1RZUEVf",
						"RklHSFRJTkcQAhIXChNQT0tFTU9OX1RZUEVfRkxZSU5HEAMSFwoTUE9LRU1P",
						"Tl9UWVBFX1BPSVNPThAEEhcKE1BPS0VNT05fVFlQRV9HUk9VTkQQBRIVChFQ",
						"T0tFTU9OX1RZUEVfUk9DSxAGEhQKEFBPS0VNT05fVFlQRV9CVUcQBxIWChJQ",
						"T0tFTU9OX1RZUEVfR0hPU1QQCBIWChJQT0tFTU9OX1RZUEVfU1RFRUwQCRIV",
						"ChFQT0tFTU9OX1RZUEVfRklSRRAKEhYKElBPS0VNT05fVFlQRV9XQVRFUhAL",
						"EhYKElBPS0VNT05fVFlQRV9HUkFTUxAMEhkKFVBPS0VNT05fVFlQRV9FTEVD",
						"VFJJQxANEhgKFFBPS0VNT05fVFlQRV9QU1lDSElDEA4SFAoQUE9LRU1PTl9U",
						"WVBFX0lDRRAPEhcKE1BPS0VNT05fVFlQRV9EUkFHT04QEBIVChFQT0tFTU9O",
						"X1RZUEVfREFSSxAREhYKElBPS0VNT05fVFlQRV9GQUlSWRASYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.PokemonType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The pokemon type.
	/// </summary>
	public enum PokemonType
	{
		/// <summary>
		/// The none.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_NONE")] None = 0,

		/// <summary>
		/// The normal.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_NORMAL")] Normal = 1,

		/// <summary>
		/// The fighting.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_FIGHTING")] Fighting = 2,

		/// <summary>
		/// The flying.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_FLYING")] Flying = 3,

		/// <summary>
		/// The poison.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_POISON")] Poison = 4,

		/// <summary>
		/// The ground.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_GROUND")] Ground = 5,

		/// <summary>
		/// The rock.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_ROCK")] Rock = 6,

		/// <summary>
		/// The bug.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_BUG")] Bug = 7,

		/// <summary>
		/// The ghost.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_GHOST")] Ghost = 8,

		/// <summary>
		/// The steel.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_STEEL")] Steel = 9,

		/// <summary>
		/// The fire.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_FIRE")] Fire = 10,

		/// <summary>
		/// The water.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_WATER")] Water = 11,

		/// <summary>
		/// The grass.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_GRASS")] Grass = 12,

		/// <summary>
		/// The electric.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_ELECTRIC")] Electric = 13,

		/// <summary>
		/// The psychic.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_PSYCHIC")] Psychic = 14,

		/// <summary>
		/// The ice.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_ICE")] Ice = 15,

		/// <summary>
		/// The dragon.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_DRAGON")] Dragon = 16,

		/// <summary>
		/// The dark.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_DARK")] Dark = 17,

		/// <summary>
		/// The fairy.
		/// </summary>
		[pbr::OriginalName("POKEMON_TYPE_FAIRY")] Fairy = 18,
	}

	#endregion
}

#endregion Designer generated code