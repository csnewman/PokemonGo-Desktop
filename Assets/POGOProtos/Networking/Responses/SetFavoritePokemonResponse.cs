// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SetFavoritePokemonResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/SetFavoritePokemonResponse.proto
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
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/SetFavoritePokemonResponse.proto</summary>
	public static partial class SetFavoritePokemonResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/SetFavoritePokemonResponse.proto</summary>
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
		/// Initializes static members of the <see cref="SetFavoritePokemonResponseReflection"/> class.
		/// </summary>
		static SetFavoritePokemonResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CkBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL1NldEZhdm9yaXRl",
						"UG9rZW1vblJlc3BvbnNlLnByb3RvEh9QT0dPUHJvdG9zLk5ldHdvcmtpbmcu",
						"UmVzcG9uc2VzIskBChpTZXRGYXZvcml0ZVBva2Vtb25SZXNwb25zZRJSCgZy",
						"ZXN1bHQYASABKA4yQi5QT0dPUHJvdG9zLk5ldHdvcmtpbmcuUmVzcG9uc2Vz",
						"LlNldEZhdm9yaXRlUG9rZW1vblJlc3BvbnNlLlJlc3VsdCJXCgZSZXN1bHQS",
						"CQoFVU5TRVQQABILCgdTVUNDRVNTEAESGwoXRVJST1JfUE9LRU1PTl9OT1Rf",
						"Rk9VTkQQAhIYChRFUlJPUl9QT0tFTU9OX0lTX0VHRxADYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.SetFavoritePokemonResponse),
							global::POGOProtos.Networking.Responses.SetFavoritePokemonResponse.Parser,
							new[] { "Result" },
							null,
							new[] { typeof(global::POGOProtos.Networking.Responses.SetFavoritePokemonResponse.Types.Result) },
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The set favorite pokemon response.
	/// </summary>
	public sealed partial class SetFavoritePokemonResponse : pb::IMessage<SetFavoritePokemonResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "result" field.</summary>
		public const int ResultFieldNumber = 1;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<SetFavoritePokemonResponse> _parser =
			new pb::MessageParser<SetFavoritePokemonResponse>(() => new SetFavoritePokemonResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The result_.
		/// </summary>
		private Types.Result result_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="SetFavoritePokemonResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetFavoritePokemonResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SetFavoritePokemonResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetFavoritePokemonResponse(SetFavoritePokemonResponse other) : this()
		{
			result_ = other.result_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<SetFavoritePokemonResponse> Parser
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
				return global::POGOProtos.Networking.Responses.SetFavoritePokemonResponseReflection.Descriptor.MessageTypes[0];
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

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="SetFavoritePokemonResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public SetFavoritePokemonResponse Clone()
		{
			return new SetFavoritePokemonResponse(this);
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
		public bool Equals(SetFavoritePokemonResponse other)
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

			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(SetFavoritePokemonResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Result != 0)
			{
				Result = other.Result;
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
						result_ = (global::POGOProtos.Networking.Responses.SetFavoritePokemonResponse.Types.Result)input.ReadEnum();
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
			return Equals(other as SetFavoritePokemonResponse);
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

		/// <summary>Container for nested types declared in the SetFavoritePokemonResponse message type.</summary>
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
				/// The error pokemon not found.
				/// </summary>
				[pbr::OriginalName("ERROR_POKEMON_NOT_FOUND")] ErrorPokemonNotFound = 2,

				/// <summary>
				/// The error pokemon is egg.
				/// </summary>
				[pbr::OriginalName("ERROR_POKEMON_IS_EGG")] ErrorPokemonIsEgg = 3,
			}

			#endregion
		}

		#endregion
	}

	#endregion
}

#endregion Designer generated code