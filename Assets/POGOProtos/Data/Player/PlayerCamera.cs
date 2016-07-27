// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PlayerCamera.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Data/Player/PlayerCamera.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Data.Player
{
	/// <summary>Holder for reflection information generated from POGOProtos/Data/Player/PlayerCamera.proto</summary>
	public static partial class PlayerCameraReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Data/Player/PlayerCamera.proto</summary>
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
		/// Initializes static members of the <see cref="PlayerCameraReflection"/> class.
		/// </summary>
		static PlayerCameraReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CilQT0dPUHJvdG9zL0RhdGEvUGxheWVyL1BsYXllckNhbWVyYS5wcm90bxIW",
						"UE9HT1Byb3Rvcy5EYXRhLlBsYXllciIpCgxQbGF5ZXJDYW1lcmESGQoRaXNf",
						"ZGVmYXVsdF9jYW1lcmEYASABKAhiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Data.Player.PlayerCamera),
							global::POGOProtos.Data.Player.PlayerCamera.Parser,
							new[] { "IsDefaultCamera" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The player camera.
	/// </summary>
	public sealed partial class PlayerCamera : pb::IMessage<PlayerCamera>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "is_default_camera" field.</summary>
		public const int IsDefaultCameraFieldNumber = 1;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<PlayerCamera> _parser =
			new pb::MessageParser<PlayerCamera>(() => new PlayerCamera());

		#endregion

		#region  Fields

		/// <summary>
		/// The is default camera_.
		/// </summary>
		private bool isDefaultCamera_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerCamera"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerCamera()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="PlayerCamera"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerCamera(PlayerCamera other) : this()
		{
			isDefaultCamera_ = other.isDefaultCamera_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<PlayerCamera> Parser
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
				return global::POGOProtos.Data.Player.PlayerCameraReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets a value indicating whether is default camera.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public bool IsDefaultCamera
		{
			get
			{
				return isDefaultCamera_;
			}

			set
			{
				isDefaultCamera_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="PlayerCamera"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public PlayerCamera Clone()
		{
			return new PlayerCamera(this);
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
		public bool Equals(PlayerCamera other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (IsDefaultCamera != other.IsDefaultCamera)
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
			if (IsDefaultCamera != false)
			{
				output.WriteRawTag(8);
				output.WriteBool(IsDefaultCamera);
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
			if (IsDefaultCamera != false)
			{
				size += 1 + 1;
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
		public void MergeFrom(PlayerCamera other)
		{
			if (other == null)
			{
				return;
			}

			if (other.IsDefaultCamera != false)
			{
				IsDefaultCamera = other.IsDefaultCamera;
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
						IsDefaultCamera = input.ReadBool();
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
			return Equals(other as PlayerCamera);
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
			if (IsDefaultCamera != false)
			{
				hash ^= IsDefaultCamera.GetHashCode();
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