using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private bool isRight;
    private void Update()
    {
        if(isRight == true) 
        {
            transform.position = Vector3.right * speed * Time.deltaTime;        
        }
        if(isRight == false)
        {
            transform.position = Vector3.left * speed * Time.deltaTime;
        }
    }
}
