using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    [SerializeField] private float speed_walk = 4.0f;
    [SerializeField] private float speed_run = 7.0f;
    private float speed;
    private Vector3 old_pos;

    

    // Start is called before the first frame update
    void Start()
    {
        old_pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //�X�C���O���Ȃ瓮���Ȃ�
        if (GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("swing"))
        {
            return;
        }

        //�ړ����x�X�V
        speed = speed_walk;

        //���鑬�x
        if (Input.GetKey(KeyCode.LeftShift)) 
        {
            speed = speed_run;
        }

        //�O��ړ�
        transform.position += new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical")) * speed * Time.deltaTime;

        Vector3 delta = transform.position - old_pos;

        old_pos = transform.position;

        if (delta == Vector3.zero)
            return;

        transform.rotation = Quaternion.LookRotation(delta, Vector3.up);
    }
}
