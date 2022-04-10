using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private MovementController mC;
    [SerializeField] float moveTime;
    private void Start()
    {
        mC = GetComponent<MovementController>();
        mC.CheckAround();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            if (mC.isUpEmpty)
            {
                mC.SetMove(Vector3.forward, moveTime);
            }
            else if (mC.upHit.collider.TryGetComponent(out MovementController cubeMc) && cubeMc.isUpEmpty)
            {
                mC.SetMove(Vector3.forward, moveTime);
                cubeMc.SetMove(Vector3.forward, moveTime);
            }
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (mC.isDownEmpty)
            {
                mC.SetMove(Vector3.back, moveTime);
            }
            else if (mC.downHit.collider.TryGetComponent(out MovementController cubeMc) && cubeMc.isDownEmpty)
            {
                mC.SetMove(Vector3.back, moveTime);
                cubeMc.SetMove(Vector3.back, moveTime);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            if (mC.isLeftEmpty)
            {
                mC.SetMove(Vector3.left, moveTime);
            }
            else if (mC.leftHit.collider.TryGetComponent(out MovementController cubeMc) && cubeMc.isLeftEmpty)
            {
                mC.SetMove(Vector3.left, moveTime);
                cubeMc.SetMove(Vector3.left, moveTime);
            }
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            if (mC.isRightEmpty)
            {
                mC.SetMove(Vector3.right, moveTime);
            }
            else if (mC.rightHit.collider.TryGetComponent(out MovementController cubeMc) && cubeMc.isRightEmpty)
            {
                mC.SetMove(Vector3.right, moveTime);
                cubeMc.SetMove(Vector3.right, moveTime);
            }
        }
    }
}
