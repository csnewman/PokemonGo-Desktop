// --------------------------------------------------------------------------------------------------------------------
// <copyright file="GetSuggestedCodenamesMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GetSuggestedCodenamesMessage.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/GetSuggestedCodenamesMessage.proto</summary>
	public static partial class GetSuggestedCodenamesMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/GetSuggestedCodenamesMessage.proto</summary>
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
		/// Initializes static members of the <see cref="GetSuggestedCodenamesMessageReflection"/> class.
		/// </summary>
		static GetSuggestedCodenamesMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkpQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvR2V0",
						"U3VnZ2VzdGVkQ29kZW5hbWVzTWVzc2FnZS5wcm90bxInUE9HT1Byb3Rvcy5O",
						"ZXR3b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzIh4KHEdldFN1Z2dlc3RlZENv",
						"ZGVuYW1lc01lc3NhZ2ViBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.GetSuggestedCodenamesMessage),
							global::POGOProtos.Networking.Requests.Messages.GetSuggestedCodenamesMessage.Parser,
							null,
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	///  No message needed.
	/// </summary>
	public sealed partial class GetSuggestedCodenamesMessage : pb::IMessage<GetSuggestedCodenamesMessage>
	{
		#region Static Fields and Constants

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<GetSuggestedCodenamesMessage> _parser =
			new pb::MessageParser<GetSuggestedCodenamesMessage>(() => new GetSuggestedCodenamesMessage());

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="GetSuggestedCodenamesMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetSuggestedCodenamesMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="GetSuggestedCodenamesMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetSuggestedCodenamesMessage(GetSuggestedCodenamesMessage other) : this()
		{
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<GetSuggestedCodenamesMessage> Parser
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
				return
					global::POGOProtos.Networking.Requests.Messages.GetSuggestedCodenamesMessageReflection.Descriptor.MessageTypes[0];
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

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="GetSuggestedCodenamesMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GetSuggestedCodenamesMessage Clone()
		{
			return new GetSuggestedCodenamesMessage(this);
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
		public bool Equals(GetSuggestedCodenamesMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
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
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(GetSuggestedCodenamesMessage other)
		{
			if (other == null)
			{
				return;
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
			return Equals(other as GetSuggestedCodenamesMessage);
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