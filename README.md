# C-Sharp.Unity.Movimiento-Fisicas
Esta es la segunda práctica de la asignatura "Interfaces Inteligentes"

## Ejercicio Físicas 3D - Situaciones

## Ejercicios Físicas 3D - Scripts

### Hitos Generales
- Crear y añadir los componentes Rigidbody y Collider.
- Configurar correctamente los componentes Transform, Collider, Rigidbody y Renderer según cada ejercicio.

### Hitos Ejercicio 1 (Movimiento del personaje con Rigidbody)
- Implementar el movimiento mediante WASD o las flechas del teclado.
- Controlar el desplazamiento mediante el Rigidbody, por ejemplo, con MovePosition.
- Mantener el control del movimiento con Rigidbody, pero sin que nuestro movimiento sea afectado por las físicas.
- Probar el movimiento en todas las direcciones y comprobar que funciona correctamente.
<img width="1280" height="720" alt="Ej1" src="https://github.com/user-attachments/assets/8bdd4cf7-a52f-43f5-a3ec-823c6bcab449" />

Resultado: el personaje se mueve mediante el Rigidbody y responde a las teclas sin perder el control del desplazamiento.

## Hitos Ejercicio 2 (Detección de colisiones y cambio de color)
- Crear varios cubos o esferas con Rigidbody dinámico y Collider.
- Implementar OnCollisionEnter para detectar las colisiones.
- Mostrar en la consola el nombre del objeto con el que se ha colisionado.
- Cambiar el color del objeto que ejecuta el script al colisionar.
- Probar las colisiones entre varios objetos y comprobar los mensajes de consola.
<img width="1280" height="720" alt="Ej2" src="https://github.com/user-attachments/assets/791f4c5c-3196-4745-8bf7-30a166a6d3ae" />

Resultado: Al producirse una colisión, aparece el nombre del otro objeto en la consola y cambia el color del objeto que detecta la colisión.

## Hitos Ejercicio 3 (Zonas Trigger y modificación de variables)
- Crear el personaje y una zona con Collider e Is Trigger activado.
- Detectar la entrada del personaje mediante OnTriggerEnter.
- Cambiar el color del personaje o activar un efecto de iluminación al entrar.
- Revertir el cambio al salir mediante OnTriggerExit.
- Crear una segunda zona que incremente una variable de daño.
- Probar la entrada, permanencia y salida de ambas zonas.
<img width="1280" height="720" alt="Ej3" src="https://github.com/user-attachments/assets/c99e8a68-c4df-4ed9-91a6-1b6346f97576" />

Resultado: La primera zona activa y revierte el efecto; la segunda modifica la variable de daño cuando se activa la interacción prevista.

## Hitos Ejercicio 4 (Layers y Layer Collision Matrix)
- Crear las capas Jugador, Enemigos y Recolectables.
- Asignar cada tipo de objeto a su capa correspondiente.
- Configurar la Layer Collision Matrix en Project Settings > Physics.
- Permitir las colisiones entre jugador y enemigos y desactivar las interacciones entre enemigos y entre enemigos y recolectables, si no son necesarias.
- Configurar los recolectables con Collider y Is Trigger activado.
- Implementar la detección de los recolectables mediante OnTriggerEnter.
- Probar todas las combinaciones de interacción entre capas.
<img width="1280" height="720" alt="Ej4" src="https://github.com/user-attachments/assets/9f50cfa6-636b-4c52-94b9-a378cab46bf3" />

Resultado: Los enemigos colisionan con el jugador, mientras que los recolectables se detectan mediante triggers.

## Hitos Ejercicio 5 (Physic Materials y fuerzas)
- Crear una escena con objetos y superficies de prueba, al igual que creamos los Physic Materials resbaladizo, rugoso y de rebote alto.
- Configurar la fricción y el rebote de cada material y lo asignamos a su respectivo Collider.
- Implementar AddForce para aplicar una fuerza al pulsar X.
- Comprobar que los objetos que deban responder a la fuerza tienen Rigidbody dinámico.
- Comparar el deslizamiento y el rebote en condiciones similares para registrar las diferencias observadas entre materiales.
<img width="1280" height="720" alt="Ej5" src="https://github.com/user-attachments/assets/98db06ab-7f7e-4d6a-ac4d-225b9f7b7d7a" />

Resultado: Los objetos muestran diferencias observables de fricción y rebote al aplicar fuerzas. La fricción también depende del material de la superficie de contacto.

## Hitos Ejercicio 6 (Esfera, obstáculo y objetivo)
- Crear un cubo, una esfera y un cilindro alineados.
- Añadir un Collider a cada objeto y comprobar que ninguno tiene Rigidbody.
- Asignar la etiqueta Cilindro al objetivo y Obstaculo al cubo.
- Implementar el movimiento de la esfera hacia el cilindro con Vector3.MoveTowards.
- Detectar cuándo la esfera alcanza el cubo.
- Cambiar el material del cubo al alcanzar el obstáculo.
- Probar el comportamiento final de la esfera y verificar que llega al objetivo.
<img width="1280" height="720" alt="Ej6" src="https://github.com/user-attachments/assets/4583cedc-1e22-40c3-a773-230115dd4063" />

Resultado:La esfera se dirige al cilindro y, al alcanzar el cubo, este cambia su material.
