using UnityEngine;

public class Entrega3 : MonoBehaviour
{
    void Start()
    {

        int n = 3654;
        int res = 0;
        //Forma 1
       // n = n * n;

        //Forma 2
      //  n = n + n + n;

       //Forma 3
       //bucle if


       //Contar cifras de un numero entero n*(no negativo)
       //Talla del problema

       while (n > 0)
        {
            res++;
            n = n / 10;

        }
        Debug.Log(res);

        //Coste temporal = O(n^2) por bucle


        // Mejor y peor caso

    }

    void Update()
    {
        
    }
}
