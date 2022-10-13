/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tarea3;

import java.io.IOException;
import java.net.DatagramPacket;
import java.net.DatagramSocket;
import java.net.SocketException;
import java.nio.charset.StandardCharsets;
import java.util.Base64;

/**
 *
 * Escribir un programa en java para  calcular el factorial de un numero en un ambiente cliente servidor utilizando soquetes
 * UDP, el cliente envía un numero y recibe su factorial, vuelve  a mandar otro numero y el servidor le calcula el factorial,
 * hasta que el cliente envía el numero 0 y todo termina
 */
public class ServerUDP {
    static String facto(int num){
        int aux = 1;
        for(int i = 1; i <= num; i++){
            aux *= i;
        }
        return String.valueOf(aux);
    }
    
    
  public static void main (String args[]) { 
    int port=6589;  
    try {
      
        DatagramSocket socketUDP = new DatagramSocket(port);
        byte[] bufer = new byte[1000];

        while (true) {
          // Construimos el DatagramPacket para recibir peticiones
            DatagramPacket peticion = new DatagramPacket(bufer, bufer.length);

            // Leemos una petición del DatagramSocket
            socketUDP.receive(peticion);
            

            String str = new String(peticion.getData(), 0, peticion.getLength());
            //String str = Base64.getEncoder().encodeToString(peticion.getData());
            
            System.out.println(str);
            int x = Integer.parseInt(str);
            //System.out.println(Integer.valueOf(str));
            
            String r = facto(x);
            byte[] mensaje = r.getBytes();
            //System.out.print("Datagrama recibido del host: " + peticion.getAddress());
            //System.out.println(" desde el puerto remoto: " + peticion.getPort());

            // Construimos el DatagramPacket para enviar la respuesta
            DatagramPacket respuesta = new DatagramPacket(mensaje, mensaje.length,
                                 peticion.getAddress(), peticion.getPort());

            // Enviamos la respuesta, que es un eco
            socketUDP.send(respuesta);
      }

    } catch (SocketException e) {
      System.out.println("Socket: " + e.getMessage());
    } catch (IOException e) {
      System.out.println("IO: " + e.getMessage());
    }
  }

}

    

