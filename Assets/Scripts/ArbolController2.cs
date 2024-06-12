using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArbolController2 : MonoBehaviour
{

    public GameObject semilla;
    public GameObject semilla2;
	public GameObject semilla3;
	public int numAleatorio;

	private GameObject flor;

    // Start is called before the first frame update
    void Start()
    {
        flor = this.transform.GetChild(0).gameObject;

        StartCoroutine("GenerarSemillas");

        float vida = Random.Range(15.0f, 30.0f);

        Invoke("Morir", vida);
        
    }

    IEnumerator GenerarSemillas()
    {
		float tiempoEspera = Random.Range(3.0f, 5.0f);

		yield return new WaitForSeconds(tiempoEspera);

        while(true){

            float cambioX = Random.Range(-2.0f, 2.0f);
            float cambioZ = Random.Range(-2.0f, 2.0f);
            Vector3 nuevaPos = new Vector3(flor.transform.position.x + cambioX, flor.transform.position.y , flor.transform.position.z + cambioZ);
            numAleatorio = Random.Range(0, 2);
            if (numAleatorio == 0)
            {
                Instantiate(semilla, nuevaPos, Quaternion.identity);
            }
            else if (numAleatorio == 1)
            {
				Instantiate(semilla2, nuevaPos, Quaternion.identity);
			}
			else if (numAleatorio == 2)
			{
				Instantiate(semilla3, nuevaPos, Quaternion.identity);
			}


			yield return new WaitForSeconds(tiempoEspera);

        }

    }


    private void Morir() {

		Destroy(this.gameObject);

	}

}
