# Sistema de gestión: vacunas COVID19

## Software utilizado

### Programas de desarrollo

* Windows 10
* Microsoft Visual Studio 19
* SQL Server 19
* Microsoft SQL server management studio 18

### Patrones de diseño utilizados

* __Chain of responsability:__  se implementa a través de distintos handlers que sirven como nodos de la cadena de responsabilidad (estos se pueden encontrar en la carpeta Handlers dentro de Controller en los archivos del proyecto). El principal motivo de implementar este patrón es que facilita mucho el desarrollo de distintos validadores de los datos obtenidos en el programa, además de establecer un orden de ejecución y segmentar las funciones de validación, ayudando considerablemente el proceso de depuración, la escalabilidad de la aplicación (pues agregar nuevas validaciones únicamente implica crear un nuevo nodo en la cadena) y tener un mejor control del flujo de los datos.
* __Proxy:__  se implementa en las clases terminadas en proxy, creando una interfaz intermedia con el objeto a utilizar y sirve para extender la funcionalidad de dos clases en específico: Login y Appointment (véase el diagrama UML de clases para más referencia). El principal motivo para utilizar este patrón es añadir lógica extra a las clases de login y citas permitiendo que estas se enfoquen más en tareas específicas y el proxy se encargue de algunas validaciones, consultas y registros, permitiendo un mejor manejo de los datos antes de enviarlos a otros forms, guardarlos en la base de datos, etc.

### Paquetes y librerías externas

* itext 7.1.15
* Microsoft.EntityFrameworkCore 5.0.7
* Microsoft.EntityFrameworkCore.Design 5.0.7
* Microsoft.EntityFrameworkCore.SqlServer 5.0.7
* Microsoft.EntityFrameworkCore.Tools 5.0.7
* OxyPlot.Core 2.0.0
* OxyPlot.WindowsForms 2.0.0

### Instalación
