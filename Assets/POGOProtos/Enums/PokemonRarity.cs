// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokemonRarity.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/PokemonRarity.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/PokemonRarity.proto</summary>
	public static partial class PokemonRarityReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/PokemonRarity.proto</summary>
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
		/// Initializes static members of the <see cref="PokemonRarityReflection"/> class.
		/// </summary>
		static PokemonRarityReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiRQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25SYXJpdHkucHJvdG8SEFBPR09Q",
						"cm90b3MuRW51bXMqNgoNUG9rZW1vblJhcml0eRIKCgZOT1JNQUwQABINCglM",
						"RUdFTkRBUlkQARIKCgZNWVRISUMQAmIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.PokemonRarity), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The pokemon rarity.
	/// </summary>
	public enum PokemonRarity
	{
		/// <summary>
		/// The normal.
		/// </summary>
		[pbr::OriginalName("NORMAL")] Normal = 0,

		/// <summary>
		/// The legendary.
		/// </summary>
		[pbr::OriginalName("LEGENDARY")] Legendary = 1,

		/// <summary>
		/// The mythic.
		/// </summary>
		[pbr::OriginalName("MYTHIC")] Mythic = 2,
	}

	#endregion
}

#endregion Designer generated code