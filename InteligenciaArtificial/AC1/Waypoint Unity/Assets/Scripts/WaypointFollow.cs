using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    // Declaração do array de checkpoints e índice pra controle da posição do array
    public GameObject[] waypoints;
    int currentWP = 0;

    // Variáveis para velocidade do agente
    float speed = 1.0f;
    float accuracy = 1.0f;
    float rotSpeed = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        // Encontra na cena os objetos com a tag waypoint e aloca-os no array
        waypoints = GameObject.FindGameObjectsWithTag("waypoint");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Se não houver nenhum waypoint na cena, retorna/sai do if
        if (waypoints.Length == 0) return;

        // Guarda numa variável a posição em que estará de frente para o objeto alvo atual do array
        Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x,
        this.transform.position.y,
        waypoints[currentWP].transform.position.z);

        // Usa a variável guardada para fazer uma interpolação na rotação entre a posição atual e a posição alvo
        Vector3 direction = lookAtGoal - this.transform.position;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
        Quaternion.LookRotation(direction),
        Time.deltaTime * rotSpeed);

        // Verifica se a magnitude(um cálculo de ângulo) está menor que a variável accuracy(1)
        if (direction.magnitude < accuracy)

        {
            // Adiciona 1 no índice e para o próximo waypoint
            currentWP++;

            // Se o índice do array for maior ou igual que o tamanho do array
            if (currentWP >= waypoints.Length)
            {
                // Reseta para o primeiro waypoint
                currentWP = 0;
            }
        }

        // Move o transform para o eixo Z com a variável speed com o passar do tempo
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}