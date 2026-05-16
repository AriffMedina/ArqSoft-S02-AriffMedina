## 👨‍💻 Información del Estudiante

- **Nombre:** Ariff Medina
- **Matrícula:** SW2509006
- **Grupo:** A
- **Cuatrimestre:** Tercer Cuatrimestre
- **Carrera:** TSU en Desarrollo e Innovación de Software
- **Profesor:** Jorge Javier Pedrozo Romero

# Ahorcado
Un juego sencillo escrito en C#

## Violaciones de SOLID identificadas en la clase GOD
| Situación | Principio violado |
|---|---|
| `Juego` controla turnos, dibuja el tablero, muestra mensajes y elige la palabra | SRP (Single Responsibility Principle)|
| Las palabras están hardcodeadas dentro del constructor | DIP (Dependency Inversion Principle) |
| Para agregar un segundo juego habría que modificar `Juego` directamente | OCP (Open/Closed Principle) |

---

## 📋 Descripción del Proyecto

Este proyecto consiste en el desarrollo de un juego de ahorcado ejecutado en consola, donde el usuario debe adivinar una palabra letra por letra antes de agotar el número máximo de intentos permitidos. El programa incluye validación de entradas, control de errores, categorias y una interfaz simple basada en texto para brindar una experiencia interactiva dentro de la terminal.

Además, el repositorio cuenta con una branch adicional dedicada a la integración de el juego de la viborita, desarrollado como una extensión del proyecto principal para explorar nuevas mecánicas y funcionalidades dentro del entorno de consola.

---

### 🛠️ Tecnologías Utilizadas

- **Backend:** ASP.NET Core 10.0 (C#)
- **Arquitectura:** MVC (Model-View-Controller)
- **Herramientas:** Visual Studio 2022, Git

---

## 🤝 Agradecimientos

- **Profesor Jorge Javier Pedrozo Romero** por la estructura del curso y la práctica
- **Tecnológico de Software** por la formación integral

---

## 📧 Contacto

- **Email Institucional:** ariff.medina@tecdesoftware.edu.mx
- **GitHub:** [AriffMedina](https://github.com/AriffMedina)

---

## 📄 Licencia

Este proyecto fue desarrollado por **Ariff Medina** como parte de las prácticas académicas para el **Tecnológico de Software**.

Distribuido bajo la Licencia MIT. Siéntete libre de utilizar la arquitectura del código y el diseño de la interfaz para fines educativos o proyectos personales, siempre y cuando se mantenga el reconocimiento al autor original.

---

## 🤖 Declaración de Uso de IA

Declaro que la elaboración de este trabajo fue realizada de manera autónoma y personal, sin el uso de herramientas de inteligencia artificial generativa para el desarrollo o creación del contenido presentado.

---

<div align="center">

**⭐ Si te gustó este proyecto, dale una estrella ⭐**

Hecho con 💙 por Ariff Medina — 2026

</div>

