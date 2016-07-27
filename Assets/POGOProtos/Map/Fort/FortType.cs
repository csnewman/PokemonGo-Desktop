// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/Fort/FortType.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Map/Fort/FortType.proto</summary>
	public static partial class FortTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/Fort/FortType.proto</summary>
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
		/// Initializes static members of the <see cref="FortTypeReflection"/> class.
		/// </summary>
		static FortTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiJQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnRUeXBlLnByb3RvEhNQT0dPUHJv",
						"dG9zLk1hcC5Gb3J0KiMKCEZvcnRUeXBlEgcKA0dZTRAAEg4KCkNIRUNLUE9J",
						"TlQQAWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Map.Fort.FortType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The fort type.
	/// </summary>
	public enum FortType
	{
		/// <summary>
		/// The gym.
		/// </summary>
		[pbr::OriginalName("GYM")] Gym = 0,

		/// <summary>
		/// The checkpoint.
		/// </summary>
		[pbr::OriginalName("CHECKPOINT")] Checkpoint = 1,
	}

	#endregion
}

#endregion Designer generated code