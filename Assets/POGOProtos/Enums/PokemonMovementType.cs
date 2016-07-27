// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PokemonMovementType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/PokemonMovementType.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/PokemonMovementType.proto</summary>
	public static partial class PokemonMovementTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/PokemonMovementType.proto</summary>
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
		/// Initializes static members of the <see cref="PokemonMovementTypeReflection"/> class.
		/// </summary>
		static PokemonMovementTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CipQT0dPUHJvdG9zL0VudW1zL1Bva2Vtb25Nb3ZlbWVudFR5cGUucHJvdG8S",
						"EFBPR09Qcm90b3MuRW51bXMqrQEKE1Bva2Vtb25Nb3ZlbWVudFR5cGUSEwoP",
						"TU9WRU1FTlRfU1RBVElDEAASEQoNTU9WRU1FTlRfSlVNUBABEhUKEU1PVkVN",
						"RU5UX1ZFUlRJQ0FMEAISFAoQTU9WRU1FTlRfUFNZQ0hJQxADEhUKEU1PVkVN",
						"RU5UX0VMRUNUUklDEAQSEwoPTU9WRU1FTlRfRkxZSU5HEAUSFQoRTU9WRU1F",
						"TlRfSE9WRVJJTkcQBmIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.PokemonMovementType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The pokemon movement type.
	/// </summary>
	public enum PokemonMovementType
	{
		/// <summary>
		/// The movement static.
		/// </summary>
		[pbr::OriginalName("MOVEMENT_STATIC")] MovementStatic = 0,

		/// <summary>
		/// The movement jump.
		/// </summary>
		[pbr::OriginalName("MOVEMENT_JUMP")] MovementJump = 1,

		/// <summary>
		/// The movement vertical.
		/// </summary>
		[pbr::OriginalName("MOVEMENT_VERTICAL")] MovementVertical = 2,

		/// <summary>
		/// The movement psychic.
		/// </summary>
		[pbr::OriginalName("MOVEMENT_PSYCHIC")] MovementPsychic = 3,

		/// <summary>
		/// The movement electric.
		/// </summary>
		[pbr::OriginalName("MOVEMENT_ELECTRIC")] MovementElectric = 4,

		/// <summary>
		/// The movement flying.
		/// </summary>
		[pbr::OriginalName("MOVEMENT_FLYING")] MovementFlying = 5,

		/// <summary>
		/// The movement hovering.
		/// </summary>
		[pbr::OriginalName("MOVEMENT_HOVERING")] MovementHovering = 6,
	}

	#endregion
}

#endregion Designer generated code