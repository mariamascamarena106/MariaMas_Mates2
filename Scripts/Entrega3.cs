using UnityEngine;

public class Entrega3 : MonoBehaviour
{
    void Start()
    {


        //Forma 1
        // n = n * n;

        //Forma 2
        //  n = n + n + n;

        //Forma 3
        //bucle if



        //Contar cifras de un numero entero n*(no negativo)

        //Talla del problema:
        //n: 9


        // Mejor caso:

        int n = 364;
        int res = 0;

        while (n != 0)
        {
            res++;
            n = n / 10;

        }
        Debug.Log(res);

        //Peor:

        int m = 890065324;
        int resul = 0;

        while (m != 0)
        {
            resul++;
            m = m / 10;

        }
        Debug.Log(resul);

        //Coste temporal = O(n log n)







    }

    void Update()
    {
        
    }
}
