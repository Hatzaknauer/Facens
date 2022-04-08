using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    // Declara��o do array de checkpoints e �ndice pra controle da posi��o do array
    public GameObject[] waypoints;
    int currentWP = 0;

    // Vari�veis para velocidade do agente
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
        // Se n�o houver nenhum waypoint na cena, retorna/sai do if
        if (waypoints.Length == 0) return;

        // Guarda numa vari�vel a posi��o em que estar� de frente para o objeto alvo atual do array
        Vector3 lookAtGoal = new Vector3(waypoints[currentWP].transform.position.x,
        this.transform.position.y,
        waypoints[currentWP].transform.position.z);

        // Usa a vari�vel guardada para fazer uma interpola��o na rota��o entre a posi��o atual e a posi��o alvo
        Vector3 direction = lookAtGoal - this.transform.position;
        this.transform.rotation = Quaternion.Slerp(this.transform.rotation,
        Quaternion.LookRotation(direction),
        Time.deltaTime * rotSpeed);

        // Verifica se a magnitude(um c�lculo de �ngulo) est� menor que a vari�vel accuracy(1)
        if (direction.magnitude < accuracy)

        {
            // Adiciona 1 no �ndice e para o pr�ximo waypoint
            currentWP++;

            // Se o �ndice do array for maior ou igual que o tamanho do array
            if (currentWP >= waypoints.Length)
            {
                // Reseta para o primeiro waypoint
                currentWP = 0;
            }
        }

        // Move o transform para o eixo Z com a vari�vel speed com o passar do tempo
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}