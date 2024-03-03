using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private GameObject[] levelParts;
    [SerializeField] private float minimalDistance;
    [SerializeField] private Transform finalPoint;
    [SerializeField] private int initialAmount;
    private Transform jugador;

    private void Start()
    {
        jugador = GameObject.FindGameObjectWithTag("Player").transform;
        for(int i = 0; i < initialAmount; i++)
        {
            GeneratePartLevel();
        }
    }
    private void Update()
    {
        if(Vector2.Distance(jugador.position, finalPoint.position)< minimalDistance)
        {
            GeneratePartLevel();
        }
    }

    private void GeneratePartLevel()
    {
        int randomNumber = Random.Range(0, levelParts.Length);
        GameObject level = Instantiate(levelParts[randomNumber], finalPoint.position, Quaternion.identity);
        finalPoint = FindFinalPoint(level, "FinalPoint");
    }

    private Transform FindFinalPoint(GameObject partLevel, string label)
    {
        Transform point = null;
        foreach (Transform location in partLevel.transform)
        {
            if (location.CompareTag(label))
            {
                point = location;
                break;
            }          
        }
        return point;
    }
}
