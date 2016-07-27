// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MapObjectsStatus.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/MapObjectsStatus.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Map
{
	/// <summary>Holder for reflection information generated from POGOProtos/Map/MapObjectsStatus.proto</summary>
	public static partial class MapObjectsStatusReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/MapObjectsStatus.proto</summary>
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
		/// Initializes static members of the <see cref="MapObjectsStatusReflection"/> class.
		/// </summary>
		static MapObjectsStatusReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiVQT0dPUHJvdG9zL01hcC9NYXBPYmplY3RzU3RhdHVzLnByb3RvEg5QT0dP",
						"UHJvdG9zLk1hcCpFChBNYXBPYmplY3RzU3RhdHVzEhAKDFVOU0VUX1NUQVRV",
						"UxAAEgsKB1NVQ0NFU1MQARISCg5MT0NBVElPTl9VTlNFVBACYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Map.MapObjectsStatus), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The map objects status.
	/// </summary>
	public enum MapObjectsStatus
	{
		/// <summary>
		/// The unset status.
		/// </summary>
		[pbr::OriginalName("UNSET_STATUS")] UnsetStatus = 0,

		/// <summary>
		/// The success.
		/// </summary>
		[pbr::OriginalName("SUCCESS")] Success = 1,

		/// <summary>
		/// The location unset.
		/// </summary>
		[pbr::OriginalName("LOCATION_UNSET")] LocationUnset = 2,
	}

	#endregion
}

#endregion Designer generated code