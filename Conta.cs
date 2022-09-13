using System;

namespace ControleBancario
{
    class Conta
    {
       private String _cliente;
      private  Double _saldo;

      public Conta(String nome_cliente, Double saldo_cliente)
      {
          this.cliente = nome_cliente;
          this.saldo = saldo_cliente;
      }

      public String cliente
      {
          get {return this._cliente;}
          set {this._cliente = value;}
      }

      public Double saldo
      {
          get {return this._saldo;}
          set {this._saldo = value;}
      }

      public Double Sacar(Double valor)
      {
          if (valor>this.saldo){
              Console.WriteLine("O saldo Atual é: " +this.saldo+ " Portanto não há saldo suficiente para o Saque Solicitado!");
              Console.ReadKey();
          }else{
              this.saldo -= valor;
          }
          return this.saldo;
      }

      public Double Depositar(Double valor)
      {
          this.saldo += valor;
          return this.saldo;
      }
    }
}