/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.39
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class SipUri : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SipUri(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(SipUri obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~SipUri() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if(swigCPtr.Handle != IntPtr.Zero && swigCMemOwn) {
        swigCMemOwn = false;
        tinyWRAPPINVOKE.delete_SipUri(swigCPtr);
      }
      swigCPtr = new HandleRef(null, IntPtr.Zero);
      GC.SuppressFinalize(this);
    }
  }

  public SipUri(string arg0) : this(tinyWRAPPINVOKE.new_SipUri(arg0), true) {
  }

  public static bool isValid(string arg0) {
    bool ret = tinyWRAPPINVOKE.SipUri_isValid__SWIG_0(arg0);
    return ret;
  }

  public bool isValid() {
    bool ret = tinyWRAPPINVOKE.SipUri_isValid__SWIG_1(swigCPtr);
    return ret;
  }

  public string getScheme() {
    string ret = tinyWRAPPINVOKE.SipUri_getScheme(swigCPtr);
    return ret;
  }

  public string getHost() {
    string ret = tinyWRAPPINVOKE.SipUri_getHost(swigCPtr);
    return ret;
  }

  public ushort getPort() {
    ushort ret = tinyWRAPPINVOKE.SipUri_getPort(swigCPtr);
    return ret;
  }

  public string getUserName() {
    string ret = tinyWRAPPINVOKE.SipUri_getUserName(swigCPtr);
    return ret;
  }

  public string getPassword() {
    string ret = tinyWRAPPINVOKE.SipUri_getPassword(swigCPtr);
    return ret;
  }

  public string getDisplayName() {
    string ret = tinyWRAPPINVOKE.SipUri_getDisplayName(swigCPtr);
    return ret;
  }

  public string getParamValue(string pname) {
    string ret = tinyWRAPPINVOKE.SipUri_getParamValue(swigCPtr, pname);
    return ret;
  }

}

}
