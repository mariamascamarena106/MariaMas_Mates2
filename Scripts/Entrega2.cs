using UnityEngine;

public class Entrega2 : MonoBehaviour
{
    void Start()
    {

        // Primer método

        float resultado = Random.Range (0.0f, 1.0f);

        if(resultado >= 0.0 ||  resultado <= 1.0)
        {
            resultado = resultado * 100;
            Debug.Log(resultado + "%");
        }

        // Segundo método

        float probabilidad = Random.Range (0f, 100f);
       
        if (probabilidad >= 0 || probabilidad <= 100)
        {
            probabilidad = probabilidad * 0.01f;
            Debug.Log(probabilidad);
        }

        // Tercer método

        float Rbuscados = 2f;
        float Rposibles = 3f;

        Debug.Log(Rbuscados / Rposibles + "%");

        // Cuarto método

        float figura = 12 / 52f;
        float As = 4 / 52f;

        Debug.Log(figura + As);

        // Quinto método 

        Debug.Log(figura * As);

        // Sexto método

        int dado = Random.Range(1, 6);
        Debug.Log(dado);

        //Séptimo método

        int D6 = dado;
        int D8 = Random.Range(1, 8);
        int D100 = Random.Range(1, 100);

        Debug.Log(D8);

    }

    void Update()
    {
        
    }
}
