using UnityEngine;

public class Bonfire : GimmickBase
{

    [SerializeField] private float _decreaseValue;
    [SerializeField] private Transform _fire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_fire.localScale.x >= 0)_fire.localScale -= new Vector3(_decreaseValue, _decreaseValue, _decreaseValue);
    }

    protected override void OnCollisionEnterPlayer()
    {
        _fire.localScale += new Vector3(Player.player.branchPoint, Player.player.branchPoint, Player.player.branchPoint);
        Player.player.branchPoint = 0;
    }
}
