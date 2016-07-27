// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EggIncubatorType.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Inventory/EggIncubatorType.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Inventory
{
	/// <summary>Holder for reflection information generated from POGOProtos/Inventory/EggIncubatorType.proto</summary>
	public static partial class EggIncubatorTypeReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Inventory/EggIncubatorType.proto</summary>
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
		/// Initializes static members of the <see cref="EggIncubatorTypeReflection"/> class.
		/// </summary>
		static EggIncubatorTypeReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CitQT0dPUHJvdG9zL0ludmVudG9yeS9FZ2dJbmN1YmF0b3JUeXBlLnByb3Rv",
						"EhRQT0dPUHJvdG9zLkludmVudG9yeSo/ChBFZ2dJbmN1YmF0b3JUeXBlEhMK",
						"D0lOQ1VCQVRPUl9VTlNFVBAAEhYKEklOQ1VCQVRPUl9ESVNUQU5DRRABYgZw",
						"cm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Inventory.EggIncubatorType), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The egg incubator type.
	/// </summary>
	public enum EggIncubatorType
	{
		/// <summary>
		/// The incubator unset.
		/// </summary>
		[pbr::OriginalName("INCUBATOR_UNSET")] IncubatorUnset = 0,

		/// <summary>
		/// The incubator distance.
		/// </summary>
		[pbr::OriginalName("INCUBATOR_DISTANCE")] IncubatorDistance = 1,
	}

	#endregion
}

#endregion Designer generated code