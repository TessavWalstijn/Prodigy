using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _waypoints = new GameObject[10];
    public GameObject[] waypoints { get { return _waypoints; } }

    private int[][] _connections = new int[10][];

    void Start()
    {
        // ~~ ALLOWED CONNECTIONS:
        // ~~ Array format: [A, B, ...[B]]
        // ~~ A = Playerslocation
        // ~~ B = Allowed movement
        _connections[0] = new int[] { 0, 1, 2 };
        _connections[1] = new int[] { 1, 0, 3 };
        _connections[2] = new int[] { 2, 0, 4 };
        _connections[3] = new int[] { 3, 1, 5, 6 };
        _connections[4] = new int[] { 4, 2, 5, 7 };
        _connections[5] = new int[] { 5, 3, 4, 8 };
        _connections[6] = new int[] { 6, 3, 8 };
        _connections[7] = new int[] { 7, 4, 8 };
        _connections[8] = new int[] { 8, 5, 6, 7, 9 };
        _connections[9] = new int[] { 9 };
    }

    public int[] GetAvailbleConnections(int waypoint)
    {
        int max = _connections.Length;
        for (int i = 0; i < max; i += 1)
        {
            int[] currentConnections = _connections[i];
            if (waypoint == currentConnections[0])
            {
                return currentConnections;
            }
        }
        return new int[] { waypoint };
    }
}