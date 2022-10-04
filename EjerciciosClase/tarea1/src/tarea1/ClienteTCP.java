package tarea1;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.PrintStream;
import java.net.Socket;
import java.util.Objects;
import java.util.Scanner;

public class ClienteTCP {
    public static void main(String[] args) {
        int port = 5002;
        Scanner entradaEscaner = new Scanner (System.in);
        
        try {
            while (true) {                
                System.out.println("Ingrese una cadena: ");
                String cadena = entradaEscaner.nextLine();

                Socket client = new Socket("localhost", port);//instancia
                PrintStream toServer = new PrintStream(client.getOutputStream());//instancia         
                BufferedReader fromServer = new BufferedReader(new InputStreamReader(client.getInputStream()));//instancia

                toServer.println(cadena);
                String x = fromServer.readLine();
            
                if(x.equals("finalizar")){
                    break;
                }else
                    System.out.println(x);                
           }
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
}