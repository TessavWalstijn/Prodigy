using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualConnections : MonoBehaviour
{
    
    [SerializeField]
    private Color _open;

    [SerializeField]
    private Color _closed;

    private Waypoints _waypoints;
    private Material[] _matirials = new Material[10];

    // Start is called before the first frame update
    void Start()
    {
        _waypoints = GetComponent<Waypoints>();
        GameObject[] waypoints = _waypoints.waypoints;

        int maxWaypoints = waypoints.Length;
        for (int i = 0; i < maxWaypoints; i += 1) {
            GameObject point = waypoints[i];
            Renderer render = point.GetComponent<Renderer>();
            _matirials[i] = render.GetComponent<Material>();
        }

        ShowAvailbleConnections(0);
    }

    public void ShowAvailbleConnections (int waypoint)
    {
        int[] connections = _waypoints.GetAvailbleConnections(waypoint);

        int maxWaypoints = _matirials.Length;
        for (int i = 0; i < maxWaypoints; i += 1) {
            _matirials[i].color = _closed;
        }

        int maxConnections = connections.Length;
        for (int i = 1; i < maxConnections; i += 1) {
            _matirials[i].color = _open;
        }
    }
}
