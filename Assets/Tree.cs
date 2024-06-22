using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : GimmickBase
{
    [SerializeField] private GameObject _Branch;
    [SerializeField] private float _instantiateRange = 9;

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
        if(other.CompareTag("Axe"))
        {
            Instantiate(_Branch,transform.position,Quaternion.identity);
            Instantiate(this.gameObject, new Vector3(Random.Range(-_instantiateRange, _instantiateRange), 0.0f, Random.Range(-_instantiateRange, _instantiateRange)), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
