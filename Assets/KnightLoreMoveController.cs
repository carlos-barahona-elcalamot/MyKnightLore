using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KnightLoreMoveController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void OnMove(InputValue value)
    {
        Vector2 moveDirection = value.Get<Vector2>();
        if (Mathf.Abs(moveDirection.x) > Mathf.Abs(moveDirection.y)) {
            if (moveDirection.x > 0) {
                GetComponent<Animator>().SetTrigger("KeyUp");
            } else if (moveDirection.x < 0) {
                GetComponent<Animator>().SetTrigger("KeyDown");
            }
        } else {
            if (moveDirection.y > 0) {
                GetComponent<Animator>().SetTrigger("KeyRight");
            } else if (moveDirection.y < 0) {
                GetComponent<Animator>().SetTrigger("KeyLeft");
            }

        }
    }
}
