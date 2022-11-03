/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primerP;

import java.rmi.RemoteException;

/**
 *
 * @author Usuario
 */
public interface IBanco12 {
    public boolean retirar(int idcliente,int monto)throws RemoteException;
    public boolean abandonar(int idcliente,int monto)throws RemoteException;
}
