// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Request.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Request.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Requests
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Request.proto</summary>
	public static partial class RequestReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Request.proto</summary>
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
		/// Initializes static members of the <see cref="RequestReflection"/> class.
		/// </summary>
		static RequestReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CixQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvUmVxdWVzdC5wcm90",
						"bxIeUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlcXVlc3RzGjBQT0dPUHJvdG9z",
						"L05ldHdvcmtpbmcvUmVxdWVzdHMvUmVxdWVzdFR5cGUucHJvdG8iZQoHUmVx",
						"dWVzdBJBCgxyZXF1ZXN0X3R5cGUYASABKA4yKy5QT0dPUHJvdG9zLk5ldHdv",
						"cmtpbmcuUmVxdWVzdHMuUmVxdWVzdFR5cGUSFwoPcmVxdWVzdF9tZXNzYWdl",
						"GAIgASgMYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Networking.Requests.RequestTypeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Request),
							global::POGOProtos.Networking.Requests.Request.Parser,
							new[] { "RequestType", "RequestMessage" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The request.
	/// </summary>
	public sealed partial class Request : pb::IMessage<Request>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "request_type" field.</summary>
		public const int RequestTypeFieldNumber = 1;

		/// <summary>Field number for the "request_message" field.</summary>
		public const int RequestMessageFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<Request> _parser = new pb::MessageParser<Request>(() => new Request());

		#endregion

		#region  Fields

		/// <summary>
		/// The request message_.
		/// </summary>
		private pb.ByteString requestMessage_ = pb::ByteString.Empty;

		/// <summary>
		/// The request type_.
		/// </summary>
		private RequestType requestType_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="Request"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Request()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Request"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Request(Request other) : this()
		{
			requestType_ = other.requestType_;
			requestMessage_ = other.requestMessage_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<Request> Parser
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
				return global::POGOProtos.Networking.Requests.RequestReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the request type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public RequestType RequestType
		{
			get
			{
				return requestType_;
			}

			set
			{
				requestType_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the request message.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pb.ByteString RequestMessage
		{
			get
			{
				return requestMessage_;
			}

			set
			{
				requestMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="Request"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Request Clone()
		{
			return new Request(this);
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
		public bool Equals(Request other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (RequestType != other.RequestType)
			{
				return false;
			}

			if (RequestMessage != other.RequestMessage)
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
			if (RequestType != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)RequestType);
			}

			if (RequestMessage.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteBytes(RequestMessage);
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
			if (RequestType != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)RequestType);
			}

			if (RequestMessage.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeBytesSize(RequestMessage);
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
		public void MergeFrom(Request other)
		{
			if (other == null)
			{
				return;
			}

			if (other.RequestType != 0)
			{
				RequestType = other.RequestType;
			}

			if (other.RequestMessage.Length != 0)
			{
				RequestMessage = other.RequestMessage;
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
						requestType_ = (global::POGOProtos.Networking.Requests.RequestType)input.ReadEnum();
						break;
					}

					case 18:
					{
						RequestMessage = input.ReadBytes();
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
			return Equals(other as Request);
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
			if (RequestType != 0)
			{
				hash ^= RequestType.GetHashCode();
			}

			if (RequestMessage.Length != 0)
			{
				hash ^= RequestMessage.GetHashCode();
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