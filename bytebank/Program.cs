using bytebank.Contas;
using bytebank.Titular;

//ContaCorrente contaCaiera = new ContaCorrente();
//contaCaiera.titular = "Caio de Paula";
//contaCaiera.numeroAgc = 30;
//contaCaiera.conta = "1010-X";
//contaCaiera.saldo = 500;
//Console.WriteLine("Saldo da conta do Caiera = " + contaCaiera.saldo + " reais.");

//ContaCorrente contaCaiera2 = new ContaCorrente();
//contaCaiera2.titular = "Caio de Paula";
//contaCaiera2.numeroAgc = 30;
//contaCaiera2.conta = "1010-X";
//contaCaiera2.saldo = 500;
//Console.WriteLine("Saldo da conta do Caiera = " + contaCaiera2.saldo + " reais.");

//contaCaiera2 = contaCaiera;
//Console.WriteLine(contaCaiera == contaCaiera2);

//ContaCorrente contaMaria = new ContaCorrente();
//contaMaria.titular = "Maria Vera";
//contaMaria.numeroAgc = 22;
//contaMaria.conta = "1111-2";
//contaMaria.saldo = 10000;

//Console.WriteLine("Saldo da conta da Maria = " + contaMaria.saldo + " reais.");

//contaCaiera.Transferir(50, contaMaria);
//Console.WriteLine("Saldo da conta do Caiera = " + contaCaiera.saldo + " reais.");
//Console.WriteLine("Saldo da conta da Maria = " + contaMaria.saldo + " reais.");

//contaCaiera.Depositar(1000);
//Console.WriteLine("Saldo da conta do Caiera pós-depósito da Nike = " + contaCaiera.saldo + " reais.");

//if(contaCaiera.Sacar(150) == true)
//{
//    Console.WriteLine("Saldo da conta do Caiera pós-saque = " + contaCaiera.saldo + " reais.");
//}
//else
//{
//    Console.WriteLine("Saldo Insuficiente para saque.");
//}

// aplicando valor padrão
//ContaCorrente ContaZe = new ContaCorrente();
//ContaZe.titular = "José Almeida Jr.";
//Console.WriteLine(ContaZe.titular);
//Console.WriteLine(ContaZe.saldo);
//Console.WriteLine(ContaZe.numeroAgc);
//Console.WriteLine(ContaZe.conta);

//Tipagem (tipos) por valor
//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor == valor2);
//Console.WriteLine(valor);
//Console.WriteLine(valor2);

//Cliente cliente = new Cliente();
//cliente.nome = "Caio de Paula";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista de Dados";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numeroAgc = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissão = " + conta.titular.profissao);
//Console.WriteLine("Nº Conta = " + conta.conta);
//Console.WriteLine("Saldo= " + conta.saldo);
//Console.WriteLine("Nº Agência = " + conta.numeroAgc);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "José Souza";
//conta2.titular.cpf = "987654321";
//conta2.titular.profissao = "QA";
//conta2.conta = "1111-Y";
//conta2.numeroAgc = 22;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);
//Console.WriteLine(conta2.titular.cpf);
//Console.WriteLine(conta2.conta);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.Numero_Agencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(50000);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.Numero_Agencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(800);
//conta4.Titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_Agencia);

ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9985-Y");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

ContaCorrente conta7 = new ContaCorrente(284, "4321-R");
Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
