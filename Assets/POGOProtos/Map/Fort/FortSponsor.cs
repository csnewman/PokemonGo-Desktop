// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortSponsor.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/Fort/FortSponsor.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Map.Fort
{
	/// <summary>Holder for reflection information generated from POGOProtos/Map/Fort/FortSponsor.proto</summary>
	public static partial class FortSponsorReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/Fort/FortSponsor.proto</summary>
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
		/// Initializes static members of the <see cref="FortSponsorReflection"/> class.
		/// </summary>
		static FortSponsorReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiVQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnRTcG9uc29yLnByb3RvEhNQT0dP",
						"UHJvdG9zLk1hcC5Gb3J0KkIKC0ZvcnRTcG9uc29yEhEKDVVOU0VUX1NQT05T",
						"T1IQABINCglNQ0RPTkFMRFMQARIRCg1QT0tFTU9OX1NUT1JFEAJiBnByb3Rv",
						"Mw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Map.Fort.FortSponsor), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The fort sponsor.
	/// </summary>
	public enum FortSponsor
	{
		/// <summary>
		/// The unset sponsor.
		/// </summary>
		[pbr::OriginalName("UNSET_SPONSOR")] UnsetSponsor = 0,

		/// <summary>
		/// The mcdonalds.
		/// </summary>
		[pbr::OriginalName("MCDONALDS")] Mcdonalds = 1,

		/// <summary>
		/// The pokemon store.
		/// </summary>
		[pbr::OriginalName("POKEMON_STORE")] PokemonStore = 2,
	}

	#endregion
}

#endregion Designer generated code