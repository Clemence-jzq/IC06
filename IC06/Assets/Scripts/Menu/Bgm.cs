using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour
{
    public GameObject obj = null;


    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("bgm");
        if(obj == null)
        {
            obj = (GameObject)Instantiate(obj);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
