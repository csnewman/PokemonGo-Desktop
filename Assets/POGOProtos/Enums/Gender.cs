// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gender.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/Gender.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/Gender.proto</summary>
	public static partial class GenderReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/Gender.proto</summary>
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
		/// Initializes static members of the <see cref="GenderReflection"/> class.
		/// </summary>
		static GenderReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ch1QT0dPUHJvdG9zL0VudW1zL0dlbmRlci5wcm90bxIQUE9HT1Byb3Rvcy5F",
						"bnVtcyoeCgZHZW5kZXISCAoETUFMRRAAEgoKBkZFTUFMRRABYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.Gender), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The gender.
	/// </summary>
	public enum Gender
	{
		/// <summary>
		/// The male.
		/// </summary>
		[pbr::OriginalName("MALE")] Male = 0,

		/// <summary>
		/// The female.
		/// </summary>
		[pbr::OriginalName("FEMALE")] Female = 1,
	}

	#endregion
}

#endregion Designer generated code