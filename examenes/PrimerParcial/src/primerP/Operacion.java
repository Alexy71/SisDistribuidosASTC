/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package primerP;

import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

/**
 *
 * @author Carlos
 */
public class Operacion extends UnicastRemoteObject implements ISitioComercio{

    public Operacion() throws RemoteException {
        super();
    }

    @Override
    public int datos(int cliente) throws RemoteException {
        int aux = 1;
        return 1;
    }
 
}
