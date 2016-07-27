// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetMapObjectsMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GetMapObjectsMessage.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Requests.Messages
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GetMapObjectsMessage.proto</summary>
	public static partial class GetMapObjectsMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/GetMapObjectsMessage.proto</summary>
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
		/// Initializes static members of the <see cref="GetMapObjectsMessageReflection"/> class.
		/// </summary>
		static GetMapObjectsMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkJQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvR2V0",
						"TWFwT2JqZWN0c01lc3NhZ2UucHJvdG8SJ1BPR09Qcm90b3MuTmV0d29ya2lu",
						"Zy5SZXF1ZXN0cy5NZXNzYWdlcyJwChRHZXRNYXBPYmplY3RzTWVzc2FnZRIT",
						"CgdjZWxsX2lkGAEgAygEQgIQARIeChJzaW5jZV90aW1lc3RhbXBfbXMYAiAD",
						"KANCAhABEhAKCGxhdGl0dWRlGAMgASgBEhEKCWxvbmdpdHVkZRgEIAEoAWIG",
						"cHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.GetMapObjectsMessage),
							global::POGOProtos.Networking.Requests.Messages.GetMapObjectsMessage.Parser,
							new[] { "CellId", "SinceTimestampMs", "Latitude", "Longitude" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The get map objects message.
	/// </summary>
	public sealed partial class GetMapObjectsMessage : pb::IMessage<GetMapObjectsMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "cell_id" field.</summary>
		public const int CellIdFieldNumber = 1;

		/// <summary>Field number for the "since_timestamp_ms" field.</summary>
		public const int SinceTimestampMsFieldNumber = 2;

		/// <summary>Field number for the "latitude" field.</summary>
		public const int LatitudeFieldNumber = 3;

		/// <summary>Field number for the "longitude" field.</summary>
		public const int LongitudeFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetMapObjectsMessage> _parser =
			new pb::MessageParser<GetMapObjectsMessage>(() => new GetMapObjectsMessage());

		/// <summary>
		/// The _repeated_cell id_codec.
		/// </summary>
		private static readonly pb.FieldCodec<ulong> _repeated_cellId_codec = pb::FieldCodec.ForUInt64(10);

		/// <summary>
		/// The _repeated_since timestamp ms_codec.
		/// </summary>
		private static readonly pb.FieldCodec<long> _repeated_sinceTimestampMs_codec = pb::FieldCodec.ForInt64(18);

		#endregion

		#region  Fields

		/// <summary>
		/// The cell id_.
		/// </summary>
		private readonly pbc.RepeatedField<ulong> cellId_ = new pbc::RepeatedField<ulong>();

		/// <summary>
		/// The latitude_.
		/// </summary>
		private double latitude_;

		/// <summary>
		/// The longitude_.
		/// </summary>
		private double longitude_;

		/// <summary>
		/// The since timestamp ms_.
		/// </summary>
		private readonly pbc.RepeatedField<long> sinceTimestampMs_ = new pbc::RepeatedField<long>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetMapObjectsMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetMapObjectsMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetMapObjectsMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetMapObjectsMessage(GetMapObjectsMessage other) : this()
		{
			cellId_ = other.cellId_.Clone();
			sinceTimestampMs_ = other.sinceTimestampMs_.Clone();
			latitude_ = other.latitude_;
			longitude_ = other.longitude_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetMapObjectsMessage> Parser
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
				return global::POGOProtos.Networking.Requests.Messages.GetMapObjectsMessageReflection.Descriptor.MessageTypes[0];
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
		/// Gets the cell id.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<ulong> CellId
		{
			get
			{
				return cellId_;
			}
		}

		/// <summary>
		/// Gets the since timestamp ms.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<long> SinceTimestampMs
		{
			get
			{
				return sinceTimestampMs_;
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
		/// The <see cref="GetMapObjectsMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetMapObjectsMessage Clone()
		{
			return new GetMapObjectsMessage(this);
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
		public bool Equals(GetMapObjectsMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!cellId_.Equals(other.cellId_))
			{
				return false;
			}

			if (!sinceTimestampMs_.Equals(other.sinceTimestampMs_))
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
			cellId_.WriteTo(output, _repeated_cellId_codec);
			sinceTimestampMs_.WriteTo(output, _repeated_sinceTimestampMs_codec);
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
			size += cellId_.CalculateSize(_repeated_cellId_codec);
			size += sinceTimestampMs_.CalculateSize(_repeated_sinceTimestampMs_codec);
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
		public void MergeFrom(GetMapObjectsMessage other)
		{
			if (other == null)
			{
				return;
			}

			cellId_.Add(other.cellId_);
			sinceTimestampMs_.Add(other.sinceTimestampMs_);
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
					case 8:
					{
						cellId_.AddEntriesFrom(input, _repeated_cellId_codec);
						break;
					}

					case 18:
					case 16:
					{
						sinceTimestampMs_.AddEntriesFrom(input, _repeated_sinceTimestampMs_codec);
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
			return Equals(other as GetMapObjectsMessage);
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
			hash ^= cellId_.GetHashCode();
			hash ^= sinceTimestampMs_.GetHashCode();
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