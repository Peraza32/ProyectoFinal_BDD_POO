# Sistema de gestión: vacunas COVID19

La aplicación de gestión busca apoyar al ministerio de Salud de El Salvador en llevar un mejor control en la asignación de citas y control de procesos de vacunación en el país, con dicho programa sería posible agilizar y obtener datos de análisis de cómo se está desarrollando el plan de vacunación y por ende ayudar en el objetivo de tener por lo menos 40,000 personas vacunadas cada día.

## Software utilizado

### Programas de desarrollo

* Windows 10
* Microsoft Visual Studio 19
* SQL Server 19
* Microsoft SQL server management studio 18

### Patrones de diseño utilizados

* __Model View Controller:__ se implementa como la arquitectura principal del software haciendo las separaciones entre el modelo (los datos y la lógica del programa), la vista (interfaces gráficas y entornos donde interactúa el usuario final) y el controlador (que responde a las acciones realizadas en la aplicación), cada una de estas partes está especificada en su respectiva carpeta con los archivos que componen dicho patrón de diseño. Se utiliza principalmente para separar responsabilidades en los objetos del proyecto, propiciando así código más fácil de depurar e igualmente poder delegar el desarrollo de la funcionalidad entre varios programadores teniendo la menor cantidad de conflictos. Así mismo el patrón mvc ayuda a la reutilización de código y a un mejor manejo de los datos en la aplicación.
* __Chain of responsability:__  se implementa creando una interfaz que sirva como base de funcionalidad en todos los nodos de la cadena (conocidos como handlers), de ahí se hereda una clase abstracta que a través de polimorfismo permita el encadenamiento y uso de muchos handlers en la cadena independientemente de su tipo, una vez planteado esto se implementan handlers concretos que llevan a cabo una tarea en específico de la cadena antes de continuar con la ejecución de los demás. El principal motivo de implementar este patrón es que facilita mucho el desarrollo de distintos validadores de los datos obtenidos en el programa, además de establecer un orden de ejecución y segmentar las funciones de validación, ayudando considerablemente el proceso de depuración, la escalabilidad de la aplicación (pues agregar nuevas validaciones únicamente implica crear un nuevo nodo en la cadena) y tener un mejor control del flujo de los datos.
* __Proxy:__  se implementa en las clases terminadas en proxy, creando una interfaz intermedia con el objeto a utilizar a través de herencia y composición dentro de esta nueva clase proxy; sirve para extender la funcionalidad de dos clases en específico: Login y Appointment (véase el diagrama UML de clases para más referencia). El principal motivo para utilizar este patrón es añadir lógica extra a las clases de login y citas permitiendo que estas se enfoquen más en tareas específicas y el proxy se encargue de algunas validaciones, consultas y registros, permitiendo un mejor manejo de los datos antes de enviarlos a otros forms, guardarlos en la base de datos, etc.

### Paquetes y librerías externas

* itext 7.1.15
* Microsoft.EntityFrameworkCore 5.0.7
* Microsoft.EntityFrameworkCore.Design 5.0.7
* Microsoft.EntityFrameworkCore.SqlServer 5.0.7
* Microsoft.EntityFrameworkCore.Tools 5.0.7
* OxyPlot.Core 2.0.0
* OxyPlot.WindowsForms 2.0.0

### Instalación

1. Ejecutar el [script](https://github.com/UCASV/proyecto-final-grupo4/blob/main/Proyecto%20BASES-POO%202021/Programaci%C3%B3n%20orientada%20a%20objetos/EN_Proyecto-Script-V1.2.sql) de la base de datos en sql server para crear las tablas necesarias y permitir una conexión desde la aplicación.
2. Ejecutar el instalador del programa y realizar los pasos correspondientes (si se instalará para todos los usuarios, ruta de los archivos de instalación, etc).
3. Iniciar el programa. Se recomienda consultar el [manual de usuario](https://github.com/UCASV/proyecto-final-grupo4/blob/main/Proyecto%20BASES-POO%202021/Programaci%C3%B3n%20orientada%20a%20objetos/Manual%20de%20usuario.pdf) para conocer su uso.

### [Manual de usuario](https://github.com/UCASV/proyecto-final-grupo4/blob/main/Proyecto%20BASES-POO%202021/Programaci%C3%B3n%20orientada%20a%20objetos/Manual%20de%20usuario.pdf)
