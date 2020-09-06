
## Ejercicios de aplicación de Expert y SRP

Facultad de Ingeniería y Tecnologías
Programación II
Conway's Game of Life
John Conway fue un matemático inglés muy conocido por sus aportes matemáticos en diversas áreas, pero lo que realmente lo hizo famoso fue su creación lúdica: juego de la vida.



El juego de la vida consiste en un autómata celular con unas pocas reglas muy simples. El universo es una grilla ortogonal de dos dimensiones, donde cada espacio de la grilla representa una única célula. Cada célula puede estar viva o muerta. Cada una de estas células tendra 8 vecinos. En cada iteración del tiempo (generación) una célula estará viva o muerta según la cantidad de vecinos vivos o muertos que tenga. Siguiendo estas reglas:

Una célula viva con menos de 2 vecinos vivos muere, por soledad.
Una célula viva con 2 o 3 vecinos vivos sobrevive a la siguiente generación.
Una célula viva con más de 3 vecinos vivos muere, por sobrepoblación.
Una célula muerta con exactamente 3 vecinos vivos se convierte en una célula viva, por reproducción

Parte 1

Como tributo a Conway hoy vamos a crear este juego en consola! Para ello te vamos a proveer de varios code snippets y será tu trabajo asignarlos a la clase correcta cumpliendo con Expert y SRP.

El objetivo será desarrollar este juego mediante objetos diferentes, cada uno con una resposnabilidad única (SRP). El tablero deberá ser cargado a partir de un archivo de texto y luego el avance del juego deberá ser impreso en pantalla mediante consola.

Debes tener en cuenta que hoy se pide que el juego se lea desde un archivo y se imprima en consola, pero mañana podremos pedirles que se lea de una fuente diferente y se muestre en pantalla por otro medio 😉

# Recuerda agregar comentarios a todas tus clases indicando si cumplen o no con SRP y Expert. Deberás justificar adecuadamente por que crees que cumple o no.