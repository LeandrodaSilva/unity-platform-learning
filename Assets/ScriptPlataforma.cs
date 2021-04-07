using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptPlataforma : MonoBehaviour
{
    private float cont;
    public float deslocamento = 1;
    private Vector2 posInicial;
    public float altura;
    public float largura;


    // Start is called before the first frame update
    void Start()
    {
        posInicial = new Vector2(transform.position.x, transform.position.y);
        cont = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cont += deslocamento * Time.deltaTime;

        float posY = Mathf.Sin(cont) * altura;
        float posX = Mathf.Cos(cont) * largura;

        transform.position = new Vector2(posInicial.x + posX, posInicial.y + posY);

        if (cont > 2 * Mathf.PI)
        {
            cont = 0;
        }
    }
}
