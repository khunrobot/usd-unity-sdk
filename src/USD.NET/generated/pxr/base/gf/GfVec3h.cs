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

public class GfVec3h : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GfVec3h(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GfVec3h obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GfVec3h() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_GfVec3h(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GfVec3h() : this(UsdCsPINVOKE.new_GfVec3h__SWIG_0(), true) {
  }

  public GfVec3h(GfHalf value) : this(UsdCsPINVOKE.new_GfVec3h__SWIG_1(GfHalf.getCPtr(value)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec3h(GfHalf s0, GfHalf s1, GfHalf s2) : this(UsdCsPINVOKE.new_GfVec3h__SWIG_2(GfHalf.getCPtr(s0), GfHalf.getCPtr(s1), GfHalf.getCPtr(s2)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec3h(GfVec3d other) : this(UsdCsPINVOKE.new_GfVec3h__SWIG_4(GfVec3d.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec3h(GfVec3f other) : this(UsdCsPINVOKE.new_GfVec3h__SWIG_5(GfVec3f.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public GfVec3h(GfVec3i other) : this(UsdCsPINVOKE.new_GfVec3h__SWIG_6(GfVec3i.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static GfVec3h XAxis() {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.GfVec3h_XAxis(), true);
    return ret;
  }

  public static GfVec3h YAxis() {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.GfVec3h_YAxis(), true);
    return ret;
  }

  public static GfVec3h ZAxis() {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.GfVec3h_ZAxis(), true);
    return ret;
  }

  public static GfVec3h Axis(uint i) {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.GfVec3h_Axis(i), true);
    return ret;
  }

  public GfVec3h Set(GfHalf s0, GfHalf s1, GfHalf s2) {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.GfVec3h_Set__SWIG_0(swigCPtr, GfHalf.getCPtr(s0), GfHalf.getCPtr(s1), GfHalf.getCPtr(s2)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3h Set(GfHalf a) {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.GfVec3h_Set__SWIG_1(swigCPtr, GfHalf.getCPtr(a)), false);
    return ret;
  }

  public GfVec3h GetProjection(GfVec3h v) {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.GfVec3h_GetProjection(swigCPtr, GfVec3h.getCPtr(v)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3h GetComplement(GfVec3h b) {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.GfVec3h_GetComplement(swigCPtr, GfVec3h.getCPtr(b)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfHalf GetLengthSq() {
    GfHalf ret = new GfHalf(UsdCsPINVOKE.GfVec3h_GetLengthSq(swigCPtr), true);
    return ret;
  }

  public GfHalf GetLength() {
    GfHalf ret = new GfHalf(UsdCsPINVOKE.GfVec3h_GetLength(swigCPtr), true);
    return ret;
  }

  public GfHalf Normalize(GfHalf eps) {
    GfHalf ret = new GfHalf(UsdCsPINVOKE.GfVec3h_Normalize__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfHalf Normalize() {
    GfHalf ret = new GfHalf(UsdCsPINVOKE.GfVec3h_Normalize__SWIG_1(swigCPtr), true);
    return ret;
  }

  public GfVec3h GetNormalized(GfHalf eps) {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.GfVec3h_GetNormalized__SWIG_0(swigCPtr, GfHalf.getCPtr(eps)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public GfVec3h GetNormalized() {
    GfVec3h ret = new GfVec3h(UsdCsPINVOKE.GfVec3h_GetNormalized__SWIG_1(swigCPtr), true);
    return ret;
  }

  public static bool OrthogonalizeBasis(GfVec3h tx, GfVec3h ty, GfVec3h tz, bool normalize, double eps) {
    bool ret = UsdCsPINVOKE.GfVec3h_OrthogonalizeBasis__SWIG_0(GfVec3h.getCPtr(tx), GfVec3h.getCPtr(ty), GfVec3h.getCPtr(tz), normalize, eps);
    return ret;
  }

  public static bool OrthogonalizeBasis(GfVec3h tx, GfVec3h ty, GfVec3h tz, bool normalize) {
    bool ret = UsdCsPINVOKE.GfVec3h_OrthogonalizeBasis__SWIG_1(GfVec3h.getCPtr(tx), GfVec3h.getCPtr(ty), GfVec3h.getCPtr(tz), normalize);
    return ret;
  }

  public void BuildOrthonormalFrame(GfVec3h v1, GfVec3h v2, GfHalf eps) {
    UsdCsPINVOKE.GfVec3h_BuildOrthonormalFrame__SWIG_0(swigCPtr, GfVec3h.getCPtr(v1), GfVec3h.getCPtr(v2), GfHalf.getCPtr(eps));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void BuildOrthonormalFrame(GfVec3h v1, GfVec3h v2) {
    UsdCsPINVOKE.GfVec3h_BuildOrthonormalFrame__SWIG_1(swigCPtr, GfVec3h.getCPtr(v1), GfVec3h.getCPtr(v2));
  }

  public static bool Equals(GfVec3h lhs, GfVec3h rhs) {
    bool ret = UsdCsPINVOKE.GfVec3h_Equals(GfVec3h.getCPtr(lhs), GfVec3h.getCPtr(rhs));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  override public int GetHashCode() {
    int ret = UsdCsPINVOKE.GfVec3h_GetHashCode(swigCPtr);
    return ret;
  }

    public static bool operator==(GfVec3h lhs, GfVec3h rhs){
      // The Swig binding glue will re-enter this operator comparing to null, so 
      // that case must be handled explicitly to avoid an infinite loop. This is still
      // not great, since it crosses the C#/C++ barrier twice. A better approache might
      // be to return a simple value from C++ that can be compared in C#.
      bool lnull = lhs as object == null;
      bool rnull = rhs as object == null;
      return (lnull == rnull) && ((lnull && rnull) || GfVec3h.Equals(lhs, rhs));
    }

    public static bool operator !=(GfVec3h lhs, GfVec3h rhs) {
        return !(lhs == rhs);
    }

    override public bool Equals(object rhs) {
      return GfVec3h.Equals(this, rhs as GfVec3h);
    }
  
  protected float GetValue(int index) {
    float ret = UsdCsPINVOKE.GfVec3h_GetValue(swigCPtr, index);
    return ret;
  }

  protected void SetValue(int index, float value) {
    UsdCsPINVOKE.GfVec3h_SetValue(swigCPtr, index, value);
  }

  public float this[int index] {
    get { return GetValue(index); }
    set { SetValue(index, value); }
  }
  
  public static readonly uint dimension = UsdCsPINVOKE.GfVec3h_dimension_get();
}

}
