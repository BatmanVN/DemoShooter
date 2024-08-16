using UnityEngine;
using UnityEngine.Events;

public class Gate : MonoBehaviour
{
    public UnityEvent onPlayerEnter;
    private void OnTriggerEnter(Collider gate)
    {
        if(gate.CompareTag("Player"))
        {
            onPlayerEnter?.Invoke();
        }
    }
}