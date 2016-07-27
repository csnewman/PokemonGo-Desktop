// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DownloadRemoteConfigVersionMessage.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/DownloadRemoteConfigVersionMessage.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Networking.Requests.Messages
{
	/// <summary>Holder for reflection information generated from POGOProtos/Networking/Requests/Messages/DownloadRemoteConfigVersionMessage.proto</summary>
	public static partial class DownloadRemoteConfigVersionMessageReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Networking/Requests/Messages/DownloadRemoteConfigVersionMessage.proto</summary>
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
		/// Initializes static members of the <see cref="DownloadRemoteConfigVersionMessageReflection"/> class.
		/// </summary>
		static DownloadRemoteConfigVersionMessageReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"ClBQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVxdWVzdHMvTWVzc2FnZXMvRG93",
						"bmxvYWRSZW1vdGVDb25maWdWZXJzaW9uTWVzc2FnZS5wcm90bxInUE9HT1By",
						"b3Rvcy5OZXR3b3JraW5nLlJlcXVlc3RzLk1lc3NhZ2VzGh9QT0dPUHJvdG9z",
						"L0VudW1zL1BsYXRmb3JtLnByb3RvIqoBCiJEb3dubG9hZFJlbW90ZUNvbmZp",
						"Z1ZlcnNpb25NZXNzYWdlEiwKCHBsYXRmb3JtGAEgASgOMhouUE9HT1Byb3Rv",
						"cy5FbnVtcy5QbGF0Zm9ybRIbChNkZXZpY2VfbWFudWZhY3R1cmVyGAIgASgJ",
						"EhQKDGRldmljZV9tb2RlbBgDIAEoCRIOCgZsb2NhbGUYBCABKAkSEwoLYXBw",
						"X3ZlcnNpb24YBSABKA1iBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[] { global::POGOProtos.Enums.PlatformReflection.Descriptor, },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Networking.Requests.Messages.DownloadRemoteConfigVersionMessage),
							global::POGOProtos.Networking.Requests.Messages.DownloadRemoteConfigVersionMessage.Parser,
							new[] { "Platform", "DeviceManufacturer", "DeviceModel", "Locale", "AppVersion" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The download remote config version message.
	/// </summary>
	public sealed partial class DownloadRemoteConfigVersionMessage : pb::IMessage<DownloadRemoteConfigVersionMessage>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "platform" field.</summary>
		public const int PlatformFieldNumber = 1;

		/// <summary>Field number for the "device_manufacturer" field.</summary>
		public const int DeviceManufacturerFieldNumber = 2;

		/// <summary>Field number for the "device_model" field.</summary>
		public const int DeviceModelFieldNumber = 3;

		/// <summary>Field number for the "locale" field.</summary>
		public const int LocaleFieldNumber = 4;

		/// <summary>Field number for the "app_version" field.</summary>
		public const int AppVersionFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<DownloadRemoteConfigVersionMessage> _parser =
			new pb::MessageParser<DownloadRemoteConfigVersionMessage>(() => new DownloadRemoteConfigVersionMessage());

		#endregion

		#region  Fields

		/// <summary>
		/// The app version_.
		/// </summary>
		private uint appVersion_;

		/// <summary>
		/// The device manufacturer_.
		/// </summary>
		private string deviceManufacturer_ = string.Empty;

		/// <summary>
		/// The device model_.
		/// </summary>
		private string deviceModel_ = string.Empty;

		/// <summary>
		/// The locale_.
		/// </summary>
		private string locale_ = string.Empty;

		/// <summary>
		/// The platform_.
		/// </summary>
		private Platform platform_ = 0;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadRemoteConfigVersionMessage"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadRemoteConfigVersionMessage()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="DownloadRemoteConfigVersionMessage"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadRemoteConfigVersionMessage(DownloadRemoteConfigVersionMessage other) : this()
		{
			platform_ = other.platform_;
			deviceManufacturer_ = other.deviceManufacturer_;
			deviceModel_ = other.deviceModel_;
			locale_ = other.locale_;
			appVersion_ = other.appVersion_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<DownloadRemoteConfigVersionMessage> Parser
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
					global::POGOProtos.Networking.Requests.Messages.DownloadRemoteConfigVersionMessageReflection.Descriptor
						.MessageTypes[0];
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
		/// Gets or sets the platform.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public Platform Platform
		{
			get
			{
				return platform_;
			}

			set
			{
				platform_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the device manufacturer.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string DeviceManufacturer
		{
			get
			{
				return deviceManufacturer_;
			}

			set
			{
				deviceManufacturer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the device model.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string DeviceModel
		{
			get
			{
				return deviceModel_;
			}

			set
			{
				deviceModel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the locale.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string Locale
		{
			get
			{
				return locale_;
			}

			set
			{
				locale_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets or sets the app version.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public uint AppVersion
		{
			get
			{
				return appVersion_;
			}

			set
			{
				appVersion_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="DownloadRemoteConfigVersionMessage"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public DownloadRemoteConfigVersionMessage Clone()
		{
			return new DownloadRemoteConfigVersionMessage(this);
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
		public bool Equals(DownloadRemoteConfigVersionMessage other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (Platform != other.Platform)
			{
				return false;
			}

			if (DeviceManufacturer != other.DeviceManufacturer)
			{
				return false;
			}

			if (DeviceModel != other.DeviceModel)
			{
				return false;
			}

			if (Locale != other.Locale)
			{
				return false;
			}

			if (AppVersion != other.AppVersion)
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
			if (Platform != 0)
			{
				output.WriteRawTag(8);
				output.WriteEnum((int)Platform);
			}

			if (DeviceManufacturer.Length != 0)
			{
				output.WriteRawTag(18);
				output.WriteString(DeviceManufacturer);
			}

			if (DeviceModel.Length != 0)
			{
				output.WriteRawTag(26);
				output.WriteString(DeviceModel);
			}

			if (Locale.Length != 0)
			{
				output.WriteRawTag(34);
				output.WriteString(Locale);
			}

			if (AppVersion != 0)
			{
				output.WriteRawTag(40);
				output.WriteUInt32(AppVersion);
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
			if (Platform != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeEnumSize((int)Platform);
			}

			if (DeviceManufacturer.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceManufacturer);
			}

			if (DeviceModel.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(DeviceModel);
			}

			if (Locale.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(Locale);
			}

			if (AppVersion != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeUInt32Size(AppVersion);
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
		public void MergeFrom(DownloadRemoteConfigVersionMessage other)
		{
			if (other == null)
			{
				return;
			}

			if (other.Platform != 0)
			{
				Platform = other.Platform;
			}

			if (other.DeviceManufacturer.Length != 0)
			{
				DeviceManufacturer = other.DeviceManufacturer;
			}

			if (other.DeviceModel.Length != 0)
			{
				DeviceModel = other.DeviceModel;
			}

			if (other.Locale.Length != 0)
			{
				Locale = other.Locale;
			}

			if (other.AppVersion != 0)
			{
				AppVersion = other.AppVersion;
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
						platform_ = (global::POGOProtos.Enums.Platform)input.ReadEnum();
						break;
					}

					case 18:
					{
						DeviceManufacturer = input.ReadString();
						break;
					}

					case 26:
					{
						DeviceModel = input.ReadString();
						break;
					}

					case 34:
					{
						Locale = input.ReadString();
						break;
					}

					case 40:
					{
						AppVersion = input.ReadUInt32();
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
			return Equals(other as DownloadRemoteConfigVersionMessage);
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
			if (Platform != 0)
			{
				hash ^= Platform.GetHashCode();
			}

			if (DeviceManufacturer.Length != 0)
			{
				hash ^= DeviceManufacturer.GetHashCode();
			}

			if (DeviceModel.Length != 0)
			{
				hash ^= DeviceModel.GetHashCode();
			}

			if (Locale.Length != 0)
			{
				hash ^= Locale.GetHashCode();
			}

			if (AppVersion != 0)
			{
				hash ^= AppVersion.GetHashCode();
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