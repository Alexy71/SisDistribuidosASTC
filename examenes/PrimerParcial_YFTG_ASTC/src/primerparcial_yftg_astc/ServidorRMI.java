/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package primerparcial_yftg_astc;

import java.net.MalformedURLException;
import java.rmi.AlreadyBoundException;
import java.rmi.Naming;
import java.rmi.RemoteException;
import java.util.logging.Level;
import java.util.logging.Logger;

public class ServidorRMI {
    public static void main(String[] args) {
        try {
            PlataformaIntercambio emisor;
            emisor = new PlataformaIntercambio();
            Naming.bind("PIntercambio", emisor);
            System.out.println("\nServidor PLATAFORMA de INTERCAMBIO listo\n");
        } catch (RemoteException | AlreadyBoundException | MalformedURLException ex) {
            Logger.getLogger(ServidorRMI.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}

