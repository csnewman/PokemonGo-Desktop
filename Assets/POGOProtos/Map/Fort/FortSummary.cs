// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FortSummary.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Map/Fort/FortSummary.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Map.Fort
{
	/// <summary>Holder for reflection information generated from POGOProtos/Map/Fort/FortSummary.proto</summary>
	public static partial class FortSummaryReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Map/Fort/FortSummary.proto</summary>
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
		/// Initializes static members of the <see cref="FortSummaryReflection"/> class.
		/// </summary>
		static FortSummaryReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CiVQT0dPUHJvdG9zL01hcC9Gb3J0L0ZvcnRTdW1tYXJ5LnByb3RvEhNQT0dP",
						"UHJvdG9zLk1hcC5Gb3J0Im8KC0ZvcnRTdW1tYXJ5EhcKD2ZvcnRfc3VtbWFy",
						"eV9pZBgBIAEoCRIiChpsYXN0X21vZGlmaWVkX3RpbWVzdGFtcF9tcxgCIAEo",
						"AxIQCghsYXRpdHVkZRgDIAEoARIRCglsb25naXR1ZGUYBCABKAFiBnByb3Rv",
						"Mw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Map.Fort.FortSummary),
							global::POGOProtos.Map.Fort.FortSummary.Parser,
							new[] { "FortSummaryId", "LastModifiedTimestampMs", "Latitude", "Longitude" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The fort summary.
	/// </summary>
	public sealed partial class FortSummary : pb::IMessage<FortSummary>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "fort_summary_id" field.</summary>
		public const int FortSummaryIdFieldNumber = 1;

		/// <summary>Field number for the "last_modified_timestamp_ms" field.</summary>
		public const int LastModifiedTimestampMsFieldNumber = 2;

		/// <summary>Field number for the "latitude" field.</summary>
		public const int LatitudeFieldNumber = 3;

		/// <summary>Field number for the "longitude" field.</summary>
		public const int LongitudeFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<FortSummary> _parser =
			new pb::MessageParser<FortSummary>(() => new FortSummary());

		#endregion

		#region  Fields

		/// <summary>
		/// The fort summary id_.
		/// </summary>
		private string fortSummaryId_ = string.Empty;

		/// <summary>
		/// The last modified timestamp ms_.
		/// </summary>
		private long lastModifiedTimestampMs_;

		/// <summary>
		/// The latitude_.
		/// </summary>
		private double latitude_;

		/// <summary>
		/// The longitude_.
		/// </summary>
		private double longitude_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="FortSummary"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSummary()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="FortSummary"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSummary(FortSummary other) : this()
		{
			fortSummaryId_ = other.fortSummaryId_;
			lastModifiedTimestampMs_ = other.lastModifiedTimestampMs_;
			latitude_ = other.latitude_;
			longitude_ = other.longitude_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<FortSummary> Parser
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
				return global::POGOProtos.Map.Fort.FortSummaryReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the fort summary id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string FortSummaryId
		{
			get
			{
				return fortSummaryId_;
			}

			set
			{
				fortSummaryId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the last modified timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public long LastModifiedTimestampMs
		{
			get
			{
				return lastModifiedTimestampMs_;
			}

			set
			{
				lastModifiedTimestampMs_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the latitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Latitude
		{
			get
			{
				return latitude_;
			}

			set
			{
				latitude_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the longitude.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public double Longitude
		{
			get
			{
				return longitude_;
			}

			set
			{
				longitude_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="FortSummary"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public FortSummary Clone()
		{
			return new FortSummary(this);
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
		public bool Equals(FortSummary other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (FortSummaryId != other.FortSummaryId)
			{
				return false;
			}

			if (LastModifiedTimestampMs != other.LastModifiedTimestampMs)
			{
				return false;
			}

			if (Latitude != other.Latitude)
			{
				return false;
			}

			if (Longitude != other.Longitude)
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
			if (FortSummaryId.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(FortSummaryId);
			}

			if (LastModifiedTimestampMs != 0L)
			{
				output.WriteRawTag(16);
				output.WriteInt64(LastModifiedTimestampMs);
			}

			if (Latitude != 0D)
			{
				output.WriteRawTag(25);
				output.WriteDouble(Latitude);
			}

			if (Longitude != 0D)
			{
				output.WriteRawTag(33);
				output.WriteDouble(Longitude);
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
			if (FortSummaryId.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(FortSummaryId);
			}

			if (LastModifiedTimestampMs != 0L)
			{
				size += 1 + pb::CodedOutputStream.ComputeInt64Size(LastModifiedTimestampMs);
			}

			if (Latitude != 0D)
			{
				size += 1 + 8;
			}

			if (Longitude != 0D)
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
		public void MergeFrom(FortSummary other)
		{
			if (other == null)
			{
				return;
			}

			if (other.FortSummaryId.Length != 0)
			{
				FortSummaryId = other.FortSummaryId;
			}

			if (other.LastModifiedTimestampMs != 0L)
			{
				LastModifiedTimestampMs = other.LastModifiedTimestampMs;
			}

			if (other.Latitude != 0D)
			{
				Latitude = other.Latitude;
			}

			if (other.Longitude != 0D)
			{
				Longitude = other.Longitude;
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
						FortSummaryId = input.ReadString();
						break;
					}

					case 16:
					{
						LastModifiedTimestampMs = input.ReadInt64();
						break;
					}

					case 25:
					{
						Latitude = input.ReadDouble();
						break;
					}

					case 33:
					{
						Longitude = input.ReadDouble();
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
			return Equals(other as FortSummary);
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
			if (FortSummaryId.Length != 0)
			{
				hash ^= FortSummaryId.GetHashCode();
			}

			if (LastModifiedTimestampMs != 0L)
			{
				hash ^= LastModifiedTimestampMs.GetHashCode();
			}

			if (Latitude != 0D)
			{
				hash ^= Latitude.GetHashCode();
			}

			if (Longitude != 0D)
			{
				hash ^= Longitude.GetHashCode();
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