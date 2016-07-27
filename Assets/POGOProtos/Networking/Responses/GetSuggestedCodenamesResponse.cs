// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetSuggestedCodenamesResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/GetSuggestedCodenamesResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetSuggestedCodenamesResponse.proto</summary>
	public static partial class GetSuggestedCodenamesResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/GetSuggestedCodenamesResponse.proto</summary>
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
		/// Initializes static members of the <see cref="GetSuggestedCodenamesResponseReflection"/> class.
		/// </summary>
		static GetSuggestedCodenamesResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkNQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldFN1Z2dlc3Rl",
						"ZENvZGVuYW1lc1Jlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtp",
						"bmcuUmVzcG9uc2VzIkMKHUdldFN1Z2dlc3RlZENvZGVuYW1lc1Jlc3BvbnNl",
						"EhEKCWNvZGVuYW1lcxgBIAMoCRIPCgdzdWNjZXNzGAIgASgIYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.GetSuggestedCodenamesResponse),
							global::POGOProtos.Networking.Responses.GetSuggestedCodenamesResponse.Parser,
							new[] { "Codenames", "Success" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The get suggested codenames response.
	/// </summary>
	public sealed partial class GetSuggestedCodenamesResponse : pb::IMessage<GetSuggestedCodenamesResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "codenames" field.</summary>
		public const int CodenamesFieldNumber = 1;

		/// <summary>Field number for the "success" field.</summary>
		public const int SuccessFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetSuggestedCodenamesResponse> _parser =
			new pb::MessageParser<GetSuggestedCodenamesResponse>(() => new GetSuggestedCodenamesResponse());

		/// <summary>
		/// The _repeated_codenames_codec.
		/// </summary>
		private static readonly pb.FieldCodec<string> _repeated_codenames_codec = pb::FieldCodec.ForString(10);

		#endregion

		#region  Fields

		/// <summary>
		/// The codenames_.
		/// </summary>
		private readonly pbc.RepeatedField<string> codenames_ = new pbc::RepeatedField<string>();

		/// <summary>
		/// The success_.
		/// </summary>
		private bool success_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetSuggestedCodenamesResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetSuggestedCodenamesResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetSuggestedCodenamesResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetSuggestedCodenamesResponse(GetSuggestedCodenamesResponse other) : this()
		{
			codenames_ = other.codenames_.Clone();
			success_ = other.success_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetSuggestedCodenamesResponse> Parser
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
				return global::POGOProtos.Networking.Responses.GetSuggestedCodenamesResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets the codenames.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<string> Codenames
		{
			get
			{
				return codenames_;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether success.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool Success
		{
			get
			{
				return success_;
			}

			set
			{
				success_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GetSuggestedCodenamesResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetSuggestedCodenamesResponse Clone()
		{
			return new GetSuggestedCodenamesResponse(this);
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
		public bool Equals(GetSuggestedCodenamesResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (!codenames_.Equals(other.codenames_))
			{
				return false;
			}

			if (Success != other.Success)
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
			codenames_.WriteTo(output, _repeated_codenames_codec);
			if (Success != false)
			{
				output.WriteRawTag(16);
				output.WriteBool(Success);
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
			size += codenames_.CalculateSize(_repeated_codenames_codec);
			if (Success != false)
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
		public void MergeFrom(GetSuggestedCodenamesResponse other)
		{
			if (other == null)
			{
				return;
			}

			codenames_.Add(other.codenames_);
			if (other.Success != false)
			{
				Success = other.Success;
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
						codenames_.AddEntriesFrom(input, _repeated_codenames_codec);
						break;
					}

					case 16:
					{
						Success = input.ReadBool();
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
			return Equals(other as GetSuggestedCodenamesResponse);
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
			hash ^= codenames_.GetHashCode();
			if (Success != false)
			{
				hash ^= Success.GetHashCode();
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