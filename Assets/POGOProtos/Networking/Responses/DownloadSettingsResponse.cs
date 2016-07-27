// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DownloadSettingsResponse.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Responses/DownloadSettingsResponse.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Settings;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Responses
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/DownloadSettingsResponse.proto</summary>
	public static partial class DownloadSettingsResponseReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Responses/DownloadSettingsResponse.proto</summary>
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
		/// Initializes static members of the <see cref="DownloadSettingsResponseReflection"/> class.
		/// </summary>
		static DownloadSettingsResponseReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Cj5QT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0Rvd25sb2FkU2V0",
						"dGluZ3NSZXNwb25zZS5wcm90bxIfUE9HT1Byb3Rvcy5OZXR3b3JraW5nLlJl",
						"c3BvbnNlcxooUE9HT1Byb3Rvcy9TZXR0aW5ncy9HbG9iYWxTZXR0aW5ncy5w",
						"cm90byJuChhEb3dubG9hZFNldHRpbmdzUmVzcG9uc2USDQoFZXJyb3IYASAB",
						"KAkSDAoEaGFzaBgCIAEoCRI1CghzZXR0aW5ncxgDIAEoCzIjLlBPR09Qcm90",
						"b3MuU2V0dGluZ3MuR2xvYmFsU2V0dGluZ3NiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Settings.GlobalSettingsReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Responses.DownloadSettingsResponse),
							global::POGOProtos.Networking.Responses.DownloadSettingsResponse.Parser,
							new[] { "Error", "Hash", "Settings" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The download settings response.
	/// </summary>
	public sealed partial class DownloadSettingsResponse : pb::IMessage<DownloadSettingsResponse>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "error" field.</summary>
		public const int ErrorFieldNumber = 1;

		/// <summary>Field number for the "hash" field.</summary>
		public const int HashFieldNumber = 2;

		/// <summary>Field number for the "settings" field.</summary>
		public const int SettingsFieldNumber = 3;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<DownloadSettingsResponse> _parser =
			new pb::MessageParser<DownloadSettingsResponse>(() => new DownloadSettingsResponse());

		#endregion

		#region  Fields

		/// <summary>
		/// The error_.
		/// </summary>
		private string error_ = string.Empty;

		/// <summary>
		/// The hash_.
		/// </summary>
		private string hash_ = string.Empty;

		/// <summary>
		/// The settings_.
		/// </summary>
		private GlobalSettings settings_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadSettingsResponse"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadSettingsResponse()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadSettingsResponse"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadSettingsResponse(DownloadSettingsResponse other) : this()
		{
			error_ = other.error_;
			hash_ = other.hash_;
			Settings = other.settings_ != null ? other.Settings.Clone() : null;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<DownloadSettingsResponse> Parser
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
				return global::POGOProtos.Networking.Responses.DownloadSettingsResponseReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the error.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Error
		{
			get
			{
				return error_;
			}

			set
			{
				error_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the hash.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Hash
		{
			get
			{
				return hash_;
			}

			set
			{
				hash_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the settings.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public GlobalSettings Settings
		{
			get
			{
				return settings_;
			}

			set
			{
				settings_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="DownloadSettingsResponse"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadSettingsResponse Clone()
		{
			return new DownloadSettingsResponse(this);
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
		public bool Equals(DownloadSettingsResponse other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Error != other.Error)
			{
				return false;
			}

			if (Hash != other.Hash)
			{
				return false;
			}

			if (!object.Equals(Settings, other.Settings))
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
			if (Error.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(Error);
			}

			if (Hash.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(Hash);
			}

			if (settings_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(Settings);
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
			if (Error.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Error);
			}

			if (Hash.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Hash);
			}

			if (settings_ != null)
			{
				size += 1 + pb::CodedOutputStream.ComputeMessageSize(Settings);
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
		public void MergeFrom(DownloadSettingsResponse other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Error.Length != 0)
			{
				Error = other.Error;
			}

			if (other.Hash.Length != 0)
			{
				Hash = other.Hash;
			}

			if (other.settings_ != null)
			{
				if (settings_ == null)
				{
					settings_ = new global::POGOProtos.Settings.GlobalSettings();
				}

				Settings.MergeFrom(other.Settings);
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
						Error = input.ReadString();
						break;
					}

					case 18:
					{
						Hash = input.ReadString();
						break;
					}

					case 26:
					{
						if (settings_ == null)
						{
							settings_ = new global::POGOProtos.Settings.GlobalSettings();
						}

						input.ReadMessage(settings_);
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
			return Equals(other as DownloadSettingsResponse);
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
			if (Error.Length != 0)
			{
				hash ^= Error.GetHashCode();
			}

			if (Hash.Length != 0)
			{
				hash ^= Hash.GetHashCode();
			}

			if (settings_ != null)
			{
				hash ^= Settings.GetHashCode();
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