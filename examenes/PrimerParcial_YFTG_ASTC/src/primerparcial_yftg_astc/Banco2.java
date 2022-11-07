/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package primerparcial_yftg_astc;


import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;

/*
        * BANCO: 2   
        * Idcliente    4         
        * Saldo        40      
*/

public class Banco2 extends UnicastRemoteObject implements IBanco2 {
    public Banco2() throws RemoteException {
        super();
    }

    @Override
    public boolean retirar(String idCliente, float monto) throws RemoteException {
        if (idCliente.equals("4") && monto <= 40) {
            return true;
        } else {
            return false;
        }
    }

    @Override
    public boolean abonar(String idCliente, float monto) throws RemoteException {
        if (idCliente.equals("4")) {
            return true;
        } else {
            return false;
        }
    }


}
