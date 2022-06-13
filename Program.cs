var arr = new int [3];

try
{
    for (var index = 0; index < 10; index++)
    {
        // System.IndexOutOfRangeException
        Console.WriteLine(arr[index]);
    }
    Cadastrar("");
}
catch (IndexOutOfRangeException ex) // Mostra erro específico.
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Não encontrei o indice na lista!");
}

catch (ArgumentNullException ex) // Aqui você recebe as infotrmações do erro.
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Falha ao cadastar texto!");
}

catch (Exception ex) // Aqui você recebe as infotrmações do erro mais generico
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Ops, algo deu errado!");
}

finally // Sempre vai passar pelo finally.
{
    Console.WriteLine("Chegou ao fim!");
}

static void Cadastrar(string texto)
{
    if (string.IsNullOrEmpty(texto))
    {
        // throw new Exception("O texto não pode ser nul ou vazio!");
        throw new ArgumentNullException("O texto não pode ser nul ou vazio!");
    }
}
