Conta c1 = new Conta(1);
Conta c2 = new Conta(2);

Console.WriteLine("O código da conta é: {0}", c1.Codigo);

c1.Depositar(1000.00);
c1.Sacar(200.00);
Console.WriteLine("O saldo da conta {0} é: {1}", c1.Codigo, c1.Saldo);

c2.Depositar(200.00);
c2.Sacar(150.00);
Console.WriteLine("O saldo atual da conta {0} é: {1}", c2.Codigo, c2.Saldo);

c1.Transferir(375.00, c2);

Console.WriteLine("\nO saldo atual da conta {0} é: {1}", c2.Codigo, c2.Saldo);

Console.WriteLine("O saldo atual da conta {0} é: {1}", c1.Codigo, c1.Saldo);

