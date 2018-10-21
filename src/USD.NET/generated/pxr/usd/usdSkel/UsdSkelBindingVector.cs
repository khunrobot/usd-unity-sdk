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

public class UsdSkelBindingVector : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<UsdSkelBinding>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal UsdSkelBindingVector(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(UsdSkelBindingVector obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~UsdSkelBindingVector() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_UsdSkelBindingVector(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public UsdSkelBindingVector(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (UsdSkelBinding element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public UsdSkelBinding this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(UsdSkelBinding[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(UsdSkelBinding[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, UsdSkelBinding[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<UsdSkelBinding> global::System.Collections.Generic.IEnumerable<UsdSkelBinding>.GetEnumerator() {
    return new UsdSkelBindingVectorEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new UsdSkelBindingVectorEnumerator(this);
  }

  public UsdSkelBindingVectorEnumerator GetEnumerator() {
    return new UsdSkelBindingVectorEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class UsdSkelBindingVectorEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<UsdSkelBinding>
  {
    private UsdSkelBindingVector collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public UsdSkelBindingVectorEnumerator(UsdSkelBindingVector collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public UsdSkelBinding Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (UsdSkelBinding)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    UsdCsPINVOKE.UsdSkelBindingVector_Clear(swigCPtr);
  }

  public void Add(UsdSkelBinding x) {
    UsdCsPINVOKE.UsdSkelBindingVector_Add(swigCPtr, UsdSkelBinding.getCPtr(x));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = UsdCsPINVOKE.UsdSkelBindingVector_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = UsdCsPINVOKE.UsdSkelBindingVector_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    UsdCsPINVOKE.UsdSkelBindingVector_reserve(swigCPtr, n);
  }

  public UsdSkelBindingVector() : this(UsdCsPINVOKE.new_UsdSkelBindingVector__SWIG_0(), true) {
  }

  public UsdSkelBindingVector(UsdSkelBindingVector other) : this(UsdCsPINVOKE.new_UsdSkelBindingVector__SWIG_1(UsdSkelBindingVector.getCPtr(other)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdSkelBindingVector(int capacity) : this(UsdCsPINVOKE.new_UsdSkelBindingVector__SWIG_2(capacity), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  private UsdSkelBinding getitemcopy(int index) {
    UsdSkelBinding ret = new UsdSkelBinding(UsdCsPINVOKE.UsdSkelBindingVector_getitemcopy(swigCPtr, index), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private UsdSkelBinding getitem(int index) {
    UsdSkelBinding ret = new UsdSkelBinding(UsdCsPINVOKE.UsdSkelBindingVector_getitem(swigCPtr, index), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, UsdSkelBinding val) {
    UsdCsPINVOKE.UsdSkelBindingVector_setitem(swigCPtr, index, UsdSkelBinding.getCPtr(val));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(UsdSkelBindingVector values) {
    UsdCsPINVOKE.UsdSkelBindingVector_AddRange(swigCPtr, UsdSkelBindingVector.getCPtr(values));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public UsdSkelBindingVector GetRange(int index, int count) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.UsdSkelBindingVector_GetRange(swigCPtr, index, count);
    UsdSkelBindingVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new UsdSkelBindingVector(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, UsdSkelBinding x) {
    UsdCsPINVOKE.UsdSkelBindingVector_Insert(swigCPtr, index, UsdSkelBinding.getCPtr(x));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, UsdSkelBindingVector values) {
    UsdCsPINVOKE.UsdSkelBindingVector_InsertRange(swigCPtr, index, UsdSkelBindingVector.getCPtr(values));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    UsdCsPINVOKE.UsdSkelBindingVector_RemoveAt(swigCPtr, index);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    UsdCsPINVOKE.UsdSkelBindingVector_RemoveRange(swigCPtr, index, count);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public static UsdSkelBindingVector Repeat(UsdSkelBinding value, int count) {
    global::System.IntPtr cPtr = UsdCsPINVOKE.UsdSkelBindingVector_Repeat(UsdSkelBinding.getCPtr(value), count);
    UsdSkelBindingVector ret = (cPtr == global::System.IntPtr.Zero) ? null : new UsdSkelBindingVector(cPtr, true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    UsdCsPINVOKE.UsdSkelBindingVector_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    UsdCsPINVOKE.UsdSkelBindingVector_Reverse__SWIG_1(swigCPtr, index, count);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, UsdSkelBindingVector values) {
    UsdCsPINVOKE.UsdSkelBindingVector_SetRange(swigCPtr, index, UsdSkelBindingVector.getCPtr(values));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
