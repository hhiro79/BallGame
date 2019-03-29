using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelPoint : MonoBehaviour
{

    void OnTriggerEnter(Collider col) {
        col.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 5, 15),
            ForceMode.VelocityChange);
    }
}
