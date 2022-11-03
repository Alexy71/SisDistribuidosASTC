/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primerP;

import java.rmi.Remote;
import java.rmi.RemoteException;

/**
 *
 * @author Usuario
 */
public interface IPlataforma extends Remote {
    public boolean realizarTransaccion(int idcliente,int idvendedor,int monto,int moneda)throws RemoteException;
}
