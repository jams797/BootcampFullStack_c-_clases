// See https://aka.ms/new-console-template for more information
using clase1.Helpers;
using Consola2.Bll;


Console.WriteLine($"Cantidad de personas: {MethodsHelper.listPerson.Count()}");

TransactionPersonBll transactionPersonBll = new TransactionPersonBll();
transactionPersonBll.Menu();

Console.WriteLine($"Cantidad de personas: {MethodsHelper.listPerson.Count()}");