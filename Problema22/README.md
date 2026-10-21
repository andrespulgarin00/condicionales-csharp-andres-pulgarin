# Problema 22. Calculadora básica

**Estructura elegida:** switch expression con `when` y throw

**Justificación:** Cada operador es un valor exacto; `when` separa la división por cero y `throw` en la rama `_` lanza la excepción de operador no soportado.

**Evidencia:**

![Salida](evidencias/salida.png)
