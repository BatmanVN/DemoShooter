using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEffectManager : Singleton<HitEffectManager>
{
    public HitEffectMapper[] effectMap;
    public GameObject GetEffectPrefab(HitSurfaceType surfaceType)
    {
        HitEffectMapper mapper = System.Array.Find(effectMap,
            effect => effect.surface == surfaceType);
        return mapper?.effectPrefab;
    }
}
