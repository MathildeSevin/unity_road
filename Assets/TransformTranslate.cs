using UnityEngine;
using System.Collections;

public class TransformTranslate : MonoBehaviour
{
    // Start is called before the first frame update
    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 5f);
    }

}
