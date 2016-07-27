// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortRenderingType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/Fort/FortRenderingType.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Map/Fort/FortRenderingType.proto</summary>
	public static partial class FortRenderingTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/Fort/FortRenderingType.proto</summary>
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
		/// Initializes static members of the <see cref="FortRenderingTypeReflection"/> class.
		/// </summary>
		static FortRenderingTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CitQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnRSZW5kZXJpbmdUeXBlLnByb3Rv",
						"EhNQT0dPUHJvdG9zLk1hcC5Gb3J0KjMKEUZvcnRSZW5kZXJpbmdUeXBlEgsK",
						"B0RFRkFVTFQQABIRCg1JTlRFUk5BTF9URVNUEAFiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Map.Fort.FortRenderingType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The fort rendering type.
	/// </summary>
	public enum FortRenderingType
	{
		/// <summary>
		/// The default.
		/// </summary>
		[pbr::OriginalName("DEFAULT")] Default = 0,

		/// <summary>
		/// The internal test.
		/// </summary>
		[pbr::OriginalName("INTERNAL_TEST")] InternalTest = 1,
	}

	#endregion
}

#endregion Designer generated code