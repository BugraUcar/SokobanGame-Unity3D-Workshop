using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementController : MonoBehaviour
{
    public bool isRightEmpty;
    public bool isLeftEmpty;
    public bool isUpEmpty;
    public bool isDownEmpty;

    public RaycastHit rightHit;
    public RaycastHit leftHit;
    public RaycastHit upHit;
    public RaycastHit downHit;

    private bool canMove;
    private Vector3 targetPos;
    private Vector3 startPos;
    private float moveTimerCounter;
    private float moveTimerDuration;
    private void Start()
    {
        CheckAround();
    }
    private void Update()
    {
        if (canMove)
        {
            Movement();
        }
    }
    public void SetMove(Vector3 direction, float moveTime)
    {
        canMove = true;
        startPos = transform.position;
        moveTimerDuration = moveTime;
        targetPos = transform.position + direction;
    }
    public void Movement()
    {
        if (moveTimerCounter < moveTimerDuration)
        {
            transform.position = Vector3.Lerp(startPos, targetPos, moveTimerCounter / moveTimerDuration);
            moveTimerCounter += Time.deltaTime;
        }
        else
        {
            transform.position = targetPos;
            moveTimerCounter = 0;
            canMove = false;
            CheckAround();
        }
    }
    public void CheckAround()
    {
        //if (Physics.Raycast(transform.position, transform.forward,1))
        //{
        //    isUpEmpty = false;
        //}
        //else
        //{
        //    isUpEmpty = true;
        //}

        isUpEmpty = !Physics.Raycast(transform.position, Vector3.forward, out upHit, 1);
        isDownEmpty = !Physics.Raycast(transform.position, Vector3.back, out downHit, 1);
        isLeftEmpty = !Physics.Raycast(transform.position, Vector3.left, out leftHit, 1);
        isRightEmpty = !Physics.Raycast(transform.position, Vector3.right, out rightHit, 1);
    }
}
