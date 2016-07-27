// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UseItemXpBoostResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemXpBoostResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemXpBoostResponse.proto</summary>
	public static partial class UseItemXpBoostResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/UseItemXpBoostResponse.proto</summary>
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
		/// Initializes static members of the <see cref="UseItemXpBoostResponseReflection"/> class.
		/// </summary>
		static UseItemXpBoostResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUl0ZW1YcEJv",
						"b3N0UmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
						"b25zZXMaJ1BPR09Qcm90b3MvSW52ZW50b3J5L0FwcGxpZWRJdGVtcy5wcm90",
						"byK+AgoWVXNlSXRlbVhwQm9vc3RSZXNwb25zZRJOCgZyZXN1bHQYASABKA4y",
						"Pi5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2VzLlVzZUl0ZW1YcEJv",
						"b3N0UmVzcG9uc2UuUmVzdWx0EjkKDWFwcGxpZWRfaXRlbXMYAiABKAsyIi5Q",
						"T0dPUHJvdG9zLkludmVudG9yeS5BcHBsaWVkSXRlbXMimAEKBlJlc3VsdBIJ",
						"CgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIbChdFUlJPUl9JTlZBTElEX0lURU1f",
						"VFlQRRACEiEKHUVSUk9SX1hQX0JPT1NUX0FMUkVBRFlfQUNUSVZFEAMSHAoY",
						"RVJST1JfTk9fSVRFTVNfUkVNQUlOSU5HEAQSGAoURVJST1JfTE9DQVRJT05f",
						"VU5TRVQQBWIGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.AppliedItemsReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.UseItemXpBoostResponse),
							global::POGOProtos.Networking.Responses.UseItemXpBoostResponse.Parser,
							new[] { "Result", "AppliedItems" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.UseItemXpBoostResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The use item xp boost response.
	/// </summary>
	public sealed partial class UseItemXpBoostResponse : pb::IMessage<UseItemXpBoostResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "applied_items" field.</summary>
		public const int AppliedItemsFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<UseItemXpBoostResponse> _parser =
			new pb::MessageParser<UseItemXpBoostResponse>(() => new UseItemXpBoostResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The applied items_.
		/// </summary>
		private AppliedItems appliedItems_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="UseItemXpBoostResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemXpBoostResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UseItemXpBoostResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemXpBoostResponse(UseItemXpBoostResponse other) : this()
		{
			result_ = other.result_;
			AppliedItems = other.appliedItems_ != null ? other.AppliedItems.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<UseItemXpBoostResponse> Parser
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
				return global::POGOProtos.Networking.Responses.UseItemXpBoostResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the applied items.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public AppliedItems AppliedItems
		{
			get
			{
				return appliedItems_;
			}

			set
			{
				appliedItems_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="UseItemXpBoostResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemXpBoostResponse Clone()
		{
			return new UseItemXpBoostResponse(this);
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
		public bool Equals(UseItemXpBoostResponse other)
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

			if (!object.Equals(AppliedItems, other.AppliedItems))
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

			if (appliedItems_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(AppliedItems);
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

			if (appliedItems_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(AppliedItems);
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
		public void MergeFrom(UseItemXpBoostResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.appliedItems_ != null)
			{
				if (appliedItems_ == null)
				{
					appliedItems_ = new global::POGOProtos.Inventory.AppliedItems();
				}

				AppliedItems.MergeFrom(other.AppliedItems);
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
						result_ = (global::POGOProtos.Networking.Responses.UseItemXpBoostResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						if (appliedItems_ == null)
						{
							appliedItems_ = new global::POGOProtos.Inventory.AppliedItems();
						}

						input.ReadMessage(appliedItems_);
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
			return Equals(other as UseItemXpBoostResponse);
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

			if (appliedItems_ != null)
			{
				hash ^= AppliedItems.GetHashCode();
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

		/// <summary>Container for nested types declared in the UseItemXpBoostResponse message type.</summary>
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
				/// The unset.
				/// </summary>
				[pbr::OriginalName("UNSET")] Unset = 0,

				/// <summary>
				/// The success.
				/// </summary>
				[pbr::OriginalName("SUCCESS")] Success = 1,

				/// <summary>
				/// The error invalid item type.
				/// </summary>
				[pbr::OriginalName("ERROR_INVALID_ITEM_TYPE")] ErrorInvalidItemType = 2,

				/// <summary>
				/// The error xp boost already active.
				/// </summary>
				[pbr::OriginalName("ERROR_XP_BOOST_ALREADY_ACTIVE")] ErrorXpBoostAlreadyActive = 3,

				/// <summary>
				/// The error no items remaining.
				/// </summary>
				[pbr::OriginalName("ERROR_NO_ITEMS_REMAINING")] ErrorNoItemsRemaining = 4,

				/// <summary>
				/// The error location unset.
				/// </summary>
				[pbr::OriginalName("ERROR_LOCATION_UNSET")] ErrorLocationUnset = 5,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code