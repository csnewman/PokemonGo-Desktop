// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetMapObjectsResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/GetMapObjectsResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Map;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetMapObjectsResponse.proto</summary>
	public static partial class GetMapObjectsResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/GetMapObjectsResponse.proto</summary>
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
		/// Initializes static members of the <see cref="GetMapObjectsResponseReflection"/> class.
		/// </summary>
		static GetMapObjectsResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjtQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldE1hcE9iamVj",
						"dHNSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
						"bnNlcxocUE9HT1Byb3Rvcy9NYXAvTWFwQ2VsbC5wcm90bxolUE9HT1Byb3Rv",
						"cy9NYXAvTWFwT2JqZWN0c1N0YXR1cy5wcm90byJ1ChVHZXRNYXBPYmplY3Rz",
						"UmVzcG9uc2USKgoJbWFwX2NlbGxzGAEgAygLMhcuUE9HT1Byb3Rvcy5NYXAu",
						"TWFwQ2VsbBIwCgZzdGF0dXMYAiABKA4yIC5QT0dPUHJvdG9zLk1hcC5NYXBP",
						"YmplY3RzU3RhdHVzYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Map.MapCellReflection.Descriptor, global::POGOProtos.Map.MapObjectsStatusReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.GetMapObjectsResponse),
							global::POGOProtos.Networking.Responses.GetMapObjectsResponse.Parser,
							new[] { "MapCells", "Status" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The get map objects response.
	/// </summary>
	public sealed partial class GetMapObjectsResponse : pb::IMessage<GetMapObjectsResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "map_cells" field.</summary>
		public const int MapCellsFieldNumber = 1;

		/// <summary>Field number for the "status" field.</summary>
		public const int StatusFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetMapObjectsResponse> _parser =
			new pb::MessageParser<GetMapObjectsResponse>(() => new GetMapObjectsResponse());

		/// <summary>
		/// The _repeated_map cells_codec.
		/// </summary>
		private static readonly pb.FieldCodec<MapCell> _repeated_mapCells_codec = pb::FieldCodec.ForMessage(
			10,
			global::POGOProtos.Map.MapCell.Parser);

		#endregion

		#region  Fields

		/// <summary>
		/// The map cells_.
		/// </summary>
		private readonly pbc.RepeatedField<MapCell> mapCells_ = new pbc::RepeatedField<MapCell>();

		/// <summary>
		/// The status_.
		/// </summary>
		private MapObjectsStatus status_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetMapObjectsResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetMapObjectsResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetMapObjectsResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetMapObjectsResponse(GetMapObjectsResponse other) : this()
		{
			mapCells_ = other.mapCells_.Clone();
			status_ = other.status_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetMapObjectsResponse> Parser
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
				return global::POGOProtos.Networking.Responses.GetMapObjectsResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets the map cells.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<MapCell> MapCells
		{
			get
			{
				return mapCells_;
			}
		}

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public MapObjectsStatus Status
		{
			get
			{
				return status_;
			}

			set
			{
				status_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GetMapObjectsResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetMapObjectsResponse Clone()
		{
			return new GetMapObjectsResponse(this);
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
		public bool Equals(GetMapObjectsResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!mapCells_.Equals(other.mapCells_))
			{
				return false;
			}

			if (Status != other.Status)
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
			mapCells_.WriteTo(output, _repeated_mapCells_codec);
			if (Status != 0)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)Status);
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
			size += mapCells_.CalculateSize(_repeated_mapCells_codec);
			if (Status != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Status);
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
		public void MergeFrom(GetMapObjectsResponse other)
		{
			if (other == null)
			{
				return;
			}

			mapCells_.Add(other.mapCells_);
			if (other.Status != 0)
			{
				Status = other.Status;
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
						mapCells_.AddEntriesFrom(input, _repeated_mapCells_codec);
						break;
					}

					case 16:
					{
						status_ = (global::POGOProtos.Map.MapObjectsStatus)input.ReadEnum();
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
			return Equals(other as GetMapObjectsResponse);
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
			hash ^= mapCells_.GetHashCode();
			if (Status != 0)
			{
				hash ^= Status.GetHashCode();
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