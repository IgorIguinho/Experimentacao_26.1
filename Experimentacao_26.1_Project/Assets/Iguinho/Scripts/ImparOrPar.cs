using UnityEngine;

public class ImparOrPar : MonoBehaviour
{

    public int jogador1;
    public bool isPar;
    public int jogador2;

    public int somaResultado;
    public int resultadoImparPar;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ImparOuParFunction();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ImparOuParFunction()
    {
        jogador2 = Random.Range(0, 100);

        int somaResultado_;
        somaResultado_ = jogador1 + jogador2;
        
        somaResultado = somaResultado_;
        resultadoImparPar = somaResultado_ % 2;

        CheckWin(resultadoImparPar);
    }

    void CheckWin(int resultado)
    {
        if (isPar)
        {
            if (resultado == 0)
            {
                Debug.Log("Jogador 1 ganhou, pois a soma de " + jogador1 + " + " + jogador2 +  " é igual a " + somaResultado + ", e esse numero é par");
            }
            else
            {
                Debug.Log("Jogador 2 ganhou, pois a soma de " + jogador1 + " + " + jogador2 +  " é igual a " + somaResultado + ", e esse numero é impar");

            }
        }
        else
        {
            if (resultado == 0)
            {
                Debug.Log("Jogador 2 ganhou, pois a soma de " + jogador1 + " + " + jogador2 +  " é igual a " + somaResultado + ", e esse numero é par");

            }
            else
            {
                Debug.Log("Jogador 1 ganhou, pois a soma de " + jogador1 + " + " + jogador2 +  " é igual a " + somaResultado + ", e esse numero é impar");
                
            }
        }
    }
}
