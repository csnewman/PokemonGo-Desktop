// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BattleActionType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Battle/BattleActionType.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Battle
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleActionType.proto</summary>
	public static partial class BattleActionTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Battle/BattleActionType.proto</summary>
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
		/// Initializes static members of the <see cref="BattleActionTypeReflection"/> class.
		/// </summary>
		static BattleActionTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ci1QT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZUFjdGlvblR5cGUucHJv",
						"dG8SFlBPR09Qcm90b3MuRGF0YS5CYXR0bGUq/AEKEEJhdHRsZUFjdGlvblR5",
						"cGUSEAoMQUNUSU9OX1VOU0VUEAASEQoNQUNUSU9OX0FUVEFDSxABEhAKDEFD",
						"VElPTl9ET0RHRRACEhkKFUFDVElPTl9TUEVDSUFMX0FUVEFDSxADEhcKE0FD",
						"VElPTl9TV0FQX1BPS0VNT04QBBIQCgxBQ1RJT05fRkFJTlQQBRIWChJBQ1RJ",
						"T05fUExBWUVSX0pPSU4QBhIWChJBQ1RJT05fUExBWUVSX1FVSVQQBxISCg5B",
						"Q1RJT05fVklDVE9SWRAIEhEKDUFDVElPTl9ERUZFQVQQCRIUChBBQ1RJT05f",
						"VElNRURfT1VUEApiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Data.Battle.BattleActionType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The battle action type.
	/// </summary>
	public enum BattleActionType
	{
		/// <summary>
		/// The action unset.
		/// </summary>
		[pbr::OriginalName("ACTION_UNSET")] ActionUnset = 0,

		/// <summary>
		/// The action attack.
		/// </summary>
		[pbr::OriginalName("ACTION_ATTACK")] ActionAttack = 1,

		/// <summary>
		/// The action dodge.
		/// </summary>
		[pbr::OriginalName("ACTION_DODGE")] ActionDodge = 2,

		/// <summary>
		/// The action special attack.
		/// </summary>
		[pbr::OriginalName("ACTION_SPECIAL_ATTACK")] ActionSpecialAttack = 3,

		/// <summary>
		/// The action swap pokemon.
		/// </summary>
		[pbr::OriginalName("ACTION_SWAP_POKEMON")] ActionSwapPokemon = 4,

		/// <summary>
		/// The action faint.
		/// </summary>
		[pbr::OriginalName("ACTION_FAINT")] ActionFaint = 5,

		/// <summary>
		/// The action player join.
		/// </summary>
		[pbr::OriginalName("ACTION_PLAYER_JOIN")] ActionPlayerJoin = 6,

		/// <summary>
		/// The action player quit.
		/// </summary>
		[pbr::OriginalName("ACTION_PLAYER_QUIT")] ActionPlayerQuit = 7,

		/// <summary>
		/// The action victory.
		/// </summary>
		[pbr::OriginalName("ACTION_VICTORY")] ActionVictory = 8,

		/// <summary>
		/// The action defeat.
		/// </summary>
		[pbr::OriginalName("ACTION_DEFEAT")] ActionDefeat = 9,

		/// <summary>
		/// The action timed out.
		/// </summary>
		[pbr::OriginalName("ACTION_TIMED_OUT")] ActionTimedOut = 10,
	}

	#endregion
}

#endregion Designer generated code