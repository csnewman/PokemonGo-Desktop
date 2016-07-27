// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UseIncenseResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/UseIncenseResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Inventory;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/UseIncenseResponse.proto</summary>
	public static partial class UseIncenseResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/UseIncenseResponse.proto</summary>
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
		/// Initializes static members of the <see cref="UseIncenseResponseReflection"/> class.
		/// </summary>
		static UseIncenseResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjhQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUluY2Vuc2VS",
						"ZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNl",
						"cxomUE9HT1Byb3Rvcy9JbnZlbnRvcnkvQXBwbGllZEl0ZW0ucHJvdG8ihwIK",
						"ElVzZUluY2Vuc2VSZXNwb25zZRJKCgZyZXN1bHQYASABKA4yOi5QT0dPUHJv",
						"dG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLlVzZUluY2Vuc2VSZXNwb25zZS5S",
						"ZXN1bHQSOgoPYXBwbGllZF9pbmNlbnNlGAIgASgLMiEuUE9HT1Byb3Rvcy5J",
						"bnZlbnRvcnkuQXBwbGllZEl0ZW0iaQoGUmVzdWx0EgsKB1VOS05PV04QABIL",
						"CgdTVUNDRVNTEAESGgoWSU5DRU5TRV9BTFJFQURZX0FDVElWRRACEhUKEU5P",
						"TkVfSU5fSU5WRU5UT1JZEAMSEgoOTE9DQVRJT05fVU5TRVQQBGIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.AppliedItemReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.UseIncenseResponse),
							global::POGOProtos.Networking.Responses.UseIncenseResponse.Parser,
							new[] { "Result", "AppliedIncense" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.UseIncenseResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The use incense response.
	/// </summary>
	public sealed partial class UseIncenseResponse : pb::IMessage<UseIncenseResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "applied_incense" field.</summary>
		public const int AppliedIncenseFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<UseIncenseResponse> _parser =
			new pb::MessageParser<UseIncenseResponse>(() => new UseIncenseResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The applied incense_.
		/// </summary>
		private AppliedItem appliedIncense_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="UseIncenseResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseIncenseResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UseIncenseResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseIncenseResponse(UseIncenseResponse other) : this()
		{
			result_ = other.result_;
			AppliedIncense = other.appliedIncense_ != null ? other.AppliedIncense.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<UseIncenseResponse> Parser
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
				return global::POGOProtos.Networking.Responses.UseIncenseResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the result.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Types.Result Result
		{
			get
			{
				return result_;
			}

			set
			{
				result_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the applied incense.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AppliedItem AppliedIncense
		{
			get
			{
				return appliedIncense_;
			}

			set
			{
				appliedIncense_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="UseIncenseResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseIncenseResponse Clone()
		{
			return new UseIncenseResponse(this);
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
		public bool Equals(UseIncenseResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Result != other.Result)
			{
				return false;
			}

			if (!object.Equals(AppliedIncense, other.AppliedIncense))
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
			if (Result != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)Result);
			}

			if (appliedIncense_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(AppliedIncense);
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
			if (Result != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Result);
			}

			if (appliedIncense_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppliedIncense);
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
		public void MergeFrom(UseIncenseResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.appliedIncense_ != null)
			{
				if (appliedIncense_ == null)
				{
					appliedIncense_ = new global::POGOProtos.Inventory.AppliedItem();
				}

				AppliedIncense.MergeFrom(other.AppliedIncense);
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
						result_ = (global::POGOProtos.Networking.Responses.UseIncenseResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						if (appliedIncense_ == null)
						{
							appliedIncense_ = new global::POGOProtos.Inventory.AppliedItem();
						}

						input.ReadMessage(appliedIncense_);
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
			return Equals(other as UseIncenseResponse);
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
			if (Result != 0)
			{
				hash ^= Result.GetHashCode();
			}

			if (appliedIncense_ != null)
			{
				hash ^= AppliedIncense.GetHashCode();
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

		/// <summary>Container for nested types declared in the UseIncenseResponse message type.</summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static partial class Types
		{
			#region Enums

			/// <summary>
			/// The result.
			/// </summary>
			public enum Result
			{
				/// <summary>
				/// The unknown.
				/// </summary>
				[pbr::OriginalName("UNKNOWN")] Unknown = 0,

				/// <summary>
				/// The success.
				/// </summary>
				[pbr::OriginalName("SUCCESS")] Success = 1,

				/// <summary>
				/// The incense already active.
				/// </summary>
				[pbr::OriginalName("INCENSE_ALREADY_ACTIVE")] IncenseAlreadyActive = 2,

				/// <summary>
				/// The none in inventory.
				/// </summary>
				[pbr::OriginalName("NONE_IN_INVENTORY")] NoneInInventory = 3,

				/// <summary>
				/// The location unset.
				/// </summary>
				[pbr::OriginalName("LOCATION_UNSET")] LocationUnset = 4,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code