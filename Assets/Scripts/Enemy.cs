using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2f;
    private Waypoint _current;
    public Waypoint startWaypoint;
    void Start()
    {
        _current = startWaypoint;

    }

    // Update is called once per frame
    void Update()
    {
        if (_current == null) return;

        transform.position = Vector3.MoveTowards(
            transform.position, _current.transform.position,speed* Time.deltaTime);
        if (Vector3.Distance(transform.position ,_current.transform.position)<0.1f)
        {
            _current = _current.next;
        }
    }
 }
