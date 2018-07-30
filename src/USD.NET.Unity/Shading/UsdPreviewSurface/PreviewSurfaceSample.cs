﻿// Copyright 2018 Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using UnityEngine;

namespace USD.NET.Unity {
  /// <summary>
  /// The following is based on the Pixar specification found here:
  /// https://graphics.pixar.com/usd/docs/UsdPreviewSurface-Proposal.html
  /// </summary>
  [System.Serializable]
  [UsdSchema("Shader")]
  public class PreviewSurfaceSample : ShaderSample {

    public PreviewSurfaceSample() {
      id = new pxr.TfToken("UsdPreviewSurface");
    }

    /// <summary>
    /// When using metallic workflow this is interpreted as albedo.
    /// </summary>
    [InputParameter("_DiffuseColor")]
    public Connectable<Vector3> diffuseColor = new Connectable<Vector3>(new Vector3(0.18f, 0.18f, 0.18f));

    /// <summary>
    /// Emissive component. 
    /// </summary>
    [InputParameter("_EmissiveColor")]
    public Connectable<Vector3> emissiveColor = new Connectable<Vector3>(Vector3.zero);

    /// <summary>
    /// This node can fundamentally operate in two modes : Specular workflow where you provide a
    /// texture/value to the "specularColor" input. Or, Metallic workflow where you provide a
    /// texture/value to the "metallic" input.  Depending on the 0 or 1 value of this parameter, the
    /// following parameters are conditionally enabled.
    /// </summary>
    [InputParameter("_UseSpecularWorkflow")]
    public Connectable<int> useSpecularWorkflow = new Connectable<int>(0);

    /// <summary>
    /// Specular color to be used. This is the color at 0 incidence. Edge color is assumed white.
    /// Transition between the two colors according to Schlick fresnel approximation.
    /// </summary>
    [InputParameter("_SpecularColor")]
    public Connectable<Vector3> specularColor = new Connectable<Vector3>(Vector3.one);

    /// <summary>
    /// Use 1 for metallic surfaces and 0 for non-metallic.
    /// 
    ///  - If metallic is 1.0, then F0(reflectivity at 0 degree incidence) will be derived from
    ///    ior( (1-ior)/(1+ior) )^2, then multiplied by Albedo; while edge F90 reflectivity will
    ///    simply be the Albedo. (As an option, you can set ior to 0 such that F0 becomes equal to
    ///    F90 and thus the Albedo).
    ///    
    ///  - If metallic is 0.0, then Albedo is ignored; F0 is derived from ior and F90 is white.
    ///    In between, we interpolate.
    /// </summary>
    [InputParameter("_Metallic")]
    public Connectable<float> metallic = new Connectable<float>(1);

    /// <summary>
    /// Roughness for the specular lobe. The value ranges from 0 to 1, which goes from a perfectly
    /// specular surface at 0.0 to maximum roughness of the specular lobe. This value is usually
    /// squared before use with a GGX or Beckmann lobe.
    /// </summary>
    [InputParameter("_Roughness")]
    public Connectable<float> roughness = new Connectable<float>(0.01f);

    /// <summary>
    /// Second specular lobe amount. The color is white.
    /// </summary>
    [InputParameter("_Clearcoat")]
    public Connectable<float> clearcoat = new Connectable<float>(0);

    /// <summary>
    /// Roughness for the second specular lobe.
    /// </summary>
    [InputParameter("_ClearcoatRoughness")]
    public Connectable<float> clearcoatRoughness = new Connectable<float>(0.01f);

    /// <summary>
    /// When opacity is 1.0 then the prim is fully opaque, if it is smaller than 1.0 then the prim
    /// is translucent, when it is 0 the prim is transparent. 
    /// </summary>
    [InputParameter("_Opacity")]
    public Connectable<float> opacity = new Connectable<float>(1);

    /// <summary>
    /// Index of Refraction to be used for translucent objects.
    /// </summary>
    [InputParameter("_Ior")]
    public Connectable<float> ior = new Connectable<float>(1.5f);

    /// <summary>
    /// Expects normal in tangent space [(-1,-1,-1), (1,1,1)] This means your texture reader
    /// implementation should provide data to this node that is properly scaled and ready to be
    /// consumed as a tangent space normal.
    /// </summary>
    [InputParameter("_Normal")]
    public Connectable<Vector3> normal = new Connectable<Vector3>(new Vector3(0, 0, 1));

    /// <summary>
    /// Displacement in the direction of the normal.
    /// </summary>
    [InputParameter("_Displacement")]
    public Connectable<float> displacement = new Connectable<float>(0);

    /// <summary>
    /// Extra information about the occlusion of different parts of the mesh that this material is
    /// applied to. Occlusion only makes sense as a surface-varying signal, and pathtracers will
    /// likely choose to ignore it. An occlusion value of 0.0 means the surface point is fully
    /// occluded by other parts of the surface, and a value of 1.0 means the surface point is
    /// completely unoccluded by other parts of the surface.
    /// </summary>
    [InputParameter("_Occlusion")]
    public Connectable<float> occlusion = new Connectable<float>(1);

    /// <remarks>
    /// In UsdShade, by convention and limitation of Usd/SdfLayer's native representable types,
    /// 'token' is assigned as the SdfValueTypeName type to all inputs and outputs of "rich types"
    /// (e.g. structs), while allowing use of renderType metadata (a string) on UsdShadeInput and
    /// UsdShadeOutput to carry typeName information that may be useful to a renderer or shading
    /// system.
    /// </remarks>
    public class Outputs {
      public pxr.TfToken displacement;
      public pxr.TfToken surface;
    }

    [UsdNamespace("outputs")]
    public Outputs outputs = new Outputs();
  }

}
