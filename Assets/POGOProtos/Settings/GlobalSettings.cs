// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GlobalSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/GlobalSettings.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/GlobalSettings.proto</summary>
	public static partial class GlobalSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/GlobalSettings.proto</summary>
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
		/// Initializes static members of the <see cref="GlobalSettingsReflection"/> class.
		/// </summary>
		static GlobalSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CihQT0dPUHJvdG9zL1NldHRpbmdzL0dsb2JhbFNldHRpbmdzLnByb3RvEhNQ",
						"T0dPUHJvdG9zLlNldHRpbmdzGiZQT0dPUHJvdG9zL1NldHRpbmdzL0ZvcnRT",
						"ZXR0aW5ncy5wcm90bxolUE9HT1Byb3Rvcy9TZXR0aW5ncy9NYXBTZXR0aW5n",
						"cy5wcm90bxonUE9HT1Byb3Rvcy9TZXR0aW5ncy9MZXZlbFNldHRpbmdzLnBy",
						"b3RvGitQT0dPUHJvdG9zL1NldHRpbmdzL0ludmVudG9yeVNldHRpbmdzLnBy",
						"b3RvIqICCg5HbG9iYWxTZXR0aW5ncxI4Cg1mb3J0X3NldHRpbmdzGAIgASgL",
						"MiEuUE9HT1Byb3Rvcy5TZXR0aW5ncy5Gb3J0U2V0dGluZ3MSNgoMbWFwX3Nl",
						"dHRpbmdzGAMgASgLMiAuUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXBTZXR0aW5n",
						"cxI6Cg5sZXZlbF9zZXR0aW5ncxgEIAEoCzIiLlBPR09Qcm90b3MuU2V0dGlu",
						"Z3MuTGV2ZWxTZXR0aW5ncxJCChJpbnZlbnRvcnlfc2V0dGluZ3MYBSABKAsy",
						"Ji5QT0dPUHJvdG9zLlNldHRpbmdzLkludmVudG9yeVNldHRpbmdzEh4KFm1p",
						"bmltdW1fY2xpZW50X3ZlcnNpb24YBiABKAliBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Settings.FortSettingsReflection.Descriptor,
					global::POGOProtos.Settings.MapSettingsReflection.Descriptor,
					global::POGOProtos.Settings.LevelSettingsReflection.Descriptor,
					global::POGOProtos.Settings.InventorySettingsReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.GlobalSettings),
							global::POGOProtos.Settings.GlobalSettings.Parser,
							new[] { "FortSettings", "MapSettings", "LevelSettings", "InventorySettings", "MinimumClientVersion" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The global settings.
	/// </summary>
	public sealed partial class GlobalSettings : pb::IMessage<GlobalSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "fort_settings" field.</summary>
		public const int FortSettingsFieldNumber = 2;

		/// <summary>Field number for the "map_settings" field.</summary>
		public const int MapSettingsFieldNumber = 3;

		/// <summary>Field number for the "level_settings" field.</summary>
		public const int LevelSettingsFieldNumber = 4;

		/// <summary>Field number for the "inventory_settings" field.</summary>
		public const int InventorySettingsFieldNumber = 5;

		/// <summary>Field number for the "minimum_client_version" field.</summary>
		public const int MinimumClientVersionFieldNumber = 6;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GlobalSettings> _parser =
			new pb::MessageParser<GlobalSettings>(() => new GlobalSettings());

		#endregion

		#region  Fields

		/// <summary>
		/// The fort settings_.
		/// </summary>
		private FortSettings fortSettings_;

		/// <summary>
		/// The inventory settings_.
		/// </summary>
		private InventorySettings inventorySettings_;

		/// <summary>
		/// The level settings_.
		/// </summary>
		private LevelSettings levelSettings_;

		/// <summary>
		/// The map settings_.
		/// </summary>
		private MapSettings mapSettings_;

		/// <summary>
		/// The minimum client version_.
		/// </summary>
		private string minimumClientVersion_ = string.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GlobalSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GlobalSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GlobalSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GlobalSettings(GlobalSettings other) : this()
		{
			FortSettings = other.fortSettings_ != null ? other.FortSettings.Clone() : null;
			MapSettings = other.mapSettings_ != null ? other.MapSettings.Clone() : null;
			LevelSettings = other.levelSettings_ != null ? other.LevelSettings.Clone() : null;
			InventorySettings = other.inventorySettings_ != null ? other.InventorySettings.Clone() : null;
			minimumClientVersion_ = other.minimumClientVersion_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GlobalSettings> Parser
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
				return global::POGOProtos.Settings.GlobalSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the fort settings.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSettings FortSettings
		{
			get
			{
				return fortSettings_;
			}

			set
			{
				fortSettings_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the map settings.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapSettings MapSettings
		{
			get
			{
				return mapSettings_;
			}

			set
			{
				mapSettings_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the level settings.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public LevelSettings LevelSettings
		{
			get
			{
				return levelSettings_;
			}

			set
			{
				levelSettings_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the inventory settings.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public InventorySettings InventorySettings
		{
			get
			{
				return inventorySettings_;
			}

			set
			{
				inventorySettings_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the minimum client version.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string MinimumClientVersion
		{
			get
			{
				return minimumClientVersion_;
			}

			set
			{
				minimumClientVersion_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GlobalSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GlobalSettings Clone()
		{
			return new GlobalSettings(this);
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
		public bool Equals(GlobalSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!object.Equals(FortSettings, other.FortSettings))
			{
				return false;
			}

			if (!object.Equals(MapSettings, other.MapSettings))
			{
				return false;
			}

			if (!object.Equals(LevelSettings, other.LevelSettings))
			{
				return false;
			}

			if (!object.Equals(InventorySettings, other.InventorySettings))
			{
				return false;
			}

			if (MinimumClientVersion != other.MinimumClientVersion)
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
			if (fortSettings_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(FortSettings);
			}

			if (mapSettings_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(MapSettings);
			}

			if (levelSettings_ != null)
			{
				output.WriteRawTag(34);
				output.WriteMessage(LevelSettings);
			}

			if (inventorySettings_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(InventorySettings);
			}

			if (MinimumClientVersion.Length != 0)
			{
				output.WriteRawTag(50);
				output.WriteString(MinimumClientVersion);
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
			if (fortSettings_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(FortSettings);
			}

			if (mapSettings_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(MapSettings);
			}

			if (levelSettings_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(LevelSettings);
			}

			if (inventorySettings_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(InventorySettings);
			}

			if (MinimumClientVersion.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(MinimumClientVersion);
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
		public void MergeFrom(GlobalSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.fortSettings_ != null)
			{
				if (fortSettings_ == null)
				{
					fortSettings_ = new global::POGOProtos.Settings.FortSettings();
				}

				FortSettings.MergeFrom(other.FortSettings);
			}

			if (other.mapSettings_ != null)
			{
				if (mapSettings_ == null)
				{
					mapSettings_ = new global::POGOProtos.Settings.MapSettings();
				}

				MapSettings.MergeFrom(other.MapSettings);
			}

			if (other.levelSettings_ != null)
			{
				if (levelSettings_ == null)
				{
					levelSettings_ = new global::POGOProtos.Settings.LevelSettings();
				}

				LevelSettings.MergeFrom(other.LevelSettings);
			}

			if (other.inventorySettings_ != null)
			{
				if (inventorySettings_ == null)
				{
					inventorySettings_ = new global::POGOProtos.Settings.InventorySettings();
				}

				InventorySettings.MergeFrom(other.InventorySettings);
			}

			if (other.MinimumClientVersion.Length != 0)
			{
				MinimumClientVersion = other.MinimumClientVersion;
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
					case 18:
					{
						if (fortSettings_ == null)
						{
							fortSettings_ = new global::POGOProtos.Settings.FortSettings();
						}

						input.ReadMessage(fortSettings_);
						break;
					}

					case 26:
					{
						if (mapSettings_ == null)
						{
							mapSettings_ = new global::POGOProtos.Settings.MapSettings();
						}

						input.ReadMessage(mapSettings_);
						break;
					}

					case 34:
					{
						if (levelSettings_ == null)
						{
							levelSettings_ = new global::POGOProtos.Settings.LevelSettings();
						}

						input.ReadMessage(levelSettings_);
						break;
					}

					case 42:
					{
						if (inventorySettings_ == null)
						{
							inventorySettings_ = new global::POGOProtos.Settings.InventorySettings();
						}

						input.ReadMessage(inventorySettings_);
						break;
					}

					case 50:
					{
						MinimumClientVersion = input.ReadString();
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
			return Equals(other as GlobalSettings);
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
			if (fortSettings_ != null)
			{
				hash ^= FortSettings.GetHashCode();
			}

			if (mapSettings_ != null)
			{
				hash ^= MapSettings.GetHashCode();
			}

			if (levelSettings_ != null)
			{
				hash ^= LevelSettings.GetHashCode();
			}

			if (inventorySettings_ != null)
			{
				hash ^= InventorySettings.GetHashCode();
			}

			if (MinimumClientVersion.Length != 0)
			{
				hash ^= MinimumClientVersion.GetHashCode();
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