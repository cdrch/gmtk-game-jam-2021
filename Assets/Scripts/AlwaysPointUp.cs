using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlwaysPointUp : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0,0,0);
    }
}
