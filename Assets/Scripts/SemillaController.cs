using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SemillaController : MonoBehaviour
{

    public GameObject Arbol;


    // Start is called before the first frame update
    void Start()
    {
        float tiempoGerminacion = Random.Range(2.0F, 10.0F);
        Invoke("germinar", tiempoGerminacion);
        
    }

    private void germinar()
    {
        int siGermina = Random.Range(0, 2);

        if (siGermina == 1)
        {
			Instantiate(Arbol, new Vector3(this.transform.position.x, 0, this.transform.position.z), Quaternion.identity);

		}
       
        Destroy(this.gameObject);




    }
}
