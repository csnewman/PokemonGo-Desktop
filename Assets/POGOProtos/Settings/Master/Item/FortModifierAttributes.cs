// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortModifierAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Item/FortModifierAttributes.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master.Item
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Item/FortModifierAttributes.proto</summary>
	public static partial class FortModifierAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Item/FortModifierAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="FortModifierAttributesReflection"/> class.
		/// </summary>
		static FortModifierAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjxQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JdGVtL0ZvcnRNb2RpZmll",
						"ckF0dHJpYnV0ZXMucHJvdG8SH1BPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVy",
						"Lkl0ZW0iYgoWRm9ydE1vZGlmaWVyQXR0cmlidXRlcxIhChltb2RpZmllcl9s",
						"aWZldGltZV9zZWNvbmRzGAEgASgFEiUKHXRyb3lfZGlza19udW1fcG9rZW1v",
						"bl9zcGF3bmVkGAIgASgFYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Item.FortModifierAttributes),
							global::POGOProtos.Settings.Master.Item.FortModifierAttributes.Parser,
							new[] { "ModifierLifetimeSeconds", "TroyDiskNumPokemonSpawned" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort modifier attributes.
	/// </summary>
	public sealed partial class FortModifierAttributes : pb::IMessage<FortModifierAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "modifier_lifetime_seconds" field.</summary>
		public const int ModifierLifetimeSecondsFieldNumber = 1;

		/// <summary>Field number for the "troy_disk_num_pokemon_spawned" field.</summary>
		public const int TroyDiskNumPokemonSpawnedFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortModifierAttributes> _parser =
			new pb::MessageParser<FortModifierAttributes>(() => new FortModifierAttributes());

		#endregion

		#region  Fields

		/// <summary>
		/// The modifier lifetime seconds_.
		/// </summary>
		private int modifierLifetimeSeconds_;

		/// <summary>
		/// The troy disk num pokemon spawned_.
		/// </summary>
		private int troyDiskNumPokemonSpawned_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortModifierAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortModifierAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortModifierAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortModifierAttributes(FortModifierAttributes other) : this()
		{
			modifierLifetimeSeconds_ = other.modifierLifetimeSeconds_;
			troyDiskNumPokemonSpawned_ = other.troyDiskNumPokemonSpawned_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortModifierAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Item.FortModifierAttributesReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the modifier lifetime seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int ModifierLifetimeSeconds
		{
			get
			{
				return modifierLifetimeSeconds_;
			}

			set
			{
				modifierLifetimeSeconds_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the troy disk num pokemon spawned.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int TroyDiskNumPokemonSpawned
		{
			get
			{
				return troyDiskNumPokemonSpawned_;
			}

			set
			{
				troyDiskNumPokemonSpawned_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortModifierAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortModifierAttributes Clone()
		{
			return new FortModifierAttributes(this);
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
		public bool Equals(FortModifierAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (ModifierLifetimeSeconds != other.ModifierLifetimeSeconds)
			{
				return false;
			}

			if (TroyDiskNumPokemonSpawned != other.TroyDiskNumPokemonSpawned)
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
			if (ModifierLifetimeSeconds != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(ModifierLifetimeSeconds);
			}

			if (TroyDiskNumPokemonSpawned != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(TroyDiskNumPokemonSpawned);
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
			if (ModifierLifetimeSeconds != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(ModifierLifetimeSeconds);
			}

			if (TroyDiskNumPokemonSpawned != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(TroyDiskNumPokemonSpawned);
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
		public void MergeFrom(FortModifierAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.ModifierLifetimeSeconds != 0)
			{
				ModifierLifetimeSeconds = other.ModifierLifetimeSeconds;
			}

			if (other.TroyDiskNumPokemonSpawned != 0)
			{
				TroyDiskNumPokemonSpawned = other.TroyDiskNumPokemonSpawned;
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
					case 8:
					{
						ModifierLifetimeSeconds = input.ReadInt32();
						break;
					}

					case 16:
					{
						TroyDiskNumPokemonSpawned = input.ReadInt32();
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
			return Equals(other as FortModifierAttributes);
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
			if (ModifierLifetimeSeconds != 0)
			{
				hash ^= ModifierLifetimeSeconds.GetHashCode();
			}

			if (TroyDiskNumPokemonSpawned != 0)
			{
				hash ^= TroyDiskNumPokemonSpawned.GetHashCode();
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