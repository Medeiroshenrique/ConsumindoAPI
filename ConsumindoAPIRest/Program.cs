using System;
using System.Threading.Tasks;
using Refit;

namespace ConsumindoAPIRest
{
    public class Program
            {
                public static async Task Main(string[] args)
                {
                    try
                    {
                        var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Digite o CEP para consulta:");
                        Console.ResetColor();
                
                        string cepColsulted = Console.ReadLine().ToString();

                        var address = await cepClient.GetAddressAsync(cepColsulted);
                        if(address.Logradouro==null){
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERRO DURANTE CONSULTA: CEP Inválido!");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"CEP: {address.CEP}");
                            Console.WriteLine($"Logradouro: {address.Logradouro}");
                            Console.WriteLine($"Complemtento: {address.Complemtento}");
                            Console.WriteLine($"Bairro: {address.Bairro}");
                            Console.WriteLine($"Localidade: {address.Localidade}");
                            Console.WriteLine($"UF: {address.Uf}");
                            Console.WriteLine($"IBGE: {address.IBGE}");
                            Console.WriteLine($"GIA: {address.GIA}");
                            Console.WriteLine($"DDD: {address.DDD}");
                            Console.WriteLine($"SIAFI: {address.SIAFI}");
                            Console.ResetColor();
                        }
                    }
                    catch(Exception e)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"ERRO DURANTE CONSULTA -> {e.Message} ");
                        Console.ResetColor();
                    }
                }
            }
}


