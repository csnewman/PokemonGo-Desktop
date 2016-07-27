// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/FortSettings.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/FortSettings.proto</summary>
	public static partial class FortSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/FortSettings.proto</summary>
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
		/// Initializes static members of the <see cref="FortSettingsReflection"/> class.
		/// </summary>
		static FortSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiZQT0dPUHJvdG9zL1NldHRpbmdzL0ZvcnRTZXR0aW5ncy5wcm90bxITUE9H",
						"T1Byb3Rvcy5TZXR0aW5ncyLkAQoMRm9ydFNldHRpbmdzEiAKGGludGVyYWN0",
						"aW9uX3JhbmdlX21ldGVycxgBIAEoARIiChptYXhfdG90YWxfZGVwbG95ZWRf",
						"cG9rZW1vbhgCIAEoBRIjChttYXhfcGxheWVyX2RlcGxveWVkX3Bva2Vtb24Y",
						"AyABKAUSIQoZZGVwbG95X3N0YW1pbmFfbXVsdGlwbGllchgEIAEoARIgChhk",
						"ZXBsb3lfYXR0YWNrX211bHRpcGxpZXIYBSABKAESJAocZmFyX2ludGVyYWN0",
						"aW9uX3JhbmdlX21ldGVycxgGIAEoAWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.FortSettings),
							global::POGOProtos.Settings.FortSettings.Parser,
							new[]
							{
								"InteractionRangeMeters", "MaxTotalDeployedPokemon", "MaxPlayerDeployedPokemon", "DeployStaminaMultiplier",
								"DeployAttackMultiplier", "FarInteractionRangeMeters"
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
	/// The fort settings.
	/// </summary>
	public sealed partial class FortSettings : pb::IMessage<FortSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "interaction_range_meters" field.</summary>
		public const int InteractionRangeMetersFieldNumber = 1;

		/// <summary>Field number for the "max_total_deployed_pokemon" field.</summary>
		public const int MaxTotalDeployedPokemonFieldNumber = 2;

		/// <summary>Field number for the "max_player_deployed_pokemon" field.</summary>
		public const int MaxPlayerDeployedPokemonFieldNumber = 3;

		/// <summary>Field number for the "deploy_stamina_multiplier" field.</summary>
		public const int DeployStaminaMultiplierFieldNumber = 4;

		/// <summary>Field number for the "deploy_attack_multiplier" field.</summary>
		public const int DeployAttackMultiplierFieldNumber = 5;

		/// <summary>Field number for the "far_interaction_range_meters" field.</summary>
		public const int FarInteractionRangeMetersFieldNumber = 6;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortSettings> _parser =
			new pb::MessageParser<FortSettings>(() => new FortSettings());

		#endregion

		#region  Fields

		/// <summary>
		/// The deploy attack multiplier_.
		/// </summary>
		private double deployAttackMultiplier_;

		/// <summary>
		/// The deploy stamina multiplier_.
		/// </summary>
		private double deployStaminaMultiplier_;

		/// <summary>
		/// The far interaction range meters_.
		/// </summary>
		private double farInteractionRangeMeters_;

		/// <summary>
		/// The interaction range meters_.
		/// </summary>
		private double interactionRangeMeters_;

		/// <summary>
		/// The max player deployed pokemon_.
		/// </summary>
		private int maxPlayerDeployedPokemon_;

		/// <summary>
		/// The max total deployed pokemon_.
		/// </summary>
		private int maxTotalDeployedPokemon_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSettings(FortSettings other) : this()
		{
			interactionRangeMeters_ = other.interactionRangeMeters_;
			maxTotalDeployedPokemon_ = other.maxTotalDeployedPokemon_;
			maxPlayerDeployedPokemon_ = other.maxPlayerDeployedPokemon_;
			deployStaminaMultiplier_ = other.deployStaminaMultiplier_;
			deployAttackMultiplier_ = other.deployAttackMultiplier_;
			farInteractionRangeMeters_ = other.farInteractionRangeMeters_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortSettings> Parser
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
				return global::POGOProtos.Settings.FortSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the interaction range meters.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double InteractionRangeMeters
		{
			get
			{
				return interactionRangeMeters_;
			}

			set
			{
				interactionRangeMeters_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the max total deployed pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaxTotalDeployedPokemon
		{
			get
			{
				return maxTotalDeployedPokemon_;
			}

			set
			{
				maxTotalDeployedPokemon_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the max player deployed pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int MaxPlayerDeployedPokemon
		{
			get
			{
				return maxPlayerDeployedPokemon_;
			}

			set
			{
				maxPlayerDeployedPokemon_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the deploy stamina multiplier.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double DeployStaminaMultiplier
		{
			get
			{
				return deployStaminaMultiplier_;
			}

			set
			{
				deployStaminaMultiplier_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the deploy attack multiplier.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double DeployAttackMultiplier
		{
			get
			{
				return deployAttackMultiplier_;
			}

			set
			{
				deployAttackMultiplier_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the far interaction range meters.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double FarInteractionRangeMeters
		{
			get
			{
				return farInteractionRangeMeters_;
			}

			set
			{
				farInteractionRangeMeters_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSettings Clone()
		{
			return new FortSettings(this);
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
		public bool Equals(FortSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (InteractionRangeMeters != other.InteractionRangeMeters)
			{
				return false;
			}

			if (MaxTotalDeployedPokemon != other.MaxTotalDeployedPokemon)
			{
				return false;
			}

			if (MaxPlayerDeployedPokemon != other.MaxPlayerDeployedPokemon)
			{
				return false;
			}

			if (DeployStaminaMultiplier != other.DeployStaminaMultiplier)
			{
				return false;
			}

			if (DeployAttackMultiplier != other.DeployAttackMultiplier)
			{
				return false;
			}

			if (FarInteractionRangeMeters != other.FarInteractionRangeMeters)
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
			if (InteractionRangeMeters != 0D)
			{
				output.WriteRawTag(9);
				output.WriteDouble(InteractionRangeMeters);
			}

			if (MaxTotalDeployedPokemon != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(MaxTotalDeployedPokemon);
			}

			if (MaxPlayerDeployedPokemon != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(MaxPlayerDeployedPokemon);
			}

			if (DeployStaminaMultiplier != 0D)
			{
				output.WriteRawTag(33);
				output.WriteDouble(DeployStaminaMultiplier);
			}

			if (DeployAttackMultiplier != 0D)
			{
				output.WriteRawTag(41);
				output.WriteDouble(DeployAttackMultiplier);
			}

			if (FarInteractionRangeMeters != 0D)
			{
				output.WriteRawTag(49);
				output.WriteDouble(FarInteractionRangeMeters);
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
			if (InteractionRangeMeters != 0D)
			{
				size += 1 + 8;
			}

			if (MaxTotalDeployedPokemon != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxTotalDeployedPokemon);
			}

			if (MaxPlayerDeployedPokemon != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(MaxPlayerDeployedPokemon);
			}

			if (DeployStaminaMultiplier != 0D)
			{
				size += 1 + 8;
			}

			if (DeployAttackMultiplier != 0D)
			{
				size += 1 + 8;
			}

			if (FarInteractionRangeMeters != 0D)
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
		public void MergeFrom(FortSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.InteractionRangeMeters != 0D)
			{
				InteractionRangeMeters = other.InteractionRangeMeters;
			}

			if (other.MaxTotalDeployedPokemon != 0)
			{
				MaxTotalDeployedPokemon = other.MaxTotalDeployedPokemon;
			}

			if (other.MaxPlayerDeployedPokemon != 0)
			{
				MaxPlayerDeployedPokemon = other.MaxPlayerDeployedPokemon;
			}

			if (other.DeployStaminaMultiplier != 0D)
			{
				DeployStaminaMultiplier = other.DeployStaminaMultiplier;
			}

			if (other.DeployAttackMultiplier != 0D)
			{
				DeployAttackMultiplier = other.DeployAttackMultiplier;
			}

			if (other.FarInteractionRangeMeters != 0D)
			{
				FarInteractionRangeMeters = other.FarInteractionRangeMeters;
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
					case 9:
					{
						InteractionRangeMeters = input.ReadDouble();
						break;
					}

					case 16:
					{
						MaxTotalDeployedPokemon = input.ReadInt32();
						break;
					}

					case 24:
					{
						MaxPlayerDeployedPokemon = input.ReadInt32();
						break;
					}

					case 33:
					{
						DeployStaminaMultiplier = input.ReadDouble();
						break;
					}

					case 41:
					{
						DeployAttackMultiplier = input.ReadDouble();
						break;
					}

					case 49:
					{
						FarInteractionRangeMeters = input.ReadDouble();
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
			return Equals(other as FortSettings);
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
			if (InteractionRangeMeters != 0D)
			{
				hash ^= InteractionRangeMeters.GetHashCode();
			}

			if (MaxTotalDeployedPokemon != 0)
			{
				hash ^= MaxTotalDeployedPokemon.GetHashCode();
			}

			if (MaxPlayerDeployedPokemon != 0)
			{
				hash ^= MaxPlayerDeployedPokemon.GetHashCode();
			}

			if (DeployStaminaMultiplier != 0D)
			{
				hash ^= DeployStaminaMultiplier.GetHashCode();
			}

			if (DeployAttackMultiplier != 0D)
			{
				hash ^= DeployAttackMultiplier.GetHashCode();
			}

			if (FarInteractionRangeMeters != 0D)
			{
				hash ^= FarInteractionRangeMeters.GetHashCode();
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