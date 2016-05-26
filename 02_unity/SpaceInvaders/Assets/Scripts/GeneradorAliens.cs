using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GeneradorAliens : MonoBehaviour
{

	// Publicamos la variable para conectarla desde el editor
	public Rigidbody2D prefabAlien1;

	// Referencia para guardar una matriz de objetos
	private Rigidbody2D[,] aliens;

    // Tamaño de la invasión alienígena para nivel 1
    
    private const int FILAS1 = 4;
	private const int COLUMNAS1 = 7;

    // Tamaño de la invasión alienígena para nivel 2

    private const int FILAS2 = 5;
    private const int COLUMNAS2 = 8;

    // Tamaño de la invasión alienígena para nivel 2

    private const int FILAS3 = 7;
    private const int COLUMNAS3 = 10;



    // Enumeración para expresar el sentido del movimiento
    private enum direccion { IZQ, DER };

	// Rumbo que lleva el pack de aliens
	private direccion rumbo = direccion.DER;

	// Posición vertical de la horda (lo iremos restando de la .y de cada alien)
	private float altura = 0.5f;

	// Límites de la pantalla
	private float limiteIzq;
	private float limiteDer;

	// Velocidad a la que se desplazan los aliens (medido en u/s)
	private float velocidad = 5f;

	// Use this for initialization

        
	void Start ()
	{

        // Rejilla de 4x7 aliens
        if (SceneManager.GetActiveScene().name == "Nivel1")
        {
            generarAliens (FILAS1, COLUMNAS1, 1.5f, 1.0f);
        }
        if (SceneManager.GetActiveScene().name == "Nivel2")
        {
            generarAliens(FILAS2, COLUMNAS2, 1.5f, 1.0f);
        }
        if (SceneManager.GetActiveScene().name == "Nivel3")
        {
            generarAliens(FILAS3, COLUMNAS3, 1.5f, 1.0f);
        }
        


        // Calculamos la anchura visible de la cámara en pantalla
        float distanciaHorizontal = Camera.main.orthographicSize * Screen.width / Screen.height;

		// Calculamos el límite izquierdo y el derecho de la pantalla (añadimos una unidad a cada lado como margen)
		limiteIzq = -1.0f * distanciaHorizontal + 1;
		limiteDer = 1.0f * distanciaHorizontal - 1;
	}

    // Update is called once per frame
    void Update()
    {
        // Contador para saber si hemos terminado
        int numAliens = 0;

        // Variable para saber si al menos un alien ha llegado al borde
        bool limiteAlcanzado = false;

        // Recorremos la horda alienígena PARA NIVEL 1
        if (SceneManager.GetActiveScene().name == "Nivel1")
        {
            for (int i = 0; i < FILAS1; i++)
            {
                for (int j = 0; j < COLUMNAS1; j++)
                {

                    // Comprobamos que haya objeto, para cuando nos empiecen a disparar
                    if (aliens[i, j] != null)
                    {

                        // Un alien más
                        numAliens += 1;

                        // ¿Vamos a izquierda o derecha?
                        if (rumbo == direccion.DER)
                        {

                            // Nos movemos a la derecha (todos los aliens que queden)
                            aliens[i, j].transform.Translate(Vector2.right * velocidad * Time.deltaTime);

                            // Comprobamos si hemos tocado el borde
                            if (aliens[i, j].transform.position.x > limiteDer)
                            {
                                limiteAlcanzado = true;
                            }
                        }
                        else
                        {

                            // Nos movemos a la derecha (todos los aliens que queden)
                            aliens[i, j].transform.Translate(Vector2.left * velocidad * Time.deltaTime);

                            // Comprobamos si hemos tocado el borde
                            if (aliens[i, j].transform.position.x < limiteIzq)
                            {
                                limiteAlcanzado = true;
                            }
                        }
                    }
                }
            }
        }

        // Recorremos la horda alienígena PARA NIVEL 2
        if (SceneManager.GetActiveScene().name == "Nivel2")
        {
            for (int i = 0; i < FILAS2; i++)
            {
                for (int j = 0; j < COLUMNAS2; j++)
                {

                    // Comprobamos que haya objeto, para cuando nos empiecen a disparar
                    if (aliens[i, j] != null)
                    {

                        // Un alien más
                        numAliens += 1;

                        // ¿Vamos a izquierda o derecha?
                        if (rumbo == direccion.DER)
                        {

                            // Nos movemos a la derecha (todos los aliens que queden)
                            aliens[i, j].transform.Translate(Vector2.right * velocidad * Time.deltaTime);

                            // Comprobamos si hemos tocado el borde
                            if (aliens[i, j].transform.position.x > limiteDer)
                            {
                                limiteAlcanzado = true;
                            }
                        }
                        else
                        {

                            // Nos movemos a la derecha (todos los aliens que queden)
                            aliens[i, j].transform.Translate(Vector2.left * velocidad * Time.deltaTime);

                            // Comprobamos si hemos tocado el borde
                            if (aliens[i, j].transform.position.x < limiteIzq)
                            {
                                limiteAlcanzado = true;
                            }
                        }
                    }
                }
            }
        }
        // Recorremos la horda alienígena PARA NIVEL 3
        if (SceneManager.GetActiveScene().name == "Nivel3")
        {
            for (int i = 0; i < FILAS3; i++)
            {
                for (int j = 0; j < COLUMNAS3; j++)
                {

                    // Comprobamos que haya objeto, para cuando nos empiecen a disparar
                    if (aliens[i, j] != null)
                    {

                        // Un alien más
                        numAliens += 1;

                        // ¿Vamos a izquierda o derecha?
                        if (rumbo == direccion.DER)
                        {

                            // Nos movemos a la derecha (todos los aliens que queden)
                            aliens[i, j].transform.Translate(Vector2.right * velocidad * Time.deltaTime);

                            // Comprobamos si hemos tocado el borde
                            if (aliens[i, j].transform.position.x > limiteDer)
                            {
                                limiteAlcanzado = true;
                            }
                        }
                        else
                        {

                            // Nos movemos a la derecha (todos los aliens que queden)
                            aliens[i, j].transform.Translate(Vector2.left * velocidad * Time.deltaTime);

                            // Comprobamos si hemos tocado el borde
                            if (aliens[i, j].transform.position.x < limiteIzq)
                            {
                                limiteAlcanzado = true;
                            }
                        }
                    }
                }
            }
        }

        // Si no quedan aliens, hemos terminado

        if (SceneManager.GetActiveScene().name == "Nivel1")
        {
            if (numAliens == 0)
            {
                SceneManager.LoadScene("Nivel2");

            }
        }
        if (SceneManager.GetActiveScene().name == "Nivel2")
        {
            if (numAliens == 0)
            {
                SceneManager.LoadScene("Nivel3");
            }


        }
        if (SceneManager.GetActiveScene().name == "Nivel3")
        {
            if (numAliens == 0)
            {
                SceneManager.LoadScene("Winner");
            }


        }


        // Si al menos un alien ha tocado el borde, todo el pack cambia de rumbo para el nivel 1
        if (SceneManager.GetActiveScene().name == "Nivel1")
        {

            if (limiteAlcanzado == true)
            {
                for (int i = 0; i < FILAS1; i++)
                {
                    for (int j = 0; j < COLUMNAS1; j++)
                    {

                        // Comprobamos que haya objeto, para cuando nos empiecen a disparar
                        if (aliens[i, j] != null)
                        {
                            aliens[i, j].transform.Translate(Vector2.down * altura);
                        }
                    }
                }


                if (rumbo == direccion.DER)
                {
                    rumbo = direccion.IZQ;
                }
                else
                {
                    rumbo = direccion.DER;
                }
            }
        }

        // Si al menos un alien ha tocado el borde, todo el pack cambia de rumbo para el nivel 2
        if (SceneManager.GetActiveScene().name == "Nivel2")
        {
            {
                if (limiteAlcanzado == true)
                {
                    for (int i = 0; i < FILAS2; i++)
                    {
                        for (int j = 0; j < COLUMNAS2; j++)
                        {

                            // Comprobamos que haya objeto, para cuando nos empiecen a disparar
                            if (aliens[i, j] != null)
                            {
                                aliens[i, j].transform.Translate(Vector2.down * altura);
                            }
                        }
                    }


                    if (rumbo == direccion.DER)
                    {
                        rumbo = direccion.IZQ;
                    }
                    else
                    {
                        rumbo = direccion.DER;
                    }
                }
            }

        }
        // Si al menos un alien ha tocado el borde, todo el pack cambia de rumbo para el nivel 3
        if (SceneManager.GetActiveScene().name == "Nivel3")
        {

            if (limiteAlcanzado == true)
            {
                for (int i = 0; i < FILAS3; i++)
                {
                    for (int j = 0; j < COLUMNAS3; j++)
                    {

                        // Comprobamos que haya objeto, para cuando nos empiecen a disparar
                        if (aliens[i, j] != null)
                        {
                            aliens[i, j].transform.Translate(Vector2.down * altura);
                        }
                    }
                }


                if (rumbo == direccion.DER)
                {
                    rumbo = direccion.IZQ;
                }
                else
                {
                    rumbo = direccion.DER;
                }
            }
        }
    }

	void generarAliens (int filas, int columnas, float espacioH, float espacioV, float escala = 1.0f)
	{
		/* Creamos una rejilla de aliens a partir del punto de origen
		 * 
		 * Ejemplo (2,5):
		 *   A A A A A
		 *   A A O A A
		 */

		// Calculamos el punto de origen de la rejilla
		Vector2 origen = new Vector2 (transform.position.x - (columnas / 2.0f) * espacioH + (espacioH / 2), transform.position.y);

		// Instanciamos el array de referencias
		aliens = new Rigidbody2D[filas, columnas];

		// Fabricamos un alien en cada posición del array
		for (int i = 0; i < filas; i++) {
			for (int j = 0; j < columnas; j++) {

				// Posición de cada alien
				Vector2 posicion = new Vector2 (origen.x + (espacioH * j), origen.y + (espacioV * i));

				// Instanciamos el objeto partiendo del prefab
				Rigidbody2D alien = (Rigidbody2D)Instantiate (prefabAlien1, posicion, transform.rotation);

				// Guardamos el alien en el array
				aliens [i, j] = alien;

				// Escala opcional, por defecto 1.0f (sin escala)
				// Nota: El prefab original ya está escalado a 0.2f
				alien.transform.localScale = new Vector2 (0.2f * escala, 0.2f * escala);
			}
		}

	}

}
