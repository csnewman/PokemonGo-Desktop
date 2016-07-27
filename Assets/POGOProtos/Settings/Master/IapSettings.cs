// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IapSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/IapSettings.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/IapSettings.proto</summary>
	public static partial class IapSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/IapSettings.proto</summary>
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
		/// Initializes static members of the <see cref="IapSettingsReflection"/> class.
		/// </summary>
		static IapSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CixQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9JYXBTZXR0aW5ncy5wcm90",
						"bxIaUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIijAIKC0lhcFNldHRpbmdz",
						"EhkKEWRhaWx5X2JvbnVzX2NvaW5zGAEgASgFEigKIGRhaWx5X2RlZmVuZGVy",
						"X2JvbnVzX3Blcl9wb2tlbW9uGAIgAygFEioKImRhaWx5X2RlZmVuZGVyX2Jv",
						"bnVzX21heF9kZWZlbmRlcnMYAyABKAUSJQodZGFpbHlfZGVmZW5kZXJfYm9u",
						"dXNfY3VycmVuY3kYBCADKAkSIgoabWluX3RpbWVfYmV0d2Vlbl9jbGFpbXNf",
						"bXMYBSABKAMSGwoTZGFpbHlfYm9udXNfZW5hYmxlZBgGIAEoCBIkChxkYWls",
						"eV9kZWZlbmRlcl9ib251c19lbmFibGVkGAcgASgIYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.IapSettings),
							global::POGOProtos.Settings.Master.IapSettings.Parser,
							new[]
							{
								"DailyBonusCoins", "DailyDefenderBonusPerPokemon", "DailyDefenderBonusMaxDefenders",
								"DailyDefenderBonusCurrency", "MinTimeBetweenClaimsMs", "DailyBonusEnabled", "DailyDefenderBonusEnabled"
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
	/// The iap settings.
	/// </summary>
	public sealed partial class IapSettings : pb::IMessage<IapSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "daily_bonus_coins" field.</summary>
		public const int DailyBonusCoinsFieldNumber = 1;

		/// <summary>Field number for the "daily_defender_bonus_per_pokemon" field.</summary>
		public const int DailyDefenderBonusPerPokemonFieldNumber = 2;

		/// <summary>Field number for the "daily_defender_bonus_max_defenders" field.</summary>
		public const int DailyDefenderBonusMaxDefendersFieldNumber = 3;

		/// <summary>Field number for the "daily_defender_bonus_currency" field.</summary>
		public const int DailyDefenderBonusCurrencyFieldNumber = 4;

		/// <summary>Field number for the "min_time_between_claims_ms" field.</summary>
		public const int MinTimeBetweenClaimsMsFieldNumber = 5;

		/// <summary>Field number for the "daily_bonus_enabled" field.</summary>
		public const int DailyBonusEnabledFieldNumber = 6;

		/// <summary>Field number for the "daily_defender_bonus_enabled" field.</summary>
		public const int DailyDefenderBonusEnabledFieldNumber = 7;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<IapSettings> _parser =
			new pb::MessageParser<IapSettings>(() => new IapSettings());

		/// <summary>
		/// The _repeated_daily defender bonus per pokemon_codec.
		/// </summary>
		private static readonly pb.FieldCodec<int> _repeated_dailyDefenderBonusPerPokemon_codec = pb::FieldCodec.ForInt32(18);

		/// <summary>
		/// The _repeated_daily defender bonus currency_codec.
		/// </summary>
		private static readonly pb.FieldCodec<string> _repeated_dailyDefenderBonusCurrency_codec = pb::FieldCodec.ForString(
			34);

		#endregion

		#region  Fields

		/// <summary>
		/// The daily bonus coins_.
		/// </summary>
		private int dailyBonusCoins_;

		/// <summary>
		/// The daily bonus enabled_.
		/// </summary>
		private bool dailyBonusEnabled_;

		/// <summary>
		/// The daily defender bonus currency_.
		/// </summary>
		private readonly pbc.RepeatedField<string> dailyDefenderBonusCurrency_ = new pbc::RepeatedField<string>();

		/// <summary>
		/// The daily defender bonus enabled_.
		/// </summary>
		private bool dailyDefenderBonusEnabled_;

		/// <summary>
		/// The daily defender bonus max defenders_.
		/// </summary>
		private int dailyDefenderBonusMaxDefenders_;

		/// <summary>
		/// The daily defender bonus per pokemon_.
		/// </summary>
		private readonly pbc.RepeatedField<int> dailyDefenderBonusPerPokemon_ = new pbc::RepeatedField<int>();

		/// <summary>
		/// The min time between claims ms_.
		/// </summary>
		private long minTimeBetweenClaimsMs_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="IapSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IapSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="IapSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IapSettings(IapSettings other) : this()
		{
			dailyBonusCoins_ = other.dailyBonusCoins_;
			dailyDefenderBonusPerPokemon_ = other.dailyDefenderBonusPerPokemon_.Clone();
			dailyDefenderBonusMaxDefenders_ = other.dailyDefenderBonusMaxDefenders_;
			dailyDefenderBonusCurrency_ = other.dailyDefenderBonusCurrency_.Clone();
			minTimeBetweenClaimsMs_ = other.minTimeBetweenClaimsMs_;
			dailyBonusEnabled_ = other.dailyBonusEnabled_;
			dailyDefenderBonusEnabled_ = other.dailyDefenderBonusEnabled_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<IapSettings> Parser
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
				return global::POGOProtos.Settings.Master.IapSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the daily bonus coins.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int DailyBonusCoins
		{
			get
			{
				return dailyBonusCoins_;
			}

			set
			{
				dailyBonusCoins_ = value;
			}
		}

		/// <summary>
		/// Gets the daily defender bonus per pokemon.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<int> DailyDefenderBonusPerPokemon
		{
			get
			{
				return dailyDefenderBonusPerPokemon_;
			}
		}

		/// <summary>
		/// Gets or sets the daily defender bonus max defenders.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public int DailyDefenderBonusMaxDefenders
		{
			get
			{
				return dailyDefenderBonusMaxDefenders_;
			}

			set
			{
				dailyDefenderBonusMaxDefenders_ = value;
			}
		}

		/// <summary>
		/// Gets the daily defender bonus currency.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<string> DailyDefenderBonusCurrency
		{
			get
			{
				return dailyDefenderBonusCurrency_;
			}
		}

		/// <summary>
		/// Gets or sets the min time between claims ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long MinTimeBetweenClaimsMs
		{
			get
			{
				return minTimeBetweenClaimsMs_;
			}

			set
			{
				minTimeBetweenClaimsMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether daily bonus enabled.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool DailyBonusEnabled
		{
			get
			{
				return dailyBonusEnabled_;
			}

			set
			{
				dailyBonusEnabled_ = value;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether daily defender bonus enabled.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool DailyDefenderBonusEnabled
		{
			get
			{
				return dailyDefenderBonusEnabled_;
			}

			set
			{
				dailyDefenderBonusEnabled_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="IapSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public IapSettings Clone()
		{
			return new IapSettings(this);
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
		public bool Equals(IapSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (DailyBonusCoins != other.DailyBonusCoins)
			{
				return false;
			}

			if (!dailyDefenderBonusPerPokemon_.Equals(other.dailyDefenderBonusPerPokemon_))
			{
				return false;
			}

			if (DailyDefenderBonusMaxDefenders != other.DailyDefenderBonusMaxDefenders)
			{
				return false;
			}

			if (!dailyDefenderBonusCurrency_.Equals(other.dailyDefenderBonusCurrency_))
			{
				return false;
			}

			if (MinTimeBetweenClaimsMs != other.MinTimeBetweenClaimsMs)
			{
				return false;
			}

			if (DailyBonusEnabled != other.DailyBonusEnabled)
			{
				return false;
			}

			if (DailyDefenderBonusEnabled != other.DailyDefenderBonusEnabled)
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
			if (DailyBonusCoins != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(DailyBonusCoins);
			}

			dailyDefenderBonusPerPokemon_.WriteTo(output, _repeated_dailyDefenderBonusPerPokemon_codec);
			if (DailyDefenderBonusMaxDefenders != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(DailyDefenderBonusMaxDefenders);
			}

			dailyDefenderBonusCurrency_.WriteTo(output, _repeated_dailyDefenderBonusCurrency_codec);
			if (MinTimeBetweenClaimsMs != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(MinTimeBetweenClaimsMs);
			}

			if (DailyBonusEnabled != false)
			{
				output.WriteRawTag(48);
				output.WriteBool(DailyBonusEnabled);
			}

			if (DailyDefenderBonusEnabled != false)
			{
				output.WriteRawTag(56);
				output.WriteBool(DailyDefenderBonusEnabled);
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
			if (DailyBonusCoins != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(DailyBonusCoins);
			}

			size += dailyDefenderBonusPerPokemon_.CalculateSize(_repeated_dailyDefenderBonusPerPokemon_codec);
			if (DailyDefenderBonusMaxDefenders != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt32Size(DailyDefenderBonusMaxDefenders);
			}

			size += dailyDefenderBonusCurrency_.CalculateSize(_repeated_dailyDefenderBonusCurrency_codec);
			if (MinTimeBetweenClaimsMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(MinTimeBetweenClaimsMs);
			}

			if (DailyBonusEnabled != false)
			{
				size += 1 + 1;
			}

			if (DailyDefenderBonusEnabled != false)
			{
				size += 1 + 1;
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
		public void MergeFrom(IapSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.DailyBonusCoins != 0)
			{
				DailyBonusCoins = other.DailyBonusCoins;
			}

			dailyDefenderBonusPerPokemon_.Add(other.dailyDefenderBonusPerPokemon_);
			if (other.DailyDefenderBonusMaxDefenders != 0)
			{
				DailyDefenderBonusMaxDefenders = other.DailyDefenderBonusMaxDefenders;
			}

			dailyDefenderBonusCurrency_.Add(other.dailyDefenderBonusCurrency_);
			if (other.MinTimeBetweenClaimsMs != 0L)
			{
				MinTimeBetweenClaimsMs = other.MinTimeBetweenClaimsMs;
			}

			if (other.DailyBonusEnabled != false)
			{
				DailyBonusEnabled = other.DailyBonusEnabled;
			}

			if (other.DailyDefenderBonusEnabled != false)
			{
				DailyDefenderBonusEnabled = other.DailyDefenderBonusEnabled;
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
						DailyBonusCoins = input.ReadInt32();
						break;
					}

					case 18:
					case 16:
					{
						dailyDefenderBonusPerPokemon_.AddEntriesFrom(input, _repeated_dailyDefenderBonusPerPokemon_codec);
						break;
					}

					case 24:
					{
						DailyDefenderBonusMaxDefenders = input.ReadInt32();
						break;
					}

					case 34:
					{
						dailyDefenderBonusCurrency_.AddEntriesFrom(input, _repeated_dailyDefenderBonusCurrency_codec);
						break;
					}

					case 40:
					{
						MinTimeBetweenClaimsMs = input.ReadInt64();
						break;
					}

					case 48:
					{
						DailyBonusEnabled = input.ReadBool();
						break;
					}

					case 56:
					{
						DailyDefenderBonusEnabled = input.ReadBool();
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
			return Equals(other as IapSettings);
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
			if (DailyBonusCoins != 0)
			{
				hash ^= DailyBonusCoins.GetHashCode();
			}

			hash ^= dailyDefenderBonusPerPokemon_.GetHashCode();
			if (DailyDefenderBonusMaxDefenders != 0)
			{
				hash ^= DailyDefenderBonusMaxDefenders.GetHashCode();
			}

			hash ^= dailyDefenderBonusCurrency_.GetHashCode();
			if (MinTimeBetweenClaimsMs != 0L)
			{
				hash ^= MinTimeBetweenClaimsMs.GetHashCode();
			}

			if (DailyBonusEnabled != false)
			{
				hash ^= DailyBonusEnabled.GetHashCode();
			}

			if (DailyDefenderBonusEnabled != false)
			{
				hash ^= DailyDefenderBonusEnabled.GetHashCode();
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