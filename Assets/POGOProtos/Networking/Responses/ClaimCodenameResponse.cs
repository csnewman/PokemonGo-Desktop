// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ClaimCodenameResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/ClaimCodenameResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/ClaimCodenameResponse.proto</summary>
	public static partial class ClaimCodenameResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/ClaimCodenameResponse.proto</summary>
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
		/// Initializes static members of the <see cref="ClaimCodenameResponseReflection"/> class.
		/// </summary>
		static ClaimCodenameResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjtQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0NsYWltQ29kZW5h",
						"bWVSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3Bv",
						"bnNlcyKwAgoVQ2xhaW1Db2RlbmFtZVJlc3BvbnNlEhAKCGNvZGVuYW1lGAEg",
						"ASgJEhQKDHVzZXJfbWVzc2FnZRgCIAEoCRIVCg1pc19hc3NpZ25hYmxlGAMg",
						"ASgIEk0KBnN0YXR1cxgEIAEoDjI9LlBPR09Qcm90b3MuTmV0d29ya2luZy5S",
						"ZXNwb25zZXMuQ2xhaW1Db2RlbmFtZVJlc3BvbnNlLlN0YXR1cyKIAQoGU3Rh",
						"dHVzEgkKBVVOU0VUEAASCwoHU1VDQ0VTUxABEhoKFkNPREVOQU1FX05PVF9B",
						"VkFJTEFCTEUQAhIWChJDT0RFTkFNRV9OT1RfVkFMSUQQAxIRCg1DVVJSRU5U",
						"X09XTkVSEAQSHwobQ09ERU5BTUVfQ0hBTkdFX05PVF9BTExPV0VEEAViBnBy",
						"b3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.ClaimCodenameResponse),
							global::POGOProtos.Networking.Responses.ClaimCodenameResponse.Parser,
							new[] { "Codename", "UserMessage", "IsAssignable", "Status" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.ClaimCodenameResponse.Types.Status) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	///  TODO: Might be incorrect, please test.
	/// </summary>
	public sealed partial class ClaimCodenameResponse : pb::IMessage<ClaimCodenameResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "codename" field.</summary>
		public const int CodenameFieldNumber = 1;

		/// <summary>Field number for the "user_message" field.</summary>
		public const int UserMessageFieldNumber = 2;

		/// <summary>Field number for the "is_assignable" field.</summary>
		public const int IsAssignableFieldNumber = 3;

		/// <summary>Field number for the "status" field.</summary>
		public const int StatusFieldNumber = 4;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<ClaimCodenameResponse> _parser =
			new pb::MessageParser<ClaimCodenameResponse>(() => new ClaimCodenameResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The codename_.
		/// </summary>
		private string codename_ = string.Empty;

		/// <summary>
		/// The is assignable_.
		/// </summary>
		private bool isAssignable_;

		/// <summary>
		/// The status_.
		/// </summary>
		private Types.Status status_ = 0;

		/// <summary>
		/// The user message_.
		/// </summary>
		private string userMessage_ = string.Empty;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimCodenameResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ClaimCodenameResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="ClaimCodenameResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ClaimCodenameResponse(ClaimCodenameResponse other) : this()
		{
			codename_ = other.codename_;
			userMessage_ = other.userMessage_;
			isAssignable_ = other.isAssignable_;
			status_ = other.status_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<ClaimCodenameResponse> Parser
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
				return global::POGOProtos.Networking.Responses.ClaimCodenameResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the codename.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Codename
		{
			get
			{
				return codename_;
			}

			set
			{
				codename_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the user message.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string UserMessage
		{
			get
			{
				return userMessage_;
			}

			set
			{
				userMessage_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether is assignable.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool IsAssignable
		{
			get
			{
				return isAssignable_;
			}

			set
			{
				isAssignable_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the status.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Types.Status Status
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
		/// The <see cref="ClaimCodenameResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public ClaimCodenameResponse Clone()
		{
			return new ClaimCodenameResponse(this);
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
		public bool Equals(ClaimCodenameResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Codename != other.Codename)
			{
				return false;
			}

			if (UserMessage != other.UserMessage)
			{
				return false;
			}

			if (IsAssignable != other.IsAssignable)
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
			if (Codename.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Codename);
			}

			if (UserMessage.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(UserMessage);
			}

			if (IsAssignable != false)
			{
				output.WriteRawTag(24);
				output.WriteBool(IsAssignable);
			}

			if (Status != 0)
			{
				output.WriteRawTag(32);
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
			if (Codename.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Codename);
			}

			if (UserMessage.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(UserMessage);
			}

			if (IsAssignable != false)
			{
				size += 1 + 1;
			}

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
		public void MergeFrom(ClaimCodenameResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Codename.Length != 0)
			{
				Codename = other.Codename;
			}

			if (other.UserMessage.Length != 0)
			{
				UserMessage = other.UserMessage;
			}

			if (other.IsAssignable != false)
			{
				IsAssignable = other.IsAssignable;
			}

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
						Codename = input.ReadString();
						break;
					}

					case 18:
					{
						UserMessage = input.ReadString();
						break;
					}

					case 24:
					{
						IsAssignable = input.ReadBool();
						break;
					}

					case 32:
					{
						status_ = (global::POGOProtos.Networking.Responses.ClaimCodenameResponse.Types.Status)input.ReadEnum();
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
			return Equals(other as ClaimCodenameResponse);
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
			if (Codename.Length != 0)
			{
				hash ^= Codename.GetHashCode();
			}

			if (UserMessage.Length != 0)
			{
				hash ^= UserMessage.GetHashCode();
			}

			if (IsAssignable != false)
			{
				hash ^= IsAssignable.GetHashCode();
			}

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

		#region Nested types

		/// <summary>Container for nested types declared in the ClaimCodenameResponse message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			#region Enums

			/// <summary>
			/// The status.
			/// </summary>
			public enum Status
			{
				/// <summary>
				/// The unset.
				/// </summary>
				[pbr::OriginalName("UNSET")] Unset = 0,

				/// <summary>
				/// The success.
				/// </summary>
				[pbr::OriginalName("SUCCESS")] Success = 1,

				/// <summary>
				/// The codename not available.
				/// </summary>
				[pbr::OriginalName("CODENAME_NOT_AVAILABLE")] CodenameNotAvailable = 2,

				/// <summary>
				/// The codename not valid.
				/// </summary>
				[pbr::OriginalName("CODENAME_NOT_VALID")] CodenameNotValid = 3,

				/// <summary>
				/// The current owner.
				/// </summary>
				[pbr::OriginalName("CURRENT_OWNER")] CurrentOwner = 4,

				/// <summary>
				/// The codename change not allowed.
				/// </summary>
				[pbr::OriginalName("CODENAME_CHANGE_NOT_ALLOWED")] CodenameChangeNotAllowed = 5,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code