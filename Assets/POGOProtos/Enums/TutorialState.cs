// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TutorialState.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/TutorialState.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/TutorialState.proto</summary>
	public static partial class TutorialStateReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/TutorialState.proto</summary>
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
		/// Initializes static members of the <see cref="TutorialStateReflection"/> class.
		/// </summary>
		static TutorialStateReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiRQT0dPUHJvdG9zL0VudW1zL1R1dG9yaWFsU3RhdGUucHJvdG8SEFBPR09Q",
						"cm90b3MuRW51bXMq5AEKDVR1dG9yaWFsU3RhdGUSEAoMTEVHQUxfU0NSRUVO",
						"EAASFAoQQVZBVEFSX1NFTEVDVElPThABEhQKEEFDQ09VTlRfQ1JFQVRJT04Q",
						"AhITCg9QT0tFTU9OX0NBUFRVUkUQAxISCg5OQU1FX1NFTEVDVElPThAEEhEK",
						"DVBPS0VNT05fQkVSUlkQBRIMCghVU0VfSVRFTRAGEiIKHkZJUlNUX1RJTUVf",
						"RVhQRVJJRU5DRV9DT01QTEVURRAHEhUKEVBPS0VTVE9QX1RVVE9SSUFMEAgS",
						"EAoMR1lNX1RVVE9SSUFMEAliBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.TutorialState), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The tutorial state.
	/// </summary>
	public enum TutorialState
	{
		/// <summary>
		/// The legal screen.
		/// </summary>
		[pbr::OriginalName("LEGAL_SCREEN")] LegalScreen = 0,

		/// <summary>
		/// The avatar selection.
		/// </summary>
		[pbr::OriginalName("AVATAR_SELECTION")] AvatarSelection = 1,

		/// <summary>
		/// The account creation.
		/// </summary>
		[pbr::OriginalName("ACCOUNT_CREATION")] AccountCreation = 2,

		/// <summary>
		/// The pokemon capture.
		/// </summary>
		[pbr::OriginalName("POKEMON_CAPTURE")] PokemonCapture = 3,

		/// <summary>
		/// The name selection.
		/// </summary>
		[pbr::OriginalName("NAME_SELECTION")] NameSelection = 4,

		/// <summary>
		/// The pokemon berry.
		/// </summary>
		[pbr::OriginalName("POKEMON_BERRY")] PokemonBerry = 5,

		/// <summary>
		/// The use item.
		/// </summary>
		[pbr::OriginalName("USE_ITEM")] UseItem = 6,

		/// <summary>
		/// The first time experience complete.
		/// </summary>
		[pbr::OriginalName("FIRST_TIME_EXPERIENCE_COMPLETE")] FirstTimeExperienceComplete = 7,

		/// <summary>
		/// The pokestop tutorial.
		/// </summary>
		[pbr::OriginalName("POKESTOP_TUTORIAL")] PokestopTutorial = 8,

		/// <summary>
		/// The gym tutorial.
		/// </summary>
		[pbr::OriginalName("GYM_TUTORIAL")] GymTutorial = 9,
	}

	#endregion
}

#endregion Designer generated code