// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LevelSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/LevelSettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/LevelSettings.proto</summary>
	public static partial class LevelSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/LevelSettings.proto</summary>
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
		/// Initializes static members of the <see cref="LevelSettingsReflection"/> class.
		/// </summary>
		static LevelSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CidQT0dPUHJvdG9zL1NldHRpbmdzL0xldmVsU2V0dGluZ3MucHJvdG8SE1BP",
						"R09Qcm90b3MuU2V0dGluZ3MiUQoNTGV2ZWxTZXR0aW5ncxIbChN0cmFpbmVy",
						"X2NwX21vZGlmaWVyGAIgASgBEiMKG3RyYWluZXJfZGlmZmljdWx0eV9tb2Rp",
						"ZmllchgDIAEoAWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.LevelSettings),
							global::POGOProtos.Settings.LevelSettings.Parser,
							new[] { "TrainerCpModifier", "TrainerDifficultyModifier" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The level settings.
	/// </summary>
	public sealed partial class LevelSettings : pb::IMessage<LevelSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "trainer_cp_modifier" field.</summary>
		public const int TrainerCpModifierFieldNumber = 2;

		/// <summary>Field number for the "trainer_difficulty_modifier" field.</summary>
		public const int TrainerDifficultyModifierFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<LevelSettings> _parser =
			new pb::MessageParser<LevelSettings>(() => new LevelSettings());

		#endregion

		#region  Fields

		/// <summary>
		/// The trainer cp modifier_.
		/// </summary>
		private double trainerCpModifier_;

		/// <summary>
		/// The trainer difficulty modifier_.
		/// </summary>
		private double trainerDifficultyModifier_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="LevelSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public LevelSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="LevelSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public LevelSettings(LevelSettings other) : this()
		{
			trainerCpModifier_ = other.trainerCpModifier_;
			trainerDifficultyModifier_ = other.trainerDifficultyModifier_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<LevelSettings> Parser
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
				return global::POGOProtos.Settings.LevelSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the trainer cp modifier.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double TrainerCpModifier
		{
			get
			{
				return trainerCpModifier_;
			}

			set
			{
				trainerCpModifier_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the trainer difficulty modifier.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double TrainerDifficultyModifier
		{
			get
			{
				return trainerDifficultyModifier_;
			}

			set
			{
				trainerDifficultyModifier_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="LevelSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public LevelSettings Clone()
		{
			return new LevelSettings(this);
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
		public bool Equals(LevelSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (TrainerCpModifier != other.TrainerCpModifier)
			{
				return false;
			}

			if (TrainerDifficultyModifier != other.TrainerDifficultyModifier)
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
			if (TrainerCpModifier != 0D)
			{
				output.WriteRawTag(17);
				output.WriteDouble(TrainerCpModifier);
			}

			if (TrainerDifficultyModifier != 0D)
			{
				output.WriteRawTag(25);
				output.WriteDouble(TrainerDifficultyModifier);
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
			if (TrainerCpModifier != 0D)
			{
				size += 1 + 8;
			}

			if (TrainerDifficultyModifier != 0D)
			{
				size += 1 + 8;
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
		public void MergeFrom(LevelSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.TrainerCpModifier != 0D)
			{
				TrainerCpModifier = other.TrainerCpModifier;
			}

			if (other.TrainerDifficultyModifier != 0D)
			{
				TrainerDifficultyModifier = other.TrainerDifficultyModifier;
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
					case 17:
					{
						TrainerCpModifier = input.ReadDouble();
						break;
					}

					case 25:
					{
						TrainerDifficultyModifier = input.ReadDouble();
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
			return Equals(other as LevelSettings);
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
			if (TrainerCpModifier != 0D)
			{
				hash ^= TrainerCpModifier.GetHashCode();
			}

			if (TrainerDifficultyModifier != 0D)
			{
				hash ^= TrainerDifficultyModifier.GetHashCode();
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