# C-Sharp.Unity.Movimiento-Fisicas
Esta es la segunda práctica de la asignatura "Interfaces Inteligentes"

## Ejercicio Físicas 3D - Situaciones
### Situación 1
#### y = 0.5
<img width="1280" height="720" alt="Sit01" src="https://github.com/user-attachments/assets/88bd0967-e5cf-4058-9171-2e188526b066" />

#### y > 0.5
<img width="1280" height="720" alt="Sit01 2" src="https://github.com/user-attachments/assets/7def309c-84fe-4f45-b2cd-de3209ac1c29" />

Explicación: El cubo es el único objeto cuya dinámica se simula mediante un Rigidbody, mientras que el plano y la esfera tienen Collider, pero no se simula su movimiento mediante un Rigidbody.

### Situación 2
<img width="1280" height="720" alt="Sit02" src="https://github.com/user-attachments/assets/fbbffcd2-ef7f-47ef-b339-45c4f76e2b16" />

Explicación: Tanto el cubo como la esfera responden a la gravedad debido a que disponen de un Rigidbody dinámico (sus movimientos dependen de las fuerzas, la gravedad, las masas y los contactos entre colliders) y pueden colisionar entre sí y con el plano.

### Situación 3
<img width="1280" height="720" alt="Sit03" src="https://github.com/user-attachments/assets/a10b8f56-2e5a-4c5d-875d-ae88999f8a40" />

Explicación: El cubo cae por efecto de la gravedad (Rigidbody dinámico), mientras que la esfera no cae por gravedad si tiene "Is Kinematic" activado (Rigidbody cinemático), por otro lado al no disponer el plano de un Rigidbody este no se ve afectado por el motor de físicas.

### Situación 4
<img width="1280" height="720" alt="Sit04" src="https://github.com/user-attachments/assets/cd625415-060d-4437-8fab-eba31b4d9dd0" />

Explicación: Al tener los tres objetos un Rigidbody dinámico estos responden a la gravedad y fuerzas. Si el plano tiene la gravedad activada, también puede moverse o caer, a diferencia de un plano estático sin Rigidbody o cinemático.

### Situación 5
<img width="1280" height="720" alt="Sit05" src="https://github.com/user-attachments/assets/7d9ca9db-3a2a-44ec-a893-38ea3c0e13fb" />

Explicación: La esfera, al tener más masa, suele sufrir una variación de velocidad menor (viéndose en la aceleración producida por una fuerza o en la respuesta durante una colisión), al igual que en el efecto que colisiona. El plano cinemático no cae ni se desplaza por efecto de la gravedad.

### Situación 6
<img width="1280" height="720" alt="Sit06" src="https://github.com/user-attachments/assets/a39863de-0e09-48d5-8bc7-97c229ffc28e" />

Explicación: El contraste con el cubo será mayor que en la situación 5 al igual que su reducción de velocidad.

### Situación 7
<img width="1280" height="720" alt="Sit07" src="https://github.com/user-attachments/assets/1bde12cb-b287-4368-9aa5-73b0006e435f" />

#### F-
<img width="1280" height="720" alt="Sit7F-" src="https://github.com/user-attachments/assets/acb7a359-21a8-4b1a-9229-830b1c73365b" />

#### F+
<img width="1280" height="720" alt="Sit7F+" src="https://github.com/user-attachments/assets/159c78ba-583e-4a32-ab66-d24ffea5e2bf" />

Explicación: La fricción afecta al deslizamiento de la esfera cuando está en contacto con el plano o con otros objetos, pudiendo reducir el deslizamiento y dificultar que el objeto comience a moverse.

### Situación 8
<img width="1280" height="720" alt="Sit08" src="https://github.com/user-attachments/assets/8587843f-b68b-46d1-9199-1ac444e86828" />

Explicación: Al tener el plano un Rigidbody cinemático este no se ve influenciado por al gravedad, al igual que con la esfera por tener un Collider que detecta solapamientos sin generar una respuesta de colisión sólida ("Is Trigger").

### Situación 9
<img width="1280" height="720" alt="Sit09" src="https://github.com/user-attachments/assets/a18d05de-96e2-4856-b7d5-d8206d23a9a6" />

Explicación: La esfera puede caer por gravedad y moverse como un cuerpo dinámico por su Rigidbody dinámico, pero su Collider configurado como Trigger no genera una colisión sólida al entrar en contacto con el cubo o el plano.

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
