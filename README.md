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
