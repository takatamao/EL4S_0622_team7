using UnityEngine;

public class Timer : MonoBehaviour
{
    public static float time;
    public static Timer timer;

    private void Awake()
    {
        timer = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        time = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        time += Time.deltaTime;
    }
}
