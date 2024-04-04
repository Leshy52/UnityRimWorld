using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody rb; // ������ �� ��������� Rigidbody2D
    public float speed = 0.5f; // �������� ������������
    private Vector3 moveVector; // ����������� ��������� ����� �������
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.z = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + moveVector * speed * Time.deltaTime);
    }
}