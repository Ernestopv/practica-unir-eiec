# Actividad Grupal: Pull requests en GitHub - UNIR

# Integrantes del equipo 

JAVIER SILVA CERON 
ERNESTO PRADO VILLALOBOS 
EDUARDO GARCIA ESPESO 
JOSE VLADIMIR LEON HIGUERAS


# ASP.NET Core API - Aplicación de ejemplo

Esta es una aplicación API básica creada utilizando el template por defecto de ASP.NET Core en Visual Studio. Está diseñada para servir como punto de partida para el desarrollo de aplicaciones web modernas con .NET. Esta API sigue el patrón RESTful y proporciona una estructura básica para manejar peticiones HTTP como `GET`, `POST`, `PUT` y `DELETE`.

## Características

- **CRUD básico**: Soporte para operaciones básicas de creación, lectura, actualización y eliminación (Create, Read, Update, Delete).
- **Controladores y rutas**: Implementación sencilla de controladores para manejar rutas HTTP.
- **Configuración de dependencias**: Configuración predeterminada de inyección de dependencias para servicios.
- **Documentación Swagger**: Incluye integración con Swagger para la autogeneración de documentación y pruebas de la API.

## Requisitos previos

Para ejecutar este proyecto, necesitarás tener instalado:

- **[Visual Studio 2022](https://visualstudio.microsoft.com/)** o superior con la carga de trabajo de desarrollo .NET
- **[.NET SDK 6.0](https://dotnet.microsoft.com/download/dotnet/6.0)**

## Estructura del proyecto

El proyecto generado sigue la estructura básica de una aplicación API con ASP.NET Core:
- **Controllers/WeatherForecastController.cs**: Ejemplo de un controlador que expone un endpoint GET para devolver información de clima ficticia.
- **Program.cs**: Punto de entrada de la aplicación, donde se configura la aplicación y el servidor web.
- **appsettings.json**: Archivo de configuración donde se pueden especificar opciones como la conexión a base de datos o configuraciones específicas de la aplicación.
- **launchSettings.json**: Configuraciones para el entorno de desarrollo, como las URLs y perfiles de lanzamiento.
