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
        //斧の当たり判定は振っているときのみ
        axe.enabled = anim.GetCurrentAnimatorStateInfo(0).IsName("swing");

        //斧を振る
        if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("Button_A"))
        {
            anim.SetInteger("status_anim", 3);

            //音
            //SoundManager.instance.PlaySE(0);
            return;
        }

        //移動
        if ((Input.GetAxis("Horizontal") != 0) || (Input.GetAxis("Vertical") != 0))
        {
            anim.SetInteger("status_anim", 1);

            //走る
            if (Input.GetKey(KeyCode.LeftShift))
            {
                anim.SetInteger("status_anim", 2);
            }
            return;
        }

        //待機モーション
        anim.SetInteger("status_anim", 0);
    }
}
