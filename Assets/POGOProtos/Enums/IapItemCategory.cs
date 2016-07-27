// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IapItemCategory.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/IapItemCategory.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/IapItemCategory.proto</summary>
	public static partial class IapItemCategoryReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/IapItemCategory.proto</summary>
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
		/// Initializes static members of the <see cref="IapItemCategoryReflection"/> class.
		/// </summary>
		static IapItemCategoryReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiZQT0dPUHJvdG9zL0VudW1zL0lhcEl0ZW1DYXRlZ29yeS5wcm90bxIQUE9H",
						"T1Byb3Rvcy5FbnVtcyqUAQoTSG9sb0lhcEl0ZW1DYXRlZ29yeRIVChFJQVBf",
						"Q0FURUdPUllfTk9ORRAAEhcKE0lBUF9DQVRFR09SWV9CVU5ETEUQARIWChJJ",
						"QVBfQ0FURUdPUllfSVRFTVMQAhIZChVJQVBfQ0FURUdPUllfVVBHUkFERVMQ",
						"AxIaChZJQVBfQ0FURUdPUllfUE9LRUNPSU5TEARiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.HoloIapItemCategory), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The holo iap item category.
	/// </summary>
	public enum HoloIapItemCategory
	{
		/// <summary>
		/// The iap category none.
		/// </summary>
		[pbr::OriginalName("IAP_CATEGORY_NONE")] IapCategoryNone = 0,

		/// <summary>
		/// The iap category bundle.
		/// </summary>
		[pbr::OriginalName("IAP_CATEGORY_BUNDLE")] IapCategoryBundle = 1,

		/// <summary>
		/// The iap category items.
		/// </summary>
		[pbr::OriginalName("IAP_CATEGORY_ITEMS")] IapCategoryItems = 2,

		/// <summary>
		/// The iap category upgrades.
		/// </summary>
		[pbr::OriginalName("IAP_CATEGORY_UPGRADES")] IapCategoryUpgrades = 3,

		/// <summary>
		/// The iap category pokecoins.
		/// </summary>
		[pbr::OriginalName("IAP_CATEGORY_POKECOINS")] IapCategoryPokecoins = 4,
	}

	#endregion
}

#endregion Designer generated code