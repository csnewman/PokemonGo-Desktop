// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UseItemEggIncubatorResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemEggIncubatorResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/UseItemEggIncubatorResponse.proto</summary>
	public static partial class UseItemEggIncubatorResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/UseItemEggIncubatorResponse.proto</summary>
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
		/// Initializes static members of the <see cref="UseItemEggIncubatorResponseReflection"/> class.
		/// </summary>
		static UseItemEggIncubatorResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkFQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1VzZUl0ZW1FZ2dJ",
						"bmN1YmF0b3JSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5n",
						"LlJlc3BvbnNlcxonUE9HT1Byb3Rvcy9JbnZlbnRvcnkvRWdnSW5jdWJhdG9y",
						"LnByb3RvIp8DChtVc2VJdGVtRWdnSW5jdWJhdG9yUmVzcG9uc2USUwoGcmVz",
						"dWx0GAEgASgOMkMuUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJlc3BvbnNlcy5V",
						"c2VJdGVtRWdnSW5jdWJhdG9yUmVzcG9uc2UuUmVzdWx0EjkKDWVnZ19pbmN1",
						"YmF0b3IYAiABKAsyIi5QT0dPUHJvdG9zLkludmVudG9yeS5FZ2dJbmN1YmF0",
						"b3Ii7wEKBlJlc3VsdBIJCgVVTlNFVBAAEgsKB1NVQ0NFU1MQARIdChlFUlJP",
						"Ul9JTkNVQkFUT1JfTk9UX0ZPVU5EEAISHwobRVJST1JfUE9LRU1PTl9FR0df",
						"Tk9UX0ZPVU5EEAMSHAoYRVJST1JfUE9LRU1PTl9JRF9OT1RfRUdHEAQSIgoe",
						"RVJST1JfSU5DVUJBVE9SX0FMUkVBRFlfSU5fVVNFEAUSJAogRVJST1JfUE9L",
						"RU1PTl9BTFJFQURZX0lOQ1VCQVRJTkcQBhIlCiFFUlJPUl9JTkNVQkFUT1Jf",
						"Tk9fVVNFU19SRU1BSU5JTkcQB2IGcHJvdG8z"));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Inventory.EggIncubatorReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponse),
							global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponse.Parser,
							new[] { "Result", "EggIncubator" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The use item egg incubator response.
	/// </summary>
	public sealed partial class UseItemEggIncubatorResponse : pb::IMessage<UseItemEggIncubatorResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>Field number for the "egg_incubator" field.</summary>
		public const int EggIncubatorFieldNumber = 2;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<UseItemEggIncubatorResponse> _parser =
			new pb::MessageParser<UseItemEggIncubatorResponse>(() => new UseItemEggIncubatorResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The egg incubator_.
		/// </summary>
		private EggIncubator eggIncubator_;

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="UseItemEggIncubatorResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemEggIncubatorResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="UseItemEggIncubatorResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemEggIncubatorResponse(UseItemEggIncubatorResponse other) : this()
		{
			result_ = other.result_;
			EggIncubator = other.eggIncubator_ != null ? other.EggIncubator.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<UseItemEggIncubatorResponse> Parser
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
				return global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the egg incubator.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public EggIncubator EggIncubator
		{
			get
			{
				return eggIncubator_;
			}

			set
			{
				eggIncubator_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="UseItemEggIncubatorResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public UseItemEggIncubatorResponse Clone()
		{
			return new UseItemEggIncubatorResponse(this);
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
		public bool Equals(UseItemEggIncubatorResponse other)
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

			if (!object.Equals(EggIncubator, other.EggIncubator))
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

			if (eggIncubator_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(EggIncubator);
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

			if (eggIncubator_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(EggIncubator);
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
		public void MergeFrom(UseItemEggIncubatorResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
			}

			if (other.eggIncubator_ != null)
			{
				if (eggIncubator_ == null)
				{
					eggIncubator_ = new global::POGOProtos.Inventory.EggIncubator();
				}

				EggIncubator.MergeFrom(other.EggIncubator);
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
						result_ = (global::POGOProtos.Networking.Responses.UseItemEggIncubatorResponse.Types.Result)input.ReadEnum();
						break;
					}

					case 18:
					{
						if (eggIncubator_ == null)
						{
							eggIncubator_ = new global::POGOProtos.Inventory.EggIncubator();
						}

						input.ReadMessage(eggIncubator_);
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
			return Equals(other as UseItemEggIncubatorResponse);
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

			if (eggIncubator_ != null)
			{
				hash ^= EggIncubator.GetHashCode();
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

		/// <summary>Container for nested types declared in the UseItemEggIncubatorResponse message type.</summary>
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
				/// The error incubator not found.
				/// </summary>
				[pbr::OriginalName("ERROR_INCUBATOR_NOT_FOUND")] ErrorIncubatorNotFound = 2,

				/// <summary>
				/// The error pokemon egg not found.
				/// </summary>
				[pbr::OriginalName("ERROR_POKEMON_EGG_NOT_FOUND")] ErrorPokemonEggNotFound = 3,

				/// <summary>
				/// The error pokemon id not egg.
				/// </summary>
				[pbr::OriginalName("ERROR_POKEMON_ID_NOT_EGG")] ErrorPokemonIdNotEgg = 4,

				/// <summary>
				/// The error incubator already in use.
				/// </summary>
				[pbr::OriginalName("ERROR_INCUBATOR_ALREADY_IN_USE")] ErrorIncubatorAlreadyInUse = 5,

				/// <summary>
				/// The error pokemon already incubating.
				/// </summary>
				[pbr::OriginalName("ERROR_POKEMON_ALREADY_INCUBATING")] ErrorPokemonAlreadyIncubating = 6,

				/// <summary>
				/// The error incubator no uses remaining.
				/// </summary>
				[pbr::OriginalName("ERROR_INCUBATOR_NO_USES_REMAINING")] ErrorIncubatorNoUsesRemaining = 7,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code