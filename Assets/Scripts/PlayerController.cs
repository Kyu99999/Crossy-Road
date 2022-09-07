using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    IDLE,
    JUMP,
}

public class PlayerController : MonoBehaviour
{
    public PlayerState currentState;
    public Animator animator;
    public float jumpTime;

    public Vector3 movePos;

    public float time;
    // Start is called before the first frame update
    void Start()
    {
        currentState = PlayerState.IDLE;
        movePos = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        StateUpdate();
    }
    public void StateUpdate()
    {
        switch (currentState)
        {
            case PlayerState.IDLE:
                if (Input.anyKeyDown)
                {
                    var v = Input.GetAxisRaw("Vertical");
                    var h = Input.GetAxisRaw("Horizontal");
                    Vector3 pos = new Vector3(h, 0, v);
                    animator.SetTrigger("Jump");
                    transform.LookAt(transform.position + pos);

                    movePos = transform.position + pos;
                    
                    ChangeState(PlayerState.JUMP);
                }
                break;
            case PlayerState.JUMP:
                time += Time.deltaTime;
                transform.position = Vector3.Lerp(transform.position, movePos, time / jumpTime);
                if (transform.position == movePos)
                {
                    ChangeState(PlayerState.IDLE);
                }
                break;
            default:
                break;
        }
    }

    public void ChangeState(PlayerState State)
    {
        currentState = State;
        StateInit();
    }

    public void StateInit()
    {
        switch (currentState)
        {
            case PlayerState.IDLE:
                break;
            case PlayerState.JUMP:
                time = 0;
                break;
            default:
                break;
        }
    }

}


