using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PhysicsEnablerController : MonoBehaviour
{
    [SerializeField] KeyCode key;

    private void OnEnable()
    {
        ButtonPressEvent.buttonPress += PhysicsEnable;
    }
    private void OnDisable()
    {
        ButtonPressEvent.buttonPress -= PhysicsEnable;
    }

    void PhysicsEnable(KeyCode pressed)
    {
        if (pressed == key)
        {
            Debug.Log("event received");
            Rigidbody rigid = this.gameObject.GetComponent<Rigidbody>();
            rigid.isKinematic = !rigid.isKinematic;
        }
    }
}
