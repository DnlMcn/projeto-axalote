using UnityEngine;

public class CreateTrash : MonoBehaviour
{
    [SerializeField] GameObject trashPrefab;

    [SerializeField] private float range = 240;
    [SerializeField] private int amount = 100;

    void Start()
    {
        int i = 0;
        while(i++ <= amount)
        {
            Instantiate(trashPrefab, new Vector3(Random.Range(-range/2, range/2), 1, Random.Range(-range/2, range/2)), Quaternion.identity);
        }
    }
}
