// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ItemEffect.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Enums/ItemEffect.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Enums/ItemEffect.proto</summary>
	public static partial class ItemEffectReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Enums/ItemEffect.proto</summary>
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
		/// Initializes static members of the <see cref="ItemEffectReflection"/> class.
		/// </summary>
		static ItemEffectReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiFQT0dPUHJvdG9zL0VudW1zL0l0ZW1FZmZlY3QucHJvdG8SEFBPR09Qcm90",
						"b3MuRW51bXMqmAQKCkl0ZW1FZmZlY3QSFAoQSVRFTV9FRkZFQ1RfTk9ORRAA",
						"EhwKF0lURU1fRUZGRUNUX0NBUF9OT19GTEVFEOgHEiAKG0lURU1fRUZGRUNU",
						"X0NBUF9OT19NT1ZFTUVOVBDqBxIeChlJVEVNX0VGRkVDVF9DQVBfTk9fVEhS",
						"RUFUEOsHEh8KGklURU1fRUZGRUNUX0NBUF9UQVJHRVRfTUFYEOwHEiAKG0lU",
						"RU1fRUZGRUNUX0NBUF9UQVJHRVRfU0xPVxDtBxIhChxJVEVNX0VGRkVDVF9D",
						"QVBfQ0hBTkNFX05JR0hUEO4HEiMKHklURU1fRUZGRUNUX0NBUF9DSEFOQ0Vf",
						"VFJBSU5FUhDvBxInCiJJVEVNX0VGRkVDVF9DQVBfQ0hBTkNFX0ZJUlNUX1RI",
						"Uk9XEPAHEiIKHUlURU1fRUZGRUNUX0NBUF9DSEFOQ0VfTEVHRU5EEPEHEiEK",
						"HElURU1fRUZGRUNUX0NBUF9DSEFOQ0VfSEVBVlkQ8gcSIgodSVRFTV9FRkZF",
						"Q1RfQ0FQX0NIQU5DRV9SRVBFQVQQ8wcSJwoiSVRFTV9FRkZFQ1RfQ0FQX0NI",
						"QU5DRV9NVUxUSV9USFJPVxD0BxIiCh1JVEVNX0VGRkVDVF9DQVBfQ0hBTkNF",
						"X0FMV0FZUxD1BxIoCiNJVEVNX0VGRkVDVF9DQVBfQ0hBTkNFX1NJTkdMRV9U",
						"SFJPVxD2B2IGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(new[] { typeof(global::POGOProtos.Enums.ItemEffect), }, null));
		}

		#endregion
	}

	#region Enums

	/// <summary>
	/// The item effect.
	/// </summary>
	public enum ItemEffect
	{
		/// <summary>
		/// The none.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_NONE")] None = 0,

		/// <summary>
		/// The cap no flee.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_NO_FLEE")] CapNoFlee = 1000,

		/// <summary>
		/// The cap no movement.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_NO_MOVEMENT")] CapNoMovement = 1002,

		/// <summary>
		/// The cap no threat.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_NO_THREAT")] CapNoThreat = 1003,

		/// <summary>
		/// The cap target max.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_TARGET_MAX")] CapTargetMax = 1004,

		/// <summary>
		/// The cap target slow.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_TARGET_SLOW")] CapTargetSlow = 1005,

		/// <summary>
		/// The cap chance night.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_NIGHT")] CapChanceNight = 1006,

		/// <summary>
		/// The cap chance trainer.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_TRAINER")] CapChanceTrainer = 1007,

		/// <summary>
		/// The cap chance first throw.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_FIRST_THROW")] CapChanceFirstThrow = 1008,

		/// <summary>
		/// The cap chance legend.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_LEGEND")] CapChanceLegend = 1009,

		/// <summary>
		/// The cap chance heavy.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_HEAVY")] CapChanceHeavy = 1010,

		/// <summary>
		/// The cap chance repeat.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_REPEAT")] CapChanceRepeat = 1011,

		/// <summary>
		/// The cap chance multi throw.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_MULTI_THROW")] CapChanceMultiThrow = 1012,

		/// <summary>
		/// The cap chance always.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_ALWAYS")] CapChanceAlways = 1013,

		/// <summary>
		/// The cap chance single throw.
		/// </summary>
		[pbr::OriginalName("ITEM_EFFECT_CAP_CHANCE_SINGLE_THROW")] CapChanceSingleThrow = 1014,
	}

	#endregion
}

#endregion Designer generated code