using System.Collections;
using System.Collections.Generic;
using System.Linq;

using UnityEngine;
using UnityEngine.UI;

public class OnSliderMove : MonoBehaviour
{
    [SerializeField] private GameObject objectSpawner;

    private Slider slider;


    private void Start()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    public void ApplySpeed()
    {
        objectSpawner.GetComponents<ObjectCreatorArea>().ToList().ForEach(area => {
            area.SetObjectSpeed(slider.value);
            GameObject.FindGameObjectsWithTag(area.prefabToSpawn.tag).ToList().ForEach(x =>
                x.GetComponent<ObjectMovement>().FallSpeed = slider.value);
            }
        );        
        Debug.Log("Slider moved! " + slider.value);
    }
}
