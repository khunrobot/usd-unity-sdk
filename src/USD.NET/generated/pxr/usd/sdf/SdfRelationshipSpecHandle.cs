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

public class SdfRelationshipSpecHandle : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal SdfRelationshipSpecHandle(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(SdfRelationshipSpecHandle obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~SdfRelationshipSpecHandle() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          UsdCsPINVOKE.delete_SdfRelationshipSpecHandle(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public SdfRelationshipSpecHandle() : this(UsdCsPINVOKE.new_SdfRelationshipSpecHandle__SWIG_0(), true) {
  }

  public SdfRelationshipSpecHandle(SdfRelationshipSpec spec) : this(UsdCsPINVOKE.new_SdfRelationshipSpecHandle__SWIG_1(SdfRelationshipSpec.getCPtr(spec)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfRelationshipSpecHandle(SdfRelationshipSpecHandle handle) : this(UsdCsPINVOKE.new_SdfRelationshipSpecHandle__SWIG_2(SdfRelationshipSpecHandle.getCPtr(handle)), true) {
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SdfRelationshipSpec __deref__() {
    global::System.IntPtr cPtr = UsdCsPINVOKE.SdfRelationshipSpecHandle___deref__(swigCPtr);
    SdfRelationshipSpec ret = (cPtr == global::System.IntPtr.Zero) ? null : new SdfRelationshipSpec(cPtr, false);
    return ret;
  }

  public SdfRelationshipSpecHandle New(SdfPrimSpecHandle owner, string name, bool custom, SdfVariability variability) {
    SdfRelationshipSpecHandle ret = new SdfRelationshipSpecHandle(UsdCsPINVOKE.SdfRelationshipSpecHandle_New__SWIG_0(swigCPtr, SdfPrimSpecHandle.getCPtr(owner), name, custom, (int)variability), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfRelationshipSpecHandle New(SdfPrimSpecHandle owner, string name, bool custom) {
    SdfRelationshipSpecHandle ret = new SdfRelationshipSpecHandle(UsdCsPINVOKE.SdfRelationshipSpecHandle_New__SWIG_1(swigCPtr, SdfPrimSpecHandle.getCPtr(owner), name, custom), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfRelationshipSpecHandle New(SdfPrimSpecHandle owner, string name) {
    SdfRelationshipSpecHandle ret = new SdfRelationshipSpecHandle(UsdCsPINVOKE.SdfRelationshipSpecHandle_New__SWIG_2(swigCPtr, SdfPrimSpecHandle.getCPtr(owner), name), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_SdfTargetsProxy GetTargetPathList() {
    SWIGTYPE_p_SdfTargetsProxy ret = new SWIGTYPE_p_SdfTargetsProxy(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetTargetPathList(swigCPtr), true);
    return ret;
  }

  public bool HasTargetPathList() {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_HasTargetPathList(swigCPtr);
    return ret;
  }

  public void ClearTargetPathList() {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_ClearTargetPathList(swigCPtr);
  }

  public void ReplaceTargetPath(SdfPath oldPath, SdfPath newPath) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_ReplaceTargetPath(swigCPtr, SdfPath.getCPtr(oldPath), SdfPath.getCPtr(newPath));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveTargetPath(SdfPath path, bool preserveTargetOrder) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_RemoveTargetPath__SWIG_0(swigCPtr, SdfPath.getCPtr(path), preserveTargetOrder);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveTargetPath(SdfPath path) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_RemoveTargetPath__SWIG_1(swigCPtr, SdfPath.getCPtr(path));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetNoLoadHint() {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_GetNoLoadHint(swigCPtr);
    return ret;
  }

  public void SetNoLoadHint(bool noload) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetNoLoadHint(swigCPtr, noload);
  }

  public string GetName() {
    string ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_GetName(swigCPtr);
    return ret;
  }

  public TfToken GetNameToken() {
    TfToken ret = new TfToken(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetNameToken(swigCPtr), true);
    return ret;
  }

  public bool CanSetName(string newName, SWIGTYPE_p_std__string whyNot) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_CanSetName(swigCPtr, newName, SWIGTYPE_p_std__string.getCPtr(whyNot));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetName(string newName, bool validate) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_SetName__SWIG_0(swigCPtr, newName, validate);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetName(string newName) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_SetName__SWIG_1(swigCPtr, newName);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsValidName(string name) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_IsValidName(swigCPtr, name);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SdfSpecHandle GetOwner() {
    SdfSpecHandle ret = new SdfSpecHandle(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetOwner(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_SdfDictionaryProxy GetCustomData() {
    SWIGTYPE_p_SdfDictionaryProxy ret = new SWIGTYPE_p_SdfDictionaryProxy(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetCustomData(swigCPtr), true);
    return ret;
  }

  public SWIGTYPE_p_SdfDictionaryProxy GetAssetInfo() {
    SWIGTYPE_p_SdfDictionaryProxy ret = new SWIGTYPE_p_SdfDictionaryProxy(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetAssetInfo(swigCPtr), true);
    return ret;
  }

  public void SetCustomData(string name, VtValue value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetCustomData(swigCPtr, name, VtValue.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetAssetInfo(string name, VtValue value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetAssetInfo(swigCPtr, name, VtValue.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetDisplayGroup() {
    string ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_GetDisplayGroup(swigCPtr);
    return ret;
  }

  public void SetDisplayGroup(string value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetDisplayGroup(swigCPtr, value);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetDisplayName() {
    string ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_GetDisplayName(swigCPtr);
    return ret;
  }

  public void SetDisplayName(string value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetDisplayName(swigCPtr, value);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetDocumentation() {
    string ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_GetDocumentation(swigCPtr);
    return ret;
  }

  public void SetDocumentation(string value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetDocumentation(swigCPtr, value);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetHidden() {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_GetHidden(swigCPtr);
    return ret;
  }

  public void SetHidden(bool value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetHidden(swigCPtr, value);
  }

  public SdfPermission GetPermission() {
    SdfPermission ret = (SdfPermission)UsdCsPINVOKE.SdfRelationshipSpecHandle_GetPermission(swigCPtr);
    return ret;
  }

  public void SetPermission(SdfPermission value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetPermission(swigCPtr, (int)value);
  }

  public string GetPrefix() {
    string ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_GetPrefix(swigCPtr);
    return ret;
  }

  public void SetPrefix(string value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetPrefix(swigCPtr, value);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetSuffix() {
    string ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_GetSuffix(swigCPtr);
    return ret;
  }

  public void SetSuffix(string value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetSuffix(swigCPtr, value);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetSymmetricPeer() {
    string ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_GetSymmetricPeer(swigCPtr);
    return ret;
  }

  public void SetSymmetricPeer(string peerName) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetSymmetricPeer(swigCPtr, peerName);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_SdfDictionaryProxy GetSymmetryArguments() {
    SWIGTYPE_p_SdfDictionaryProxy ret = new SWIGTYPE_p_SdfDictionaryProxy(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetSymmetryArguments(swigCPtr), true);
    return ret;
  }

  public void SetSymmetryArgument(string name, VtValue value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetSymmetryArgument(swigCPtr, name, VtValue.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TfToken GetSymmetryFunction() {
    TfToken ret = new TfToken(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetSymmetryFunction(swigCPtr), true);
    return ret;
  }

  public void SetSymmetryFunction(TfToken functionName) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetSymmetryFunction(swigCPtr, TfToken.getCPtr(functionName));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t GetTimeSampleMap() {
    SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t ret = new SWIGTYPE_p_std__mapT_double_VtValue_std__lessT_double_t_t(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetTimeSampleMap(swigCPtr), true);
    return ret;
  }

  public TfType GetValueType() {
    TfType ret = new TfType(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetValueType(swigCPtr), true);
    return ret;
  }

  public SdfValueTypeName GetTypeName() {
    SdfValueTypeName ret = new SdfValueTypeName(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetTypeName(swigCPtr), true);
    return ret;
  }

  public VtValue GetDefaultValue() {
    VtValue ret = new VtValue(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetDefaultValue(swigCPtr), true);
    return ret;
  }

  public bool SetDefaultValue(VtValue defaultValue) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_SetDefaultValue(swigCPtr, VtValue.getCPtr(defaultValue));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool HasDefaultValue() {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_HasDefaultValue(swigCPtr);
    return ret;
  }

  public void ClearDefaultValue() {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_ClearDefaultValue(swigCPtr);
  }

  public string GetComment() {
    string ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_GetComment(swigCPtr);
    return ret;
  }

  public void SetComment(string value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetComment(swigCPtr, value);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool IsCustom() {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_IsCustom(swigCPtr);
    return ret;
  }

  public void SetCustom(bool custom) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetCustom(swigCPtr, custom);
  }

  public SdfVariability GetVariability() {
    SdfVariability ret = (SdfVariability)UsdCsPINVOKE.SdfRelationshipSpecHandle_GetVariability(swigCPtr);
    return ret;
  }

  public bool HasOnlyRequiredFields() {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_HasOnlyRequiredFields(swigCPtr);
    return ret;
  }

  public SWIGTYPE_p_SdfSchemaBase GetSchema() {
    SWIGTYPE_p_SdfSchemaBase ret = new SWIGTYPE_p_SdfSchemaBase(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetSchema(swigCPtr), false);
    return ret;
  }

  public SdfSpecType GetSpecType() {
    SdfSpecType ret = (SdfSpecType)UsdCsPINVOKE.SdfRelationshipSpecHandle_GetSpecType(swigCPtr);
    return ret;
  }

  public bool IsDormant() {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_IsDormant(swigCPtr);
    return ret;
  }

  public SdfLayerHandle GetLayer() {
    SdfLayerHandle ret = new SdfLayerHandle(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetLayer(swigCPtr), true);
    return ret;
  }

  public SdfPath GetPath() {
    SdfPath ret = new SdfPath(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetPath(swigCPtr), true);
    return ret;
  }

  public bool PermissionToEdit() {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_PermissionToEdit(swigCPtr);
    return ret;
  }

  public TfTokenVector ListInfoKeys() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.SdfRelationshipSpecHandle_ListInfoKeys(swigCPtr), true);
    return ret;
  }

  public TfTokenVector GetMetaDataInfoKeys() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetMetaDataInfoKeys(swigCPtr), true);
    return ret;
  }

  public TfToken GetMetaDataDisplayGroup(TfToken key) {
    TfToken ret = new TfToken(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetMetaDataDisplayGroup(swigCPtr, TfToken.getCPtr(key)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VtValue GetInfo(TfToken key) {
    VtValue ret = new VtValue(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetInfo(swigCPtr, TfToken.getCPtr(key)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetInfo(TfToken key, VtValue value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetInfo(swigCPtr, TfToken.getCPtr(key), VtValue.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetInfoDictionaryValue(TfToken dictionaryKey, TfToken entryKey, VtValue value) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_SetInfoDictionaryValue(swigCPtr, TfToken.getCPtr(dictionaryKey), TfToken.getCPtr(entryKey), VtValue.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool HasInfo(TfToken key) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_HasInfo(swigCPtr, TfToken.getCPtr(key));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void ClearInfo(TfToken key) {
    UsdCsPINVOKE.SdfRelationshipSpecHandle_ClearInfo(swigCPtr, TfToken.getCPtr(key));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
  }

  public TfType GetTypeForInfo(TfToken key) {
    TfType ret = new TfType(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetTypeForInfo(swigCPtr, TfToken.getCPtr(key)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VtValue GetFallbackForInfo(TfToken key) {
    VtValue ret = new VtValue(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetFallbackForInfo(swigCPtr, TfToken.getCPtr(key)), false);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool WriteToStream(SWIGTYPE_p_std__ostream arg0, uint indent) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_WriteToStream__SWIG_0(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(arg0), indent);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool WriteToStream(SWIGTYPE_p_std__ostream arg0) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_WriteToStream__SWIG_1(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(arg0));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsInert(bool ignoreChildren) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_IsInert__SWIG_0(swigCPtr, ignoreChildren);
    return ret;
  }

  public bool IsInert() {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_IsInert__SWIG_1(swigCPtr);
    return ret;
  }

  public TfTokenVector ListFields() {
    TfTokenVector ret = new TfTokenVector(UsdCsPINVOKE.SdfRelationshipSpecHandle_ListFields(swigCPtr), true);
    return ret;
  }

  public bool HasField(TfToken name) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_HasField(swigCPtr, TfToken.getCPtr(name));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public VtValue GetField(TfToken name) {
    VtValue ret = new VtValue(UsdCsPINVOKE.SdfRelationshipSpecHandle_GetField(swigCPtr, TfToken.getCPtr(name)), true);
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool SetField(TfToken name, VtValue value) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_SetField(swigCPtr, TfToken.getCPtr(name), VtValue.getCPtr(value));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool ClearField(TfToken name) {
    bool ret = UsdCsPINVOKE.SdfRelationshipSpecHandle_ClearField(swigCPtr, TfToken.getCPtr(name));
    if (UsdCsPINVOKE.SWIGPendingException.Pending) throw UsdCsPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}
