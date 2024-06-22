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
        //���̓����蔻��͐U���Ă���Ƃ��̂�
        axe.isTrigger = !anim.GetCurrentAnimatorStateInfo(0).IsName("swing");

        //����U��
        if (Input.GetMouseButton(0))
        {
            anim.SetInteger("status_anim", 3);
            return;
        }

        //�ړ�
        if ((Input.GetAxis("Horizontal") != 0) || (Input.GetAxis("Vertical") != 0))
        {
            anim.SetInteger("status_anim", 1);

            //����
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetInteger("status_anim", 2);
            }
            return;
        }

        //�ҋ@���[�V����
        anim.SetInteger("status_anim", 0);
    }
}
