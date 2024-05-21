using System.Dynamic;
using System.Security.Cryptography.X509Certificates;

namespace proyectoCalculadora;
class Calculadora
{
    private double dato;
    public double resultado{get=>dato;}
    public void Sumar(double termino){
        dato += termino;
     }
    public void Restar(double termino){
        dato-=termino;
     }
    public void Multiplicar(double termino){
        dato *=termino;
     }
    public void Dividir(double termino){
        dato /= termino;
     }
    public void Limpiar(){
        dato=0;
    }
}