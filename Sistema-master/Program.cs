namespace Sistema{
    class Program{
static void Main(string[] args)
        {
            List<PessoaFisica> listaPf = new List<PessoaFisica>();


            Console.Clear();

            void BarraCarregamento(string textoCarregamento, string icone){
                Console.WriteLine(textoCarregamento);
                Thread.Sleep(500);
                for (var contador = 0; contador < 10; contador++)
                {
                Console.Write(icone);
                Thread.Sleep(500);
                }

            }


            Console.ForegroundColor = ConsoleColor.Cyan;
           // Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(@$"
===================================================================
|                                                                 |
|  Bem vindo ao sistema de cadastro de pessoa fisica e juridica   |
|                                                                 |
===================================================================");
BarraCarregamento("Iniciando",".");
BarraCarregamento("Procurando a solução do seu problema","@");

string oqueocaradigitounoteclado;

do{
     Console.WriteLine(@$"
==================================================================
|                   Escolha uma das opções abaixo                |
==================================================================
|                      Pessoa Física                             |
|                 1- Cadastrar Pessoa Fisica                     |
|                 2 - Listar Pessoa Fisica                       |
|                 3 - Remover Pessoa Fisica                      |
|                                                                |
|                  Pessoa Juridica                               |
|                 1- Cadastrar Pessoa Juridica                   |
|                 2 - Listar Pessoa Juridica                     |
|                 3 - Remover Pessoa Juridica                    |
|                 0 - Sair                                       |    
==================================================================");

    oqueocaradigitounoteclado = Console.ReadLine();

    switch (oqueocaradigitounoteclado)
    {
        case "1":
        /*
        Endereco banana = new Endereco();
        Console.WriteLine ($"Digite seu logradouro");
        banana.logradouro = Console.ReadLine();

        Console.WriteLine ("Digite o numero da sua residencia");
        banana.numero = int.Parse(Console.ReadLine());

        Console.WriteLine ("Digite o complemento (Aperte enter para vazio)");
        banana.complemento = Console.ReadLine();

        Console.WriteLine("Este endereço é comercial? S/N");
        string oqueeledigitou = Console.ReadLine().ToUpper();

        if(oqueeledigitou == "S"){
            banana.enderecoComercial = true;
        } else{
            banana.enderecoComercial = false;
        }
        */

       // banana.logradouro = "Rua X";
       // banana.numero = 100;
       // banana.complemento = "Perto do senai";
       // banana.enderecoComercial = true;

        PessoaFisica novapf = new PessoaFisica();

        //novapf.Endereco = banana;
                     Console.WriteLine($"Digite seu CPF (somente números");
                        novapf.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite seu nome");
                        novapf.Nome = Console.ReadLine();
                        
                        //Console.WriteLine($"Digite o valor do seu rendimento mensal");
                       // novapf.rendimento = float.Parse(Console.ReadLine());
                        
                       // Console.WriteLine($"Digite sua data de nascimento");
                       // novapf.dataNasc = DateTime.Parse(Console.ReadLine());


        
/*
        Console.WriteLine(novapf.Endereco.logradouro);
        Console.WriteLine(novapf.Endereco.numero);
        Console.WriteLine(novapf.Endereco.complemento);
        Console.WriteLine(novapf.Endereco.enderecoComercial);
       Console.WriteLine(novapf.Nome);
        Console.WriteLine(novapf.cpf);
        Console.WriteLine(novapf.dataNasc);
        double ImpostoPago = novapf.PagarImposto(2000);
        Console.WriteLine($"Ele vai pagar {ImpostoPago} reais de imposto");

        */

        bool idadeValidada = novapf.ValidarDataNascimento(novapf.dataNasc);

            if (idadeValidada == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                Seu Cadastro Foi Aprovado                            *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("***********************************************************************");
                listaPf.Add(novapf);
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("***********************************************************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("* Seu Cadastro Foi Reprovado Por Motivos de Idade Minima Não Atingida *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("***********************************************************************");
                Console.ResetColor();
            }
        
       // StreamWriter sw = new StreamWriter($"{novapf.Nome}.txt");
       // sw.WriteLine(novapf.Nome);
       // sw.WriteLine(novapf.cpf);
       // sw.Close();

       using (StreamWriter sw = new StreamWriter($"{novapf.Nome}.txt")){
        sw.WriteLine(novapf.Nome);
        sw.WriteLine(novapf.cpf);
        
       }



        break;





        case "2":
        //listar
       // foreach (var cadaItem in listaPf){
          //  Console.WriteLine ($"{cadaItem.cpf}, {cadaItem.Nome}");
       // }

    Console.WriteLine("Digite o nome da pessoa que deseja ler o cadastro");
    string nomedigitado = Console.ReadLine();



    using(StreamReader sr = new StreamReader ($"{nomedigitado}.txt")){
        string linha;
        while((linha =  sr.ReadLine()) != null){
            Console.WriteLine($"{linha}");
        }

    }
    Console.WriteLine("Aperte qualquuer tecla para continuar");
    Console.WriteLine();


        break;

        case "3":
        //remover
        Console.WriteLine("Digite o CPF que deseja remover (somente numeros)");
        string cpfProcurado = Console.ReadLine();

        PessoaFisica pessoaEncontrada = listaPf.Find(cadaItem => cadaItem.cpf == cpfProcurado);

        if (pessoaEncontrada != null){
            listaPf.Remove(pessoaEncontrada);
            Console.WriteLine("Cadastro removido");
            
        }else{
            Console.WriteLine("CPF não encontrado");

        }


         break;
        case "4":
        //cadastrar

        case "5":
         break; 
       

/*
        PessoaJuridica LC = new PessoaJuridica();
        LC.Endereco = endcom;
        LC.cnpj = "1235678990001";
        LC.razaoSocial = "Pessoa Juridica";

        double ImpostoPago2 = LC.PagarImposto(10000);
        Console.WriteLine($"Ele vai pagar {ImpostoPago2} reais de imposto");


       bool cnpjvalidado = LC.validarCNPJ(LC.cnpj);
       
       if(cnpjvalidado == true){
        Console.WriteLine("Verdadeiro - O CNPJ é valido");
       }else{
        Console.WriteLine("Falso - O CNPJ");
       }
        break;
*/
        case "0":
        Console.WriteLine("Obrigado por utilizar o nosso sistema... até a proxima.");
        BarraCarregamento("Fechando o sistema",".");
        Console.ResetColor();
        break;
        default:
        Console.WriteLine("Opção Invalida, digite uma das opções apresentadas acima.");
        break;
    }
}while(oqueocaradigitounoteclado != "0");


/*case "2":
        Endereco endcom = new Endereco();
        endcom.logradouro = "Rua X";
        endcom.numero = 100;
        endcom.complemento = "Perto do senai";
        endcom.enderecoComercial = true;



            
            /*
        Endereco banana = new Endereco();
        banana.logradouro = "Rua X";
        banana.numero = 100;
        banana.complemento = "Perto do senai";
        banana.enderecoComercial = true;

        Endereco jabuticaba = new Endereco();
        jabuticaba.logradouro = "Rua niteroi";
        jabuticaba.numero = 180;

        PessoaJuridica Paralelepipedo = new PessoaJuridica();
        Paralelepipedo.cnpj = "1618716187";

        PessoaJuridica LC = new PessoaJuridica();
        LC.endereco = banana;
        LC.cnpj = "1235678990001";
        LC.razaoSocial = "Pessoa Juridica";

       bool cnpjvalidado = LC.validarCNPJ(LC.cnpj);
       
       if(cnpjvalidado == true){
        Console.WriteLine("Verdadeiro - O CNPJ é valido");
       }else{
        Console.WriteLine("Falso - O CNPJ");
       }

       // PessoaFisica Lucas = new PessoaFisica();
       // Lucas.endereco = end;
       // Lucas.cpf = "12345678";
       // Lucas.dataNasc = new DateTime (2010, 01, 19, 04,30,58);
      //  Lucas.Nome = "Lucas Schiaffino";

        //Console.WriteLine(Lucas.endereco.logradouro);
        //Console.WriteLine(Lucas.endereco.numero);
        //Console.WriteLine(Lucas.endereco.complemento);
        //Console.WriteLine(Lucas.endereco.enderecoComercial);
       // Console.WriteLine(Lucas.Nome);
        //Console.WriteLine(Lucas.cpf);
        //Console.WriteLine(Lucas.dataNasc);

// O _ , cujo cpf é _ e faz aniversario no dia _ mora na __ numero __ 
        //concatenação
    //Console.WriteLine("O " + Lucas.Nome + ", cujo CPF é " + Lucas.cpf + " e nasceu no dia " + Lucas.dataNasc + " mora na " + Lucas.endereco.logradouro + " numero " + Lucas.endereco.numero );

//interpolação
    //Console.WriteLine($"O {Lucas.Nome}, cujo CPF é {Lucas.cpf} e faz aniversario no dia {Lucas.dataNasc} mora na {Lucas.endereco.logradouro} numero {Lucas.endereco.numero}"); 

            //Console.WriteLine(Lucas.ValidarDataNascimento(Lucas.dataNasc));
           // bool idadeValidada = Lucas.ValidarDataNascimento(Lucas.dataNasc);
          //  Console.WriteLine(idadeValidada);
        
            if (idadeValidada == true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("*************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                Seu Cadastro Foi Aprovado                            *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*************************");
                Console.ResetColor();
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*************************");
                Console.WriteLine("*                SENAI - Cadastro de Pessoas                          *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("* Seu Cadastro Foi Reprovado Por Motivos de Idade Minima Não Atingida *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*************************");
                Console.ResetColor();
            }
*/
        }   
    }
}
