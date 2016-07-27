// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BattleState.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Battle/BattleState.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleState.proto</summary>
	public static partial class BattleStateReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Battle/BattleState.proto</summary>
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
		/// Initializes static members of the <see cref="BattleStateReflection"/> class.
		/// </summary>
		static BattleStateReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CihQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZVN0YXRlLnByb3RvEhZQ",
						"T0dPUHJvdG9zLkRhdGEuQmF0dGxlKlQKC0JhdHRsZVN0YXRlEg8KC1NUQVRF",
						"X1VOU0VUEAASCgoGQUNUSVZFEAESCwoHVklDVE9SWRACEgwKCERFRkVBVEVE",
						"EAMSDQoJVElNRURfT1VUEARiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Data.Battle.BattleState), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The battle state.
	/// </summary>
	public enum BattleState
	{
		/// <summary>
		/// The state unset.
		/// </summary>
		[pbr::OriginalName("STATE_UNSET")] StateUnset = 0,

		/// <summary>
		/// The active.
		/// </summary>
		[pbr::OriginalName("ACTIVE")] Active = 1,

		/// <summary>
		/// The victory.
		/// </summary>
		[pbr::OriginalName("VICTORY")] Victory = 2,

		/// <summary>
		/// The defeated.
		/// </summary>
		[pbr::OriginalName("DEFEATED")] Defeated = 3,

		/// <summary>
		/// The timed out.
		/// </summary>
		[pbr::OriginalName("TIMED_OUT")] TimedOut = 4,
	}

	#endregion
}

#endregion Designer generated code