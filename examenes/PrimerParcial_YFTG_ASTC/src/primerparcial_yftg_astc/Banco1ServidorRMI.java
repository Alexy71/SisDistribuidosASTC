/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package primerparcial_yftg_astc;

import java.rmi.AlreadyBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.Registry;
import java.util.logging.Level;
import java.util.logging.Logger;

public class Banco1ServidorRMI {
    public static void main(String[] args) {
        try {
            Registry registro = java.rmi.registry.LocateRegistry.createRegistry(1099); 
            registro.bind("Banco1", new Banco1()); 
            System.out.println("\nServidor Banco 1 listo");
        } catch (RemoteException | AlreadyBoundException ex) {
            Logger.getLogger(Banco1ServidorRMI.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
}
