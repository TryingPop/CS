using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;

    [SerializeField]
    private Transform chrBody; // ĳ���� ��
    
    [SerializeField]
    private Transform cameraBox; // ī�޶�


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        LookAround();
    }

    void Move()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        bool isMove = (moveInput.magnitude != 0);

        if (isMove)
        {
            Vector3 lookForward = new Vector3(cameraBox.forward.x, 0f, cameraBox.forward.z).normalized;
            Vector3 lookRight = new Vector3(cameraBox.right.x, 0f, cameraBox.right.z).normalized;
            Vector3 moveDir = (lookForward * moveInput.y + lookRight * moveInput.x);


            chrBody.forward = lookForward; // ī�޶� �ٶ󺸴� �������� ��Ʈ��
            // chrBody.forward = moveDir; // ĳ���Ͱ� �̵��ϴ� �������� ��Ʈ��
            transform.position += moveDir * Time.deltaTime * moveSpeed;
        }
    }
    void LookAround()
    {
        Vector2 mouseDelta = new Vector2(Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X")); // ���� x, y �� ȸ�� ��
        Vector3 camAngle = cameraBox.rotation.eulerAngles;

        float x = camAngle.x - mouseDelta.x;
        x = Mathf.Clamp(x, -90f, 90f);
        cameraBox.rotation = Quaternion.Euler(x, camAngle.y + mouseDelta.y, camAngle.z);
    }
}
