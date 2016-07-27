// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EquipBadgeResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/EquipBadgeResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Data.Player;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/EquipBadgeResponse.proto</summary>
	public static partial class EquipBadgeResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/EquipBadgeResponse.proto</summary>
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
		/// Initializes static members of the <see cref="EquipBadgeResponseReflection"/> class.
		/// </summary>
		static EquipBadgeResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjhQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0VxdWlwQmFkZ2VS",
						"ZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNl",
						"cxoqUE9HT1Byb3Rvcy9EYXRhL1BsYXllci9FcXVpcHBlZEJhZGdlLnByb3Rv",
						"IuMBChJFcXVpcEJhZGdlUmVzcG9uc2USSgoGcmVzdWx0GAEgASgOMjouUE9H",
						"T1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5FcXVpcEJhZGdlUmVzcG9u",
						"c2UuUmVzdWx0EjcKCGVxdWlwcGVkGAIgASgLMiUuUE9HT1Byb3Rvcy5EYXRh",
						"LlBsYXllci5FcXVpcHBlZEJhZGdlIkgKBlJlc3VsdBIJCgVVTlNFVBAAEgsK",
						"B1NVQ0NFU1MQARITCg9DT09MRE9XTl9BQ1RJVkUQAhIRCg1OT1RfUVVBTElG",
						"SUVEEANiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Data.Player.EquippedBadgeReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.EquipBadgeResponse),
							global::POGOProtos.Networking.Responses.EquipBadgeResponse.Parser,
							new[] { "Result", "Equipped" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.EquipBadgeResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The equip badge response.
	/// </summary>
	public sealed partial class EquipBadgeResponse : pb::IMessage<EquipBadgeResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "equipped" field.</summary>
		public const int EquippedFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<EquipBadgeResponse> _parser =
			new pb::MessageParser<EquipBadgeResponse>(() => new EquipBadgeResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The equipped_.
		/// </summary>
		private EquippedBadge equipped_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="EquipBadgeResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquipBadgeResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="EquipBadgeResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquipBadgeResponse(EquipBadgeResponse other) : this()
		{
			result_ = other.result_;
			Equipped = other.equipped_ != null ? other.Equipped.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<EquipBadgeResponse> Parser
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
				return global::POGOProtos.Networking.Responses.EquipBadgeResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the equipped.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquippedBadge Equipped
		{
			get
			{
				return equipped_;
			}

			set
			{
				equipped_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="EquipBadgeResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EquipBadgeResponse Clone()
		{
			return new EquipBadgeResponse(this);
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
		public bool Equals(EquipBadgeResponse other)
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

			if (!object.Equals(Equipped, other.Equipped))
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

			if (equipped_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(Equipped);
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

			if (equipped_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Equipped);
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
		public void MergeFrom(EquipBadgeResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.equipped_ != null)
			{
				if (equipped_ == null)
				{
					equipped_ = new global::POGOProtos.Data.Player.EquippedBadge();
				}

				Equipped.MergeFrom(other.Equipped);
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
						result_ = (global::POGOProtos.Networking.Responses.EquipBadgeResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						if (equipped_ == null)
						{
							equipped_ = new global::POGOProtos.Data.Player.EquippedBadge();
						}

						input.ReadMessage(equipped_);
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
			return Equals(other as EquipBadgeResponse);
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

			if (equipped_ != null)
			{
				hash ^= Equipped.GetHashCode();
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

		/// <summary>Container for nested types declared in the EquipBadgeResponse message type.</summary>
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
				/// The cooldown active.
				/// </summary>
				[pbr::OriginalName("COOLDOWN_ACTIVE")] CooldownActive = 2,

				/// <summary>
				/// The not qualified.
				/// </summary>
				[pbr::OriginalName("NOT_QUALIFIED")] NotQualified = 3,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code