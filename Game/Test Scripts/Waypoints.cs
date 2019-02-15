using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    public List<Waypoints> neighbors;

    public Waypoints previous
    {
        get;
        set;
    }

    public float distance
    {
        get;
        set;
    }

    void OnDrawGizmos()
    {
        if (neighbors == null)
            return;
        Gizmos.color = new Color(0f, 0f, 0f);
        foreach(var neighbor in neighbors)
        {
            if (neighbor != null)
                Gizmos.DrawLine(transform.position, neighbor.transform.position);
        }
    }
    private Waypoints FindClosestWaypoints(Vector3 target)
    {
        GameObject closest = null;
        float closestDist = Mathf.Infinity;
        foreach (var waypoint in GameObject.FindGameObjectsWithTag(("Waypoints"))
        {
            var dist = (Waypoints.transform.position - target).magnitude;
        }

        
    }
}
