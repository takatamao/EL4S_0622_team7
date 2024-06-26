using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    [SerializeField] private float speed_walk = 4.0f;
   // [SerializeField] private float speed_run = 7.0f;
    private float speed;
    private Vector3 old_pos;
    private bool istouch = false;

    // Start is called before the first frame update
    void Start()
    {
        old_pos = transform.position;
        speed = speed_walk;
    }

    // Update is called once per frame
    void Update()
    {
        //スイング中なら動かない
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("swing"))
        {
            return;
        }

        
        ////走る速度
        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    speed = speed_run;
        //}

        //前後移動
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")).normalized * speed * Time.deltaTime;

        Vector3 delta = transform.position - old_pos;

        old_pos = transform.position;

        if (delta == Vector3.zero || istouch)
            return;

        transform.rotation = Quaternion.LookRotation(delta, Vector3.up);
    }

    //private void OnCollisionEnter(Collision coll)
    //{
    //    istouch = true;
    //}

    //private void OnCollisionExit(Collision coll)
    //{
    //    istouch = false;
    //}
}
