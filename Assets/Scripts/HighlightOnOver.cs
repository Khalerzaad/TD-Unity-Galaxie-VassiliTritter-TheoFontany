using Unity.VisualScripting;
using UnityEngine;

public class HighlightOnOver : MonoBehaviour
{
    private TrailRenderer trail;

    //Initialisation : get trail in children and unactive it
        private void Awake()
    {
        trail = GetComponent<TrailRenderer>();
        if (trail != null)
        {
            trail.enabled = false;
        }
    }
    // Called when Mouse enters collider : active trail
    private void OnMouseEnter()
    {
        if (trail != null)
        {
            trail.enabled = true;
        }
    }

    // Called when Mouse exits collider : unactive trail
    private void OnMouseExit()
    {
        if (trail != null)
        {
            trail.Clear();
            trail.enabled = false;
        }
    }
}
