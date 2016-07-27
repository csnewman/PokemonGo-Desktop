// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CameraInterpolation.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/CameraInterpolation.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/CameraInterpolation.proto</summary>
	public static partial class CameraInterpolationReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/CameraInterpolation.proto</summary>
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
		/// Initializes static members of the <see cref="CameraInterpolationReflection"/> class.
		/// </summary>
		static CameraInterpolationReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CipQT0dPUHJvdG9zL0VudW1zL0NhbWVyYUludGVycG9sYXRpb24ucHJvdG8S",
						"EFBPR09Qcm90b3MuRW51bXMqlgEKE0NhbWVyYUludGVycG9sYXRpb24SEgoO",
						"Q0FNX0lOVEVSUF9DVVQQABIVChFDQU1fSU5URVJQX0xJTkVBUhABEhUKEUNB",
						"TV9JTlRFUlBfU01PT1RIEAISJQohQ0FNX0lOVEVSUF9TTU9PVEhfUk9UX0xJ",
						"TkVBUl9NT1ZFEAMSFgoSQ0FNX0lOVEVSUF9ERVBFTkRTEARiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.CameraInterpolation), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The camera interpolation.
	/// </summary>
	public enum CameraInterpolation
	{
		/// <summary>
		/// The cam interp cut.
		/// </summary>
		[pbr::OriginalName("CAM_INTERP_CUT")] CamInterpCut = 0,

		/// <summary>
		/// The cam interp linear.
		/// </summary>
		[pbr::OriginalName("CAM_INTERP_LINEAR")] CamInterpLinear = 1,

		/// <summary>
		/// The cam interp smooth.
		/// </summary>
		[pbr::OriginalName("CAM_INTERP_SMOOTH")] CamInterpSmooth = 2,

		/// <summary>
		/// The cam interp smooth rot linear move.
		/// </summary>
		[pbr::OriginalName("CAM_INTERP_SMOOTH_ROT_LINEAR_MOVE")] CamInterpSmoothRotLinearMove = 3,

		/// <summary>
		/// The cam interp depends.
		/// </summary>
		[pbr::OriginalName("CAM_INTERP_DEPENDS")] CamInterpDepends = 4,
	}

	#endregion
}

#endregion Designer generated code