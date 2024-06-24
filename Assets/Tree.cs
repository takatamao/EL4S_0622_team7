using UnityEngine;

public class Tree : GimmickBase
{
    [SerializeField] private GameObject _Branch;
    [SerializeField] private float _dropBranchPower;
    [SerializeField] private float _spawnDeadZone;
    
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
        if (other.CompareTag("Axe"))
        {
            float x = Random.Range(-30, 30);
            if (x <= 0) x -= 2;
            else x += 2;

            float z = Random.Range(-20, 20);
            if (z <= 0) x -= 2;
            else z += 2;


            SoundManager.instance.PlaySE(1,0.25f);
            int random = Random.Range(1, 3);

            for(int i = 0; i < random; i++)
            {
                float _x = Random.Range(-1.0f, 1.0f);
                float _z = Random.Range(-1.0f, 1.0f);
                Instantiate(_Branch, transform.position + (Vector3.up * 5), Quaternion.identity)
                .GetComponent<Rigidbody>().AddForce(new Vector3(_x, 1, _z) * _dropBranchPower);
            }
            

            Instantiate(this.gameObject, new Vector3(x, 0.0f, z), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
