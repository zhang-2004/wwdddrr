using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; // ���������ռ�

public class PlayerController : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;
    public float rotationSpeed = 10f;

    [Header("Coin Collection")]
    public int coinsCollected = 0;
    public TMP_Text coinCounterText;
    public int coinsRequiredToNextLevel = 10; // ��Ҫ�ռ��Ľ������
    public int nextSceneIndex = 1; // ��һ����������������Build Settings�в鿴��

    private Rigidbody rb;
    private Vector3 movementInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        UpdateCoinUI();
    }

    void Update()
    {
        movementInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        if (movementInput != Vector3.zero)
        {
            Quaternion targetRotation = Quaternion.LookRotation(movementInput);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }

    void FixedUpdate()
    {
        if (movementInput != Vector3.zero)
        {
            Vector3 moveDirection = movementInput.normalized * moveSpeed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + moveDirection);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            coinsCollected++;
            Destroy(other.gameObject);
            UpdateCoinUI();

            // ����Ƿ�ﵽĿ������
            if (coinsCollected >= coinsRequiredToNextLevel)
            {
                LoadNextScene();
            }
        }
    }

    void UpdateCoinUI()
    {
        if (coinCounterText != null)
        {
            coinCounterText.text = "Coins: " + coinsCollected + " / " + coinsRequiredToNextLevel;
        }
    }

    // ����������������һ������
    void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneIndex);
        // �������Ч�������滻Ϊ��
        // SceneManager.LoadSceneAsync(nextSceneIndex);
    }
}