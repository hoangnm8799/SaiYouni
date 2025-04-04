using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    public float moveSpeed = 3f;  // Tốc độ di chuyển
    private Vector3 targetPosition;
    private bool canMove = true;  // Biến này để kiểm tra có thể di chuyển hay không

    // Biến ground để tham chiếu đến mặt đất (nếu cần thiết)
    public Transform ground;

    void Start()
    {
        SetRandomTarget();  // Tạo mục tiêu ngẫu nhiên ban đầu
    }

    void Update()
    {
        // Di chuyển liên tục đến mục tiêu
        if (canMove)
        {
            // Nếu đối tượng di chuyển gần đến mục tiêu, chọn mục tiêu ngẫu nhiên mới
            if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
            {
                SetRandomTarget();  // Tạo mục tiêu ngẫu nhiên mới
            }

            // Di chuyển về phía mục tiêu và giữ trục Y cố định
            Vector3 targetPosition2D = new Vector3(targetPosition.x, transform.position.y, targetPosition.z);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition2D, moveSpeed * Time.deltaTime);

            // Đảm bảo trục Y của đối tượng không bị thay đổi
            float groundHeight = GetGroundHeight(transform.position);
            transform.position = new Vector3(transform.position.x, groundHeight, transform.position.z);
        }
    }

    // Hàm này sẽ tạo ra một mục tiêu ngẫu nhiên trong không gian
    void SetRandomTarget()
    {
        // Tạo một mục tiêu ngẫu nhiên mới trong phạm vi -10f đến 10f
        // Nếu mục tiêu trùng với vị trí hiện tại, chọn lại mục tiêu khác
        Vector3 newTarget;
        do
        {
            newTarget = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));
        }
        while (Vector3.Distance(transform.position, newTarget) < 1f);  // Kiểm tra nếu mục tiêu quá gần vị trí hiện tại

        targetPosition = newTarget;
    }

    // Kiểm tra chiều cao của mặt đất tại vị trí hiện tại
    float GetGroundHeight(Vector3 position)
    {
        RaycastHit hit;
        if (Physics.Raycast(position + Vector3.up * 10f, Vector3.down, out hit, 20f))
        {
            // Trả về chiều cao mặt đất
            return hit.point.y;
        }
        return position.y;  // Nếu không có va chạm nào, giữ nguyên vị trí Y
    }

    // Kiểm tra xem đối tượng có đang đứng trên mặt đất hay không
    bool IsOnGround()
    {
        // Sử dụng raycast để kiểm tra xem đối tượng có đang chạm mặt đất hay không
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 1f))
        {
            return hit.transform == ground;
        }
        return false;
    }

    // Hàm này được gọi khi vật thể va chạm với một vật thể khác
    void OnCollisionEnter(Collision collision)
    {
        // Nếu va chạm với vật thể khác ngoài mặt đất, dừng di chuyển
        if (collision.gameObject != ground.gameObject)
        {
            canMove = false;  // Dừng di chuyển khi va chạm với vật thể khác
            Debug.Log("Va chạm với vật thể khác, dừng di chuyển");
        }
    }

    // Hàm này được gọi khi đối tượng không còn va chạm với vật thể nào
    void OnCollisionExit(Collision collision)
    {
        // Nếu va chạm với mặt đất, tiếp tục di chuyển
        if (collision.gameObject == ground.gameObject)
        {
            canMove = true;  // Tiếp tục di chuyển khi không còn va chạm với vật thể khác
            Debug.Log("Đang đứng trên mặt đất, tiếp tục di chuyển");
        }
    }
}
