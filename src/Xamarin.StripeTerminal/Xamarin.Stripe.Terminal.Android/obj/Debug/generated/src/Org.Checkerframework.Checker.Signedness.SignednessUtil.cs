using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Org.Checkerframework.Checker.Signedness {

	// Metadata.xml XPath class reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']"
	[global::Android.Runtime.Register ("org/checkerframework/checker/signedness/SignednessUtil", DoNotGenerateAcw=true)]
	public sealed partial class SignednessUtil : global::Java.Lang.Object {

		static readonly JniPeerMembers _members = new XAPeerMembers ("org/checkerframework/checker/signedness/SignednessUtil", typeof (SignednessUtil));
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

		internal SignednessUtil (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='byteFromDouble' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("byteFromDouble", "(D)B", "")]
		public static unsafe sbyte ByteFromDouble (double d)
		{
			const string __id = "byteFromDouble.(D)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (d);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='byteFromFloat' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("byteFromFloat", "(F)B", "")]
		public static unsafe sbyte ByteFromFloat (float f)
		{
			const string __id = "byteFromFloat.(F)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (f);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='compareUnsigned' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='byte']]"
		[Register ("compareUnsigned", "(BB)I", "")]
		public static unsafe int CompareUnsigned (sbyte x, sbyte y)
		{
			const string __id = "compareUnsigned.(BB)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='compareUnsigned' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("compareUnsigned", "(II)I", "")]
		public static unsafe int CompareUnsigned (int x, int y)
		{
			const string __id = "compareUnsigned.(II)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='compareUnsigned' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='long']]"
		[Register ("compareUnsigned", "(JJ)I", "")]
		public static unsafe int CompareUnsigned (long x, long y)
		{
			const string __id = "compareUnsigned.(JJ)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='compareUnsigned' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='short']]"
		[Register ("compareUnsigned", "(SS)I", "")]
		public static unsafe int CompareUnsigned (short x, short y)
		{
			const string __id = "compareUnsigned.(SS)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (x);
				__args [1] = new JniArgumentValue (y);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='getUnsigned' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getUnsigned", "(Ljava/nio/ByteBuffer;)B", "")]
		public static unsafe sbyte GetUnsigned (global::Java.Nio.ByteBuffer b)
		{
			const string __id = "getUnsigned.(Ljava/nio/ByteBuffer;)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='getUnsigned' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='byte[]']]"
		[Register ("getUnsigned", "(Ljava/nio/ByteBuffer;[B)V", "")]
		public static unsafe void GetUnsigned (global::Java.Nio.ByteBuffer b, byte[] bs)
		{
			const string __id = "getUnsigned.(Ljava/nio/ByteBuffer;[B)V";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (native_bs);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='getUnsigned' and count(parameter)=4 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("getUnsigned", "(Ljava/nio/ByteBuffer;[BII)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer GetUnsigned (global::Java.Nio.ByteBuffer b, byte[] bs, int i, int l)
		{
			const string __id = "getUnsigned.(Ljava/nio/ByteBuffer;[BII)Ljava/nio/ByteBuffer;";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (native_bs);
				__args [2] = new JniArgumentValue (i);
				__args [3] = new JniArgumentValue (l);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='getUnsigned' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("getUnsigned", "(Ljava/nio/ByteBuffer;I)B", "")]
		public static unsafe sbyte GetUnsigned (global::Java.Nio.ByteBuffer b, int i)
		{
			const string __id = "getUnsigned.(Ljava/nio/ByteBuffer;I)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='getUnsigned' and count(parameter)=2 and parameter[1][@type='java.nio.IntBuffer'] and parameter[2][@type='int']]"
		[Register ("getUnsigned", "(Ljava/nio/IntBuffer;I)I", "")]
		public static unsafe int GetUnsigned (global::Java.Nio.IntBuffer b, int i)
		{
			const string __id = "getUnsigned.(Ljava/nio/IntBuffer;I)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='getUnsignedInt' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getUnsignedInt", "(Ljava/nio/ByteBuffer;)I", "")]
		public static unsafe int GetUnsignedInt (global::Java.Nio.ByteBuffer b)
		{
			const string __id = "getUnsignedInt.(Ljava/nio/ByteBuffer;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='getUnsignedShort' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getUnsignedShort", "(Ljava/nio/ByteBuffer;)S", "")]
		public static unsafe short GetUnsignedShort (global::Java.Nio.ByteBuffer b)
		{
			const string __id = "getUnsignedShort.(Ljava/nio/ByteBuffer;)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='intFromDouble' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("intFromDouble", "(D)I", "")]
		public static unsafe int IntFromDouble (double d)
		{
			const string __id = "intFromDouble.(D)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (d);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='intFromFloat' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("intFromFloat", "(F)I", "")]
		public static unsafe int IntFromFloat (float f)
		{
			const string __id = "intFromFloat.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (f);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='longFromDouble' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("longFromDouble", "(D)J", "")]
		public static unsafe long LongFromDouble (double d)
		{
			const string __id = "longFromDouble.(D)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (d);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='longFromFloat' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("longFromFloat", "(F)J", "")]
		public static unsafe long LongFromFloat (float f)
		{
			const string __id = "longFromFloat.(F)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (f);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsigned' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='byte']]"
		[Register ("putUnsigned", "(Ljava/nio/ByteBuffer;B)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer PutUnsigned (global::Java.Nio.ByteBuffer b, sbyte ubyte)
		{
			const string __id = "putUnsigned.(Ljava/nio/ByteBuffer;B)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (ubyte);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsigned' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='byte']]"
		[Register ("putUnsigned", "(Ljava/nio/ByteBuffer;IB)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer PutUnsigned (global::Java.Nio.ByteBuffer b, int i, sbyte ubyte)
		{
			const string __id = "putUnsigned.(Ljava/nio/ByteBuffer;IB)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (i);
				__args [2] = new JniArgumentValue (ubyte);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsigned' and count(parameter)=2 and parameter[1][@type='java.nio.IntBuffer'] and parameter[2][@type='int']]"
		[Register ("putUnsigned", "(Ljava/nio/IntBuffer;I)Ljava/nio/IntBuffer;", "")]
		public static unsafe global::Java.Nio.IntBuffer PutUnsigned (global::Java.Nio.IntBuffer b, int @uint)
		{
			const string __id = "putUnsigned.(Ljava/nio/IntBuffer;I)Ljava/nio/IntBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (@uint);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsigned' and count(parameter)=3 and parameter[1][@type='java.nio.IntBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("putUnsigned", "(Ljava/nio/IntBuffer;II)Ljava/nio/IntBuffer;", "")]
		public static unsafe global::Java.Nio.IntBuffer PutUnsigned (global::Java.Nio.IntBuffer b, int i, int @uint)
		{
			const string __id = "putUnsigned.(Ljava/nio/IntBuffer;II)Ljava/nio/IntBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (i);
				__args [2] = new JniArgumentValue (@uint);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsigned' and count(parameter)=2 and parameter[1][@type='java.nio.IntBuffer'] and parameter[2][@type='int[]']]"
		[Register ("putUnsigned", "(Ljava/nio/IntBuffer;[I)Ljava/nio/IntBuffer;", "")]
		public static unsafe global::Java.Nio.IntBuffer PutUnsigned (global::Java.Nio.IntBuffer b, int[] uints)
		{
			const string __id = "putUnsigned.(Ljava/nio/IntBuffer;[I)Ljava/nio/IntBuffer;";
			IntPtr native_uints = JNIEnv.NewArray (uints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (native_uints);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (uints != null) {
					JNIEnv.CopyArray (native_uints, uints);
					JNIEnv.DeleteLocalRef (native_uints);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsigned' and count(parameter)=4 and parameter[1][@type='java.nio.IntBuffer'] and parameter[2][@type='int[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("putUnsigned", "(Ljava/nio/IntBuffer;[III)Ljava/nio/IntBuffer;", "")]
		public static unsafe global::Java.Nio.IntBuffer PutUnsigned (global::Java.Nio.IntBuffer b, int[] uints, int i, int l)
		{
			const string __id = "putUnsigned.(Ljava/nio/IntBuffer;[III)Ljava/nio/IntBuffer;";
			IntPtr native_uints = JNIEnv.NewArray (uints);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (native_uints);
				__args [2] = new JniArgumentValue (i);
				__args [3] = new JniArgumentValue (l);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.IntBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (uints != null) {
					JNIEnv.CopyArray (native_uints, uints);
					JNIEnv.DeleteLocalRef (native_uints);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsignedInt' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int']]"
		[Register ("putUnsignedInt", "(Ljava/nio/ByteBuffer;I)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer PutUnsignedInt (global::Java.Nio.ByteBuffer b, int @uint)
		{
			const string __id = "putUnsignedInt.(Ljava/nio/ByteBuffer;I)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (@uint);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsignedInt' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("putUnsignedInt", "(Ljava/nio/ByteBuffer;II)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer PutUnsignedInt (global::Java.Nio.ByteBuffer b, int i, int @uint)
		{
			const string __id = "putUnsignedInt.(Ljava/nio/ByteBuffer;II)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (i);
				__args [2] = new JniArgumentValue (@uint);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsignedLong' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='long']]"
		[Register ("putUnsignedLong", "(Ljava/nio/ByteBuffer;IJ)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer PutUnsignedLong (global::Java.Nio.ByteBuffer b, int i, long @ulong)
		{
			const string __id = "putUnsignedLong.(Ljava/nio/ByteBuffer;IJ)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (i);
				__args [2] = new JniArgumentValue (@ulong);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsignedShort' and count(parameter)=3 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='int'] and parameter[3][@type='short']]"
		[Register ("putUnsignedShort", "(Ljava/nio/ByteBuffer;IS)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer PutUnsignedShort (global::Java.Nio.ByteBuffer b, int i, short @ushort)
		{
			const string __id = "putUnsignedShort.(Ljava/nio/ByteBuffer;IS)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (i);
				__args [2] = new JniArgumentValue (@ushort);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='putUnsignedShort' and count(parameter)=2 and parameter[1][@type='java.nio.ByteBuffer'] and parameter[2][@type='short']]"
		[Register ("putUnsignedShort", "(Ljava/nio/ByteBuffer;S)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer PutUnsignedShort (global::Java.Nio.ByteBuffer b, short @ushort)
		{
			const string __id = "putUnsignedShort.(Ljava/nio/ByteBuffer;S)Ljava/nio/ByteBuffer;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((b == null) ? IntPtr.Zero : ((global::Java.Lang.Object) b).Handle);
				__args [1] = new JniArgumentValue (@ushort);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='readFullyUnsigned' and count(parameter)=2 and parameter[1][@type='java.io.RandomAccessFile'] and parameter[2][@type='byte[]']]"
		[Register ("readFullyUnsigned", "(Ljava/io/RandomAccessFile;[B)V", "")]
		public static unsafe void ReadFullyUnsigned (global::Java.IO.RandomAccessFile f, byte[] b)
		{
			const string __id = "readFullyUnsigned.(Ljava/io/RandomAccessFile;[B)V";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (native_b);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='readUnsigned' and count(parameter)=4 and parameter[1][@type='java.io.RandomAccessFile'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("readUnsigned", "(Ljava/io/RandomAccessFile;[BII)I", "")]
		public static unsafe int ReadUnsigned (global::Java.IO.RandomAccessFile f, byte[] b, int off, int len)
		{
			const string __id = "readUnsigned.(Ljava/io/RandomAccessFile;[BII)I";
			IntPtr native_b = JNIEnv.NewArray (b);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (native_b);
				__args [2] = new JniArgumentValue (off);
				__args [3] = new JniArgumentValue (len);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (b != null) {
					JNIEnv.CopyArray (native_b, b);
					JNIEnv.DeleteLocalRef (native_b);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='readUnsignedByte' and count(parameter)=1 and parameter[1][@type='java.io.RandomAccessFile']]"
		[Register ("readUnsignedByte", "(Ljava/io/RandomAccessFile;)B", "")]
		public static unsafe sbyte ReadUnsignedByte (global::Java.IO.RandomAccessFile f)
		{
			const string __id = "readUnsignedByte.(Ljava/io/RandomAccessFile;)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='readUnsignedChar' and count(parameter)=1 and parameter[1][@type='java.io.RandomAccessFile']]"
		[Register ("readUnsignedChar", "(Ljava/io/RandomAccessFile;)C", "")]
		public static unsafe char ReadUnsignedChar (global::Java.IO.RandomAccessFile f)
		{
			const string __id = "readUnsignedChar.(Ljava/io/RandomAccessFile;)C";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.StaticMethods.InvokeCharMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='readUnsignedInt' and count(parameter)=1 and parameter[1][@type='java.io.RandomAccessFile']]"
		[Register ("readUnsignedInt", "(Ljava/io/RandomAccessFile;)I", "")]
		public static unsafe int ReadUnsignedInt (global::Java.IO.RandomAccessFile f)
		{
			const string __id = "readUnsignedInt.(Ljava/io/RandomAccessFile;)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='readUnsignedLong' and count(parameter)=1 and parameter[1][@type='java.io.RandomAccessFile']]"
		[Register ("readUnsignedLong", "(Ljava/io/RandomAccessFile;)J", "")]
		public static unsafe long ReadUnsignedLong (global::Java.IO.RandomAccessFile f)
		{
			const string __id = "readUnsignedLong.(Ljava/io/RandomAccessFile;)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='readUnsignedShort' and count(parameter)=1 and parameter[1][@type='java.io.RandomAccessFile']]"
		[Register ("readUnsignedShort", "(Ljava/io/RandomAccessFile;)S", "")]
		public static unsafe short ReadUnsignedShort (global::Java.IO.RandomAccessFile f)
		{
			const string __id = "readUnsignedShort.(Ljava/io/RandomAccessFile;)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='shortFromDouble' and count(parameter)=1 and parameter[1][@type='double']]"
		[Register ("shortFromDouble", "(D)S", "")]
		public static unsafe short ShortFromDouble (double d)
		{
			const string __id = "shortFromDouble.(D)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (d);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='shortFromFloat' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("shortFromFloat", "(F)S", "")]
		public static unsafe short ShortFromFloat (float f)
		{
			const string __id = "shortFromFloat.(F)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (f);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toDouble' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toDouble", "(B)D", "")]
		public static unsafe double ToDouble (sbyte b)
		{
			const string __id = "toDouble.(B)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toDouble' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toDouble", "(I)D", "")]
		public static unsafe double ToDouble (int i)
		{
			const string __id = "toDouble.(I)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toDouble' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("toDouble", "(J)D", "")]
		public static unsafe double ToDouble (long l)
		{
			const string __id = "toDouble.(J)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (l);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toDouble' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("toDouble", "(S)D", "")]
		public static unsafe double ToDouble (short s)
		{
			const string __id = "toDouble.(S)D";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				var __rm = _members.StaticMethods.InvokeDoubleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toFloat' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toFloat", "(B)F", "")]
		public static unsafe float ToFloat (sbyte b)
		{
			const string __id = "toFloat.(B)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toFloat' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toFloat", "(I)F", "")]
		public static unsafe float ToFloat (int i)
		{
			const string __id = "toFloat.(I)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toFloat' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("toFloat", "(J)F", "")]
		public static unsafe float ToFloat (long l)
		{
			const string __id = "toFloat.(J)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (l);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toFloat' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("toFloat", "(S)F", "")]
		public static unsafe float ToFloat (short s)
		{
			const string __id = "toFloat.(S)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedInt' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toUnsignedInt", "(B)I", "")]
		public static unsafe int ToUnsignedInt (sbyte b)
		{
			const string __id = "toUnsignedInt.(B)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedInt' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("toUnsignedInt", "(C)I", "")]
		public static unsafe int ToUnsignedInt (char c)
		{
			const string __id = "toUnsignedInt.(C)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedInt' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("toUnsignedInt", "(S)I", "")]
		public static unsafe int ToUnsignedInt (short s)
		{
			const string __id = "toUnsignedInt.(S)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedLong' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toUnsignedLong", "(B)J", "")]
		public static unsafe long ToUnsignedLong (sbyte b)
		{
			const string __id = "toUnsignedLong.(B)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedLong' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("toUnsignedLong", "(C)J", "")]
		public static unsafe long ToUnsignedLong (char c)
		{
			const string __id = "toUnsignedLong.(C)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedLong' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toUnsignedLong", "(I)J", "")]
		public static unsafe long ToUnsignedLong (int i)
		{
			const string __id = "toUnsignedLong.(I)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedLong' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("toUnsignedLong", "(S)J", "")]
		public static unsafe long ToUnsignedLong (short s)
		{
			const string __id = "toUnsignedLong.(S)J";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				var __rm = _members.StaticMethods.InvokeInt64Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedShort' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toUnsignedShort", "(B)S", "")]
		public static unsafe short ToUnsignedShort (sbyte b)
		{
			const string __id = "toUnsignedShort.(B)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedShort' and count(parameter)=1 and parameter[1][@type='char']]"
		[Register ("toUnsignedShort", "(C)S", "")]
		public static unsafe short ToUnsignedShort (char c)
		{
			const string __id = "toUnsignedShort.(C)S";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (c);
				var __rm = _members.StaticMethods.InvokeInt16Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedString' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("toUnsignedString", "(B)Ljava/lang/String;", "")]
		public static unsafe string ToUnsignedString (sbyte b)
		{
			const string __id = "toUnsignedString.(B)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (b);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedString' and count(parameter)=2 and parameter[1][@type='byte'] and parameter[2][@type='int']]"
		[Register ("toUnsignedString", "(BI)Ljava/lang/String;", "")]
		public static unsafe string ToUnsignedString (sbyte b, int radix)
		{
			const string __id = "toUnsignedString.(BI)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (b);
				__args [1] = new JniArgumentValue (radix);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedString' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("toUnsignedString", "(I)Ljava/lang/String;", "")]
		public static unsafe string ToUnsignedString (int i)
		{
			const string __id = "toUnsignedString.(I)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (i);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedString' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register ("toUnsignedString", "(II)Ljava/lang/String;", "")]
		public static unsafe string ToUnsignedString (int i, int radix)
		{
			const string __id = "toUnsignedString.(II)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (i);
				__args [1] = new JniArgumentValue (radix);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedString' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("toUnsignedString", "(J)Ljava/lang/String;", "")]
		public static unsafe string ToUnsignedString (long l)
		{
			const string __id = "toUnsignedString.(J)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (l);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedString' and count(parameter)=2 and parameter[1][@type='long'] and parameter[2][@type='int']]"
		[Register ("toUnsignedString", "(JI)Ljava/lang/String;", "")]
		public static unsafe string ToUnsignedString (long l, int radix)
		{
			const string __id = "toUnsignedString.(JI)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (l);
				__args [1] = new JniArgumentValue (radix);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedString' and count(parameter)=1 and parameter[1][@type='short']]"
		[Register ("toUnsignedString", "(S)Ljava/lang/String;", "")]
		public static unsafe string ToUnsignedString (short s)
		{
			const string __id = "toUnsignedString.(S)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (s);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='toUnsignedString' and count(parameter)=2 and parameter[1][@type='short'] and parameter[2][@type='int']]"
		[Register ("toUnsignedString", "(SI)Ljava/lang/String;", "")]
		public static unsafe string ToUnsignedString (short s, int radix)
		{
			const string __id = "toUnsignedString.(SI)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (s);
				__args [1] = new JniArgumentValue (radix);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='wrapUnsigned' and count(parameter)=1 and parameter[1][@type='byte[]']]"
		[Register ("wrapUnsigned", "([B)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer WrapUnsigned (byte[] array)
		{
			const string __id = "wrapUnsigned.([B)Ljava/nio/ByteBuffer;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='wrapUnsigned' and count(parameter)=3 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
		[Register ("wrapUnsigned", "([BII)Ljava/nio/ByteBuffer;", "")]
		public static unsafe global::Java.Nio.ByteBuffer WrapUnsigned (byte[] array, int offset, int length)
		{
			const string __id = "wrapUnsigned.([BII)Ljava/nio/ByteBuffer;";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue (native_array);
				__args [1] = new JniArgumentValue (offset);
				__args [2] = new JniArgumentValue (length);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Java.Nio.ByteBuffer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='writeUnsigned' and count(parameter)=4 and parameter[1][@type='java.io.RandomAccessFile'] and parameter[2][@type='byte[]'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("writeUnsigned", "(Ljava/io/RandomAccessFile;[BII)V", "")]
		public static unsafe void WriteUnsigned (global::Java.IO.RandomAccessFile f, byte[] bs, int off, int len)
		{
			const string __id = "writeUnsigned.(Ljava/io/RandomAccessFile;[BII)V";
			IntPtr native_bs = JNIEnv.NewArray (bs);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (native_bs);
				__args [2] = new JniArgumentValue (off);
				__args [3] = new JniArgumentValue (len);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
				if (bs != null) {
					JNIEnv.CopyArray (native_bs, bs);
					JNIEnv.DeleteLocalRef (native_bs);
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='writeUnsignedByte' and count(parameter)=2 and parameter[1][@type='java.io.RandomAccessFile'] and parameter[2][@type='byte']]"
		[Register ("writeUnsignedByte", "(Ljava/io/RandomAccessFile;B)V", "")]
		public static unsafe void WriteUnsignedByte (global::Java.IO.RandomAccessFile f, sbyte b)
		{
			const string __id = "writeUnsignedByte.(Ljava/io/RandomAccessFile;B)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (b);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='writeUnsignedChar' and count(parameter)=2 and parameter[1][@type='java.io.RandomAccessFile'] and parameter[2][@type='char']]"
		[Register ("writeUnsignedChar", "(Ljava/io/RandomAccessFile;C)V", "")]
		public static unsafe void WriteUnsignedChar (global::Java.IO.RandomAccessFile f, char c)
		{
			const string __id = "writeUnsignedChar.(Ljava/io/RandomAccessFile;C)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (c);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='writeUnsignedInt' and count(parameter)=2 and parameter[1][@type='java.io.RandomAccessFile'] and parameter[2][@type='int']]"
		[Register ("writeUnsignedInt", "(Ljava/io/RandomAccessFile;I)V", "")]
		public static unsafe void WriteUnsignedInt (global::Java.IO.RandomAccessFile f, int i)
		{
			const string __id = "writeUnsignedInt.(Ljava/io/RandomAccessFile;I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (i);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='writeUnsignedLong' and count(parameter)=2 and parameter[1][@type='java.io.RandomAccessFile'] and parameter[2][@type='long']]"
		[Register ("writeUnsignedLong", "(Ljava/io/RandomAccessFile;J)V", "")]
		public static unsafe void WriteUnsignedLong (global::Java.IO.RandomAccessFile f, long l)
		{
			const string __id = "writeUnsignedLong.(Ljava/io/RandomAccessFile;J)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (l);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='org.checkerframework.checker.signedness']/class[@name='SignednessUtil']/method[@name='writeUnsignedShort' and count(parameter)=2 and parameter[1][@type='java.io.RandomAccessFile'] and parameter[2][@type='short']]"
		[Register ("writeUnsignedShort", "(Ljava/io/RandomAccessFile;S)V", "")]
		public static unsafe void WriteUnsignedShort (global::Java.IO.RandomAccessFile f, short s)
		{
			const string __id = "writeUnsignedShort.(Ljava/io/RandomAccessFile;S)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((f == null) ? IntPtr.Zero : ((global::Java.Lang.Object) f).Handle);
				__args [1] = new JniArgumentValue (s);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

	}
}
