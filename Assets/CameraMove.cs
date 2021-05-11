using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    Transform tf; //Main Camera��Transform
    Camera cam; //Main Camera��Camera

    void Start()
    {
        tf = this.gameObject.GetComponent<Transform>(); //Main Camera��Transform���擾����B
        cam = this.gameObject.GetComponent<Camera>(); //Main Camera��Camera���擾����B
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) //��L�[��������Ă����
        {
            tf.position = tf.position + new Vector3(0.0f, 0.2f, 0.0f); //�J��������ֈړ��B
        }
        else if (Input.GetKey(KeyCode.DownArrow)) //���L�[��������Ă����
        {
            tf.position = tf.position + new Vector3(0.0f, -1.0f, 0.0f); //�J���������ֈړ��B
        }
    }
}
