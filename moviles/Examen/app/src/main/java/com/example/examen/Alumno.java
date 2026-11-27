package com.example.examen;

import java.io.Serializable;
import java.util.List;
import java.util.Map;

/*
 * Clase Modelo (POJO) que representa a un jugador del torneo Six Nations.
 * Implementa Serializable para permitir que el objeto pueda convertirse
 * en flujo de bytes/datos si se necesita pasar entre pantallas o guardar.
 */
public class Alumno implements Serializable {
    private String nombre;
    private String DNI;
    private int fotoId; // número identificador que Android le asigna en la clase R (ej. R.drawable.escocia)
    private Map notas; // número identificador que Android le asigna en la clase R (ej. R.drawable.escocia)

    // Constructor: obliga a crear el jugador con todos sus datos iniciales
    public Alumno (String nombre, String DNI, int fotoId) {
        this.nombre = nombre;
        this.DNI = DNI;
        this.fotoId = fotoId;


    }

    // Métodos Getters y Setters: permiten leer y modificar los datos desde MainActivity y el Adapter
    public String getNombre() { return nombre; }
    public void setNombre(String nombre) { this.nombre = nombre; }

    public String getNacionalidad() { return DNI; }
    public void setNacionalidad(String DNI) { this.DNI = DNI; }

    public int getPuntuacion() { return puntuacion; }
    public void setPuntuacion(int puntuacion) { this.puntuacion = puntuacion; }

    public Map getnotaMedia() { return notas; }
    public void setBanderaResId(int banderaResId) { this.notas = notas; }
}
