using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Branch : GimmickBase
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected override void OnCollisionEnterPlayer()
    {
        if(Player.player.branchPoint < Player.player.maxBranchPoint)
        {
            Player.player.branchPoint++;
            Destroy(this.gameObject);
        }
    }
}
