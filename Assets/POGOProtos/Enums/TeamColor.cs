// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TeamColor.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/TeamColor.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/TeamColor.proto</summary>
	public static partial class TeamColorReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/TeamColor.proto</summary>
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
		/// Initializes static members of the <see cref="TeamColorReflection"/> class.
		/// </summary>
		static TeamColorReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiBQT0dPUHJvdG9zL0VudW1zL1RlYW1Db2xvci5wcm90bxIQUE9HT1Byb3Rv",
						"cy5FbnVtcyo3CglUZWFtQ29sb3ISCwoHTkVVVFJBTBAAEggKBEJMVUUQARIH",
						"CgNSRUQQAhIKCgZZRUxMT1cQA2IGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.TeamColor), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The team color.
	/// </summary>
	public enum TeamColor
	{
		/// <summary>
		/// The neutral.
		/// </summary>
		[pbr::OriginalName("NEUTRAL")] Neutral = 0,

		/// <summary>
		/// The blue.
		/// </summary>
		[pbr::OriginalName("BLUE")] Blue = 1,

		/// <summary>
		/// The red.
		/// </summary>
		[pbr::OriginalName("RED")] Red = 2,

		/// <summary>
		/// The yellow.
		/// </summary>
		[pbr::OriginalName("YELLOW")] Yellow = 3,
	}

	#endregion
}

#endregion Designer generated code