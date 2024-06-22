using OpenCover.Framework.Model;
using System.Collections;
using UnityEngine;

public class Bonfire : GimmickBase
{

    [SerializeField] private float _decreaseValue;
    [SerializeField] private Transform _fire;
    [SerializeField] private float _burstTime;
    [SerializeField] private float _maxSize = 5.0f;
    private float _nowTime;
    private Vector3 _startScale = Vector3.zero;
    private Vector3 _endScale = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        _nowTime = _burstTime + 1.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (_nowTime<=_burstTime)
        {
            Vector3 size = Vector3.Lerp(_startScale, _endScale,_nowTime/_burstTime);
            if (size.x >= _maxSize)
            {
                size = new Vector3(_maxSize, _maxSize, _maxSize);
            }
            else
            {
                _fire.localScale = size;
            }
            _nowTime += Time.deltaTime;
        }
        else
        {
            if(_fire.localScale.x >= 0)_fire.localScale -= new Vector3(_decreaseValue, _decreaseValue, _decreaseValue);
        }
    }

    protected override void OnCollisionEnterPlayer()
    {
        _startScale = _fire.localScale;
        _endScale = _fire.localScale + new Vector3(Player.player.branchPoint, Player.player.branchPoint, Player.player.branchPoint);
        _nowTime = 0.0f;
        Player.player.branchPoint = 0;
    }

}
