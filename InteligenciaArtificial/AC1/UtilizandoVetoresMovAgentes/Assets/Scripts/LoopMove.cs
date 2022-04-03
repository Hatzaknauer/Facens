using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoopMove : MonoBehaviour
{
    //Transforms que ser�o utilizados como checkpoints para o objeto
    public Transform[] points;

    //Transform da posi��o inicial do objeto
    Transform initialPosition;

    //Vari�vel que cont�m o tempo inicial em que se passou em cada objeto
    float startTime = 0;

    //Vari�vel que ir� guardar a dist�ncia do objeto para o destino
    float targetDistance;

    //Velocidade do objeto em unidades por segundo
    public float speed = 1f;

    //Controle do array points
    int point = 0;

    //Vari�vel para receber o nome da cena
    string scene;

    //Vari�vel para parar o movimento
    bool stop = false;

    private void Start()
    {
        //Guarda o nome da cena atual
        scene = SceneManager.GetActiveScene().name;

        //Recebe posi��o inicial do objeto
        initialPosition = GetComponent<Transform>();

        //Recebe tempo inicial do objeto
        startTime = Time.time;

        //Calcula a dist�ncia entre a posi��o inicial e o pr�ximo checkpoint
        targetDistance = Vector3.Distance(initialPosition.position, points[point].position);
    }

    private void FixedUpdate()
    {
        //Chama m�todo round enviando o checkpoint destino
        Round(point); 
    }

    public void OnTriggerEnter(Collider other)
    {

        //Se atravessar um componente com a tag "cubo"
        if (other.gameObject.CompareTag("Cubo"))
        {
            
            //Troca o componente de cor para vermelho
            other.gameObject.GetComponent<MeshRenderer>().material.color = Color.red;
        }

        //ps: tag cubo s� est� presente na cena 4
    }

    //M�todo recebe vari�vel point como ponto atual para realizar verifica��es
    void Round(int currentpoint)
    {

        //Verifica a cena atual � a cena 4, se n�o for, verifica se o checkpoint atual � o n�mero 3(quarto checkpoint), se for:
        if (scene != "Cena 4" && currentpoint == 3)
        {
            //Reseta o loop de checkpoints
            point = 0;
        }

        //Verifica se N�O est� no ponto 6
        else if (point != 6)
        {
            // Dist�ncia percorrida � calculada com base no tempo atual subtraindo o tempo inicial multiplicado pela velocidade.
            float walked = (Time.time - startTime) * speed;

            // Calcula a fra��o da dist�ncia a percorrer
            float fractionDistance = walked / targetDistance;

            // Define a posi��o do objeto como uma fra��o da dist�ncia entre os dois objetos
            this.gameObject.transform.position = Vector3.Lerp(initialPosition.position, points[point].position, fractionDistance);

            //Se a posi��o do objeto e do ponto alvo forem iguais
            if (this.gameObject.transform.position == points[point].transform.position)
            {
                //Pega a posi��o atual como posi��o inicial para o pr�ximo deslocamento
                initialPosition = GetComponent<Transform>();

                //Pega o temo atual como tempo inicial para o pr�ximo deslocamento
                startTime = Time.time;

                //Adiciona +1 ao array de posi��es para ir ao pr�ximo checkpoint
                point = point + 1;

                //Calcula a dist�ncia entre checkpoint caso n�o seja o sexto
                if (point != 6)
                {
                    //Calcula a dist�ncia entre a posi��o atual e o pr�ximo checkpoint
                    targetDistance = Vector3.Distance(initialPosition.position, points[point].position);
                }
            }
        }
    }
}
