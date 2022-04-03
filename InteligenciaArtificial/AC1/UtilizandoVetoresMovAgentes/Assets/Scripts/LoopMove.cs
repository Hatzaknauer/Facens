using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoopMove : MonoBehaviour
{
    //Transforms que serão utilizados como checkpoints para o objeto
    public Transform[] points;

    //Transform da posição inicial do objeto
    Transform initialPosition;

    //Variável que contém o tempo inicial em que se passou em cada objeto
    float startTime = 0;

    //Variável que irá guardar a distância do objeto para o destino
    float targetDistance;

    //Velocidade do objeto em unidades por segundo
    public float speed = 1f;

    //Controle do array points
    int point = 0;

    //Variável para receber o nome da cena
    string scene;

    //Variável para parar o movimento
    bool stop = false;

    private void Start()
    {
        //Guarda o nome da cena atual
        scene = SceneManager.GetActiveScene().name;

        //Recebe posição inicial do objeto
        initialPosition = GetComponent<Transform>();

        //Recebe tempo inicial do objeto
        startTime = Time.time;

        //Calcula a distância entre a posição inicial e o próximo checkpoint
        targetDistance = Vector3.Distance(initialPosition.position, points[point].position);
    }

    private void FixedUpdate()
    {
        //Chama método round enviando o checkpoint destino
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

        //ps: tag cubo só está presente na cena 4
    }

    //Método recebe variável point como ponto atual para realizar verificações
    void Round(int currentpoint)
    {

        //Verifica a cena atual é a cena 4, se não for, verifica se o checkpoint atual é o número 3(quarto checkpoint), se for:
        if (scene != "Cena 4" && currentpoint == 3)
        {
            //Reseta o loop de checkpoints
            point = 0;
        }

        //Verifica se NÃO está no ponto 6
        else if (point != 6)
        {
            // Distância percorrida é calculada com base no tempo atual subtraindo o tempo inicial multiplicado pela velocidade.
            float walked = (Time.time - startTime) * speed;

            // Calcula a fração da distância a percorrer
            float fractionDistance = walked / targetDistance;

            // Define a posição do objeto como uma fração da distância entre os dois objetos
            this.gameObject.transform.position = Vector3.Lerp(initialPosition.position, points[point].position, fractionDistance);

            //Se a posição do objeto e do ponto alvo forem iguais
            if (this.gameObject.transform.position == points[point].transform.position)
            {
                //Pega a posição atual como posição inicial para o próximo deslocamento
                initialPosition = GetComponent<Transform>();

                //Pega o temo atual como tempo inicial para o próximo deslocamento
                startTime = Time.time;

                //Adiciona +1 ao array de posições para ir ao próximo checkpoint
                point = point + 1;

                //Calcula a distância entre checkpoint caso não seja o sexto
                if (point != 6)
                {
                    //Calcula a distância entre a posição atual e o próximo checkpoint
                    targetDistance = Vector3.Distance(initialPosition.position, points[point].position);
                }
            }
        }
    }
}
