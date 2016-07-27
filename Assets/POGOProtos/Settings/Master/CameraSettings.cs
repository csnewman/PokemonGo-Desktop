// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CameraSettings.cs" company="">
//   
// </copyright>
// <summary>
//   Holder for reflection information generated from POGOProtos/Settings/Master/CameraSettings.proto
// </summary>
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1591, 0612, 3021

#region Designer generated code

using POGOProtos.Enums;
using pb = Google.Protobuf;
using pbc = Google.Protobuf.Collections;
using pbr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace POGOProtos.Settings.Master
{
	/// <summary>Holder for reflection information generated from POGOProtos/Settings/Master/CameraSettings.proto</summary>
	public static partial class CameraSettingsReflection
	{
		#region Descriptor

		/// <summary>File descriptor for POGOProtos/Settings/Master/CameraSettings.proto</summary>
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
		/// Initializes static members of the <see cref="CameraSettingsReflection"/> class.
		/// </summary>
		static CameraSettingsReflection()
		{
			byte[] descriptorData =
				global::System.Convert.FromBase64String(
					string.Concat(
						"Ci9QT0dPUHJvdG9zL1NldHRpbmdzL01hc3Rlci9DYW1lcmFTZXR0aW5ncy5w",
						"cm90bxIaUE9HT1Byb3Rvcy5TZXR0aW5ncy5NYXN0ZXIaI1BPR09Qcm90b3Mv",
						"RW51bXMvQ2FtZXJhVGFyZ2V0LnByb3RvGipQT0dPUHJvdG9zL0VudW1zL0Nh",
						"bWVyYUludGVycG9sYXRpb24ucHJvdG8i1wMKDkNhbWVyYVNldHRpbmdzEhMK",
						"C25leHRfY2FtZXJhGAEgASgJEjwKDWludGVycG9sYXRpb24YAiADKA4yJS5Q",
						"T0dPUHJvdG9zLkVudW1zLkNhbWVyYUludGVycG9sYXRpb24SMwoLdGFyZ2V0",
						"X3R5cGUYAyADKA4yHi5QT0dPUHJvdG9zLkVudW1zLkNhbWVyYVRhcmdldBIV",
						"Cg1lYXNlX2luX3NwZWVkGAQgAygCEhYKDmVhc3Rfb3V0X3NwZWVkGAUgAygC",
						"EhgKEGR1cmF0aW9uX3NlY29uZHMYBiADKAISFAoMd2FpdF9zZWNvbmRzGAcg",
						"AygCEhoKEnRyYW5zaXRpb25fc2Vjb25kcxgIIAMoAhIUCgxhbmdsZV9kZWdy",
						"ZWUYCSADKAISGwoTYW5nbGVfb2Zmc2V0X2RlZ3JlZRgKIAMoAhIUCgxwaXRj",
						"aF9kZWdyZWUYCyADKAISGwoTcGl0Y2hfb2Zmc2V0X2RlZ3JlZRgMIAMoAhIT",
						"Cgtyb2xsX2RlZ3JlZRgNIAMoAhIXCg9kaXN0YW5jZV9tZXRlcnMYDiADKAIS",
						"FgoOaGVpZ2h0X3BlcmNlbnQYDyADKAISFgoOdmVydF9jdHJfcmF0aW8YECAD",
						"KAJiBnByb3RvMw=="));
			descriptor = pbr::FileDescriptor.FromGeneratedCode(
				descriptorData,
				new[]
				{
					global::POGOProtos.Enums.CameraTargetReflection.Descriptor,
					global::POGOProtos.Enums.CameraInterpolationReflection.Descriptor,
				},
				new pbr::GeneratedClrTypeInfo(
					null,
					new[]
					{
						new pbr::GeneratedClrTypeInfo(
							typeof(global::POGOProtos.Settings.Master.CameraSettings),
							global::POGOProtos.Settings.Master.CameraSettings.Parser,
							new[]
							{
								"NextCamera", "Interpolation", "TargetType", "EaseInSpeed", "EastOutSpeed", "DurationSeconds", "WaitSeconds",
								"TransitionSeconds", "AngleDegree", "AngleOffsetDegree", "PitchDegree", "PitchOffsetDegree", "RollDegree",
								"DistanceMeters", "HeightPercent", "VertCtrRatio"
							},
							null,
							null,
							null)
					}));
		}

		#endregion
	}

	#region Messages

	/// <summary>
	/// The camera settings.
	/// </summary>
	public sealed partial class CameraSettings : pb::IMessage<CameraSettings>
	{
		#region Static Fields and Constants

		/// <summary>Field number for the "next_camera" field.</summary>
		public const int NextCameraFieldNumber = 1;

		/// <summary>Field number for the "interpolation" field.</summary>
		public const int InterpolationFieldNumber = 2;

		/// <summary>Field number for the "target_type" field.</summary>
		public const int TargetTypeFieldNumber = 3;

		/// <summary>Field number for the "ease_in_speed" field.</summary>
		public const int EaseInSpeedFieldNumber = 4;

		/// <summary>Field number for the "east_out_speed" field.</summary>
		public const int EastOutSpeedFieldNumber = 5;

		/// <summary>Field number for the "duration_seconds" field.</summary>
		public const int DurationSecondsFieldNumber = 6;

		/// <summary>Field number for the "wait_seconds" field.</summary>
		public const int WaitSecondsFieldNumber = 7;

		/// <summary>Field number for the "transition_seconds" field.</summary>
		public const int TransitionSecondsFieldNumber = 8;

		/// <summary>Field number for the "angle_degree" field.</summary>
		public const int AngleDegreeFieldNumber = 9;

		/// <summary>Field number for the "angle_offset_degree" field.</summary>
		public const int AngleOffsetDegreeFieldNumber = 10;

		/// <summary>Field number for the "pitch_degree" field.</summary>
		public const int PitchDegreeFieldNumber = 11;

		/// <summary>Field number for the "pitch_offset_degree" field.</summary>
		public const int PitchOffsetDegreeFieldNumber = 12;

		/// <summary>Field number for the "roll_degree" field.</summary>
		public const int RollDegreeFieldNumber = 13;

		/// <summary>Field number for the "distance_meters" field.</summary>
		public const int DistanceMetersFieldNumber = 14;

		/// <summary>Field number for the "height_percent" field.</summary>
		public const int HeightPercentFieldNumber = 15;

		/// <summary>Field number for the "vert_ctr_ratio" field.</summary>
		public const int VertCtrRatioFieldNumber = 16;

		/// <summary>
		/// The _parser.
		/// </summary>
		private static readonly pb.MessageParser<CameraSettings> _parser =
			new pb::MessageParser<CameraSettings>(() => new CameraSettings());

		/// <summary>
		/// The _repeated_interpolation_codec.
		/// </summary>
		private static readonly pb.FieldCodec<CameraInterpolation> _repeated_interpolation_codec = pb::FieldCodec.ForEnum(
			18,
			x => (int)x,
			x => (global::POGOProtos.Enums.CameraInterpolation)x);

		/// <summary>
		/// The _repeated_target type_codec.
		/// </summary>
		private static readonly pb.FieldCodec<CameraTarget> _repeated_targetType_codec = pb::FieldCodec.ForEnum(
			26,
			x => (int)x,
			x => (global::POGOProtos.Enums.CameraTarget)x);

		/// <summary>
		/// The _repeated_ease in speed_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_easeInSpeed_codec = pb::FieldCodec.ForFloat(34);

		/// <summary>
		/// The _repeated_east out speed_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_eastOutSpeed_codec = pb::FieldCodec.ForFloat(42);

		/// <summary>
		/// The _repeated_duration seconds_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_durationSeconds_codec = pb::FieldCodec.ForFloat(50);

		/// <summary>
		/// The _repeated_wait seconds_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_waitSeconds_codec = pb::FieldCodec.ForFloat(58);

		/// <summary>
		/// The _repeated_transition seconds_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_transitionSeconds_codec = pb::FieldCodec.ForFloat(66);

		/// <summary>
		/// The _repeated_angle degree_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_angleDegree_codec = pb::FieldCodec.ForFloat(74);

		/// <summary>
		/// The _repeated_angle offset degree_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_angleOffsetDegree_codec = pb::FieldCodec.ForFloat(82);

		/// <summary>
		/// The _repeated_pitch degree_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_pitchDegree_codec = pb::FieldCodec.ForFloat(90);

		/// <summary>
		/// The _repeated_pitch offset degree_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_pitchOffsetDegree_codec = pb::FieldCodec.ForFloat(98);

		/// <summary>
		/// The _repeated_roll degree_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_rollDegree_codec = pb::FieldCodec.ForFloat(106);

		/// <summary>
		/// The _repeated_distance meters_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_distanceMeters_codec = pb::FieldCodec.ForFloat(114);

		/// <summary>
		/// The _repeated_height percent_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_heightPercent_codec = pb::FieldCodec.ForFloat(122);

		/// <summary>
		/// The _repeated_vert ctr ratio_codec.
		/// </summary>
		private static readonly pb.FieldCodec<float> _repeated_vertCtrRatio_codec = pb::FieldCodec.ForFloat(130);

		#endregion

		#region  Fields

		/// <summary>
		/// The angle degree_.
		/// </summary>
		private readonly pbc.RepeatedField<float> angleDegree_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The angle offset degree_.
		/// </summary>
		private readonly pbc.RepeatedField<float> angleOffsetDegree_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The distance meters_.
		/// </summary>
		private readonly pbc.RepeatedField<float> distanceMeters_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The duration seconds_.
		/// </summary>
		private readonly pbc.RepeatedField<float> durationSeconds_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The ease in speed_.
		/// </summary>
		private readonly pbc.RepeatedField<float> easeInSpeed_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The east out speed_.
		/// </summary>
		private readonly pbc.RepeatedField<float> eastOutSpeed_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The height percent_.
		/// </summary>
		private readonly pbc.RepeatedField<float> heightPercent_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The interpolation_.
		/// </summary>
		private readonly pbc.RepeatedField<CameraInterpolation> interpolation_ = new pbc::RepeatedField<CameraInterpolation>();

		/// <summary>
		/// The next camera_.
		/// </summary>
		private string nextCamera_ = string.Empty;

		/// <summary>
		/// The pitch degree_.
		/// </summary>
		private readonly pbc.RepeatedField<float> pitchDegree_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The pitch offset degree_.
		/// </summary>
		private readonly pbc.RepeatedField<float> pitchOffsetDegree_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The roll degree_.
		/// </summary>
		private readonly pbc.RepeatedField<float> rollDegree_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The target type_.
		/// </summary>
		private readonly pbc.RepeatedField<CameraTarget> targetType_ = new pbc::RepeatedField<CameraTarget>();

		/// <summary>
		/// The transition seconds_.
		/// </summary>
		private readonly pbc.RepeatedField<float> transitionSeconds_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The vert ctr ratio_.
		/// </summary>
		private readonly pbc.RepeatedField<float> vertCtrRatio_ = new pbc::RepeatedField<float>();

		/// <summary>
		/// The wait seconds_.
		/// </summary>
		private readonly pbc.RepeatedField<float> waitSeconds_ = new pbc::RepeatedField<float>();

		#endregion

		#region  Constructors

		/// <summary>
		/// Initializes a new instance of the <see cref="CameraSettings"/> class.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CameraSettings()
		{
			OnConstruction();
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="CameraSettings"/> class.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CameraSettings(CameraSettings other) : this()
		{
			nextCamera_ = other.nextCamera_;
			interpolation_ = other.interpolation_.Clone();
			targetType_ = other.targetType_.Clone();
			easeInSpeed_ = other.easeInSpeed_.Clone();
			eastOutSpeed_ = other.eastOutSpeed_.Clone();
			durationSeconds_ = other.durationSeconds_.Clone();
			waitSeconds_ = other.waitSeconds_.Clone();
			transitionSeconds_ = other.transitionSeconds_.Clone();
			angleDegree_ = other.angleDegree_.Clone();
			angleOffsetDegree_ = other.angleOffsetDegree_.Clone();
			pitchDegree_ = other.pitchDegree_.Clone();
			pitchOffsetDegree_ = other.pitchOffsetDegree_.Clone();
			rollDegree_ = other.rollDegree_.Clone();
			distanceMeters_ = other.distanceMeters_.Clone();
			heightPercent_ = other.heightPercent_.Clone();
			vertCtrRatio_ = other.vertCtrRatio_.Clone();
		}

		#endregion

		#region  Properties - Public

		/// <summary>
		/// Gets the parser.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public static pb.MessageParser<CameraSettings> Parser
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
				return global::POGOProtos.Settings.Master.CameraSettingsReflection.Descriptor.MessageTypes[0];
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
		/// Gets or sets the next camera.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public string NextCamera
		{
			get
			{
				return nextCamera_;
			}

			set
			{
				nextCamera_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
			}
		}

		/// <summary>
		/// Gets the interpolation.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<CameraInterpolation> Interpolation
		{
			get
			{
				return interpolation_;
			}
		}

		/// <summary>
		/// Gets the target type.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<CameraTarget> TargetType
		{
			get
			{
				return targetType_;
			}
		}

		/// <summary>
		/// Gets the ease in speed.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> EaseInSpeed
		{
			get
			{
				return easeInSpeed_;
			}
		}

		/// <summary>
		/// Gets the east out speed.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> EastOutSpeed
		{
			get
			{
				return eastOutSpeed_;
			}
		}

		/// <summary>
		/// Gets the duration seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> DurationSeconds
		{
			get
			{
				return durationSeconds_;
			}
		}

		/// <summary>
		/// Gets the wait seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> WaitSeconds
		{
			get
			{
				return waitSeconds_;
			}
		}

		/// <summary>
		/// Gets the transition seconds.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> TransitionSeconds
		{
			get
			{
				return transitionSeconds_;
			}
		}

		/// <summary>
		/// Gets the angle degree.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> AngleDegree
		{
			get
			{
				return angleDegree_;
			}
		}

		/// <summary>
		/// Gets the angle offset degree.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> AngleOffsetDegree
		{
			get
			{
				return angleOffsetDegree_;
			}
		}

		/// <summary>
		/// Gets the pitch degree.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> PitchDegree
		{
			get
			{
				return pitchDegree_;
			}
		}

		/// <summary>
		/// Gets the pitch offset degree.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> PitchOffsetDegree
		{
			get
			{
				return pitchOffsetDegree_;
			}
		}

		/// <summary>
		/// Gets the roll degree.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> RollDegree
		{
			get
			{
				return rollDegree_;
			}
		}

		/// <summary>
		/// Gets the distance meters.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> DistanceMeters
		{
			get
			{
				return distanceMeters_;
			}
		}

		/// <summary>
		/// Gets the height percent.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> HeightPercent
		{
			get
			{
				return heightPercent_;
			}
		}

		/// <summary>
		/// Gets the vert ctr ratio.
		/// </summary>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public pbc.RepeatedField<float> VertCtrRatio
		{
			get
			{
				return vertCtrRatio_;
			}
		}

		#endregion

		#region  Interface Implementations

		/// <summary>
		/// The clone.
		/// </summary>
		/// <returns>
		/// The <see cref="CameraSettings"/>.
		/// </returns>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public CameraSettings Clone()
		{
			return new CameraSettings(this);
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
		public bool Equals(CameraSettings other)
		{
			if (ReferenceEquals(other, null))
			{
				return false;
			}

			if (ReferenceEquals(other, this))
			{
				return true;
			}

			if (NextCamera != other.NextCamera)
			{
				return false;
			}

			if (!interpolation_.Equals(other.interpolation_))
			{
				return false;
			}

			if (!targetType_.Equals(other.targetType_))
			{
				return false;
			}

			if (!easeInSpeed_.Equals(other.easeInSpeed_))
			{
				return false;
			}

			if (!eastOutSpeed_.Equals(other.eastOutSpeed_))
			{
				return false;
			}

			if (!durationSeconds_.Equals(other.durationSeconds_))
			{
				return false;
			}

			if (!waitSeconds_.Equals(other.waitSeconds_))
			{
				return false;
			}

			if (!transitionSeconds_.Equals(other.transitionSeconds_))
			{
				return false;
			}

			if (!angleDegree_.Equals(other.angleDegree_))
			{
				return false;
			}

			if (!angleOffsetDegree_.Equals(other.angleOffsetDegree_))
			{
				return false;
			}

			if (!pitchDegree_.Equals(other.pitchDegree_))
			{
				return false;
			}

			if (!pitchOffsetDegree_.Equals(other.pitchOffsetDegree_))
			{
				return false;
			}

			if (!rollDegree_.Equals(other.rollDegree_))
			{
				return false;
			}

			if (!distanceMeters_.Equals(other.distanceMeters_))
			{
				return false;
			}

			if (!heightPercent_.Equals(other.heightPercent_))
			{
				return false;
			}

			if (!vertCtrRatio_.Equals(other.vertCtrRatio_))
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
			if (NextCamera.Length != 0)
			{
				output.WriteRawTag(10);
				output.WriteString(NextCamera);
			}

			interpolation_.WriteTo(output, _repeated_interpolation_codec);
			targetType_.WriteTo(output, _repeated_targetType_codec);
			easeInSpeed_.WriteTo(output, _repeated_easeInSpeed_codec);
			eastOutSpeed_.WriteTo(output, _repeated_eastOutSpeed_codec);
			durationSeconds_.WriteTo(output, _repeated_durationSeconds_codec);
			waitSeconds_.WriteTo(output, _repeated_waitSeconds_codec);
			transitionSeconds_.WriteTo(output, _repeated_transitionSeconds_codec);
			angleDegree_.WriteTo(output, _repeated_angleDegree_codec);
			angleOffsetDegree_.WriteTo(output, _repeated_angleOffsetDegree_codec);
			pitchDegree_.WriteTo(output, _repeated_pitchDegree_codec);
			pitchOffsetDegree_.WriteTo(output, _repeated_pitchOffsetDegree_codec);
			rollDegree_.WriteTo(output, _repeated_rollDegree_codec);
			distanceMeters_.WriteTo(output, _repeated_distanceMeters_codec);
			heightPercent_.WriteTo(output, _repeated_heightPercent_codec);
			vertCtrRatio_.WriteTo(output, _repeated_vertCtrRatio_codec);
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
			if (NextCamera.Length != 0)
			{
				size += 1 + pb::CodedOutputStream.ComputeStringSize(NextCamera);
			}

			size += interpolation_.CalculateSize(_repeated_interpolation_codec);
			size += targetType_.CalculateSize(_repeated_targetType_codec);
			size += easeInSpeed_.CalculateSize(_repeated_easeInSpeed_codec);
			size += eastOutSpeed_.CalculateSize(_repeated_eastOutSpeed_codec);
			size += durationSeconds_.CalculateSize(_repeated_durationSeconds_codec);
			size += waitSeconds_.CalculateSize(_repeated_waitSeconds_codec);
			size += transitionSeconds_.CalculateSize(_repeated_transitionSeconds_codec);
			size += angleDegree_.CalculateSize(_repeated_angleDegree_codec);
			size += angleOffsetDegree_.CalculateSize(_repeated_angleOffsetDegree_codec);
			size += pitchDegree_.CalculateSize(_repeated_pitchDegree_codec);
			size += pitchOffsetDegree_.CalculateSize(_repeated_pitchOffsetDegree_codec);
			size += rollDegree_.CalculateSize(_repeated_rollDegree_codec);
			size += distanceMeters_.CalculateSize(_repeated_distanceMeters_codec);
			size += heightPercent_.CalculateSize(_repeated_heightPercent_codec);
			size += vertCtrRatio_.CalculateSize(_repeated_vertCtrRatio_codec);
			return size;
		}

		/// <summary>
		/// The merge from.
		/// </summary>
		/// <param name="other">
		/// The other.
		/// </param>
		[global::System.Diagnostics.DebuggerNonUserCodeAttribute]
		public void MergeFrom(CameraSettings other)
		{
			if (other == null)
			{
				return;
			}

			if (other.NextCamera.Length != 0)
			{
				NextCamera = other.NextCamera;
			}

			interpolation_.Add(other.interpolation_);
			targetType_.Add(other.targetType_);
			easeInSpeed_.Add(other.easeInSpeed_);
			eastOutSpeed_.Add(other.eastOutSpeed_);
			durationSeconds_.Add(other.durationSeconds_);
			waitSeconds_.Add(other.waitSeconds_);
			transitionSeconds_.Add(other.transitionSeconds_);
			angleDegree_.Add(other.angleDegree_);
			angleOffsetDegree_.Add(other.angleOffsetDegree_);
			pitchDegree_.Add(other.pitchDegree_);
			pitchOffsetDegree_.Add(other.pitchOffsetDegree_);
			rollDegree_.Add(other.rollDegree_);
			distanceMeters_.Add(other.distanceMeters_);
			heightPercent_.Add(other.heightPercent_);
			vertCtrRatio_.Add(other.vertCtrRatio_);
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
						NextCamera = input.ReadString();
						break;
					}

					case 18:
					case 16:
					{
						interpolation_.AddEntriesFrom(input, _repeated_interpolation_codec);
						break;
					}

					case 26:
					case 24:
					{
						targetType_.AddEntriesFrom(input, _repeated_targetType_codec);
						break;
					}

					case 34:
					case 37:
					{
						easeInSpeed_.AddEntriesFrom(input, _repeated_easeInSpeed_codec);
						break;
					}

					case 42:
					case 45:
					{
						eastOutSpeed_.AddEntriesFrom(input, _repeated_eastOutSpeed_codec);
						break;
					}

					case 50:
					case 53:
					{
						durationSeconds_.AddEntriesFrom(input, _repeated_durationSeconds_codec);
						break;
					}

					case 58:
					case 61:
					{
						waitSeconds_.AddEntriesFrom(input, _repeated_waitSeconds_codec);
						break;
					}

					case 66:
					case 69:
					{
						transitionSeconds_.AddEntriesFrom(input, _repeated_transitionSeconds_codec);
						break;
					}

					case 74:
					case 77:
					{
						angleDegree_.AddEntriesFrom(input, _repeated_angleDegree_codec);
						break;
					}

					case 82:
					case 85:
					{
						angleOffsetDegree_.AddEntriesFrom(input, _repeated_angleOffsetDegree_codec);
						break;
					}

					case 90:
					case 93:
					{
						pitchDegree_.AddEntriesFrom(input, _repeated_pitchDegree_codec);
						break;
					}

					case 98:
					case 101:
					{
						pitchOffsetDegree_.AddEntriesFrom(input, _repeated_pitchOffsetDegree_codec);
						break;
					}

					case 106:
					case 109:
					{
						rollDegree_.AddEntriesFrom(input, _repeated_rollDegree_codec);
						break;
					}

					case 114:
					case 117:
					{
						distanceMeters_.AddEntriesFrom(input, _repeated_distanceMeters_codec);
						break;
					}

					case 122:
					case 125:
					{
						heightPercent_.AddEntriesFrom(input, _repeated_heightPercent_codec);
						break;
					}

					case 130:
					case 133:
					{
						vertCtrRatio_.AddEntriesFrom(input, _repeated_vertCtrRatio_codec);
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
			return Equals(other as CameraSettings);
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
			if (NextCamera.Length != 0)
			{
				hash ^= NextCamera.GetHashCode();
			}

			hash ^= interpolation_.GetHashCode();
			hash ^= targetType_.GetHashCode();
			hash ^= easeInSpeed_.GetHashCode();
			hash ^= eastOutSpeed_.GetHashCode();
			hash ^= durationSeconds_.GetHashCode();
			hash ^= waitSeconds_.GetHashCode();
			hash ^= transitionSeconds_.GetHashCode();
			hash ^= angleDegree_.GetHashCode();
			hash ^= angleOffsetDegree_.GetHashCode();
			hash ^= pitchDegree_.GetHashCode();
			hash ^= pitchOffsetDegree_.GetHashCode();
			hash ^= rollDegree_.GetHashCode();
			hash ^= distanceMeters_.GetHashCode();
			hash ^= heightPercent_.GetHashCode();
			hash ^= vertCtrRatio_.GetHashCode();
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