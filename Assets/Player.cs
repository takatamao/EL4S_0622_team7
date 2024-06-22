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
        Application.targetFrameRate = 60;
        player = this;
    }
}
