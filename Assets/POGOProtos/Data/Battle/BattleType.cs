// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BattleType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Battle/BattleType.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Battle/BattleType.proto</summary>
	public static partial class BattleTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Battle/BattleType.proto</summary>
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
		/// Initializes static members of the <see cref="BattleTypeReflection"/> class.
		/// </summary>
		static BattleTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CidQT0dPUHJvdG9zL0RhdGEvQmF0dGxlL0JhdHRsZVR5cGUucHJvdG8SFlBP",
						"R09Qcm90b3MuRGF0YS5CYXR0bGUqPQoKQmF0dGxlVHlwZRIVChFCQVRUTEVf",
						"VFlQRV9VTlNFVBAAEgoKBk5PUk1BTBABEgwKCFRSQUlOSU5HEAJiBnByb3Rv",
						"Mw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Data.Battle.BattleType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The battle type.
	/// </summary>
	public enum BattleType
	{
		/// <summary>
		/// The unset.
		/// </summary>
		[pbr::OriginalName("BATTLE_TYPE_UNSET")] Unset = 0,

		/// <summary>
		/// The normal.
		/// </summary>
		[pbr::OriginalName("NORMAL")] Normal = 1,

		/// <summary>
		/// The training.
		/// </summary>
		[pbr::OriginalName("TRAINING")] Training = 2,
	}

	#endregion
}

#endregion Designer generated code