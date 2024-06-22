using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rb;
    public float moveValue = 10.0f;
    public int branchPoint;
    public int maxBranchPoint = 5;

    public static Player player;

    private void Awake()
    {
        player = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) _rb.velocity = Vector3.forward * moveValue;
        if (Input.GetKey(KeyCode.A)) _rb.velocity = Vector3.left * moveValue;
        if (Input.GetKey(KeyCode.S)) _rb.velocity = Vector3.back * moveValue;
        if (Input.GetKey(KeyCode.D)) _rb.velocity = Vector3.right * moveValue;
    }
}
