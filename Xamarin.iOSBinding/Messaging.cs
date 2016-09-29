using System;
using AudioToolbox;
using AudioUnit;
using AVFoundation;
using CoreAnimation;
using CoreGraphics;
using CoreLocation;
using CoreMedia;
using CoreMotion;
using Foundation;
using MapKit;
using Metal;
using MetalPerformanceShaders;
using ModelIO;
using OpenTK;
using SceneKit;
using System.Runtime.InteropServices;
using UIKit;

namespace Xamarin.iOSBinding
{
	internal static class Messaging
	{
		//
		// Static Fields
		//
		internal const string LIBOBJC_DYLIB = "/usr/lib/libobjc.dylib";

		//
		// Static Methods
		//
		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AudioComponentDescription AudioComponentDescription_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AudioComponentDescription_objc_msgSend_stret (out AudioComponentDescription retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AudioComponentDescription AudioComponentDescription_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AudioComponentDescription_objc_msgSendSuper_stret (out AudioComponentDescription retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AudioStreamBasicDescription AudioStreamBasicDescription_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AudioStreamBasicDescription_objc_msgSend_stret (out AudioStreamBasicDescription retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AudioStreamBasicDescription AudioStreamBasicDescription_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AudioStreamBasicDescription_objc_msgSendSuper_stret (out AudioStreamBasicDescription retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AudioStreamPacketDescription AudioStreamPacketDescription_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AudioStreamPacketDescription_objc_msgSend_stret (out AudioStreamPacketDescription retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AudioStreamPacketDescription AudioStreamPacketDescription_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AudioStreamPacketDescription_objc_msgSendSuper_stret (out AudioStreamPacketDescription retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AudioTimeStamp AudioTimeStamp_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AudioTimeStamp_objc_msgSend_stret (out AudioTimeStamp retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AudioTimeStamp AudioTimeStamp_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AudioTimeStamp_objc_msgSendSuper_stret (out AudioTimeStamp retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVAudio3DAngularOrientation AVAudio3DAngularOrientation_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVAudio3DAngularOrientation_objc_msgSend_stret (out AVAudio3DAngularOrientation retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVAudio3DAngularOrientation AVAudio3DAngularOrientation_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVAudio3DAngularOrientation_objc_msgSendSuper_stret (out AVAudio3DAngularOrientation retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVAudio3DVectorOrientation AVAudio3DVectorOrientation_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVAudio3DVectorOrientation_objc_msgSend_stret (out AVAudio3DVectorOrientation retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVAudio3DVectorOrientation AVAudio3DVectorOrientation_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVAudio3DVectorOrientation_objc_msgSendSuper_stret (out AVAudio3DVectorOrientation retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVAudioConverterPrimeInfo AVAudioConverterPrimeInfo_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVAudioConverterPrimeInfo_objc_msgSend_stret (out AVAudioConverterPrimeInfo retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVAudioConverterPrimeInfo AVAudioConverterPrimeInfo_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVAudioConverterPrimeInfo_objc_msgSendSuper_stret (out AVAudioConverterPrimeInfo retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVBeatRange AVBeatRange_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVBeatRange_objc_msgSend_stret (out AVBeatRange retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVBeatRange AVBeatRange_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVBeatRange_objc_msgSendSuper_stret (out AVBeatRange retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVCaptureWhiteBalanceChromaticityValues AVCaptureWhiteBalanceChromaticityValues_objc_msgSend_AVCaptureWhiteBalanceGains (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVCaptureWhiteBalanceChromaticityValues_objc_msgSend_stret_AVCaptureWhiteBalanceGains (out AVCaptureWhiteBalanceChromaticityValues retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVCaptureWhiteBalanceChromaticityValues AVCaptureWhiteBalanceChromaticityValues_objc_msgSendSuper_AVCaptureWhiteBalanceGains (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVCaptureWhiteBalanceChromaticityValues_objc_msgSendSuper_stret_AVCaptureWhiteBalanceGains (out AVCaptureWhiteBalanceChromaticityValues retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVCaptureWhiteBalanceGains AVCaptureWhiteBalanceGains_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVCaptureWhiteBalanceGains AVCaptureWhiteBalanceGains_objc_msgSend_AVCaptureWhiteBalanceChromaticityValues (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceChromaticityValues arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVCaptureWhiteBalanceGains AVCaptureWhiteBalanceGains_objc_msgSend_AVCaptureWhiteBalanceTemperatureAndTintValues (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceTemperatureAndTintValues arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVCaptureWhiteBalanceGains_objc_msgSend_stret (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVCaptureWhiteBalanceGains_objc_msgSend_stret_AVCaptureWhiteBalanceChromaticityValues (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceChromaticityValues arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVCaptureWhiteBalanceGains_objc_msgSend_stret_AVCaptureWhiteBalanceTemperatureAndTintValues (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceTemperatureAndTintValues arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVCaptureWhiteBalanceGains AVCaptureWhiteBalanceGains_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVCaptureWhiteBalanceGains AVCaptureWhiteBalanceGains_objc_msgSendSuper_AVCaptureWhiteBalanceChromaticityValues (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceChromaticityValues arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVCaptureWhiteBalanceGains AVCaptureWhiteBalanceGains_objc_msgSendSuper_AVCaptureWhiteBalanceTemperatureAndTintValues (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceTemperatureAndTintValues arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVCaptureWhiteBalanceGains_objc_msgSendSuper_stret (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVCaptureWhiteBalanceGains_objc_msgSendSuper_stret_AVCaptureWhiteBalanceChromaticityValues (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceChromaticityValues arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVCaptureWhiteBalanceGains_objc_msgSendSuper_stret_AVCaptureWhiteBalanceTemperatureAndTintValues (out AVCaptureWhiteBalanceGains retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceTemperatureAndTintValues arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVCaptureWhiteBalanceTemperatureAndTintValues AVCaptureWhiteBalanceTemperatureAndTintValues_objc_msgSend_AVCaptureWhiteBalanceGains (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVCaptureWhiteBalanceTemperatureAndTintValues_objc_msgSend_stret_AVCaptureWhiteBalanceGains (out AVCaptureWhiteBalanceTemperatureAndTintValues retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVCaptureWhiteBalanceTemperatureAndTintValues AVCaptureWhiteBalanceTemperatureAndTintValues_objc_msgSendSuper_AVCaptureWhiteBalanceGains (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVCaptureWhiteBalanceTemperatureAndTintValues_objc_msgSendSuper_stret_AVCaptureWhiteBalanceGains (out AVCaptureWhiteBalanceTemperatureAndTintValues retval, IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVEdgeWidths AVEdgeWidths_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVEdgeWidths_objc_msgSend_stret (out AVEdgeWidths retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVEdgeWidths AVEdgeWidths_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVEdgeWidths_objc_msgSendSuper_stret (out AVEdgeWidths retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern AVPixelAspectRatio AVPixelAspectRatio_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void AVPixelAspectRatio_objc_msgSend_stret (out AVPixelAspectRatio retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern AVPixelAspectRatio AVPixelAspectRatio_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void AVPixelAspectRatio_objc_msgSendSuper_stret (out AVPixelAspectRatio retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_bool_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_bool_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, uint arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_bool_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, ulong arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_byte (IntPtr receiver, IntPtr selector, byte arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CGRect_bool (IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CGRect_IntPtr_bool (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CGRect_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_Char (IntPtr receiver, IntPtr selector, char arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CMTime_ref_CGAffineTransform_ref_CGAffineTransform_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref CGAffineTransform arg2, ref CGAffineTransform arg3, ref CMTimeRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CMTime_ref_CGRect_ref_CGRect_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref CGRect arg2, ref CGRect arg3, ref CMTimeRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CMTime_ref_Single_ref_Single_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref float arg2, ref float arg3, ref CMTimeRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_CMTimeRange_IntPtr_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, CMTimeRange arg1, IntPtr arg2, CMTime arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_Double_Double (IntPtr receiver, IntPtr selector, double arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_Double_ref_IntPtr (IntPtr receiver, IntPtr selector, double arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_float_float_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, float arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_float_float_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, float arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_float_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_float_ref_IntPtr (IntPtr receiver, IntPtr selector, float arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_int_ref_IntPtr (IntPtr receiver, IntPtr selector, int arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_Int64_ref_IntPtr (IntPtr receiver, IntPtr selector, long arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_bool_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_bool_NSRange_out_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, NSRange arg3, out NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_byte_byte_byte_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, byte arg2, byte arg3, byte arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_CMTime (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_CMTimeRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_int_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_Int64_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_Int64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CMTime arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_int_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, IntPtr arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_Int64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_Int64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, long arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, ref IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, ref IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt32_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, uint arg4, ref IntPtr arg5, ref IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4, ref IntPtr arg5, ref IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_nint_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, bool arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_nint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_nuint_IntPtr_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3, IntPtr arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_ref_Boolean (IntPtr receiver, IntPtr selector, IntPtr arg1, ref bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_ref_CGRect_ref_CGRect_ref_nfloat_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ref CGRect arg2, ref CGRect arg3, ref nfloat arg4, IntPtr arg5, NSRange arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_ref_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_UInt32_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_UInt64_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_MKMapRect (IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_MKMapRect_nfloat (IntPtr receiver, IntPtr selector, MKMapRect arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_nint_float_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, float arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_nint_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_nint_ref_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_NSOperatingSystemVersion (IntPtr receiver, IntPtr selector, NSOperatingSystemVersion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_nuint_ref_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_out_nfloat_out_nfloat (IntPtr receiver, IntPtr selector, out nfloat arg1, out nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_out_NSUrlRelationship_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, out NSUrlRelationship arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_out_NSUrlRelationship_UInt32_UInt32_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, out NSUrlRelationship arg1, uint arg2, uint arg3, IntPtr arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_out_NSUrlRelationship_UInt64_UInt64_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, out NSUrlRelationship arg1, ulong arg2, ulong arg3, IntPtr arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_ref_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_ref_IntPtr_out_Double_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out double arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_ref_IntPtr_out_Double_UInt32_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out double arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_ref_IntPtr_out_Double_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out double arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_ref_IntPtr_out_NSRange_IntPtr_NSRange_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out NSRange arg2, IntPtr arg3, NSRange arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_ref_SCNVector3_ref_nfloat (IntPtr receiver, IntPtr selector, ref SCNVector3 arg1, ref nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_ref_SCNVector3_ref_SCNVector3 (IntPtr receiver, IntPtr selector, ref SCNVector3 arg1, ref SCNVector3 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_UInt32_ref_IntPtr_out_Double_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, ref IntPtr arg2, out double arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern bool bool_objc_msgSend_UInt64_ref_IntPtr_out_Double_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ref IntPtr arg2, out double arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_bool_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_bool_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, uint arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_bool_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, ulong arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_byte (IntPtr receiver, IntPtr selector, byte arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CGRect_bool (IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CGRect_IntPtr_bool (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CGRect_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_Char (IntPtr receiver, IntPtr selector, char arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CMTime_ref_CGAffineTransform_ref_CGAffineTransform_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref CGAffineTransform arg2, ref CGAffineTransform arg3, ref CMTimeRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CMTime_ref_CGRect_ref_CGRect_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref CGRect arg2, ref CGRect arg3, ref CMTimeRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CMTime_ref_Single_ref_Single_ref_CMTimeRange (IntPtr receiver, IntPtr selector, CMTime arg1, ref float arg2, ref float arg3, ref CMTimeRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_CMTimeRange_IntPtr_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, CMTimeRange arg1, IntPtr arg2, CMTime arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_Double_Double (IntPtr receiver, IntPtr selector, double arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_Double_ref_IntPtr (IntPtr receiver, IntPtr selector, double arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_float_float_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, float arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_float_float_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, float arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_float_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_float_ref_IntPtr (IntPtr receiver, IntPtr selector, float arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_int_ref_IntPtr (IntPtr receiver, IntPtr selector, int arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_Int64_ref_IntPtr (IntPtr receiver, IntPtr selector, long arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_bool_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_bool_NSRange_out_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, NSRange arg3, out NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_byte_byte_byte_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, byte arg2, byte arg3, byte arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_CMTime (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_CMTimeRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_int_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_Int64_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_Int64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CMTime arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_Int64_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, IntPtr arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_Int64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Int64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, long arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, ref IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, ref IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt32_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, uint arg4, ref IntPtr arg5, ref IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4, ref IntPtr arg5, ref IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_nint_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, bool arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_nint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_nuint_IntPtr_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3, IntPtr arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_ref_Boolean (IntPtr receiver, IntPtr selector, IntPtr arg1, ref bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_ref_CGRect_ref_CGRect_ref_nfloat_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ref CGRect arg2, ref CGRect arg3, ref nfloat arg4, IntPtr arg5, NSRange arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_UInt32_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_UInt64_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_MKMapRect (IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_MKMapRect_nfloat (IntPtr receiver, IntPtr selector, MKMapRect arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_nint_float_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, float arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_nint_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_nint_ref_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_NSOperatingSystemVersion (IntPtr receiver, IntPtr selector, NSOperatingSystemVersion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_nuint_ref_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_out_nfloat_out_nfloat (IntPtr receiver, IntPtr selector, out nfloat arg1, out nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_out_NSUrlRelationship_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, out NSUrlRelationship arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_out_NSUrlRelationship_UInt32_UInt32_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, out NSUrlRelationship arg1, uint arg2, uint arg3, IntPtr arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_out_NSUrlRelationship_UInt64_UInt64_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, out NSUrlRelationship arg1, ulong arg2, ulong arg3, IntPtr arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_ref_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_ref_IntPtr_out_Double_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out double arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_ref_IntPtr_out_Double_UInt32_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out double arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_ref_IntPtr_out_Double_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out double arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_ref_IntPtr_out_NSRange_IntPtr_NSRange_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, out NSRange arg2, IntPtr arg3, NSRange arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_ref_SCNVector3_ref_nfloat (IntPtr receiver, IntPtr selector, ref SCNVector3 arg1, ref nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_ref_SCNVector3_ref_SCNVector3 (IntPtr receiver, IntPtr selector, ref SCNVector3 arg1, ref SCNVector3 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_UInt32_ref_IntPtr_out_Double_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, ref IntPtr arg2, out double arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern bool bool_objc_msgSendSuper_UInt64_ref_IntPtr_out_Double_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ref IntPtr arg2, out double arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern byte byte_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern byte byte_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CATransform3D CATransform3D_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CATransform3D_objc_msgSend_stret (out CATransform3D retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CATransform3D CATransform3D_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CATransform3D_objc_msgSendSuper_stret (out CATransform3D retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGAffineTransform CGAffineTransform_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGAffineTransform CGAffineTransform_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGAffineTransform CGAffineTransform_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGAffineTransform_objc_msgSend_stret (out CGAffineTransform retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGAffineTransform_objc_msgSend_stret_int (out CGAffineTransform retval, IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGAffineTransform_objc_msgSend_stret_IntPtr (out CGAffineTransform retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGAffineTransform CGAffineTransform_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGAffineTransform CGAffineTransform_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGAffineTransform CGAffineTransform_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGAffineTransform_objc_msgSendSuper_stret (out CGAffineTransform retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGAffineTransform_objc_msgSendSuper_stret_int (out CGAffineTransform retval, IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGAffineTransform_objc_msgSendSuper_stret_IntPtr (out CGAffineTransform retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_CLLocationCoordinate2D_IntPtr (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_MKMapPoint (IntPtr receiver, IntPtr selector, MKMapPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_nint_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGPoint CGPoint_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret (out CGPoint retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_CGPoint (out CGPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_CGPoint_CGPoint (out CGPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_CGPoint_IntPtr (out CGPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_CLLocationCoordinate2D (out CGPoint retval, IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_CLLocationCoordinate2D_IntPtr (out CGPoint retval, IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_IntPtr (out CGPoint retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_IntPtr_CGPoint (out CGPoint retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_MKMapPoint (out CGPoint retval, IntPtr receiver, IntPtr selector, MKMapPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_nint (out CGPoint retval, IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_nint_IntPtr (out CGPoint retval, IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGPoint_objc_msgSend_stret_nuint (out CGPoint retval, IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_MKMapPoint (IntPtr receiver, IntPtr selector, MKMapPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_nint_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGPoint CGPoint_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret (out CGPoint retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_CGPoint (out CGPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_CGPoint_CGPoint (out CGPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_CGPoint_IntPtr (out CGPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_CLLocationCoordinate2D (out CGPoint retval, IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_CLLocationCoordinate2D_IntPtr (out CGPoint retval, IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_IntPtr (out CGPoint retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_IntPtr_CGPoint (out CGPoint retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_MKMapPoint (out CGPoint retval, IntPtr receiver, IntPtr selector, MKMapPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_nint (out CGPoint retval, IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_nint_IntPtr (out CGPoint retval, IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGPoint_objc_msgSendSuper_stret_nuint (out CGPoint retval, IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_CGRect_CGRect_float (IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_CGRect_nint (IntPtr receiver, IntPtr selector, CGRect arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_CGRect_nuint_int_out_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1, nuint arg2, int arg3, out CGRect arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_CGRect_nuint_Int64_out_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1, nuint arg2, long arg3, out CGRect arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_CGSize_UInt32_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_CGSize_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, uint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_CGSize_UInt64_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_CGSize_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_IntPtr_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_IntPtr_CGRect_CGPoint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGPoint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_IntPtr_nuint_IntPtr_CGRect_CGPoint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3, CGRect arg4, CGPoint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_MKCoordinateRegion_IntPtr (IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_MKMapRect (IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGRect CGRect_objc_msgSend_nuint_out_NSRange_bool (IntPtr receiver, IntPtr selector, nuint arg1, out NSRange arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret (out CGRect retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_CGRect (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_CGRect_CGRect_float (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_CGRect_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_CGRect_nint (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_CGRect_nuint_int_out_CGRect (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, nuint arg2, int arg3, out CGRect arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_CGRect_nuint_Int64_out_CGRect (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, nuint arg2, long arg3, out CGRect arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_CGSize_UInt32_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, CGSize arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_CGSize_UInt32_IntPtr_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, CGSize arg1, uint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_CGSize_UInt64_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, CGSize arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_CGSize_UInt64_IntPtr_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, CGSize arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_IntPtr_CGRect (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_IntPtr_CGRect_CGPoint_nuint (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGPoint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_IntPtr_IntPtr_ref_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_IntPtr_nuint_IntPtr_CGRect_CGPoint_nuint (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3, CGRect arg4, CGPoint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_MKCoordinateRegion_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_MKMapRect (out CGRect retval, IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_nint (out CGRect retval, IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_NSRange_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_nuint_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, nuint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGRect_objc_msgSend_stret_nuint_out_NSRange_bool (out CGRect retval, IntPtr receiver, IntPtr selector, nuint arg1, out NSRange arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_CGRect_CGRect_float (IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_CGRect_nint (IntPtr receiver, IntPtr selector, CGRect arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_CGRect_nuint_int_out_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1, nuint arg2, int arg3, out CGRect arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_CGRect_nuint_Int64_out_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1, nuint arg2, long arg3, out CGRect arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_CGSize_UInt32_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_CGSize_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, uint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_CGSize_UInt64_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_CGSize_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_IntPtr_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_IntPtr_CGRect_CGPoint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGPoint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_IntPtr_nuint_IntPtr_CGRect_CGPoint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3, CGRect arg4, CGPoint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_MKCoordinateRegion_IntPtr (IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_MKMapRect (IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGRect CGRect_objc_msgSendSuper_nuint_out_NSRange_bool (IntPtr receiver, IntPtr selector, nuint arg1, out NSRange arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret (out CGRect retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_CGRect (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_CGRect_CGRect_float (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_CGRect_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_CGRect_nint (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_CGRect_nuint_int_out_CGRect (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, nuint arg2, int arg3, out CGRect arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_CGRect_nuint_Int64_out_CGRect (out CGRect retval, IntPtr receiver, IntPtr selector, CGRect arg1, nuint arg2, long arg3, out CGRect arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_CGSize_UInt32_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, CGSize arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_CGSize_UInt32_IntPtr_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, CGSize arg1, uint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_CGSize_UInt64_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, CGSize arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_CGSize_UInt64_IntPtr_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, CGSize arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_CGRect (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_CGRect_CGPoint_nuint (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGPoint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_IntPtr_ref_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_IntPtr_nuint_IntPtr_CGRect_CGPoint_nuint (out CGRect retval, IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3, CGRect arg4, CGPoint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_MKCoordinateRegion_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_MKMapRect (out CGRect retval, IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_nint (out CGRect retval, IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_NSRange_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_nuint_IntPtr (out CGRect retval, IntPtr receiver, IntPtr selector, nuint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGRect_objc_msgSendSuper_stret_nuint_out_NSRange_bool (out CGRect retval, IntPtr receiver, IntPtr selector, nuint arg1, out NSRange arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGPoint_nfloat_IntPtr_int (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGPoint_nfloat_IntPtr_Int64 (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGPoint_nfloat_IntPtr_nfloat_int_int (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, int arg5, int arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGPoint_nfloat_IntPtr_nfloat_Int64_Int64 (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, long arg5, long arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGPoint_nfloat_IntPtr_nfloat_ref_nfloat_int_int (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, ref nfloat arg5, int arg6, int arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGPoint_nfloat_IntPtr_nfloat_ref_nfloat_Int64_Int64 (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, ref nfloat arg5, long arg6, long arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGRect_IntPtr_int (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGRect_IntPtr_int_int (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGRect_IntPtr_Int64 (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGRect_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, long arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGSize (IntPtr receiver, IntPtr selector, CGSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_CGSize_float_float (IntPtr receiver, IntPtr selector, CGSize arg1, float arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_IntPtr_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_IntPtr_CGSize_int (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_IntPtr_CGSize_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_IntPtr_nfloat_int (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_IntPtr_nfloat_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_IntPtr_nfloat_ref_nfloat_nfloat_int (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, ref nfloat arg3, nfloat arg4, int arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_IntPtr_nfloat_ref_nfloat_nfloat_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, ref nfloat arg3, nfloat arg4, long arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGSize CGSize_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret (out CGSize retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGPoint_IntPtr (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGPoint_nfloat_IntPtr_int (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGPoint_nfloat_IntPtr_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGPoint_nfloat_IntPtr_nfloat_int_int (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, int arg5, int arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGPoint_nfloat_IntPtr_nfloat_Int64_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, long arg5, long arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGPoint_nfloat_IntPtr_nfloat_ref_nfloat_int_int (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, ref nfloat arg5, int arg6, int arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGPoint_nfloat_IntPtr_nfloat_ref_nfloat_Int64_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, ref nfloat arg5, long arg6, long arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGRect_IntPtr (out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGRect_IntPtr_int (out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGRect_IntPtr_int_int (out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGRect_IntPtr_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGRect_IntPtr_Int64_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, long arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGSize (out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_CGSize_float_float (out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1, float arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_IntPtr (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_IntPtr_CGSize (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_IntPtr_CGSize_int (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_IntPtr_CGSize_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_IntPtr_IntPtr_IntPtr (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_IntPtr_IntPtr_nint (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_IntPtr_nfloat_int (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_IntPtr_nfloat_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_IntPtr_nfloat_ref_nfloat_nfloat_int (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, ref nfloat arg3, nfloat arg4, int arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_IntPtr_nfloat_ref_nfloat_nfloat_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, ref nfloat arg3, nfloat arg4, long arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_nint (out CGSize retval, IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGSize_objc_msgSend_stret_nuint (out CGSize retval, IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGPoint_nfloat_IntPtr_int (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGPoint_nfloat_IntPtr_Int64 (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGPoint_nfloat_IntPtr_nfloat_int_int (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, int arg5, int arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGPoint_nfloat_IntPtr_nfloat_Int64_Int64 (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, long arg5, long arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGPoint_nfloat_IntPtr_nfloat_ref_nfloat_int_int (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, ref nfloat arg5, int arg6, int arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGPoint_nfloat_IntPtr_nfloat_ref_nfloat_Int64_Int64 (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, ref nfloat arg5, long arg6, long arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGRect_IntPtr_int (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGRect_IntPtr_int_int (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGRect_IntPtr_Int64 (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGRect_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, long arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGSize (IntPtr receiver, IntPtr selector, CGSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_CGSize_float_float (IntPtr receiver, IntPtr selector, CGSize arg1, float arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_CGSize_int (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_CGSize_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_nfloat_int (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_nfloat_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_nfloat_ref_nfloat_nfloat_int (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, ref nfloat arg3, nfloat arg4, int arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_IntPtr_nfloat_ref_nfloat_nfloat_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, ref nfloat arg3, nfloat arg4, long arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGSize CGSize_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret (out CGSize retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGPoint_IntPtr (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGPoint_nfloat_IntPtr_int (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGPoint_nfloat_IntPtr_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGPoint_nfloat_IntPtr_nfloat_int_int (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, int arg5, int arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGPoint_nfloat_IntPtr_nfloat_Int64_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, long arg5, long arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGPoint_nfloat_IntPtr_nfloat_ref_nfloat_int_int (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, ref nfloat arg5, int arg6, int arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGPoint_nfloat_IntPtr_nfloat_ref_nfloat_Int64_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, IntPtr arg3, nfloat arg4, ref nfloat arg5, long arg6, long arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGRect_IntPtr (out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGRect_IntPtr_int (out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGRect_IntPtr_int_int (out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, int arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGRect_IntPtr_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGRect_IntPtr_Int64_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, long arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGSize (out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_CGSize_float_float (out CGSize retval, IntPtr receiver, IntPtr selector, CGSize arg1, float arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_IntPtr (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_CGSize (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_CGSize_int (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_CGSize_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_IntPtr_IntPtr (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_IntPtr_nint (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_nfloat_int (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_nfloat_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_nfloat_ref_nfloat_nfloat_int (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, ref nfloat arg3, nfloat arg4, int arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_IntPtr_nfloat_ref_nfloat_nfloat_Int64 (out CGSize retval, IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, ref nfloat arg3, nfloat arg4, long arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_nint (out CGSize retval, IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGSize_objc_msgSendSuper_stret_nuint (out CGSize retval, IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGVector CGVector_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CGVector CGVector_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGVector_objc_msgSend_stret (out CGVector retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CGVector_objc_msgSend_stret_IntPtr (out CGVector retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGVector CGVector_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CGVector CGVector_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGVector_objc_msgSendSuper_stret (out CGVector retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CGVector_objc_msgSendSuper_stret_IntPtr (out CGVector retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern char Char_objc_msgSend_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern char Char_objc_msgSendSuper_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CLLocationCoordinate2D CLLocationCoordinate2D_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CLLocationCoordinate2D CLLocationCoordinate2D_objc_msgSend_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CLLocationCoordinate2D_objc_msgSend_stret (out CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CLLocationCoordinate2D_objc_msgSend_stret_CGPoint_IntPtr (out CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CLLocationCoordinate2D CLLocationCoordinate2D_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CLLocationCoordinate2D CLLocationCoordinate2D_objc_msgSendSuper_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CLLocationCoordinate2D_objc_msgSendSuper_stret (out CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CLLocationCoordinate2D_objc_msgSendSuper_stret_CGPoint_IntPtr (out CLLocationCoordinate2D retval, IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMAcceleration CMAcceleration_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMAcceleration_objc_msgSend_stret (out CMAcceleration retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMAcceleration CMAcceleration_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMAcceleration_objc_msgSendSuper_stret (out CMAcceleration retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMCalibratedMagneticField CMCalibratedMagneticField_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMCalibratedMagneticField_objc_msgSend_stret (out CMCalibratedMagneticField retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMCalibratedMagneticField CMCalibratedMagneticField_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMCalibratedMagneticField_objc_msgSendSuper_stret (out CMCalibratedMagneticField retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMMagneticField CMMagneticField_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMMagneticField_objc_msgSend_stret (out CMMagneticField retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMMagneticField CMMagneticField_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMMagneticField_objc_msgSendSuper_stret (out CMMagneticField retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMQuaternion CMQuaternion_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMQuaternion_objc_msgSend_stret (out CMQuaternion retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMQuaternion CMQuaternion_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMQuaternion_objc_msgSendSuper_stret (out CMQuaternion retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMRotationMatrix CMRotationMatrix_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMRotationMatrix_objc_msgSend_stret (out CMRotationMatrix retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMRotationMatrix CMRotationMatrix_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMRotationMatrix_objc_msgSendSuper_stret (out CMRotationMatrix retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMRotationRate CMRotationRate_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMRotationRate_objc_msgSend_stret (out CMRotationRate retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMRotationRate CMRotationRate_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMRotationRate_objc_msgSendSuper_stret (out CMRotationRate retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMTime CMTime_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMTime CMTime_objc_msgSend_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMTime CMTime_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMTime CMTime_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMTime_objc_msgSend_stret (out CMTime retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMTime_objc_msgSend_stret_CMTime (out CMTime retval, IntPtr receiver, IntPtr selector, CMTime arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMTime_objc_msgSend_stret_Double (out CMTime retval, IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMTime_objc_msgSend_stret_Int64 (out CMTime retval, IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMTime CMTime_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMTime CMTime_objc_msgSendSuper_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMTime CMTime_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMTime CMTime_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMTime_objc_msgSendSuper_stret (out CMTime retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMTime_objc_msgSendSuper_stret_CMTime (out CMTime retval, IntPtr receiver, IntPtr selector, CMTime arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMTime_objc_msgSendSuper_stret_Double (out CMTime retval, IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMTime_objc_msgSendSuper_stret_Int64 (out CMTime retval, IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMTimeMapping CMTimeMapping_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMTimeMapping_objc_msgSend_stret (out CMTimeMapping retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMTimeMapping CMTimeMapping_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMTimeMapping_objc_msgSendSuper_stret (out CMTimeMapping retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMTimeRange CMTimeRange_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMTimeRange_objc_msgSend_stret (out CMTimeRange retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMTimeRange CMTimeRange_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMTimeRange_objc_msgSendSuper_stret (out CMTimeRange retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern CMVideoDimensions CMVideoDimensions_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void CMVideoDimensions_objc_msgSend_stret (out CMVideoDimensions retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern CMVideoDimensions CMVideoDimensions_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void CMVideoDimensions_objc_msgSendSuper_stret (out CMVideoDimensions retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern double Double_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern double Double_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern double Double_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern double Double_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern double Double_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern double Double_objc_msgSend_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern double Double_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern double Double_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern double Double_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern double Double_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern double Double_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern double Double_objc_msgSendSuper_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern float float_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern float float_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern float float_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern float float_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern float float_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern float float_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern float float_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern float float_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern float float_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern float float_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_CGSize_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, int arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_CGSize_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, long arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_int_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_IntPtr_CGSize_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGSize arg3, int arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_IntPtr_CGSize_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGSize arg3, long arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern int int_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_CGSize_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, int arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_CGSize_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, long arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_int_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_IntPtr_CGSize_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGSize arg3, int arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_IntPtr_CGSize_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGSize arg3, long arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern int int_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_IntPtr_Int64_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_IntPtr_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_IntPtr_UInt64_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_IntPtr_UInt64_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern long Int64_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_IntPtr_Int64_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_IntPtr_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_IntPtr_UInt64_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_IntPtr_UInt64_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern long Int64_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_AudioComponentDescription (IntPtr receiver, IntPtr selector, AudioComponentDescription arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_AudioComponentDescription_ref_IntPtr (IntPtr receiver, IntPtr selector, AudioComponentDescription arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_AudioComponentDescription_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, AudioComponentDescription arg1, uint arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_bool_nuint_bool_nuint (IntPtr receiver, IntPtr selector, bool arg1, nuint arg2, bool arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_byte (IntPtr receiver, IntPtr selector, byte arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CATransform3D (IntPtr receiver, IntPtr selector, CATransform3D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGAffineTransform_bool (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGPoint_Double (IntPtr receiver, IntPtr selector, CGPoint arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGPoint_IntPtr_Double (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGPoint_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGPoint_IntPtr_nfloat (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGPoint_nfloat_nfloat_nfloat_bool (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, nfloat arg3, nfloat arg4, bool arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_bool_UIEdgeInsets (IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2, UIEdgeInsets arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_int (IntPtr receiver, IntPtr selector, CGRect arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_int_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, int arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_Int64 (IntPtr receiver, IntPtr selector, CGRect arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_IntPtr_nuint (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_nfloat (IntPtr receiver, IntPtr selector, CGRect arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_UInt32_CGSize (IntPtr receiver, IntPtr selector, CGRect arg1, uint arg2, CGSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGRect_UInt64_CGSize (IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, CGSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGSize (IntPtr receiver, IntPtr selector, CGSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGSize_CGPoint (IntPtr receiver, IntPtr selector, CGSize arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGSize_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGSize_nfloat (IntPtr receiver, IntPtr selector, CGSize arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGSize_UInt32 (IntPtr receiver, IntPtr selector, CGSize arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGVector (IntPtr receiver, IntPtr selector, CGVector arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGVector_CGPoint_Double (IntPtr receiver, IntPtr selector, CGVector arg1, CGPoint arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CGVector_Double (IntPtr receiver, IntPtr selector, CGVector arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_CLLocationCoordinate2D_Double (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, CLLocationCoordinate2D arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, double arg3, double arg4, double arg5, double arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, double arg3, double arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_IntPtr (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_Double_nfloat_Double (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, nfloat arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CLLocationCoordinate2D_IntPtr (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CMTime_float (IntPtr receiver, IntPtr selector, CMTime arg1, float arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CMTime_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CMTime_out_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, out CMTime arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CMTime_ref_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1, ref CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CMTimeMapping (IntPtr receiver, IntPtr selector, CMTimeMapping arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_CMTimeRange (IntPtr receiver, IntPtr selector, CMTimeRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Double_Double (IntPtr receiver, IntPtr selector, double arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Double_int (IntPtr receiver, IntPtr selector, double arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Double_Int64 (IntPtr receiver, IntPtr selector, double arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, bool arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Double_out_NSEnergyFormatterUnit (IntPtr receiver, IntPtr selector, double arg1, out NSEnergyFormatterUnit arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Double_ref_NSLengthFormatterUnit (IntPtr receiver, IntPtr selector, double arg1, ref NSLengthFormatterUnit arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Double_ref_NSMassFormatterUnit (IntPtr receiver, IntPtr selector, double arg1, ref NSMassFormatterUnit arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Double_UInt32 (IntPtr receiver, IntPtr selector, double arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_float (IntPtr receiver, IntPtr selector, float arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_float_bool_IntPtr (IntPtr receiver, IntPtr selector, float arg1, bool arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_float_Double (IntPtr receiver, IntPtr selector, float arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_CGSize_bool_IntPtr (IntPtr receiver, IntPtr selector, int arg1, CGSize arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_Double (IntPtr receiver, IntPtr selector, int arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_int_UInt32_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_nfloat_IntPtr (IntPtr receiver, IntPtr selector, int arg1, nfloat arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_nint (IntPtr receiver, IntPtr selector, int arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_nint_IntPtr (IntPtr receiver, IntPtr selector, int arg1, nint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_nint_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, nint arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_int_UInt32 (IntPtr receiver, IntPtr selector, int arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_Double (IntPtr receiver, IntPtr selector, long arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_int (IntPtr receiver, IntPtr selector, long arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_Int64 (IntPtr receiver, IntPtr selector, long arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_Int64_IntPtr (IntPtr receiver, IntPtr selector, long arg1, long arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_Int64_UInt64_IntPtr (IntPtr receiver, IntPtr selector, long arg1, long arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_IntPtr_Int64 (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_nfloat_IntPtr (IntPtr receiver, IntPtr selector, long arg1, nfloat arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_nint (IntPtr receiver, IntPtr selector, long arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_nint_IntPtr (IntPtr receiver, IntPtr selector, long arg1, nint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_nint_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, long arg1, nint arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_short_bool (IntPtr receiver, IntPtr selector, long arg1, short arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Int64_UInt64 (IntPtr receiver, IntPtr selector, long arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_bool_bool_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, bool arg4, bool arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_bool_bool_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_bool_bool_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, nfloat arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_bool_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGAffineTransform (IntPtr receiver, IntPtr selector, IntPtr arg1, CGAffineTransform arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGPoint_CGVector (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGVector arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGPoint_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, IntPtr arg3, CGPoint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGRect_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, int arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGRect_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGSize_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CGSize_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, uint arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Double_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Double_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, bool arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, bool arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_float_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, CGSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_float_float_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, float arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_float_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_CMTimeRange_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, CMTimeRange arg3, CMTimeRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_float_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, float arg3, float arg4, float arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_int_int_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4, float arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_int_IntPtr_int_nfloat_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4, int arg5, nfloat arg6, nfloat arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, nint arg3, nint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_int_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_Int64_IntPtr_Int64_nfloat_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, IntPtr arg4, long arg5, nfloat arg6, nfloat arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, nint arg3, nint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Int64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3, CGPoint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_CGPoint_CGVector (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3, CGVector arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3, float arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, nuint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nint_bool_nint_nint_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3, bool arg4, nint arg5, nint arg6, nint arg7, nint arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nint_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, nuint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nuint_UInt32_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, uint arg4, int arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nuint_UInt32_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, uint arg4, int arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nuint_UInt64_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, ulong arg4, long arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_nuint_UInt64_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, ulong arg4, long arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, uint arg4, uint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_float_float_int_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, float arg4, float arg5, int arg6, IntPtr arg7, uint arg8, IntPtr arg9, IntPtr arg10);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ulong arg4, ulong arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Matrix2 (IntPtr receiver, IntPtr selector, IntPtr arg1, Matrix2 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Matrix3 (IntPtr receiver, IntPtr selector, IntPtr arg1, Matrix3 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Matrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, Matrix4 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_MDLAxisAlignedBoundingBox_float (IntPtr receiver, IntPtr selector, IntPtr arg1, MDLAxisAlignedBoundingBox arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nfloat_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nfloat_int (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nfloat_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nfloat_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nint_CGSize_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, CGSize arg3, int arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nint_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nint_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nint_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nint_nint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nint_out_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, out NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nint_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, out NSRange arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_float_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, float arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_nuint_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, int arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_nuint_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_UInt32_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, uint arg3, int arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_UInt64_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, ulong arg3, long arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_nuint_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_out_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, out nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_ref_MPSImageHistogramInfo (IntPtr receiver, IntPtr selector, IntPtr arg1, ref MPSImageHistogramInfo arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_SCNMatrix4_SCNMatrix4_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNMatrix4 arg2, SCNMatrix4 arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNVector3 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_SCNVector3_IntPtr_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNVector3 arg2, IntPtr arg3, SCNVector3 arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_SCNVector3_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNVector3 arg2, SCNVector3 arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_SCNVector3_SCNVector3_IntPtr_SCNVector3_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNVector3 arg2, SCNVector3 arg3, IntPtr arg4, SCNVector3 arg5, SCNVector3 arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UIEdgeInsets_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, UIEdgeInsets arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UIEdgeInsets_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, UIEdgeInsets arg2, int arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UIEdgeInsets_Int64_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, UIEdgeInsets arg2, long arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt16_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ushort arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt16_UInt16_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ushort arg2, ushort arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, bool arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_float (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr_nint_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, nint arg4, nint arg5, nint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr_out_Boolean_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, out bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, nuint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_ref_NSPropertyListFormat_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref NSPropertyListFormat arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt32_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, bool arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_float (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_nint_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, nint arg4, nint arg5, nint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_out_Boolean_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, out bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, nuint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ref IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_ref_NSPropertyListFormat_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ref NSPropertyListFormat arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UInt64_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UIOffset_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, UIOffset arg2, CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_UIOffset_IntPtr_UIOffset (IntPtr receiver, IntPtr selector, IntPtr arg1, UIOffset arg2, IntPtr arg3, UIOffset arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, Vector2 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Vector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, Vector3 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_IntPtr_Vector4 (IntPtr receiver, IntPtr selector, IntPtr arg1, Vector4 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_MDLVoxelIndexExtent (IntPtr receiver, IntPtr selector, MDLVoxelIndexExtent arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_MKCoordinateSpan (IntPtr receiver, IntPtr selector, MKCoordinateSpan arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_MKMapRect (IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_MKTileOverlayPath (IntPtr receiver, IntPtr selector, MKTileOverlayPath arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_CGPoint (IntPtr receiver, IntPtr selector, nfloat arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_CGSize (IntPtr receiver, IntPtr selector, nfloat arg1, CGSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_CGSize_bool (IntPtr receiver, IntPtr selector, nfloat arg1, CGSize arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_Double (IntPtr receiver, IntPtr selector, nfloat arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_Double_bool (IntPtr receiver, IntPtr selector, nfloat arg1, double arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_IntPtr (IntPtr receiver, IntPtr selector, nfloat arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_nfloat_Double (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_nfloat_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_nfloat_nfloat_Double (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2, nfloat arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_nfloat_nfloat_Double_bool (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2, nfloat arg3, double arg4, bool arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_nfloat_nfloat_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2, nfloat arg3, nfloat arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nfloat_SCNVector3_Double (IntPtr receiver, IntPtr selector, nfloat arg1, SCNVector3 arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_bool (IntPtr receiver, IntPtr selector, nint arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_IntPtr_ref_NSRange_ref_NSRange (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2, ref NSRange arg3, ref NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_IntPtr_ref_NSRange_ref_NSRange_ref_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2, ref NSRange arg3, ref NSRange arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_nint (IntPtr receiver, IntPtr selector, nint arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_nint_nint_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, nint arg1, nint arg2, nint arg3, IntPtr arg4, uint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_nint_nint_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, nint arg1, nint arg2, nint arg3, IntPtr arg4, ulong arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_nint_nint_nint_nint_nint_nint_nint (IntPtr receiver, IntPtr selector, nint arg1, nint arg2, nint arg3, nint arg4, nint arg5, nint arg6, nint arg7, nint arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_out_NSRange (IntPtr receiver, IntPtr selector, nint arg1, out NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, nint arg1, out NSRange arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_ref_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nint_ref_NSRange (IntPtr receiver, IntPtr selector, nint arg1, ref NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_NSDecimal (IntPtr receiver, IntPtr selector, NSDecimal arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, uint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_NSRange_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ulong arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nuint_nuint (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nuint_out_NSRange_bool (IntPtr receiver, IntPtr selector, nuint arg1, out NSRange arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nuint_UInt32 (IntPtr receiver, IntPtr selector, nuint arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_nuint_UInt64 (IntPtr receiver, IntPtr selector, nuint arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_out_nuint (IntPtr receiver, IntPtr selector, out nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_ref_AudioStreamBasicDescription (IntPtr receiver, IntPtr selector, ref AudioStreamBasicDescription arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_ref_AudioStreamBasicDescription_IntPtr (IntPtr receiver, IntPtr selector, ref AudioStreamBasicDescription arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_ref_AudioTimeStamp_Double (IntPtr receiver, IntPtr selector, ref AudioTimeStamp arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_ref_CGPoint_nuint (IntPtr receiver, IntPtr selector, ref CGPoint arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_ref_Single (IntPtr receiver, IntPtr selector, ref float arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_SByte (IntPtr receiver, IntPtr selector, sbyte arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_SCNMatrix4 (IntPtr receiver, IntPtr selector, SCNMatrix4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_SCNVector3 (IntPtr receiver, IntPtr selector, SCNVector3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_SCNVector3_Double (IntPtr receiver, IntPtr selector, SCNVector3 arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_SCNVector3_SCNVector3_IntPtr (IntPtr receiver, IntPtr selector, SCNVector3 arg1, SCNVector3 arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_SCNVector4 (IntPtr receiver, IntPtr selector, SCNVector4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_SCNVector4_Double (IntPtr receiver, IntPtr selector, SCNVector4 arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_short (IntPtr receiver, IntPtr selector, short arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_short_IntPtr (IntPtr receiver, IntPtr selector, short arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void IntPtr_objc_msgSend_stret (IntPtr retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UIEdgeInsets (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UIEdgeInsets_int (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UIEdgeInsets_Int64 (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt16 (IntPtr receiver, IntPtr selector, ushort arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_CGSize_bool_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, CGSize arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_Double (IntPtr receiver, IntPtr selector, uint arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_Double_bool_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, double arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_Double_UInt32_bool (IntPtr receiver, IntPtr selector, uint arg1, double arg2, uint arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_int (IntPtr receiver, IntPtr selector, uint arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_int_int (IntPtr receiver, IntPtr selector, uint arg1, int arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_Double_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, double arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_Double_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, double arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_nint (IntPtr receiver, IntPtr selector, uint arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_nint_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, nint arg2, IntPtr arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_nuint_bool (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_nuint_nuint_bool (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, nuint arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_UInt32_int (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_UInt32_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3, bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_UInt32_NSRange_NSRange (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, NSRange arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_UInt32_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt32_UInt64 (IntPtr receiver, IntPtr selector, uint arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_Double (IntPtr receiver, IntPtr selector, ulong arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_Double_bool_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, double arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_Double_UInt32_bool (IntPtr receiver, IntPtr selector, ulong arg1, double arg2, uint arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_Int64 (IntPtr receiver, IntPtr selector, ulong arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_Int64_Double (IntPtr receiver, IntPtr selector, ulong arg1, long arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_Int64_Int64 (IntPtr receiver, IntPtr selector, ulong arg1, long arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_Double_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, double arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_Double_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, double arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_nint (IntPtr receiver, IntPtr selector, ulong arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_nint_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1, nint arg2, IntPtr arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_nuint_bool (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_nuint_nuint_bool (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, nuint arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_UInt64_Int64 (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_UInt64_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3, bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UInt64_UInt64_NSRange_NSRange (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, NSRange arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_UIOffset (IntPtr receiver, IntPtr selector, UIOffset arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern IntPtr IntPtr_objc_msgSend_Vector4 (IntPtr receiver, IntPtr selector, Vector4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_AudioComponentDescription (IntPtr receiver, IntPtr selector, AudioComponentDescription arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_AudioComponentDescription_ref_IntPtr (IntPtr receiver, IntPtr selector, AudioComponentDescription arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_AudioComponentDescription_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, AudioComponentDescription arg1, uint arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_bool_nuint_bool_nuint (IntPtr receiver, IntPtr selector, bool arg1, nuint arg2, bool arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_byte (IntPtr receiver, IntPtr selector, byte arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CATransform3D (IntPtr receiver, IntPtr selector, CATransform3D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGAffineTransform_bool (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_Double (IntPtr receiver, IntPtr selector, CGPoint arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_IntPtr_Double (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_IntPtr_nfloat (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGPoint_nfloat_nfloat_nfloat_bool (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, nfloat arg3, nfloat arg4, bool arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_bool_UIEdgeInsets (IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2, UIEdgeInsets arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_int (IntPtr receiver, IntPtr selector, CGRect arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_int_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, int arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_Int64 (IntPtr receiver, IntPtr selector, CGRect arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_IntPtr_nuint (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_nfloat (IntPtr receiver, IntPtr selector, CGRect arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_UInt32_CGSize (IntPtr receiver, IntPtr selector, CGRect arg1, uint arg2, CGSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGRect_UInt64_CGSize (IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, CGSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGSize (IntPtr receiver, IntPtr selector, CGSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGSize_CGPoint (IntPtr receiver, IntPtr selector, CGSize arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGSize_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGSize_nfloat (IntPtr receiver, IntPtr selector, CGSize arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGSize_UInt32 (IntPtr receiver, IntPtr selector, CGSize arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGVector (IntPtr receiver, IntPtr selector, CGVector arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGVector_CGPoint_Double (IntPtr receiver, IntPtr selector, CGVector arg1, CGPoint arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CGVector_Double (IntPtr receiver, IntPtr selector, CGVector arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_CLLocationCoordinate2D_Double (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, CLLocationCoordinate2D arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, double arg3, double arg4, double arg5, double arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, double arg3, double arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_IntPtr (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_Double_nfloat_Double (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, double arg2, nfloat arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CMTime_float (IntPtr receiver, IntPtr selector, CMTime arg1, float arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CMTime_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CMTime_out_CMTime_ref_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, out CMTime arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CMTime_ref_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1, ref CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CMTimeMapping (IntPtr receiver, IntPtr selector, CMTimeMapping arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_CMTimeRange (IntPtr receiver, IntPtr selector, CMTimeRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Double_Double (IntPtr receiver, IntPtr selector, double arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Double_int (IntPtr receiver, IntPtr selector, double arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Double_Int64 (IntPtr receiver, IntPtr selector, double arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, bool arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Double_out_NSEnergyFormatterUnit (IntPtr receiver, IntPtr selector, double arg1, out NSEnergyFormatterUnit arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Double_ref_NSLengthFormatterUnit (IntPtr receiver, IntPtr selector, double arg1, ref NSLengthFormatterUnit arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Double_ref_NSMassFormatterUnit (IntPtr receiver, IntPtr selector, double arg1, ref NSMassFormatterUnit arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Double_UInt32 (IntPtr receiver, IntPtr selector, double arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_float (IntPtr receiver, IntPtr selector, float arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_float_bool_IntPtr (IntPtr receiver, IntPtr selector, float arg1, bool arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_float_Double (IntPtr receiver, IntPtr selector, float arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_CGSize_bool_IntPtr (IntPtr receiver, IntPtr selector, int arg1, CGSize arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_Double (IntPtr receiver, IntPtr selector, int arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_int_UInt32_IntPtr (IntPtr receiver, IntPtr selector, int arg1, int arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_nfloat_IntPtr (IntPtr receiver, IntPtr selector, int arg1, nfloat arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_nint (IntPtr receiver, IntPtr selector, int arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_nint_IntPtr (IntPtr receiver, IntPtr selector, int arg1, nint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_nint_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, nint arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_int_UInt32 (IntPtr receiver, IntPtr selector, int arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_Double (IntPtr receiver, IntPtr selector, long arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_int (IntPtr receiver, IntPtr selector, long arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_Int64 (IntPtr receiver, IntPtr selector, long arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_Int64_IntPtr (IntPtr receiver, IntPtr selector, long arg1, long arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_Int64_UInt64_IntPtr (IntPtr receiver, IntPtr selector, long arg1, long arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_IntPtr_Int64 (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_nfloat_IntPtr (IntPtr receiver, IntPtr selector, long arg1, nfloat arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_nint (IntPtr receiver, IntPtr selector, long arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_nint_IntPtr (IntPtr receiver, IntPtr selector, long arg1, nint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_nint_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, long arg1, nint arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8, IntPtr arg9);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_short_bool (IntPtr receiver, IntPtr selector, long arg1, short arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Int64_UInt64 (IntPtr receiver, IntPtr selector, long arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool_bool_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, bool arg4, bool arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool_bool_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool_bool_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, bool arg3, nfloat arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGAffineTransform (IntPtr receiver, IntPtr selector, IntPtr arg1, CGAffineTransform arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGPoint_CGVector (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGVector arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGPoint_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, IntPtr arg3, CGPoint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGRect_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, int arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGRect_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGSize_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CGSize_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, uint arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, CMTimeRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double_bool_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, bool arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Double_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, bool arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_float_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, CGSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_float_float_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, float arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_float_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_CMTimeRange_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, CMTimeRange arg3, CMTimeRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_float_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, float arg3, float arg4, float arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_int_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4, float arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_int_IntPtr_int_nfloat_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, IntPtr arg4, int arg5, nfloat arg6, nfloat arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, nint arg3, nint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_int_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_Int64_IntPtr_Int64_nfloat_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, IntPtr arg4, long arg5, nfloat arg6, nfloat arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, nint arg3, nint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Int64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3, CGPoint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CGPoint_CGVector (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGPoint arg3, CGVector arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, float arg3, float arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, nuint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint_bool_nint_nint_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3, bool arg4, nint arg5, nint arg6, nint arg7, nint arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nint_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, nuint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint_UInt32_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, uint arg4, int arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint_UInt32_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, uint arg4, int arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint_UInt64_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, ulong arg4, long arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_nuint_UInt64_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, ulong arg4, long arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, uint arg4, uint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_float_float_int_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, float arg4, float arg5, int arg6, IntPtr arg7, uint arg8, IntPtr arg9, IntPtr arg10);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64_UInt64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ulong arg4, ulong arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Matrix2 (IntPtr receiver, IntPtr selector, IntPtr arg1, Matrix2 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Matrix3 (IntPtr receiver, IntPtr selector, IntPtr arg1, Matrix3 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Matrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, Matrix4 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_MDLAxisAlignedBoundingBox_float (IntPtr receiver, IntPtr selector, IntPtr arg1, MDLAxisAlignedBoundingBox arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nfloat_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nfloat_int (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nfloat_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nfloat_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nint_CGSize_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, CGSize arg3, int arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nint_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nint_nint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nint_out_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, out NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nint_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, out NSRange arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_float_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, float arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, int arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_nuint_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_UInt32_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, uint arg3, int arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_UInt64_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, ulong arg3, long arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_nuint_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_out_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, out nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_ref_MPSImageHistogramInfo (IntPtr receiver, IntPtr selector, IntPtr arg1, ref MPSImageHistogramInfo arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_SCNMatrix4_SCNMatrix4_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNMatrix4 arg2, SCNMatrix4 arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNVector3 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_SCNVector3_IntPtr_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNVector3 arg2, IntPtr arg3, SCNVector3 arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_SCNVector3_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNVector3 arg2, SCNVector3 arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_SCNVector3_SCNVector3_IntPtr_SCNVector3_SCNVector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNVector3 arg2, SCNVector3 arg3, IntPtr arg4, SCNVector3 arg5, SCNVector3 arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UIEdgeInsets_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, UIEdgeInsets arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UIEdgeInsets_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, UIEdgeInsets arg2, int arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UIEdgeInsets_Int64_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, UIEdgeInsets arg2, long arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt16_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ushort arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt16_UInt16_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ushort arg2, ushort arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, bool arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_float (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr_nint_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, nint arg4, nint arg5, nint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr_out_Boolean_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, out bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, nuint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_ref_NSPropertyListFormat_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref NSPropertyListFormat arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt32_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, bool arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_float (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_nint_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, nint arg4, nint arg5, nint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_out_Boolean_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, out bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, nuint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ref IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_ref_NSPropertyListFormat_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ref NSPropertyListFormat arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UInt64_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UIOffset_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, UIOffset arg2, CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_UIOffset_IntPtr_UIOffset (IntPtr receiver, IntPtr selector, IntPtr arg1, UIOffset arg2, IntPtr arg3, UIOffset arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, Vector2 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Vector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, Vector3 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_IntPtr_Vector4 (IntPtr receiver, IntPtr selector, IntPtr arg1, Vector4 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_MDLVoxelIndexExtent (IntPtr receiver, IntPtr selector, MDLVoxelIndexExtent arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_MKCoordinateSpan (IntPtr receiver, IntPtr selector, MKCoordinateSpan arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_MKMapRect (IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_MKTileOverlayPath (IntPtr receiver, IntPtr selector, MKTileOverlayPath arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_CGPoint (IntPtr receiver, IntPtr selector, nfloat arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_CGSize (IntPtr receiver, IntPtr selector, nfloat arg1, CGSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_CGSize_bool (IntPtr receiver, IntPtr selector, nfloat arg1, CGSize arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_Double (IntPtr receiver, IntPtr selector, nfloat arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_Double_bool (IntPtr receiver, IntPtr selector, nfloat arg1, double arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_IntPtr (IntPtr receiver, IntPtr selector, nfloat arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_nfloat_Double (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_nfloat_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_nfloat_nfloat_Double (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2, nfloat arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_nfloat_nfloat_Double_bool (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2, nfloat arg3, double arg4, bool arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_nfloat_nfloat_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2, nfloat arg3, nfloat arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nfloat_SCNVector3_Double (IntPtr receiver, IntPtr selector, nfloat arg1, SCNVector3 arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_bool (IntPtr receiver, IntPtr selector, nint arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_IntPtr_ref_NSRange_ref_NSRange (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2, ref NSRange arg3, ref NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_IntPtr_ref_NSRange_ref_NSRange_ref_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2, ref NSRange arg3, ref NSRange arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_nint (IntPtr receiver, IntPtr selector, nint arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_nint_nint_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, nint arg1, nint arg2, nint arg3, IntPtr arg4, uint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_nint_nint_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, nint arg1, nint arg2, nint arg3, IntPtr arg4, ulong arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_nint_nint_nint_nint_nint_nint_nint (IntPtr receiver, IntPtr selector, nint arg1, nint arg2, nint arg3, nint arg4, nint arg5, nint arg6, nint arg7, nint arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_out_NSRange (IntPtr receiver, IntPtr selector, nint arg1, out NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_out_NSRange_NSRange (IntPtr receiver, IntPtr selector, nint arg1, out NSRange arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_ref_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nint_ref_NSRange (IntPtr receiver, IntPtr selector, nint arg1, ref NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_NSDecimal (IntPtr receiver, IntPtr selector, NSDecimal arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, uint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_NSRange_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ulong arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nuint_nuint (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nuint_out_NSRange_bool (IntPtr receiver, IntPtr selector, nuint arg1, out NSRange arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nuint_UInt32 (IntPtr receiver, IntPtr selector, nuint arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_nuint_UInt64 (IntPtr receiver, IntPtr selector, nuint arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_out_nuint (IntPtr receiver, IntPtr selector, out nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_ref_AudioStreamBasicDescription (IntPtr receiver, IntPtr selector, ref AudioStreamBasicDescription arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_ref_AudioStreamBasicDescription_IntPtr (IntPtr receiver, IntPtr selector, ref AudioStreamBasicDescription arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_ref_AudioTimeStamp_Double (IntPtr receiver, IntPtr selector, ref AudioTimeStamp arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_ref_CGPoint_nuint (IntPtr receiver, IntPtr selector, ref CGPoint arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_ref_IntPtr (IntPtr receiver, IntPtr selector, ref IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_ref_Single (IntPtr receiver, IntPtr selector, ref float arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_SByte (IntPtr receiver, IntPtr selector, sbyte arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_SCNMatrix4 (IntPtr receiver, IntPtr selector, SCNMatrix4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_SCNVector3 (IntPtr receiver, IntPtr selector, SCNVector3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_SCNVector3_Double (IntPtr receiver, IntPtr selector, SCNVector3 arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_SCNVector3_SCNVector3_IntPtr (IntPtr receiver, IntPtr selector, SCNVector3 arg1, SCNVector3 arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_SCNVector4 (IntPtr receiver, IntPtr selector, SCNVector4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_SCNVector4_Double (IntPtr receiver, IntPtr selector, SCNVector4 arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_short (IntPtr receiver, IntPtr selector, short arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_short_IntPtr (IntPtr receiver, IntPtr selector, short arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void IntPtr_objc_msgSendSuper_stret (IntPtr retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UIEdgeInsets (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UIEdgeInsets_int (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UIEdgeInsets_Int64 (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt16 (IntPtr receiver, IntPtr selector, ushort arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_CGSize_bool_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, CGSize arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_Double (IntPtr receiver, IntPtr selector, uint arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_Double_bool_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, double arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_Double_UInt32_bool (IntPtr receiver, IntPtr selector, uint arg1, double arg2, uint arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_int (IntPtr receiver, IntPtr selector, uint arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_int_int (IntPtr receiver, IntPtr selector, uint arg1, int arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr_Double_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, double arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr_Double_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, double arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_nint (IntPtr receiver, IntPtr selector, uint arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_nint_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, nint arg2, IntPtr arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_nuint_bool (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_nuint_nuint_bool (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, nuint arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32_int (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3, bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32_NSRange_NSRange (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, NSRange arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt32_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt32_UInt64 (IntPtr receiver, IntPtr selector, uint arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_Double (IntPtr receiver, IntPtr selector, ulong arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_Double_bool_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, double arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_Double_UInt32_bool (IntPtr receiver, IntPtr selector, ulong arg1, double arg2, uint arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_Int64 (IntPtr receiver, IntPtr selector, ulong arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_Int64_Double (IntPtr receiver, IntPtr selector, ulong arg1, long arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_Int64_Int64 (IntPtr receiver, IntPtr selector, ulong arg1, long arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_Double_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, double arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_Double_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, double arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6, IntPtr arg7, IntPtr arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_nint (IntPtr receiver, IntPtr selector, ulong arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_nint_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1, nint arg2, IntPtr arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_nuint_bool (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_nuint_nuint_bool (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, nuint arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_UInt64_Int64 (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_UInt64_IntPtr_bool_ref_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3, bool arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UInt64_UInt64_NSRange_NSRange (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, NSRange arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_UIOffset (IntPtr receiver, IntPtr selector, UIOffset arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern IntPtr IntPtr_objc_msgSendSuper_Vector4 (IntPtr receiver, IntPtr selector, Vector4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern Matrix2 Matrix2_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void Matrix2_objc_msgSend_stret (out Matrix2 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern Matrix2 Matrix2_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void Matrix2_objc_msgSendSuper_stret (out Matrix2 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern Matrix3 Matrix3_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void Matrix3_objc_msgSend_stret (out Matrix3 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern Matrix3 Matrix3_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void Matrix3_objc_msgSendSuper_stret (out Matrix3 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern Matrix4 Matrix4_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void Matrix4_objc_msgSend_stret (out Matrix4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern Matrix4 Matrix4_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void Matrix4_objc_msgSendSuper_stret (out Matrix4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MDLAxisAlignedBoundingBox MDLAxisAlignedBoundingBox_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MDLAxisAlignedBoundingBox_objc_msgSend_stret (out MDLAxisAlignedBoundingBox retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MDLAxisAlignedBoundingBox MDLAxisAlignedBoundingBox_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret (out MDLAxisAlignedBoundingBox retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MDLVoxelIndexExtent MDLVoxelIndexExtent_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MDLVoxelIndexExtent_objc_msgSend_stret (out MDLVoxelIndexExtent retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MDLVoxelIndexExtent MDLVoxelIndexExtent_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MDLVoxelIndexExtent_objc_msgSendSuper_stret (out MDLVoxelIndexExtent retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MKCoordinateRegion MKCoordinateRegion_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MKCoordinateRegion MKCoordinateRegion_objc_msgSend_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MKCoordinateRegion MKCoordinateRegion_objc_msgSend_MKCoordinateRegion (IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MKCoordinateRegion_objc_msgSend_stret (out MKCoordinateRegion retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MKCoordinateRegion_objc_msgSend_stret_CGRect_IntPtr (out MKCoordinateRegion retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MKCoordinateRegion_objc_msgSend_stret_MKCoordinateRegion (out MKCoordinateRegion retval, IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MKCoordinateRegion MKCoordinateRegion_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MKCoordinateRegion MKCoordinateRegion_objc_msgSendSuper_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MKCoordinateRegion MKCoordinateRegion_objc_msgSendSuper_MKCoordinateRegion (IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MKCoordinateRegion_objc_msgSendSuper_stret (out MKCoordinateRegion retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MKCoordinateRegion_objc_msgSendSuper_stret_CGRect_IntPtr (out MKCoordinateRegion retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MKCoordinateRegion_objc_msgSendSuper_stret_MKCoordinateRegion (out MKCoordinateRegion retval, IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MKCoordinateSpan MKCoordinateSpan_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MKCoordinateSpan_objc_msgSend_stret (out MKCoordinateSpan retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MKCoordinateSpan MKCoordinateSpan_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MKCoordinateSpan_objc_msgSendSuper_stret (out MKCoordinateSpan retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MKMapPoint MKMapPoint_objc_msgSend_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MKMapPoint_objc_msgSend_stret_CGPoint (out MKMapPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MKMapPoint MKMapPoint_objc_msgSendSuper_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MKMapPoint_objc_msgSendSuper_stret_CGPoint (out MKMapPoint retval, IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MKMapRect MKMapRect_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MKMapRect MKMapRect_objc_msgSend_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MKMapRect MKMapRect_objc_msgSend_MKMapRect (IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MKMapRect MKMapRect_objc_msgSend_MKMapRect_UIEdgeInsets (IntPtr receiver, IntPtr selector, MKMapRect arg1, UIEdgeInsets arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MKMapRect_objc_msgSend_stret (out MKMapRect retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MKMapRect_objc_msgSend_stret_CGRect (out MKMapRect retval, IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MKMapRect_objc_msgSend_stret_MKMapRect (out MKMapRect retval, IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MKMapRect_objc_msgSend_stret_MKMapRect_UIEdgeInsets (out MKMapRect retval, IntPtr receiver, IntPtr selector, MKMapRect arg1, UIEdgeInsets arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MKMapRect MKMapRect_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MKMapRect MKMapRect_objc_msgSendSuper_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MKMapRect MKMapRect_objc_msgSendSuper_MKMapRect (IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MKMapRect MKMapRect_objc_msgSendSuper_MKMapRect_UIEdgeInsets (IntPtr receiver, IntPtr selector, MKMapRect arg1, UIEdgeInsets arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MKMapRect_objc_msgSendSuper_stret (out MKMapRect retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MKMapRect_objc_msgSendSuper_stret_CGRect (out MKMapRect retval, IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MKMapRect_objc_msgSendSuper_stret_MKMapRect (out MKMapRect retval, IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MKMapRect_objc_msgSendSuper_stret_MKMapRect_UIEdgeInsets (out MKMapRect retval, IntPtr receiver, IntPtr selector, MKMapRect arg1, UIEdgeInsets arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MPSImageHistogramInfo MPSImageHistogramInfo_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MPSImageHistogramInfo_objc_msgSend_stret (out MPSImageHistogramInfo retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MPSImageHistogramInfo MPSImageHistogramInfo_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MPSImageHistogramInfo_objc_msgSendSuper_stret (out MPSImageHistogramInfo retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MPSOffset MPSOffset_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MPSOffset_objc_msgSend_stret (out MPSOffset retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MPSOffset MPSOffset_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MPSOffset_objc_msgSendSuper_stret (out MPSOffset retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MPSRegion MPSRegion_objc_msgSend_MTLSize (IntPtr receiver, IntPtr selector, MTLSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MPSRegion_objc_msgSend_stret_MTLSize (out MPSRegion retval, IntPtr receiver, IntPtr selector, MTLSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MPSRegion MPSRegion_objc_msgSendSuper_MTLSize (IntPtr receiver, IntPtr selector, MTLSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MPSRegion_objc_msgSendSuper_stret_MTLSize (out MPSRegion retval, IntPtr receiver, IntPtr selector, MTLSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MTLClearColor MTLClearColor_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MTLClearColor_objc_msgSend_stret (out MTLClearColor retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MTLClearColor MTLClearColor_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MTLClearColor_objc_msgSendSuper_stret (out MTLClearColor retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MTLRegion MTLRegion_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MTLRegion_objc_msgSend_stret (out MTLRegion retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MTLRegion MTLRegion_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MTLRegion_objc_msgSendSuper_stret (out MTLRegion retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern MTLSize MTLSize_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void MTLSize_objc_msgSend_stret (out MTLSize retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern MTLSize MTLSize_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void MTLSize_objc_msgSendSuper_stret (out MTLSize retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_IntPtr_nuint_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, CGRect arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nfloat nfloat_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_IntPtr_nuint_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, CGRect arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nfloat nfloat_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_IntPtr_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, uint arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_IntPtr_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ulong arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nint nint_objc_msgSend_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_IntPtr_IntPtr_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_IntPtr_IntPtr_UInt32_UInt32_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, uint arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_IntPtr_IntPtr_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_IntPtr_IntPtr_UInt64_UInt64_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ulong arg4, ref IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nint nint_objc_msgSendSuper_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSDecimal NSDecimal_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSDecimal_objc_msgSend_stret (out NSDecimal retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSDecimal NSDecimal_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSDecimal_objc_msgSendSuper_stret (out NSDecimal retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSOperatingSystemVersion NSOperatingSystemVersion_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSOperatingSystemVersion_objc_msgSend_stret (out NSOperatingSystemVersion retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSOperatingSystemVersion NSOperatingSystemVersion_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSOperatingSystemVersion_objc_msgSendSuper_stret (out NSOperatingSystemVersion retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_IntPtr_NSRange_nint_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, nint arg3, bool arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_IntPtr_UInt64_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret (out NSRange retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_CGRect_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_IntPtr_NSRange_nint_bool_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, nint arg3, bool arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_IntPtr_UInt32_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_IntPtr_UInt64_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_NSRange_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_nuint (out NSRange retval, IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_UInt32 (out NSRange retval, IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_UInt32_UInt32_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_UInt64 (out NSRange retval, IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void NSRange_objc_msgSend_stret_UInt64_UInt64_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern NSRange NSRange_objc_msgSend_UInt64_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_IntPtr_NSRange_nint_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, nint arg3, bool arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_IntPtr_UInt64_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret (out NSRange retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_CGRect_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_IntPtr_NSRange_nint_bool_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, nint arg3, bool arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_IntPtr_UInt32_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_IntPtr_UInt64_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_NSRange (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_NSRange_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_nuint (out NSRange retval, IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_UInt32 (out NSRange retval, IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_UInt32_UInt32_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_UInt64 (out NSRange retval, IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void NSRange_objc_msgSendSuper_stret_UInt64_UInt64_IntPtr (out NSRange retval, IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern NSRange NSRange_objc_msgSendSuper_UInt64_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_CGPoint_IntPtr_ref_nfloat (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2, ref nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_Int64_nuint_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, nuint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, NSRange arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_IntPtr_ref_IntPtr_out_Boolean (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, out bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_IntPtr_UInt64_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_UInt64_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_IntPtr_UInt64_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_NSRange_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_nuint_bool_bool_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, bool arg2, bool arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern nuint nuint_objc_msgSend_UInt64_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_CGPoint_IntPtr_ref_nfloat (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2, ref nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_Int64_nuint_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, nuint arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5, NSRange arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_IntPtr_ref_IntPtr_out_Boolean (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ref IntPtr arg3, out bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_IntPtr_UInt64_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_UInt32_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_UInt64_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_IntPtr_UInt64_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_NSRange_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_nuint_bool_bool_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, bool arg2, bool arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern nuint nuint_objc_msgSendSuper_UInt64_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern Quaterniond Quaterniond_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void Quaterniond_objc_msgSend_stret (out Quaterniond retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern Quaterniond Quaterniond_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void Quaterniond_objc_msgSendSuper_stret (out Quaterniond retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern sbyte SByte_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern sbyte SByte_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern SCNMatrix4 SCNMatrix4_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern SCNMatrix4 SCNMatrix4_objc_msgSend_SCNMatrix4_IntPtr (IntPtr receiver, IntPtr selector, SCNMatrix4 arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void SCNMatrix4_objc_msgSend_stret (out SCNMatrix4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void SCNMatrix4_objc_msgSend_stret_SCNMatrix4_IntPtr (out SCNMatrix4 retval, IntPtr receiver, IntPtr selector, SCNMatrix4 arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern SCNMatrix4 SCNMatrix4_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern SCNMatrix4 SCNMatrix4_objc_msgSendSuper_SCNMatrix4_IntPtr (IntPtr receiver, IntPtr selector, SCNMatrix4 arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void SCNMatrix4_objc_msgSendSuper_stret (out SCNMatrix4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void SCNMatrix4_objc_msgSendSuper_stret_SCNMatrix4_IntPtr (out SCNMatrix4 retval, IntPtr receiver, IntPtr selector, SCNMatrix4 arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern SCNQuaternion SCNQuaternion_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void SCNQuaternion_objc_msgSend_stret (out SCNQuaternion retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern SCNQuaternion SCNQuaternion_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void SCNQuaternion_objc_msgSendSuper_stret (out SCNQuaternion retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern SCNVector3 SCNVector3_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern SCNVector3 SCNVector3_objc_msgSend_SCNVector3 (IntPtr receiver, IntPtr selector, SCNVector3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern SCNVector3 SCNVector3_objc_msgSend_SCNVector3_IntPtr (IntPtr receiver, IntPtr selector, SCNVector3 arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void SCNVector3_objc_msgSend_stret (out SCNVector3 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void SCNVector3_objc_msgSend_stret_SCNVector3 (out SCNVector3 retval, IntPtr receiver, IntPtr selector, SCNVector3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void SCNVector3_objc_msgSend_stret_SCNVector3_IntPtr (out SCNVector3 retval, IntPtr receiver, IntPtr selector, SCNVector3 arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern SCNVector3 SCNVector3_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern SCNVector3 SCNVector3_objc_msgSendSuper_SCNVector3 (IntPtr receiver, IntPtr selector, SCNVector3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern SCNVector3 SCNVector3_objc_msgSendSuper_SCNVector3_IntPtr (IntPtr receiver, IntPtr selector, SCNVector3 arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void SCNVector3_objc_msgSendSuper_stret (out SCNVector3 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void SCNVector3_objc_msgSendSuper_stret_SCNVector3 (out SCNVector3 retval, IntPtr receiver, IntPtr selector, SCNVector3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void SCNVector3_objc_msgSendSuper_stret_SCNVector3_IntPtr (out SCNVector3 retval, IntPtr receiver, IntPtr selector, SCNVector3 arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern SCNVector4 SCNVector4_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void SCNVector4_objc_msgSend_stret (out SCNVector4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern SCNVector4 SCNVector4_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void SCNVector4_objc_msgSendSuper_stret (out SCNVector4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern short short_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern short short_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIEdgeInsets UIEdgeInsets_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIEdgeInsets UIEdgeInsets_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIEdgeInsets UIEdgeInsets_objc_msgSend_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIEdgeInsets_objc_msgSend_stret (out UIEdgeInsets retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIEdgeInsets_objc_msgSend_stret_IntPtr (out UIEdgeInsets retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIEdgeInsets_objc_msgSend_stret_IntPtr_IntPtr_nint (out UIEdgeInsets retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIEdgeInsets_objc_msgSend_stret_UIEdgeInsets (out UIEdgeInsets retval, IntPtr receiver, IntPtr selector, UIEdgeInsets arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIEdgeInsets UIEdgeInsets_objc_msgSend_UIEdgeInsets (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIEdgeInsets UIEdgeInsets_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIEdgeInsets UIEdgeInsets_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIEdgeInsets UIEdgeInsets_objc_msgSendSuper_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIEdgeInsets_objc_msgSendSuper_stret (out UIEdgeInsets retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIEdgeInsets_objc_msgSendSuper_stret_IntPtr (out UIEdgeInsets retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIEdgeInsets_objc_msgSendSuper_stret_IntPtr_IntPtr_nint (out UIEdgeInsets retval, IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIEdgeInsets_objc_msgSendSuper_stret_UIEdgeInsets (out UIEdgeInsets retval, IntPtr receiver, IntPtr selector, UIEdgeInsets arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIEdgeInsets UIEdgeInsets_objc_msgSendSuper_UIEdgeInsets (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIFloatRange UIFloatRange_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIFloatRange_objc_msgSend_stret (out UIFloatRange retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIFloatRange UIFloatRange_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIFloatRange_objc_msgSendSuper_stret (out UIFloatRange retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern ushort UInt16_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern ushort UInt16_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern ushort UInt16_objc_msgSend_nuint_ref_Boolean (IntPtr receiver, IntPtr selector, nuint arg1, ref bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern ushort UInt16_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern ushort UInt16_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern ushort UInt16_objc_msgSendSuper_nuint_ref_Boolean (IntPtr receiver, IntPtr selector, nuint arg1, ref bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern uint UInt32_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern uint UInt32_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern uint UInt32_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern uint UInt32_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern uint UInt32_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern uint UInt32_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern uint UInt32_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern uint UInt32_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern ulong UInt64_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern ulong UInt64_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern ulong UInt64_objc_msgSend_Double_ref_IntPtr (IntPtr receiver, IntPtr selector, double arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern ulong UInt64_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern ulong UInt64_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern ulong UInt64_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern ulong UInt64_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern ulong UInt64_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern ulong UInt64_objc_msgSendSuper_Double_ref_IntPtr (IntPtr receiver, IntPtr selector, double arg1, ref IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern ulong UInt64_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern ulong UInt64_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern ulong UInt64_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIOffset UIOffset_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIOffset UIOffset_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIOffset UIOffset_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIOffset UIOffset_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIOffset UIOffset_objc_msgSend_Int64_Int64 (IntPtr receiver, IntPtr selector, long arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern UIOffset UIOffset_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIOffset_objc_msgSend_stret (out UIOffset retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIOffset_objc_msgSend_stret_int (out UIOffset retval, IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIOffset_objc_msgSend_stret_int_int (out UIOffset retval, IntPtr receiver, IntPtr selector, int arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIOffset_objc_msgSend_stret_Int64 (out UIOffset retval, IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIOffset_objc_msgSend_stret_Int64_Int64 (out UIOffset retval, IntPtr receiver, IntPtr selector, long arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void UIOffset_objc_msgSend_stret_IntPtr (out UIOffset retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIOffset UIOffset_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIOffset UIOffset_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIOffset UIOffset_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIOffset UIOffset_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIOffset UIOffset_objc_msgSendSuper_Int64_Int64 (IntPtr receiver, IntPtr selector, long arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern UIOffset UIOffset_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIOffset_objc_msgSendSuper_stret (out UIOffset retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIOffset_objc_msgSendSuper_stret_int (out UIOffset retval, IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIOffset_objc_msgSendSuper_stret_int_int (out UIOffset retval, IntPtr receiver, IntPtr selector, int arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIOffset_objc_msgSendSuper_stret_Int64 (out UIOffset retval, IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIOffset_objc_msgSendSuper_stret_Int64_Int64 (out UIOffset retval, IntPtr receiver, IntPtr selector, long arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void UIOffset_objc_msgSendSuper_stret_IntPtr (out UIOffset retval, IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern Vector2 Vector2_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void Vector2_objc_msgSend_stret (out Vector2 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern Vector2 Vector2_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void Vector2_objc_msgSendSuper_stret (out Vector2 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern Vector3 Vector3_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void Vector3_objc_msgSend_stret (out Vector3 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern Vector3 Vector3_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void Vector3_objc_msgSendSuper_stret (out Vector3 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern Vector3d Vector3d_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void Vector3d_objc_msgSend_stret (out Vector3d retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern Vector3d Vector3d_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void Vector3d_objc_msgSendSuper_stret (out Vector3d retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern Vector4 Vector4_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend_stret")]
		public static extern void Vector4_objc_msgSend_stret (out Vector4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern Vector4 Vector4_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper_stret")]
		public static extern void Vector4_objc_msgSendSuper_stret (out Vector4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_AudioComponentDescription_UInt32_IntPtr (IntPtr receiver, IntPtr selector, AudioComponentDescription arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_AVAudio3DAngularOrientation (IntPtr receiver, IntPtr selector, AVAudio3DAngularOrientation arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_AVAudio3DVectorOrientation (IntPtr receiver, IntPtr selector, AVAudio3DVectorOrientation arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_AVAudioConverterPrimeInfo (IntPtr receiver, IntPtr selector, AVAudioConverterPrimeInfo arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_AVBeatRange (IntPtr receiver, IntPtr selector, AVBeatRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_AVCaptureWhiteBalanceGains_IntPtr (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_bool (IntPtr receiver, IntPtr selector, bool arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_bool_bool (IntPtr receiver, IntPtr selector, bool arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_bool_int (IntPtr receiver, IntPtr selector, bool arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_bool_Int64 (IntPtr receiver, IntPtr selector, bool arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_bool_nint (IntPtr receiver, IntPtr selector, bool arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_bool_nuint (IntPtr receiver, IntPtr selector, bool arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_byte_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2, byte arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_byte_byte_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2, byte arg3, byte arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CATransform3D (IntPtr receiver, IntPtr selector, CATransform3D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGAffineTransform_CGAffineTransform_CMTimeRange (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CGAffineTransform arg2, CMTimeRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGAffineTransform_CMTime (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGAffineTransform_IntPtr (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGPoint_bool (IntPtr receiver, IntPtr selector, CGPoint arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGPoint_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGPoint_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGPoint_int_nfloat (IntPtr receiver, IntPtr selector, CGPoint arg1, int arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGPoint_nfloat_nfloat_nfloat_bool (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, nfloat arg3, nfloat arg4, bool arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGPoint_NSRange (IntPtr receiver, IntPtr selector, CGPoint arg1, NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_bool (IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_CGRect_CMTimeRange (IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, CMTimeRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_CMTime (IntPtr receiver, IntPtr selector, CGRect arg1, CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_int_nfloat (IntPtr receiver, IntPtr selector, CGRect arg1, int arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_IntPtr_bool (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, uint arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_IntPtr_UInt64_bool (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, ulong arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_nint (IntPtr receiver, IntPtr selector, CGRect arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_NSRange_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1, NSRange arg2, CGRect arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_UInt32_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, uint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_UInt64_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGRect_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGSize (IntPtr receiver, IntPtr selector, CGSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGSize_bool (IntPtr receiver, IntPtr selector, CGSize arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGSize_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGSize_nint (IntPtr receiver, IntPtr selector, CGSize arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGSize_NSRange (IntPtr receiver, IntPtr selector, CGSize arg1, NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGVector (IntPtr receiver, IntPtr selector, CGVector arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGVector_CGPoint (IntPtr receiver, IntPtr selector, CGVector arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CGVector_IntPtr (IntPtr receiver, IntPtr selector, CGVector arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CLLocationCoordinate2D_bool (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CLLocationCoordinate2D_int (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CLLocationCoordinate2D_Int64 (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CLLocationCoordinate2D_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, IntPtr arg2, CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CMTime_CMTime_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CMTime_CMTime_CMTime_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CMTime_float_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, float arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CMTime_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CMTimeRange (IntPtr receiver, IntPtr selector, CMTimeRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_CMTimeRange_CMTime (IntPtr receiver, IntPtr selector, CMTimeRange arg1, CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Double_CGRect_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, CGRect arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Double_Double (IntPtr receiver, IntPtr selector, double arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, double arg1, double arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Double_Double_nfloat_nfloat_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, double arg2, nfloat arg3, nfloat arg4, uint arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Double_Double_nfloat_nfloat_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, double arg2, nfloat arg3, nfloat arg4, ulong arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Double_Double_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, double arg2, uint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Double_Double_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, double arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Double_IntPtr (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float (IntPtr receiver, IntPtr selector, float arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float_bool (IntPtr receiver, IntPtr selector, float arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float_CMTime (IntPtr receiver, IntPtr selector, float arg1, CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float_CMTime_CMTime (IntPtr receiver, IntPtr selector, float arg1, CMTime arg2, CMTime arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float_float_CMTimeRange (IntPtr receiver, IntPtr selector, float arg1, float arg2, CMTimeRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float_int (IntPtr receiver, IntPtr selector, float arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float_Int64 (IntPtr receiver, IntPtr selector, float arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_float_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_int_Double (IntPtr receiver, IntPtr selector, int arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_int_IntPtr_bool (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_int_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, double arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_int_nfloat (IntPtr receiver, IntPtr selector, int arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Int64_bool (IntPtr receiver, IntPtr selector, long arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Int64_Double (IntPtr receiver, IntPtr selector, long arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Int64_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Int64_IntPtr_bool (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Int64_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, double arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Int64_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_AudioComponentDescription_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, AudioComponentDescription arg2, IntPtr arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_bool_int (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_bool_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_bool_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_bool_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_bool_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_CGPoint_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGRect arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_CGPoint_ref_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, ref CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_CGRect_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGRect arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_CGSize_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, int arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_CGSize_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, long arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Double_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, uint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Double_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_float_float_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, float arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_int_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_int_float_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, float arg3, float arg4, float arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_int_int_int_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4, float arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_int_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Int64_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Int64_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Int64_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Int64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Int64_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, uint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_Int64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_CGRect_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_CMTimeRange_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CMTimeRange arg3, IntPtr arg4, CMTimeRange arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_Double_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, uint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_Double_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, uint arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_Double_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, ulong arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_Double_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, ulong arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_Int64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4, long arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CGPoint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_CGRect_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CGRect arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_CMTime (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CMTime arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, double arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, NSRange arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_nuint_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, nuint arg4, IntPtr arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, uint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_nint_CGRect_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3, CGRect arg4, int arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_nuint_IntPtr_CGAffineTransform_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, IntPtr arg4, CGAffineTransform arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, nuint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_nuint_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_nuint_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_IntPtr_UInt64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nfloat_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nint_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nint_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nint_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3, nint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nint_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, ref IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_NSRange_byte (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, byte arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_NSRange_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_NSRange_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_int (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3, nuint arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_MTLRegion_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, MTLRegion arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_MTLSize (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, MTLSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_MTLOrigin (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, MTLOrigin arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, MTLOrigin arg9);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, MTLOrigin arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, nuint arg9);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_nuint_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, MTLOrigin arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, nuint arg9, uint arg10);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_nuint_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, MTLOrigin arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, nuint arg9, ulong arg10);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_nuint_MTLRegion_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, MTLRegion arg4, nuint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_nuint_nuint_MTLSize_IntPtr_nuint_nuint_MTLOrigin (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, nuint arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, MTLOrigin arg9);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_nuint_nuint_MTLSize_IntPtr_nuint_nuint_MTLOrigin_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, nuint arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, MTLOrigin arg9, uint arg10);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_nuint_nuint_MTLSize_IntPtr_nuint_nuint_MTLOrigin_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, nuint arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, MTLOrigin arg9, ulong arg10);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_nuint_nuint_nuint_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, nuint arg4, nuint arg5, nuint arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_out_nint_out_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, out nint arg2, out nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_ref_CGRect_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref CGRect arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_SCNMatrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNMatrix4 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, int arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_IntPtr_UInt32_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, uint arg4, ref IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_NSRange_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, nint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_NSRange_nint_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, nint arg4, NSRange arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, long arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_IntPtr_UInt64_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, ulong arg4, ref IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_NSRange_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, nint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_NSRange_nint_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, nint arg4, NSRange arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ref IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_UInt64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_IntPtr_UInt64_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Matrix2 (IntPtr receiver, IntPtr selector, Matrix2 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Matrix3 (IntPtr receiver, IntPtr selector, Matrix3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Matrix4 (IntPtr receiver, IntPtr selector, Matrix4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MKCoordinateRegion (IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MKCoordinateRegion_bool (IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MKMapRect (IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MKMapRect_bool (IntPtr receiver, IntPtr selector, MKMapRect arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MKMapRect_nfloat (IntPtr receiver, IntPtr selector, MKMapRect arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MKMapRect_nfloat_IntPtr (IntPtr receiver, IntPtr selector, MKMapRect arg1, nfloat arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MKMapRect_UIEdgeInsets_bool (IntPtr receiver, IntPtr selector, MKMapRect arg1, UIEdgeInsets arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MKTileOverlayPath_IntPtr (IntPtr receiver, IntPtr selector, MKTileOverlayPath arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MPSOffset (IntPtr receiver, IntPtr selector, MPSOffset arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MTLClearColor (IntPtr receiver, IntPtr selector, MTLClearColor arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MTLRegion (IntPtr receiver, IntPtr selector, MTLRegion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MTLRegion_nuint_IntPtr_nuint (IntPtr receiver, IntPtr selector, MTLRegion arg1, nuint arg2, IntPtr arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MTLRegion_nuint_nuint_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, MTLRegion arg1, nuint arg2, nuint arg3, IntPtr arg4, nuint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MTLScissorRect (IntPtr receiver, IntPtr selector, MTLScissorRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MTLSize_MTLSize (IntPtr receiver, IntPtr selector, MTLSize arg1, MTLSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_MTLViewport (IntPtr receiver, IntPtr selector, MTLViewport arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nfloat_bool (IntPtr receiver, IntPtr selector, nfloat arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nfloat_float (IntPtr receiver, IntPtr selector, nfloat arg1, float arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nfloat_int (IntPtr receiver, IntPtr selector, nfloat arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nfloat_Int64 (IntPtr receiver, IntPtr selector, nfloat arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nfloat_IntPtr (IntPtr receiver, IntPtr selector, nfloat arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nfloat_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nfloat_nint (IntPtr receiver, IntPtr selector, nfloat arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nfloat_nuint (IntPtr receiver, IntPtr selector, nfloat arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nint_bool (IntPtr receiver, IntPtr selector, nint arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nint_CGRect (IntPtr receiver, IntPtr selector, nint arg1, CGRect arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nint_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nint_nint (IntPtr receiver, IntPtr selector, nint arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nint_nint_bool (IntPtr receiver, IntPtr selector, nint arg1, nint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nint_UInt32 (IntPtr receiver, IntPtr selector, nint arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nint_UInt64 (IntPtr receiver, IntPtr selector, nint arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_CGPoint (IntPtr receiver, IntPtr selector, NSRange arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_Double_nint (IntPtr receiver, IntPtr selector, NSRange arg1, double arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_int_CGRect_NSRange_CGPoint (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, CGRect arg3, NSRange arg4, CGPoint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_int_nfloat_CGRect_NSRange_CGPoint (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, nfloat arg3, CGRect arg4, NSRange arg5, CGPoint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_Int64_CGRect_NSRange_CGPoint (IntPtr receiver, IntPtr selector, NSRange arg1, long arg2, CGRect arg3, NSRange arg4, CGPoint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_Int64_nfloat_CGRect_NSRange_CGPoint (IntPtr receiver, IntPtr selector, NSRange arg1, long arg2, nfloat arg3, CGRect arg4, NSRange arg5, CGPoint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_IntPtr_nuint (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_nint (IntPtr receiver, IntPtr selector, NSRange arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_nint_out_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1, nint arg2, out NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_NSRange_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, NSRange arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_out_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1, out NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_UInt32_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_NSRange_UInt64_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nuint_nint (IntPtr receiver, IntPtr selector, nuint arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nuint_nuint (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nuint_nuint_Double_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2, double arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nuint_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, ref IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_nuint_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, uint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_out_nint_out_nint_out_nint_out_nint_IntPtr (IntPtr receiver, IntPtr selector, out nint arg1, out nint arg2, out nint arg3, out nint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_out_nuint_out_nuint_out_nuint_NSRange (IntPtr receiver, IntPtr selector, out nuint arg1, out nuint arg2, out nuint arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_ref_nuint_ref_nuint (IntPtr receiver, IntPtr selector, ref nuint arg1, ref nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_ref_SCNVector3_ref_SCNVector3 (IntPtr receiver, IntPtr selector, ref SCNVector3 arg1, ref SCNVector3 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_SCNMatrix4 (IntPtr receiver, IntPtr selector, SCNMatrix4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_SCNQuaternion (IntPtr receiver, IntPtr selector, SCNQuaternion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_SCNVector3 (IntPtr receiver, IntPtr selector, SCNVector3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_SCNVector3_bool (IntPtr receiver, IntPtr selector, SCNVector3 arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_SCNVector3_SCNVector3_bool (IntPtr receiver, IntPtr selector, SCNVector3 arg1, SCNVector3 arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_SCNVector4 (IntPtr receiver, IntPtr selector, SCNVector4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_SCNVector4_bool (IntPtr receiver, IntPtr selector, SCNVector4 arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UIEdgeInsets (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UIEdgeInsets_IntPtr (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UIFloatRange (IntPtr receiver, IntPtr selector, UIFloatRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt16_byte (IntPtr receiver, IntPtr selector, ushort arg1, byte arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_bool (IntPtr receiver, IntPtr selector, uint arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_IntPtr_nuint (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, uint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_NSRange_nint (IntPtr receiver, IntPtr selector, uint arg1, NSRange arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_nuint_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_nuint_nuint_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, nuint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_nuint_nuint_nuint_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, nuint arg3, nuint arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_nuint_UInt32_IntPtr_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, uint arg3, IntPtr arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_nuint_UInt32_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, uint arg3, IntPtr arg4, nuint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_nuint_UInt32_IntPtr_nuint_nuint_nint_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, uint arg3, IntPtr arg4, nuint arg5, nuint arg6, nint arg7, nuint arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt32_UInt32_IntPtr_nuint_IntPtr_nuint (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3, nuint arg4, IntPtr arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_bool (IntPtr receiver, IntPtr selector, ulong arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_IntPtr_nuint (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_IntPtr_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_NSRange_nint (IntPtr receiver, IntPtr selector, ulong arg1, NSRange arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_nuint_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_nuint_nuint_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, nuint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_nuint_nuint_nuint_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, nuint arg3, nuint arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_nuint_UInt64_IntPtr_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, ulong arg3, IntPtr arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_nuint_UInt64_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, ulong arg3, IntPtr arg4, nuint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_nuint_UInt64_IntPtr_nuint_nuint_nint_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, ulong arg3, IntPtr arg4, nuint arg5, nuint arg6, nint arg7, nuint arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UInt64_UInt64_IntPtr_nuint_IntPtr_nuint (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3, nuint arg4, IntPtr arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UIOffset (IntPtr receiver, IntPtr selector, UIOffset arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UIOffset_int (IntPtr receiver, IntPtr selector, UIOffset arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UIOffset_int_int (IntPtr receiver, IntPtr selector, UIOffset arg1, int arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UIOffset_Int64 (IntPtr receiver, IntPtr selector, UIOffset arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UIOffset_Int64_Int64 (IntPtr receiver, IntPtr selector, UIOffset arg1, long arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_UIOffset_IntPtr (IntPtr receiver, IntPtr selector, UIOffset arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Vector2 (IntPtr receiver, IntPtr selector, Vector2 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSend")]
		public static extern void void_objc_msgSend_Vector4 (IntPtr receiver, IntPtr selector, Vector4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_AudioComponentDescription_UInt32_IntPtr (IntPtr receiver, IntPtr selector, AudioComponentDescription arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_AVAudio3DAngularOrientation (IntPtr receiver, IntPtr selector, AVAudio3DAngularOrientation arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_AVAudio3DVectorOrientation (IntPtr receiver, IntPtr selector, AVAudio3DVectorOrientation arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_AVAudioConverterPrimeInfo (IntPtr receiver, IntPtr selector, AVAudioConverterPrimeInfo arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_AVBeatRange (IntPtr receiver, IntPtr selector, AVBeatRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_AVCaptureWhiteBalanceGains_IntPtr (IntPtr receiver, IntPtr selector, AVCaptureWhiteBalanceGains arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_bool (IntPtr receiver, IntPtr selector, bool arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_bool_bool (IntPtr receiver, IntPtr selector, bool arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_bool_int (IntPtr receiver, IntPtr selector, bool arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_bool_Int64 (IntPtr receiver, IntPtr selector, bool arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_bool_IntPtr (IntPtr receiver, IntPtr selector, bool arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_bool_nint (IntPtr receiver, IntPtr selector, bool arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_bool_nuint (IntPtr receiver, IntPtr selector, bool arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_byte_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2, byte arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_byte_byte_byte_byte (IntPtr receiver, IntPtr selector, byte arg1, byte arg2, byte arg3, byte arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CATransform3D (IntPtr receiver, IntPtr selector, CATransform3D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGAffineTransform (IntPtr receiver, IntPtr selector, CGAffineTransform arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGAffineTransform_CGAffineTransform_CMTimeRange (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CGAffineTransform arg2, CMTimeRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGAffineTransform_CMTime (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGAffineTransform_IntPtr (IntPtr receiver, IntPtr selector, CGAffineTransform arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGPoint_bool (IntPtr receiver, IntPtr selector, CGPoint arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGPoint_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGPoint_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, CGPoint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGPoint_int_nfloat (IntPtr receiver, IntPtr selector, CGPoint arg1, int arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGPoint_IntPtr (IntPtr receiver, IntPtr selector, CGPoint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGPoint_nfloat_nfloat_nfloat_bool (IntPtr receiver, IntPtr selector, CGPoint arg1, nfloat arg2, nfloat arg3, nfloat arg4, bool arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGPoint_NSRange (IntPtr receiver, IntPtr selector, CGPoint arg1, NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_bool (IntPtr receiver, IntPtr selector, CGRect arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_CGRect_CMTimeRange (IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, CMTimeRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, CGRect arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_CMTime (IntPtr receiver, IntPtr selector, CGRect arg1, CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_int_nfloat (IntPtr receiver, IntPtr selector, CGRect arg1, int arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_IntPtr_bool (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, uint arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_IntPtr_UInt64_bool (IntPtr receiver, IntPtr selector, CGRect arg1, IntPtr arg2, ulong arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_nint (IntPtr receiver, IntPtr selector, CGRect arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_NSRange_CGRect (IntPtr receiver, IntPtr selector, CGRect arg1, NSRange arg2, CGRect arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_UInt32_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, uint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_UInt64_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGRect_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, CGRect arg1, ulong arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGSize (IntPtr receiver, IntPtr selector, CGSize arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGSize_bool (IntPtr receiver, IntPtr selector, CGSize arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGSize_IntPtr (IntPtr receiver, IntPtr selector, CGSize arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGSize_nint (IntPtr receiver, IntPtr selector, CGSize arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGSize_NSRange (IntPtr receiver, IntPtr selector, CGSize arg1, NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGVector (IntPtr receiver, IntPtr selector, CGVector arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGVector_CGPoint (IntPtr receiver, IntPtr selector, CGVector arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CGVector_IntPtr (IntPtr receiver, IntPtr selector, CGVector arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CLLocationCoordinate2D (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CLLocationCoordinate2D_bool (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CLLocationCoordinate2D_int (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CLLocationCoordinate2D_Int64 (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CLLocationCoordinate2D_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, CLLocationCoordinate2D arg1, IntPtr arg2, CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CMTime_CMTime_CMTime (IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CMTime_CMTime_CMTime_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, CMTime arg2, CMTime arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CMTime_float_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, float arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CMTime_IntPtr (IntPtr receiver, IntPtr selector, CMTime arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CMTimeRange (IntPtr receiver, IntPtr selector, CMTimeRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_CMTimeRange_CMTime (IntPtr receiver, IntPtr selector, CMTimeRange arg1, CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Double_CGRect_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, CGRect arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Double_Double (IntPtr receiver, IntPtr selector, double arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Double_Double_IntPtr (IntPtr receiver, IntPtr selector, double arg1, double arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Double_Double_nfloat_nfloat_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, double arg2, nfloat arg3, nfloat arg4, uint arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Double_Double_nfloat_nfloat_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, double arg2, nfloat arg3, nfloat arg4, ulong arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Double_Double_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, double arg2, uint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Double_Double_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, double arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Double_IntPtr (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, double arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float (IntPtr receiver, IntPtr selector, float arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float_bool (IntPtr receiver, IntPtr selector, float arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float_CMTime (IntPtr receiver, IntPtr selector, float arg1, CMTime arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float_CMTime_CMTime (IntPtr receiver, IntPtr selector, float arg1, CMTime arg2, CMTime arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float_float_CMTimeRange (IntPtr receiver, IntPtr selector, float arg1, float arg2, CMTimeRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float_float_float_float (IntPtr receiver, IntPtr selector, float arg1, float arg2, float arg3, float arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float_int (IntPtr receiver, IntPtr selector, float arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float_Int64 (IntPtr receiver, IntPtr selector, float arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_float_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_int (IntPtr receiver, IntPtr selector, int arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_int_bool (IntPtr receiver, IntPtr selector, int arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_int_Double (IntPtr receiver, IntPtr selector, int arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_int_int (IntPtr receiver, IntPtr selector, int arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_int_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_int_IntPtr_bool (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_int_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, double arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_int_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, int arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_int_nfloat (IntPtr receiver, IntPtr selector, int arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Int64 (IntPtr receiver, IntPtr selector, long arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Int64_bool (IntPtr receiver, IntPtr selector, long arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Int64_Double (IntPtr receiver, IntPtr selector, long arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Int64_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Int64_IntPtr_bool (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Int64_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, double arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Int64_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, long arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_AudioComponentDescription_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, AudioComponentDescription arg2, IntPtr arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_bool_int (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_bool_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_bool_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_bool_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_bool_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_CGPoint_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_CGPoint_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, CGRect arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_CGPoint_ref_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, CGPoint arg2, ref CGPoint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_CGRect_CGRect (IntPtr receiver, IntPtr selector, IntPtr arg1, CGRect arg2, CGRect arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_CGSize_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, int arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_CGSize_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, CGSize arg2, long arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Double_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Double_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, uint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Double_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_float (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_float_float_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, float arg2, float arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_int_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_int_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_int_float_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, float arg3, float arg4, float arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_int_int_int_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, int arg3, int arg4, float arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_int_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Int64_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Int64_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, bool arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Int64_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Int64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, long arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Int64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Int64_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, uint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_Int64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_CGRect_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGRect arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_CGSize (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CGSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_CMTimeRange_IntPtr_CMTimeRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, CMTimeRange arg3, IntPtr arg4, CMTimeRange arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Double_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, uint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Double_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, uint arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Double_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, ulong arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Double_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, double arg3, ulong arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, int arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_Int64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, long arg3, long arg4, long arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, bool arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CGPoint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CGPoint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CGRect_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CGRect arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_CMTime (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, CMTime arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, double arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_Double_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, double arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, NSRange arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_nuint_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, nuint arg4, IntPtr arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, uint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, ulong arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_nint_CGRect_int_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nint arg3, CGRect arg4, int arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_nuint_IntPtr_CGAffineTransform_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, IntPtr arg4, CGAffineTransform arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, nuint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_nuint_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_nuint_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, nuint arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3, uint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_IntPtr_UInt64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3, ulong arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nfloat_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nfloat arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nint_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nint_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nint_nint_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3, nint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nint_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, ref IntPtr arg3, ref IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_NSRange_byte (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, byte arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_NSRange_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_NSRange_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, NSRange arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_int (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, IntPtr arg3, nuint arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_MTLRegion_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, MTLRegion arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_MTLSize (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, MTLSize arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_MTLOrigin (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, MTLOrigin arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, MTLOrigin arg9);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, MTLOrigin arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, nuint arg9);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_nuint_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, MTLOrigin arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, nuint arg9, uint arg10);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_nuint_MTLOrigin_MTLSize_IntPtr_nuint_nuint_nuint_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, MTLOrigin arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, nuint arg9, ulong arg10);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_nuint_MTLRegion_nuint_nuint (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, MTLRegion arg4, nuint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_nuint_nuint_MTLSize_IntPtr_nuint_nuint_MTLOrigin (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, nuint arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, MTLOrigin arg9);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_nuint_nuint_MTLSize_IntPtr_nuint_nuint_MTLOrigin_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, nuint arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, MTLOrigin arg9, uint arg10);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_nuint_nuint_MTLSize_IntPtr_nuint_nuint_MTLOrigin_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, nuint arg4, MTLSize arg5, IntPtr arg6, nuint arg7, nuint arg8, MTLOrigin arg9, ulong arg10);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_nuint_nuint_nuint_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, nuint arg2, nuint arg3, nuint arg4, nuint arg5, nuint arg6, IntPtr arg7);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_out_nint_out_nfloat (IntPtr receiver, IntPtr selector, IntPtr arg1, out nint arg2, out nfloat arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_ref_CGRect_ref_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ref CGRect arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_SCNMatrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, SCNMatrix4 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_int_int (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, int arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_IntPtr_UInt32_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, IntPtr arg3, uint arg4, ref IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_NSRange_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, nint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_NSRange_nint_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, NSRange arg3, nint arg4, NSRange arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, ref IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_UInt32_int (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3, int arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt32_UInt32_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_Int64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, long arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_IntPtr_UInt64_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, IntPtr arg3, ulong arg4, ref IntPtr arg5, IntPtr arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_NSRange_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_NSRange_nint (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, nint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_NSRange_nint_NSRange (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, NSRange arg3, nint arg4, NSRange arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_ref_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ref IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_UInt64_Int64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, long arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_IntPtr_UInt64_UInt64_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Matrix2 (IntPtr receiver, IntPtr selector, Matrix2 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Matrix3 (IntPtr receiver, IntPtr selector, Matrix3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Matrix4 (IntPtr receiver, IntPtr selector, Matrix4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MKCoordinateRegion (IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MKCoordinateRegion_bool (IntPtr receiver, IntPtr selector, MKCoordinateRegion arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MKMapRect (IntPtr receiver, IntPtr selector, MKMapRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MKMapRect_bool (IntPtr receiver, IntPtr selector, MKMapRect arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MKMapRect_nfloat (IntPtr receiver, IntPtr selector, MKMapRect arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MKMapRect_nfloat_IntPtr (IntPtr receiver, IntPtr selector, MKMapRect arg1, nfloat arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MKMapRect_UIEdgeInsets_bool (IntPtr receiver, IntPtr selector, MKMapRect arg1, UIEdgeInsets arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MKTileOverlayPath_IntPtr (IntPtr receiver, IntPtr selector, MKTileOverlayPath arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MPSOffset (IntPtr receiver, IntPtr selector, MPSOffset arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MTLClearColor (IntPtr receiver, IntPtr selector, MTLClearColor arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MTLRegion (IntPtr receiver, IntPtr selector, MTLRegion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MTLRegion_nuint_IntPtr_nuint (IntPtr receiver, IntPtr selector, MTLRegion arg1, nuint arg2, IntPtr arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MTLRegion_nuint_nuint_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, MTLRegion arg1, nuint arg2, nuint arg3, IntPtr arg4, nuint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MTLScissorRect (IntPtr receiver, IntPtr selector, MTLScissorRect arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MTLSize_MTLSize (IntPtr receiver, IntPtr selector, MTLSize arg1, MTLSize arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_MTLViewport (IntPtr receiver, IntPtr selector, MTLViewport arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nfloat_bool (IntPtr receiver, IntPtr selector, nfloat arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nfloat_float (IntPtr receiver, IntPtr selector, nfloat arg1, float arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nfloat_int (IntPtr receiver, IntPtr selector, nfloat arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nfloat_Int64 (IntPtr receiver, IntPtr selector, nfloat arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nfloat_IntPtr (IntPtr receiver, IntPtr selector, nfloat arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nfloat_nfloat (IntPtr receiver, IntPtr selector, nfloat arg1, nfloat arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nfloat_nint (IntPtr receiver, IntPtr selector, nfloat arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nfloat_nuint (IntPtr receiver, IntPtr selector, nfloat arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nint (IntPtr receiver, IntPtr selector, nint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nint_bool (IntPtr receiver, IntPtr selector, nint arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nint_CGRect (IntPtr receiver, IntPtr selector, nint arg1, CGRect arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nint_IntPtr (IntPtr receiver, IntPtr selector, nint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nint_nint (IntPtr receiver, IntPtr selector, nint arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nint_nint_bool (IntPtr receiver, IntPtr selector, nint arg1, nint arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nint_UInt32 (IntPtr receiver, IntPtr selector, nint arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nint_UInt64 (IntPtr receiver, IntPtr selector, nint arg1, ulong arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_CGPoint (IntPtr receiver, IntPtr selector, NSRange arg1, CGPoint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_Double_nint (IntPtr receiver, IntPtr selector, NSRange arg1, double arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_int_CGRect_NSRange_CGPoint (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, CGRect arg3, NSRange arg4, CGPoint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_int_nfloat_CGRect_NSRange_CGPoint (IntPtr receiver, IntPtr selector, NSRange arg1, int arg2, nfloat arg3, CGRect arg4, NSRange arg5, CGPoint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_Int64_CGRect_NSRange_CGPoint (IntPtr receiver, IntPtr selector, NSRange arg1, long arg2, CGRect arg3, NSRange arg4, CGPoint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_Int64_nfloat_CGRect_NSRange_CGPoint (IntPtr receiver, IntPtr selector, NSRange arg1, long arg2, nfloat arg3, CGRect arg4, NSRange arg5, CGPoint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_IntPtr_nuint (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_IntPtr_UInt32_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, uint arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_IntPtr_UInt64_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, IntPtr arg2, ulong arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_nint (IntPtr receiver, IntPtr selector, NSRange arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_nint_out_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1, nint arg2, out NSRange arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_NSRange_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, NSRange arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_out_NSRange (IntPtr receiver, IntPtr selector, NSRange arg1, out NSRange arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_UInt32_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, uint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_NSRange_UInt64_IntPtr (IntPtr receiver, IntPtr selector, NSRange arg1, ulong arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nuint_nint (IntPtr receiver, IntPtr selector, nuint arg1, nint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nuint_nuint (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nuint_nuint_Double_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2, double arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nuint_nuint_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, nuint arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nuint_ref_IntPtr_ref_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, ref IntPtr arg2, ref IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_nuint_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, nuint arg1, uint arg2, IntPtr arg3, IntPtr arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_out_nint_out_nint_out_nint_out_nint_IntPtr (IntPtr receiver, IntPtr selector, out nint arg1, out nint arg2, out nint arg3, out nint arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_out_nuint_out_nuint_out_nuint_NSRange (IntPtr receiver, IntPtr selector, out nuint arg1, out nuint arg2, out nuint arg3, NSRange arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_ref_nuint_ref_nuint (IntPtr receiver, IntPtr selector, ref nuint arg1, ref nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_ref_SCNVector3_ref_SCNVector3 (IntPtr receiver, IntPtr selector, ref SCNVector3 arg1, ref SCNVector3 arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_SCNMatrix4 (IntPtr receiver, IntPtr selector, SCNMatrix4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_SCNQuaternion (IntPtr receiver, IntPtr selector, SCNQuaternion arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_SCNVector3 (IntPtr receiver, IntPtr selector, SCNVector3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_SCNVector3_bool (IntPtr receiver, IntPtr selector, SCNVector3 arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_SCNVector3_SCNVector3_bool (IntPtr receiver, IntPtr selector, SCNVector3 arg1, SCNVector3 arg2, bool arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_SCNVector4 (IntPtr receiver, IntPtr selector, SCNVector4 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_SCNVector4_bool (IntPtr receiver, IntPtr selector, SCNVector4 arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UIEdgeInsets (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UIEdgeInsets_IntPtr (IntPtr receiver, IntPtr selector, UIEdgeInsets arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UIFloatRange (IntPtr receiver, IntPtr selector, UIFloatRange arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt16_byte (IntPtr receiver, IntPtr selector, ushort arg1, byte arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32 (IntPtr receiver, IntPtr selector, uint arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_bool (IntPtr receiver, IntPtr selector, uint arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_IntPtr_nuint (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_IntPtr_UInt32_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, uint arg1, IntPtr arg2, uint arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_NSRange_nint (IntPtr receiver, IntPtr selector, uint arg1, NSRange arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_nuint_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_nuint_nuint_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, nuint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_nuint_nuint_nuint_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, nuint arg3, nuint arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_nuint_UInt32_IntPtr_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, uint arg3, IntPtr arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_nuint_UInt32_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, uint arg3, IntPtr arg4, nuint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_nuint_UInt32_IntPtr_nuint_nuint_nint_nuint (IntPtr receiver, IntPtr selector, uint arg1, nuint arg2, uint arg3, IntPtr arg4, nuint arg5, nuint arg6, nint arg7, nuint arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_UInt32 (IntPtr receiver, IntPtr selector, uint arg1, uint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt32_UInt32_IntPtr_nuint_IntPtr_nuint (IntPtr receiver, IntPtr selector, uint arg1, uint arg2, IntPtr arg3, nuint arg4, IntPtr arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64 (IntPtr receiver, IntPtr selector, ulong arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_bool (IntPtr receiver, IntPtr selector, ulong arg1, bool arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, IntPtr arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_IntPtr_nuint (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_IntPtr_UInt64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, ulong arg1, IntPtr arg2, ulong arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_NSRange_nint (IntPtr receiver, IntPtr selector, ulong arg1, NSRange arg2, nint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_nuint_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, nuint arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_nuint_nuint_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, nuint arg3, nuint arg4);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_nuint_nuint_nuint_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, nuint arg3, nuint arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_nuint_UInt64_IntPtr_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, ulong arg3, IntPtr arg4, nuint arg5);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_nuint_UInt64_IntPtr_nuint_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, ulong arg3, IntPtr arg4, nuint arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_nuint_UInt64_IntPtr_nuint_nuint_nint_nuint (IntPtr receiver, IntPtr selector, ulong arg1, nuint arg2, ulong arg3, IntPtr arg4, nuint arg5, nuint arg6, nint arg7, nuint arg8);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UInt64_UInt64_IntPtr_nuint_IntPtr_nuint (IntPtr receiver, IntPtr selector, ulong arg1, ulong arg2, IntPtr arg3, nuint arg4, IntPtr arg5, nuint arg6);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UIOffset (IntPtr receiver, IntPtr selector, UIOffset arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UIOffset_int (IntPtr receiver, IntPtr selector, UIOffset arg1, int arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UIOffset_int_int (IntPtr receiver, IntPtr selector, UIOffset arg1, int arg2, int arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UIOffset_Int64 (IntPtr receiver, IntPtr selector, UIOffset arg1, long arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UIOffset_Int64_Int64 (IntPtr receiver, IntPtr selector, UIOffset arg1, long arg2, long arg3);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_UIOffset_IntPtr (IntPtr receiver, IntPtr selector, UIOffset arg1, IntPtr arg2);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Vector2 (IntPtr receiver, IntPtr selector, Vector2 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("/usr/lib/libobjc.dylib", EntryPoint = "objc_msgSendSuper")]
		public static extern void void_objc_msgSendSuper_Vector4 (IntPtr receiver, IntPtr selector, Vector4 arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSend_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSend_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSend_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSend_IntPtr_nint_nint_nint_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3, nint arg4, uint arg5);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSend_IntPtr_nint_nint_nint_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3, nint arg4, ulong arg5);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSend_IntPtr_UInt32_nint_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, nint arg3, uint arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSend_IntPtr_UInt64_nint_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, nint arg3, ulong arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSendSuper_IntPtr (IntPtr receiver, IntPtr selector, IntPtr arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, uint arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSendSuper_IntPtr_IntPtr_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, ulong arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSendSuper_IntPtr_nint_nint_nint_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3, nint arg4, uint arg5);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSendSuper_IntPtr_nint_nint_nint_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, nint arg2, nint arg3, nint arg4, ulong arg5);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSendSuper_IntPtr_UInt32_nint_UInt32 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, nint arg3, uint arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_IntPtr_objc_msgSendSuper_IntPtr_UInt64_nint_UInt64 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, nint arg3, ulong arg4);

		[DllImport ("__Internal")]
		public static extern bool xamarin_simd__bool_objc_msgSend_Vector2i_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, Vector2i arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("__Internal")]
		public static extern bool xamarin_simd__bool_objc_msgSend_Vector2i_nint_float_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, Vector2i arg1, nint arg2, float arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("__Internal")]
		public static extern bool xamarin_simd__bool_objc_msgSend_Vector4i_bool_bool_bool_bool (IntPtr receiver, IntPtr selector, Vector4i arg1, bool arg2, bool arg3, bool arg4, bool arg5);

		[DllImport ("__Internal")]
		public static extern bool xamarin_simd__bool_objc_msgSendSuper_Vector2i_IntPtr_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, Vector2i arg1, IntPtr arg2, IntPtr arg3, IntPtr arg4, IntPtr arg5);

		[DllImport ("__Internal")]
		public static extern bool xamarin_simd__bool_objc_msgSendSuper_Vector2i_nint_float_IntPtr_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, Vector2i arg1, nint arg2, float arg3, IntPtr arg4, IntPtr arg5, IntPtr arg6);

		[DllImport ("__Internal")]
		public static extern bool xamarin_simd__bool_objc_msgSendSuper_Vector4i_bool_bool_bool_bool (IntPtr receiver, IntPtr selector, Vector4i arg1, bool arg2, bool arg3, bool arg4, bool arg5);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_float_float_IntPtr_Vector2i (IntPtr receiver, IntPtr selector, float arg1, float arg2, IntPtr arg3, Vector2i arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_float_IntPtr_Vector2i_int (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, int arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_float_IntPtr_Vector2i_int_int_bool (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, int arg4, int arg5, bool arg6);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_float_IntPtr_Vector2i_int_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, int arg4, int arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_float_IntPtr_Vector2i_int_Int64_bool (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, int arg4, long arg5, bool arg6);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_float_IntPtr_Vector2i_int_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, int arg4, long arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_float_IntPtr_Vector2i_Int64 (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, long arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_float_Vector2_nuint_nuint_int_bool_IntPtr (IntPtr receiver, IntPtr selector, float arg1, Vector2 arg2, nuint arg3, nuint arg4, int arg5, bool arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_float_Vector2_nuint_nuint_Int64_bool_IntPtr (IntPtr receiver, IntPtr selector, float arg1, Vector2 arg2, nuint arg3, nuint arg4, long arg5, bool arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_bool_IntPtr_Vector2i_nint_nuint_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, Vector2i arg4, nint arg5, nuint arg6, int arg7, bool arg8);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_bool_IntPtr_Vector2i_nint_nuint_Int64_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, Vector2i arg4, nint arg5, nuint arg6, long arg7, bool arg8);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_int_Vector2i_float_float_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, Vector2i arg3, float arg4, float arg5, float arg6, float arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_Int64_Vector2i_float_float_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, Vector2i arg3, float arg4, float arg5, float arg6, float arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_Vector2i (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, Vector2i arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_IntPtr_Vector2i (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, Vector2i arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_IntPtr_Vector2i_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, Vector2i arg3, float arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt32_Matrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, Matrix4 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt32_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, Vector2 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt32_Vector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, Vector3 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt32_Vector4 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, Vector4 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt64_Matrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, Matrix4 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt64_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, Vector2 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt64_Vector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, Vector3 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_UInt64_Vector4 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, Vector4 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, Vector2 arg2);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_IntPtr_Vector2_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, Vector2 arg2, Vector2 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Matrix4 (IntPtr receiver, IntPtr selector, Matrix4 arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector2 (IntPtr receiver, IntPtr selector, Vector2 arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector2_Vector2 (IntPtr receiver, IntPtr selector, Vector2 arg1, Vector2 arg2);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector2_Vector2_float (IntPtr receiver, IntPtr selector, Vector2 arg1, Vector2 arg2, float arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector2_Vector2i_int_IntPtr (IntPtr receiver, IntPtr selector, Vector2 arg1, Vector2i arg2, int arg3, IntPtr arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector2_Vector2i_Int64_IntPtr (IntPtr receiver, IntPtr selector, Vector2 arg1, Vector2i arg2, long arg3, IntPtr arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector2i (IntPtr receiver, IntPtr selector, Vector2i arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector2i_int_int_bool (IntPtr receiver, IntPtr selector, Vector2i arg1, int arg2, int arg3, bool arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector3_IntPtr (IntPtr receiver, IntPtr selector, Vector3 arg1, IntPtr arg2);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector3_nuint_nuint_int_bool_bool_IntPtr (IntPtr receiver, IntPtr selector, Vector3 arg1, nuint arg2, nuint arg3, int arg4, bool arg5, bool arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector3_nuint_nuint_Int64_bool_bool_IntPtr (IntPtr receiver, IntPtr selector, Vector3 arg1, nuint arg2, nuint arg3, long arg4, bool arg5, bool arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector3_Vector3i_int_bool_IntPtr (IntPtr receiver, IntPtr selector, Vector3 arg1, Vector3i arg2, int arg3, bool arg4, IntPtr arg5);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSend_Vector3_Vector3i_Int64_bool_IntPtr (IntPtr receiver, IntPtr selector, Vector3 arg1, Vector3i arg2, long arg3, bool arg4, IntPtr arg5);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_float_float_IntPtr_Vector2i (IntPtr receiver, IntPtr selector, float arg1, float arg2, IntPtr arg3, Vector2i arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_float_IntPtr_Vector2i_int (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, int arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_float_IntPtr_Vector2i_int_int_bool (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, int arg4, int arg5, bool arg6);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_float_IntPtr_Vector2i_int_int_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, int arg4, int arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_float_IntPtr_Vector2i_int_Int64_bool (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, int arg4, long arg5, bool arg6);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_float_IntPtr_Vector2i_int_Int64_IntPtr_IntPtr (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, int arg4, long arg5, IntPtr arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_float_IntPtr_Vector2i_Int64 (IntPtr receiver, IntPtr selector, float arg1, IntPtr arg2, Vector2i arg3, long arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_float_Vector2_nuint_nuint_int_bool_IntPtr (IntPtr receiver, IntPtr selector, float arg1, Vector2 arg2, nuint arg3, nuint arg4, int arg5, bool arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_float_Vector2_nuint_nuint_Int64_bool_IntPtr (IntPtr receiver, IntPtr selector, float arg1, Vector2 arg2, nuint arg3, nuint arg4, long arg5, bool arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr_Vector2i_nint_nuint_int_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, Vector2i arg4, nint arg5, nuint arg6, int arg7, bool arg8);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_bool_IntPtr_Vector2i_nint_nuint_Int64_bool (IntPtr receiver, IntPtr selector, IntPtr arg1, bool arg2, IntPtr arg3, Vector2i arg4, nint arg5, nuint arg6, long arg7, bool arg8);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_int_Vector2i_float_float_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, int arg2, Vector2i arg3, float arg4, float arg5, float arg6, float arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Int64_Vector2i_float_float_float_float (IntPtr receiver, IntPtr selector, IntPtr arg1, long arg2, Vector2i arg3, float arg4, float arg5, float arg6, float arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_Vector2i (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, IntPtr arg3, Vector2i arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Vector2i (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, Vector2i arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_IntPtr_Vector2i_float (IntPtr receiver, IntPtr selector, IntPtr arg1, IntPtr arg2, Vector2i arg3, float arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt32_Matrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, Matrix4 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt32_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, Vector2 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt32_Vector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, Vector3 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt32_Vector4 (IntPtr receiver, IntPtr selector, IntPtr arg1, uint arg2, Vector4 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt64_Matrix4 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, Matrix4 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt64_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, Vector2 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt64_Vector3 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, Vector3 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_UInt64_Vector4 (IntPtr receiver, IntPtr selector, IntPtr arg1, ulong arg2, Vector4 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, Vector2 arg2);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_IntPtr_Vector2_Vector2 (IntPtr receiver, IntPtr selector, IntPtr arg1, Vector2 arg2, Vector2 arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Matrix4 (IntPtr receiver, IntPtr selector, Matrix4 arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector2 (IntPtr receiver, IntPtr selector, Vector2 arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector2_Vector2 (IntPtr receiver, IntPtr selector, Vector2 arg1, Vector2 arg2);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector2_Vector2_float (IntPtr receiver, IntPtr selector, Vector2 arg1, Vector2 arg2, float arg3);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector2_Vector2i_int_IntPtr (IntPtr receiver, IntPtr selector, Vector2 arg1, Vector2i arg2, int arg3, IntPtr arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector2_Vector2i_Int64_IntPtr (IntPtr receiver, IntPtr selector, Vector2 arg1, Vector2i arg2, long arg3, IntPtr arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector2i (IntPtr receiver, IntPtr selector, Vector2i arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector2i_int_int_bool (IntPtr receiver, IntPtr selector, Vector2i arg1, int arg2, int arg3, bool arg4);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_IntPtr (IntPtr receiver, IntPtr selector, Vector3 arg1, IntPtr arg2);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_nuint_nuint_int_bool_bool_IntPtr (IntPtr receiver, IntPtr selector, Vector3 arg1, nuint arg2, nuint arg3, int arg4, bool arg5, bool arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_nuint_nuint_Int64_bool_bool_IntPtr (IntPtr receiver, IntPtr selector, Vector3 arg1, nuint arg2, nuint arg3, long arg4, bool arg5, bool arg6, IntPtr arg7);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_Vector3i_int_bool_IntPtr (IntPtr receiver, IntPtr selector, Vector3 arg1, Vector3i arg2, int arg3, bool arg4, IntPtr arg5);

		[DllImport ("__Internal")]
		public static extern IntPtr xamarin_simd__IntPtr_objc_msgSendSuper_Vector3_Vector3i_Int64_bool_IntPtr (IntPtr receiver, IntPtr selector, Vector3 arg1, Vector3i arg2, long arg3, bool arg4, IntPtr arg5);

		[DllImport ("__Internal")]
		public static extern Matrix4 xamarin_simd__Matrix4_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern Matrix4 xamarin_simd__Matrix4_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern Matrix4 xamarin_simd__Matrix4_objc_msgSend_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Matrix4_objc_msgSend_stret (out Matrix4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Matrix4_objc_msgSend_stret_Double (out Matrix4 retval, IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Matrix4_objc_msgSend_stret_IntPtr_Double (out Matrix4 retval, IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

		[DllImport ("__Internal")]
		public static extern Matrix4 xamarin_simd__Matrix4_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern Matrix4 xamarin_simd__Matrix4_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern Matrix4 xamarin_simd__Matrix4_objc_msgSendSuper_IntPtr_Double (IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Matrix4_objc_msgSendSuper_stret (out Matrix4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Matrix4_objc_msgSendSuper_stret_Double (out Matrix4 retval, IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Matrix4_objc_msgSendSuper_stret_IntPtr_Double (out Matrix4 retval, IntPtr receiver, IntPtr selector, IntPtr arg1, double arg2);

		[DllImport ("__Internal")]
		public static extern MDLAxisAlignedBoundingBox xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern MDLAxisAlignedBoundingBox xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_stret (out MDLAxisAlignedBoundingBox retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_stret_Double (out MDLAxisAlignedBoundingBox retval, IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_stret_Vector4i (out MDLAxisAlignedBoundingBox retval, IntPtr receiver, IntPtr selector, Vector4i arg1);

		[DllImport ("__Internal")]
		public static extern MDLAxisAlignedBoundingBox xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSend_Vector4i (IntPtr receiver, IntPtr selector, Vector4i arg1);

		[DllImport ("__Internal")]
		public static extern MDLAxisAlignedBoundingBox xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern MDLAxisAlignedBoundingBox xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret (out MDLAxisAlignedBoundingBox retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret_Double (out MDLAxisAlignedBoundingBox retval, IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_stret_Vector4i (out MDLAxisAlignedBoundingBox retval, IntPtr receiver, IntPtr selector, Vector4i arg1);

		[DllImport ("__Internal")]
		public static extern MDLAxisAlignedBoundingBox xamarin_simd__MDLAxisAlignedBoundingBox_objc_msgSendSuper_Vector4i (IntPtr receiver, IntPtr selector, Vector4i arg1);

		[DllImport ("__Internal")]
		public static extern Vector2 xamarin_simd__Vector2_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern Vector2 xamarin_simd__Vector2_objc_msgSend_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector2_objc_msgSend_stret (out Vector2 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector2_objc_msgSend_stret_nuint (out Vector2 retval, IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("__Internal")]
		public static extern Vector2 xamarin_simd__Vector2_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern Vector2 xamarin_simd__Vector2_objc_msgSendSuper_nuint (IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector2_objc_msgSendSuper_stret (out Vector2 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector2_objc_msgSendSuper_stret_nuint (out Vector2 retval, IntPtr receiver, IntPtr selector, nuint arg1);

		[DllImport ("__Internal")]
		public static extern Vector2i xamarin_simd__Vector2i_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector2i_objc_msgSend_stret (out Vector2i retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern Vector2i xamarin_simd__Vector2i_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector2i_objc_msgSendSuper_stret (out Vector2i retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern Vector3 xamarin_simd__Vector3_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern Vector3 xamarin_simd__Vector3_objc_msgSend_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector3_objc_msgSend_stret (out Vector3 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector3_objc_msgSend_stret_Double (out Vector3 retval, IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector3_objc_msgSend_stret_Vector2i_Vector2i (out Vector3 retval, IntPtr receiver, IntPtr selector, Vector2i arg1, Vector2i arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector3_objc_msgSend_stret_Vector3 (out Vector3 retval, IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector3_objc_msgSend_stret_Vector4i (out Vector3 retval, IntPtr receiver, IntPtr selector, Vector4i arg1);

		[DllImport ("__Internal")]
		public static extern Vector3 xamarin_simd__Vector3_objc_msgSend_Vector2i_Vector2i (IntPtr receiver, IntPtr selector, Vector2i arg1, Vector2i arg2);

		[DllImport ("__Internal")]
		public static extern Vector3 xamarin_simd__Vector3_objc_msgSend_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern Vector3 xamarin_simd__Vector3_objc_msgSend_Vector4i (IntPtr receiver, IntPtr selector, Vector4i arg1);

		[DllImport ("__Internal")]
		public static extern Vector3 xamarin_simd__Vector3_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern Vector3 xamarin_simd__Vector3_objc_msgSendSuper_Double (IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector3_objc_msgSendSuper_stret (out Vector3 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector3_objc_msgSendSuper_stret_Double (out Vector3 retval, IntPtr receiver, IntPtr selector, double arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector3_objc_msgSendSuper_stret_Vector2i_Vector2i (out Vector3 retval, IntPtr receiver, IntPtr selector, Vector2i arg1, Vector2i arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector3_objc_msgSendSuper_stret_Vector3 (out Vector3 retval, IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector3_objc_msgSendSuper_stret_Vector4i (out Vector3 retval, IntPtr receiver, IntPtr selector, Vector4i arg1);

		[DllImport ("__Internal")]
		public static extern Vector3 xamarin_simd__Vector3_objc_msgSendSuper_Vector2i_Vector2i (IntPtr receiver, IntPtr selector, Vector2i arg1, Vector2i arg2);

		[DllImport ("__Internal")]
		public static extern Vector3 xamarin_simd__Vector3_objc_msgSendSuper_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern Vector3 xamarin_simd__Vector3_objc_msgSendSuper_Vector4i (IntPtr receiver, IntPtr selector, Vector4i arg1);

		[DllImport ("__Internal")]
		public static extern Vector4 xamarin_simd__Vector4_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector4_objc_msgSend_stret (out Vector4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern Vector4 xamarin_simd__Vector4_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector4_objc_msgSendSuper_stret (out Vector4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector4i_objc_msgSend_stret_Vector3 (out Vector4i retval, IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern Vector4i xamarin_simd__Vector4i_objc_msgSend_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__Vector4i_objc_msgSendSuper_stret_Vector3 (out Vector4i retval, IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern Vector4i xamarin_simd__Vector4i_objc_msgSendSuper_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSend_Matrix4 (IntPtr receiver, IntPtr selector, Matrix4 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSend_Matrix4_Double (IntPtr receiver, IntPtr selector, Matrix4 arg1, double arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSend_MDLAxisAlignedBoundingBox_bool (IntPtr receiver, IntPtr selector, MDLAxisAlignedBoundingBox arg1, bool arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSend_Vector2 (IntPtr receiver, IntPtr selector, Vector2 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSend_Vector2i (IntPtr receiver, IntPtr selector, Vector2i arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSend_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSend_Vector3_Double (IntPtr receiver, IntPtr selector, Vector3 arg1, double arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSend_Vector3_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1, Vector3 arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSend_Vector4 (IntPtr receiver, IntPtr selector, Vector4 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSend_Vector4i (IntPtr receiver, IntPtr selector, Vector4i arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSendSuper_Matrix4 (IntPtr receiver, IntPtr selector, Matrix4 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSendSuper_Matrix4_Double (IntPtr receiver, IntPtr selector, Matrix4 arg1, double arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSendSuper_MDLAxisAlignedBoundingBox_bool (IntPtr receiver, IntPtr selector, MDLAxisAlignedBoundingBox arg1, bool arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSendSuper_Vector2 (IntPtr receiver, IntPtr selector, Vector2 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSendSuper_Vector2i (IntPtr receiver, IntPtr selector, Vector2i arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSendSuper_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSendSuper_Vector3_Double (IntPtr receiver, IntPtr selector, Vector3 arg1, double arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSendSuper_Vector3_Vector3 (IntPtr receiver, IntPtr selector, Vector3 arg1, Vector3 arg2);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSendSuper_Vector4 (IntPtr receiver, IntPtr selector, Vector4 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_simd__void_objc_msgSendSuper_Vector4i (IntPtr receiver, IntPtr selector, Vector4i arg1);

		[DllImport ("__Internal")]
		public static extern Vector4 xamarin_vector_float3__Vector4_objc_msgSend (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_vector_float3__Vector4_objc_msgSend_stret (out Vector4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern Vector4 xamarin_vector_float3__Vector4_objc_msgSendSuper (IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_vector_float3__Vector4_objc_msgSendSuper_stret (out Vector4 retval, IntPtr receiver, IntPtr selector);

		[DllImport ("__Internal")]
		public static extern void xamarin_vector_float3__void_objc_msgSend_Vector4 (IntPtr receiver, IntPtr selector, Vector4 arg1);

		[DllImport ("__Internal")]
		public static extern void xamarin_vector_float3__void_objc_msgSendSuper_Vector4 (IntPtr receiver, IntPtr selector, Vector4 arg1);
	}
}


