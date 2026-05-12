# Ahorcado
Un juego sencillo escrito en C#

## Violaciones de SOLID identificadas en la clase GOD
| Situación | Principio violado |
|---|---|
| `Juego` controla turnos, dibuja el tablero, muestra mensajes y elige la palabra | SRP (Single Responsibility Principle)|
| Las palabras están hardcodeadas dentro del constructor | DIP (Dependency Inversion Principle) |
| Para agregar un segundo juego habría que modificar `Juego` directamente | OCP (Open/Closed Principle) |
