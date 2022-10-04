package tarea1;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintStream;
import java.net.ServerSocket;
import java.net.Socket;

public class ServidorTCP {

    static String Inversa(String cadena) {
        int tamano = cadena.length();
        String[] caden = cadena.split("");
        String result = "";
        for (int i = tamano - 1; i >= 0; i--) {
            result += caden[i];
        }
        return result;
    }

    public static void main(String[] args) {
        int port = 5002;
        try {
            ServerSocket server = new ServerSocket(port);
            Socket client;
            PrintStream toClient;
            client = server.accept(); //conexion
            BufferedReader fromClient = new BufferedReader(new InputStreamReader(client.getInputStream())); // el lector
            toClient = new PrintStream(client.getOutputStream());
            String x = fromClient.readLine();
            toClient.println(Inversa(x));
            

        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
}
