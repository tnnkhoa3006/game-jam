// Dual Shift - customized edition by Trần Nguyễn Ngọc Khoa (Khoat0360).
// Licenses: see CODE LICENSE.md and THIRD_PARTY_NOTICES.md in the project root.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour
{
    public Transform[] waypoints;
    private Transform target;
    public float speed;
    public int destPoint;
    
    void Start()
    {
        target = waypoints[0];
    }

    void Update()
    {
        Vector2 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
        if (Vector2.Distance(transform.position, target.position) < 0.3f)
        {
            destPoint = (destPoint + 1) % waypoints.Length;
            target = waypoints[destPoint];
        }
    }
}
