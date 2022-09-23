using UnityEngine;

public class P_3_GetKeys_Movement : MonoBehaviour
{

    [SerializeField]
    float velocidad = 10;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Codigo ejecutado una vez");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(
                transform.forward * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(
                transform.forward * -1 * velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
        }
    }
}
