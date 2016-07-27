// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CameraAttributes.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/Pokemon/CameraAttributes.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master.Pokemon
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/Pokemon/CameraAttributes.proto</summary>
	public static partial class CameraAttributesReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/Pokemon/CameraAttributes.proto</summary>
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
		/// Initializes static members of the <see cref="CameraAttributesReflection"/> class.
		/// </summary>
		static CameraAttributesReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"CjlQT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9Qb2tlbW9uL0NhbWVyYUF0",
						"dHJpYnV0ZXMucHJvdG8SIlBPR09Qcm90b3MuU2V0dGluZ3MuTWFzdGVyLlBv",
						"a2Vtb24ilwEKEENhbWVyYUF0dHJpYnV0ZXMSFQoNZGlza19yYWRpdXNfbRgB",
						"IAEoAhIZChFjeWxpbmRlcl9yYWRpdXNfbRgCIAEoAhIZChFjeWxpbmRlcl9o",
						"ZWlnaHRfbRgDIAEoAhIZChFjeWxpbmRlcl9ncm91bmRfbRgEIAEoAhIbChNz",
						"aG91bGRlcl9tb2RlX3NjYWxlGAUgASgCYgZwcm90bzM="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new pbr.FileDescriptor[] { },
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.Pokemon.CameraAttributes),
							global::POGOProtos.Settings.Master.Pokemon.CameraAttributes.Parser,
							new[] { "DiskRadiusM", "CylinderRadiusM", "CylinderHeightM", "CylinderGroundM", "ShoulderModeScale" },
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The camera attributes.
	/// </summary>
	public sealed partial class CameraAttributes : pb::IMessage<CameraAttributes>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "disk_radius_m" field.</summary>
		public const int DiskRadiusMFieldNumber = 1;

		/// <summary>Field number for the "cylinder_radius_m" field.</summary>
		public const int CylinderRadiusMFieldNumber = 2;

		/// <summary>Field number for the "cylinder_height_m" field.</summary>
		public const int CylinderHeightMFieldNumber = 3;

		/// <summary>Field number for the "cylinder_ground_m" field.</summary>
		public const int CylinderGroundMFieldNumber = 4;

		/// <summary>Field number for the "shoulder_mode_scale" field.</summary>
		public const int ShoulderModeScaleFieldNumber = 5;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<CameraAttributes> _parser =
			new pb::MessageParser<CameraAttributes>(() => new CameraAttributes());

		#endregion

		#region  Fields

		/// <summary>
		/// The cylinder ground m_.
		/// </summary>
		private float cylinderGroundM_;

		/// <summary>
		/// The cylinder height m_.
		/// </summary>
		private float cylinderHeightM_;

		/// <summary>
		/// The cylinder radius m_.
		/// </summary>
		private float cylinderRadiusM_;

		/// <summary>
		/// The disk radius m_.
		/// </summary>
		private float diskRadiusM_;

		/// <summary>
		/// The shoulder mode scale_.
		/// </summary>
		private float shoulderModeScale_;

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CameraAttributes"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CameraAttributes()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CameraAttributes"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CameraAttributes(CameraAttributes other) : this()
		{
			diskRadiusM_ = other.diskRadiusM_;
			cylinderRadiusM_ = other.cylinderRadiusM_;
			cylinderHeightM_ = other.cylinderHeightM_;
			cylinderGroundM_ = other.cylinderGroundM_;
			shoulderModeScale_ = other.shoulderModeScale_;
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<CameraAttributes> Parser
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
				return global::POGOProtos.Settings.Master.Pokemon.CameraAttributesReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the disk radius m.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float DiskRadiusM
		{
			get
			{
				return diskRadiusM_;
			}

			set
			{
				diskRadiusM_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the cylinder radius m.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float CylinderRadiusM
		{
			get
			{
				return cylinderRadiusM_;
			}

			set
			{
				cylinderRadiusM_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the cylinder height m.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float CylinderHeightM
		{
			get
			{
				return cylinderHeightM_;
			}

			set
			{
				cylinderHeightM_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the cylinder ground m.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float CylinderGroundM
		{
			get
			{
				return cylinderGroundM_;
			}

			set
			{
				cylinderGroundM_ = value;
			}
		}

		/// <summary>
		/// Gets or sets the shoulder mode scale.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public float ShoulderModeScale
		{
			get
			{
				return shoulderModeScale_;
			}

			set
			{
				shoulderModeScale_ = value;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="CameraAttributes"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CameraAttributes Clone()
		{
			return new CameraAttributes(this);
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
		public bool Equals(CameraAttributes other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (DiskRadiusM != other.DiskRadiusM)
			{
				return false;
			}

			if (CylinderRadiusM != other.CylinderRadiusM)
			{
				return false;
			}

			if (CylinderHeightM != other.CylinderHeightM)
			{
				return false;
			}

			if (CylinderGroundM != other.CylinderGroundM)
			{
				return false;
			}

			if (ShoulderModeScale != other.ShoulderModeScale)
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
			if (DiskRadiusM != 0F)
			{
				output.WriteRawTag(13);
				output.WriteFloat(DiskRadiusM);
			}

			if (CylinderRadiusM != 0F)
			{
				output.WriteRawTag(21);
				output.WriteFloat(CylinderRadiusM);
			}

			if (CylinderHeightM != 0F)
			{
				output.WriteRawTag(29);
				output.WriteFloat(CylinderHeightM);
			}

			if (CylinderGroundM != 0F)
			{
				output.WriteRawTag(37);
				output.WriteFloat(CylinderGroundM);
			}

			if (ShoulderModeScale != 0F)
			{
				output.WriteRawTag(45);
				output.WriteFloat(ShoulderModeScale);
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
			if (DiskRadiusM != 0F)
			{
				size += 1 + 4;
			}

			if (CylinderRadiusM != 0F)
			{
				size += 1 + 4;
			}

			if (CylinderHeightM != 0F)
			{
				size += 1 + 4;
			}

			if (CylinderGroundM != 0F)
			{
				size += 1 + 4;
			}

			if (ShoulderModeScale != 0F)
			{
				size += 1 + 4;
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
		public void MergeFrom(CameraAttributes other)
		{
			if (other == null)
			{
				return;
			}

			if (other.DiskRadiusM != 0F)
			{
				DiskRadiusM = other.DiskRadiusM;
			}

			if (other.CylinderRadiusM != 0F)
			{
				CylinderRadiusM = other.CylinderRadiusM;
			}

			if (other.CylinderHeightM != 0F)
			{
				CylinderHeightM = other.CylinderHeightM;
			}

			if (other.CylinderGroundM != 0F)
			{
				CylinderGroundM = other.CylinderGroundM;
			}

			if (other.ShoulderModeScale != 0F)
			{
				ShoulderModeScale = other.ShoulderModeScale;
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
					case 13:
					{
						DiskRadiusM = input.ReadFloat();
						break;
					}

					case 21:
					{
						CylinderRadiusM = input.ReadFloat();
						break;
					}

					case 29:
					{
						CylinderHeightM = input.ReadFloat();
						break;
					}

					case 37:
					{
						CylinderGroundM = input.ReadFloat();
						break;
					}

					case 45:
					{
						ShoulderModeScale = input.ReadFloat();
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
			return Equals(other as CameraAttributes);
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
			if (DiskRadiusM != 0F)
			{
				hash ^= DiskRadiusM.GetHashCode();
			}

			if (CylinderRadiusM != 0F)
			{
				hash ^= CylinderRadiusM.GetHashCode();
			}

			if (CylinderHeightM != 0F)
			{
				hash ^= CylinderHeightM.GetHashCode();
			}

			if (CylinderGroundM != 0F)
			{
				hash ^= CylinderGroundM.GetHashCode();
			}

			if (ShoulderModeScale != 0F)
			{
				hash ^= ShoulderModeScale.GetHashCode();
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