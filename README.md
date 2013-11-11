PostsharpExample
================

Ejemplo de programación orientada a aspectos con postsharp.

En este laboratorio voy a hacer algunas pruebas con Postsharp que es un framework para utilizar 
programación orientada a Aspectos (AOP en inglés). Para .Net hay varios pero este me ha parecido
muy sencillo de aplicar, habria que probar otros igualmente.

La programación orientada a aspectos tiene como objetivo eliminar el código repetido que hay en una 
aplicación como es la toma de tiempos, temas de seguridad, logs, traza de excepciones, auditorias
y que no pertenece a ninguna capa en especial como de negocio o dominio , ni capa de datos.
Es algo que aplica a todas las capas del proyecto y se le conoce como código trasversal o cross-cutting.

A parte de para lo típico que se utiliza AOP que nos vendria muy bien para modularizar temas de logging, cache, seguridad. 
Creo que es muy interesante para almacenar las acciones que realiza el usuario, pensando en el brain, de una forma
bastante estándar.

Al final consiste en atributos de .net a los que Postsharp le añade funcionalidad muy interesante.

Postsharp se puede descargar mediante NuGet y tiene una version de prueba , una gratis con limitaciones,
y dos de pago, o de su página web http://www.postsharp.net/

Una vez descargada aparece un asistente y tienes que elegir la versión que quieres y si es la gratis te 
redirecciona a la web para que registres y te envian una clave al correo.


Conclusión del laboratorio
--------------------------

La programación orientada a aspectos es una técnica muy interesante para que empecemos a utilizar en buyoo.
El código queda muy limpio en tareas muy comunes y se elimina código duplicado.
En cuanto al framework Postsharp es muy sencillo de utilizar.
Lo que menos me gusta de este framework es que la clave es solo para un ordenador, yo me he registrado con la misma en dos ordenadores pero 
es un proceso que hay que hacer manualmente y no es algo tran trasparente como con otras librerias que se añaden desde NuGet.
También tendríamos que ver como se registra esta dll para pre y pro
