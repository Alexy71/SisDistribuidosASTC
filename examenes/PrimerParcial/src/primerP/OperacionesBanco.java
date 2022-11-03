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
public class OperacionesBanco implements IBanco12 {

    @Override
    public boolean retirar(int idcliente, int monto) throws RemoteException {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }

    @Override
    public boolean abandonar(int idcliente, int monto) throws RemoteException {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }   
}
