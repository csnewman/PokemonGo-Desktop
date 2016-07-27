// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Platform.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/Platform.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/Platform.proto</summary>
	public static partial class PlatformReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/Platform.proto</summary>
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
		/// Initializes static members of the <see cref="PlatformReflection"/> class.
		/// </summary>
		static PlatformReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ch9QT0dPUHJvdG9zL0VudW1zL1BsYXRmb3JtLnByb3RvEhBQT0dPUHJvdG9z",
						"LkVudW1zKkEKCFBsYXRmb3JtEgkKBVVOU0VUEAASBwoDSU9TEAESCwoHQU5E",
						"Uk9JRBACEgcKA09TWBADEgsKB1dJTkRPV1MQBGIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.Platform), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The platform.
	/// </summary>
	public enum Platform
	{
		/// <summary>
		/// The unset.
		/// </summary>
		[pbr::OriginalName("UNSET")] Unset = 0,

		/// <summary>
		/// The ios.
		/// </summary>
		[pbr::OriginalName("IOS")] Ios = 1,

		/// <summary>
		/// The android.
		/// </summary>
		[pbr::OriginalName("ANDROID")] Android = 2,

		/// <summary>
		/// The osx.
		/// </summary>
		[pbr::OriginalName("OSX")] Osx = 3,

		/// <summary>
		/// The windows.
		/// </summary>
		[pbr::OriginalName("WINDOWS")] Windows = 4,
	}

	#endregion
}

#endregion Designer generated code