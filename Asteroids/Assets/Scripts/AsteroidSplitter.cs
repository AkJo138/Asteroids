using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSplitter : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] GameObject asteroidPrefab;
    [SerializeField] int asteroidLevel;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDestroy()
    {
        if(asteroidLevel !=  0)
            Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
        //newprefab.localScale = scaleDown;
        //Instantiate(asteroidPrefab, )
    }
}
