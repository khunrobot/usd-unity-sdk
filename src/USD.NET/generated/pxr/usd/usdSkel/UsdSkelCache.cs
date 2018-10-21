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

public class UsdSkelCache : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdSkelCache(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelCache obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSkelCache() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdSkelCache(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdSkelCache() : this(UsdCsPINVOKE.new_UsdSkelCache(), true) {
  }

  public void Clear() {
    UsdCsPINVOKE.UsdSkelCache_Clear(swigCPtr);
  }

  public bool Populate(UsdSkelRoot root) {
    bool ret = UsdCsPINVOKE.UsdSkelCache_Populate(swigCPtr, UsdSkelRoot.getCPtr(root));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdSkelSkeletonQuery GetSkelQuery(UsdSkelSkeleton skel) {
    UsdSkelSkeletonQuery ret = new UsdSkelSkeletonQuery(UsdCsPINVOKE.UsdSkelCache_GetSkelQuery(swigCPtr, UsdSkelSkeleton.getCPtr(skel)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdSkelAnimQuery GetAnimQuery(UsdPrim prim) {
    UsdSkelAnimQuery ret = new UsdSkelAnimQuery(UsdCsPINVOKE.UsdSkelCache_GetAnimQuery(swigCPtr, UsdPrim.getCPtr(prim)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public UsdSkelSkinningQuery GetSkinningQuery(UsdPrim prim) {
    UsdSkelSkinningQuery ret = new UsdSkelSkinningQuery(UsdCsPINVOKE.UsdSkelCache_GetSkinningQuery(swigCPtr, UsdPrim.getCPtr(prim)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeSkelBindings(UsdSkelRoot skelRoot, UsdSkelBindingVector bindings) {
    bool ret = UsdCsPINVOKE.UsdSkelCache_ComputeSkelBindings(swigCPtr, UsdSkelRoot.getCPtr(skelRoot), UsdSkelBindingVector.getCPtr(bindings));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ComputeSkelBinding(UsdSkelRoot skelRoot, UsdSkelSkeleton skel, UsdSkelBinding binding) {
    bool ret = UsdCsPINVOKE.UsdSkelCache_ComputeSkelBinding(swigCPtr, UsdSkelRoot.getCPtr(skelRoot), UsdSkelSkeleton.getCPtr(skel), UsdSkelBinding.getCPtr(binding));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
