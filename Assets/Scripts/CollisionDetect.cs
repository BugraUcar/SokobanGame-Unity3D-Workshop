using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetect : MonoBehaviour
{
    public float distance;
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position,transform.forward ,distance);
        if (hit.collider.tag != "Wall")
        {
            FindObjectOfType < PlayerController >= false;
        }
    }
}
