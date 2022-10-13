package tarea3;

import java.net.*;
import java.io.*;
import java.util.Scanner;

/**
 *
 * Escribir un programa en java para calcular el factorial de un numero en un
 * ambiente cliente servidor utilizando soquetes UDP, el cliente envía un numero
 * y recibe su factorial, vuelve a mandar otro numero y el servidor le calcula
 * el factorial, hasta que el cliente envía el numero 0 y todo termina
 */
public class ClientUDP {

    public static void main(String args[]) {
        int puerto = 6589;
        boolean aux = true;
        Scanner sc = new Scanner(System.in);
        try {
             while (aux == true){
                System.out.println("Introduzca un numero");
                String dato = sc.next();
                if ("0".equals(dato)) {
                    System.out.print("FIN :3 ");
                    aux = false;
                } else {
                    DatagramSocket socketUDP = new DatagramSocket();
                    byte[] mensaje = dato.getBytes();
                    InetAddress hostServidor = InetAddress.getByName("localhost");

                    // Construimos un datagrama para enviar el mensaje al servidor
                    DatagramPacket peticion = new DatagramPacket(mensaje, dato.length(), hostServidor, puerto);

                    // Enviamos el datagrama
                    socketUDP.send(peticion);

                    // Construimos el DatagramPacket que contendrá la respuesta
                    byte[] bufer = new byte[1000];
                    DatagramPacket respuesta = new DatagramPacket(bufer, bufer.length);
                    socketUDP.receive(respuesta);
                    // Enviamos la respuesta del servidor a la salida estandar
                    System.out.println("Factorial de: " + dato + ": " + new String(respuesta.getData()));

                    // Cerramos el socket
                    socketUDP.close();
                }
            }
            System.out.println("Ejecucion finalizada");
        } catch (SocketException e) {
            System.out.println("Socket: " + e.getMessage());
        } catch (IOException e) {
            System.out.println("IO: " + e.getMessage());
        }
    }
}
