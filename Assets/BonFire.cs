using OpenCover.Framework.Model;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bonfire : GimmickBase
{

    [SerializeField] private float _decreaseValue;
    [SerializeField] private Transform _fire;
    [SerializeField] private Light _light;
    [SerializeField] private float _burstTime;
    [SerializeField] private float _maxSize = 5.0f;
    [SerializeField] private float _pointRef = 1.0f;    // ‚­‚×‚½}‚Ì”‚ğ‚½‚«‰Î‚Ì‘å‚«‚³‚É”½‰f‚·‚éŠ„‡
    private float _nowTime;
    private Vector3 _startScale = Vector3.zero;
    private Vector3 _endScale = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.PlayBGM(0,0.25f, true);
        _nowTime = _burstTime + 1.0f;
    }

    // Update is called once per frame
    void Update()
    {

        if (_nowTime <= _burstTime)
        {
            Vector3 size = Vector3.Lerp(_startScale, _endScale, _nowTime / _burstTime);
            if (size.x >= _maxSize)
            {
                size = new Vector3(_maxSize, _maxSize, _maxSize);
            }
            else
            {
                _fire.localScale = size;

            }
            _light.intensity = size.x * 2;
            _light.range = _light.intensity * 10;
            _nowTime += Time.deltaTime;
        }
        else
        {
            if (_fire.localScale.x >= 0) _fire.localScale -= new Vector3(_decreaseValue, _decreaseValue, _decreaseValue);
            _light.intensity = _fire.localScale.x * 2;
            _light.range = _light.intensity * 10;
            if (_fire.localScale.x <= 0.0f)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    protected override void OnCollisionEnterPlayer()
    {
        if(Player.player.branchPoint != 0)
        {
            SoundManager.instance.PlaySE(0,0.5f);
            _startScale = _fire.localScale;
            float point = Player.player.branchPoint / _pointRef;
            _endScale = _fire.localScale + new Vector3(point, point, point);
            _nowTime = 0.0f;
            Player.player.branchPoint = 0;
        }
    }

}
