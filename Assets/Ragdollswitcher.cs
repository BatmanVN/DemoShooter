using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdollswitcher : MonoBehaviour
{
    public Animator zomAnim;
    public Rigidbody[] rigbd;

    [ContextMenu("Retrive Rigibodies")]
    private void RetriveRigibodies()
    {
        rigbd = GetComponentsInChildren<Rigidbody>();
    }

    [ContextMenu("Clear RagDoll")]
    private void ClearRagDoll()
    {
        var characterJoint = GetComponentsInChildren<CharacterJoint>();
        for(int i = characterJoint.Length - 1; i >= 0 ; i--)
        {
            DestroyImmediate(characterJoint[i]);
        }
        var rigidList = GetComponentsInChildren<Rigidbody>();
        for(int i = rigidList.Length-1; i >= 0; i--)
        {
            DestroyImmediate(rigidList[i]);
        }
        var colls = GetComponentsInChildren<Collider>();
        for(int i = colls.Length-1; i>=0; i--)
        {
            DestroyImmediate(colls[i]);
        }
    }
    [ContextMenu("Enable RagDoll")]
    public void EnableRagDoll() => SetRagDoll(true);
    [ContextMenu("Disable RagDoll")]
    public void DisableRagDoll() => SetRagDoll(false);
    private void SetRagDoll(bool ragdollEnable)
    {
        zomAnim.enabled = !ragdollEnable;
        for (int i = 0; i< rigbd.Length; i++)
        {
            rigbd[i].isKinematic = !ragdollEnable;
        }
    }
    [ContextMenu("Add HitSurface")]
    private void AddHitSurface()
    {
        var colliders = GetComponentsInChildren<Collider>();
        foreach(var collider in colliders)
        {
            if (collider.GetComponent<HitSurface>() == null)
            {
                var hitSurface = collider.gameObject.AddComponent<HitSurface>();
                hitSurface.surfaceType = HitSurfaceType.Blood;
            }
        }
    }
}
