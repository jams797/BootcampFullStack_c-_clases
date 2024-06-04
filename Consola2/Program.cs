// See https://aka.ms/new-console-template for more information
using Consola2.Helpers;
using Consola2.Bll;
using Consola2.Models;


Console.WriteLine($"Cantidad de personas: {MethodsHelper.listPerson.Count()}");

MenuBll menuBll = new MenuBll();
menuBll.Menu();


Console.WriteLine($"Cantidad de personas: {MethodsHelper.listPerson.Count()}");