# TpFinalEstructuraDeDatos
Proyecto de streaming usando C#

Trabajo Practico grupal para la materia Estructura de datos de la carrera de Analisis de Sistemas. Profesor: Santoro.

Detalle de los métodos usados para el trabajo practico que simula una pagina de streaming para ver peliculas y series:

-Se utilizo el método switch para ejecutar la funciones necesarias dependiendo la opción elegida del menú.

-En la opción 1 del menú, correspondiente al registro y inicio de sesión.

Para el registro se ingresa por consola la variables user y pass.

-En el inicio de sesión se pide usuario y contraseña y esos datos se comparan mediante un IF con lo ingresado en el registro para poder ingresar a la aplicación.

-Tambien se utilizo un bucle Do While una vez que se registra e inicia sesion para saber si vuelve al menu principal o sale de la plataforma.

-En la opción 2 (favoritos) se utiliza el método cola para ingresas las películas favoritas, y se usa un bucle do while para dar un parámetro para el ingreso de películas, se utiliza el foreach para revisar lo ingresado en las cola y después imprimirlo.

-En la opción 3 (historial de películas) se utiliza el método pila para guardar las películas vistas, despues se utiliza un foreach para revisar la pila y imprimir su contenido.

-En la opción 4 (sugerencias) muestra las sugerencias guardas en una pila, despues se imprime utilizando un foreach para ver su contenido.

-En la opcion 5 se sale de la plataforma.
