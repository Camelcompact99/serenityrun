using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_Moneda : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter(Collision otherObj) {
    if (otherObj.gameObject.tag == "Player") {
        Destroy(gameObject);
    }
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
