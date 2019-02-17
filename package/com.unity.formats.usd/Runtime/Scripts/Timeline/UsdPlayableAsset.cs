﻿// Copyright 2018 Jeremy Cowles. All rights reserved.
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
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace USD.NET.Unity {

  [System.Serializable]
  public class UsdPlayableAsset : PlayableAsset {
    private UsdAsset m_sourceUsdAsset;

    [Tooltip("USD Player to Control")]
    public ExposedReference<UsdAsset> SourceUsdAsset;
    public string UsdRootPath;

    public ClipCaps clipCaps { get { return ClipCaps.Extrapolation | ClipCaps.Looping | ClipCaps.SpeedMultiplier | ClipCaps.ClipIn; } }

    public UsdAsset GetUsdAsset() {
      m_sourceUsdAsset.m_usdRootPath = UsdRootPath;
      return m_sourceUsdAsset;
    }

    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner) {
      var usdPlayable = ScriptPlayable<UsdPlayableBehaviour>.Create(graph);
      UsdPlayableBehaviour behaviour = usdPlayable.GetBehaviour();
      m_sourceUsdAsset = SourceUsdAsset.Resolve(graph.GetResolver());

      if (m_sourceUsdAsset != null) {
        behaviour.playableAsset = this;
        UsdRootPath = m_sourceUsdAsset.m_usdRootPath;
        name = System.IO.Path.GetFileName(m_sourceUsdAsset.usdFullPath);
      }

      return usdPlayable;
    }

    public override double duration {
      get {
        double dur = 0;
        try {
          dur = m_sourceUsdAsset == null ? 0 : m_sourceUsdAsset.Length;
        } catch (System.Exception ex) {
          Debug.LogException(new System.Exception("Failed to read clip duration", ex));
        }
        return dur;
      }
    }

  }
}