using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_anim : MonoBehaviour
{
    [SerializeField] private BoxCollider axe;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        axe.isTrigger = anim.GetCurrentAnimatorStateInfo(0).IsName("swing");

        if (Input.GetMouseButton(0))
        {
            anim.SetInteger("status_anim", 3);
            return;
        }

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetInteger("status_anim", 1);
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetInteger("status_anim", 2);
            }
            return;
        }

        anim.SetInteger("status_anim", 0);
    }
}
