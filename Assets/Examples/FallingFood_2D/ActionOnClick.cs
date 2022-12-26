using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log($"{this.name} detected Left mouse button Click!");
        }
    }
}
