# Program-Quiz 📝💻

Sistema de escritorio desarrollado en **C# (.NET)** bajo una arquitectura en capas, diseñado para la gestión, administración y realización de cuestionarios y evaluaciones de programación.

---

## 🏗️ Arquitectura del Proyecto

La solución (`Program-Quiz.sln`) está estructurada siguiendo el patrón de **Arquitectura en N-Capas**, lo que permite separar responsabilidades, facilitar el mantenimiento y escalar el sistema:

```text
Program-Quiz/
├── Common/          # Clases transversales, caché de sesión de usuario y utilidades compartidas.
├── DataAccess/      # Capa de acceso a datos (conexión a BD, ejecución de consultas y procedimientos).
├── Domain/          # Capa de lógica de negocio, modelos, validaciones y reglas del sistema.
├── Presentation/    # Capa de interfaz gráfica de usuario (Formularios Windows Forms).
└── Program-Quiz.sln # Archivo de solución principal de Visual Studio.
```

### Descripción de las Capas
* **Presentation (`Presentation`):** Contiene los formularios e interfaces visuales con las que interactúan los usuarios (inicio de sesión, paneles de administración, resolución de cuestionarios y visualización de resultados).
* **Domain (`Domain`):** Actúa como puente entre la interfaz y los datos. Valida las reglas de negocio antes de enviar o recibir información de la base de datos.
* **DataAccess (`DataAccess`):** Gestiona la conexión directa con el motor de base de datos, encapsulando las operaciones CRUD y consultas SQL.
* **Common (`Common`):** Almacena estructuras y datos compartidos entre todas las capas, como la información del usuario autenticado en sesión y constantes del sistema.

---

## 🛠️ Tecnologías Utilizadas

* **Lenguaje:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Arquitectura:** Programación Orientada a Objetos (POO) y Diseño en Capas
* **Control de Versiones:** Git & GitHub

---

## 🚀 Instalación y Ejecución

### Requisitos Previos
* Sistema operativo Windows.
* [Visual Studio 2019 / 2022](https://visualstudio.microsoft.com/) (con la carga de trabajo *Desarrollo de escritorio de .NET*) o **Visual Studio Code** con MSBuild configurado.
* Motor de base de datos compatible (SQL Server / MySQL según la cadena de conexión configurada).

### Pasos para ejecutar el proyecto
1. **Clonar el repositorio:**
   ```bash
   git clone [https://github.com/TheRolo2001/ProgramQuiz.git](https://github.com/TheRolo2001/ProgramQuiz.git)
   ```
2. **Abrir la solución:**
   * Haz doble clic en el archivo `Program-Quiz.sln` para abrirlo en Visual Studio.
3. **Restaurar paquetes NuGet:**
   * En Visual Studio, haz clic derecho sobre la solución en el *Explorador de soluciones* y selecciona **Restaurar paquetes NuGet**.
4. **Configurar la Base de Datos:**
   * Abre el archivo `App.config` dentro del proyecto `Presentation`.
   * Actualiza la cadena de conexión (`connectionString`) con los datos de tu servidor local.
5. **Compilar y ejecutar:**
   * Asegúrate de que `Presentation` esté establecido como **Proyecto de inicio** (*Set as Startup Project*).
   * Presiona `F5` o haz clic en **Iniciar** para ejecutar la aplicación.

---

## 👤 Autor

* **TheRolo2001** – [Perfil de GitHub](https://github.com/TheRolo2001)
