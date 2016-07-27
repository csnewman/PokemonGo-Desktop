// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EncounterSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/EncounterSettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/EncounterSettings.proto</summary>
	public static partial class EncounterSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/EncounterSettings.proto</summary>
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
		/// Initializes static members of the <see cref="EncounterSettingsReflection"/> class.
		/// </summary>
		static EncounterSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjJQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9FbmNvdW50ZXJTZXR0aW5n",
						"cy5wcm90bxIaUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIirgEKEUVuY291",
						"bnRlclNldHRpbmdzEhwKFHNwaW5fYm9udXNfdGhyZXNob2xkGAEgASgCEiEK",
						"GWV4Y2VsbGVudF90aHJvd190aHJlc2hvbGQYAiABKAISHQoVZ3JlYXRfdGhy",
						"b3dfdGhyZXNob2xkGAMgASgCEhwKFG5pY2VfdGhyb3dfdGhyZXNob2xkGAQg",
						"ASgCEhsKE21pbGVzdG9uZV90aHJlc2hvbGQYBSABKAViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.EncounterSettings),
							global::POGOProtos.Settings.Master.EncounterSettings.Parser,
							new[]
							{
								"SpinBonusThreshold", "ExcellentThrowThreshold", "GreatThrowThreshold", "NiceThrowThreshold",
								"MilestoneThreshold"
							},
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The encounter settings.
	/// </summary>
	public sealed partial class EncounterSettings : pb::IMessage<EncounterSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "spin_bonus_threshold" field.</summary>
		public const int SpinBonusThresholdFieldNumber = 1;

		/// <summary>Field number for the "excellent_throw_threshold" field.</summary>
		public const int ExcellentThrowThresholdFieldNumber = 2;

		/// <summary>Field number for the "great_throw_threshold" field.</summary>
		public const int GreatThrowThresholdFieldNumber = 3;

		/// <summary>Field number for the "nice_throw_threshold" field.</summary>
		public const int NiceThrowThresholdFieldNumber = 4;

		/// <summary>Field number for the "milestone_threshold" field.</summary>
		public const int MilestoneThresholdFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EncounterSettings> _parser =
			new pb::MessageParser<EncounterSettings>(() => new EncounterSettings());

		#endregion

		#region  Fields

		/// <summary>
		/// The excellent throw threshold_.
		/// </summary>
		private float excellentThrowThreshold_;

		/// <summary>
		/// The great throw threshold_.
		/// </summary>
		private float greatThrowThreshold_;

		/// <summary>
		/// The milestone threshold_.
		/// </summary>
		private int milestoneThreshold_;

		/// <summary>
		/// The nice throw threshold_.
		/// </summary>
		private float niceThrowThreshold_;

		/// <summary>
		/// The spin bonus threshold_.
		/// </summary>
		private float spinBonusThreshold_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EncounterSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EncounterSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterSettings(EncounterSettings other) : this()
		{
			spinBonusThreshold_ = other.spinBonusThreshold_;
			excellentThrowThreshold_ = other.excellentThrowThreshold_;
			greatThrowThreshold_ = other.greatThrowThreshold_;
			niceThrowThreshold_ = other.niceThrowThreshold_;
			milestoneThreshold_ = other.milestoneThreshold_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EncounterSettings> Parser
		{
			get
			{
				return _parser;
			}
		}

		/// <summary>
		/// Gets the descriptor.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pbr.MessageDescriptor Descriptor
		{
			get
			{
				return global::POGOProtos.Settings.Master.EncounterSettingsReflection.Descriptor.MessageTypes[0];
			}
		}

		/// <summary>
		/// Gets the descriptor.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		pbr.MessageDescriptor pb::IMessage.Descriptor
		{
			get
			{
				return Descriptor;
			}
		}

		/// <summary>
		/// Gets or sets the spin bonus threshold.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float SpinBonusThreshold
		{
			get
			{
				return spinBonusThreshold_;
			}

			set
			{
				spinBonusThreshold_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the excellent throw threshold.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float ExcellentThrowThreshold
		{
			get
			{
				return excellentThrowThreshold_;
			}

			set
			{
				excellentThrowThreshold_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the great throw threshold.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float GreatThrowThreshold
		{
			get
			{
				return greatThrowThreshold_;
			}

			set
			{
				greatThrowThreshold_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the nice throw threshold.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float NiceThrowThreshold
		{
			get
			{
				return niceThrowThreshold_;
			}

			set
			{
				niceThrowThreshold_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the milestone threshold.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MilestoneThreshold
		{
			get
			{
				return milestoneThreshold_;
			}

			set
			{
				milestoneThreshold_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="EncounterSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EncounterSettings Clone()
		{
			return new EncounterSettings(this);
		}

		/// <summary>
		/// The equals.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		/// <returns>
		/// The <see cref="bool"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool Equals(EncounterSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (SpinBonusThreshold != other.SpinBonusThreshold)
			{
				return false;
			}

			if (ExcellentThrowThreshold != other.ExcellentThrowThreshold)
			{
				return false;
			}

			if (GreatThrowThreshold != other.GreatThrowThreshold)
			{
				return false;
			}

			if (NiceThrowThreshold != other.NiceThrowThreshold)
			{
				return false;
			}

			if (MilestoneThreshold != other.MilestoneThreshold)
			{
				return false;
			}

			return true;
		}

		/// <summary>
		/// The write to.
		/// </summary>
		/// <param name="output">
		/// The output.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void WriteTo(pb.CodedOutputStream output)
		{
			if (SpinBonusThreshold != 0F)
			{
				output.WriteRawTag(13);
				output.WriteFloat(SpinBonusThreshold);
			}

			if (ExcellentThrowThreshold != 0F)
			{
				output.WriteRawTag(21);
				output.WriteFloat(ExcellentThrowThreshold);
			}

			if (GreatThrowThreshold != 0F)
			{
				output.WriteRawTag(29);
				output.WriteFloat(GreatThrowThreshold);
			}

			if (NiceThrowThreshold != 0F)
			{
				output.WriteRawTag(37);
				output.WriteFloat(NiceThrowThreshold);
			}

			if (MilestoneThreshold != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(MilestoneThreshold);
			}
		}

		/// <summary>
		/// The calculate size.
		/// </summary>
		/// <returns>
		/// The <see cref="int"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int CalculateSize()
		{
			int size = 0;
			if (SpinBonusThreshold != 0F)
			{
				size += 1 + 4;
			}

			if (ExcellentThrowThreshold != 0F)
			{
				size += 1 + 4;
			}

			if (GreatThrowThreshold != 0F)
			{
				size += 1 + 4;
			}

			if (NiceThrowThreshold != 0F)
			{
				size += 1 + 4;
			}

			if (MilestoneThreshold != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MilestoneThreshold);
			}

			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(EncounterSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.SpinBonusThreshold != 0F)
			{
				SpinBonusThreshold = other.SpinBonusThreshold;
			}

			if (other.ExcellentThrowThreshold != 0F)
			{
				ExcellentThrowThreshold = other.ExcellentThrowThreshold;
			}

			if (other.GreatThrowThreshold != 0F)
			{
				GreatThrowThreshold = other.GreatThrowThreshold;
			}

			if (other.NiceThrowThreshold != 0F)
			{
				NiceThrowThreshold = other.NiceThrowThreshold;
			}

			if (other.MilestoneThreshold != 0)
			{
				MilestoneThreshold = other.MilestoneThreshold;
			}
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="input">
		/// The input.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(pb.CodedInputStream input)
		{
			uint tag;
			while ((tag = input.ReadTag()) != 0)
			{
				switch (tag)
				{
					default:
						input.SkipLastField();
						break;
					case 13:
					{
						SpinBonusThreshold = input.ReadFloat();
						break;
					}

					case 21:
					{
						ExcellentThrowThreshold = input.ReadFloat();
						break;
					}

					case 29:
					{
						GreatThrowThreshold = input.ReadFloat();
						break;
					}

					case 37:
					{
						NiceThrowThreshold = input.ReadFloat();
						break;
					}

					case 40:
					{
						MilestoneThreshold = input.ReadInt32();
						break;
					}
				}
			}
		}

		#endregion

		#region  Methods - Public

		/// <summary>
		/// The equals.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		/// <returns>
		/// The <see cref="bool"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public override bool Equals(object other)
		{
			return Equals(other as EncounterSettings);
		}

		/// <summary>
		/// The get hash code.
		/// </summary>
		/// <returns>
		/// The <see cref="int"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public override int GetHashCode()
		{
			int hash = 1;
			if (SpinBonusThreshold != 0F)
			{
				hash ^= SpinBonusThreshold.GetHashCode();
			}

			if (ExcellentThrowThreshold != 0F)
			{
				hash ^= ExcellentThrowThreshold.GetHashCode();
			}

			if (GreatThrowThreshold != 0F)
			{
				hash ^= GreatThrowThreshold.GetHashCode();
			}

			if (NiceThrowThreshold != 0F)
			{
				hash ^= NiceThrowThreshold.GetHashCode();
			}

			if (MilestoneThreshold != 0)
			{
				hash ^= MilestoneThreshold.GetHashCode();
			}

			return hash;
		}

		/// <summary>
		/// The to string.
		/// </summary>
		/// <returns>
		/// The <see cref="string"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public override string ToString()
		{
			return pb::JsonFormatter.ToDiagnosticString(this);
		}

		#endregion

		#region  Methods - Private

		/// <summary>
		/// The on construction.
		/// </summary>
		partial void OnConstruction();

		#endregion
	}

	#endregion
}

#endregion Designer generated code