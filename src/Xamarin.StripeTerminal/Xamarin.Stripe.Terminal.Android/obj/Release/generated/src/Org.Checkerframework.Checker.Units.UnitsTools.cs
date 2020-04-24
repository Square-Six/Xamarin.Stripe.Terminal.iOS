using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Checker.Units {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']"
	[global::Android.Runtime.Register ("org/checkerframework/checker/units/UnitsTools", DoNotGenerateAcw=true)]
	public partial class UnitsTools : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='A']"
		[Register ("A")]
		public const int A = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='C']"
		[Register ("C")]
		public const int C = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='K']"
		[Register ("K")]
		public const int K = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='cd']"
		[Register ("cd")]
		public const int Cd = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='deg']"
		[Register ("deg")]
		public const double Deg = (double) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='g']"
		[Register ("g")]
		public const int G = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='h']"
		[Register ("h")]
		public const int H = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='kg']"
		[Register ("kg")]
		public const int Kg = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='km']"
		[Register ("km")]
		public const int Km = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='km2']"
		[Register ("km2")]
		public const int Km2 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='kmPERh']"
		[Register ("kmPERh")]
		public const int KmPERh = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='m']"
		[Register ("m")]
		public const int M = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='m2']"
		[Register ("m2")]
		public const int M2 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='mPERs']"
		[Register ("mPERs")]
		public const int MPERs = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='mPERs2']"
		[Register ("mPERs2")]
		public const int MPERs2 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='min']"
		[Register ("min")]
		public const int Min = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='mm']"
		[Register ("mm")]
		public const int Mm = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='mm2']"
		[Register ("mm2")]
		public const int Mm2 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='mol']"
		[Register ("mol")]
		public const int Mol = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='rad']"
		[Register ("rad")]
		public const double Rad = (double) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/field[@name='s']"
		[Register ("s")]
		public const int S = (int) 1;
		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/units/UnitsTools", typeof (UnitsTools));
		internal static new IntPtr class_ref {
			get {
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected UnitsTools (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/constructor[@name='UnitsTools' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UnitsTools ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromCelsiusToKelvin' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromCelsiusToKelvin", "(I)I", "")]
		public static unsafe int FromCelsiusToKelvin (int c)
		{
			const string __id = "fromCelsiusToKelvin.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromGramToKiloGram' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromGramToKiloGram", "(I)I", "")]
		public static unsafe int FromGramToKiloGram (int g)
		{
			const string __id = "fromGramToKiloGram.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (g);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromHourToMinute' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromHourToMinute", "(I)I", "")]
		public static unsafe int FromHourToMinute (int h)
		{
			const string __id = "fromHourToMinute.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (h);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromKelvinToCelsius' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromKelvinToCelsius", "(I)I", "")]
		public static unsafe int FromKelvinToCelsius (int k)
		{
			const string __id = "fromKelvinToCelsius.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (k);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromKiloGramToGram' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromKiloGramToGram", "(I)I", "")]
		public static unsafe int FromKiloGramToGram (int kg)
		{
			const string __id = "fromKiloGramToGram.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (kg);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromKiloMeterPerHourToMeterPerSecond' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("fromKiloMeterPerHourToMeterPerSecond", "(D)D", "")]
		public static unsafe double FromKiloMeterPerHourToMeterPerSecond (double kmph)
		{
			const string __id = "fromKiloMeterPerHourToMeterPerSecond.(D)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (kmph);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromKiloMeterToMeter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromKiloMeterToMeter", "(I)I", "")]
		public static unsafe int FromKiloMeterToMeter (int km)
		{
			const string __id = "fromKiloMeterToMeter.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (km);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromMeterPerSecondToKiloMeterPerHour' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("fromMeterPerSecondToKiloMeterPerHour", "(D)D", "")]
		public static unsafe double FromMeterPerSecondToKiloMeterPerHour (double mps)
		{
			const string __id = "fromMeterPerSecondToKiloMeterPerHour.(D)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mps);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromMeterToKiloMeter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromMeterToKiloMeter", "(I)I", "")]
		public static unsafe int FromMeterToKiloMeter (int m)
		{
			const string __id = "fromMeterToKiloMeter.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (m);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromMeterToMilliMeter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromMeterToMilliMeter", "(I)I", "")]
		public static unsafe int FromMeterToMilliMeter (int m)
		{
			const string __id = "fromMeterToMilliMeter.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (m);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromMilliMeterToMeter' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromMilliMeterToMeter", "(I)I", "")]
		public static unsafe int FromMilliMeterToMeter (int mm)
		{
			const string __id = "fromMilliMeterToMeter.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (mm);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromMinuteToHour' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromMinuteToHour", "(I)I", "")]
		public static unsafe int FromMinuteToHour (int min)
		{
			const string __id = "fromMinuteToHour.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (min);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromMinuteToSecond' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromMinuteToSecond", "(I)I", "")]
		public static unsafe int FromMinuteToSecond (int min)
		{
			const string __id = "fromMinuteToSecond.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (min);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='fromSecondToMinute' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("fromSecondToMinute", "(I)I", "")]
		public static unsafe int FromSecondToMinute (int s)
		{
			const string __id = "fromSecondToMinute.(I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='toDegrees' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("toDegrees", "(D)D", "")]
		public static unsafe double ToDegrees (double angrad)
		{
			const string __id = "toDegrees.(D)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (angrad);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.units']/class[@name='UnitsTools']/method[@name='toRadians' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("toRadians", "(D)D", "")]
		public static unsafe double ToRadians (double angdeg)
		{
			const string __id = "toRadians.(D)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (angdeg);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

	}
}
