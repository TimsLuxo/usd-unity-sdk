//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace pxr {

public class PcpPropertyIndex : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal PcpPropertyIndex(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(PcpPropertyIndex obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~PcpPropertyIndex() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_PcpPropertyIndex(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public PcpPropertyIndex() : this(UsdCsPINVOKE.new_PcpPropertyIndex__SWIG_0(), true) {
  }

  public PcpPropertyIndex(PcpPropertyIndex rhs) : this(UsdCsPINVOKE.new_PcpPropertyIndex__SWIG_1(PcpPropertyIndex.getCPtr(rhs)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void Swap(PcpPropertyIndex index) {
    UsdCsPINVOKE.PcpPropertyIndex_Swap(swigCPtr, PcpPropertyIndex.getCPtr(index));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsEmpty() {
    bool ret = UsdCsPINVOKE.PcpPropertyIndex_IsEmpty(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_PcpPropertyRange GetPropertyRange(bool localOnly) {
    SWIGTYPE_p_PcpPropertyRange ret = new SWIGTYPE_p_PcpPropertyRange(UsdCsPINVOKE.PcpPropertyIndex_GetPropertyRange__SWIG_0(swigCPtr, localOnly), true);
    return ret;
  }

  public SWIGTYPE_p_PcpPropertyRange GetPropertyRange() {
    SWIGTYPE_p_PcpPropertyRange ret = new SWIGTYPE_p_PcpPropertyRange(UsdCsPINVOKE.PcpPropertyIndex_GetPropertyRange__SWIG_1(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_PcpErrorVector GetLocalErrors() {
    SWIGTYPE_p_PcpErrorVector ret = new SWIGTYPE_p_PcpErrorVector(UsdCsPINVOKE.PcpPropertyIndex_GetLocalErrors(swigCPtr), true);
    return ret;
  }

  public uint GetNumLocalSpecs() {
    uint ret = UsdCsPINVOKE.PcpPropertyIndex_GetNumLocalSpecs(swigCPtr);
    return ret;
  }

}

}