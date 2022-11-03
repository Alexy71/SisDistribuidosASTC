/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package primerP;

import java.rmi.Naming;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

/**
 *
 * @author Usuario
 */
public class OperacionPlataforma extends UnicastRemoteObject implements IPlataforma{
     public OperacionPlataforma() throws RemoteException {
        super();
    }
    @Override
    public boolean realizarTransaccion(int idcliente, int idvendedor, int monto, int moneda) throws RemoteException {
       boolean aux = true;
        if(idcliente == 1 && idvendedor == 1){
            aux = true;
       }
        else if(idcliente == 3 && idvendedor == 1){
            aux = true;
       }
        else if(idcliente == 4 && idvendedor == 2){
            aux = true;
       }
        else if(idcliente == 2 && idvendedor == 3){
            aux = true;
       }else{aux = false;}
        
       return aux;
    }

   
    
}
