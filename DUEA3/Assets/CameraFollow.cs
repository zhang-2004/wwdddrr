using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Follow Settings")]
    public Transform target;                  // Ҫ�����Ŀ�����
    public float smoothSpeed = 0.125f;       // ����ƽ���ȣ�ֵԽСԽƽ����
    public Vector3 offset = new Vector3(0, 2, -5); // ��������Ŀ���ƫ����
    public float lookUpOffset = 1f;          // ��������ƫ����

    private Vector3 velocity = Vector3.zero; // ����SmoothDamp�����ʱ���

    void Start()
    {
        // ���δ�ֶ�����ƫ���������Զ������ʼƫ��
        if (offset == Vector3.zero)
        {
            offset = transform.position - target.position;
        }
    }

    void LateUpdate()
    {
        if (target == null) return;

        // ����Ŀ��λ�ã�Ŀ��λ�� + ƫ������
        Vector3 targetPosition = target.position + offset;

        // ʹ��SmoothDampƽ���ƶ������
        transform.position = Vector3.SmoothDamp(
            transform.position,
            targetPosition,
            ref velocity,
            smoothSpeed
        );

        // �����������Ŀ�꣨����ֱƫ�ƣ�
        Vector3 lookAtPoint = target.position + Vector3.up * lookUpOffset;
        transform.LookAt(lookAtPoint);
    }
}