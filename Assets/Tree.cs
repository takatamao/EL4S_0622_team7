using UnityEngine;

public class Tree : GimmickBase
{
    [SerializeField] private GameObject _Branch;
   // [SerializeField] private float _instantiateRange = 9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        int x = Random.Range(-30, 30);
        if (x <= 0) x -= 5;
        else x += 5;

        int z = Random.Range(-15, 35);
        if (z <= 0) x -= 5;
        else z += 5;

        if (other.CompareTag("Axe"))
        {
            SoundManager.instance.PlaySE(1,0.25f);
            Instantiate(_Branch,transform.position,Quaternion.identity);
            Instantiate(this.gameObject, new Vector3(x, 0.0f, z), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
