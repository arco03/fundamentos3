using UnityEngine;

public class PlayerFall : MonoBehaviour
{
    [SerializeField] private float x, y, z;
    [SerializeField] GameObject GameOverUI;
    [SerializeField] GameObject TimeUI;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("FallCollision"))
        {
            Debug.Log("Detectó la colision");
            GameOverUI.SetActive(true);
            TimeUI.SetActive(false);
          
        }
    }
}
