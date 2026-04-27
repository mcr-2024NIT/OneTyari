using UnityEngine;

public class camera : MonoBehaviour
{
    public void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector3(Move._Xpos, 1f, -10f);
    }
}
