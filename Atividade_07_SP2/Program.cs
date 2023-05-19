﻿using Atividade_07_SP2;

internal class Program {
    private static void Main(string[] args) {

        float val_pag;
        Console.WriteLine("Informar Nome");
        string var_nome = Console.ReadLine();
        Console.WriteLine("Informar Endereço");
        string var_endereco = Console.ReadLine();
        Console.WriteLine("Pessoa Física (PF) ou Jurídica (PJ) ?");
        string var_tipo = Console.ReadLine();
        if (var_tipo == "PF") {
            // --- Pessoa Física ----
            PessoaFisica pf = new PessoaFisica();
            pf.nome = var_nome;
            pf.endereco = var_endereco;
            Console.WriteLine("Informar CPF:");
            pf.cpf = Console.ReadLine();
            Console.WriteLine("Informar RG:");
            pf.rg = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pf.PagarImposto(val_pag);
            Console.WriteLine("-------- Pessoa Física ---------");
            Console.WriteLine("Nome ..........: " + pf.nome);
            Console.WriteLine("Endereço ......: " + pf.endereco);
            Console.WriteLine("CPF ...........: " + pf.cpf);
            Console.WriteLine("RG ............: " + pf.rg);
            Console.WriteLine("Valor de Compra: " + pf.valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + pf.valorImposto.ToString("C"));
            Console.WriteLine("Total a Pagar : " + pf.total.ToString("C"));
        }
        if (var_tipo == "PJ") {
            // Pessoa Jurídica
            PessoaJuridica pj = new PessoaJuridica();
            pj.nome = var_nome;
            pj.endereco = var_endereco;
            Console.WriteLine("Informar CNPJ:");
            pj.cnpj = Console.ReadLine();
            Console.WriteLine("Informar IE:");
            pj.ie = Console.ReadLine();
            Console.WriteLine("Informar Valor de Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pj.PagarImposto(val_pag);
            Console.WriteLine("-------- Pessoa Jurídica ---------");
            Console.WriteLine("Nome ..........: " + pj.nome);
            Console.WriteLine("Endereço ......: " + pj.endereco);
            Console.WriteLine("CNPJ ..........: " + pj.cnpj);
            Console.WriteLine("IE ............: " + pj.ie);
            Console.WriteLine("Valor de Compra: " + pj.valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + pj.valorImposto.ToString("C"));
            Console.WriteLine("Total a Pagar : " + pj.total.ToString("C"));
        }

    }
}