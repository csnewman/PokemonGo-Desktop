// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CameraTarget.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/CameraTarget.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/CameraTarget.proto</summary>
	public static partial class CameraTargetReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/CameraTarget.proto</summary>
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
		/// Initializes static members of the <see cref="CameraTargetReflection"/> class.
		/// </summary>
		static CameraTargetReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiNQT0dPUHJvdG9zL0VudW1zL0NhbWVyYVRhcmdldC5wcm90bxIQUE9HT1By",
						"b3Rvcy5FbnVtcyr8AwoMQ2FtZXJhVGFyZ2V0EhcKE0NBTV9UQVJHRVRfQVRU",
						"QUNLRVIQABIcChhDQU1fVEFSR0VUX0FUVEFDS0VSX0VER0UQARIeChpDQU1f",
						"VEFSR0VUX0FUVEFDS0VSX0dST1VORBACEhcKE0NBTV9UQVJHRVRfREVGRU5E",
						"RVIQAxIcChhDQU1fVEFSR0VUX0RFRkVOREVSX0VER0UQBBIeChpDQU1fVEFS",
						"R0VUX0RFRkVOREVSX0dST1VORBAFEiAKHENBTV9UQVJHRVRfQVRUQUNLRVJf",
						"REVGRU5ERVIQBhIlCiFDQU1fVEFSR0VUX0FUVEFDS0VSX0RFRkVOREVSX0VE",
						"R0UQBxIgChxDQU1fVEFSR0VUX0RFRkVOREVSX0FUVEFDS0VSEAgSJQohQ0FN",
						"X1RBUkdFVF9ERUZFTkRFUl9BVFRBQ0tFUl9FREdFEAkSJwojQ0FNX1RBUkdF",
						"VF9BVFRBQ0tFUl9ERUZFTkRFUl9NSVJST1IQCxIpCiVDQU1fVEFSR0VUX1NI",
						"T1VMREVSX0FUVEFDS0VSX0RFRkVOREVSEAwSMAosQ0FNX1RBUkdFVF9TSE9V",
						"TERFUl9BVFRBQ0tFUl9ERUZFTkRFUl9NSVJST1IQDRImCiJDQU1fVEFSR0VU",
						"X0FUVEFDS0VSX0RFRkVOREVSX1dPUkxEEA5iBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.CameraTarget), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The camera target.
	/// </summary>
	public enum CameraTarget
	{
		/// <summary>
		/// The cam target attacker.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_ATTACKER")] CamTargetAttacker = 0,

		/// <summary>
		/// The cam target attacker edge.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_ATTACKER_EDGE")] CamTargetAttackerEdge = 1,

		/// <summary>
		/// The cam target attacker ground.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_ATTACKER_GROUND")] CamTargetAttackerGround = 2,

		/// <summary>
		/// The cam target defender.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_DEFENDER")] CamTargetDefender = 3,

		/// <summary>
		/// The cam target defender edge.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_DEFENDER_EDGE")] CamTargetDefenderEdge = 4,

		/// <summary>
		/// The cam target defender ground.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_DEFENDER_GROUND")] CamTargetDefenderGround = 5,

		/// <summary>
		/// The cam target attacker defender.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_ATTACKER_DEFENDER")] CamTargetAttackerDefender = 6,

		/// <summary>
		/// The cam target attacker defender edge.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_ATTACKER_DEFENDER_EDGE")] CamTargetAttackerDefenderEdge = 7,

		/// <summary>
		/// The cam target defender attacker.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_DEFENDER_ATTACKER")] CamTargetDefenderAttacker = 8,

		/// <summary>
		/// The cam target defender attacker edge.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_DEFENDER_ATTACKER_EDGE")] CamTargetDefenderAttackerEdge = 9,

		/// <summary>
		/// The cam target attacker defender mirror.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_ATTACKER_DEFENDER_MIRROR")] CamTargetAttackerDefenderMirror = 11,

		/// <summary>
		/// The cam target shoulder attacker defender.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_SHOULDER_ATTACKER_DEFENDER")] CamTargetShoulderAttackerDefender = 12,

		/// <summary>
		/// The cam target shoulder attacker defender mirror.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_SHOULDER_ATTACKER_DEFENDER_MIRROR")] CamTargetShoulderAttackerDefenderMirror = 13,

		/// <summary>
		/// The cam target attacker defender world.
		/// </summary>
		[pbr::OriginalName("CAM_TARGET_ATTACKER_DEFENDER_WORLD")] CamTargetAttackerDefenderWorld = 14,
	}

	#endregion
}

#endregion Designer generated code