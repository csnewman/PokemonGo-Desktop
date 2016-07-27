// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortLureInfo.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/Fort/FortLureInfo.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Map.Fort
{
	/// <summary>Holder for reflection information generated from POGOProtos/Map/Fort/FortLureInfo.proto</summary>
	public static partial class FortLureInfoReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/Fort/FortLureInfo.proto</summary>
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
		/// Initializes static members of the <see cref="FortLureInfoReflection"/> class.
		/// </summary>
		static FortLureInfoReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiZQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnRMdXJlSW5mby5wcm90bxITUE9H",
						"T1Byb3Rvcy5NYXAuRm9ydBogUE9HT1Byb3Rvcy9FbnVtcy9Qb2tlbW9uSWQu",
						"cHJvdG8ikAEKDEZvcnRMdXJlSW5mbxIPCgdmb3J0X2lkGAEgASgJEhQKDGVu",
						"Y291bnRlcl9pZBgCIAEoBhI2ChFhY3RpdmVfcG9rZW1vbl9pZBgDIAEoDjIb",
						"LlBPR09Qcm90b3MuRW51bXMuUG9rZW1vbklkEiEKGWx1cmVfZXhwaXJlc190",
						"aW1lc3RhbXBfbXMYBCABKANiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Map.Fort.FortLureInfo),
							global::POGOProtos.Map.Fort.FortLureInfo.Parser,
							new[] { "FortId", "EncounterId", "ActivePokemonId", "LureExpiresTimestampMs" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort lure info.
	/// </summary>
	public sealed partial class FortLureInfo : pb::IMessage<FortLureInfo>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "fort_id" field.</summary>
		public const int FortIdFieldNumber = 1;

		/// <summary>Field number for the "encounter_id" field.</summary>
		public const int EncounterIdFieldNumber = 2;

		/// <summary>Field number for the "active_pokemon_id" field.</summary>
		public const int ActivePokemonIdFieldNumber = 3;

		/// <summary>Field number for the "lure_expires_timestamp_ms" field.</summary>
		public const int LureExpiresTimestampMsFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortLureInfo> _parser =
			new pb::MessageParser<FortLureInfo>(() => new FortLureInfo());

		#endregion

		#region  Fields

		/// <summary>
		/// The active pokemon id_.
		/// </summary>
		private PokemonId activePokemonId_ = 0;

		/// <summary>
		/// The encounter id_.
		/// </summary>
		private ulong encounterId_;

		/// <summary>
		/// The fort id_.
		/// </summary>
		private string fortId_ = string.Empty;

		/// <summary>
		/// The lure expires timestamp ms_.
		/// </summary>
		private long lureExpiresTimestampMs_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortLureInfo"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortLureInfo()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortLureInfo"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortLureInfo(FortLureInfo other) : this()
		{
			fortId_ = other.fortId_;
			encounterId_ = other.encounterId_;
			activePokemonId_ = other.activePokemonId_;
			lureExpiresTimestampMs_ = other.lureExpiresTimestampMs_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortLureInfo> Parser
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
				return global::POGOProtos.Map.Fort.FortLureInfoReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the fort id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string FortId
		{
			get
			{
				return fortId_;
			}

			set
			{
				fortId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the encounter id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ulong EncounterId
		{
			get
			{
				return encounterId_;
			}

			set
			{
				encounterId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the active pokemon id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PokemonId ActivePokemonId
		{
			get
			{
				return activePokemonId_;
			}

			set
			{
				activePokemonId_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the lure expires timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long LureExpiresTimestampMs
		{
			get
			{
				return lureExpiresTimestampMs_;
			}

			set
			{
				lureExpiresTimestampMs_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortLureInfo"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortLureInfo Clone()
		{
			return new FortLureInfo(this);
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
		public bool Equals(FortLureInfo other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (FortId != other.FortId)
			{
				return false;
			}

			if (EncounterId != other.EncounterId)
			{
				return false;
			}

			if (ActivePokemonId != other.ActivePokemonId)
			{
				return false;
			}

			if (LureExpiresTimestampMs != other.LureExpiresTimestampMs)
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
			if (FortId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(FortId);
			}

			if (EncounterId != 0UL)
			{
				output.WriteRawTag(17);
				output.WriteFixed64(EncounterId);
			}

			if (ActivePokemonId != 0)
			{
				output.WriteRawTag(24);
				output.WriteEnum((int)ActivePokemonId);
			}

			if (LureExpiresTimestampMs != 0L)
			{
				output.WriteRawTag(32);
				output.WriteInt64(LureExpiresTimestampMs);
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
			if (FortId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(FortId);
			}

			if (EncounterId != 0UL)
			{
				size += 1 + 8;
			}

			if (ActivePokemonId != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)ActivePokemonId);
			}

			if (LureExpiresTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(LureExpiresTimestampMs);
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
		public void MergeFrom(FortLureInfo other)
		{
			if (other == null)
			{
				return;
			}

			if (other.FortId.Length != 0)
			{
				FortId = other.FortId;
			}

			if (other.EncounterId != 0UL)
			{
				EncounterId = other.EncounterId;
			}

			if (other.ActivePokemonId != 0)
			{
				ActivePokemonId = other.ActivePokemonId;
			}

			if (other.LureExpiresTimestampMs != 0L)
			{
				LureExpiresTimestampMs = other.LureExpiresTimestampMs;
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
					case 10:
					{
						FortId = input.ReadString();
						break;
					}

					case 17:
					{
						EncounterId = input.ReadFixed64();
						break;
					}

					case 24:
					{
						activePokemonId_ = (global::POGOProtos.Enums.PokemonId)input.ReadEnum();
						break;
					}

					case 32:
					{
						LureExpiresTimestampMs = input.ReadInt64();
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
			return Equals(other as FortLureInfo);
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
			if (FortId.Length != 0)
			{
				hash ^= FortId.GetHashCode();
			}

			if (EncounterId != 0UL)
			{
				hash ^= EncounterId.GetHashCode();
			}

			if (ActivePokemonId != 0)
			{
				hash ^= ActivePokemonId.GetHashCode();
			}

			if (LureExpiresTimestampMs != 0L)
			{
				hash ^= LureExpiresTimestampMs.GetHashCode();
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